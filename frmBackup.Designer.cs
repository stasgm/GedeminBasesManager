namespace GedeminBasesManager
{
    partial class frmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup));
            this.label3 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.restoreDestBtn = new System.Windows.Forms.Button();
            this.restoreSrcBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.restoreDestBox = new System.Windows.Forms.TextBox();
            this.restoreSrcBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.openFileDiag = new System.Windows.Forms.OpenFileDialog();
            this.tbDBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLogOut = new System.Windows.Forms.TextBox();
            this.cbLog = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Firebird Credentials";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(95, 66);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(114, 20);
            this.passwordBox.TabIndex = 5;
            this.passwordBox.Text = "masterkey";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(95, 40);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(114, 20);
            this.usernameBox.TabIndex = 4;
            this.usernameBox.Text = "SYSDBA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Password:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Username:";
            // 
            // restoreDestBtn
            // 
            this.restoreDestBtn.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreDestBtn.Location = new System.Drawing.Point(366, 196);
            this.restoreDestBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.restoreDestBtn.Name = "restoreDestBtn";
            this.restoreDestBtn.Size = new System.Drawing.Size(26, 21);
            this.restoreDestBtn.TabIndex = 39;
            this.restoreDestBtn.Text = "…";
            this.restoreDestBtn.UseVisualStyleBackColor = true;
            this.restoreDestBtn.Click += new System.EventHandler(this.restoreDestBtn_Click);
            // 
            // restoreSrcBtn
            // 
            this.restoreSrcBtn.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreSrcBtn.Location = new System.Drawing.Point(366, 147);
            this.restoreSrcBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.restoreSrcBtn.Name = "restoreSrcBtn";
            this.restoreSrcBtn.Size = new System.Drawing.Size(26, 21);
            this.restoreSrcBtn.TabIndex = 38;
            this.restoreSrcBtn.Text = "…";
            this.restoreSrcBtn.UseVisualStyleBackColor = true;
            this.restoreSrcBtn.Click += new System.EventHandler(this.restoreSrcBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 22);
            this.label5.TabIndex = 37;
            this.label5.Text = "Restore backup";
            // 
            // restoreDestBox
            // 
            this.restoreDestBox.Location = new System.Drawing.Point(26, 195);
            this.restoreDestBox.Name = "restoreDestBox";
            this.restoreDestBox.Size = new System.Drawing.Size(334, 20);
            this.restoreDestBox.TabIndex = 2;
            this.restoreDestBox.Text = "c:\\database.fdb";
            // 
            // restoreSrcBox
            // 
            this.restoreSrcBox.Location = new System.Drawing.Point(26, 147);
            this.restoreSrcBox.Name = "restoreSrcBox";
            this.restoreSrcBox.Size = new System.Drawing.Size(334, 20);
            this.restoreSrcBox.TabIndex = 3;
            this.restoreSrcBox.Text = "c:\\database-backup.fbk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Destination:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Source:";
            // 
            // restoreBtn
            // 
            this.restoreBtn.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreBtn.Location = new System.Drawing.Point(289, 240);
            this.restoreBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(103, 27);
            this.restoreBtn.TabIndex = 1;
            this.restoreBtn.Text = "Restore backup";
            this.restoreBtn.UseVisualStyleBackColor = true;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // openFileDiag
            // 
            this.openFileDiag.Filter = "FDB files|*.fdb";
            // 
            // tbDBName
            // 
            this.tbDBName.Location = new System.Drawing.Point(26, 243);
            this.tbDBName.Name = "tbDBName";
            this.tbDBName.Size = new System.Drawing.Size(257, 20);
            this.tbDBName.TabIndex = 0;
            this.tbDBName.TextChanged += new System.EventHandler(this.tbDBName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Database name:";
            // 
            // tbLogOut
            // 
            this.tbLogOut.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogOut.Location = new System.Drawing.Point(398, 29);
            this.tbLogOut.Multiline = true;
            this.tbLogOut.Name = "tbLogOut";
            this.tbLogOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLogOut.Size = new System.Drawing.Size(412, 238);
            this.tbLogOut.TabIndex = 42;
            // 
            // cbLog
            // 
            this.cbLog.AutoSize = true;
            this.cbLog.Checked = true;
            this.cbLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLog.Location = new System.Drawing.Point(398, 6);
            this.cbLog.Name = "cbLog";
            this.cbLog.Size = new System.Drawing.Size(110, 17);
            this.cbLog.TabIndex = 43;
            this.cbLog.Text = "Show process log";
            this.cbLog.UseVisualStyleBackColor = true;
            // 
            // frmBackup
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 281);
            this.Controls.Add(this.cbLog);
            this.Controls.Add(this.tbLogOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDBName);
            this.Controls.Add(this.restoreDestBtn);
            this.Controls.Add(this.restoreSrcBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.restoreDestBox);
            this.Controls.Add(this.restoreSrcBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restore backup";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmBackup_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmBackup_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button restoreDestBtn;
        private System.Windows.Forms.Button restoreSrcBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox restoreDestBox;
        private System.Windows.Forms.TextBox restoreSrcBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button restoreBtn;
        private System.Windows.Forms.OpenFileDialog openFileDiag;
        private System.Windows.Forms.TextBox tbDBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLogOut;
        private System.Windows.Forms.CheckBox cbLog;
    }
}