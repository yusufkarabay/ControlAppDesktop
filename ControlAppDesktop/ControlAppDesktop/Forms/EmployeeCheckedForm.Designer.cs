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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnClose.BackgroundImage = global::ControlAppDesktop.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1176, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 34);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.dgvNotCheckedEmployee);
            this.grpEmployee.Location = new System.Drawing.Point(108, 254);
            this.grpEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Padding = new System.Windows.Forms.Padding(4);
            this.grpEmployee.Size = new System.Drawing.Size(1120, 356);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvNotCheckedEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotCheckedEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotCheckedEmployee.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvNotCheckedEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotCheckedEmployee.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvNotCheckedEmployee.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvNotCheckedEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotCheckedEmployee.Location = new System.Drawing.Point(4, 20);
            this.dgvNotCheckedEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNotCheckedEmployee.MultiSelect = false;
            this.dgvNotCheckedEmployee.Name = "dgvNotCheckedEmployee";
            this.dgvNotCheckedEmployee.ReadOnly = true;
            this.dgvNotCheckedEmployee.RowHeadersVisible = false;
            this.dgvNotCheckedEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotCheckedEmployee.Size = new System.Drawing.Size(1112, 332);
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
            this.btnRefresh.Location = new System.Drawing.Point(1108, 198);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(456, 119);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 30);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Onayla";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Visible = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(273, 91);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(160, 25);
            this.cbDepartment.TabIndex = 1;
            this.cbDepartment.Visible = false;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(141, 91);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(117, 17);
            this.lblDepartment.TabIndex = 8;
            this.lblDepartment.Text = "Departman Seç :";
            this.lblDepartment.Visible = false;
            // 
            // lblAuthority
            // 
            this.lblAuthority.AutoSize = true;
            this.lblAuthority.Location = new System.Drawing.Point(141, 146);
            this.lblAuthority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthority.Name = "lblAuthority";
            this.lblAuthority.Size = new System.Drawing.Size(72, 17);
            this.lblAuthority.TabIndex = 11;
            this.lblAuthority.Text = "Yetki Seç :";
            this.lblAuthority.Visible = false;
            // 
            // cbAuthority
            // 
            this.cbAuthority.FormattingEnabled = true;
            this.cbAuthority.Location = new System.Drawing.Point(273, 146);
            this.cbAuthority.Margin = new System.Windows.Forms.Padding(4);
            this.cbAuthority.Name = "cbAuthority";
            this.cbAuthority.Size = new System.Drawing.Size(160, 25);
            this.cbAuthority.TabIndex = 2;
            this.cbAuthority.Visible = false;
            // 
            // EmployeeCheckedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1301, 863);
            this.Controls.Add(this.lblAuthority);
            this.Controls.Add(this.cbAuthority);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grpEmployee);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeCheckedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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