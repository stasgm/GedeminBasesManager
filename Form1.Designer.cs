namespace GedeminBasesManager
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.gbFdb = new System.Windows.Forms.GroupBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUseCredentials = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbServerType = new System.Windows.Forms.ComboBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAssociate = new System.Windows.Forms.Button();
            this.btnSelectGedemin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGedeminPath = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.fbBk = new System.Windows.Forms.GroupBox();
            this.btnRemoveBackup = new System.Windows.Forms.Button();
            this.btnAssociateBackup = new System.Windows.Forms.Button();
            this.gbFdb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.fbBk.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFdb
            // 
            this.gbFdb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFdb.Controls.Add(this.tbPassword);
            this.gbFdb.Controls.Add(this.tbUsername);
            this.gbFdb.Controls.Add(this.label5);
            this.gbFdb.Controls.Add(this.label2);
            this.gbFdb.Controls.Add(this.cbUseCredentials);
            this.gbFdb.Controls.Add(this.label4);
            this.gbFdb.Controls.Add(this.cbServerType);
            this.gbFdb.Controls.Add(this.numPort);
            this.gbFdb.Controls.Add(this.label3);
            this.gbFdb.Controls.Add(this.tbServer);
            this.gbFdb.Controls.Add(this.btnRemove);
            this.gbFdb.Controls.Add(this.btnAssociate);
            this.gbFdb.Controls.Add(this.btnSelectGedemin);
            this.gbFdb.Controls.Add(this.label1);
            this.gbFdb.Controls.Add(this.tbGedeminPath);
            this.gbFdb.Location = new System.Drawing.Point(13, 6);
            this.gbFdb.Name = "gbFdb";
            this.gbFdb.Size = new System.Drawing.Size(364, 184);
            this.gbFdb.TabIndex = 0;
            this.gbFdb.TabStop = false;
            this.gbFdb.Text = "FDB association";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(246, 126);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(110, 20);
            this.tbPassword.TabIndex = 19;
            this.tbPassword.Text = "Administrator";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(72, 126);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(110, 20);
            this.tbUsername.TabIndex = 18;
            this.tbUsername.Text = "Administrator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username:";
            // 
            // cbUseCredentials
            // 
            this.cbUseCredentials.AutoSize = true;
            this.cbUseCredentials.Checked = true;
            this.cbUseCredentials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseCredentials.Location = new System.Drawing.Point(13, 107);
            this.cbUseCredentials.Name = "cbUseCredentials";
            this.cbUseCredentials.Size = new System.Drawing.Size(99, 17);
            this.cbUseCredentials.TabIndex = 15;
            this.cbUseCredentials.Text = "Use credentials";
            this.cbUseCredentials.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Server:";
            // 
            // cbServerType
            // 
            this.cbServerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServerType.FormattingEnabled = true;
            this.cbServerType.Items.AddRange(new object[] {
            "Default",
            "Embedded"});
            this.cbServerType.Location = new System.Drawing.Point(57, 74);
            this.cbServerType.Name = "cbServerType";
            this.cbServerType.Size = new System.Drawing.Size(75, 21);
            this.cbServerType.TabIndex = 13;
            this.cbServerType.SelectedIndexChanged += new System.EventHandler(this.CbServerType_SelectedIndexChanged);
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(299, 74);
            this.numPort.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(57, 20);
            this.numPort.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Port";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(141, 74);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(116, 20);
            this.tbServer.TabIndex = 8;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(89, 155);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnAssociate
            // 
            this.btnAssociate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAssociate.Location = new System.Drawing.Point(8, 155);
            this.btnAssociate.Name = "btnAssociate";
            this.btnAssociate.Size = new System.Drawing.Size(75, 23);
            this.btnAssociate.TabIndex = 5;
            this.btnAssociate.Text = "Associate";
            this.btnAssociate.UseVisualStyleBackColor = true;
            this.btnAssociate.Click += new System.EventHandler(this.BtnAssociate_Click);
            // 
            // btnSelectGedemin
            // 
            this.btnSelectGedemin.Location = new System.Drawing.Point(328, 44);
            this.btnSelectGedemin.Name = "btnSelectGedemin";
            this.btnSelectGedemin.Size = new System.Drawing.Size(28, 23);
            this.btnSelectGedemin.TabIndex = 2;
            this.btnSelectGedemin.Text = "...";
            this.btnSelectGedemin.UseVisualStyleBackColor = true;
            this.btnSelectGedemin.Click += new System.EventHandler(this.BtnSelectGedemin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "\'Gedemin.exe\' path";
            // 
            // tbGedeminPath
            // 
            this.tbGedeminPath.Location = new System.Drawing.Point(13, 45);
            this.tbGedeminPath.Name = "tbGedeminPath";
            this.tbGedeminPath.Size = new System.Drawing.Size(309, 20);
            this.tbGedeminPath.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(305, 261);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // fbBk
            // 
            this.fbBk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fbBk.Controls.Add(this.btnRemoveBackup);
            this.fbBk.Controls.Add(this.btnAssociateBackup);
            this.fbBk.Location = new System.Drawing.Point(13, 196);
            this.fbBk.Name = "fbBk";
            this.fbBk.Size = new System.Drawing.Size(364, 58);
            this.fbBk.TabIndex = 2;
            this.fbBk.TabStop = false;
            this.fbBk.Text = "BK association";
            // 
            // btnRemoveBackup
            // 
            this.btnRemoveBackup.Location = new System.Drawing.Point(89, 19);
            this.btnRemoveBackup.Name = "btnRemoveBackup";
            this.btnRemoveBackup.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveBackup.TabIndex = 11;
            this.btnRemoveBackup.Text = "Remove";
            this.btnRemoveBackup.UseVisualStyleBackColor = true;
            this.btnRemoveBackup.Click += new System.EventHandler(this.btnRemoveBackup_Click);
            // 
            // btnAssociateBackup
            // 
            this.btnAssociateBackup.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAssociateBackup.Location = new System.Drawing.Point(8, 19);
            this.btnAssociateBackup.Name = "btnAssociateBackup";
            this.btnAssociateBackup.Size = new System.Drawing.Size(75, 23);
            this.btnAssociateBackup.TabIndex = 10;
            this.btnAssociateBackup.Text = "Associate";
            this.btnAssociateBackup.UseVisualStyleBackColor = true;
            this.btnAssociateBackup.Click += new System.EventHandler(this.btnAssociateBackup_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 287);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbFdb);
            this.Controls.Add(this.fbBk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSettings_FormClosing);
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.gbFdb.ResumeLayout(false);
            this.gbFdb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.fbBk.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFdb;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox fbBk;
        private System.Windows.Forms.Button btnSelectGedemin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGedeminPath;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAssociate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbServerType;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbUseCredentials;
        private System.Windows.Forms.Button btnRemoveBackup;
        private System.Windows.Forms.Button btnAssociateBackup;
    }
}

