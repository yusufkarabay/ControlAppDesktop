namespace ControlAppDesktop
{
    partial class Login
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.LnkForgot = new System.Windows.Forms.LinkLabel();
            this.LnkSignUp = new System.Windows.Forms.LinkLabel();
            this.mtxtTC = new System.Windows.Forms.MaskedTextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(105, 60);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(90, 16);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "TC  Kimlik No:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(163, 114);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(37, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Şifre:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(252, 197);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(232, 111);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(171, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "123456";
            // 
            // LnkForgot
            // 
            this.LnkForgot.AutoSize = true;
            this.LnkForgot.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkForgot.Location = new System.Drawing.Point(377, 225);
            this.LnkForgot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LnkForgot.Name = "LnkForgot";
            this.LnkForgot.Size = new System.Drawing.Size(99, 16);
            this.LnkForgot.TabIndex = 5;
            this.LnkForgot.TabStop = true;
            this.LnkForgot.Text = "Şifremi Unuttum";
            this.LnkForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkForgot_LinkClicked);
            // 
            // LnkSignUp
            // 
            this.LnkSignUp.AutoSize = true;
            this.LnkSignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkSignUp.Location = new System.Drawing.Point(152, 225);
            this.LnkSignUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LnkSignUp.Name = "LnkSignUp";
            this.LnkSignUp.Size = new System.Drawing.Size(49, 16);
            this.LnkSignUp.TabIndex = 6;
            this.LnkSignUp.TabStop = true;
            this.LnkSignUp.Text = "Kaydol";
            this.LnkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkSignUp_LinkClicked);
            // 
            // mtxtTC
            // 
            this.mtxtTC.Location = new System.Drawing.Point(232, 60);
            this.mtxtTC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtTC.Mask = "00000000000";
            this.mtxtTC.Name = "mtxtTC";
            this.mtxtTC.Size = new System.Drawing.Size(171, 22);
            this.mtxtTC.TabIndex = 0;
            this.mtxtTC.Text = "22420015174";
            this.mtxtTC.ValidatingType = typeof(int);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(324, 11);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 16);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Zaman";
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 372);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.mtxtTC);
            this.Controls.Add(this.LnkSignUp);
            this.Controls.Add(this.LnkForgot);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Control App Giriş Yap";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel LnkForgot;
        private System.Windows.Forms.LinkLabel LnkSignUp;
        private System.Windows.Forms.MaskedTextBox mtxtTC;
        private System.Windows.Forms.Label lblTime;
    }
}

