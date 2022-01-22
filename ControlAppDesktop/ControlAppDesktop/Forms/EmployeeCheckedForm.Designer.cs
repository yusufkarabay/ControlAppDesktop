namespace ControlAppDesktop.Forms
{
    partial class EmployeeCheckedForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.dgvNotCheckedEmployee = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.okToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblAuthority = new System.Windows.Forms.Label();
            this.cbAuthority = new System.Windows.Forms.ComboBox();
            this.grpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotCheckedEmployee)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(984, 53);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.dgvNotCheckedEmployee);
            this.grpEmployee.Location = new System.Drawing.Point(81, 194);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(1014, 272);
            this.grpEmployee.TabIndex = 4;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Onay Bekleyen Personel Listesi";
            // 
            // dgvNotCheckedEmployee
            // 
            this.dgvNotCheckedEmployee.AllowUserToAddRows = false;
            this.dgvNotCheckedEmployee.AllowUserToDeleteRows = false;
            this.dgvNotCheckedEmployee.AllowUserToResizeColumns = false;
            this.dgvNotCheckedEmployee.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.dgvNotCheckedEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotCheckedEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotCheckedEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotCheckedEmployee.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvNotCheckedEmployee.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvNotCheckedEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotCheckedEmployee.Location = new System.Drawing.Point(3, 16);
            this.dgvNotCheckedEmployee.MultiSelect = false;
            this.dgvNotCheckedEmployee.Name = "dgvNotCheckedEmployee";
            this.dgvNotCheckedEmployee.ReadOnly = true;
            this.dgvNotCheckedEmployee.RowHeadersVisible = false;
            this.dgvNotCheckedEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotCheckedEmployee.Size = new System.Drawing.Size(1008, 253);
            this.dgvNotCheckedEmployee.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 26);
            // 
            // okToolStripMenuItem
            // 
            this.okToolStripMenuItem.Name = "okToolStripMenuItem";
            this.okToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.okToolStripMenuItem.Text = "Onayla";
            this.okToolStripMenuItem.Click += new System.EventHandler(this.okToolStripMenuItem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1017, 165);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(342, 91);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Onayla";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(205, 70);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(121, 21);
            this.cbDepartment.TabIndex = 7;
            this.cbDepartment.Visible = false;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(106, 70);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(87, 13);
            this.lblDepartment.TabIndex = 8;
            this.lblDepartment.Text = "Departman Seç :";
            this.lblDepartment.Visible = false;
            // 
            // lblAuthority
            // 
            this.lblAuthority.AutoSize = true;
            this.lblAuthority.Location = new System.Drawing.Point(106, 111);
            this.lblAuthority.Name = "lblAuthority";
            this.lblAuthority.Size = new System.Drawing.Size(59, 13);
            this.lblAuthority.TabIndex = 11;
            this.lblAuthority.Text = "Yetki Seç :";
            this.lblAuthority.Visible = false;
            // 
            // cbAuthority
            // 
            this.cbAuthority.FormattingEnabled = true;
            this.cbAuthority.Location = new System.Drawing.Point(205, 111);
            this.cbAuthority.Name = "cbAuthority";
            this.cbAuthority.Size = new System.Drawing.Size(121, 21);
            this.cbAuthority.TabIndex = 10;
            this.cbAuthority.Visible = false;
            // 
            // EmployeeCheckedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 660);
            this.Controls.Add(this.lblAuthority);
            this.Controls.Add(this.cbAuthority);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grpEmployee);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeCheckedForm";
            this.Text = "EmployeeCheckedForm";
            this.Load += new System.EventHandler(this.EmployeeCheckedForm_Load);
            this.grpEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotCheckedEmployee)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.DataGridView dgvNotCheckedEmployee;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem okToolStripMenuItem;
        private System.Windows.Forms.Label lblAuthority;
        private System.Windows.Forms.ComboBox cbAuthority;
    }
}