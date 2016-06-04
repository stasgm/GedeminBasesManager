using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System;

namespace PacketViewer
{
    public class FileAssociation
    {
        private const int SHCNE_ASSOCCHANGED = 0x8000000;
        private const uint SHCNF_IDLIST = 0x0U;

        public static void Associate(string fileextension, string paramvalue, string description, string icon, string AssociationName)
        {
            if (AssociationName.Length == 0) AssociationName = Application.ProductName;
            Registry.ClassesRoot.CreateSubKey(fileextension).SetValue("", AssociationName);

            if (AssociationName != null && AssociationName.Length > 0)
            {
                using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(AssociationName))
                {
                    if (description != null)
                        key.SetValue("", description);

                    if (icon != null)
                        key.CreateSubKey("DefaultIcon").SetValue("", icon);
                        //key.CreateSubKey("DefaultIcon").SetValue("", ToShortPathName(icon));

                        //key.CreateSubKey(@"Shell\Open\Command").SetValue("", ToShortPathName(Application.ExecutablePath) + paramvalue +" \"%1\"");
                        key.CreateSubKey(@"Shell\Open\Command").SetValue("", paramvalue);
                }
            }

            SHChangeNotify(SHCNE_ASSOCCHANGED, SHCNF_IDLIST, IntPtr.Zero, IntPtr.Zero);
        }

        public static bool IsAssociated(string fileextension)
        {
            return (Registry.ClassesRoot.OpenSubKey(fileextension, false) != null);
        }

        public static void Remove(string fileextension, string AssociationName)
        {
            if (AssociationName.Length == 0) AssociationName = Application.ProductName;
            Registry.ClassesRoot.DeleteSubKeyTree(fileextension);
            Registry.ClassesRoot.DeleteSubKeyTree(AssociationName);
        }

        [DllImport("shell32.dll", SetLastError = true)]
        private static extern void SHChangeNotify(int wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);

        [DllImport("Kernel32.dll")]
        private static extern uint GetShortPathName(string lpszLongPath, [Out]StringBuilder lpszShortPath, uint cchBuffer);

        private static string ToShortPathName(string longName)
        {
            StringBuilder s = new StringBuilder(1000);
            uint iSize = (uint)s.Capacity;
            uint iRet = GetShortPathName(longName, s, iSize);
            return s.ToString();
        }
    }
}