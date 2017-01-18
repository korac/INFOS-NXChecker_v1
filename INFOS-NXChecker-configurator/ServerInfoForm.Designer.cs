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
            this.lblServerIP = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.tboxServerIP = new System.Windows.Forms.TextBox();
            this.tboxPort = new System.Windows.Forms.TextBox();
            this.tboxImeBaze = new System.Windows.Forms.TextBox();
            this.gboxServer = new System.Windows.Forms.GroupBox();
            this.gboxPristupni = new System.Windows.Forms.GroupBox();
            this.cBoxLozinka = new System.Windows.Forms.CheckBox();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.errProviderInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTestirajKonekciju = new System.Windows.Forms.Button();
            this.gboxServer.SuspendLayout();
            this.gboxPristupni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderInput)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblServerIP.ForeColor = System.Drawing.Color.DimGray;
            this.lblServerIP.Location = new System.Drawing.Point(27, 36);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(77, 13);
            this.lblServerIP.TabIndex = 1;
            this.lblServerIP.Text = "SERVER IP:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPort.ForeColor = System.Drawing.Color.DimGray;
            this.lblPort.Location = new System.Drawing.Point(39, 88);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(65, 13);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "PORT No:";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatabase.ForeColor = System.Drawing.Color.DimGray;
            this.lblDatabase.Location = new System.Drawing.Point(35, 62);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(69, 13);
            this.lblDatabase.TabIndex = 4;
            this.lblDatabase.Text = "IME BAZE:";
            // 
            // tboxServerIP
            // 
            this.tboxServerIP.Location = new System.Drawing.Point(110, 33);
            this.tboxServerIP.MaxLength = 100;
            this.tboxServerIP.Name = "tboxServerIP";
            this.tboxServerIP.Size = new System.Drawing.Size(180, 20);
            this.tboxServerIP.TabIndex = 6;
            this.tboxServerIP.Validating += new System.ComponentModel.CancelEventHandler(this.tboxServerIP_Validating);
            // 
            // tboxPort
            // 
            this.tboxPort.Location = new System.Drawing.Point(110, 85);
            this.tboxPort.MaxLength = 10;
            this.tboxPort.Name = "tboxPort";
            this.tboxPort.Size = new System.Drawing.Size(180, 20);
            this.tboxPort.TabIndex = 7;
            this.tboxPort.Validating += new System.ComponentModel.CancelEventHandler(this.tboxPort_Validating);
            // 
            // tboxImeBaze
            // 
            this.tboxImeBaze.Location = new System.Drawing.Point(110, 59);
            this.tboxImeBaze.MaxLength = 40;
            this.tboxImeBaze.Name = "tboxImeBaze";
            this.tboxImeBaze.Size = new System.Drawing.Size(180, 20);
            this.tboxImeBaze.TabIndex = 8;
            this.tboxImeBaze.Validating += new System.ComponentModel.CancelEventHandler(this.tboxImeBaze_Validating);
            // 
            // gboxServer
            // 
            this.gboxServer.Controls.Add(this.lblServerIP);
            this.gboxServer.Controls.Add(this.lblPort);
            this.gboxServer.Controls.Add(this.tboxImeBaze);
            this.gboxServer.Controls.Add(this.lblDatabase);
            this.gboxServer.Controls.Add(this.tboxPort);
            this.gboxServer.Controls.Add(this.tboxServerIP);
            this.gboxServer.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gboxServer.Location = new System.Drawing.Point(21, 32);
            this.gboxServer.Name = "gboxServer";
            this.gboxServer.Size = new System.Drawing.Size(322, 132);
            this.gboxServer.TabIndex = 11;
            this.gboxServer.TabStop = false;
            this.gboxServer.Text = "Server";
            // 
            // gboxPristupni
            // 
            this.gboxPristupni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxPristupni.Controls.Add(this.cBoxLozinka);
            this.gboxPristupni.Controls.Add(this.tboxPassword);
            this.gboxPristupni.Controls.Add(this.tboxUsername);
            this.gboxPristupni.Controls.Add(this.lblPassword);
            this.gboxPristupni.Controls.Add(this.lblUsername);
            this.gboxPristupni.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gboxPristupni.Location = new System.Drawing.Point(349, 32);
            this.gboxPristupni.Name = "gboxPristupni";
            this.gboxPristupni.Size = new System.Drawing.Size(348, 132);
            this.gboxPristupni.TabIndex = 12;
            this.gboxPristupni.TabStop = false;
            this.gboxPristupni.Text = "Pristupni podaci";
            // 
            // cBoxLozinka
            // 
            this.cBoxLozinka.AutoSize = true;
            this.cBoxLozinka.Location = new System.Drawing.Point(142, 88);
            this.cBoxLozinka.Name = "cBoxLozinka";
            this.cBoxLozinka.Size = new System.Drawing.Size(94, 17);
            this.cBoxLozinka.TabIndex = 15;
            this.cBoxLozinka.Text = "Pokaži lozinku";
            this.cBoxLozinka.UseVisualStyleBackColor = true;
            this.cBoxLozinka.CheckedChanged += new System.EventHandler(this.cBoxLozinka_CheckedChanged);
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(142, 62);
            this.tboxPassword.MaxLength = 30;
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.PasswordChar = '*';
            this.tboxPassword.Size = new System.Drawing.Size(180, 20);
            this.tboxPassword.TabIndex = 14;
            this.tboxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tboxPassword_Validating);
            // 
            // tboxUsername
            // 
            this.tboxUsername.Location = new System.Drawing.Point(142, 36);
            this.tboxUsername.MaxLength = 50;
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(180, 20);
            this.tboxUsername.TabIndex = 13;
            this.tboxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tboxUsername_Validating);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPassword.ForeColor = System.Drawing.Color.DimGray;
            this.lblPassword.Location = new System.Drawing.Point(72, 65);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 13);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "LOZINKA:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsername.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsername.Location = new System.Drawing.Point(23, 39);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(113, 13);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "KORISNIČKO IME:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZatvori.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnZatvori.Location = new System.Drawing.Point(483, 181);
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
            this.btnSpremi.Location = new System.Drawing.Point(593, 181);
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
            this.btnTestirajKonekciju.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestirajKonekciju.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTestirajKonekciju.FlatAppearance.BorderSize = 0;
            this.btnTestirajKonekciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestirajKonekciju.ForeColor = System.Drawing.Color.White;
            this.btnTestirajKonekciju.Location = new System.Drawing.Point(21, 181);
            this.btnTestirajKonekciju.Name = "btnTestirajKonekciju";
            this.btnTestirajKonekciju.Size = new System.Drawing.Size(144, 40);
            this.btnTestirajKonekciju.TabIndex = 21;
            this.btnTestirajKonekciju.Text = "TESTIRAJ KONEKCIJU";
            this.btnTestirajKonekciju.UseVisualStyleBackColor = false;
            this.btnTestirajKonekciju.Click += new System.EventHandler(this.btnTestirajKonekciju_Click);
            // 
            // ServerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(717, 233);
            this.Controls.Add(this.btnTestirajKonekciju);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.gboxPristupni);
            this.Controls.Add(this.gboxServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServerInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server Info";
            this.Load += new System.EventHandler(this.ServerInfoForm_Load);
            this.gboxServer.ResumeLayout(false);
            this.gboxServer.PerformLayout();
            this.gboxPristupni.ResumeLayout(false);
            this.gboxPristupni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox tboxServerIP;
        private System.Windows.Forms.TextBox tboxPort;
        private System.Windows.Forms.TextBox tboxImeBaze;
        private System.Windows.Forms.GroupBox gboxServer;
        private System.Windows.Forms.GroupBox gboxPristupni;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ErrorProvider errProviderInput;
        private System.Windows.Forms.CheckBox cBoxLozinka;
        private System.Windows.Forms.Button btnTestirajKonekciju;
    }
}