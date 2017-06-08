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
            this.iRGroupBox = new System.Windows.Forms.GroupBox();
            this.trackLabel = new System.Windows.Forms.Label();
            this.driverLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.OBSGroupBox = new System.Windows.Forms.GroupBox();
            this.inGarageSceneTextBox = new System.Windows.Forms.TextBox();
            this.inGarageLabel = new System.Windows.Forms.Label();
            this.inCarSceneTextBox = new System.Windows.Forms.TextBox();
            this.inCarLabel = new System.Windows.Forms.Label();
            this.currentSceneLabel = new System.Windows.Forms.Label();
            this.txtServerPasswordLabel = new System.Windows.Forms.Label();
            this.txtServerIPLabel = new System.Windows.Forms.Label();
            this.txtServerPassword = new System.Windows.Forms.TextBox();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.iRGroupBox.SuspendLayout();
            this.OBSGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // iRGroupBox
            // 
            this.iRGroupBox.Controls.Add(this.trackLabel);
            this.iRGroupBox.Controls.Add(this.driverLabel);
            this.iRGroupBox.Controls.Add(this.statusLabel);
            this.iRGroupBox.Location = new System.Drawing.Point(10, 10);
            this.iRGroupBox.Name = "iRGroupBox";
            this.iRGroupBox.Size = new System.Drawing.Size(320, 110);
            this.iRGroupBox.TabIndex = 17;
            this.iRGroupBox.TabStop = false;
            this.iRGroupBox.Text = "iRacing";
            // 
            // trackLabel
            // 
            this.trackLabel.AutoSize = true;
            this.trackLabel.Location = new System.Drawing.Point(10, 78);
            this.trackLabel.Name = "trackLabel";
            this.trackLabel.Size = new System.Drawing.Size(63, 13);
            this.trackLabel.TabIndex = 9;
            this.trackLabel.Text = "IsOnTrack: ";
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Location = new System.Drawing.Point(10, 49);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(41, 13);
            this.driverLabel.TabIndex = 8;
            this.driverLabel.Text = "Driver: ";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(10, 20);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 13);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Status: ";
            // 
            // OBSGroupBox
            // 
            this.OBSGroupBox.Controls.Add(this.inGarageSceneTextBox);
            this.OBSGroupBox.Controls.Add(this.inGarageLabel);
            this.OBSGroupBox.Controls.Add(this.inCarSceneTextBox);
            this.OBSGroupBox.Controls.Add(this.inCarLabel);
            this.OBSGroupBox.Controls.Add(this.currentSceneLabel);
            this.OBSGroupBox.Controls.Add(this.txtServerPasswordLabel);
            this.OBSGroupBox.Controls.Add(this.txtServerIPLabel);
            this.OBSGroupBox.Controls.Add(this.txtServerPassword);
            this.OBSGroupBox.Controls.Add(this.txtServerIP);
            this.OBSGroupBox.Controls.Add(this.btnConnect);
            this.OBSGroupBox.Location = new System.Drawing.Point(340, 10);
            this.OBSGroupBox.Name = "OBSGroupBox";
            this.OBSGroupBox.Size = new System.Drawing.Size(366, 110);
            this.OBSGroupBox.TabIndex = 18;
            this.OBSGroupBox.TabStop = false;
            this.OBSGroupBox.Text = "OBS Websocket";
            // 
            // inGarageSceneTextBox
            // 
            this.inGarageSceneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inGarageSceneTextBox.Location = new System.Drawing.Point(242, 46);
            this.inGarageSceneTextBox.Name = "inGarageSceneTextBox";
            this.inGarageSceneTextBox.Size = new System.Drawing.Size(110, 20);
            this.inGarageSceneTextBox.TabIndex = 23;
            this.inGarageSceneTextBox.Text = "InGame";
            // 
            // inGarageLabel
            // 
            this.inGarageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inGarageLabel.AutoSize = true;
            this.inGarageLabel.Location = new System.Drawing.Point(188, 49);
            this.inGarageLabel.Name = "inGarageLabel";
            this.inGarageLabel.Size = new System.Drawing.Size(45, 13);
            this.inGarageLabel.TabIndex = 22;
            this.inGarageLabel.Text = "Garage:";
            // 
            // inCarSceneTextBox
            // 
            this.inCarSceneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inCarSceneTextBox.Location = new System.Drawing.Point(64, 46);
            this.inCarSceneTextBox.Name = "inCarSceneTextBox";
            this.inCarSceneTextBox.Size = new System.Drawing.Size(110, 20);
            this.inCarSceneTextBox.TabIndex = 21;
            this.inCarSceneTextBox.Text = "Driving";
            // 
            // inCarLabel
            // 
            this.inCarLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inCarLabel.AutoSize = true;
            this.inCarLabel.Location = new System.Drawing.Point(10, 49);
            this.inCarLabel.Name = "inCarLabel";
            this.inCarLabel.Size = new System.Drawing.Size(38, 13);
            this.inCarLabel.TabIndex = 20;
            this.inCarLabel.Text = "In Car:";
            // 
            // currentSceneLabel
            // 
            this.currentSceneLabel.AutoSize = true;
            this.currentSceneLabel.Location = new System.Drawing.Point(133, 80);
            this.currentSceneLabel.Name = "currentSceneLabel";
            this.currentSceneLabel.Size = new System.Drawing.Size(0, 13);
            this.currentSceneLabel.TabIndex = 19;
            // 
            // txtServerPasswordLabel
            // 
            this.txtServerPasswordLabel.AutoSize = true;
            this.txtServerPasswordLabel.Location = new System.Drawing.Point(185, 20);
            this.txtServerPasswordLabel.Name = "txtServerPasswordLabel";
            this.txtServerPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.txtServerPasswordLabel.TabIndex = 18;
            this.txtServerPasswordLabel.Text = "Password:";
            // 
            // txtServerIPLabel
            // 
            this.txtServerIPLabel.AutoSize = true;
            this.txtServerIPLabel.Location = new System.Drawing.Point(10, 20);
            this.txtServerIPLabel.Name = "txtServerIPLabel";
            this.txtServerIPLabel.Size = new System.Drawing.Size(53, 13);
            this.txtServerIPLabel.TabIndex = 17;
            this.txtServerIPLabel.Text = "IP:PORT:";
            // 
            // txtServerPassword
            // 
            this.txtServerPassword.Location = new System.Drawing.Point(242, 16);
            this.txtServerPassword.Name = "txtServerPassword";
            this.txtServerPassword.Size = new System.Drawing.Size(110, 20);
            this.txtServerPassword.TabIndex = 16;
            this.txtServerPassword.Text = "bl4f4s3l";
            this.txtServerPassword.UseSystemPasswordChar = true;
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(64, 16);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(110, 20);
            this.txtServerIP.TabIndex = 15;
            this.txtServerIP.Text = "ws://127.0.0.1:4444";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(13, 75);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 23);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // iROBSceneChangerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 131);
            this.Controls.Add(this.OBSGroupBox);
            this.Controls.Add(this.iRGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "iROBSceneChangerForm";
            this.Text = "iROBSceneChanger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.iRGroupBox.ResumeLayout(false);
            this.iRGroupBox.PerformLayout();
            this.OBSGroupBox.ResumeLayout(false);
            this.OBSGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox iRGroupBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label trackLabel;
        private System.Windows.Forms.Label driverLabel;
        private System.Windows.Forms.GroupBox OBSGroupBox;
        private System.Windows.Forms.TextBox inGarageSceneTextBox;
        private System.Windows.Forms.Label inGarageLabel;
        private System.Windows.Forms.TextBox inCarSceneTextBox;
        private System.Windows.Forms.Label inCarLabel;
        private System.Windows.Forms.Label currentSceneLabel;
        private System.Windows.Forms.Label txtServerPasswordLabel;
        private System.Windows.Forms.Label txtServerIPLabel;
        private System.Windows.Forms.TextBox txtServerPassword;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Button btnConnect;
    }
}

