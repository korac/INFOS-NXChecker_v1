namespace INFOS_NXChecker_configurator
{
    partial class PartnerPodaciForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartnerPodaciForm));
            this.lblOIB = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.tboxLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.tboxDevice = new System.Windows.Forms.TextBox();
            this.tboxOIB = new System.Windows.Forms.TextBox();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.errProviderInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblPartnerName = new System.Windows.Forms.Label();
            this.tboxPartnerName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderInput)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOIB.ForeColor = System.Drawing.Color.DimGray;
            this.lblOIB.Location = new System.Drawing.Point(98, 58);
            this.lblOIB.Name = "lblOIB";
            this.lblOIB.Size = new System.Drawing.Size(32, 13);
            this.lblOIB.TabIndex = 9;
            this.lblOIB.Text = "OIB:";
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDevice.ForeColor = System.Drawing.Color.DimGray;
            this.lblDevice.Location = new System.Drawing.Point(70, 110);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(60, 13);
            this.lblDevice.TabIndex = 10;
            this.lblDevice.Text = "UREĐAJ:";
            // 
            // tboxLocation
            // 
            this.tboxLocation.Location = new System.Drawing.Point(141, 81);
            this.tboxLocation.MaxLength = 70;
            this.tboxLocation.Name = "tboxLocation";
            this.tboxLocation.Size = new System.Drawing.Size(214, 20);
            this.tboxLocation.TabIndex = 14;
            this.tboxLocation.Validating += new System.ComponentModel.CancelEventHandler(this.tboxLocation_Validating);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLocation.ForeColor = System.Drawing.Color.DimGray;
            this.lblLocation.Location = new System.Drawing.Point(61, 84);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(69, 13);
            this.lblLocation.TabIndex = 11;
            this.lblLocation.Text = "LOKACIJA:";
            // 
            // tboxDevice
            // 
            this.tboxDevice.Location = new System.Drawing.Point(141, 107);
            this.tboxDevice.MaxLength = 30;
            this.tboxDevice.Name = "tboxDevice";
            this.tboxDevice.Size = new System.Drawing.Size(214, 20);
            this.tboxDevice.TabIndex = 13;
            this.tboxDevice.Validating += new System.ComponentModel.CancelEventHandler(this.tboxDevice_Validating);
            // 
            // tboxOIB
            // 
            this.tboxOIB.Location = new System.Drawing.Point(141, 55);
            this.tboxOIB.MaxLength = 11;
            this.tboxOIB.Name = "tboxOIB";
            this.tboxOIB.Size = new System.Drawing.Size(214, 20);
            this.tboxOIB.TabIndex = 12;
            this.tboxOIB.Validating += new System.ComponentModel.CancelEventHandler(this.tboxOIB_Validating);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnZatvori.Location = new System.Drawing.Point(182, 150);
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
            this.btnSpremi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSpremi.FlatAppearance.BorderSize = 0;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.ForeColor = System.Drawing.Color.White;
            this.btnSpremi.Location = new System.Drawing.Point(292, 150);
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
            // lblPartnerName
            // 
            this.lblPartnerName.AutoSize = true;
            this.lblPartnerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPartnerName.ForeColor = System.Drawing.Color.DimGray;
            this.lblPartnerName.Location = new System.Drawing.Point(26, 32);
            this.lblPartnerName.Name = "lblPartnerName";
            this.lblPartnerName.Size = new System.Drawing.Size(104, 13);
            this.lblPartnerName.TabIndex = 23;
            this.lblPartnerName.Text = "IME PARTNERA:";
            // 
            // tboxPartnerName
            // 
            this.tboxPartnerName.Location = new System.Drawing.Point(141, 29);
            this.tboxPartnerName.MaxLength = 80;
            this.tboxPartnerName.Name = "tboxPartnerName";
            this.tboxPartnerName.Size = new System.Drawing.Size(214, 20);
            this.tboxPartnerName.TabIndex = 24;
            this.tboxPartnerName.Validating += new System.ComponentModel.CancelEventHandler(this.tboxPartnerName_Validating);
            // 
            // PartnerPodaciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(408, 202);
            this.Controls.Add(this.lblPartnerName);
            this.Controls.Add(this.tboxPartnerName);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.lblOIB);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.tboxLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.tboxDevice);
            this.Controls.Add(this.tboxOIB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PartnerPodaciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podaci o Partneru";
            this.Load += new System.EventHandler(this.PartnerPodaciForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProviderInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOIB;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.TextBox tboxLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox tboxDevice;
        private System.Windows.Forms.TextBox tboxOIB;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ErrorProvider errProviderInput;
        private System.Windows.Forms.Label lblPartnerName;
        private System.Windows.Forms.TextBox tboxPartnerName;
    }
}