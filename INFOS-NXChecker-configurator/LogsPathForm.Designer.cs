namespace INFOS_NXChecker_configurator
{
    partial class LogsPathForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogsPathForm));
            this.gboxLocation = new System.Windows.Forms.GroupBox();
            this.lblFolderName = new System.Windows.Forms.Label();
            this.tboxFullPath = new System.Windows.Forms.TextBox();
            this.lblFullPath = new System.Windows.Forms.Label();
            this.tboxFolderName = new System.Windows.Forms.TextBox();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.errProviderInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.gboxLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderInput)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxLocation
            // 
            this.gboxLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxLocation.Controls.Add(this.lblFolderName);
            this.gboxLocation.Controls.Add(this.tboxFullPath);
            this.gboxLocation.Controls.Add(this.lblFullPath);
            this.gboxLocation.Controls.Add(this.tboxFolderName);
            this.gboxLocation.ForeColor = System.Drawing.Color.IndianRed;
            this.gboxLocation.Location = new System.Drawing.Point(22, 12);
            this.gboxLocation.Name = "gboxLocation";
            this.gboxLocation.Size = new System.Drawing.Size(437, 95);
            this.gboxLocation.TabIndex = 12;
            this.gboxLocation.TabStop = false;
            this.gboxLocation.Text = "Lokacija";
            // 
            // lblFolderName
            // 
            this.lblFolderName.AutoSize = true;
            this.lblFolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFolderName.ForeColor = System.Drawing.Color.DimGray;
            this.lblFolderName.Location = new System.Drawing.Point(22, 31);
            this.lblFolderName.Name = "lblFolderName";
            this.lblFolderName.Size = new System.Drawing.Size(118, 13);
            this.lblFolderName.TabIndex = 1;
            this.lblFolderName.Text = "NAZIV DATOTEKE:";
            // 
            // tboxFullPath
            // 
            this.tboxFullPath.BackColor = System.Drawing.Color.White;
            this.tboxFullPath.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tboxFullPath.Location = new System.Drawing.Point(149, 54);
            this.tboxFullPath.MaxLength = 40;
            this.tboxFullPath.Name = "tboxFullPath";
            this.tboxFullPath.ReadOnly = true;
            this.tboxFullPath.Size = new System.Drawing.Size(265, 20);
            this.tboxFullPath.TabIndex = 8;
            // 
            // lblFullPath
            // 
            this.lblFullPath.AutoSize = true;
            this.lblFullPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFullPath.ForeColor = System.Drawing.Color.DimGray;
            this.lblFullPath.Location = new System.Drawing.Point(62, 57);
            this.lblFullPath.Name = "lblFullPath";
            this.lblFullPath.Size = new System.Drawing.Size(78, 13);
            this.lblFullPath.TabIndex = 4;
            this.lblFullPath.Text = "FULL PATH:";
            // 
            // tboxFolderName
            // 
            this.tboxFolderName.Location = new System.Drawing.Point(149, 28);
            this.tboxFolderName.MaxLength = 100;
            this.tboxFolderName.Name = "tboxFolderName";
            this.tboxFolderName.Size = new System.Drawing.Size(265, 20);
            this.tboxFolderName.TabIndex = 6;
            this.tboxFolderName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tboxFolderName_KeyUp);
            this.tboxFolderName.Validating += new System.ComponentModel.CancelEventHandler(this.tboxFolderName_Validating);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.ForeColor = System.Drawing.Color.IndianRed;
            this.btnZatvori.Location = new System.Drawing.Point(245, 131);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(104, 40);
            this.btnZatvori.TabIndex = 22;
            this.btnZatvori.Text = "ZATVORI";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpremi.BackColor = System.Drawing.Color.IndianRed;
            this.btnSpremi.FlatAppearance.BorderSize = 0;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.ForeColor = System.Drawing.Color.White;
            this.btnSpremi.Location = new System.Drawing.Point(355, 131);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(104, 40);
            this.btnSpremi.TabIndex = 21;
            this.btnSpremi.Text = "SPREMI";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // errProviderInput
            // 
            this.errProviderInput.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderInput.ContainerControl = this;
            // 
            // LogsPathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(483, 183);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.gboxLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LogsPathForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logs Lokacija";
            this.Load += new System.EventHandler(this.LogsPathForm_Load);
            this.gboxLocation.ResumeLayout(false);
            this.gboxLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxLocation;
        private System.Windows.Forms.Label lblFolderName;
        private System.Windows.Forms.TextBox tboxFullPath;
        private System.Windows.Forms.Label lblFullPath;
        private System.Windows.Forms.TextBox tboxFolderName;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ErrorProvider errProviderInput;
    }
}