using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Net.Security;
using System.IO.Compression;
using Ionic;
using Ionic.Zip;

using jFTP;

namespace BugTrap.Classes
{

    //''' <summary>
    //''' Use as Callback for Uploading Procedure and Downloading Procedure.
    //''' This Callback was Called Everytime that Download and Upload Procedure occurs
    //''' </summary>
    //''' <param name="CurrentFile">The Current File that was being Copied.</param>
    //''' <param name="TotalSize">The Total Size of the Current File.</param>
    //''' <param name="CurrentSize">The Current Size Being Downloaded or Uploaded.</param>
    //''' <param name="CurrentSpeed">The Current Speed\Size being Downloaded or Uploaded at the Current Time.</param>
    //''' <param name="State">The Current State , It can be use if there is an Error.</param>
    //''' <remarks></remarks>
    //Public Delegate Sub ProgressCallBack(ByVal CurrentFile As String, _
    //                                     ByVal TotalSize As Long, _
    //                                     ByVal CurrentSize As Long, _
    //                                     ByVal CurrentSpeed As Long, _
    //                                     ByVal FileAlias As String, _
    //                                     ByVal State As Integer)
    public class ReportSender
    {
        private List<string> Archives;
        private FTP.ProgressCallBack progressCallback;
        private string FTPServer;
        private string FTPUsername;
        private string FTPPassword;
        private string FTPFolder;


        public ReportSender(string FTPServer, string Username, string Password, string FTPFolder, FTP.ProgressCallBack FTPprogressCallback) 
        {
            Archives = new List<string>();
            this.FTPServer = FTPServer;
            this.FTPUsername = Username;
            this.FTPPassword = Password;
            this.FTPFolder = FTPFolder;
            this.progressCallback = FTPprogressCallback;
        }

        public void ClearFiles() 
        {
            if (Archives != null) Archives.Clear();
        }

        public void Add(string file)
        {
            if (Archives != null)  Archives.Add(file);
        }

        public void Remove(string file) 
        {
            if (Archives != null)  Archives.Remove(file);
        }


        public string SelectFolder(System.Windows.Forms.Form dialog) 
        {
            System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = fbd.ShowDialog(dialog);
            if (result == System.Windows.Forms.DialogResult.OK) 
            {
                return fbd.SelectedPath;
            }

            return "";
        }

        public string ZipReports(string header,string folder) 
        {
            string zipName  = folder + @"\" + header + "_" + DateTime.Now.ToLocalTime().ToString("MMddyyyy_hhmmsstt") + ".zip";
            ZipFile zip = new ZipFile(zipName, Encoding.ASCII);
            foreach (string key in Archives)
            {
                if (File.Exists(key)) 
                {
                    FileInfo info = new FileInfo(key);
                    zip.AddFile(key , "");
                }
            }

            zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
            zip.CompressionMethod = CompressionMethod.Deflate;
            zip.Save();
            zip.Dispose();
            zip = null;
            return zipName;
        }

        public void UploadFile(string filePath) 
        {
            FTP ftp = new FTP(this.FTPUsername, this.FTPPassword, this.FTPServer, this.progressCallback);

            try
            {
                ftp.QuiteMode = false;
                FileInfo info = new FileInfo(filePath);
                ftp.UploadFile((this.FTPFolder.Length == 0 ? "" : this.FTPFolder + @"\") + info.Name + "." + info.Extension, filePath, info.Name + "." + info.Extension, FTP.TaskState.Start);
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                System.Windows.Forms.MessageBox.Show(ex.Message + "\n" + ex.StackTrace, "Error");
            }
        }
    }
}
