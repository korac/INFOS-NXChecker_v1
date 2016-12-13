namespace INFOS_NXChecker_configurator
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.gboxLogin = new System.Windows.Forms.GroupBox();
            this.tboxKorisnicko = new System.Windows.Forms.TextBox();
            this.lblKorisnicko = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.tboxLozinka = new System.Windows.Forms.TextBox();
            this.errProviderLozinka = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProviderKorisnicko = new System.Windows.Forms.ErrorProvider(this.components);
            this.gboxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderLozinka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderKorisnicko)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(310, 187);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(104, 40);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.White;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnOdustani.Location = new System.Drawing.Point(200, 187);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(104, 40);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "ODUSTANI";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // gboxLogin
            // 
            this.gboxLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gboxLogin.Controls.Add(this.tboxKorisnicko);
            this.gboxLogin.Controls.Add(this.lblKorisnicko);
            this.gboxLogin.Controls.Add(this.lblLozinka);
            this.gboxLogin.Controls.Add(this.tboxLozinka);
            this.gboxLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gboxLogin.Location = new System.Drawing.Point(26, 41);
            this.gboxLogin.Name = "gboxLogin";
            this.gboxLogin.Size = new System.Drawing.Size(388, 114);
            this.gboxLogin.TabIndex = 7;
            this.gboxLogin.TabStop = false;
            this.gboxLogin.Text = "Login";
            // 
            // tboxKorisnicko
            // 
            this.tboxKorisnicko.Location = new System.Drawing.Point(143, 37);
            this.tboxKorisnicko.MaxLength = 100;
            this.tboxKorisnicko.Name = "tboxKorisnicko";
            this.tboxKorisnicko.Size = new System.Drawing.Size(211, 20);
            this.tboxKorisnicko.TabIndex = 0;
            this.tboxKorisnicko.Validating += new System.ComponentModel.CancelEventHandler(this.tboxKorisnicko_Validating);
            // 
            // lblKorisnicko
            // 
            this.lblKorisnicko.AutoSize = true;
            this.lblKorisnicko.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnicko.ForeColor = System.Drawing.Color.DimGray;
            this.lblKorisnicko.Location = new System.Drawing.Point(24, 40);
            this.lblKorisnicko.Name = "lblKorisnicko";
            this.lblKorisnicko.Size = new System.Drawing.Size(113, 13);
            this.lblKorisnicko.TabIndex = 2;
            this.lblKorisnicko.Text = "KORISNIČKO IME:";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLozinka.ForeColor = System.Drawing.Color.DimGray;
            this.lblLozinka.Location = new System.Drawing.Point(73, 66);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(64, 13);
            this.lblLozinka.TabIndex = 3;
            this.lblLozinka.Text = "LOZINKA:";
            // 
            // tboxLozinka
            // 
            this.tboxLozinka.Location = new System.Drawing.Point(143, 63);
            this.tboxLozinka.MaxLength = 100;
            this.tboxLozinka.Name = "tboxLozinka";
            this.tboxLozinka.PasswordChar = '*';
            this.tboxLozinka.Size = new System.Drawing.Size(211, 20);
            this.tboxLozinka.TabIndex = 1;
            this.tboxLozinka.Validating += new System.ComponentModel.CancelEventHandler(this.tboxLozinka_Validating);
            // 
            // errProviderLozinka
            // 
            this.errProviderLozinka.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderLozinka.ContainerControl = this;
            // 
            // errProviderKorisnicko
            // 
            this.errProviderKorisnicko.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProviderKorisnicko.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 239);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.gboxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NX Checker Servis Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.gboxLogin.ResumeLayout(false);
            this.gboxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderLozinka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderKorisnicko)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.GroupBox gboxLogin;
        private System.Windows.Forms.TextBox tboxKorisnicko;
        private System.Windows.Forms.Label lblKorisnicko;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox tboxLozinka;
        private System.Windows.Forms.ErrorProvider errProviderLozinka;
        private System.Windows.Forms.ErrorProvider errProviderKorisnicko;
    }
}