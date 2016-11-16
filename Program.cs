using System;
using System.Windows.Forms;

namespace GedeminBasesManager
{
    static class Program
    {
        //public frmBackup frm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]        
        static void Main()             
        {
            frmBackup frm;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            String[] arguments = Environment.GetCommandLineArgs();

            if (arguments.Length == 1) {
                Application.Run(new frmSettings());
            }else{
                frm = new frmBackup(arguments);
                Application.Run(frm);
                //Application.Run(new frmBackup(arguments));
            }
        }
    }
}
