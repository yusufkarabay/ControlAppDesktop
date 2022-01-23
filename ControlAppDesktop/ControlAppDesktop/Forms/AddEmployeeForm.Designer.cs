namespace ControlAppDesktop.Forms
{
    partial class AddEmployeeForm
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
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblAuthority = new System.Windows.Forms.Label();
            this.cmbAuthority = new System.Windows.Forms.ComboBox();
            this.txtRepassword = new System.Windows.Forms.TextBox();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblIsUser = new System.Windows.Forms.Label();
            this.dtpEmployeeBDate = new System.Windows.Forms.DateTimePicker();
            this.rtbxAdressInfo = new System.Windows.Forms.RichTextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.mtxtMail = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.cbDepartmentInfo = new System.Windows.Forms.ComboBox();
            this.txtSurnmaeInfo = new System.Windows.Forms.TextBox();
            this.txtNameInfo = new System.Windows.Forms.TextBox();
            this.mtxtTcInfo = new System.Windows.Forms.MaskedTextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblBdate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.employeeSurname = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.Label();
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chebUser = new System.Windows.Forms.CheckBox();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.chebUser);
            this.grpInfo.Controls.Add(this.lblAuthority);
            this.grpInfo.Controls.Add(this.cmbAuthority);
            this.grpInfo.Controls.Add(this.txtRepassword);
            this.grpInfo.Controls.Add(this.lblRePassword);
            this.grpInfo.Controls.Add(this.txtPassword);
            this.grpInfo.Controls.Add(this.lblPassword);
            this.grpInfo.Controls.Add(this.lblIsUser);
            this.grpInfo.Controls.Add(this.dtpEmployeeBDate);
            this.grpInfo.Controls.Add(this.rtbxAdressInfo);
            this.grpInfo.Controls.Add(this.lblAdress);
            this.grpInfo.Controls.Add(this.mtxtMail);
            this.grpInfo.Controls.Add(this.mtxtTel);
            this.grpInfo.Controls.Add(this.cbDepartmentInfo);
            this.grpInfo.Controls.Add(this.txtSurnmaeInfo);
            this.grpInfo.Controls.Add(this.txtNameInfo);
            this.grpInfo.Controls.Add(this.mtxtTcInfo);
            this.grpInfo.Controls.Add(this.lblMail);
            this.grpInfo.Controls.Add(this.lblTel);
            this.grpInfo.Controls.Add(this.lblBdate);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.department);
            this.grpInfo.Controls.Add(this.employeeSurname);
            this.grpInfo.Controls.Add(this.employeeName);
            this.grpInfo.Location = new System.Drawing.Point(176, 41);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(459, 495);
            this.grpInfo.TabIndex = 6;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Kişi Bilgileri";
            // 
            // lblAuthority
            // 
            this.lblAuthority.AutoSize = true;
            this.lblAuthority.Location = new System.Drawing.Point(25, 449);
            this.lblAuthority.Name = "lblAuthority";
            this.lblAuthority.Size = new System.Drawing.Size(37, 13);
            this.lblAuthority.TabIndex = 32;
            this.lblAuthority.Text = "Yetki :";
            this.lblAuthority.Visible = false;
            // 
            // cmbAuthority
            // 
            this.cmbAuthority.FormattingEnabled = true;
            this.cmbAuthority.Location = new System.Drawing.Point(180, 441);
            this.cmbAuthority.Name = "cmbAuthority";
            this.cmbAuthority.Size = new System.Drawing.Size(216, 21);
            this.cmbAuthority.TabIndex = 31;
            this.cmbAuthority.Visible = false;
            // 
            // txtRepassword
            // 
            this.txtRepassword.Location = new System.Drawing.Point(179, 410);
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.Size = new System.Drawing.Size(200, 20);
            this.txtRepassword.TabIndex = 28;
            this.txtRepassword.Visible = false;
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Location = new System.Drawing.Point(25, 410);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(77, 13);
            this.lblRePassword.TabIndex = 30;
            this.lblRePassword.Text = "Tekrar Parola :";
            this.lblRePassword.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(180, 377);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 27;
            this.txtPassword.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(25, 380);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(43, 13);
            this.lblPassword.TabIndex = 29;
            this.lblPassword.Text = "Parola :";
            this.lblPassword.Visible = false;
            // 
            // lblIsUser
            // 
            this.lblIsUser.AutoSize = true;
            this.lblIsUser.Location = new System.Drawing.Point(23, 346);
            this.lblIsUser.Name = "lblIsUser";
            this.lblIsUser.Size = new System.Drawing.Size(68, 13);
            this.lblIsUser.TabIndex = 10;
            this.lblIsUser.Text = "Kullanıcı mı ?";
            // 
            // dtpEmployeeBDate
            // 
            this.dtpEmployeeBDate.Location = new System.Drawing.Point(179, 145);
            this.dtpEmployeeBDate.Name = "dtpEmployeeBDate";
            this.dtpEmployeeBDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEmployeeBDate.TabIndex = 26;
            // 
            // rtbxAdressInfo
            // 
            this.rtbxAdressInfo.Location = new System.Drawing.Point(179, 224);
            this.rtbxAdressInfo.Name = "rtbxAdressInfo";
            this.rtbxAdressInfo.Size = new System.Drawing.Size(200, 96);
            this.rtbxAdressInfo.TabIndex = 25;
            this.rtbxAdressInfo.Text = "";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(23, 257);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(39, 13);
            this.lblAdress.TabIndex = 24;
            this.lblAdress.Text = "Adress";
            // 
            // mtxtMail
            // 
            this.mtxtMail.Location = new System.Drawing.Point(179, 198);
            this.mtxtMail.Name = "mtxtMail";
            this.mtxtMail.Size = new System.Drawing.Size(200, 20);
            this.mtxtMail.TabIndex = 23;
            // 
            // mtxtTel
            // 
            this.mtxtTel.Location = new System.Drawing.Point(179, 173);
            this.mtxtTel.Mask = "(999) 000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(200, 20);
            this.mtxtTel.TabIndex = 22;
            // 
            // cbDepartmentInfo
            // 
            this.cbDepartmentInfo.FormattingEnabled = true;
            this.cbDepartmentInfo.Location = new System.Drawing.Point(179, 109);
            this.cbDepartmentInfo.Name = "cbDepartmentInfo";
            this.cbDepartmentInfo.Size = new System.Drawing.Size(200, 21);
            this.cbDepartmentInfo.TabIndex = 20;
            // 
            // txtSurnmaeInfo
            // 
            this.txtSurnmaeInfo.Location = new System.Drawing.Point(179, 76);
            this.txtSurnmaeInfo.Name = "txtSurnmaeInfo";
            this.txtSurnmaeInfo.Size = new System.Drawing.Size(200, 20);
            this.txtSurnmaeInfo.TabIndex = 19;
            // 
            // txtNameInfo
            // 
            this.txtNameInfo.Location = new System.Drawing.Point(179, 43);
            this.txtNameInfo.Name = "txtNameInfo";
            this.txtNameInfo.Size = new System.Drawing.Size(200, 20);
            this.txtNameInfo.TabIndex = 18;
            // 
            // mtxtTcInfo
            // 
            this.mtxtTcInfo.Location = new System.Drawing.Point(179, 17);
            this.mtxtTcInfo.Mask = "00000000000";
            this.mtxtTcInfo.Name = "mtxtTcInfo";
            this.mtxtTcInfo.Size = new System.Drawing.Size(200, 20);
            this.mtxtTcInfo.TabIndex = 17;
            this.mtxtTcInfo.ValidatingType = typeof(int);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(13, 205);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "Mail:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(13, 176);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(46, 13);
            this.lblTel.TabIndex = 13;
            this.lblTel.Text = "Telefon:";
            // 
            // lblBdate
            // 
            this.lblBdate.AutoSize = true;
            this.lblBdate.Location = new System.Drawing.Point(13, 147);
            this.lblBdate.Name = "lblBdate";
            this.lblBdate.Size = new System.Drawing.Size(73, 13);
            this.lblBdate.TabIndex = 11;
            this.lblBdate.Text = "Doğum Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "TC:";
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Location = new System.Drawing.Point(6, 112);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(62, 13);
            this.department.TabIndex = 8;
            this.department.Text = "Departman:";
            // 
            // employeeSurname
            // 
            this.employeeSurname.AutoSize = true;
            this.employeeSurname.Location = new System.Drawing.Point(6, 83);
            this.employeeSurname.Name = "employeeSurname";
            this.employeeSurname.Size = new System.Drawing.Size(40, 13);
            this.employeeSurname.TabIndex = 3;
            this.employeeSurname.Text = "Soyad:";
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Location = new System.Drawing.Point(6, 54);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(23, 13);
            this.employeeName.TabIndex = 2;
            this.employeeName.Text = "Ad:";
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.Location = new System.Drawing.Point(385, 581);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeAdd.TabIndex = 7;
            this.btnEmployeeAdd.Text = "Oluştur";
            this.btnEmployeeAdd.UseVisualStyleBackColor = true;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(695, 28);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chebUser
            // 
            this.chebUser.AutoSize = true;
            this.chebUser.Location = new System.Drawing.Point(179, 346);
            this.chebUser.Name = "chebUser";
            this.chebUser.Size = new System.Drawing.Size(48, 17);
            this.chebUser.TabIndex = 33;
            this.chebUser.Text = "Evet";
            this.chebUser.UseVisualStyleBackColor = true;
            this.chebUser.CheckedChanged += new System.EventHandler(this.chebUser_CheckedChanged);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 736);
            this.Controls.Add(this.btnEmployeeAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfo;
        public System.Windows.Forms.RichTextBox rtbxAdressInfo;
        private System.Windows.Forms.Label lblAdress;
        public System.Windows.Forms.MaskedTextBox mtxtMail;
        public System.Windows.Forms.MaskedTextBox mtxtTel;
        public System.Windows.Forms.ComboBox cbDepartmentInfo;
        public System.Windows.Forms.TextBox txtSurnmaeInfo;
        public System.Windows.Forms.TextBox txtNameInfo;
        public System.Windows.Forms.MaskedTextBox mtxtTcInfo;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblBdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.Label employeeSurname;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.Button btnEmployeeAdd;
        private System.Windows.Forms.DateTimePicker dtpEmployeeBDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblIsUser;
        private System.Windows.Forms.TextBox txtRepassword;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAuthority;
        private System.Windows.Forms.ComboBox cmbAuthority;
        private System.Windows.Forms.CheckBox chebUser;
    }
}