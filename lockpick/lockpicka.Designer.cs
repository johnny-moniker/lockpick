namespace lockpick
{
    partial class frmLockpicka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLockpicka));
            this.btnSubmitPWChange = new System.Windows.Forms.Button();
            this.lblServerPath = new System.Windows.Forms.Label();
            this.lblServerUsername = new System.Windows.Forms.Label();
            this.lblServerPassword = new System.Windows.Forms.Label();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.chkboxConnection = new System.Windows.Forms.CheckBox();
            this.txtServerPath = new System.Windows.Forms.TextBox();
            this.txtServerUserID = new System.Windows.Forms.TextBox();
            this.txtServerPassword = new System.Windows.Forms.TextBox();
            this.txtInitialCatalog = new System.Windows.Forms.TextBox();
            this.txtFullConnection = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblASPEmal = new System.Windows.Forms.Label();
            this.txtASPMemberPass = new System.Windows.Forms.TextBox();
            this.txtASPMember = new System.Windows.Forms.TextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.gbServerStatus = new System.Windows.Forms.GroupBox();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.gbServerStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmitPWChange
            // 
            this.btnSubmitPWChange.Enabled = false;
            this.btnSubmitPWChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitPWChange.Location = new System.Drawing.Point(179, 300);
            this.btnSubmitPWChange.Name = "btnSubmitPWChange";
            this.btnSubmitPWChange.Size = new System.Drawing.Size(165, 28);
            this.btnSubmitPWChange.TabIndex = 9;
            this.btnSubmitPWChange.Text = "change password";
            this.btnSubmitPWChange.UseVisualStyleBackColor = true;
            this.btnSubmitPWChange.Click += new System.EventHandler(this.btnClickForm);
            // 
            // lblServerPath
            // 
            this.lblServerPath.AutoSize = true;
            this.lblServerPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerPath.Location = new System.Drawing.Point(87, 55);
            this.lblServerPath.Name = "lblServerPath";
            this.lblServerPath.Size = new System.Drawing.Size(85, 18);
            this.lblServerPath.TabIndex = 0;
            this.lblServerPath.Text = "Server Path";
            // 
            // lblServerUsername
            // 
            this.lblServerUsername.AutoSize = true;
            this.lblServerUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerUsername.Location = new System.Drawing.Point(47, 84);
            this.lblServerUsername.Name = "lblServerUsername";
            this.lblServerUsername.Size = new System.Drawing.Size(124, 18);
            this.lblServerUsername.TabIndex = 0;
            this.lblServerUsername.Text = "Server Username";
            // 
            // lblServerPassword
            // 
            this.lblServerPassword.AutoSize = true;
            this.lblServerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerPassword.Location = new System.Drawing.Point(50, 116);
            this.lblServerPassword.Name = "lblServerPassword";
            this.lblServerPassword.Size = new System.Drawing.Size(122, 18);
            this.lblServerPassword.TabIndex = 0;
            this.lblServerPassword.Text = "Server Password";
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseName.Location = new System.Drawing.Point(53, 146);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(115, 18);
            this.lblDatabaseName.TabIndex = 0;
            this.lblDatabaseName.Text = "Database Name";
            // 
            // chkboxConnection
            // 
            this.chkboxConnection.AutoSize = true;
            this.chkboxConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxConnection.Location = new System.Drawing.Point(23, 17);
            this.chkboxConnection.Name = "chkboxConnection";
            this.chkboxConnection.Size = new System.Drawing.Size(148, 17);
            this.chkboxConnection.TabIndex = 1;
            this.chkboxConnection.Text = "use connection string";
            this.chkboxConnection.UseVisualStyleBackColor = true;
            this.chkboxConnection.CheckedChanged += new System.EventHandler(this.chkboxConnection_CheckedChanged);
            // 
            // txtServerPath
            // 
            this.txtServerPath.Location = new System.Drawing.Point(179, 55);
            this.txtServerPath.Name = "txtServerPath";
            this.txtServerPath.Size = new System.Drawing.Size(165, 20);
            this.txtServerPath.TabIndex = 3;
            // 
            // txtServerUserID
            // 
            this.txtServerUserID.Location = new System.Drawing.Point(178, 85);
            this.txtServerUserID.Name = "txtServerUserID";
            this.txtServerUserID.Size = new System.Drawing.Size(165, 20);
            this.txtServerUserID.TabIndex = 4;
            // 
            // txtServerPassword
            // 
            this.txtServerPassword.Location = new System.Drawing.Point(178, 114);
            this.txtServerPassword.Name = "txtServerPassword";
            this.txtServerPassword.Size = new System.Drawing.Size(165, 20);
            this.txtServerPassword.TabIndex = 5;
            // 
            // txtInitialCatalog
            // 
            this.txtInitialCatalog.Location = new System.Drawing.Point(178, 146);
            this.txtInitialCatalog.Name = "txtInitialCatalog";
            this.txtInitialCatalog.Size = new System.Drawing.Size(165, 20);
            this.txtInitialCatalog.TabIndex = 6;
            // 
            // txtFullConnection
            // 
            this.txtFullConnection.Enabled = false;
            this.txtFullConnection.Location = new System.Drawing.Point(178, 14);
            this.txtFullConnection.Name = "txtFullConnection";
            this.txtFullConnection.Size = new System.Drawing.Size(368, 20);
            this.txtFullConnection.TabIndex = 2;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Enabled = false;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(56, 262);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(109, 18);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "New Password";
            // 
            // lblASPEmal
            // 
            this.lblASPEmal.AutoSize = true;
            this.lblASPEmal.Enabled = false;
            this.lblASPEmal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblASPEmal.Location = new System.Drawing.Point(2, 227);
            this.lblASPEmal.Name = "lblASPEmal";
            this.lblASPEmal.Size = new System.Drawing.Size(164, 18);
            this.lblASPEmal.TabIndex = 0;
            this.lblASPEmal.Text = "ASP Membership Email";
            // 
            // txtASPMemberPass
            // 
            this.txtASPMemberPass.Enabled = false;
            this.txtASPMemberPass.Location = new System.Drawing.Point(178, 262);
            this.txtASPMemberPass.Name = "txtASPMemberPass";
            this.txtASPMemberPass.Size = new System.Drawing.Size(165, 20);
            this.txtASPMemberPass.TabIndex = 8;
            // 
            // txtASPMember
            // 
            this.txtASPMember.Enabled = false;
            this.txtASPMember.Location = new System.Drawing.Point(178, 228);
            this.txtASPMember.Name = "txtASPMember";
            this.txtASPMember.Size = new System.Drawing.Size(165, 20);
            this.txtASPMember.TabIndex = 7;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConnection.Location = new System.Drawing.Point(91, 86);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(92, 22);
            this.btnTestConnection.TabIndex = 15;
            this.btnTestConnection.TabStop = false;
            this.btnTestConnection.Text = "test connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnClickForm);
            // 
            // gbServerStatus
            // 
            this.gbServerStatus.Controls.Add(this.lblServerStatus);
            this.gbServerStatus.Controls.Add(this.btnTestConnection);
            this.gbServerStatus.Location = new System.Drawing.Point(357, 50);
            this.gbServerStatus.Name = "gbServerStatus";
            this.gbServerStatus.Size = new System.Drawing.Size(189, 114);
            this.gbServerStatus.TabIndex = 16;
            this.gbServerStatus.TabStop = false;
            this.gbServerStatus.Text = "server status";
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.Location = new System.Drawing.Point(6, 34);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(75, 13);
            this.lblServerStatus.TabIndex = 0;
            this.lblServerStatus.Text = "no connection";
            // 
            // frmLockpicka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 335);
            this.Controls.Add(this.gbServerStatus);
            this.Controls.Add(this.txtASPMember);
            this.Controls.Add(this.txtASPMemberPass);
            this.Controls.Add(this.lblASPEmal);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtFullConnection);
            this.Controls.Add(this.txtInitialCatalog);
            this.Controls.Add(this.txtServerPassword);
            this.Controls.Add(this.txtServerUserID);
            this.Controls.Add(this.txtServerPath);
            this.Controls.Add(this.chkboxConnection);
            this.Controls.Add(this.lblDatabaseName);
            this.Controls.Add(this.lblServerPassword);
            this.Controls.Add(this.lblServerUsername);
            this.Controls.Add(this.lblServerPath);
            this.Controls.Add(this.btnSubmitPWChange);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLockpicka";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Lockpickr";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmLockpicka_Load);
            this.gbServerStatus.ResumeLayout(false);
            this.gbServerStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitPWChange;
        private System.Windows.Forms.Label lblServerPath;
        private System.Windows.Forms.Label lblServerUsername;
        private System.Windows.Forms.Label lblServerPassword;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.CheckBox chkboxConnection;
        private System.Windows.Forms.TextBox txtServerPath;
        private System.Windows.Forms.TextBox txtServerUserID;
        private System.Windows.Forms.TextBox txtServerPassword;
        private System.Windows.Forms.TextBox txtInitialCatalog;
        private System.Windows.Forms.TextBox txtFullConnection;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblASPEmal;
        private System.Windows.Forms.TextBox txtASPMemberPass;
        private System.Windows.Forms.TextBox txtASPMember;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.GroupBox gbServerStatus;
        private System.Windows.Forms.Label lblServerStatus;
    }
}

