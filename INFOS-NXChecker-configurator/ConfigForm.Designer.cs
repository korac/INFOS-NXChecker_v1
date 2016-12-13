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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gboxPostavke = new System.Windows.Forms.GroupBox();
            this.lblSekunde = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblSati = new System.Windows.Forms.Label();
            this.numMinute = new System.Windows.Forms.NumericUpDown();
            this.numSekunde = new System.Windows.Forms.NumericUpDown();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.numSati = new System.Windows.Forms.NumericUpDown();
            this.tboxPath = new System.Windows.Forms.TextBox();
            this.tabStart = new System.Windows.Forms.TabPage();
            this.btnRunStop = new System.Windows.Forms.Button();
            this.lblServiceStatus = new System.Windows.Forms.Label();
            this.lblServiceDesc = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.gboxPostavke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSekunde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSati)).BeginInit();
            this.tabStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabConfig);
            this.tabControl.Controls.Add(this.tabStart);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(524, 364);
            this.tabControl.TabIndex = 1;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.btnZatvori);
            this.tabConfig.Controls.Add(this.btnSpremi);
            this.tabConfig.Controls.Add(this.lblTitle);
            this.tabConfig.Controls.Add(this.gboxPostavke);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(516, 338);
            this.tabConfig.TabIndex = 0;
            this.tabConfig.Text = "Konfiguracija";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnZatvori.Location = new System.Drawing.Point(247, 290);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(104, 40);
            this.btnZatvori.TabIndex = 12;
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
            this.btnSpremi.Location = new System.Drawing.Point(357, 290);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(104, 40);
            this.btnSpremi.TabIndex = 10;
            this.btnSpremi.Text = "SPREMI";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitle.Location = new System.Drawing.Point(17, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 22);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Konfiguracija Servisa";
            // 
            // gboxPostavke
            // 
            this.gboxPostavke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxPostavke.Controls.Add(this.lblSekunde);
            this.gboxPostavke.Controls.Add(this.lblMinute);
            this.gboxPostavke.Controls.Add(this.lblSati);
            this.gboxPostavke.Controls.Add(this.numMinute);
            this.gboxPostavke.Controls.Add(this.numSekunde);
            this.gboxPostavke.Controls.Add(this.lblPath);
            this.gboxPostavke.Controls.Add(this.btnPath);
            this.gboxPostavke.Controls.Add(this.lblPeriod);
            this.gboxPostavke.Controls.Add(this.numSati);
            this.gboxPostavke.Controls.Add(this.tboxPath);
            this.gboxPostavke.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gboxPostavke.Location = new System.Drawing.Point(39, 56);
            this.gboxPostavke.Name = "gboxPostavke";
            this.gboxPostavke.Size = new System.Drawing.Size(422, 204);
            this.gboxPostavke.TabIndex = 11;
            this.gboxPostavke.TabStop = false;
            this.gboxPostavke.Text = "Postavke";
            // 
            // lblSekunde
            // 
            this.lblSekunde.AutoSize = true;
            this.lblSekunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSekunde.Location = new System.Drawing.Point(338, 42);
            this.lblSekunde.Name = "lblSekunde";
            this.lblSekunde.Size = new System.Drawing.Size(22, 17);
            this.lblSekunde.TabIndex = 13;
            this.lblSekunde.Text = "ss";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMinute.Location = new System.Drawing.Point(263, 42);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(30, 17);
            this.lblMinute.TabIndex = 14;
            this.lblMinute.Text = "mm";
            // 
            // lblSati
            // 
            this.lblSati.AutoSize = true;
            this.lblSati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSati.Location = new System.Drawing.Point(197, 42);
            this.lblSati.Name = "lblSati";
            this.lblSati.Size = new System.Drawing.Size(24, 17);
            this.lblSati.TabIndex = 12;
            this.lblSati.Text = "hh";
            // 
            // numMinute
            // 
            this.numMinute.Location = new System.Drawing.Point(227, 42);
            this.numMinute.Name = "numMinute";
            this.numMinute.Size = new System.Drawing.Size(33, 20);
            this.numMinute.TabIndex = 10;
            // 
            // numSekunde
            // 
            this.numSekunde.Location = new System.Drawing.Point(299, 42);
            this.numSekunde.Name = "numSekunde";
            this.numSekunde.Size = new System.Drawing.Size(33, 20);
            this.numSekunde.TabIndex = 11;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPath.ForeColor = System.Drawing.Color.DimGray;
            this.lblPath.Location = new System.Drawing.Point(18, 79);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(139, 13);
            this.lblPath.TabIndex = 5;
            this.lblPath.Text = "LOKACIJA DATOTEKE:";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(163, 75);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(29, 21);
            this.btnPath.TabIndex = 6;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPeriod.ForeColor = System.Drawing.Color.DimGray;
            this.lblPeriod.Location = new System.Drawing.Point(99, 45);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(58, 13);
            this.lblPeriod.TabIndex = 4;
            this.lblPeriod.Text = "PERIOD:";
            // 
            // numSati
            // 
            this.numSati.Location = new System.Drawing.Point(163, 42);
            this.numSati.Name = "numSati";
            this.numSati.Size = new System.Drawing.Size(33, 20);
            this.numSati.TabIndex = 9;
            // 
            // tboxPath
            // 
            this.tboxPath.Location = new System.Drawing.Point(163, 102);
            this.tboxPath.Multiline = true;
            this.tboxPath.Name = "tboxPath";
            this.tboxPath.Size = new System.Drawing.Size(231, 63);
            this.tboxPath.TabIndex = 3;
            // 
            // tabStart
            // 
            this.tabStart.Controls.Add(this.btnRunStop);
            this.tabStart.Controls.Add(this.lblServiceStatus);
            this.tabStart.Controls.Add(this.lblServiceDesc);
            this.tabStart.Location = new System.Drawing.Point(4, 22);
            this.tabStart.Name = "tabStart";
            this.tabStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabStart.Size = new System.Drawing.Size(516, 338);
            this.tabStart.TabIndex = 1;
            this.tabStart.Text = "Start/Stop";
            this.tabStart.UseVisualStyleBackColor = true;
            // 
            // btnRunStop
            // 
            this.btnRunStop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunStop.FlatAppearance.BorderSize = 0;
            this.btnRunStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRunStop.ForeColor = System.Drawing.Color.White;
            this.btnRunStop.Location = new System.Drawing.Point(170, 127);
            this.btnRunStop.Name = "btnRunStop";
            this.btnRunStop.Size = new System.Drawing.Size(168, 140);
            this.btnRunStop.TabIndex = 3;
            this.btnRunStop.Text = "run/stop";
            this.btnRunStop.UseVisualStyleBackColor = true;
            this.btnRunStop.Click += new System.EventHandler(this.btnRunStop_Click);
            // 
            // lblServiceStatus
            // 
            this.lblServiceStatus.AutoSize = true;
            this.lblServiceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblServiceStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblServiceStatus.Location = new System.Drawing.Point(218, 57);
            this.lblServiceStatus.Name = "lblServiceStatus";
            this.lblServiceStatus.Size = new System.Drawing.Size(80, 20);
            this.lblServiceStatus.TabIndex = 2;
            this.lblServiceStatus.Text = "STATUS";
            // 
            // lblServiceDesc
            // 
            this.lblServiceDesc.AutoSize = true;
            this.lblServiceDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblServiceDesc.Location = new System.Drawing.Point(32, 60);
            this.lblServiceDesc.Name = "lblServiceDesc";
            this.lblServiceDesc.Size = new System.Drawing.Size(180, 17);
            this.lblServiceDesc.TabIndex = 1;
            this.lblServiceDesc.Text = "NX Checker Service status:";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 364);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NXChecker Servis Konfigurator";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            this.gboxPostavke.ResumeLayout(false);
            this.gboxPostavke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSekunde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSati)).EndInit();
            this.tabStart.ResumeLayout(false);
            this.tabStart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblServiceDesc;
        private System.Windows.Forms.Label lblServiceStatus;
        private System.Windows.Forms.Button btnRunStop;
        private System.Windows.Forms.TabPage tabStart;
        private System.Windows.Forms.TextBox tboxPath;
        private System.Windows.Forms.NumericUpDown numSati;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.NumericUpDown numSekunde;
        private System.Windows.Forms.NumericUpDown numMinute;
        private System.Windows.Forms.Label lblSati;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblSekunde;
        private System.Windows.Forms.GroupBox gboxPostavke;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.TabControl tabControl;
    }
}