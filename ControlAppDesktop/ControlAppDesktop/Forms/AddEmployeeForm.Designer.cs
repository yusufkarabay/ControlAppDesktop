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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.chebUser = new System.Windows.Forms.CheckBox();
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
            this.btnClose = new System.Windows.Forms.Button();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmployeeAdd.BackgroundImage")));
            this.btnEmployeeAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmployeeAdd.FlatAppearance.BorderSize = 0;
            this.btnEmployeeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeAdd.Location = new System.Drawing.Point(413, 766);
            this.btnEmployeeAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(40, 39);
            this.btnEmployeeAdd.TabIndex = 12;
            this.btnEmployeeAdd.UseVisualStyleBackColor = true;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
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
            this.grpInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpInfo.Location = new System.Drawing.Point(77, 43);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpInfo.Size = new System.Drawing.Size(699, 697);
            this.grpInfo.TabIndex = 6;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Kişi Bilgileri";
            // 
            // chebUser
            // 
            this.chebUser.AutoSize = true;
            this.chebUser.Location = new System.Drawing.Point(239, 474);
            this.chebUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chebUser.Name = "chebUser";
            this.chebUser.Size = new System.Drawing.Size(54, 21);
            this.chebUser.TabIndex = 8;
            this.chebUser.Text = "Evet";
            this.chebUser.UseVisualStyleBackColor = true;
            this.chebUser.CheckedChanged += new System.EventHandler(this.chebUser_CheckedChanged);
            // 
            // lblAuthority
            // 
            this.lblAuthority.AutoSize = true;
            this.lblAuthority.Location = new System.Drawing.Point(105, 647);
            this.lblAuthority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthority.Name = "lblAuthority";
            this.lblAuthority.Size = new System.Drawing.Size(43, 17);
            this.lblAuthority.TabIndex = 32;
            this.lblAuthority.Text = "Yetki :";
            this.lblAuthority.Visible = false;
            // 
            // cmbAuthority
            // 
            this.cmbAuthority.FormattingEnabled = true;
            this.cmbAuthority.Location = new System.Drawing.Point(239, 618);
            this.cmbAuthority.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAuthority.Name = "cmbAuthority";
            this.cmbAuthority.Size = new System.Drawing.Size(287, 25);
            this.cmbAuthority.TabIndex = 11;
            this.cmbAuthority.Visible = false;
            // 
            // txtRepassword
            // 
            this.txtRepassword.Location = new System.Drawing.Point(237, 583);
            this.txtRepassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.Size = new System.Drawing.Size(415, 22);
            this.txtRepassword.TabIndex = 10;
            this.txtRepassword.Visible = false;
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Location = new System.Drawing.Point(97, 592);
            this.lblRePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(90, 17);
            this.lblRePassword.TabIndex = 30;
            this.lblRePassword.Text = "Tekrar Parola :";
            this.lblRePassword.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(237, 538);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(415, 22);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(101, 542);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(52, 17);
            this.lblPassword.TabIndex = 29;
            this.lblPassword.Text = "Parola :";
            this.lblPassword.Visible = false;
            // 
            // lblIsUser
            // 
            this.lblIsUser.AutoSize = true;
            this.lblIsUser.Location = new System.Drawing.Point(97, 474);
            this.lblIsUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsUser.Name = "lblIsUser";
            this.lblIsUser.Size = new System.Drawing.Size(84, 17);
            this.lblIsUser.TabIndex = 10;
            this.lblIsUser.Text = "Kullanıcı mı ?";
            // 
            // dtpEmployeeBDate
            // 
            this.dtpEmployeeBDate.Location = new System.Drawing.Point(239, 206);
            this.dtpEmployeeBDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEmployeeBDate.Name = "dtpEmployeeBDate";
            this.dtpEmployeeBDate.Size = new System.Drawing.Size(415, 22);
            this.dtpEmployeeBDate.TabIndex = 4;
            // 
            // rtbxAdressInfo
            // 
            this.rtbxAdressInfo.Location = new System.Drawing.Point(239, 345);
            this.rtbxAdressInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbxAdressInfo.Name = "rtbxAdressInfo";
            this.rtbxAdressInfo.Size = new System.Drawing.Size(415, 117);
            this.rtbxAdressInfo.TabIndex = 7;
            this.rtbxAdressInfo.Text = "";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(101, 356);
            this.lblAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(47, 17);
            this.lblAdress.TabIndex = 24;
            this.lblAdress.Text = "Adress";
            // 
            // mtxtMail
            // 
            this.mtxtMail.Location = new System.Drawing.Point(239, 299);
            this.mtxtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtMail.Name = "mtxtMail";
            this.mtxtMail.Size = new System.Drawing.Size(415, 22);
            this.mtxtMail.TabIndex = 6;
            // 
            // mtxtTel
            // 
            this.mtxtTel.Location = new System.Drawing.Point(239, 254);
            this.mtxtTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtTel.Mask = "(999) 000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(415, 22);
            this.mtxtTel.TabIndex = 5;
            // 
            // cbDepartmentInfo
            // 
            this.cbDepartmentInfo.FormattingEnabled = true;
            this.cbDepartmentInfo.Location = new System.Drawing.Point(239, 161);
            this.cbDepartmentInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDepartmentInfo.Name = "cbDepartmentInfo";
            this.cbDepartmentInfo.Size = new System.Drawing.Size(415, 25);
            this.cbDepartmentInfo.TabIndex = 3;
            // 
            // txtSurnmaeInfo
            // 
            this.txtSurnmaeInfo.Location = new System.Drawing.Point(239, 117);
            this.txtSurnmaeInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSurnmaeInfo.Name = "txtSurnmaeInfo";
            this.txtSurnmaeInfo.Size = new System.Drawing.Size(415, 22);
            this.txtSurnmaeInfo.TabIndex = 2;
            // 
            // txtNameInfo
            // 
            this.txtNameInfo.Location = new System.Drawing.Point(239, 71);
            this.txtNameInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameInfo.Name = "txtNameInfo";
            this.txtNameInfo.Size = new System.Drawing.Size(415, 22);
            this.txtNameInfo.TabIndex = 1;
            // 
            // mtxtTcInfo
            // 
            this.mtxtTcInfo.Location = new System.Drawing.Point(239, 21);
            this.mtxtTcInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtTcInfo.Mask = "00000000000";
            this.mtxtTcInfo.Name = "mtxtTcInfo";
            this.mtxtTcInfo.Size = new System.Drawing.Size(415, 22);
            this.mtxtTcInfo.TabIndex = 0;
            this.mtxtTcInfo.ValidatingType = typeof(int);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(101, 299);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 17);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "Mail:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(99, 256);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(54, 17);
            this.lblTel.TabIndex = 13;
            this.lblTel.Text = "Telefon:";
            // 
            // lblBdate
            // 
            this.lblBdate.AutoSize = true;
            this.lblBdate.Location = new System.Drawing.Point(99, 213);
            this.lblBdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBdate.Name = "lblBdate";
            this.lblBdate.Size = new System.Drawing.Size(87, 17);
            this.lblBdate.TabIndex = 11;
            this.lblBdate.Text = "Doğum Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "TC:";
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Location = new System.Drawing.Point(99, 169);
            this.department.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(79, 17);
            this.department.TabIndex = 8;
            this.department.Text = "Departman:";
            // 
            // employeeSurname
            // 
            this.employeeSurname.AutoSize = true;
            this.employeeSurname.Location = new System.Drawing.Point(99, 126);
            this.employeeSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeSurname.Name = "employeeSurname";
            this.employeeSurname.Size = new System.Drawing.Size(48, 17);
            this.employeeSurname.TabIndex = 3;
            this.employeeSurname.Text = "Soyad:";
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Location = new System.Drawing.Point(99, 80);
            this.employeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(28, 17);
            this.employeeName.TabIndex = 2;
            this.employeeName.Text = "Ad:";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::ControlAppDesktop.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(784, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 39);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(855, 884);
            this.Controls.Add(this.btnEmployeeAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployeeForm";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEmployeeAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.CheckBox chebUser;
        private System.Windows.Forms.Label lblAuthority;
        private System.Windows.Forms.ComboBox cmbAuthority;
        private System.Windows.Forms.TextBox txtRepassword;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblIsUser;
        private System.Windows.Forms.DateTimePicker dtpEmployeeBDate;
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
    }
}