namespace ControlAppDesktop.Forms
{
    partial class EmployeePassiveForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.gbEmployeeSearch = new System.Windows.Forms.GroupBox();
            this.rbMail = new System.Windows.Forms.RadioButton();
            this.rbTel = new System.Windows.Forms.RadioButton();
            this.rbSurname = new System.Windows.Forms.RadioButton();
            this.rbDepartment = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbTc = new System.Windows.Forms.RadioButton();
            this.txtbxSearchEmloyee = new System.Windows.Forms.TextBox();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblMailInfo = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelInfo = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblBdateInfo = new System.Windows.Forms.Label();
            this.lblBdate = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.employeeSurname = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.Label();
            this.lblDepartmentInfo = new System.Windows.Forms.Label();
            this.lblSurnameInfo = new System.Windows.Forms.Label();
            this.lblNameInfo = new System.Windows.Forms.Label();
            this.lblTcInfo = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.returnActiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbEmployeeSearch.SuspendLayout();
            this.grpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(689, 148);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(565, 56);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(200, 21);
            this.cbDepartment.TabIndex = 16;
            this.cbDepartment.Text = "Departman Seçiniz...";
            // 
            // gbEmployeeSearch
            // 
            this.gbEmployeeSearch.Controls.Add(this.rbMail);
            this.gbEmployeeSearch.Controls.Add(this.rbTel);
            this.gbEmployeeSearch.Controls.Add(this.rbSurname);
            this.gbEmployeeSearch.Controls.Add(this.rbDepartment);
            this.gbEmployeeSearch.Controls.Add(this.rbName);
            this.gbEmployeeSearch.Controls.Add(this.rbTc);
            this.gbEmployeeSearch.Location = new System.Drawing.Point(349, 53);
            this.gbEmployeeSearch.Name = "gbEmployeeSearch";
            this.gbEmployeeSearch.Size = new System.Drawing.Size(200, 199);
            this.gbEmployeeSearch.TabIndex = 15;
            this.gbEmployeeSearch.TabStop = false;
            this.gbEmployeeSearch.Text = "Arama Seçeneği";
            // 
            // rbMail
            // 
            this.rbMail.AutoSize = true;
            this.rbMail.Location = new System.Drawing.Point(29, 135);
            this.rbMail.Name = "rbMail";
            this.rbMail.Size = new System.Drawing.Size(97, 17);
            this.rbMail.TabIndex = 6;
            this.rbMail.TabStop = true;
            this.rbMail.Text = "Mail\'e Göre Ara";
            this.rbMail.UseVisualStyleBackColor = true;
            this.rbMail.CheckedChanged += new System.EventHandler(this.rbMail_CheckedChanged);
            // 
            // rbTel
            // 
            this.rbTel.AutoSize = true;
            this.rbTel.Location = new System.Drawing.Point(29, 112);
            this.rbTel.Name = "rbTel";
            this.rbTel.Size = new System.Drawing.Size(114, 17);
            this.rbTel.TabIndex = 5;
            this.rbTel.TabStop = true;
            this.rbTel.Text = "Telefon\'a Göre Ara";
            this.rbTel.UseVisualStyleBackColor = true;
            this.rbTel.CheckedChanged += new System.EventHandler(this.rbTel_CheckedChanged);
            // 
            // rbSurname
            // 
            this.rbSurname.AutoSize = true;
            this.rbSurname.Location = new System.Drawing.Point(29, 66);
            this.rbSurname.Name = "rbSurname";
            this.rbSurname.Size = new System.Drawing.Size(108, 17);
            this.rbSurname.TabIndex = 3;
            this.rbSurname.TabStop = true;
            this.rbSurname.Text = "Soyad\'a Göre Ara";
            this.rbSurname.UseVisualStyleBackColor = true;
            this.rbSurname.CheckedChanged += new System.EventHandler(this.rbSurname_CheckedChanged);
            // 
            // rbDepartment
            // 
            this.rbDepartment.AutoSize = true;
            this.rbDepartment.Location = new System.Drawing.Point(29, 89);
            this.rbDepartment.Name = "rbDepartment";
            this.rbDepartment.Size = new System.Drawing.Size(130, 17);
            this.rbDepartment.TabIndex = 2;
            this.rbDepartment.TabStop = true;
            this.rbDepartment.Text = "Departman\'a Göre Ara";
            this.rbDepartment.UseVisualStyleBackColor = true;
            this.rbDepartment.CheckedChanged += new System.EventHandler(this.rbDepartment_CheckedChanged);
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Location = new System.Drawing.Point(29, 43);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(91, 17);
            this.rbName.TabIndex = 1;
            this.rbName.TabStop = true;
            this.rbName.Text = "Ad\'a Göre Ara";
            this.rbName.UseVisualStyleBackColor = true;
            this.rbName.CheckedChanged += new System.EventHandler(this.rbName_CheckedChanged);
            // 
            // rbTc
            // 
            this.rbTc.AutoSize = true;
            this.rbTc.Location = new System.Drawing.Point(29, 20);
            this.rbTc.Name = "rbTc";
            this.rbTc.Size = new System.Drawing.Size(97, 17);
            this.rbTc.TabIndex = 0;
            this.rbTc.TabStop = true;
            this.rbTc.Text = "TC\'ye Göre Ara";
            this.rbTc.UseVisualStyleBackColor = true;
            this.rbTc.CheckedChanged += new System.EventHandler(this.rbTc_CheckedChanged);
            // 
            // txtbxSearchEmloyee
            // 
            this.txtbxSearchEmloyee.Location = new System.Drawing.Point(565, 56);
            this.txtbxSearchEmloyee.Name = "txtbxSearchEmloyee";
            this.txtbxSearchEmloyee.Size = new System.Drawing.Size(200, 20);
            this.txtbxSearchEmloyee.TabIndex = 14;
            this.txtbxSearchEmloyee.Text = "Personel Ara...";
            this.txtbxSearchEmloyee.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtbxSearchEmloyee_MouseClick);
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Location = new System.Drawing.Point(794, 53);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnSearchEmployee.TabIndex = 13;
            this.btnSearchEmployee.Text = "Ara";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.dgvEmployee);
            this.grpEmployee.Location = new System.Drawing.Point(21, 301);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(1014, 272);
            this.grpEmployee.TabIndex = 12;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Ayrılmış Personel Listesi";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AllowUserToResizeColumns = false;
            this.dgvEmployee.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.dgvEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvEmployee.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(3, 16);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(1008, 253);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmployee_CellMouseClick);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblMailInfo);
            this.grpInfo.Controls.Add(this.lblMail);
            this.grpInfo.Controls.Add(this.lblTelInfo);
            this.grpInfo.Controls.Add(this.lblTel);
            this.grpInfo.Controls.Add(this.lblBdateInfo);
            this.grpInfo.Controls.Add(this.lblBdate);
            this.grpInfo.Controls.Add(this.lblTc);
            this.grpInfo.Controls.Add(this.department);
            this.grpInfo.Controls.Add(this.employeeSurname);
            this.grpInfo.Controls.Add(this.employeeName);
            this.grpInfo.Controls.Add(this.lblDepartmentInfo);
            this.grpInfo.Controls.Add(this.lblSurnameInfo);
            this.grpInfo.Controls.Add(this.lblNameInfo);
            this.grpInfo.Controls.Add(this.lblTcInfo);
            this.grpInfo.Location = new System.Drawing.Point(24, 53);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(300, 220);
            this.grpInfo.TabIndex = 18;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Kişi Bilgileri";
            // 
            // lblMailInfo
            // 
            this.lblMailInfo.AutoSize = true;
            this.lblMailInfo.Location = new System.Drawing.Point(103, 199);
            this.lblMailInfo.Name = "lblMailInfo";
            this.lblMailInfo.Size = new System.Drawing.Size(19, 13);
            this.lblMailInfo.TabIndex = 16;
            this.lblMailInfo.Text = "00";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(6, 199);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(29, 13);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "Mail:";
            // 
            // lblTelInfo
            // 
            this.lblTelInfo.AutoSize = true;
            this.lblTelInfo.Location = new System.Drawing.Point(103, 170);
            this.lblTelInfo.Name = "lblTelInfo";
            this.lblTelInfo.Size = new System.Drawing.Size(19, 13);
            this.lblTelInfo.TabIndex = 14;
            this.lblTelInfo.Text = "00";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(6, 170);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(46, 13);
            this.lblTel.TabIndex = 13;
            this.lblTel.Text = "Telefon:";
            // 
            // lblBdateInfo
            // 
            this.lblBdateInfo.AutoSize = true;
            this.lblBdateInfo.Location = new System.Drawing.Point(103, 141);
            this.lblBdateInfo.Name = "lblBdateInfo";
            this.lblBdateInfo.Size = new System.Drawing.Size(19, 13);
            this.lblBdateInfo.TabIndex = 12;
            this.lblBdateInfo.Text = "00";
            // 
            // lblBdate
            // 
            this.lblBdate.AutoSize = true;
            this.lblBdate.Location = new System.Drawing.Point(6, 141);
            this.lblBdate.Name = "lblBdate";
            this.lblBdate.Size = new System.Drawing.Size(73, 13);
            this.lblBdate.TabIndex = 11;
            this.lblBdate.Text = "Doğum Tarihi:";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(6, 25);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(24, 13);
            this.lblTc.TabIndex = 10;
            this.lblTc.Text = "TC:";
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
            // lblDepartmentInfo
            // 
            this.lblDepartmentInfo.AutoSize = true;
            this.lblDepartmentInfo.Location = new System.Drawing.Point(103, 112);
            this.lblDepartmentInfo.Name = "lblDepartmentInfo";
            this.lblDepartmentInfo.Size = new System.Drawing.Size(19, 13);
            this.lblDepartmentInfo.TabIndex = 9;
            this.lblDepartmentInfo.Text = "00";
            // 
            // lblSurnameInfo
            // 
            this.lblSurnameInfo.AutoSize = true;
            this.lblSurnameInfo.Location = new System.Drawing.Point(103, 83);
            this.lblSurnameInfo.Name = "lblSurnameInfo";
            this.lblSurnameInfo.Size = new System.Drawing.Size(19, 13);
            this.lblSurnameInfo.TabIndex = 5;
            this.lblSurnameInfo.Text = "00";
            // 
            // lblNameInfo
            // 
            this.lblNameInfo.AutoSize = true;
            this.lblNameInfo.Location = new System.Drawing.Point(103, 54);
            this.lblNameInfo.Name = "lblNameInfo";
            this.lblNameInfo.Size = new System.Drawing.Size(19, 13);
            this.lblNameInfo.TabIndex = 4;
            this.lblNameInfo.Text = "00";
            // 
            // lblTcInfo
            // 
            this.lblTcInfo.AutoSize = true;
            this.lblTcInfo.Location = new System.Drawing.Point(103, 25);
            this.lblTcInfo.Name = "lblTcInfo";
            this.lblTcInfo.Size = new System.Drawing.Size(19, 13);
            this.lblTcInfo.TabIndex = 1;
            this.lblTcInfo.Text = "00";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnActiveToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 48);
            // 
            // returnActiveToolStripMenuItem
            // 
            this.returnActiveToolStripMenuItem.Name = "returnActiveToolStripMenuItem";
            this.returnActiveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.returnActiveToolStripMenuItem.Text = "Aktif Yap";
            this.returnActiveToolStripMenuItem.Click += new System.EventHandler(this.returnActiveToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Sil";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // EmployeePassiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 627);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.gbEmployeeSearch);
            this.Controls.Add(this.txtbxSearchEmloyee);
            this.Controls.Add(this.btnSearchEmployee);
            this.Controls.Add(this.grpEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeePassiveForm";
            this.Text = "EmployeePassiveForm";
            this.Load += new System.EventHandler(this.EmployeePassiveForm_Load);
            this.gbEmployeeSearch.ResumeLayout(false);
            this.gbEmployeeSearch.PerformLayout();
            this.grpEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.GroupBox gbEmployeeSearch;
        private System.Windows.Forms.RadioButton rbMail;
        private System.Windows.Forms.RadioButton rbTel;
        private System.Windows.Forms.RadioButton rbSurname;
        private System.Windows.Forms.RadioButton rbDepartment;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbTc;
        private System.Windows.Forms.TextBox txtbxSearchEmloyee;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblMailInfo;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelInfo;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblBdateInfo;
        private System.Windows.Forms.Label lblBdate;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.Label employeeSurname;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.Label lblDepartmentInfo;
        private System.Windows.Forms.Label lblSurnameInfo;
        private System.Windows.Forms.Label lblNameInfo;
        private System.Windows.Forms.Label lblTcInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem returnActiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}