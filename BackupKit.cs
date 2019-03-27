using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.Data.Services;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;
using GedeminBasesManager;

namespace FirebirdBackupKit
{
    public class BackupKit
    {
        public TextBox tb;
        public string Username { get; set; }

        public string Password { get; set; }

        public string Server{ get; set; }

        public int Port { get; set; }

        public BackupKit(string username, string password, string server, int port)
        {

            if (string.IsNullOrEmpty(username))
                throw new ArgumentNullException("username");

            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("password");

            if (string.IsNullOrEmpty(server)) server = "localhost";

            if (port == 0) Port = 3050;

            Username = username;
            Password = password;
            Server = server;
            Port = port;
        }

        public void Backup(string source, string dest)
        {

            if (!File.Exists(source))
                throw new FileNotFoundException("Source file not found", source);

            if (File.Exists(dest))
                throw new IOException("Destination file already exists");

            //frmBackup.addText("Backing up database");
          
            Debug.WriteLine("Backing up database");
            Debug.WriteLine("Source: {0} ({1})", source, GetFileSize(source));
            Debug.WriteLine("Destination: {0}", dest, null);

            string backupTemp = GetTempName(dest);

            Debug.WriteLine("Backing up to temp file - {0}", backupTemp, null);

            FbBackup backup = new FbBackup
            {
                ConnectionString = CreateConnectionString(source),
                Verbose = true,
            };

            backup.BackupFiles.Add(new FbBackupFile(backupTemp, null));

            backup.ServiceOutput += ServiceOutput;

            backup.Execute();

            Debug.WriteLine("Backup complete - {0} ({1})", backupTemp, GetFileSize(backupTemp));

            Debug.WriteLine("Renaming temp backup file to - {0}", dest, null);

            File.Move(backupTemp, dest);

            Debug.WriteLine("Backup complete");

        }

        public void Restore(string source, string dest, TextBox tbLog)
        {
            tb = tbLog;

            if (!File.Exists(source))
                throw new FileNotFoundException("Файл архива базы данных не найден", source);

            if (File.Exists(dest))
                throw new IOException("Файл базы данных уже существует");

            tb.Text = String.Format("Начат процесс восстановления базы данных: {0}" + Environment.NewLine, DateTime.Now);
            //tbLog.AppendText("Source: {0} ({1})", source, GetFileSize(source));
            //tbLog.AppendText("Destination: {0}", dest, null);
            /*
            Debug.WriteLine("Restoring database");
            Debug.WriteLine("Source: {0} ({1})", source, GetFileSize(source));
            Debug.WriteLine("Destination: {0}", dest, null);
            */

            string restoreTemp = GetTempName(dest);

            tb.AppendText(String.Format("Временный файл: {0}" + Environment.NewLine + Environment.NewLine, restoreTemp));
            //Debug.WriteLine("Restoring to temp file - {0}", restoreTemp, null);

            FbRestore restore = new FbRestore()
            {
                ConnectionString = CreateConnectionString(restoreTemp),
                Verbose = true,
                Options = FbRestoreFlags.Create,
            };

            restore.BackupFiles.Add(new FbBackupFile(source, null));

            restore.ServiceOutput += ServiceOutput;

            //Program.
            try
            {
                restore.Execute();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
                // Удалить временный файл
            }

            //Debug.WriteLine("Restore complete - {0} ({1})", restoreTemp, GetFileSize(restoreTemp));
            tb.AppendText(Environment.NewLine + "Переименование временного файла" + Environment.NewLine + Environment.NewLine);
            //Debug.WriteLine("Renaming temp restore file to - {0}", dest, null);

            File.Move(restoreTemp, dest);
            tb.AppendText(String.Format("Закончен процесс восстановления базы данных: {0}" + Environment.NewLine, DateTime.Now));
        }

        public void Copy(string source, string dest)
        {

            if (!File.Exists(source))
                throw new FileNotFoundException("Source file not found", source);

            if (File.Exists(dest))
                throw new IOException("Destination file already exists");

            Debug.WriteLine("Copying database");
            Debug.WriteLine("Source: {0} ({1})", source, GetFileSize(source));
            Debug.WriteLine("Destination: {0}", dest, null);

            string backupTemp = GetTempName(source);

            Debug.WriteLine("Backing up to temp file - {0}", backupTemp, null);

            FbBackup backup = new FbBackup
            {
                ConnectionString = CreateConnectionString(source),
                Verbose = true,
                Options = FbBackupFlags.NoGarbageCollect,
            };

            backup.BackupFiles.Add(new FbBackupFile(backupTemp, null));

            backup.ServiceOutput += ServiceOutput;

            backup.Execute();

            Debug.WriteLine("Backup complete - {0} ({1})", backupTemp, GetFileSize(backupTemp));

            string restoreTemp = GetTempName(source);

            Debug.WriteLine("Restoring to temp file - {0}", restoreTemp, null);

            FbRestore restore = new FbRestore()
            {
                ConnectionString = CreateConnectionString(restoreTemp),
                Verbose = true,
                Options = FbRestoreFlags.Create,
            };

            restore.BackupFiles.Add(new FbBackupFile(backupTemp, null));

            restore.ServiceOutput += ServiceOutput;

            restore.Execute();

            Debug.WriteLine("Restore complete - {0} ({1})", restoreTemp, GetFileSize(restoreTemp));

            Debug.WriteLine("Renaming temp restore file to - {0}", dest, null);

            File.Move(restoreTemp, dest);

            Debug.WriteLine("Deleting temp backup file - {0}", backupTemp, null);

            File.Delete(backupTemp);

            Debug.WriteLine("Copy complete");

        }

        void ServiceOutput(object sender, ServiceOutputEventArgs e)
        {
            tb.AppendText(String.Format(e.Message + Environment.NewLine));
            Debug.WriteLine(e.Message);
        }

        string GetTempName(string fileName)
        {
            return Path.Combine(Path.GetDirectoryName(fileName), Path.GetRandomFileName());
        }

        string GetFileSize(string fileName)
        {

            FileInfo fi = new FileInfo(fileName);

            return FormatSize(fi.Length);

        }

        string FormatSize(double size)
        {

            string[] units = { "kb", "mb", "gb" };
            int unit = 0;

            size = size / 1024;

            while (size >= 1024)
            {
                size = size / 1024;
                unit++;
            }

            return String.Format("{0:f1}{1}", size, units[unit]);

        }

        string CreateConnectionString(string database)
        {

            FbConnectionStringBuilder cs = new FbConnectionStringBuilder
            {
                UserID = Username,
                Password = Password,
                Database = database,
                DataSource = Server,
                Port = Port
            };

            return cs.ToString();

        }
  
    }
}
