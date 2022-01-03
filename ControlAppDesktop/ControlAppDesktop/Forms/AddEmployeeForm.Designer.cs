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
            this.cmbAuthority = new System.Windows.Forms.ComboBox();
            this.authority = new System.Windows.Forms.Label();
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
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.cmbAuthority);
            this.grpInfo.Controls.Add(this.authority);
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
            this.grpInfo.Size = new System.Drawing.Size(435, 369);
            this.grpInfo.TabIndex = 6;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Kişi Bilgileri";
            // 
            // cmbAuthority
            // 
            this.cmbAuthority.FormattingEnabled = true;
            this.cmbAuthority.Location = new System.Drawing.Point(196, 147);
            this.cmbAuthority.Name = "cmbAuthority";
            this.cmbAuthority.Size = new System.Drawing.Size(149, 21);
            this.cmbAuthority.TabIndex = 28;
            // 
            // authority
            // 
            this.authority.AutoSize = true;
            this.authority.Location = new System.Drawing.Point(13, 147);
            this.authority.Name = "authority";
            this.authority.Size = new System.Drawing.Size(37, 13);
            this.authority.TabIndex = 27;
            this.authority.Text = "Yetki :";
            // 
            // dtpEmployeeBDate
            // 
            this.dtpEmployeeBDate.Location = new System.Drawing.Point(196, 176);
            this.dtpEmployeeBDate.Name = "dtpEmployeeBDate";
            this.dtpEmployeeBDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEmployeeBDate.TabIndex = 26;
            // 
            // rtbxAdressInfo
            // 
            this.rtbxAdressInfo.Location = new System.Drawing.Point(179, 253);
            this.rtbxAdressInfo.Name = "rtbxAdressInfo";
            this.rtbxAdressInfo.Size = new System.Drawing.Size(100, 96);
            this.rtbxAdressInfo.TabIndex = 25;
            this.rtbxAdressInfo.Text = "ziyapaşa mah";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(23, 286);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(39, 13);
            this.lblAdress.TabIndex = 24;
            this.lblAdress.Text = "Adress";
            // 
            // mtxtMail
            // 
            this.mtxtMail.Location = new System.Drawing.Point(196, 227);
            this.mtxtMail.Mask = "a@gmail.com";
            this.mtxtMail.Name = "mtxtMail";
            this.mtxtMail.Size = new System.Drawing.Size(149, 20);
            this.mtxtMail.TabIndex = 23;
            // 
            // mtxtTel
            // 
            this.mtxtTel.Location = new System.Drawing.Point(196, 201);
            this.mtxtTel.Mask = "5555555555";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(149, 20);
            this.mtxtTel.TabIndex = 22;
            // 
            // cbDepartmentInfo
            // 
            this.cbDepartmentInfo.FormattingEnabled = true;
            this.cbDepartmentInfo.Location = new System.Drawing.Point(189, 112);
            this.cbDepartmentInfo.Name = "cbDepartmentInfo";
            this.cbDepartmentInfo.Size = new System.Drawing.Size(149, 21);
            this.cbDepartmentInfo.TabIndex = 20;
            // 
            // txtSurnmaeInfo
            // 
            this.txtSurnmaeInfo.Location = new System.Drawing.Point(189, 83);
            this.txtSurnmaeInfo.Name = "txtSurnmaeInfo";
            this.txtSurnmaeInfo.Size = new System.Drawing.Size(149, 20);
            this.txtSurnmaeInfo.TabIndex = 19;
            this.txtSurnmaeInfo.Text = "denemekarabay";
            // 
            // txtNameInfo
            // 
            this.txtNameInfo.Location = new System.Drawing.Point(189, 46);
            this.txtNameInfo.Name = "txtNameInfo";
            this.txtNameInfo.Size = new System.Drawing.Size(149, 20);
            this.txtNameInfo.TabIndex = 18;
            this.txtNameInfo.Text = "deneme";
            // 
            // mtxtTcInfo
            // 
            this.mtxtTcInfo.Location = new System.Drawing.Point(189, 17);
            this.mtxtTcInfo.Name = "mtxtTcInfo";
            this.mtxtTcInfo.Size = new System.Drawing.Size(149, 20);
            this.mtxtTcInfo.TabIndex = 17;
            this.mtxtTcInfo.Text = "99999999999";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(13, 234);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "Mail:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(13, 205);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(46, 13);
            this.lblTel.TabIndex = 13;
            this.lblTel.Text = "Telefon:";
            // 
            // lblBdate
            // 
            this.lblBdate.AutoSize = true;
            this.lblBdate.Location = new System.Drawing.Point(13, 176);
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
            this.btnEmployeeAdd.Location = new System.Drawing.Point(412, 406);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeAdd.TabIndex = 7;
            this.btnEmployeeAdd.Text = "Oluştur";
            this.btnEmployeeAdd.UseVisualStyleBackColor = true;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEmployeeAdd);
            this.Controls.Add(this.grpInfo);
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
        public System.Windows.Forms.ComboBox cmbAuthority;
        private System.Windows.Forms.Label authority;
    }
}