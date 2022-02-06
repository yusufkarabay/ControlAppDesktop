namespace ControlAppDesktop.Forms
{
    partial class DepartmentForm
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
            this.btnDepartmentList = new System.Windows.Forms.Button();
            this.btnDepartmentUpdate = new System.Windows.Forms.Button();
            this.lblDepartmentNameEdit = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.btnCreateDepartment = new System.Windows.Forms.Button();
            this.gbDepartmentInfo = new System.Windows.Forms.GroupBox();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lblDepartmentNameInfo = new System.Windows.Forms.Label();
            this.dgvDepartment = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.departmentNameUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDepartmentList = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbDepartmentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbDepartmentList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDepartmentList
            // 
            this.btnDepartmentList.Location = new System.Drawing.Point(478, 300);
            this.btnDepartmentList.Name = "btnDepartmentList";
            this.btnDepartmentList.Size = new System.Drawing.Size(75, 23);
            this.btnDepartmentList.TabIndex = 0;
            this.btnDepartmentList.Text = "Listele";
            this.btnDepartmentList.UseVisualStyleBackColor = true;
            this.btnDepartmentList.Click += new System.EventHandler(this.btnDepartmentList_Click);
            // 
            // btnDepartmentUpdate
            // 
            this.btnDepartmentUpdate.Location = new System.Drawing.Point(204, 250);
            this.btnDepartmentUpdate.Name = "btnDepartmentUpdate";
            this.btnDepartmentUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnDepartmentUpdate.TabIndex = 3;
            this.btnDepartmentUpdate.Text = "Güncelle";
            this.btnDepartmentUpdate.UseVisualStyleBackColor = true;
            this.btnDepartmentUpdate.Visible = false;
            this.btnDepartmentUpdate.Click += new System.EventHandler(this.btnDepartmentUpdate_Click);
            // 
            // lblDepartmentNameEdit
            // 
            this.lblDepartmentNameEdit.AutoSize = true;
            this.lblDepartmentNameEdit.Location = new System.Drawing.Point(104, 198);
            this.lblDepartmentNameEdit.Name = "lblDepartmentNameEdit";
            this.lblDepartmentNameEdit.Size = new System.Drawing.Size(116, 17);
            this.lblDepartmentNameEdit.TabIndex = 28;
            this.lblDepartmentNameEdit.Text = "Departman Adı :";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(274, 191);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(263, 23);
            this.txtDepartmentName.TabIndex = 2;
            this.txtDepartmentName.Text = "Departman Adı Giriniz...";
            this.txtDepartmentName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDepartmentName_MouseClick);
            // 
            // btnCreateDepartment
            // 
            this.btnCreateDepartment.Location = new System.Drawing.Point(95, 38);
            this.btnCreateDepartment.Name = "btnCreateDepartment";
            this.btnCreateDepartment.Size = new System.Drawing.Size(184, 23);
            this.btnCreateDepartment.TabIndex = 1;
            this.btnCreateDepartment.Text = "Departman Oluştur";
            this.btnCreateDepartment.UseVisualStyleBackColor = true;
            this.btnCreateDepartment.Click += new System.EventHandler(this.btnCreateDepartment_Click);
            // 
            // gbDepartmentInfo
            // 
            this.gbDepartmentInfo.Controls.Add(this.lblDepartmentName);
            this.gbDepartmentInfo.Controls.Add(this.lblDepartmentNameInfo);
            this.gbDepartmentInfo.Location = new System.Drawing.Point(95, 83);
            this.gbDepartmentInfo.Name = "gbDepartmentInfo";
            this.gbDepartmentInfo.Size = new System.Drawing.Size(423, 89);
            this.gbDepartmentInfo.TabIndex = 25;
            this.gbDepartmentInfo.TabStop = false;
            this.gbDepartmentInfo.Text = "Departman Bilgileri";
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(20, 31);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(116, 17);
            this.lblDepartmentName.TabIndex = 16;
            this.lblDepartmentName.Text = "Departman Adı :";
            // 
            // lblDepartmentNameInfo
            // 
            this.lblDepartmentNameInfo.AutoSize = true;
            this.lblDepartmentNameInfo.Location = new System.Drawing.Point(125, 31);
            this.lblDepartmentNameInfo.Name = "lblDepartmentNameInfo";
            this.lblDepartmentNameInfo.Size = new System.Drawing.Size(22, 17);
            this.lblDepartmentNameInfo.TabIndex = 14;
            this.lblDepartmentNameInfo.Text = "00";
            // 
            // dgvDepartment
            // 
            this.dgvDepartment.AllowUserToAddRows = false;
            this.dgvDepartment.AllowUserToDeleteRows = false;
            this.dgvDepartment.AllowUserToResizeColumns = false;
            this.dgvDepartment.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.dgvDepartment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDepartment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartment.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartment.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDepartment.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepartment.Location = new System.Drawing.Point(3, 19);
            this.dgvDepartment.MultiSelect = false;
            this.dgvDepartment.Name = "dgvDepartment";
            this.dgvDepartment.ReadOnly = true;
            this.dgvDepartment.RowHeadersVisible = false;
            this.dgvDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartment.Size = new System.Drawing.Size(653, 247);
            this.dgvDepartment.TabIndex = 2;
            this.dgvDepartment.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDepartment_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentNameUpdateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 26);
            // 
            // departmentNameUpdateToolStripMenuItem
            // 
            this.departmentNameUpdateToolStripMenuItem.Name = "departmentNameUpdateToolStripMenuItem";
            this.departmentNameUpdateToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.departmentNameUpdateToolStripMenuItem.Text = "Departman Adını Güncelle";
            this.departmentNameUpdateToolStripMenuItem.Click += new System.EventHandler(this.departmentNameUpdateToolStripMenuItem_Click);
            // 
            // gbDepartmentList
            // 
            this.gbDepartmentList.Controls.Add(this.dgvDepartment);
            this.gbDepartmentList.Location = new System.Drawing.Point(95, 329);
            this.gbDepartmentList.Name = "gbDepartmentList";
            this.gbDepartmentList.Size = new System.Drawing.Size(659, 269);
            this.gbDepartmentList.TabIndex = 24;
            this.gbDepartmentList.TabStop = false;
            this.gbDepartmentList.Text = "Departman Listesi";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::ControlAppDesktop.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(751, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DepartmentForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(824, 650);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDepartmentList);
            this.Controls.Add(this.btnDepartmentUpdate);
            this.Controls.Add(this.lblDepartmentNameEdit);
            this.Controls.Add(this.txtDepartmentName);
            this.Controls.Add(this.btnCreateDepartment);
            this.Controls.Add(this.gbDepartmentInfo);
            this.Controls.Add(this.gbDepartmentList);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentForm";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.gbDepartmentInfo.ResumeLayout(false);
            this.gbDepartmentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbDepartmentList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDepartmentList;
        private System.Windows.Forms.Button btnDepartmentUpdate;
        private System.Windows.Forms.Label lblDepartmentNameEdit;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Button btnCreateDepartment;
        private System.Windows.Forms.GroupBox gbDepartmentInfo;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblDepartmentNameInfo;
        private System.Windows.Forms.DataGridView dgvDepartment;
        private System.Windows.Forms.GroupBox gbDepartmentList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem departmentNameUpdateToolStripMenuItem;
    }
}