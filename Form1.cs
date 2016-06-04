using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacketViewer;
using System.IO;

namespace GedeminBasesManager
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            cbServerType.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbServerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isDefaultSrv = false;

            ComboBox senderComboBox = (ComboBox)sender;
            switch (senderComboBox.SelectedIndex)
            {
                case 0:
                    isDefaultSrv = true;
                    break;
                case 1:
                    isDefaultSrv = false;
                    break;
            }
            tbServer.Enabled = isDefaultSrv;
            numPort.Enabled = isDefaultSrv;
        }

        private void btnSelectGedemin_Click(object sender, EventArgs e)
        {
            OpenFileDialog oflDatabase = new OpenFileDialog();
            oflDatabase.Filter = "|gedemin.exe"; ;
            if (oflDatabase.ShowDialog() == DialogResult.OK)
            {
                tbGedeminPath.Text = oflDatabase.FileName;
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            cbServerType.SelectedIndex = Properties.Settings.Default.ServerType;
            tbServer.Text = Properties.Settings.Default.Server;
            numPort.Value = Properties.Settings.Default.Port;
            if (numPort.Value == 0)
            {
                numPort.Value = 3050;
            }
            tbGedeminPath.Text = Properties.Settings.Default.GedeminPath;
            cbUseCredentials.Checked = Properties.Settings.Default.UseCredentials;
            tbUsername.Text = Properties.Settings.Default.Username;
            tbPassword.Text = Properties.Settings.Default.Password;

        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ServerType = cbServerType.SelectedIndex;
            Properties.Settings.Default.Server = tbServer.Text;
            Properties.Settings.Default.Port = numPort.Value;
            Properties.Settings.Default.GedeminPath = tbGedeminPath.Text;
            Properties.Settings.Default.UseCredentials = cbUseCredentials.Checked;
            Properties.Settings.Default.Username = tbUsername.Text;
            Properties.Settings.Default.Password = tbPassword.Text;
            Properties.Settings.Default.Save();
        }

        private void btnAssociate_Click(object sender, EventArgs e)
        {
            string regtext = "";
            string gedeminDir = System.IO.Path.GetDirectoryName(tbGedeminPath.Text) + "\\";

            if (tbGedeminPath.Text.Length > 0)
            {
                regtext = '"' + tbGedeminPath.Text.Trim('"').Trim(' ') + '"';
            } else {
                MessageBox.Show("Gedemin path error");
                return;
            }

            if (cbServerType.SelectedIndex == 0)
            {
                //Default
                regtext += " /sn ";

                if (tbServer.Text.Length > 0)
                {
                    regtext += '"' + tbServer.Text + '/' + numPort.Value + ":%1"+ '"';
                }
                else
                {
                    MessageBox.Show("Server error");
                    return;
                }
            }
            regtext += cbUseCredentials.Checked ? " /user "+ tbUsername.Text + " /password " + tbUsername.Text : "";
            //regtext += " /user Administrator /password Administrator";

            // Проверить на правильность пути к gedemin.exe

            string icoFilePath = gedeminDir + "FDB.ico";
            
            using (FileStream fs = new FileStream(icoFilePath, FileMode.Create))
                Properties.Resources.ged_fdb.Save(fs);

            FileAssociation.Associate(".fdb", regtext, "gedemin database", icoFilePath, "Firebird database");


            MessageBox.Show("Successfully associated!\n\n" + regtext + '\n'+ icoFilePath);
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (FileAssociation.IsAssociated(".fdb"))
            {
                FileAssociation.Remove(".fdb", "Firebird database");
                MessageBox.Show("Association removed!");
            }
            else
            {
                MessageBox.Show("Not associated!");
            }
                
        }

        private void btnAssociateBackup_Click(object sender, EventArgs e)
        {
            string regtext = "\"" + Application.ExecutablePath + "\" \"%1\"";
            string gedeminDir = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\";

            string icoFilePath = gedeminDir + "BK.ico";

            using (FileStream fs = new FileStream(icoFilePath, FileMode.Create))
                Properties.Resources.ged_bk.Save(fs);

            FileAssociation.Associate(".bk", regtext, "gedemin database", icoFilePath, "Firebird database backup");


            MessageBox.Show("Successfully associated!\n\n" + regtext + '\n' + icoFilePath);
        }

        private void btnRemoveBackup_Click(object sender, EventArgs e)
        {
            if (FileAssociation.IsAssociated(".bk"))
            {
                FileAssociation.Remove(".bk", "Firebird database backup");
                MessageBox.Show("Association removed!");
            }
            else
            {
                MessageBox.Show("Not associated!");
            }
        }
    }
}