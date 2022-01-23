namespace ControlAppDesktop.Forms
{
    partial class RegisterForm
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
            this.lblTcInfo = new System.Windows.Forms.Label();
            this.lblNameInfo = new System.Windows.Forms.Label();
            this.lblSurnameInfo = new System.Windows.Forms.Label();
            this.lblBDateInfo = new System.Windows.Forms.Label();
            this.lblAdressInfo = new System.Windows.Forms.Label();
            this.lblTelInfo = new System.Windows.Forms.Label();
            this.lblMailInfo = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.rtxtAdress = new System.Windows.Forms.RichTextBox();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.mtxbTC = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtRepassword = new System.Windows.Forms.TextBox();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.dtpBDate = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTcInfo
            // 
            this.lblTcInfo.AutoSize = true;
            this.lblTcInfo.Location = new System.Drawing.Point(105, 67);
            this.lblTcInfo.Name = "lblTcInfo";
            this.lblTcInfo.Size = new System.Drawing.Size(27, 13);
            this.lblTcInfo.TabIndex = 0;
            this.lblTcInfo.Text = "TC :";
            // 
            // lblNameInfo
            // 
            this.lblNameInfo.AutoSize = true;
            this.lblNameInfo.Location = new System.Drawing.Point(105, 106);
            this.lblNameInfo.Name = "lblNameInfo";
            this.lblNameInfo.Size = new System.Drawing.Size(26, 13);
            this.lblNameInfo.TabIndex = 1;
            this.lblNameInfo.Text = "Ad :";
            // 
            // lblSurnameInfo
            // 
            this.lblSurnameInfo.AutoSize = true;
            this.lblSurnameInfo.Location = new System.Drawing.Point(105, 145);
            this.lblSurnameInfo.Name = "lblSurnameInfo";
            this.lblSurnameInfo.Size = new System.Drawing.Size(37, 13);
            this.lblSurnameInfo.TabIndex = 2;
            this.lblSurnameInfo.Text = "Soyad";
            // 
            // lblBDateInfo
            // 
            this.lblBDateInfo.AutoSize = true;
            this.lblBDateInfo.Location = new System.Drawing.Point(98, 264);
            this.lblBDateInfo.Name = "lblBDateInfo";
            this.lblBDateInfo.Size = new System.Drawing.Size(76, 13);
            this.lblBDateInfo.TabIndex = 3;
            this.lblBDateInfo.Text = "Doğum Tarihi :";
            // 
            // lblAdressInfo
            // 
            this.lblAdressInfo.AutoSize = true;
            this.lblAdressInfo.Location = new System.Drawing.Point(98, 303);
            this.lblAdressInfo.Name = "lblAdressInfo";
            this.lblAdressInfo.Size = new System.Drawing.Size(40, 13);
            this.lblAdressInfo.TabIndex = 4;
            this.lblAdressInfo.Text = "Adres :";
            // 
            // lblTelInfo
            // 
            this.lblTelInfo.AutoSize = true;
            this.lblTelInfo.Location = new System.Drawing.Point(98, 404);
            this.lblTelInfo.Name = "lblTelInfo";
            this.lblTelInfo.Size = new System.Drawing.Size(49, 13);
            this.lblTelInfo.TabIndex = 5;
            this.lblTelInfo.Text = "Telefon :";
            // 
            // lblMailInfo
            // 
            this.lblMailInfo.AutoSize = true;
            this.lblMailInfo.Location = new System.Drawing.Point(98, 443);
            this.lblMailInfo.Name = "lblMailInfo";
            this.lblMailInfo.Size = new System.Drawing.Size(32, 13);
            this.lblMailInfo.TabIndex = 6;
            this.lblMailInfo.Text = "Mail :";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(246, 496);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Kaydol";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(203, 106);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(203, 145);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(166, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // rtxtAdress
            // 
            this.rtxtAdress.Location = new System.Drawing.Point(196, 290);
            this.rtxtAdress.Name = "rtxtAdress";
            this.rtxtAdress.Size = new System.Drawing.Size(186, 96);
            this.rtxtAdress.TabIndex = 6;
            this.rtxtAdress.Text = "";
            // 
            // mtxtTel
            // 
            this.mtxtTel.Location = new System.Drawing.Point(196, 397);
            this.mtxtTel.Mask = "(999) 000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(165, 20);
            this.mtxtTel.TabIndex = 7;
            this.mtxtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtTel_KeyPress);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(196, 440);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(166, 20);
            this.txtMail.TabIndex = 8;
            // 
            // mtxbTC
            // 
            this.mtxbTC.Location = new System.Drawing.Point(204, 67);
            this.mtxbTC.Mask = "00000000000";
            this.mtxbTC.Name = "mtxbTC";
            this.mtxbTC.Size = new System.Drawing.Size(165, 20);
            this.mtxbTC.TabIndex = 0;
            this.mtxbTC.ValidatingType = typeof(int);
            this.mtxbTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxbTC_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(204, 179);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(166, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(105, 182);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(43, 13);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Parola :";
            // 
            // txtRepassword
            // 
            this.txtRepassword.Location = new System.Drawing.Point(203, 212);
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.Size = new System.Drawing.Size(166, 20);
            this.txtRepassword.TabIndex = 4;
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Location = new System.Drawing.Point(105, 212);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(77, 13);
            this.lblRePassword.TabIndex = 19;
            this.lblRePassword.Text = "Tekrar Parola :";
            // 
            // dtpBDate
            // 
            this.dtpBDate.Location = new System.Drawing.Point(204, 257);
            this.dtpBDate.Name = "dtpBDate";
            this.dtpBDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBDate.TabIndex = 20;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(559, 57);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 731);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtpBDate);
            this.Controls.Add(this.txtRepassword);
            this.Controls.Add(this.lblRePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.mtxbTC);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.mtxtTel);
            this.Controls.Add(this.rtxtAdress);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblMailInfo);
            this.Controls.Add(this.lblTelInfo);
            this.Controls.Add(this.lblAdressInfo);
            this.Controls.Add(this.lblBDateInfo);
            this.Controls.Add(this.lblSurnameInfo);
            this.Controls.Add(this.lblNameInfo);
            this.Controls.Add(this.lblTcInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTcInfo;
        private System.Windows.Forms.Label lblNameInfo;
        private System.Windows.Forms.Label lblSurnameInfo;
        private System.Windows.Forms.Label lblBDateInfo;
        private System.Windows.Forms.Label lblAdressInfo;
        private System.Windows.Forms.Label lblTelInfo;
        private System.Windows.Forms.Label lblMailInfo;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.RichTextBox rtxtAdress;
        private System.Windows.Forms.MaskedTextBox mtxtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.MaskedTextBox mtxbTC;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtRepassword;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.DateTimePicker dtpBDate;
        private System.Windows.Forms.Button btnClose;
    }
}