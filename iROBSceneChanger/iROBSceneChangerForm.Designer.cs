namespace iROBSceneChanger
{
    partial class iROBSceneChangerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OBSConnectionGroupBox = new System.Windows.Forms.GroupBox();
            this.txtServerPasswordLabel = new System.Windows.Forms.Label();
            this.txtServerIPLabel = new System.Windows.Forms.Label();
            this.txtServerPassword = new System.Windows.Forms.TextBox();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.iRStatusIcon = new System.Windows.Forms.ToolStripStatusLabel();
            this.iRStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.versionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.OBSStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.OBSStatusIcon = new System.Windows.Forms.ToolStripStatusLabel();
            this.OBSScenesGroupBox = new System.Windows.Forms.GroupBox();
            this.inGarageSceneTextBox = new System.Windows.Forms.TextBox();
            this.inGarageLabel = new System.Windows.Forms.Label();
            this.inCarSceneTextBox = new System.Windows.Forms.TextBox();
            this.inCarLabel = new System.Windows.Forms.Label();
            this.OBSConnectionGroupBox.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.OBSScenesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OBSConnectionGroupBox
            // 
            this.OBSConnectionGroupBox.Controls.Add(this.txtServerPasswordLabel);
            this.OBSConnectionGroupBox.Controls.Add(this.txtServerIPLabel);
            this.OBSConnectionGroupBox.Controls.Add(this.txtServerPassword);
            this.OBSConnectionGroupBox.Controls.Add(this.txtServerIP);
            this.OBSConnectionGroupBox.Controls.Add(this.btnConnect);
            this.OBSConnectionGroupBox.Location = new System.Drawing.Point(10, 10);
            this.OBSConnectionGroupBox.Name = "OBSConnectionGroupBox";
            this.OBSConnectionGroupBox.Size = new System.Drawing.Size(210, 125);
            this.OBSConnectionGroupBox.TabIndex = 18;
            this.OBSConnectionGroupBox.TabStop = false;
            this.OBSConnectionGroupBox.Text = "OBS Websocket Server";
            // 
            // txtServerPasswordLabel
            // 
            this.txtServerPasswordLabel.AutoSize = true;
            this.txtServerPasswordLabel.Location = new System.Drawing.Point(10, 55);
            this.txtServerPasswordLabel.Name = "txtServerPasswordLabel";
            this.txtServerPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.txtServerPasswordLabel.TabIndex = 18;
            this.txtServerPasswordLabel.Text = "Password:";
            // 
            // txtServerIPLabel
            // 
            this.txtServerIPLabel.AutoSize = true;
            this.txtServerIPLabel.Location = new System.Drawing.Point(10, 25);
            this.txtServerIPLabel.Name = "txtServerIPLabel";
            this.txtServerIPLabel.Size = new System.Drawing.Size(53, 13);
            this.txtServerIPLabel.TabIndex = 17;
            this.txtServerIPLabel.Text = "IP:PORT:";
            // 
            // txtServerPassword
            // 
            this.txtServerPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::iROBSceneChanger.Properties.Settings.Default, "WsServerPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtServerPassword.Location = new System.Drawing.Point(85, 52);
            this.txtServerPassword.Name = "txtServerPassword";
            this.txtServerPassword.Size = new System.Drawing.Size(110, 20);
            this.txtServerPassword.TabIndex = 16;
            this.txtServerPassword.Text = global::iROBSceneChanger.Properties.Settings.Default.WsServerPassword;
            this.txtServerPassword.UseSystemPasswordChar = true;
            // 
            // txtServerIP
            // 
            this.txtServerIP.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::iROBSceneChanger.Properties.Settings.Default, "WsServer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtServerIP.Location = new System.Drawing.Point(85, 22);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(110, 20);
            this.txtServerIP.TabIndex = 15;
            this.txtServerIP.Text = global::iROBSceneChanger.Properties.Settings.Default.WsServer;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(10, 90);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 23);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iRStatusIcon,
            this.iRStatus,
            this.versionLabel,
            this.OBSStatus,
            this.OBSStatusIcon});
            this.statusStrip.Location = new System.Drawing.Point(0, 144);
            this.statusStrip.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(449, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 19;
            // 
            // iRStatusIcon
            // 
            this.iRStatusIcon.Image = global::iROBSceneChanger.Properties.Resources.iRacingSim;
            this.iRStatusIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iRStatusIcon.Margin = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.iRStatusIcon.Name = "iRStatusIcon";
            this.iRStatusIcon.Size = new System.Drawing.Size(16, 17);
            // 
            // iRStatus
            // 
            this.iRStatus.Image = global::iROBSceneChanger.Properties.Resources.disconnected;
            this.iRStatus.Name = "iRStatus";
            this.iRStatus.Size = new System.Drawing.Size(95, 17);
            this.iRStatus.Text = "Disconnected";
            // 
            // versionLabel
            // 
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(171, 17);
            this.versionLabel.Spring = true;
            // 
            // OBSStatus
            // 
            this.OBSStatus.Image = global::iROBSceneChanger.Properties.Resources.disconnected;
            this.OBSStatus.Name = "OBSStatus";
            this.OBSStatus.Size = new System.Drawing.Size(95, 17);
            this.OBSStatus.Text = "Disconnected";
            this.OBSStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // OBSStatusIcon
            // 
            this.OBSStatusIcon.Image = global::iROBSceneChanger.Properties.Resources.obs;
            this.OBSStatusIcon.Name = "OBSStatusIcon";
            this.OBSStatusIcon.Size = new System.Drawing.Size(16, 17);
            // 
            // OBSScenesGroupBox
            // 
            this.OBSScenesGroupBox.Controls.Add(this.inGarageSceneTextBox);
            this.OBSScenesGroupBox.Controls.Add(this.inGarageLabel);
            this.OBSScenesGroupBox.Controls.Add(this.inCarSceneTextBox);
            this.OBSScenesGroupBox.Controls.Add(this.inCarLabel);
            this.OBSScenesGroupBox.Location = new System.Drawing.Point(230, 10);
            this.OBSScenesGroupBox.Name = "OBSScenesGroupBox";
            this.OBSScenesGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.OBSScenesGroupBox.Size = new System.Drawing.Size(210, 125);
            this.OBSScenesGroupBox.TabIndex = 20;
            this.OBSScenesGroupBox.TabStop = false;
            this.OBSScenesGroupBox.Text = "OBS Scenes";
            // 
            // inGarageSceneTextBox
            // 
            this.inGarageSceneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::iROBSceneChanger.Properties.Settings.Default, "InGarageScene", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.inGarageSceneTextBox.Location = new System.Drawing.Point(85, 52);
            this.inGarageSceneTextBox.Name = "inGarageSceneTextBox";
            this.inGarageSceneTextBox.Size = new System.Drawing.Size(110, 20);
            this.inGarageSceneTextBox.TabIndex = 27;
            this.inGarageSceneTextBox.Text = global::iROBSceneChanger.Properties.Settings.Default.InGarageScene;
            // 
            // inGarageLabel
            // 
            this.inGarageLabel.AutoSize = true;
            this.inGarageLabel.Location = new System.Drawing.Point(10, 55);
            this.inGarageLabel.Name = "inGarageLabel";
            this.inGarageLabel.Size = new System.Drawing.Size(45, 13);
            this.inGarageLabel.TabIndex = 26;
            this.inGarageLabel.Text = "Garage:";
            // 
            // inCarSceneTextBox
            // 
            this.inCarSceneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::iROBSceneChanger.Properties.Settings.Default, "InCarScene", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.inCarSceneTextBox.Location = new System.Drawing.Point(85, 22);
            this.inCarSceneTextBox.Name = "inCarSceneTextBox";
            this.inCarSceneTextBox.Size = new System.Drawing.Size(110, 20);
            this.inCarSceneTextBox.TabIndex = 25;
            this.inCarSceneTextBox.Text = global::iROBSceneChanger.Properties.Settings.Default.InCarScene;
            // 
            // inCarLabel
            // 
            this.inCarLabel.AutoSize = true;
            this.inCarLabel.Location = new System.Drawing.Point(10, 25);
            this.inCarLabel.Name = "inCarLabel";
            this.inCarLabel.Size = new System.Drawing.Size(38, 13);
            this.inCarLabel.TabIndex = 24;
            this.inCarLabel.Text = "In Car:";
            // 
            // iROBSceneChangerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 166);
            this.Controls.Add(this.OBSScenesGroupBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.OBSConnectionGroupBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::iROBSceneChanger.Properties.Settings.Default, "WindowLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = global::iROBSceneChanger.Properties.Settings.Default.WindowLocation;
            this.Name = "iROBSceneChangerForm";
            this.Text = "iROBSceneChanger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.iROBSceneChangerForm_FormClosing);
            this.OBSConnectionGroupBox.ResumeLayout(false);
            this.OBSConnectionGroupBox.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.OBSScenesGroupBox.ResumeLayout(false);
            this.OBSScenesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox OBSConnectionGroupBox;
        private System.Windows.Forms.Label txtServerPasswordLabel;
        private System.Windows.Forms.Label txtServerIPLabel;
        private System.Windows.Forms.TextBox txtServerPassword;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel iRStatusIcon;
        private System.Windows.Forms.ToolStripStatusLabel iRStatus;
        private System.Windows.Forms.ToolStripStatusLabel versionLabel;
        private System.Windows.Forms.ToolStripStatusLabel OBSStatusIcon;
        private System.Windows.Forms.ToolStripStatusLabel OBSStatus;
        private System.Windows.Forms.GroupBox OBSScenesGroupBox;
        private System.Windows.Forms.TextBox inGarageSceneTextBox;
        private System.Windows.Forms.Label inGarageLabel;
        private System.Windows.Forms.TextBox inCarSceneTextBox;
        private System.Windows.Forms.Label inCarLabel;
    }
}

