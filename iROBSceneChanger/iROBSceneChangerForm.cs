using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using iRacingSdkWrapper;
using OBSWebsocketDotNet;
using iROBSceneChanger.Properties;

namespace iROBSceneChanger
{
    public partial class iROBSceneChangerForm : Form
    {
        private SdkWrapper wrapper;
        private OBSWebsocket obs;

        private Driver me;
        private List<Driver> drivers;
        private bool isUpdatingDrivers;
        private bool oldIsOnTrack;
        private bool obsWsConnected;

        public iROBSceneChangerForm()
        {
            InitializeComponent();

            // Create a new instance of the SdkWrapper object
            wrapper = new SdkWrapper();

            // Set some properties
            wrapper.EventRaiseType = SdkWrapper.EventRaiseTypes.CurrentThread;
            wrapper.TelemetryUpdateFrequency = 1;

            // Listen for various iRacing events
            wrapper.Connected += wrapper_Connected;
            wrapper.Disconnected += wrapper_Disconnected;
            wrapper.SessionInfoUpdated += wrapper_SessionInfoUpdated;
            wrapper.TelemetryUpdated += wrapper_TelemetryUpdated;

            // Bind a list of drivers to the grid
            drivers = new List<Driver>();
            oldIsOnTrack = false;

            // Create a new instance of the OBSWebsocket object
            obs = new OBSWebsocket();
            obsWsConnected = false;

            // Listen for various OBS events
            obs.OnSceneChange += onSceneChange;

            wrapper.Start();
            StatusChanged();
        }

        #region Connecting, disconnecting, etc

        private void StatusChanged()
        {
            if (wrapper.IsConnected)
            {
                if (wrapper.IsRunning)
                {
                    iRStatus.Text = "Connected";
                    iRStatus.Image = Resources.connected;
                }
                else
                {
                    iRStatus.Text = "Disconnected";
                    iRStatus.Image = Resources.disconnected;
                }
            }
            else
            {
                if (wrapper.IsRunning)
                {
                    iRStatus.Text = "Disconnected, waiting for sim...";
                    iRStatus.Image = Resources.waiting;
                }
                else
                {
                    iRStatus.Text = "Disconnected";
                    iRStatus.Image = Resources.disconnected;
                }
            }
        }

        private void wrapper_Connected(object sender, EventArgs e)
        {
            StatusChanged();
        }

        private void wrapper_Disconnected(object sender, EventArgs e)
        {
            StatusChanged();
        }

        #endregion

        #region Events

        private void wrapper_SessionInfoUpdated(object sender, SdkWrapper.SessionInfoUpdatedEventArgs e)
        {
            // Indicate that we are updating the drivers list
            isUpdatingDrivers = true;

            // Parse the Drivers section of the session info into a list of drivers
            ParseDrivers(e.SessionInfo);

            // Indicate we are finished updating drivers
            isUpdatingDrivers = false;
        }

        private void wrapper_TelemetryUpdated(object sender, SdkWrapper.TelemetryUpdatedEventArgs e)
        {
            // Besides the driver details found in the session info, there's also things in the telemetry
            // that are properties of a driver, such as their lap, lap distance, track surface, distance relative
            // to yourself and more.
            // We update the existing list of drivers with the telemetry values here.

            // If we are currently renewing the drivers list it makes little sense to update the existing drivers
            // because they will change anyway
            if (isUpdatingDrivers) return;

            UpdateDriversTelemetry(e.TelemetryInfo);
            ChangeScene();
        }

        #endregion

        #region Drivers

        // Parse the YAML DriverInfo section that contains information such as driver id, name, license, car number, etc.
        private void ParseDrivers(SessionInfo sessionInfo)
        {
            int id = 0;
            Driver driver;

            var newDrivers = new List<Driver>();

            // Loop through drivers until none are found anymore
            do
            {
                driver = null;

                // Construct a yaml query that finds each driver and his info in the Session Info yaml string
                // This query can be re-used for every property for one driver (with the specified id)
                YamlQuery query = sessionInfo["DriverInfo"]["Drivers"]["CarIdx", id];

                // Try to get the UserName of the driver (because its the first value given)
                // If the UserName value is not found (name == null) then we found all drivers and we can stop
                string name = query["UserName"].GetValue();

                if (name != null)
                {
                    // Find this driver in the list
                    // This strange " => " syntax is called a lambda expression and is short for a loop through all drivers
                    // Read as: select the first driver 'd', if any, whose Name is equal to name.
                    driver = drivers.FirstOrDefault(d => d.Name == name);

                    if (driver == null)
                    {
                        // Or create a new Driver if we didn't find him before
                        driver = new Driver();
                        driver.Id = id;
                        driver.Name = name;
                        driver.CustomerId = int.Parse(query["UserID"].GetValue("0")); // default value 0
                    }
                    newDrivers.Add(driver);

                    id++;
                }
            } while (driver != null);

            // Replace old list of drivers with new list of drivers and update the grid
            drivers.Clear();
            drivers.AddRange(newDrivers);
        }

        private void UpdateDriversTelemetry(TelemetryInfo info)
        {
            // Get your own driver entry
            // This strange " => " syntax is called a lambda expression and is short for a loop through all drivers
            me = drivers.FirstOrDefault(d => d.Id == wrapper.DriverId);

            if (me == null)
                return;

            me.IsOnTrack = info.IsOnTrack.Value;
        }

        #endregion

        #region OBS stuff
        private void ChangeScene()
        {
            if (!obsWsConnected)
                return;

            if (me == null || me.IsOnTrack == oldIsOnTrack)
                return;

            if (me.IsOnTrack)
                obs.SetCurrentScene(inCarSceneTextBox.Text);
            else
                obs.SetCurrentScene(inGarageSceneTextBox.Text);

            oldIsOnTrack = me.IsOnTrack;
        }

        private void onSceneChange(OBSWebsocket sender, string newSceneName)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                currentSceneLabel.Text = "Current Scene: " + newSceneName;
            });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inCarSceneTextBox.Text) || string.IsNullOrEmpty(inGarageSceneTextBox.Text))
            {
                MessageBox.Show("You must provide OBS scenes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                obs.Connect(txtServerIP.Text, txtServerPassword.Text);
            }
            catch (AuthFailureException)
            {
                MessageBox.Show("Authentication failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            catch (ErrorResponseException ex)
            {
                MessageBox.Show("Connect failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var sceneNames = new[] { inCarSceneTextBox.Text, inGarageSceneTextBox.Text };
            var scenesFound = obs.ListScenes().Where(s => sceneNames.Contains(s.Name));

            if (scenesFound.Count() < 2)
            {
                obs.Disconnect();
                MessageBox.Show("Provided OBS scenes not found in scene collection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            btnConnect.Enabled = false;
            txtServerIP.Enabled = false;
            txtServerPassword.Enabled = false;
            inCarSceneTextBox.Enabled = false;
            inGarageSceneTextBox.Enabled = false;
            obsWsConnected = true;

            btnConnect.Text = "Connected";
            currentSceneLabel.Text = "Current Scene: " + obs.GetCurrentScene().Name;
        }
        #endregion

        private void iROBSceneChangerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            wrapper.Stop();
            obs.Disconnect();

            // Save settings
            Settings.Default.Save();
        }
    }
}
