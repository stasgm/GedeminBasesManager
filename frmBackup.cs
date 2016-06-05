using System;
using System.Windows.Forms;
using FirebirdBackupKit;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace GedeminBasesManager
{
    public partial class frmBackup : Form
    {
        string fbkFilter = "BK files|*.bk";
        TextBoxTraceListener _textBoxListener;
        Thread _messageGeneratingThread;

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

        private void restoreSrcBtn_Click(object sender, EventArgs e)
        {
            openFileDiag.Filter = fbkFilter;
            openFileDiag.FileName = null;
            openFileDiag.Title = "Restore database source";
            openFileDiag.CheckFileExists = true;

            if (openFileDiag.ShowDialog() == DialogResult.OK)
                restoreSrcBox.Text = openFileDiag.FileName;
        }

        private void restoreDestBtn_Click(object sender, EventArgs e)
        {
            openFileDiag.Filter = fbkFilter;
            openFileDiag.FileName = null;
            openFileDiag.Title = "Restore database destination";
            openFileDiag.CheckFileExists = false;

            if (openFileDiag.ShowDialog() == DialogResult.OK)
                restoreDestBox.Text = openFileDiag.FileName;
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            if (cbLog.Checked)
            { 
                _textBoxListener = new TextBoxTraceListener(tbLogOut);
                Debug.Listeners.Add(_textBoxListener);
            }

            _messageGeneratingThread = new Thread(new ThreadStart(RunRestore));
            _messageGeneratingThread.Start();

        }

        private void tbDBName_TextChanged(object sender, EventArgs e)
        {
            restoreDestBox.Text = Path.GetDirectoryName(restoreDestBox.Text) + "\\" + tbDBName.Text + ".fdb";
        }

        private void RunRestore()
        {
            try
            {
                var backupKit = new BackupKit(usernameBox.Text, passwordBox.Text);
                backupKit.Restore(restoreSrcBox.Text, restoreDestBox.Text);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

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
}
