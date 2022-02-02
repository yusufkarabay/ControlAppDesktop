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
            this.pnlLoginTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLoginTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(147, 587);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(90, 16);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "TC  Kimlik No:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(205, 641);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(37, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Şifre:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(274, 769);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 28);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(274, 638);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(244, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "123456";
            // 
            // LnkForgot
            // 
            this.LnkForgot.AutoSize = true;
            this.LnkForgot.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkForgot.Location = new System.Drawing.Point(458, 809);
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
            this.LnkSignUp.Location = new System.Drawing.Point(105, 687);
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
            this.mtxtTC.Location = new System.Drawing.Point(274, 587);
            this.mtxtTC.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtTC.Mask = "00000000000";
            this.mtxtTC.Name = "mtxtTC";
            this.mtxtTC.Size = new System.Drawing.Size(244, 22);
            this.mtxtTC.TabIndex = 0;
            this.mtxtTC.Text = "22420015174";
            this.mtxtTC.ValidatingType = typeof(int);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(508, 74);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 16);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Zaman";
            // 
            // pnlLoginTop
            // 
            this.pnlLoginTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.pnlLoginTop.Controls.Add(this.btnMinimize);
            this.pnlLoginTop.Controls.Add(this.btnExit);
            this.pnlLoginTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginTop.Name = "pnlLoginTop";
            this.pnlLoginTop.Size = new System.Drawing.Size(750, 26);
            this.pnlLoginTop.TabIndex = 9;
            this.pnlLoginTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLoginTop_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::ControlAppDesktop.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(683, -3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::ControlAppDesktop.Properties.Resources.cancel_red;
            this.btnExit.Location = new System.Drawing.Point(713, -3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(392, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(750, 1000);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlLoginTop);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.mtxtTC);
            this.Controls.Add(this.LnkSignUp);
            this.Controls.Add(this.LnkForgot);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control App Giriş Yap";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlLoginTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel pnlLoginTop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

