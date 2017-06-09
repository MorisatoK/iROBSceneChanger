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

        private TelemetryInfo telemetry;
        private bool oldIsOnTrack;
        private bool obsWsConnected;

        public iROBSceneChangerForm()
        {
            InitializeComponent();
            this.Text = Application.ProductName + " " + Application.ProductVersion;

            // Create a new instance of the SdkWrapper object
            wrapper = new SdkWrapper();

            // Set some properties
            wrapper.EventRaiseType = SdkWrapper.EventRaiseTypes.CurrentThread;
            wrapper.TelemetryUpdateFrequency = 1;

            // Listen for various iRacing events
            wrapper.Connected += wrapper_Connected;
            wrapper.Disconnected += wrapper_Disconnected;
            wrapper.TelemetryUpdated += wrapper_TelemetryUpdated;

            // Save OnTrack state
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

        private void wrapper_TelemetryUpdated(object sender, SdkWrapper.TelemetryUpdatedEventArgs e)
        {
            telemetry = e.TelemetryInfo;

            if (telemetry.IsOnTrack.Value == oldIsOnTrack)
                return;

            ChangeScene();
            oldIsOnTrack = telemetry.IsOnTrack.Value;
        }

        #endregion

        #region OBS stuff
        private void ChangeScene()
        {
            if (!obsWsConnected || telemetry == null)
                return;

            if (telemetry.IsOnTrack.Value)
                obs.SetCurrentScene(inCarSceneTextBox.Text);
            else
                obs.SetCurrentScene(inGarageSceneTextBox.Text);
        }

        private void onSceneChange(OBSWebsocket sender, string newSceneName)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                OBSStatus.Text = newSceneName;
            });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            OBSStatus.Image = Resources.waiting;

            if (string.IsNullOrEmpty(inCarSceneTextBox.Text) || string.IsNullOrEmpty(inGarageSceneTextBox.Text))
            {
                MessageBox.Show("You must provide OBS scenes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                OBSStatus.Image = Resources.disconnected;
                return;
            }

            try
            {
                obs.Connect(txtServerIP.Text, txtServerPassword.Text);
            }
            catch (AuthFailureException)
            {
                MessageBox.Show("Authentication failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                OBSStatus.Image = Resources.disconnected;
                return;
            }
            catch (ErrorResponseException ex)
            {
                MessageBox.Show("Connect failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                OBSStatus.Image = Resources.disconnected;
                return;
            }

            var sceneNames = new[] { inCarSceneTextBox.Text, inGarageSceneTextBox.Text };
            var scenesFound = obs.ListScenes().Where(s => sceneNames.Contains(s.Name));

            if (scenesFound.Count() < 2)
            {
                obs.Disconnect();
                OBSStatus.Image = Resources.disconnected;
                MessageBox.Show("Provided OBS scenes not found in scene collection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            obsWsConnected = true;
            btnConnect.Enabled = false;
            txtServerIP.Enabled = false;
            txtServerPassword.Enabled = false;
            inCarSceneTextBox.Enabled = false;
            inGarageSceneTextBox.Enabled = false;
            OBSStatus.Image = Resources.connected;
            OBSStatus.Text = obs.GetCurrentScene().Name;
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
