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
            this.lblTcInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcInfo.Location = new System.Drawing.Point(49, 84);
            this.lblTcInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTcInfo.Name = "lblTcInfo";
            this.lblTcInfo.Size = new System.Drawing.Size(28, 16);
            this.lblTcInfo.TabIndex = 0;
            this.lblTcInfo.Text = "TC :";
            // 
            // lblNameInfo
            // 
            this.lblNameInfo.AutoSize = true;
            this.lblNameInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameInfo.Location = new System.Drawing.Point(49, 132);
            this.lblNameInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameInfo.Name = "lblNameInfo";
            this.lblNameInfo.Size = new System.Drawing.Size(30, 16);
            this.lblNameInfo.TabIndex = 1;
            this.lblNameInfo.Text = "Ad :";
            // 
            // lblSurnameInfo
            // 
            this.lblSurnameInfo.AutoSize = true;
            this.lblSurnameInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurnameInfo.Location = new System.Drawing.Point(49, 180);
            this.lblSurnameInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurnameInfo.Name = "lblSurnameInfo";
            this.lblSurnameInfo.Size = new System.Drawing.Size(44, 16);
            this.lblSurnameInfo.TabIndex = 2;
            this.lblSurnameInfo.Text = "Soyad";
            // 
            // lblBDateInfo
            // 
            this.lblBDateInfo.AutoSize = true;
            this.lblBDateInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBDateInfo.Location = new System.Drawing.Point(49, 327);
            this.lblBDateInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBDateInfo.Name = "lblBDateInfo";
            this.lblBDateInfo.Size = new System.Drawing.Size(89, 16);
            this.lblBDateInfo.TabIndex = 3;
            this.lblBDateInfo.Text = "Doğum Tarihi :";
            // 
            // lblAdressInfo
            // 
            this.lblAdressInfo.AutoSize = true;
            this.lblAdressInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdressInfo.Location = new System.Drawing.Point(49, 375);
            this.lblAdressInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdressInfo.Name = "lblAdressInfo";
            this.lblAdressInfo.Size = new System.Drawing.Size(47, 16);
            this.lblAdressInfo.TabIndex = 4;
            this.lblAdressInfo.Text = "Adres :";
            // 
            // lblTelInfo
            // 
            this.lblTelInfo.AutoSize = true;
            this.lblTelInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelInfo.Location = new System.Drawing.Point(49, 499);
            this.lblTelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelInfo.Name = "lblTelInfo";
            this.lblTelInfo.Size = new System.Drawing.Size(56, 16);
            this.lblTelInfo.TabIndex = 5;
            this.lblTelInfo.Text = "Telefon :";
            // 
            // lblMailInfo
            // 
            this.lblMailInfo.AutoSize = true;
            this.lblMailInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMailInfo.Location = new System.Drawing.Point(49, 547);
            this.lblMailInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMailInfo.Name = "lblMailInfo";
            this.lblMailInfo.Size = new System.Drawing.Size(38, 16);
            this.lblMailInfo.TabIndex = 6;
            this.lblMailInfo.Text = "Mail :";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(214)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.Location = new System.Drawing.Point(165, 598);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(313, 39);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Kaydol";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.Location = new System.Drawing.Point(165, 131);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.Location = new System.Drawing.Point(165, 178);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(312, 22);
            this.txtSurname.TabIndex = 2;
            // 
            // rtxtAdress
            // 
            this.rtxtAdress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxtAdress.Location = new System.Drawing.Point(165, 371);
            this.rtxtAdress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtAdress.Name = "rtxtAdress";
            this.rtxtAdress.Size = new System.Drawing.Size(312, 117);
            this.rtxtAdress.TabIndex = 6;
            this.rtxtAdress.Text = "";
            // 
            // mtxtTel
            // 
            this.mtxtTel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtTel.Location = new System.Drawing.Point(165, 499);
            this.mtxtTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtTel.Mask = "(999) 000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(312, 22);
            this.mtxtTel.TabIndex = 7;
            this.mtxtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtTel_KeyPress);
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(165, 551);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(311, 22);
            this.txtMail.TabIndex = 8;
            // 
            // mtxbTC
            // 
            this.mtxbTC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxbTC.Location = new System.Drawing.Point(165, 84);
            this.mtxbTC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxbTC.Mask = "00000000000";
            this.mtxbTC.Name = "mtxbTC";
            this.mtxbTC.Size = new System.Drawing.Size(311, 22);
            this.mtxbTC.TabIndex = 0;
            this.mtxbTC.ValidatingType = typeof(int);
            this.mtxbTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxbTC_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(165, 225);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(312, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.Location = new System.Drawing.Point(48, 232);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(51, 16);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Parola :";
            // 
            // txtRepassword
            // 
            this.txtRepassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRepassword.Location = new System.Drawing.Point(165, 272);
            this.txtRepassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.Size = new System.Drawing.Size(312, 22);
            this.txtRepassword.TabIndex = 4;
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRePassword.Location = new System.Drawing.Point(48, 279);
            this.lblRePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(91, 16);
            this.lblRePassword.TabIndex = 19;
            this.lblRePassword.Text = "Tekrar Parola :";
            // 
            // dtpBDate
            // 
            this.dtpBDate.CalendarForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dtpBDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dtpBDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBDate.Location = new System.Drawing.Point(165, 318);
            this.dtpBDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBDate.Name = "dtpBDate";
            this.dtpBDate.Size = new System.Drawing.Size(311, 22);
            this.dtpBDate.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClose.BackgroundImage = global::ControlAppDesktop.Properties.Resources.back;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClose.Location = new System.Drawing.Point(14, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 39);
            this.btnClose.TabIndex = 21;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(562, 800);
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
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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