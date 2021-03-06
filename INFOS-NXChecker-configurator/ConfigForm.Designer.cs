﻿namespace INFOS_NXChecker_configurator
{
    partial class ConfigForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.btnRunStop = new System.Windows.Forms.Button();
            this.lblServiceStatus = new System.Windows.Forms.Label();
            this.lblServiceDesc = new System.Windows.Forms.Label();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panelKonf = new System.Windows.Forms.Panel();
            this.gboxLogs = new System.Windows.Forms.GroupBox();
            this.lblFolderName = new System.Windows.Forms.Label();
            this.btnChangeLogs = new System.Windows.Forms.Button();
            this.btnOpenLogs = new System.Windows.Forms.Button();
            this.lblLogs = new System.Windows.Forms.Label();
            this.gboxPartnerPodaci = new System.Windows.Forms.GroupBox();
            this.lblPartnerName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.btnPartnerPodaci = new System.Windows.Forms.Button();
            this.gboxServerInfo = new System.Windows.Forms.GroupBox();
            this.lblFullAddressInfo = new System.Windows.Forms.Label();
            this.btnServerInfo = new System.Windows.Forms.Button();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.gboxTemps = new System.Windows.Forms.GroupBox();
            this.btnTemp3 = new System.Windows.Forms.Button();
            this.btnTemp2 = new System.Windows.Forms.Button();
            this.btnTemp1 = new System.Windows.Forms.Button();
            this.tboxTemp3 = new System.Windows.Forms.TextBox();
            this.tboxTemp2 = new System.Windows.Forms.TextBox();
            this.tboxTemp1 = new System.Windows.Forms.TextBox();
            this.lblTemp3 = new System.Windows.Forms.Label();
            this.lblTemp2 = new System.Windows.Forms.Label();
            this.lblTemp1 = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.gboxPostavke = new System.Windows.Forms.GroupBox();
            this.lblStarijeOd2 = new System.Windows.Forms.Label();
            this.numDani = new System.Windows.Forms.NumericUpDown();
            this.lblStarijeOd1 = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.numSati = new System.Windows.Forms.NumericUpDown();
            this.tboxPath = new System.Windows.Forms.TextBox();
            this.errProviderBackup = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderTemp1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderTemp2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderTemp3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelStatus.SuspendLayout();
            this.panelKonf.SuspendLayout();
            this.gboxLogs.SuspendLayout();
            this.gboxPartnerPodaci.SuspendLayout();
            this.gboxServerInfo.SuspendLayout();
            this.gboxTemps.SuspendLayout();
            this.gboxPostavke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderTemp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderTemp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderTemp3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRunStop
            // 
            this.btnRunStop.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRunStop.BackColor = System.Drawing.Color.White;
            this.btnRunStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRunStop.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnRunStop.Location = new System.Drawing.Point(573, 12);
            this.btnRunStop.Name = "btnRunStop";
            this.btnRunStop.Size = new System.Drawing.Size(104, 40);
            this.btnRunStop.TabIndex = 3;
            this.btnRunStop.Text = "RUN/STOP";
            this.btnRunStop.UseVisualStyleBackColor = false;
            this.btnRunStop.Click += new System.EventHandler(this.btnRunStop_Click);
            // 
            // lblServiceStatus
            // 
            this.lblServiceStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblServiceStatus.AutoSize = true;
            this.lblServiceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblServiceStatus.ForeColor = System.Drawing.Color.White;
            this.lblServiceStatus.Location = new System.Drawing.Point(209, 20);
            this.lblServiceStatus.Name = "lblServiceStatus";
            this.lblServiceStatus.Size = new System.Drawing.Size(80, 20);
            this.lblServiceStatus.TabIndex = 2;
            this.lblServiceStatus.Text = "STATUS";
            // 
            // lblServiceDesc
            // 
            this.lblServiceDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblServiceDesc.AutoSize = true;
            this.lblServiceDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblServiceDesc.ForeColor = System.Drawing.Color.White;
            this.lblServiceDesc.Location = new System.Drawing.Point(23, 23);
            this.lblServiceDesc.Name = "lblServiceDesc";
            this.lblServiceDesc.Size = new System.Drawing.Size(180, 17);
            this.lblServiceDesc.TabIndex = 1;
            this.lblServiceDesc.Text = "NX Checker Service status:";
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelStatus.Controls.Add(this.btnRefresh);
            this.panelStatus.Controls.Add(this.btnRunStop);
            this.panelStatus.Controls.Add(this.lblServiceStatus);
            this.panelStatus.Controls.Add(this.lblServiceDesc);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Location = new System.Drawing.Point(0, 0);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(689, 62);
            this.panelStatus.TabIndex = 2;
            // 
            // panelKonf
            // 
            this.panelKonf.BackColor = System.Drawing.Color.White;
            this.panelKonf.Controls.Add(this.gboxLogs);
            this.panelKonf.Controls.Add(this.gboxPartnerPodaci);
            this.panelKonf.Controls.Add(this.gboxServerInfo);
            this.panelKonf.Controls.Add(this.gboxTemps);
            this.panelKonf.Controls.Add(this.btnZatvori);
            this.panelKonf.Controls.Add(this.btnSpremi);
            this.panelKonf.Controls.Add(this.gboxPostavke);
            this.panelKonf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelKonf.Location = new System.Drawing.Point(0, 68);
            this.panelKonf.Name = "panelKonf";
            this.panelKonf.Size = new System.Drawing.Size(689, 548);
            this.panelKonf.TabIndex = 3;
            // 
            // gboxLogs
            // 
            this.gboxLogs.Controls.Add(this.lblFolderName);
            this.gboxLogs.Controls.Add(this.btnChangeLogs);
            this.gboxLogs.Controls.Add(this.btnOpenLogs);
            this.gboxLogs.Controls.Add(this.lblLogs);
            this.gboxLogs.ForeColor = System.Drawing.Color.IndianRed;
            this.gboxLogs.Location = new System.Drawing.Point(44, 415);
            this.gboxLogs.Name = "gboxLogs";
            this.gboxLogs.Size = new System.Drawing.Size(605, 52);
            this.gboxLogs.TabIndex = 20;
            this.gboxLogs.TabStop = false;
            this.gboxLogs.Text = "Logs lokacije";
            // 
            // lblFolderName
            // 
            this.lblFolderName.AutoSize = true;
            this.lblFolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFolderName.Location = new System.Drawing.Point(157, 23);
            this.lblFolderName.Name = "lblFolderName";
            this.lblFolderName.Size = new System.Drawing.Size(138, 13);
            this.lblFolderName.TabIndex = 24;
            this.lblFolderName.Text = "DODAJ LOGS FOLDER";
            // 
            // btnChangeLogs
            // 
            this.btnChangeLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeLogs.BackColor = System.Drawing.Color.IndianRed;
            this.btnChangeLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeLogs.ForeColor = System.Drawing.Color.White;
            this.btnChangeLogs.Location = new System.Drawing.Point(399, 12);
            this.btnChangeLogs.Name = "btnChangeLogs";
            this.btnChangeLogs.Size = new System.Drawing.Size(97, 34);
            this.btnChangeLogs.TabIndex = 23;
            this.btnChangeLogs.Text = "IZMIJENI";
            this.btnChangeLogs.UseVisualStyleBackColor = false;
            this.btnChangeLogs.EnabledChanged += new System.EventHandler(this.btnChangeLogs_EnabledChanged);
            this.btnChangeLogs.Click += new System.EventHandler(this.btnChangeLogs_Click);
            // 
            // btnOpenLogs
            // 
            this.btnOpenLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenLogs.BackColor = System.Drawing.Color.IndianRed;
            this.btnOpenLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenLogs.ForeColor = System.Drawing.Color.White;
            this.btnOpenLogs.Location = new System.Drawing.Point(502, 12);
            this.btnOpenLogs.Name = "btnOpenLogs";
            this.btnOpenLogs.Size = new System.Drawing.Size(97, 34);
            this.btnOpenLogs.TabIndex = 22;
            this.btnOpenLogs.Text = "OTVORI";
            this.btnOpenLogs.UseVisualStyleBackColor = false;
            this.btnOpenLogs.EnabledChanged += new System.EventHandler(this.btnChangeLogs_EnabledChanged);
            this.btnOpenLogs.Click += new System.EventHandler(this.btnOpenLogs_Click);
            // 
            // lblLogs
            // 
            this.lblLogs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLogs.AutoSize = true;
            this.lblLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogs.ForeColor = System.Drawing.Color.DimGray;
            this.lblLogs.Location = new System.Drawing.Point(17, 23);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(134, 13);
            this.lblLogs.TabIndex = 21;
            this.lblLogs.Text = "NAZIV DIREKTORIJA:";
            // 
            // gboxPartnerPodaci
            // 
            this.gboxPartnerPodaci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxPartnerPodaci.Controls.Add(this.lblPartnerName);
            this.gboxPartnerPodaci.Controls.Add(this.lblLocation);
            this.gboxPartnerPodaci.Controls.Add(this.lblDevice);
            this.gboxPartnerPodaci.Controls.Add(this.btnPartnerPodaci);
            this.gboxPartnerPodaci.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gboxPartnerPodaci.Location = new System.Drawing.Point(415, 19);
            this.gboxPartnerPodaci.Name = "gboxPartnerPodaci";
            this.gboxPartnerPodaci.Size = new System.Drawing.Size(234, 104);
            this.gboxPartnerPodaci.TabIndex = 19;
            this.gboxPartnerPodaci.TabStop = false;
            this.gboxPartnerPodaci.Text = "Partner podaci";
            // 
            // lblPartnerName
            // 
            this.lblPartnerName.AutoSize = true;
            this.lblPartnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPartnerName.ForeColor = System.Drawing.Color.DimGray;
            this.lblPartnerName.Location = new System.Drawing.Point(17, 23);
            this.lblPartnerName.Name = "lblPartnerName";
            this.lblPartnerName.Size = new System.Drawing.Size(73, 13);
            this.lblPartnerName.TabIndex = 25;
            this.lblPartnerName.Text = "Unesite ime";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLocation.ForeColor = System.Drawing.Color.DimGray;
            this.lblLocation.Location = new System.Drawing.Point(17, 51);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(98, 13);
            this.lblLocation.TabIndex = 23;
            this.lblLocation.Text = "Unesite lokaciju";
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDevice.ForeColor = System.Drawing.Color.DimGray;
            this.lblDevice.Location = new System.Drawing.Point(17, 78);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(90, 13);
            this.lblDevice.TabIndex = 24;
            this.lblDevice.Text = "Unesite uređaj";
            // 
            // btnPartnerPodaci
            // 
            this.btnPartnerPodaci.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPartnerPodaci.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPartnerPodaci.FlatAppearance.BorderSize = 0;
            this.btnPartnerPodaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartnerPodaci.ForeColor = System.Drawing.Color.White;
            this.btnPartnerPodaci.Location = new System.Drawing.Point(156, 23);
            this.btnPartnerPodaci.Name = "btnPartnerPodaci";
            this.btnPartnerPodaci.Size = new System.Drawing.Size(72, 68);
            this.btnPartnerPodaci.TabIndex = 23;
            this.btnPartnerPodaci.Text = "IZMIJENI";
            this.btnPartnerPodaci.UseVisualStyleBackColor = false;
            this.btnPartnerPodaci.Click += new System.EventHandler(this.btnPartnerPodaci_Click);
            // 
            // gboxServerInfo
            // 
            this.gboxServerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxServerInfo.Controls.Add(this.lblFullAddressInfo);
            this.gboxServerInfo.Controls.Add(this.btnServerInfo);
            this.gboxServerInfo.Controls.Add(this.lblServerIP);
            this.gboxServerInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gboxServerInfo.Location = new System.Drawing.Point(44, 19);
            this.gboxServerInfo.Name = "gboxServerInfo";
            this.gboxServerInfo.Size = new System.Drawing.Size(365, 104);
            this.gboxServerInfo.TabIndex = 18;
            this.gboxServerInfo.TabStop = false;
            this.gboxServerInfo.Text = "Server Info";
            // 
            // lblFullAddressInfo
            // 
            this.lblFullAddressInfo.AutoSize = true;
            this.lblFullAddressInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFullAddressInfo.ForeColor = System.Drawing.Color.DimGray;
            this.lblFullAddressInfo.Location = new System.Drawing.Point(12, 51);
            this.lblFullAddressInfo.Name = "lblFullAddressInfo";
            this.lblFullAddressInfo.Size = new System.Drawing.Size(100, 13);
            this.lblFullAddressInfo.TabIndex = 20;
            this.lblFullAddressInfo.Text = "Server ip adresa";
            // 
            // btnServerInfo
            // 
            this.btnServerInfo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnServerInfo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnServerInfo.FlatAppearance.BorderSize = 0;
            this.btnServerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServerInfo.ForeColor = System.Drawing.Color.White;
            this.btnServerInfo.Location = new System.Drawing.Point(278, 23);
            this.btnServerInfo.Name = "btnServerInfo";
            this.btnServerInfo.Size = new System.Drawing.Size(72, 68);
            this.btnServerInfo.TabIndex = 19;
            this.btnServerInfo.Text = "IZMIJENI";
            this.btnServerInfo.UseVisualStyleBackColor = false;
            this.btnServerInfo.Click += new System.EventHandler(this.btnServerInfo_Click);
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblServerIP.ForeColor = System.Drawing.Color.DimGray;
            this.lblServerIP.Location = new System.Drawing.Point(12, 23);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(123, 13);
            this.lblServerIP.TabIndex = 0;
            this.lblServerIP.Text = "ADRESA SERVERA:";
            // 
            // gboxTemps
            // 
            this.gboxTemps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxTemps.Controls.Add(this.btnTemp3);
            this.gboxTemps.Controls.Add(this.btnTemp2);
            this.gboxTemps.Controls.Add(this.btnTemp1);
            this.gboxTemps.Controls.Add(this.tboxTemp3);
            this.gboxTemps.Controls.Add(this.tboxTemp2);
            this.gboxTemps.Controls.Add(this.tboxTemp1);
            this.gboxTemps.Controls.Add(this.lblTemp3);
            this.gboxTemps.Controls.Add(this.lblTemp2);
            this.gboxTemps.Controls.Add(this.lblTemp1);
            this.gboxTemps.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gboxTemps.Location = new System.Drawing.Point(44, 287);
            this.gboxTemps.Name = "gboxTemps";
            this.gboxTemps.Size = new System.Drawing.Size(605, 122);
            this.gboxTemps.TabIndex = 17;
            this.gboxTemps.TabStop = false;
            this.gboxTemps.Text = "Temp lokacije";
            // 
            // btnTemp3
            // 
            this.btnTemp3.Location = new System.Drawing.Point(80, 79);
            this.btnTemp3.Name = "btnTemp3";
            this.btnTemp3.Size = new System.Drawing.Size(29, 21);
            this.btnTemp3.TabIndex = 20;
            this.btnTemp3.Text = "...";
            this.btnTemp3.UseVisualStyleBackColor = true;
            this.btnTemp3.Click += new System.EventHandler(this.btnTemp3_Click);
            // 
            // btnTemp2
            // 
            this.btnTemp2.Location = new System.Drawing.Point(80, 53);
            this.btnTemp2.Name = "btnTemp2";
            this.btnTemp2.Size = new System.Drawing.Size(29, 21);
            this.btnTemp2.TabIndex = 19;
            this.btnTemp2.Text = "...";
            this.btnTemp2.UseVisualStyleBackColor = true;
            this.btnTemp2.Click += new System.EventHandler(this.btnTemp2_Click);
            // 
            // btnTemp1
            // 
            this.btnTemp1.Location = new System.Drawing.Point(80, 27);
            this.btnTemp1.Name = "btnTemp1";
            this.btnTemp1.Size = new System.Drawing.Size(29, 21);
            this.btnTemp1.TabIndex = 13;
            this.btnTemp1.Text = "...";
            this.btnTemp1.UseVisualStyleBackColor = true;
            this.btnTemp1.Click += new System.EventHandler(this.btnTemp1_Click);
            // 
            // tboxTemp3
            // 
            this.tboxTemp3.BackColor = System.Drawing.Color.White;
            this.tboxTemp3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tboxTemp3.Location = new System.Drawing.Point(115, 80);
            this.tboxTemp3.Name = "tboxTemp3";
            this.tboxTemp3.ReadOnly = true;
            this.tboxTemp3.Size = new System.Drawing.Size(466, 20);
            this.tboxTemp3.TabIndex = 18;
            this.tboxTemp3.Validating += new System.ComponentModel.CancelEventHandler(this.tboxTemp3_Validating);
            // 
            // tboxTemp2
            // 
            this.tboxTemp2.BackColor = System.Drawing.Color.White;
            this.tboxTemp2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tboxTemp2.Location = new System.Drawing.Point(115, 54);
            this.tboxTemp2.Name = "tboxTemp2";
            this.tboxTemp2.ReadOnly = true;
            this.tboxTemp2.Size = new System.Drawing.Size(466, 20);
            this.tboxTemp2.TabIndex = 17;
            this.tboxTemp2.Validating += new System.ComponentModel.CancelEventHandler(this.tboxTemp2_Validating);
            // 
            // tboxTemp1
            // 
            this.tboxTemp1.BackColor = System.Drawing.Color.White;
            this.tboxTemp1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tboxTemp1.Location = new System.Drawing.Point(115, 28);
            this.tboxTemp1.Name = "tboxTemp1";
            this.tboxTemp1.ReadOnly = true;
            this.tboxTemp1.Size = new System.Drawing.Size(466, 20);
            this.tboxTemp1.TabIndex = 16;
            this.tboxTemp1.Validating += new System.ComponentModel.CancelEventHandler(this.tboxTemp1_Validating);
            // 
            // lblTemp3
            // 
            this.lblTemp3.AutoSize = true;
            this.lblTemp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemp3.ForeColor = System.Drawing.Color.DimGray;
            this.lblTemp3.Location = new System.Drawing.Point(18, 83);
            this.lblTemp3.Name = "lblTemp3";
            this.lblTemp3.Size = new System.Drawing.Size(56, 13);
            this.lblTemp3.TabIndex = 15;
            this.lblTemp3.Text = "TEMP 3:";
            // 
            // lblTemp2
            // 
            this.lblTemp2.AutoSize = true;
            this.lblTemp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemp2.ForeColor = System.Drawing.Color.DimGray;
            this.lblTemp2.Location = new System.Drawing.Point(18, 57);
            this.lblTemp2.Name = "lblTemp2";
            this.lblTemp2.Size = new System.Drawing.Size(56, 13);
            this.lblTemp2.TabIndex = 14;
            this.lblTemp2.Text = "TEMP 2:";
            // 
            // lblTemp1
            // 
            this.lblTemp1.AutoSize = true;
            this.lblTemp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTemp1.ForeColor = System.Drawing.Color.DimGray;
            this.lblTemp1.Location = new System.Drawing.Point(18, 31);
            this.lblTemp1.Name = "lblTemp1";
            this.lblTemp1.Size = new System.Drawing.Size(56, 13);
            this.lblTemp1.TabIndex = 13;
            this.lblTemp1.Text = "TEMP 1:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnZatvori.Location = new System.Drawing.Point(435, 496);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(104, 40);
            this.btnZatvori.TabIndex = 16;
            this.btnZatvori.Text = "ZATVORI";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpremi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSpremi.FlatAppearance.BorderSize = 0;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.ForeColor = System.Drawing.Color.White;
            this.btnSpremi.Location = new System.Drawing.Point(545, 496);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(104, 40);
            this.btnSpremi.TabIndex = 14;
            this.btnSpremi.Text = "SPREMI";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.EnabledChanged += new System.EventHandler(this.btnSpremi_EnabledChanged);
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // gboxPostavke
            // 
            this.gboxPostavke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxPostavke.Controls.Add(this.lblStarijeOd2);
            this.gboxPostavke.Controls.Add(this.numDani);
            this.gboxPostavke.Controls.Add(this.lblStarijeOd1);
            this.gboxPostavke.Controls.Add(this.lblPath);
            this.gboxPostavke.Controls.Add(this.btnPath);
            this.gboxPostavke.Controls.Add(this.lblPeriod);
            this.gboxPostavke.Controls.Add(this.numSati);
            this.gboxPostavke.Controls.Add(this.tboxPath);
            this.gboxPostavke.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gboxPostavke.Location = new System.Drawing.Point(44, 129);
            this.gboxPostavke.Name = "gboxPostavke";
            this.gboxPostavke.Size = new System.Drawing.Size(605, 152);
            this.gboxPostavke.TabIndex = 15;
            this.gboxPostavke.TabStop = false;
            this.gboxPostavke.Text = "Postavke";
            // 
            // lblStarijeOd2
            // 
            this.lblStarijeOd2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStarijeOd2.AutoSize = true;
            this.lblStarijeOd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStarijeOd2.ForeColor = System.Drawing.Color.DimGray;
            this.lblStarijeOd2.Location = new System.Drawing.Point(180, 107);
            this.lblStarijeOd2.Name = "lblStarijeOd2";
            this.lblStarijeOd2.Size = new System.Drawing.Size(128, 13);
            this.lblStarijeOd2.TabIndex = 15;
            this.lblStarijeOd2.Text = "dana će biti izbrisane";
            // 
            // numDani
            // 
            this.numDani.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.numDani.Location = new System.Drawing.Point(141, 105);
            this.numDani.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numDani.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDani.Name = "numDani";
            this.numDani.Size = new System.Drawing.Size(33, 20);
            this.numDani.TabIndex = 14;
            this.numDani.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblStarijeOd1
            // 
            this.lblStarijeOd1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStarijeOd1.AutoSize = true;
            this.lblStarijeOd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStarijeOd1.ForeColor = System.Drawing.Color.DimGray;
            this.lblStarijeOd1.Location = new System.Drawing.Point(20, 107);
            this.lblStarijeOd1.Name = "lblStarijeOd1";
            this.lblStarijeOd1.Size = new System.Drawing.Size(115, 13);
            this.lblStarijeOd1.TabIndex = 13;
            this.lblStarijeOd1.Text = "Datoteke starije od";
            // 
            // lblPath
            // 
            this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPath.ForeColor = System.Drawing.Color.DimGray;
            this.lblPath.Location = new System.Drawing.Point(13, 72);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(122, 13);
            this.lblPath.TabIndex = 5;
            this.lblPath.Text = "BACKUP LOKACIJA:";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(141, 68);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(29, 21);
            this.btnPath.TabIndex = 6;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // lblPeriod
            // 
            this.lblPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPeriod.ForeColor = System.Drawing.Color.DimGray;
            this.lblPeriod.Location = new System.Drawing.Point(17, 35);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(118, 13);
            this.lblPeriod.TabIndex = 4;
            this.lblPeriod.Text = "PERIOD (Br. SATI):";
            // 
            // numSati
            // 
            this.numSati.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.numSati.Location = new System.Drawing.Point(141, 32);
            this.numSati.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numSati.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSati.Name = "numSati";
            this.numSati.Size = new System.Drawing.Size(33, 20);
            this.numSati.TabIndex = 9;
            this.numSati.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tboxPath
            // 
            this.tboxPath.BackColor = System.Drawing.Color.White;
            this.tboxPath.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tboxPath.Location = new System.Drawing.Point(176, 69);
            this.tboxPath.Multiline = true;
            this.tboxPath.Name = "tboxPath";
            this.tboxPath.ReadOnly = true;
            this.tboxPath.Size = new System.Drawing.Size(405, 20);
            this.tboxPath.TabIndex = 3;
            this.tboxPath.Validating += new System.ComponentModel.CancelEventHandler(this.tboxPath_Validating);
            // 
            // errProviderBackup
            // 
            this.errProviderBackup.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderBackup.ContainerControl = this;
            // 
            // errProviderTemp1
            // 
            this.errProviderTemp1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderTemp1.ContainerControl = this;
            // 
            // errProviderTemp2
            // 
            this.errProviderTemp2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderTemp2.ContainerControl = this;
            // 
            // errProviderTemp3
            // 
            this.errProviderTemp3.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderTemp3.ContainerControl = this;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRefresh.FlatAppearance.BorderSize = 3;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::INFOS_NXChecker_configurator.Properties.Resources.refresh2;
            this.btnRefresh.Location = new System.Drawing.Point(463, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(104, 40);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 616);
            this.Controls.Add(this.panelKonf);
            this.Controls.Add(this.panelStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NXChecker Servis Konfigurator";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.panelKonf.ResumeLayout(false);
            this.gboxLogs.ResumeLayout(false);
            this.gboxLogs.PerformLayout();
            this.gboxPartnerPodaci.ResumeLayout(false);
            this.gboxPartnerPodaci.PerformLayout();
            this.gboxServerInfo.ResumeLayout(false);
            this.gboxServerInfo.PerformLayout();
            this.gboxTemps.ResumeLayout(false);
            this.gboxTemps.PerformLayout();
            this.gboxPostavke.ResumeLayout(false);
            this.gboxPostavke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderTemp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderTemp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderTemp3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblServiceDesc;
        private System.Windows.Forms.Label lblServiceStatus;
        private System.Windows.Forms.Button btnRunStop;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Panel panelKonf;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.GroupBox gboxPostavke;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.NumericUpDown numSati;
        private System.Windows.Forms.TextBox tboxPath;
        private System.Windows.Forms.GroupBox gboxTemps;
        private System.Windows.Forms.TextBox tboxTemp3;
        private System.Windows.Forms.TextBox tboxTemp2;
        private System.Windows.Forms.TextBox tboxTemp1;
        private System.Windows.Forms.Label lblTemp3;
        private System.Windows.Forms.Label lblTemp2;
        private System.Windows.Forms.Label lblTemp1;
        private System.Windows.Forms.Button btnTemp3;
        private System.Windows.Forms.Button btnTemp2;
        private System.Windows.Forms.Button btnTemp1;
        private System.Windows.Forms.Label lblStarijeOd2;
        private System.Windows.Forms.NumericUpDown numDani;
        private System.Windows.Forms.Label lblStarijeOd1;
        private System.Windows.Forms.ErrorProvider errProviderBackup;
        private System.Windows.Forms.ErrorProvider errProviderTemp1;
        private System.Windows.Forms.ErrorProvider errProviderTemp2;
        private System.Windows.Forms.ErrorProvider errProviderTemp3;
        private System.Windows.Forms.GroupBox gboxServerInfo;
        private System.Windows.Forms.Label lblFullAddressInfo;
        private System.Windows.Forms.Button btnServerInfo;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.GroupBox gboxPartnerPodaci;
        private System.Windows.Forms.Button btnPartnerPodaci;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.Label lblPartnerName;
        private System.Windows.Forms.GroupBox gboxLogs;
        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.Button btnOpenLogs;
        private System.Windows.Forms.Button btnChangeLogs;
        private System.Windows.Forms.Label lblFolderName;
        private System.Windows.Forms.Button btnRefresh;
    }
}