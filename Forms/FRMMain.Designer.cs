namespace BugTrap.Forms
{
    partial class FRMMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMMain));
            this.LBLHeader = new System.Windows.Forms.Label();
            this.PicBoxBugTrap = new System.Windows.Forms.PictureBox();
            this.TCMain = new System.Windows.Forms.TabControl();
            this.TABCrashReport = new System.Windows.Forms.TabPage();
            this.TXTErrorStackTrace = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTErrorDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TABApplicationInfo = new System.Windows.Forms.TabPage();
            this.TXTApplicationInfo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TABMachineInfo = new System.Windows.Forms.TabPage();
            this.TXTSoftwareInfo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TXTHardwareInfo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TABMachineState = new System.Windows.Forms.TabPage();
            this.TXTNetworkInfo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TXTProcessList = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TABSendReport = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.BTNSendErrorReport = new System.Windows.Forms.Button();
            this.TXTUserReportDescribe = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TXTUsrReportDescription = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TXTUserReportEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TXTUserReportName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TABAbout = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LBLinkEmail = new System.Windows.Forms.LinkLabel();
            this.LBLinkSite = new System.Windows.Forms.LinkLabel();
            this.BTNClose = new System.Windows.Forms.Button();
            this.BTNIgnoreAndContinue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBLApplicationName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LBLVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBugTrap)).BeginInit();
            this.TCMain.SuspendLayout();
            this.TABCrashReport.SuspendLayout();
            this.TABApplicationInfo.SuspendLayout();
            this.TABMachineInfo.SuspendLayout();
            this.TABMachineState.SuspendLayout();
            this.TABSendReport.SuspendLayout();
            this.TABAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLHeader
            // 
            this.LBLHeader.AutoSize = true;
            this.LBLHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLHeader.Location = new System.Drawing.Point(79, 12);
            this.LBLHeader.Name = "LBLHeader";
            this.LBLHeader.Size = new System.Drawing.Size(443, 60);
            this.LBLHeader.TabIndex = 0;
            this.LBLHeader.Text = resources.GetString("LBLHeader.Text");
            // 
            // PicBoxBugTrap
            // 
            this.PicBoxBugTrap.BackgroundImage = global::BugTrap.Properties.Resources.Bug;
            this.PicBoxBugTrap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicBoxBugTrap.Location = new System.Drawing.Point(12, 12);
            this.PicBoxBugTrap.Name = "PicBoxBugTrap";
            this.PicBoxBugTrap.Size = new System.Drawing.Size(50, 37);
            this.PicBoxBugTrap.TabIndex = 1;
            this.PicBoxBugTrap.TabStop = false;
            // 
            // TCMain
            // 
            this.TCMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TCMain.Controls.Add(this.TABCrashReport);
            this.TCMain.Controls.Add(this.TABApplicationInfo);
            this.TCMain.Controls.Add(this.TABMachineInfo);
            this.TCMain.Controls.Add(this.TABMachineState);
            this.TCMain.Controls.Add(this.TABSendReport);
            this.TCMain.Controls.Add(this.TABAbout);
            this.TCMain.Location = new System.Drawing.Point(12, 199);
            this.TCMain.Name = "TCMain";
            this.TCMain.SelectedIndex = 0;
            this.TCMain.Size = new System.Drawing.Size(514, 296);
            this.TCMain.TabIndex = 2;
            // 
            // TABCrashReport
            // 
            this.TABCrashReport.BackColor = System.Drawing.Color.Silver;
            this.TABCrashReport.Controls.Add(this.TXTErrorStackTrace);
            this.TABCrashReport.Controls.Add(this.label6);
            this.TABCrashReport.Controls.Add(this.TXTErrorDescription);
            this.TABCrashReport.Controls.Add(this.label3);
            this.TABCrashReport.Location = new System.Drawing.Point(4, 22);
            this.TABCrashReport.Name = "TABCrashReport";
            this.TABCrashReport.Padding = new System.Windows.Forms.Padding(3);
            this.TABCrashReport.Size = new System.Drawing.Size(506, 270);
            this.TABCrashReport.TabIndex = 0;
            this.TABCrashReport.Text = "Crash Report";
            // 
            // TXTErrorStackTrace
            // 
            this.TXTErrorStackTrace.Location = new System.Drawing.Point(14, 123);
            this.TXTErrorStackTrace.Multiline = true;
            this.TXTErrorStackTrace.Name = "TXTErrorStackTrace";
            this.TXTErrorStackTrace.ReadOnly = true;
            this.TXTErrorStackTrace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXTErrorStackTrace.Size = new System.Drawing.Size(474, 129);
            this.TXTErrorStackTrace.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Error StackTrace";
            // 
            // TXTErrorDescription
            // 
            this.TXTErrorDescription.Location = new System.Drawing.Point(14, 23);
            this.TXTErrorDescription.Multiline = true;
            this.TXTErrorDescription.Name = "TXTErrorDescription";
            this.TXTErrorDescription.ReadOnly = true;
            this.TXTErrorDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXTErrorDescription.Size = new System.Drawing.Size(474, 81);
            this.TXTErrorDescription.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Error Description";
            // 
            // TABApplicationInfo
            // 
            this.TABApplicationInfo.BackColor = System.Drawing.Color.Silver;
            this.TABApplicationInfo.Controls.Add(this.TXTApplicationInfo);
            this.TABApplicationInfo.Controls.Add(this.label16);
            this.TABApplicationInfo.Location = new System.Drawing.Point(4, 22);
            this.TABApplicationInfo.Name = "TABApplicationInfo";
            this.TABApplicationInfo.Size = new System.Drawing.Size(506, 270);
            this.TABApplicationInfo.TabIndex = 4;
            this.TABApplicationInfo.Text = "Application Info";
            // 
            // TXTApplicationInfo
            // 
            this.TXTApplicationInfo.Location = new System.Drawing.Point(17, 28);
            this.TXTApplicationInfo.Multiline = true;
            this.TXTApplicationInfo.Name = "TXTApplicationInfo";
            this.TXTApplicationInfo.ReadOnly = true;
            this.TXTApplicationInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXTApplicationInfo.Size = new System.Drawing.Size(474, 222);
            this.TXTApplicationInfo.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(14, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Information";
            // 
            // TABMachineInfo
            // 
            this.TABMachineInfo.BackColor = System.Drawing.Color.Silver;
            this.TABMachineInfo.Controls.Add(this.TXTSoftwareInfo);
            this.TABMachineInfo.Controls.Add(this.label8);
            this.TABMachineInfo.Controls.Add(this.TXTHardwareInfo);
            this.TABMachineInfo.Controls.Add(this.label7);
            this.TABMachineInfo.Location = new System.Drawing.Point(4, 22);
            this.TABMachineInfo.Name = "TABMachineInfo";
            this.TABMachineInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TABMachineInfo.Size = new System.Drawing.Size(506, 270);
            this.TABMachineInfo.TabIndex = 1;
            this.TABMachineInfo.Text = "Machine Info";
            // 
            // TXTSoftwareInfo
            // 
            this.TXTSoftwareInfo.Location = new System.Drawing.Point(16, 159);
            this.TXTSoftwareInfo.Multiline = true;
            this.TXTSoftwareInfo.Name = "TXTSoftwareInfo";
            this.TXTSoftwareInfo.ReadOnly = true;
            this.TXTSoftwareInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXTSoftwareInfo.Size = new System.Drawing.Size(474, 105);
            this.TXTSoftwareInfo.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Software Info";
            // 
            // TXTHardwareInfo
            // 
            this.TXTHardwareInfo.Location = new System.Drawing.Point(16, 26);
            this.TXTHardwareInfo.Multiline = true;
            this.TXTHardwareInfo.Name = "TXTHardwareInfo";
            this.TXTHardwareInfo.ReadOnly = true;
            this.TXTHardwareInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXTHardwareInfo.Size = new System.Drawing.Size(474, 105);
            this.TXTHardwareInfo.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hardware Info";
            // 
            // TABMachineState
            // 
            this.TABMachineState.BackColor = System.Drawing.Color.Silver;
            this.TABMachineState.Controls.Add(this.TXTNetworkInfo);
            this.TABMachineState.Controls.Add(this.label9);
            this.TABMachineState.Controls.Add(this.TXTProcessList);
            this.TABMachineState.Controls.Add(this.label10);
            this.TABMachineState.Location = new System.Drawing.Point(4, 22);
            this.TABMachineState.Name = "TABMachineState";
            this.TABMachineState.Padding = new System.Windows.Forms.Padding(3);
            this.TABMachineState.Size = new System.Drawing.Size(506, 270);
            this.TABMachineState.TabIndex = 2;
            this.TABMachineState.Text = "Machine State";
            // 
            // TXTNetworkInfo
            // 
            this.TXTNetworkInfo.Location = new System.Drawing.Point(16, 159);
            this.TXTNetworkInfo.Multiline = true;
            this.TXTNetworkInfo.Name = "TXTNetworkInfo";
            this.TXTNetworkInfo.ReadOnly = true;
            this.TXTNetworkInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXTNetworkInfo.Size = new System.Drawing.Size(474, 105);
            this.TXTNetworkInfo.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Network";
            // 
            // TXTProcessList
            // 
            this.TXTProcessList.Location = new System.Drawing.Point(16, 26);
            this.TXTProcessList.Multiline = true;
            this.TXTProcessList.Name = "TXTProcessList";
            this.TXTProcessList.ReadOnly = true;
            this.TXTProcessList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXTProcessList.Size = new System.Drawing.Size(474, 105);
            this.TXTProcessList.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Process List";
            // 
            // TABSendReport
            // 
            this.TABSendReport.BackColor = System.Drawing.Color.Silver;
            this.TABSendReport.Controls.Add(this.label15);
            this.TABSendReport.Controls.Add(this.BTNSendErrorReport);
            this.TABSendReport.Controls.Add(this.TXTUserReportDescribe);
            this.TABSendReport.Controls.Add(this.label14);
            this.TABSendReport.Controls.Add(this.TXTUsrReportDescription);
            this.TABSendReport.Controls.Add(this.label13);
            this.TABSendReport.Controls.Add(this.TXTUserReportEmail);
            this.TABSendReport.Controls.Add(this.label12);
            this.TABSendReport.Controls.Add(this.TXTUserReportName);
            this.TABSendReport.Controls.Add(this.label11);
            this.TABSendReport.Location = new System.Drawing.Point(4, 22);
            this.TABSendReport.Name = "TABSendReport";
            this.TABSendReport.Padding = new System.Windows.Forms.Padding(3);
            this.TABSendReport.Size = new System.Drawing.Size(506, 270);
            this.TABSendReport.TabIndex = 3;
            this.TABSendReport.Text = "Send Error Report";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(13, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(442, 75);
            this.label15.TabIndex = 13;
            this.label15.Text = resources.GetString("label15.Text");
            // 
            // BTNSendErrorReport
            // 
            this.BTNSendErrorReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNSendErrorReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTNSendErrorReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSendErrorReport.Location = new System.Drawing.Point(400, 237);
            this.BTNSendErrorReport.Name = "BTNSendErrorReport";
            this.BTNSendErrorReport.Size = new System.Drawing.Size(89, 27);
            this.BTNSendErrorReport.TabIndex = 13;
            this.BTNSendErrorReport.Text = "Send";
            this.BTNSendErrorReport.UseVisualStyleBackColor = false;
            this.BTNSendErrorReport.Click += new System.EventHandler(this.BTNSendErrorReport_Click);
            // 
            // TXTUserReportDescribe
            // 
            this.TXTUserReportDescribe.Location = new System.Drawing.Point(16, 196);
            this.TXTUserReportDescribe.MaxLength = 4096;
            this.TXTUserReportDescribe.Multiline = true;
            this.TXTUserReportDescribe.Name = "TXTUserReportDescribe";
            this.TXTUserReportDescribe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXTUserReportDescribe.Size = new System.Drawing.Size(242, 68);
            this.TXTUserReportDescribe.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(13, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(291, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Describe the steps you did before the error occur. -- Optional";
            // 
            // TXTUsrReportDescription
            // 
            this.TXTUsrReportDescription.Location = new System.Drawing.Point(247, 101);
            this.TXTUsrReportDescription.MaxLength = 64;
            this.TXTUsrReportDescription.Name = "TXTUsrReportDescription";
            this.TXTUsrReportDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXTUsrReportDescription.Size = new System.Drawing.Size(242, 20);
            this.TXTUsrReportDescription.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(244, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(223, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Error Description(User Perspective) -- Optional";
            // 
            // TXTUserReportEmail
            // 
            this.TXTUserReportEmail.Location = new System.Drawing.Point(16, 145);
            this.TXTUserReportEmail.MaxLength = 64;
            this.TXTUserReportEmail.Name = "TXTUserReportEmail";
            this.TXTUserReportEmail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXTUserReportEmail.Size = new System.Drawing.Size(222, 20);
            this.TXTUserReportEmail.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(13, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Email";
            // 
            // TXTUserReportName
            // 
            this.TXTUserReportName.Location = new System.Drawing.Point(16, 101);
            this.TXTUserReportName.MaxLength = 64;
            this.TXTUserReportName.Name = "TXTUserReportName";
            this.TXTUserReportName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXTUserReportName.Size = new System.Drawing.Size(222, 20);
            this.TXTUserReportName.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(13, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Name";
            // 
            // TABAbout
            // 
            this.TABAbout.BackColor = System.Drawing.Color.Silver;
            this.TABAbout.Controls.Add(this.label19);
            this.TABAbout.Controls.Add(this.pictureBox1);
            this.TABAbout.Controls.Add(this.label18);
            this.TABAbout.Controls.Add(this.label17);
            this.TABAbout.Location = new System.Drawing.Point(4, 22);
            this.TABAbout.Name = "TABAbout";
            this.TABAbout.Padding = new System.Windows.Forms.Padding(3);
            this.TABAbout.Size = new System.Drawing.Size(506, 270);
            this.TABAbout.TabIndex = 5;
            this.TABAbout.Text = "About";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(7, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(230, 60);
            this.label19.TabIndex = 17;
            this.label19.Text = "Author : Jonnel ross Mendoza\r\nDate Created : 04-12-2019\r\nVersion 1.0.0.3\r\nEmail :" +
                " jonnelross.mendoza@gmail.com\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BugTrap.Properties.Resources.Bug;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(9, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 37);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(65, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(141, 37);
            this.label18.TabIndex = 15;
            this.label18.Text = "BugTrap";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(6, 164);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(492, 45);
            this.label17.TabIndex = 14;
            this.label17.Text = resources.GetString("label17.Text");
            // 
            // LBLinkEmail
            // 
            this.LBLinkEmail.AutoSize = true;
            this.LBLinkEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLinkEmail.LinkColor = System.Drawing.Color.DodgerBlue;
            this.LBLinkEmail.Location = new System.Drawing.Point(178, 129);
            this.LBLinkEmail.Name = "LBLinkEmail";
            this.LBLinkEmail.Size = new System.Drawing.Size(90, 15);
            this.LBLinkEmail.TabIndex = 3;
            this.LBLinkEmail.TabStop = true;
            this.LBLinkEmail.Text = "<APPEMAIL>";
            // 
            // LBLinkSite
            // 
            this.LBLinkSite.AutoSize = true;
            this.LBLinkSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLinkSite.LinkColor = System.Drawing.Color.DodgerBlue;
            this.LBLinkSite.Location = new System.Drawing.Point(178, 157);
            this.LBLinkSite.Name = "LBLinkSite";
            this.LBLinkSite.Size = new System.Drawing.Size(109, 15);
            this.LBLinkSite.TabIndex = 4;
            this.LBLinkSite.TabStop = true;
            this.LBLinkSite.Text = "<APPWEBSITE>";
            // 
            // BTNClose
            // 
            this.BTNClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNClose.Location = new System.Drawing.Point(346, 501);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(180, 27);
            this.BTNClose.TabIndex = 5;
            this.BTNClose.Text = "Close and Exit Application";
            this.BTNClose.UseVisualStyleBackColor = true;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // BTNIgnoreAndContinue
            // 
            this.BTNIgnoreAndContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNIgnoreAndContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNIgnoreAndContinue.Location = new System.Drawing.Point(12, 501);
            this.BTNIgnoreAndContinue.Name = "BTNIgnoreAndContinue";
            this.BTNIgnoreAndContinue.Size = new System.Drawing.Size(180, 27);
            this.BTNIgnoreAndContinue.TabIndex = 6;
            this.BTNIgnoreAndContinue.Text = "Ignore and Continue";
            this.BTNIgnoreAndContinue.UseVisualStyleBackColor = true;
            this.BTNIgnoreAndContinue.Click += new System.EventHandler(this.BTNIgnoreAndContinue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Application Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Application Version";
            // 
            // LBLApplicationName
            // 
            this.LBLApplicationName.AutoSize = true;
            this.LBLApplicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLApplicationName.Location = new System.Drawing.Point(178, 72);
            this.LBLApplicationName.Name = "LBLApplicationName";
            this.LBLApplicationName.Size = new System.Drawing.Size(88, 15);
            this.LBLApplicationName.TabIndex = 9;
            this.LBLApplicationName.Text = "<APPNAME>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Support Website";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Support Email";
            // 
            // LBLVersion
            // 
            this.LBLVersion.AutoSize = true;
            this.LBLVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLVersion.Location = new System.Drawing.Point(178, 99);
            this.LBLVersion.Name = "LBLVersion";
            this.LBLVersion.Size = new System.Drawing.Size(76, 15);
            this.LBLVersion.TabIndex = 12;
            this.LBLVersion.Text = "<APPVER>";
            // 
            // FRMMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(538, 534);
            this.Controls.Add(this.LBLVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBLApplicationName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNIgnoreAndContinue);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.LBLinkSite);
            this.Controls.Add(this.LBLinkEmail);
            this.Controls.Add(this.TCMain);
            this.Controls.Add(this.PicBoxBugTrap);
            this.Controls.Add(this.LBLHeader);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRMMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BugTrap";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBugTrap)).EndInit();
            this.TCMain.ResumeLayout(false);
            this.TABCrashReport.ResumeLayout(false);
            this.TABCrashReport.PerformLayout();
            this.TABApplicationInfo.ResumeLayout(false);
            this.TABApplicationInfo.PerformLayout();
            this.TABMachineInfo.ResumeLayout(false);
            this.TABMachineInfo.PerformLayout();
            this.TABMachineState.ResumeLayout(false);
            this.TABMachineState.PerformLayout();
            this.TABSendReport.ResumeLayout(false);
            this.TABSendReport.PerformLayout();
            this.TABAbout.ResumeLayout(false);
            this.TABAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLHeader;
        private System.Windows.Forms.PictureBox PicBoxBugTrap;
        private System.Windows.Forms.TabControl TCMain;
        private System.Windows.Forms.TabPage TABCrashReport;
        private System.Windows.Forms.TabPage TABMachineInfo;
        private System.Windows.Forms.LinkLabel LBLinkEmail;
        private System.Windows.Forms.LinkLabel LBLinkSite;
        private System.Windows.Forms.TabPage TABMachineState;
        private System.Windows.Forms.TabPage TABSendReport;
        private System.Windows.Forms.Button BTNClose;
        private System.Windows.Forms.Button BTNIgnoreAndContinue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBLApplicationName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBLVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTErrorDescription;
        private System.Windows.Forms.TextBox TXTErrorStackTrace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTSoftwareInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXTHardwareInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTNetworkInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXTProcessList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXTUserReportDescribe;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TXTUsrReportDescription;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TXTUserReportEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXTUserReportName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BTNSendErrorReport;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage TABApplicationInfo;
        private System.Windows.Forms.TextBox TXTApplicationInfo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage TABAbout;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}