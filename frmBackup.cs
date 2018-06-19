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
        //FbConnection fb;

        public void DeleteBackup()
        {
            String FileName = restoreSrcBox.Text;
            if (File.Exists(FileName))
            {
                File.Delete(FileName);
                tbLogOut.AppendText(Environment.NewLine + String.Format("Файл архива базы данных '{0}' удалён" + Environment.NewLine, FileName));
            }
        }

        public void ResetPassword()
        {
            FbConnectionStringBuilder fb_con = new FbConnectionStringBuilder();
            fb_con.Charset = "WIN1251"; //используемая кодировка
            fb_con.UserID = "SYSDBA"; //логин
            fb_con.Password = "masterkey"; //пароль
            fb_con.Database = restoreDestBox.Text;
            fb_con.Dialect = 3;

            FbConnection myConnection = new FbConnection(fb_con.ToString());
            myConnection.Open();

            FbTransaction myTransaction = myConnection.BeginTransaction();

            FbCommand myCommand = new FbCommand();
            myCommand.CommandText =
                "UPDATE GD_USER SET PASSW = 'Administrator' " +
                "WHERE NAME = 'Administrator'";

            myCommand.Connection = myConnection;
            myCommand.Transaction = myTransaction;
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
        /*
        public static class CallBackMy
        {
            public delegate void callbackEvent(string what);
            public static callbackEvent callbackEventHandler;
        }
        */

        /*
        public void addText(string text)
        {
            SetValue(text);
        }
        */

        public frmBackup()
        {
            //CallBackMy.callbackEventHandler = new CallBackMy.callbackEvent(this.SetValue);
            //tb = new ProgressData();
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

        private void restoreSrcBtn_Click(object sender, EventArgs e)
        {
            openFileDiag.Filter = fbkFilter;
            openFileDiag.FileName = null;
            openFileDiag.Title = "Путь к архивной копии базы данных"; // Restore database source
            openFileDiag.CheckFileExists = true;

            if (openFileDiag.ShowDialog() == DialogResult.OK)
                restoreSrcBox.Text = openFileDiag.FileName;
        }

        private void restoreDestBtn_Click(object sender, EventArgs e)
        {
            openFileDiag.Filter = fbkFilter;
            openFileDiag.FileName = null;
            openFileDiag.Title = "Путь к восстановленной базе данных"; // Restore database destination
            openFileDiag.CheckFileExists = false;

            if (openFileDiag.ShowDialog() == DialogResult.OK)
                restoreDestBox.Text = openFileDiag.FileName;
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            if (isProcess)
            {
                MessageBox.Show("В процессе восстановления");
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

        private void tbDBName_TextChanged(object sender, EventArgs e)
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

            if (cbIsResetPassword.Checked) ResetPassword();
            if (cbIsDeleteBK.Checked) DeleteBackup();
            MessageBox.Show("Закончен процесс восстановления базы данных!");
            isProcess = false;
        }

        private void frmBackup_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void frmBackup_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            if (files.Length == 0) return;

            string FileName = files[0];            
            if (Path.GetExtension(FileName) != ".bk" && Path.GetExtension(FileName) != ".fdb")
            {
                MessageBox.Show("Невернный файл. Только для *.bk или *.fdb");
                return;
            }

            var result = MessageBox.Show("Добавить " + FileName, "Внимание", MessageBoxButtons.YesNo);
            
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

        /*
        delegate void SetTextCallback(string text);
        private void SetValue(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (tb.InvokeRequired())
            {
                SetTextCallback d = new SetTextCallback(SetValue);
                Invoke(d, new object[] { text });
            }
            else
            {
                tb.AddText(text);
            }
        }
        */

        private void btnPassword_Click(object sender, EventArgs e)
        {
            // Set the ServerType to 1 for connect to the embedded server
            ResetPassword();
        }

        private void btnDeleteBK_Click(object sender, EventArgs e)
        {
            DeleteBackup();
        }

        private void BtnClearLog_Click(object sender, EventArgs e)
        {
            tbLogOut.Clear();
        }

        private void BtnSQLCommand_Click(object sender, EventArgs e)
        {
            FbConnectionStringBuilder fb_con = new FbConnectionStringBuilder();
            fb_con.Charset = "WIN1251"; //используемая кодировка
            fb_con.UserID = "SYSDBA"; //логин
            fb_con.Password = "masterkey"; //пароль
            fb_con.Database = restoreDestBox.Text;
            fb_con.Dialect = 3;

            FbConnection myConnection = new FbConnection(fb_con.ToString());
            myConnection.Open();

            FbTransaction myTransaction = myConnection.BeginTransaction();

            String SQLCommand = "UPDATE GD_USER SET IBPASSWORD = 'masterkey' WHERE IBNAME = 'SYSDBA'";
            if (tbLogOut.Text.Length > 0) SQLCommand = tbLogOut.Text;

            FbCommand myCommand = new FbCommand();
            myCommand.CommandText = SQLCommand;

            myCommand.Connection = myConnection;
            myCommand.Transaction = myTransaction;
            myCommand.ExecuteNonQuery();
            myTransaction.Commit();
            myCommand.Dispose();
            myConnection.Close();

            MessageBox.Show("SQL запрос выполнен!");
        }

        private void btnOpenDB_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo pi = new ProcessStartInfo();
            pi.UseShellExecute = true;
            pi.FileName = restoreDestBox.Text;
            p.StartInfo = pi;

            try
            {
                p.Start();
            }
            catch (Exception Ex)
            {
                //MessageBox.Show(Ex.Message);
            }

        }
    }

    /*
    public class TextBoxTraceListener : TraceListener
    {
        private TextBox _target;
        private StringSendDelegate _invokeWrite;
        
        public TextBoxTraceListener(TextBox target)
        {
            _target = target;
            _invokeWrite = new StringSendDelegate(SendString);
        }

        public override void Write(string message)
        {
            _target.Invoke(_invokeWrite, new object[] { message });
        }

        public override void WriteLine(string message)
        {
            _target.Invoke(_invokeWrite, new object[]
                { message + Environment.NewLine });
        }
        
        private delegate void StringSendDelegate(string message);
        private void SendString(string message)
        {
            _target.AppendText(message + "\r");
        }
    }   
    */
}
