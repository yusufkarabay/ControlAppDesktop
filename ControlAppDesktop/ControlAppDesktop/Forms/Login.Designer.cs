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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.LnkForgot = new System.Windows.Forms.LinkLabel();
            this.LnkSignUp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(111, 120);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(67, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Kullanıcı Adı:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(145, 176);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(31, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Şifre:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(179, 357);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(222, 120);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(222, 176);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // LnkForgot
            // 
            this.LnkForgot.AutoSize = true;
            this.LnkForgot.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkForgot.Location = new System.Drawing.Point(326, 367);
            this.LnkForgot.Name = "LnkForgot";
            this.LnkForgot.Size = new System.Drawing.Size(81, 13);
            this.LnkForgot.TabIndex = 5;
            this.LnkForgot.TabStop = true;
            this.LnkForgot.Text = "Şifremi Unuttum";
            // 
            // LnkSignUp
            // 
            this.LnkSignUp.AutoSize = true;
            this.LnkSignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkSignUp.Location = new System.Drawing.Point(67, 367);
            this.LnkSignUp.Name = "LnkSignUp";
            this.LnkSignUp.Size = new System.Drawing.Size(39, 13);
            this.LnkSignUp.TabIndex = 6;
            this.LnkSignUp.TabStop = true;
            this.LnkSignUp.Text = "Kaydol";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 723);
            this.Controls.Add(this.LnkSignUp);
            this.Controls.Add(this.LnkForgot);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Name = "Login";
            this.Text = "Control App Giriş Yap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel LnkForgot;
        private System.Windows.Forms.LinkLabel LnkSignUp;
    }
}

