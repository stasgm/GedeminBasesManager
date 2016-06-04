using System;
using System.Windows.Forms;
using FirebirdBackupKit;
using System.IO;
using System.Diagnostics;
using TestMessageThread;
using System.Threading;

namespace GedeminBasesManager
{
    public partial class frmBackup : Form
    {
        string fbkFilter = "BK files|*.bk";
        TextBoxTraceListener _textBoxListener;
        SpewPointlessMessages _messageGenerator;
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

            tbDBName.Text = Path.GetFileNameWithoutExtension(backuppath) + ".fdb";

            restoreDestBox.Text = Path.GetDirectoryName(backuppath) + "\\" + tbDBName.Text;
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
            _textBoxListener = new TextBoxTraceListener(tbLogOut);
            _messageGenerator = new SpewPointlessMessages();
            Debug.Listeners.Add(_textBoxListener);
            //            Debug.AutoFlush = true;
            //            Debug.Indent();
            //            Debug.WriteLine("Entering Main");
            //            Debug.WriteLine("Exiting Main");
            //            Debug.Unindent();
            //  Application.DoEvents();
            
            _messageGenerator.source = restoreSrcBox.Text;
            _messageGenerator.dest = restoreDestBox.Text;
            _messageGeneratingThread = new Thread(new ThreadStart(_messageGenerator.Start));
            _messageGeneratingThread.Start();
        }

        private void tbDBName_TextChanged(object sender, EventArgs e)
        {
            restoreDestBox.Text = Path.GetDirectoryName(restoreDestBox.Text) + "\\" + tbDBName.Text;
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
            // No need to lock text box as this function will only 
            // ever be executed from the UI thread
            //.._target.Text += message;
            _target.AppendText(message + "\r");
        }
    }   
}
