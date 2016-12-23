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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartnerPodaciForm));
            this.lblOIB = new System.Windows.Forms.Label();
            this.lblDevice = new System.Windows.Forms.Label();
            this.tboxLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.tboxDevice = new System.Windows.Forms.TextBox();
            this.tboxOIB = new System.Windows.Forms.TextBox();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOIB
            // 
            this.lblOIB.AutoSize = true;
            this.lblOIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOIB.ForeColor = System.Drawing.Color.DimGray;
            this.lblOIB.Location = new System.Drawing.Point(80, 34);
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
            this.lblDevice.Location = new System.Drawing.Point(52, 86);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(60, 13);
            this.lblDevice.TabIndex = 10;
            this.lblDevice.Text = "UREĐAJ:";
            // 
            // tboxLocation
            // 
            this.tboxLocation.Location = new System.Drawing.Point(123, 57);
            this.tboxLocation.MaxLength = 70;
            this.tboxLocation.Name = "tboxLocation";
            this.tboxLocation.Size = new System.Drawing.Size(214, 20);
            this.tboxLocation.TabIndex = 14;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLocation.ForeColor = System.Drawing.Color.DimGray;
            this.lblLocation.Location = new System.Drawing.Point(43, 60);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(69, 13);
            this.lblLocation.TabIndex = 11;
            this.lblLocation.Text = "LOKACIJA:";
            // 
            // tboxDevice
            // 
            this.tboxDevice.Location = new System.Drawing.Point(123, 83);
            this.tboxDevice.MaxLength = 30;
            this.tboxDevice.Name = "tboxDevice";
            this.tboxDevice.Size = new System.Drawing.Size(214, 20);
            this.tboxDevice.TabIndex = 13;
            // 
            // tboxOIB
            // 
            this.tboxOIB.Location = new System.Drawing.Point(123, 31);
            this.tboxOIB.MaxLength = 11;
            this.tboxOIB.Name = "tboxOIB";
            this.tboxOIB.Size = new System.Drawing.Size(214, 20);
            this.tboxOIB.TabIndex = 12;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnZatvori.Location = new System.Drawing.Point(167, 125);
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
            this.btnSpremi.Location = new System.Drawing.Point(277, 125);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(104, 40);
            this.btnSpremi.TabIndex = 21;
            this.btnSpremi.Text = "SPREMI";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // PartnerPodaciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(393, 177);
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
            this.Text = "Podaci o Partneru";
            this.Load += new System.EventHandler(this.PartnerPodaciForm_Load);
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
    }
}