using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GedeminBasesManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            String[] arguments = Environment.GetCommandLineArgs();

            if (arguments.Length == 1) {
                Application.Run(new frmSettings());
            }else{
                Application.Run(new frmBackup(arguments));
            }
        }
    }
}
