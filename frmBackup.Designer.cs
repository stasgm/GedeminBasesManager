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
            this.btnPassword = new System.Windows.Forms.Button();
            this.cbIsDeleteBK = new System.Windows.Forms.CheckBox();
            this.cbIsResetPassword = new System.Windows.Forms.CheckBox();
            this.btnDeleteBK = new System.Windows.Forms.Button();
            this.BtnSQLCommand = new System.Windows.Forms.Button();
            this.BtnClearLog = new System.Windows.Forms.Button();
            this.btnOpenDB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbServer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
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
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 5;
            this.passwordBox.Text = "masterkey";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(95, 40);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(100, 20);
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
            this.restoreDestBtn.Location = new System.Drawing.Point(334, 194);
            this.restoreDestBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.restoreDestBtn.Name = "restoreDestBtn";
            this.restoreDestBtn.Size = new System.Drawing.Size(26, 23);
            this.restoreDestBtn.TabIndex = 39;
            this.restoreDestBtn.Text = "…";
            this.restoreDestBtn.UseVisualStyleBackColor = true;
            this.restoreDestBtn.Click += new System.EventHandler(this.RestoreDestBtn_Click);
            // 
            // restoreSrcBtn
            // 
            this.restoreSrcBtn.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreSrcBtn.Location = new System.Drawing.Point(334, 146);
            this.restoreSrcBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.restoreSrcBtn.Name = "restoreSrcBtn";
            this.restoreSrcBtn.Size = new System.Drawing.Size(26, 23);
            this.restoreSrcBtn.TabIndex = 38;
            this.restoreSrcBtn.Text = "…";
            this.restoreSrcBtn.UseVisualStyleBackColor = true;
            this.restoreSrcBtn.Click += new System.EventHandler(this.RestoreSrcBtn_Click);
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
            this.restoreDestBox.Size = new System.Drawing.Size(303, 20);
            this.restoreDestBox.TabIndex = 2;
            this.restoreDestBox.Text = "c:\\database.fdb";
            // 
            // restoreSrcBox
            // 
            this.restoreSrcBox.Location = new System.Drawing.Point(26, 147);
            this.restoreSrcBox.Name = "restoreSrcBox";
            this.restoreSrcBox.Size = new System.Drawing.Size(303, 20);
            this.restoreSrcBox.TabIndex = 3;
            this.restoreSrcBox.Text = "c:\\database-backup.fbk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Путь к базе данных:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Путь к архиву базы данных:";
            // 
            // restoreBtn
            // 
            this.restoreBtn.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restoreBtn.Location = new System.Drawing.Point(16, 296);
            this.restoreBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(116, 39);
            this.restoreBtn.TabIndex = 0;
            this.restoreBtn.Text = "Восстановить";
            this.restoreBtn.UseVisualStyleBackColor = true;
            this.restoreBtn.Click += new System.EventHandler(this.RestoreBtn_Click);
            // 
            // openFileDiag
            // 
            this.openFileDiag.Filter = "FDB files|*.fdb";
            // 
            // tbDBName
            // 
            this.tbDBName.Location = new System.Drawing.Point(26, 243);
            this.tbDBName.Name = "tbDBName";
            this.tbDBName.Size = new System.Drawing.Size(334, 20);
            this.tbDBName.TabIndex = 1;
            this.tbDBName.TextChanged += new System.EventHandler(this.TbDBName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Имя файла базы данных:";
            // 
            // tbLogOut
            // 
            this.tbLogOut.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogOut.Location = new System.Drawing.Point(366, 38);
            this.tbLogOut.Multiline = true;
            this.tbLogOut.Name = "tbLogOut";
            this.tbLogOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLogOut.Size = new System.Drawing.Size(454, 296);
            this.tbLogOut.TabIndex = 42;
            // 
            // cbLog
            // 
            this.cbLog.AutoSize = true;
            this.cbLog.Checked = true;
            this.cbLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLog.Location = new System.Drawing.Point(366, 14);
            this.cbLog.Name = "cbLog";
            this.cbLog.Size = new System.Drawing.Size(207, 17);
            this.cbLog.TabIndex = 43;
            this.cbLog.Text = "Выводить процесс восстановления";
            this.cbLog.UseVisualStyleBackColor = true;
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(138, 296);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(108, 39);
            this.btnPassword.TabIndex = 44;
            this.btnPassword.Text = "Сбросить пароль";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.BtnPassword_Click);
            // 
            // cbIsDeleteBK
            // 
            this.cbIsDeleteBK.AutoSize = true;
            this.cbIsDeleteBK.Location = new System.Drawing.Point(26, 272);
            this.cbIsDeleteBK.Name = "cbIsDeleteBK";
            this.cbIsDeleteBK.Size = new System.Drawing.Size(115, 17);
            this.cbIsDeleteBK.TabIndex = 45;
            this.cbIsDeleteBK.Text = "Удалить файл BK";
            this.cbIsDeleteBK.UseVisualStyleBackColor = true;
            // 
            // cbIsResetPassword
            // 
            this.cbIsResetPassword.AutoSize = true;
            this.cbIsResetPassword.Checked = true;
            this.cbIsResetPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsResetPassword.Location = new System.Drawing.Point(148, 272);
            this.cbIsResetPassword.Name = "cbIsResetPassword";
            this.cbIsResetPassword.Size = new System.Drawing.Size(113, 17);
            this.cbIsResetPassword.TabIndex = 46;
            this.cbIsResetPassword.Text = "Сбросить пароль";
            this.cbIsResetPassword.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBK
            // 
            this.btnDeleteBK.Location = new System.Drawing.Point(252, 296);
            this.btnDeleteBK.Name = "btnDeleteBK";
            this.btnDeleteBK.Size = new System.Drawing.Size(108, 39);
            this.btnDeleteBK.TabIndex = 47;
            this.btnDeleteBK.Text = "Удалить Backup";
            this.btnDeleteBK.UseVisualStyleBackColor = true;
            this.btnDeleteBK.Click += new System.EventHandler(this.BtnDeleteBK_Click);
            // 
            // BtnSQLCommand
            // 
            this.BtnSQLCommand.Location = new System.Drawing.Point(745, 10);
            this.BtnSQLCommand.Name = "BtnSQLCommand";
            this.BtnSQLCommand.Size = new System.Drawing.Size(75, 23);
            this.BtnSQLCommand.TabIndex = 48;
            this.BtnSQLCommand.Text = "SQL";
            this.BtnSQLCommand.UseVisualStyleBackColor = true;
            this.BtnSQLCommand.Click += new System.EventHandler(this.BtnSQLCommand_Click);
            // 
            // BtnClearLog
            // 
            this.BtnClearLog.Location = new System.Drawing.Point(664, 10);
            this.BtnClearLog.Name = "BtnClearLog";
            this.BtnClearLog.Size = new System.Drawing.Size(75, 23);
            this.BtnClearLog.TabIndex = 49;
            this.BtnClearLog.Text = "Очистить";
            this.BtnClearLog.UseVisualStyleBackColor = true;
            this.BtnClearLog.Click += new System.EventHandler(this.BtnClearLog_Click);
            // 
            // btnOpenDB
            // 
            this.btnOpenDB.Location = new System.Drawing.Point(252, 100);
            this.btnOpenDB.Name = "btnOpenDB";
            this.btnOpenDB.Size = new System.Drawing.Size(108, 39);
            this.btnOpenDB.TabIndex = 50;
            this.btnOpenDB.Text = "Открыть БД";
            this.btnOpenDB.UseVisualStyleBackColor = true;
            this.btnOpenDB.Click += new System.EventHandler(this.BtnOpenDB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Server:";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(248, 66);
            this.numPort.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(57, 20);
            this.numPort.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Port";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(248, 40);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(100, 20);
            this.tbServer.TabIndex = 53;
            // 
            // frmBackup
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 341);
            this.Controls.Add(this.numPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbServer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOpenDB);
            this.Controls.Add(this.BtnClearLog);
            this.Controls.Add(this.BtnSQLCommand);
            this.Controls.Add(this.btnDeleteBK);
            this.Controls.Add(this.cbIsResetPassword);
            this.Controls.Add(this.cbIsDeleteBK);
            this.Controls.Add(this.btnPassword);
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
            this.Load += new System.EventHandler(this.frmBackup_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FrmBackup_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FrmBackup_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
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
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.CheckBox cbIsDeleteBK;
        private System.Windows.Forms.CheckBox cbIsResetPassword;
        private System.Windows.Forms.Button btnDeleteBK;
        private System.Windows.Forms.Button BtnSQLCommand;
        private System.Windows.Forms.Button BtnClearLog;
        private System.Windows.Forms.Button btnOpenDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbServer;
    }
}