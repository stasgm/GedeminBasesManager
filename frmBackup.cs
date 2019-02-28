using System;
using System.Windows.Forms;
using FirebirdBackupKit;
using System.IO;
using System.Diagnostics;
using System.Threading;
using FirebirdSql.Data.FirebirdClient;

namespace GedeminBasesManager
{
    public partial class frmBackup : Form
    {
        string fbkFilter = "BK файл|*.bk";    
        
        Thread _messageGeneratingThread;      
        private bool isProcess = false;
        public ProgressData tb;

        public void DeleteBackup()
        {
            String FileName = restoreSrcBox.Text;
            if (File.Exists(FileName))
            {
                File.Delete(FileName);
                tbLogOut.AppendText(Environment.NewLine + String.Format("Файл архива базы данных '{0}' удалён" + Environment.NewLine, FileName));
            }
        }

        public void GenNewDBID()
        {
            // Новый ID базы данных
            FbConnectionStringBuilder fb_con = new FbConnectionStringBuilder
            {
                Charset = "WIN1251", //используемая кодировка
                UserID = "SYSDBA", //логин
                Password = "masterkey", //пароль
                Database = restoreDestBox.Text,
                Dialect = 3
            };

            FbConnection myConnection = new FbConnection(fb_con.ToString());
            myConnection.Open();

            FbTransaction myTransaction = myConnection.BeginTransaction();

            FbCommand myCommand = new FbCommand
            {
                CommandText = "SELECT NEXT VALUE FOR GD_G_DBID FROM RDB$DATABASE",
                Connection = myConnection,
                Transaction = myTransaction
            };

            string iddb = "-1";

            FbDataReader reader = myCommand.ExecuteReader();
            if (reader.Read())
            {
                iddb = reader["GEN_ID"].ToString();
            }

                // myCommand.ExecuteNonQuery();
            myTransaction.Commit();
            myCommand.Dispose();
            myConnection.Close();

            tbLogOut.AppendText(String.Format(Environment.NewLine + "Присвоен новый DB ID  {0}" + Environment.NewLine, iddb));
        }

        public void ResetPassword()
        {
            FbConnectionStringBuilder fb_con = new FbConnectionStringBuilder
            {
                Charset = "WIN1251", //используемая кодировка
                UserID = "SYSDBA", //логин
                Password = "masterkey", //пароль
                Database = restoreDestBox.Text,
                Dialect = 3
            };

            FbConnection myConnection = new FbConnection(fb_con.ToString());
            myConnection.Open();

            FbTransaction myTransaction = myConnection.BeginTransaction();

            FbCommand myCommand = new FbCommand
            {
                CommandText =
                    "UPDATE GD_USER SET PASSW = 'Administrator' " +
                    "WHERE NAME = 'Administrator'",

                Connection = myConnection,
                Transaction = myTransaction
            };
            // Execute Update
            myCommand.ExecuteNonQuery();

            // Commit changes
            myTransaction.Commit();

            // Free command resources in Firebird Server
            myCommand.Dispose();

            // Close connection
            myConnection.Close();

            tbLogOut.AppendText(Environment.NewLine + "Пароль SYSDBA был сброшен на значение по умолчанию" + Environment.NewLine);
        }

        public void ResetDBUser()
        {
            FbConnectionStringBuilder fb_con = new FbConnectionStringBuilder
            {
                Charset = "WIN1251", //используемая кодировка
                UserID = "SYSDBA", //логин
                Password = "masterkey", //пароль
                Database = restoreDestBox.Text,
                Dialect = 3
            };

            FbConnection myConnection = new FbConnection(fb_con.ToString());
            myConnection.Open();

            FbTransaction myTransaction = myConnection.BeginTransaction();
            
            FbCommand myCommand = new FbCommand
            {
                CommandText = "UPDATE GD_USER SET IBPASSWORD = 'masterkey' WHERE IBNAME = 'SYSDBA'",
                Connection = myConnection,
                Transaction = myTransaction
            };
            myCommand.ExecuteNonQuery();
            myTransaction.Commit();
            myCommand.Dispose();
            myConnection.Close();

            tbLogOut.AppendText(Environment.NewLine + "Установлен пользователь DB SYSDBA и пароль сброшен на значение по умолчанию" + Environment.NewLine);
        }

        public frmBackup()
        {
            InitializeComponent();
        }

        public frmBackup(string[] arguments)
        {
            InitializeComponent();

            if (!(arguments.Length >= 2)) return;

            string backuppath = arguments[1];

            if (backuppath.Length == 0) return;

            restoreSrcBox.Text = backuppath;

            tbDBName.Text = Path.GetFileNameWithoutExtension(backuppath);

            restoreDestBox.Text = Path.GetDirectoryName(backuppath) + "\\" + tbDBName.Text + ".fdb";
        }

        private void RestoreSrcBtn_Click(object sender, EventArgs e)
        {
            openFileDiag.Filter = fbkFilter;
            openFileDiag.FileName = null;
            openFileDiag.Title = "Путь к архивной копии базы данных"; // Restore database source
            openFileDiag.CheckFileExists = true;

            if (openFileDiag.ShowDialog() == DialogResult.OK)
                restoreSrcBox.Text = openFileDiag.FileName;
        }

        private void RestoreDestBtn_Click(object sender, EventArgs e)
        {
            openFileDiag.Filter = fbkFilter;
            openFileDiag.FileName = null;
            openFileDiag.Title = "Путь к восстановленной базе данных"; // Restore database destination
            openFileDiag.CheckFileExists = false;

            if (openFileDiag.ShowDialog() == DialogResult.OK)
                restoreDestBox.Text = openFileDiag.FileName;
        }

        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            if (isProcess)
            {
                MessageBox.Show("В процессе восстановления", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (cbLog.Checked)
                {
                    //tb = new ProgressData();
                    //ListBoxObserver lbox = new ListBoxObserver(tbLogOut);
                    //tb.AddObserver(lbox);
                    //  _textBoxListener = new TextBoxTraceListener(tbLogOut);
                    //Debug.Listeners.Add(_textBoxListener);

                }
                _messageGeneratingThread = new Thread(new ThreadStart(RunRestore));
                _messageGeneratingThread.Start();
            }

        }

        private void TbDBName_TextChanged(object sender, EventArgs e)
        {
            restoreDestBox.Text = Path.GetDirectoryName(restoreDestBox.Text) + "\\" + tbDBName.Text + ".fdb";
        }

        private void RunRestore()
        {
            isProcess = true;
            try
            {
                var backupKit = new BackupKit(usernameBox.Text, passwordBox.Text);
                backupKit.Restore(restoreSrcBox.Text, restoreDestBox.Text, tbLogOut);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }


            // ResetDBUser();

            if (cbIsResetPassword.Checked) ResetPassword();
            if (cbIsDeleteBK.Checked) DeleteBackup();

            GenNewDBID();
            GenNewDBID();

            DialogResult dialogResult = MessageBox.Show("Закончен процесс восстановления базы данных!\nПодключиться к базе данных?" , "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Process p = new Process();
                ProcessStartInfo pi = new ProcessStartInfo
                {
                    UseShellExecute = true,
                    FileName = restoreDestBox.Text
                };
                p.StartInfo = pi;

                try
                {
                    p.Start();
                    Application.Exit(); 
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            isProcess = false;
        }

        private void FrmBackup_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void FrmBackup_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (files.Length == 0) return;

            string FileName = files[0];            
            if (Path.GetExtension(FileName) != ".bk" && Path.GetExtension(FileName) != ".fdb")
            {
                MessageBox.Show("Невернный файл. Только для *.bk или *.fdb", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Добавить " + FileName, "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result  ==  DialogResult.Yes)
            {
                if (Path.GetExtension(FileName).ToUpper() == ".FDB")
                {
                    tbDBName.Text = "";
                    restoreDestBox.Text = files[0];
                    restoreSrcBox.Text = "";
                }
                else
                {
                    restoreSrcBox.Text = files[0];
                }
                
            }
        }

        private void BtnPassword_Click(object sender, EventArgs e)
        {
            // Set the ServerType to 1 for connect to the embedded server
            ResetPassword();
            GenNewDBID();
        }

        private void BtnDeleteBK_Click(object sender, EventArgs e)
        {
            DeleteBackup();
        }

        private void BtnClearLog_Click(object sender, EventArgs e)
        {
            tbLogOut.Clear();
        }

        private void BtnSQLCommand_Click(object sender, EventArgs e)
        {
            ResetDBUser();            
            // MessageBox.Show("SQL запрос выполнен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnOpenDB_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo pi = new ProcessStartInfo
            {
                UseShellExecute = true,
                FileName = restoreDestBox.Text
            };
            p.StartInfo = pi;

            try
            {
                p.Start();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
