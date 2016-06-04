using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using FirebirdBackupKit;
using System.Windows.Forms;
using System.IO;

namespace TestMessageThread
{
    public class SpewPointlessMessages
    {
        public string source;
        public string dest;

        public SpewPointlessMessages()
        {
        }

        /// <summary>
        /// Start outputting time messages to the Trace
        /// </summary>
        public void Start()
        {
            try
            {
                //var backupKit = new BackupKit(usernameBox.Text, passwordBox.Text);
                var backupKit = new BackupKit("SYSDBA", "masterkey");

                backupKit.Restore(source, dest);
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

        /// <summary>
        /// Allow all running message threads to complete
        /// </summary>
    }
}
