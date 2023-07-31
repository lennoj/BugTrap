using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace BugTrap
{
    public class BugTrapHandler
    {
        private static string _supportEmail;
        private static string _supportWebsite;
        private static string _ApplicationTitle;
        private static string _ApplicationVersion;


        public static string SupportEmail { get { return _supportEmail; } }
        public static string SupportWebisite { get { return _supportWebsite; } }
        public static string ApplicationTitle { get { return _ApplicationTitle; } }
        public static string ApplicationVersion { get { return _ApplicationVersion; } }

        public static void Initialize(string pSupportEmail, string pSupportWebsite, string pTitle, string pVersion , Action<string> OnGenerateReport,Action<string> OnSendReport , string FTPServer, string FTPUsername, string FTPPassword, string FTPFolder, bool EncryptErrorDetails) 
        {
            _supportEmail = pSupportEmail;
            _supportWebsite = pSupportWebsite;
            _ApplicationTitle = pTitle;
            _ApplicationVersion = pVersion;
            
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.ThrowException, true);

            Application.ThreadException += (object sender, System.Threading.ThreadExceptionEventArgs args) =>
            {
                try
                {
                    Forms.FRMMain.ShowBugTrapDialog(args, ApplicationTitle, ApplicationVersion, SupportEmail, SupportWebisite, OnGenerateReport, OnSendReport, FTPServer, FTPUsername, FTPPassword, FTPFolder,EncryptErrorDetails);  
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    MessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine, "BugTrap Error");                
                }
            };

            AppDomain.CurrentDomain.UnhandledException += (Object sender, UnhandledExceptionEventArgs args)=>
            {
                try
                {
                    Forms.FRMMain.ShowBugTrapDialog(args, ApplicationTitle, ApplicationVersion, SupportEmail, SupportWebisite, OnGenerateReport, OnSendReport, FTPServer, FTPUsername, FTPPassword, FTPFolder,EncryptErrorDetails);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    MessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine, "BugTrap Error");                
                }
            };
        }

        

    }
}
