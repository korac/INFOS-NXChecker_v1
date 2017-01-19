namespace INFOS_NXChecker_configurator
{
    partial class ServerInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerInfoForm));
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.errProviderInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTestirajKonekciju = new System.Windows.Forms.Button();
            this.gboxPartner = new System.Windows.Forms.GroupBox();
            this.lblPartnerSelect = new System.Windows.Forms.Label();
            this.tboxPartnerInsert = new System.Windows.Forms.TextBox();
            this.lblPartnerInsert = new System.Windows.Forms.Label();
            this.tboxPartnerSelect = new System.Windows.Forms.TextBox();
            this.gboxLokacija = new System.Windows.Forms.GroupBox();
            this.tboxLokacijaID = new System.Windows.Forms.TextBox();
            this.lblLokacijaID = new System.Windows.Forms.Label();
            this.lblLokacijaSelect = new System.Windows.Forms.Label();
            this.tboxLokacijaInsert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxLokacijaSelect = new System.Windows.Forms.TextBox();
            this.gboxUredaj = new System.Windows.Forms.GroupBox();
            this.tboxUredajID = new System.Windows.Forms.TextBox();
            this.lblUredajID = new System.Windows.Forms.Label();
            this.lblUredajSelect = new System.Windows.Forms.Label();
            this.tboxUredajInsert = new System.Windows.Forms.TextBox();
            this.lblUredajInsert = new System.Windows.Forms.Label();
            this.tboxUredajSelect = new System.Windows.Forms.TextBox();
            this.lblServerAdresa = new System.Windows.Forms.Label();
            this.tboxServerAdresa = new System.Windows.Forms.TextBox();
            this.gboxStatusLogs = new System.Windows.Forms.GroupBox();
            this.lblStatusInsert = new System.Windows.Forms.Label();
            this.tboxLogsInsert = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxStatusInsert = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderInput)).BeginInit();
            this.gboxPartner.SuspendLayout();
            this.gboxLokacija.SuspendLayout();
            this.gboxUredaj.SuspendLayout();
            this.gboxStatusLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnZatvori.Location = new System.Drawing.Point(394, 335);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(104, 40);
            this.btnZatvori.TabIndex = 20;
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
            this.btnSpremi.Location = new System.Drawing.Point(504, 335);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(104, 40);
            this.btnSpremi.TabIndex = 19;
            this.btnSpremi.Text = "SPREMI";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // errProviderInput
            // 
            this.errProviderInput.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderInput.ContainerControl = this;
            // 
            // btnTestirajKonekciju
            // 
            this.btnTestirajKonekciju.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTestirajKonekciju.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTestirajKonekciju.FlatAppearance.BorderSize = 0;
            this.btnTestirajKonekciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestirajKonekciju.ForeColor = System.Drawing.Color.White;
            this.btnTestirajKonekciju.Location = new System.Drawing.Point(12, 335);
            this.btnTestirajKonekciju.Name = "btnTestirajKonekciju";
            this.btnTestirajKonekciju.Size = new System.Drawing.Size(144, 40);
            this.btnTestirajKonekciju.TabIndex = 21;
            this.btnTestirajKonekciju.Text = "TESTIRAJ KONEKCIJU";
            this.btnTestirajKonekciju.UseVisualStyleBackColor = false;
            this.btnTestirajKonekciju.Click += new System.EventHandler(this.btnTestirajKonekciju_Click);
            // 
            // gboxPartner
            // 
            this.gboxPartner.Controls.Add(this.lblPartnerSelect);
            this.gboxPartner.Controls.Add(this.tboxPartnerInsert);
            this.gboxPartner.Controls.Add(this.lblPartnerInsert);
            this.gboxPartner.Controls.Add(this.tboxPartnerSelect);
            this.gboxPartner.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gboxPartner.Location = new System.Drawing.Point(32, 72);
            this.gboxPartner.Name = "gboxPartner";
            this.gboxPartner.Size = new System.Drawing.Size(279, 95);
            this.gboxPartner.TabIndex = 12;
            this.gboxPartner.TabStop = false;
            this.gboxPartner.Text = "Partner";
            // 
            // lblPartnerSelect
            // 
            this.lblPartnerSelect.AutoSize = true;
            this.lblPartnerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPartnerSelect.ForeColor = System.Drawing.Color.DimGray;
            this.lblPartnerSelect.Location = new System.Drawing.Point(26, 31);
            this.lblPartnerSelect.Name = "lblPartnerSelect";
            this.lblPartnerSelect.Size = new System.Drawing.Size(103, 13);
            this.lblPartnerSelect.TabIndex = 1;
            this.lblPartnerSelect.Text = "Partner SELECT:";
            // 
            // tboxPartnerInsert
            // 
            this.tboxPartnerInsert.Location = new System.Drawing.Point(135, 54);
            this.tboxPartnerInsert.MaxLength = 40;
            this.tboxPartnerInsert.Name = "tboxPartnerInsert";
            this.tboxPartnerInsert.Size = new System.Drawing.Size(128, 20);
            this.tboxPartnerInsert.TabIndex = 8;
            this.tboxPartnerInsert.Validating += new System.ComponentModel.CancelEventHandler(this.tboxPartnerInsert_Validating);
            // 
            // lblPartnerInsert
            // 
            this.lblPartnerInsert.AutoSize = true;
            this.lblPartnerInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPartnerInsert.ForeColor = System.Drawing.Color.DimGray;
            this.lblPartnerInsert.Location = new System.Drawing.Point(27, 57);
            this.lblPartnerInsert.Name = "lblPartnerInsert";
            this.lblPartnerInsert.Size = new System.Drawing.Size(102, 13);
            this.lblPartnerInsert.TabIndex = 4;
            this.lblPartnerInsert.Text = "Partner INSERT:";
            // 
            // tboxPartnerSelect
            // 
            this.tboxPartnerSelect.Location = new System.Drawing.Point(135, 28);
            this.tboxPartnerSelect.MaxLength = 100;
            this.tboxPartnerSelect.Name = "tboxPartnerSelect";
            this.tboxPartnerSelect.Size = new System.Drawing.Size(128, 20);
            this.tboxPartnerSelect.TabIndex = 6;
            this.tboxPartnerSelect.Validating += new System.ComponentModel.CancelEventHandler(this.tboxPartnerSelect_Validating);
            // 
            // gboxLokacija
            // 
            this.gboxLokacija.Controls.Add(this.tboxLokacijaID);
            this.gboxLokacija.Controls.Add(this.lblLokacijaID);
            this.gboxLokacija.Controls.Add(this.lblLokacijaSelect);
            this.gboxLokacija.Controls.Add(this.tboxLokacijaInsert);
            this.gboxLokacija.Controls.Add(this.label2);
            this.gboxLokacija.Controls.Add(this.tboxLokacijaSelect);
            this.gboxLokacija.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gboxLokacija.Location = new System.Drawing.Point(32, 173);
            this.gboxLokacija.Name = "gboxLokacija";
            this.gboxLokacija.Size = new System.Drawing.Size(279, 119);
            this.gboxLokacija.TabIndex = 13;
            this.gboxLokacija.TabStop = false;
            this.gboxLokacija.Text = "Lokacija";
            // 
            // tboxLokacijaID
            // 
            this.tboxLokacijaID.Location = new System.Drawing.Point(135, 80);
            this.tboxLokacijaID.MaxLength = 40;
            this.tboxLokacijaID.Name = "tboxLokacijaID";
            this.tboxLokacijaID.Size = new System.Drawing.Size(128, 20);
            this.tboxLokacijaID.TabIndex = 10;
            this.tboxLokacijaID.Validating += new System.ComponentModel.CancelEventHandler(this.tboxLokacijaID_Validating);
            // 
            // lblLokacijaID
            // 
            this.lblLokacijaID.AutoSize = true;
            this.lblLokacijaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLokacijaID.ForeColor = System.Drawing.Color.DimGray;
            this.lblLokacijaID.Location = new System.Drawing.Point(54, 83);
            this.lblLokacijaID.Name = "lblLokacijaID";
            this.lblLokacijaID.Size = new System.Drawing.Size(75, 13);
            this.lblLokacijaID.TabIndex = 9;
            this.lblLokacijaID.Text = "SELECT ID:";
            // 
            // lblLokacijaSelect
            // 
            this.lblLokacijaSelect.AutoSize = true;
            this.lblLokacijaSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLokacijaSelect.ForeColor = System.Drawing.Color.DimGray;
            this.lblLokacijaSelect.Location = new System.Drawing.Point(19, 31);
            this.lblLokacijaSelect.Name = "lblLokacijaSelect";
            this.lblLokacijaSelect.Size = new System.Drawing.Size(110, 13);
            this.lblLokacijaSelect.TabIndex = 1;
            this.lblLokacijaSelect.Text = "Lokacija SELECT:";
            // 
            // tboxLokacijaInsert
            // 
            this.tboxLokacijaInsert.Location = new System.Drawing.Point(135, 54);
            this.tboxLokacijaInsert.MaxLength = 40;
            this.tboxLokacijaInsert.Name = "tboxLokacijaInsert";
            this.tboxLokacijaInsert.Size = new System.Drawing.Size(128, 20);
            this.tboxLokacijaInsert.TabIndex = 8;
            this.tboxLokacijaInsert.Validating += new System.ComponentModel.CancelEventHandler(this.tboxLokacijaInsert_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lokacija INSERT:";
            // 
            // tboxLokacijaSelect
            // 
            this.tboxLokacijaSelect.Location = new System.Drawing.Point(135, 28);
            this.tboxLokacijaSelect.MaxLength = 100;
            this.tboxLokacijaSelect.Name = "tboxLokacijaSelect";
            this.tboxLokacijaSelect.Size = new System.Drawing.Size(128, 20);
            this.tboxLokacijaSelect.TabIndex = 6;
            this.tboxLokacijaSelect.Validating += new System.ComponentModel.CancelEventHandler(this.tboxLokacijaSelect_Validating);
            // 
            // gboxUredaj
            // 
            this.gboxUredaj.Controls.Add(this.tboxUredajID);
            this.gboxUredaj.Controls.Add(this.lblUredajID);
            this.gboxUredaj.Controls.Add(this.lblUredajSelect);
            this.gboxUredaj.Controls.Add(this.tboxUredajInsert);
            this.gboxUredaj.Controls.Add(this.lblUredajInsert);
            this.gboxUredaj.Controls.Add(this.tboxUredajSelect);
            this.gboxUredaj.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gboxUredaj.Location = new System.Drawing.Point(317, 173);
            this.gboxUredaj.Name = "gboxUredaj";
            this.gboxUredaj.Size = new System.Drawing.Size(279, 119);
            this.gboxUredaj.TabIndex = 14;
            this.gboxUredaj.TabStop = false;
            this.gboxUredaj.Text = "Uređaj";
            // 
            // tboxUredajID
            // 
            this.tboxUredajID.Location = new System.Drawing.Point(135, 80);
            this.tboxUredajID.MaxLength = 40;
            this.tboxUredajID.Name = "tboxUredajID";
            this.tboxUredajID.Size = new System.Drawing.Size(128, 20);
            this.tboxUredajID.TabIndex = 10;
            this.tboxUredajID.Validating += new System.ComponentModel.CancelEventHandler(this.tboxUredajID_Validating);
            // 
            // lblUredajID
            // 
            this.lblUredajID.AutoSize = true;
            this.lblUredajID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUredajID.ForeColor = System.Drawing.Color.DimGray;
            this.lblUredajID.Location = new System.Drawing.Point(48, 83);
            this.lblUredajID.Name = "lblUredajID";
            this.lblUredajID.Size = new System.Drawing.Size(75, 13);
            this.lblUredajID.TabIndex = 9;
            this.lblUredajID.Text = "SELECT ID:";
            // 
            // lblUredajSelect
            // 
            this.lblUredajSelect.AutoSize = true;
            this.lblUredajSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUredajSelect.ForeColor = System.Drawing.Color.DimGray;
            this.lblUredajSelect.Location = new System.Drawing.Point(23, 31);
            this.lblUredajSelect.Name = "lblUredajSelect";
            this.lblUredajSelect.Size = new System.Drawing.Size(100, 13);
            this.lblUredajSelect.TabIndex = 1;
            this.lblUredajSelect.Text = "Uređaj SELECT:";
            // 
            // tboxUredajInsert
            // 
            this.tboxUredajInsert.Location = new System.Drawing.Point(135, 54);
            this.tboxUredajInsert.MaxLength = 40;
            this.tboxUredajInsert.Name = "tboxUredajInsert";
            this.tboxUredajInsert.Size = new System.Drawing.Size(128, 20);
            this.tboxUredajInsert.TabIndex = 8;
            this.tboxUredajInsert.Validating += new System.ComponentModel.CancelEventHandler(this.tboxUredajInsert_Validating);
            // 
            // lblUredajInsert
            // 
            this.lblUredajInsert.AutoSize = true;
            this.lblUredajInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUredajInsert.ForeColor = System.Drawing.Color.DimGray;
            this.lblUredajInsert.Location = new System.Drawing.Point(24, 57);
            this.lblUredajInsert.Name = "lblUredajInsert";
            this.lblUredajInsert.Size = new System.Drawing.Size(99, 13);
            this.lblUredajInsert.TabIndex = 4;
            this.lblUredajInsert.Text = "Uređaj INSERT:";
            // 
            // tboxUredajSelect
            // 
            this.tboxUredajSelect.Location = new System.Drawing.Point(135, 28);
            this.tboxUredajSelect.MaxLength = 100;
            this.tboxUredajSelect.Name = "tboxUredajSelect";
            this.tboxUredajSelect.Size = new System.Drawing.Size(128, 20);
            this.tboxUredajSelect.TabIndex = 6;
            this.tboxUredajSelect.Validating += new System.ComponentModel.CancelEventHandler(this.tboxUredajSelect_Validating);
            // 
            // lblServerAdresa
            // 
            this.lblServerAdresa.AutoSize = true;
            this.lblServerAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblServerAdresa.ForeColor = System.Drawing.Color.DimGray;
            this.lblServerAdresa.Location = new System.Drawing.Point(29, 34);
            this.lblServerAdresa.Name = "lblServerAdresa";
            this.lblServerAdresa.Size = new System.Drawing.Size(115, 13);
            this.lblServerAdresa.TabIndex = 9;
            this.lblServerAdresa.Text = "SERVER ADRESA:";
            // 
            // tboxServerAdresa
            // 
            this.tboxServerAdresa.Location = new System.Drawing.Point(150, 31);
            this.tboxServerAdresa.MaxLength = 100;
            this.tboxServerAdresa.Name = "tboxServerAdresa";
            this.tboxServerAdresa.Size = new System.Drawing.Size(430, 20);
            this.tboxServerAdresa.TabIndex = 10;
            this.tboxServerAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.tboxServerAdresa_Validating);
            // 
            // gboxStatusLogs
            // 
            this.gboxStatusLogs.Controls.Add(this.lblStatusInsert);
            this.gboxStatusLogs.Controls.Add(this.tboxLogsInsert);
            this.gboxStatusLogs.Controls.Add(this.label3);
            this.gboxStatusLogs.Controls.Add(this.tboxStatusInsert);
            this.gboxStatusLogs.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gboxStatusLogs.Location = new System.Drawing.Point(317, 72);
            this.gboxStatusLogs.Name = "gboxStatusLogs";
            this.gboxStatusLogs.Size = new System.Drawing.Size(279, 95);
            this.gboxStatusLogs.TabIndex = 13;
            this.gboxStatusLogs.TabStop = false;
            this.gboxStatusLogs.Text = "Status/Logs";
            // 
            // lblStatusInsert
            // 
            this.lblStatusInsert.AutoSize = true;
            this.lblStatusInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStatusInsert.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatusInsert.Location = new System.Drawing.Point(26, 31);
            this.lblStatusInsert.Name = "lblStatusInsert";
            this.lblStatusInsert.Size = new System.Drawing.Size(97, 13);
            this.lblStatusInsert.TabIndex = 1;
            this.lblStatusInsert.Text = "Status INSERT:";
            // 
            // tboxLogsInsert
            // 
            this.tboxLogsInsert.Location = new System.Drawing.Point(135, 54);
            this.tboxLogsInsert.MaxLength = 40;
            this.tboxLogsInsert.Name = "tboxLogsInsert";
            this.tboxLogsInsert.Size = new System.Drawing.Size(128, 20);
            this.tboxLogsInsert.TabIndex = 8;
            this.tboxLogsInsert.Validating += new System.ComponentModel.CancelEventHandler(this.tboxLogsInsert_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(35, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Logs INSERT:";
            // 
            // tboxStatusInsert
            // 
            this.tboxStatusInsert.Location = new System.Drawing.Point(135, 28);
            this.tboxStatusInsert.MaxLength = 100;
            this.tboxStatusInsert.Name = "tboxStatusInsert";
            this.tboxStatusInsert.Size = new System.Drawing.Size(128, 20);
            this.tboxStatusInsert.TabIndex = 6;
            this.tboxStatusInsert.Validating += new System.ComponentModel.CancelEventHandler(this.tboxStatusInsert_Validating);
            // 
            // ServerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(628, 387);
            this.Controls.Add(this.gboxStatusLogs);
            this.Controls.Add(this.lblServerAdresa);
            this.Controls.Add(this.gboxUredaj);
            this.Controls.Add(this.tboxServerAdresa);
            this.Controls.Add(this.gboxLokacija);
            this.Controls.Add(this.gboxPartner);
            this.Controls.Add(this.btnTestirajKonekciju);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnSpremi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServerInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Info";
            this.Load += new System.EventHandler(this.ServerInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderInput)).EndInit();
            this.gboxPartner.ResumeLayout(false);
            this.gboxPartner.PerformLayout();
            this.gboxLokacija.ResumeLayout(false);
            this.gboxLokacija.PerformLayout();
            this.gboxUredaj.ResumeLayout(false);
            this.gboxUredaj.PerformLayout();
            this.gboxStatusLogs.ResumeLayout(false);
            this.gboxStatusLogs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ErrorProvider errProviderInput;
        private System.Windows.Forms.Button btnTestirajKonekciju;
        private System.Windows.Forms.Label lblServerAdresa;
        private System.Windows.Forms.GroupBox gboxUredaj;
        private System.Windows.Forms.TextBox tboxUredajID;
        private System.Windows.Forms.Label lblUredajID;
        private System.Windows.Forms.Label lblUredajSelect;
        private System.Windows.Forms.TextBox tboxUredajInsert;
        private System.Windows.Forms.Label lblUredajInsert;
        private System.Windows.Forms.TextBox tboxUredajSelect;
        private System.Windows.Forms.TextBox tboxServerAdresa;
        private System.Windows.Forms.GroupBox gboxLokacija;
        private System.Windows.Forms.TextBox tboxLokacijaID;
        private System.Windows.Forms.Label lblLokacijaID;
        private System.Windows.Forms.Label lblLokacijaSelect;
        private System.Windows.Forms.TextBox tboxLokacijaInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxLokacijaSelect;
        private System.Windows.Forms.GroupBox gboxPartner;
        private System.Windows.Forms.Label lblPartnerSelect;
        private System.Windows.Forms.TextBox tboxPartnerInsert;
        private System.Windows.Forms.Label lblPartnerInsert;
        private System.Windows.Forms.TextBox tboxPartnerSelect;
        private System.Windows.Forms.GroupBox gboxStatusLogs;
        private System.Windows.Forms.Label lblStatusInsert;
        private System.Windows.Forms.TextBox tboxLogsInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxStatusInsert;
    }
}