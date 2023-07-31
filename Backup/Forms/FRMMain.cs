using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Runtime;
using System.IO;
using System.Net.NetworkInformation;
using System.Net;
using Microsoft.VisualBasic.Devices;
using System.Management;
using BugTrap.Classes;

namespace BugTrap.Forms
{
    public partial class FRMMain : Form
    {
        private UnhandledExceptionEventArgs UEE;
        private Action<string> OnGenerateReport;
        private Action<string> OnSendReport;
        private ReportSender RptSender;
        
        public UnhandledExceptionEventArgs UnhandledException { get { return this.UEE; } }

        public FRMMain(UnhandledExceptionEventArgs args)
        {
            this.UEE = args;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public static void ShowBugTrapDialog(UnhandledExceptionEventArgs args,string applicationTitle, string applicationVersion,string supportEmail, string supportWebsite,
                                            Action<string> OnGenerateReport,Action<string> OnSendReport, string FTPServer , string Username, string Password , string FTPFolder) 
        {
            FRMMain dialog = new FRMMain(args);
            Exception ex = (Exception)args.ExceptionObject;
            dialog.OnGenerateReport = OnGenerateReport;
            dialog.OnSendReport = OnSendReport;
            dialog.LBLHeader.Text = Properties.Resources.BugTrapHeader;

            dialog.LBLinkEmail.Text = supportEmail;
            dialog.LBLinkSite.Text = supportWebsite;
            dialog.LBLApplicationName.Text = applicationTitle;
            dialog.LBLVersion.Text = applicationVersion;
            dialog.TXTErrorDescription.Text =
                "Crash Date:" + DateTime.Now.ToLocalTime().ToString("mm-dd-yyyy") + Environment.NewLine + 
                "Crash Time:" + DateTime.Now.ToLocalTime().ToString("hh:mm:ss tt") + Environment.NewLine + 
                "Crash Description:" + Environment.NewLine +
                ex.Message;
            dialog.TXTErrorStackTrace.Text = ex.StackTrace;

            // Set Application Info
            dialog.TXTApplicationInfo.Text = dialog.GetApplicationInfo();

            // Set Machine State:Process List Info
            dialog.TXTProcessList.Text = dialog.GetProcessInfo();

            // Set Network State:Network List
            dialog.TXTNetworkInfo.Text = dialog.GetNetworkInformation();

            // Set Software Information
            dialog.TXTSoftwareInfo.Text = dialog.GetSoftwareInfo();

            // Set Hardware Information
            dialog.TXTHardwareInfo.Text = dialog.GetHardwareInfo();

            dialog.RptSender = new ReportSender(FTPServer, Username , Password , FTPFolder, null);

            try
            {
                List<string> files = dialog.WriteReportFilesInDisk("Pre_Report");

                dialog.RptSender.ClearFiles();
                foreach (String rpt in files)
                {
                    dialog.RptSender.Add(rpt);
                }

                string zipResult = dialog.RptSender.ZipReports(BugTrap.BugTrapHandler.ApplicationTitle, Microsoft.VisualBasic.FileIO.SpecialDirectories.Temp + @"\Pre_Report");

                if (dialog.OnGenerateReport != null) dialog.OnGenerateReport(zipResult);
                if (dialog.OnSendReport != null) dialog.OnSendReport(zipResult);
                dialog.RptSender.UploadFile(zipResult);
                //MessageBox.Show(this, "Report Sent!", "BugTrap", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //MessageBox.Show(this, "Report Sent!", "BugTrap", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exErr)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                //MessageBox.Show(null, exErr.Message, "BugTrap Failed Send", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            DialogResult result = dialog.ShowDialog();
          
            if (result == DialogResult.Ignore)
                return;
            else
            {
                Application.ExitThread();
                Application.Exit();
                Process.GetCurrentProcess().Kill();
            }
        }

        private void BTNClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }

        private void BTNIgnoreAndContinue_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Ignoring this error may lead to fatal error, data corruption and system crash.\n" +
               "Would you like to continue ignore this error?", "Ignore BugTrap", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                DialogResult = DialogResult.Ignore;
                Close();
            }
        }

        private void BTNSendErrorReport_Click(object sender, EventArgs e)
        {
            
            if (TXTUserReportName.Text.Trim().Length == 0)
            {
                MessageBox.Show(this, "Please enter your Fullname", "BugTrap Report", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TXTUserReportEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show(this, "Please enter valid Email address", "BugTrap Report", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (TXTUsrReportDescription.Text.Trim().Length == 0)
            {
                MessageBox.Show(this, "Please enter description", "BugTrap Report", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                
                List<string> files = WriteReportFilesInDisk("Post_Report");

                this.RptSender.ClearFiles();
                foreach (String rpt in files)
                {
                    this.RptSender.Add(rpt);
                }

                string zipResult = this.RptSender.ZipReports(BugTrap.BugTrapHandler.ApplicationTitle, Microsoft.VisualBasic.FileIO.SpecialDirectories.Temp + @"\Post_Report");
                if (this.OnGenerateReport != null) this.OnGenerateReport(zipResult);
                if (this.OnSendReport != null) this.OnSendReport(zipResult);
                this.RptSender.UploadFile(zipResult);
                MessageBox.Show(this, "Report Sent!", "BugTrap", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "BugTrap Failed Send", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

         private void WriteReportFileInDisk(string filePath, string data) 
         {
            FileStream fs = null;

            try
            {
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.Write);
                fs.Write(buffer , 0, buffer.Length);
                fs.Close();
                fs.Dispose();
                fs = null;
                
            }
            catch (Exception ex)
            {
                 MessageBox.Show(this, ex.Message, "BugTrap Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Dispose();
                    fs = null;
                }
            }
        }

        private List<String> WriteReportFilesInDisk(string folder) 
        {
            string tempFolder = Microsoft.VisualBasic.FileIO.SpecialDirectories.Temp;
            string newFolder = tempFolder + @"\" + folder;
            Directory.CreateDirectory(newFolder);

            WriteReportFileInDisk(newFolder + @"\CrashReport.txt", TXTErrorDescription.Text + Environment.NewLine + TXTErrorStackTrace.Text);
            WriteReportFileInDisk(newFolder + @"\ApplicationInfo.txt", TXTApplicationInfo.Text);
            WriteReportFileInDisk(newFolder + @"\HardwareInfo.txt", TXTHardwareInfo.Text);
            WriteReportFileInDisk(newFolder + @"\SoftwareInfo.txt", TXTSoftwareInfo.Text);
            WriteReportFileInDisk(newFolder + @"\ProcessInfo.txt", TXTProcessList.Text);
            WriteReportFileInDisk(newFolder + @"\NetworkInfo.txt", TXTNetworkInfo.Text);
            WriteReportFileInDisk(newFolder + @"\SourceInfo.txt", 
                    "Reporter's Info" + Environment.NewLine + 
                    "Name:" + TXTUserReportName.Text + Environment.NewLine + 
                    "Title:" + TXTUsrReportDescription.Text + Environment.NewLine +  
                    "User Descriptions:" + TXTUserReportDescribe.Text + Environment.NewLine                
                    );

            List<string> ls = new List<string>();
            ls.Add(newFolder + @"\CrashReport.txt");
            ls.Add(newFolder + @"\ApplicationInfo.txt");
            ls.Add(newFolder + @"\HardwareInfo.txt");
            ls.Add(newFolder + @"\SoftwareInfo.txt");
            ls.Add(newFolder + @"\ProcessInfo.txt");
            ls.Add(newFolder + @"\SourceInfo.txt");

            return ls;
        }


        public string GetApplicationInfo() 
        {
            string mainAssemblyInfo = "==Main Assembly Information==" + Environment.NewLine;
            Assembly mainAssembly = Assembly.GetEntryAssembly();
            mainAssemblyInfo += "Main Assembly Name:" + mainAssembly.GetName().Name + Environment.NewLine;
            mainAssemblyInfo += "Main Assembly Fullname" + mainAssembly.GetName().FullName + Environment.NewLine;
            mainAssemblyInfo += "Main Assembly Path:" + mainAssembly.CodeBase + Environment.NewLine;
            mainAssemblyInfo += "Main Assembly Size:" + new FileInfo(mainAssembly.Location).Length.ToString() + " bytes" + Environment.NewLine;

            string loadedAssemblies = "==Loaded Assembly Information==" + Environment.NewLine;
            foreach (Assembly asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                loadedAssemblies += "Loaded Assembly Name:" + asm.GetName().Name + Environment.NewLine;
                loadedAssemblies += "Loaded Assembly Fullname" + asm.GetName().FullName + Environment.NewLine;
                loadedAssemblies += "Loaded Assembly Path:" +  Environment.NewLine + asm.Location + Environment.NewLine + Environment.NewLine;
                loadedAssemblies += "Loaded Assembly Size:" + new FileInfo(asm.Location).Length.ToString() + " bytes";

            }


            return mainAssemblyInfo + Environment.NewLine + loadedAssemblies + Environment.NewLine + "==End Of Assembly List==";
        }

        public string GetProcessInfo() 
        {
            Process currentProcess = Process.GetCurrentProcess();
            string OtherProcessInfo = "==Other Processes Information==" + Environment.NewLine;
            string CurrentProcessInfo = "==Current Process Information==" + Environment.NewLine;

            CurrentProcessInfo += "Process Name: " + currentProcess.ProcessName + ".exe"+ Environment.NewLine;
            CurrentProcessInfo += "Process ID: "  + currentProcess.Id + Environment.NewLine;
            CurrentProcessInfo += "Session ID: " + currentProcess.SessionId + Environment.NewLine;
            CurrentProcessInfo += "Responding: " + (currentProcess.Responding ? "Yes" : "No") + Environment.NewLine;
            CurrentProcessInfo += "Process File Location: " + Environment.NewLine + (currentProcess.MainModule.FileName == null ? "" : currentProcess.MainModule.FileName) + Environment.NewLine; 
            CurrentProcessInfo += "Main Window Name: " + (currentProcess.MainWindowTitle == null ? "" : currentProcess.MainWindowTitle) + Environment.NewLine;
            CurrentProcessInfo += "Thread Count: " + currentProcess.Threads.Count + Environment.NewLine;
            CurrentProcessInfo += "Handle Count: " + currentProcess.HandleCount + Environment.NewLine;
            CurrentProcessInfo += "Min Private Working Set: " + currentProcess.MinWorkingSet + " bytes" + Environment.NewLine;
            CurrentProcessInfo += "Max Private Working Set: " + currentProcess.MaxWorkingSet + " bytes" + Environment.NewLine;
            CurrentProcessInfo += "Current Used Physical Memory: " + currentProcess.WorkingSet64 + " bytes" + Environment.NewLine + Environment.NewLine + Environment.NewLine;

            
            foreach (Process proc in Process.GetProcesses())
            {

                OtherProcessInfo += "Process Name: " + proc.ProcessName + ".exe" + Environment.NewLine;
                OtherProcessInfo += "Process ID: " + proc.Id + Environment.NewLine;
                OtherProcessInfo += "Session ID: " + proc.SessionId + Environment.NewLine;
                OtherProcessInfo += "Responding: " + (proc.Responding ? "Yes" : "No") + Environment.NewLine;
                OtherProcessInfo += GetProcessFilePath(proc, "Process File Location: ");
                OtherProcessInfo += GetProcessProperty(proc, "Main Window Name: ", "MainWindowTitle");
                OtherProcessInfo += "Thread Count: " + currentProcess.Threads.Count + Environment.NewLine;
                OtherProcessInfo += "Handle Count: " + currentProcess.HandleCount + Environment.NewLine;
                OtherProcessInfo += "Min Private Working Set: " + currentProcess.MinWorkingSet + " bytes" + Environment.NewLine;
                OtherProcessInfo += "Max Private Working Set: " + currentProcess.MaxWorkingSet + " bytes" +  Environment.NewLine;
                OtherProcessInfo += "Current Used Physical Memory: " + currentProcess.WorkingSet64 + " bytes" + Environment.NewLine + Environment.NewLine + Environment.NewLine;

            }

            return CurrentProcessInfo + OtherProcessInfo;
        }


        public string GetProcessProperty(Process process, string Header, string propertyName)
        {
            string info = "";
            try
            {
                foreach (PropertyInfo propInfo in process.GetType().GetProperties())
                {
                    if (propInfo.Name.Equals(propertyName))
                    {
                        info += Header + propInfo.GetValue(process, null).ToString() + Environment.NewLine;
                        return info;
                    }
                }

                return info += Header + Environment.NewLine;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                info += Header + Environment.NewLine;
                return info;
            }
        }

        public string GetProcessFilePath(Process process, string Header)
        {
            string info = "";
            try
            {
                info += Header + Environment.NewLine + process.MainModule.FileName + Environment.NewLine;
                return info;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                info += Header + Environment.NewLine;
                return info;
            }
        }

        public string GetNetworkInformation() 
        {
            string networkInformation = "==Network Interface Info==" + Environment.NewLine;

            foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                IPInterfaceProperties ipProp = netInterface.GetIPProperties();
                networkInformation += "Network Interface ID: " + netInterface.Id+ Environment.NewLine;
                networkInformation += "Network Interface Name: " + netInterface.Name + Environment.NewLine;
                
                networkInformation += "Operational Status: " + netInterface.OperationalStatus + Environment.NewLine;
                // Show UniCast Addresses
                networkInformation += "Unicast Addresses: " + Environment.NewLine;
                foreach (UnicastIPAddressInformation unicastIP in ipProp.UnicastAddresses)
                {
                    networkInformation += unicastIP.Address.AddressFamily + ":" + unicastIP.Address.ToString() + Environment.NewLine;      
                }
                networkInformation += "-------------------------------------------------" + Environment.NewLine;

                // Show MultiCast Addresses
                networkInformation += "Multicast Addresses: " + Environment.NewLine;
                foreach (MulticastIPAddressInformation multicastIP in ipProp.MulticastAddresses)
                {
                    networkInformation += multicastIP.Address.AddressFamily + ":" + multicastIP.Address.ToString() + Environment.NewLine;
                }
                networkInformation += "-------------------------------------------------" + Environment.NewLine;

                // Show MultiCast Addresses
                networkInformation += "Anycast Addresses: " + Environment.NewLine;
                foreach (IPAddressInformation anycastIP in ipProp.AnycastAddresses)
                {
                    networkInformation += anycastIP.Address.AddressFamily + ":" + anycastIP.Address.ToString() + Environment.NewLine;
                }
                networkInformation += "-------------------------------------------------" + Environment.NewLine;

                // Show DNS Addresses
                networkInformation += "DNS Addresses: " + Environment.NewLine;
                foreach (IPAddress dnsIP in ipProp.DnsAddresses)
                {
                    networkInformation += dnsIP.AddressFamily + ":" + dnsIP + Environment.NewLine;
                }
                networkInformation += "-------------------------------------------------" + Environment.NewLine;

                // Show Dhcp Addresses
                networkInformation += "DHCP Addresses: " + Environment.NewLine;
                foreach (IPAddress dhcpIP in ipProp.DhcpServerAddresses)
                {
                    networkInformation += dhcpIP.AddressFamily + ":" + dhcpIP + Environment.NewLine;
                }
                networkInformation += "-------------------------------------------------" + Environment.NewLine;


                // Show Dhcp Addresses
                networkInformation += "Win Server Addresses: " + Environment.NewLine;
                foreach (IPAddress winIP in ipProp.WinsServersAddresses)
                {
                    networkInformation += winIP.AddressFamily + ":" + winIP + Environment.NewLine;
                }
                networkInformation += "-------------------------------------------------" + Environment.NewLine;


                // Show Gateway Addresses
                networkInformation += "Gateway Addresses: " + Environment.NewLine;
                foreach (GatewayIPAddressInformation gwIP in ipProp.GatewayAddresses)
                {
                    networkInformation += gwIP.Address.AddressFamily + ":" + gwIP.Address + Environment.NewLine;
                }
                networkInformation += "-------------------------------------------------" + Environment.NewLine;


                networkInformation += "Physical Address: " + netInterface.GetPhysicalAddress().ToString() + Environment.NewLine ;
                networkInformation += "-------------------------------------------------" + Environment.NewLine + Environment.NewLine;
                 
            }

            return networkInformation;
        }

        public string GetSoftwareInfo() 
        {
            string softwareInfo = "==Software Information==" + Environment.NewLine;

            ComputerInfo comInfo = new ComputerInfo();
            softwareInfo += "Operating System Information" + Environment.NewLine;
            softwareInfo += "Operating System:" + comInfo.OSFullName + Environment.NewLine;
            softwareInfo += "Platorm:" + comInfo.OSPlatform + Environment.NewLine;
            softwareInfo += "Version:" + comInfo.OSVersion + Environment.NewLine;
            softwareInfo += "RAM Size:" + comInfo.TotalPhysicalMemory + Environment.NewLine;
            softwareInfo += "RAM Available:" + comInfo.AvailablePhysicalMemory + Environment.NewLine;
            softwareInfo += "Installed Culture:" + comInfo.InstalledUICulture + Environment.NewLine;

            ManagementObjectSearcher myOperativeSystemObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");

            foreach (ManagementObject obj in myOperativeSystemObject.Get())
            {
                softwareInfo +="Caption  -  " + obj["Caption"]+ Environment.NewLine;
                softwareInfo +="WindowsDirectory  -  " + obj["WindowsDirectory"]+ Environment.NewLine;
                softwareInfo +="ProductType  -  " + obj["ProductType"]+ Environment.NewLine;
                softwareInfo +="SerialNumber  -  " + obj["SerialNumber"]+ Environment.NewLine;
                softwareInfo +="SystemDirectory  -  " + obj["SystemDirectory"]+ Environment.NewLine;
                softwareInfo +="CountryCode  -  " + obj["CountryCode"]+ Environment.NewLine;
                softwareInfo +="CurrentTimeZone  -  " + obj["CurrentTimeZone"]+ Environment.NewLine;
                softwareInfo +="EncryptionLevel  -  " + obj["EncryptionLevel"]+ Environment.NewLine;
                softwareInfo +="OSType  -  " + obj["OSType"]+ Environment.NewLine;
                softwareInfo +="Version  -  " + obj["Version"]+ Environment.NewLine;
            }

            return softwareInfo;
        }

        public string GetHardwareInfo() 
        {
            string hardwareInfo = "==Hardware Information==" + Environment.NewLine;

            ManagementObjectSearcher myVideoObject = new ManagementObjectSearcher("select * from Win32_VideoController");

            hardwareInfo += "Video Controller" + Environment.NewLine;
            foreach (ManagementObject obj in myVideoObject.Get())
            {
                hardwareInfo += "Name  -  " + obj["Name"] + Environment.NewLine;
                hardwareInfo += "Status  -  " + obj["Status"]+ Environment.NewLine;
                hardwareInfo += "Caption  -  " + obj["Caption"]+ Environment.NewLine;
                hardwareInfo += "DeviceID  -  " + obj["DeviceID"]+ Environment.NewLine;
                hardwareInfo += "AdapterRAM  -  " + obj["AdapterRAM"]+ Environment.NewLine;
                hardwareInfo += "AdapterDACType  -  " + obj["AdapterDACType"] + Environment.NewLine;
                hardwareInfo += "Monochrome  -  " + obj["Monochrome"]+ Environment.NewLine;
                hardwareInfo += "InstalledDisplayDrivers  -  " + obj["InstalledDisplayDrivers"] + Environment.NewLine;
                hardwareInfo += "DriverVersion  -  " + obj["DriverVersion"]+ Environment.NewLine;
                hardwareInfo += "VideoProcessor  -  " + obj["VideoProcessor"]+ Environment.NewLine;
                hardwareInfo += "VideoArchitecture  -  " + obj["VideoArchitecture"] + Environment.NewLine;
                hardwareInfo += "VideoMemoryType  -  " + obj["VideoMemoryType"] + Environment.NewLine;
            }

            hardwareInfo +=  Environment.NewLine + "Drives Information" + Environment.NewLine;
            foreach (DriveInfo info in System.IO.DriveInfo.GetDrives())
            {
                hardwareInfo += "Drive Name: " + info.Name + Environment.NewLine;
                hardwareInfo += "Is Ready: " + info.IsReady + Environment.NewLine;
                if (info.IsReady) 
                {
                    hardwareInfo += "Volume Label: " + info.VolumeLabel + Environment.NewLine;
                    hardwareInfo += "Total Size: " + info.TotalSize + " bytes" + Environment.NewLine;
                    hardwareInfo += "Free Space: " + info.TotalFreeSpace + " bytes" + Environment.NewLine;
                    hardwareInfo += "Root Directory: " + info.RootDirectory + Environment.NewLine;
                    hardwareInfo += "Drive Type: " + info.DriveType + Environment.NewLine;
                    hardwareInfo += "Drive Format: " + info.DriveFormat + Environment.NewLine;
                }
            }

            hardwareInfo += Environment.NewLine + "CPU  Information" + Environment.NewLine;
            ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_Processor");
            foreach (ManagementObject obj in myProcessorObject.Get())
            {
                hardwareInfo += "Name  -  " + obj["Name"] + Environment.NewLine;
                hardwareInfo += "DeviceID  -  " + obj["DeviceID"] + Environment.NewLine;
                hardwareInfo += "Manufacturer  -  " + obj["Manufacturer"] + Environment.NewLine;
                hardwareInfo += "CurrentClockSpeed  -  " + obj["CurrentClockSpeed"] + Environment.NewLine;
                hardwareInfo += "Caption  -  " + obj["Caption"] + Environment.NewLine;
                hardwareInfo += "NumberOfCores  -  " + obj["NumberOfCores"] + Environment.NewLine;
                try
                {
                    hardwareInfo += "NumberOfEnabledCore  -  " + obj["NumberOfEnabledCore"] + Environment.NewLine;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    hardwareInfo += "NumberOfEnabledCore  -  1" + Environment.NewLine;
                }
                hardwareInfo += "NumberOfLogicalProcessors  -  " + obj["NumberOfLogicalProcessors"] + Environment.NewLine;
                hardwareInfo += "Architecture  -  " + obj["Architecture"] + Environment.NewLine;
                hardwareInfo += "Family  -  " + obj["Family"] + Environment.NewLine;
                hardwareInfo += "ProcessorType  -  " + obj["ProcessorType"] + Environment.NewLine;

                try
                {
                    hardwareInfo += "Characteristics  -  " + obj["Characteristics"] + Environment.NewLine;
                }
                catch (Exception ex)
                {
                   Console.WriteLine(ex.Message);
                }

                hardwareInfo += "AddressWidth  -  " + obj["AddressWidth"] + Environment.NewLine;
            }

            return hardwareInfo;
        }



    }
}
