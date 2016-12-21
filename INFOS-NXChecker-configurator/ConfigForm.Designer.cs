namespace INFOS_NXChecker_configurator
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gboxPostavke = new System.Windows.Forms.GroupBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.numSati = new System.Windows.Forms.NumericUpDown();
            this.tboxPath = new System.Windows.Forms.TextBox();
            this.lblStarijeOd1 = new System.Windows.Forms.Label();
            this.numDani = new System.Windows.Forms.NumericUpDown();
            this.lblStarijeOd2 = new System.Windows.Forms.Label();
            this.errProviderBackup = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderTemp1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderTemp2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderTemp3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelStatus.SuspendLayout();
            this.panelKonf.SuspendLayout();
            this.gboxTemps.SuspendLayout();
            this.gboxPostavke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDani)).BeginInit();
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
            this.panelKonf.Controls.Add(this.gboxTemps);
            this.panelKonf.Controls.Add(this.btnZatvori);
            this.panelKonf.Controls.Add(this.btnSpremi);
            this.panelKonf.Controls.Add(this.lblTitle);
            this.panelKonf.Controls.Add(this.gboxPostavke);
            this.panelKonf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelKonf.Location = new System.Drawing.Point(0, 68);
            this.panelKonf.Name = "panelKonf";
            this.panelKonf.Size = new System.Drawing.Size(689, 473);
            this.panelKonf.TabIndex = 3;
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
            this.gboxTemps.Location = new System.Drawing.Point(44, 219);
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
            this.tboxTemp3.ForeColor = System.Drawing.Color.DimGray;
            this.tboxTemp3.Location = new System.Drawing.Point(115, 80);
            this.tboxTemp3.Name = "tboxTemp3";
            this.tboxTemp3.Size = new System.Drawing.Size(466, 20);
            this.tboxTemp3.TabIndex = 18;
            this.tboxTemp3.Validating += new System.ComponentModel.CancelEventHandler(this.tboxTemp3_Validating);
            // 
            // tboxTemp2
            // 
            this.tboxTemp2.ForeColor = System.Drawing.Color.DimGray;
            this.tboxTemp2.Location = new System.Drawing.Point(115, 54);
            this.tboxTemp2.Name = "tboxTemp2";
            this.tboxTemp2.Size = new System.Drawing.Size(466, 20);
            this.tboxTemp2.TabIndex = 17;
            this.tboxTemp2.Validating += new System.ComponentModel.CancelEventHandler(this.tboxTemp2_Validating);
            // 
            // tboxTemp1
            // 
            this.tboxTemp1.ForeColor = System.Drawing.Color.DimGray;
            this.tboxTemp1.Location = new System.Drawing.Point(115, 28);
            this.tboxTemp1.Name = "tboxTemp1";
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
            this.btnZatvori.Location = new System.Drawing.Point(435, 415);
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
            this.btnSpremi.Location = new System.Drawing.Point(545, 415);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(104, 40);
            this.btnSpremi.TabIndex = 14;
            this.btnSpremi.Text = "SPREMI";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(40, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 22);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Konfiguracija Servisa";
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
            this.gboxPostavke.Location = new System.Drawing.Point(44, 61);
            this.gboxPostavke.Name = "gboxPostavke";
            this.gboxPostavke.Size = new System.Drawing.Size(605, 152);
            this.gboxPostavke.TabIndex = 15;
            this.gboxPostavke.TabStop = false;
            this.gboxPostavke.Text = "Postavke";
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
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 541);
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
            this.panelKonf.PerformLayout();
            this.gboxTemps.ResumeLayout(false);
            this.gboxTemps.PerformLayout();
            this.gboxPostavke.ResumeLayout(false);
            this.gboxPostavke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDani)).EndInit();
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
        private System.Windows.Forms.Label lblTitle;
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
    }
}