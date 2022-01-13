namespace ControlAppDesktop.Forms
{
    partial class MaintenanceMailAddForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblMailEmployee = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbMail = new System.Windows.Forms.GroupBox();
            this.dgvMail = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(851, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(122, 18);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(64, 13);
            this.lblMail.TabIndex = 1;
            this.lblMail.Text = "Mail Adresi :";
            // 
            // lblMailEmployee
            // 
            this.lblMailEmployee.AutoSize = true;
            this.lblMailEmployee.Location = new System.Drawing.Point(122, 52);
            this.lblMailEmployee.Name = "lblMailEmployee";
            this.lblMailEmployee.Size = new System.Drawing.Size(64, 13);
            this.lblMailEmployee.TabIndex = 2;
            this.lblMailEmployee.Text = "Mail Sahibi :";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(206, 15);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(188, 20);
            this.txtMail.TabIndex = 3;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(206, 52);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(188, 20);
            this.txtEmployee.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(414, 31);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbMail
            // 
            this.gbMail.Controls.Add(this.dgvMail);
            this.gbMail.Location = new System.Drawing.Point(45, 148);
            this.gbMail.Name = "gbMail";
            this.gbMail.Size = new System.Drawing.Size(914, 269);
            this.gbMail.TabIndex = 27;
            this.gbMail.TabStop = false;
            this.gbMail.Text = "Mail Listesi";
            // 
            // dgvMail
            // 
            this.dgvMail.AllowUserToAddRows = false;
            this.dgvMail.AllowUserToDeleteRows = false;
            this.dgvMail.AllowUserToResizeColumns = false;
            this.dgvMail.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            this.dgvMail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMail.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMail.Location = new System.Drawing.Point(3, 16);
            this.dgvMail.MultiSelect = false;
            this.dgvMail.Name = "dgvMail";
            this.dgvMail.ReadOnly = true;
            this.dgvMail.RowHeadersVisible = false;
            this.dgvMail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMail.Size = new System.Drawing.Size(908, 250);
            this.dgvMail.TabIndex = 2;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(735, 18);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 28;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(851, 79);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // MaintenanceMailAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 565);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.gbMail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMailEmployee);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaintenanceMailAdd";
            this.Text = "MaintenanceMailAdd";
            this.gbMail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblMailEmployee;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbMail;
        private System.Windows.Forms.DataGridView dgvMail;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnUpdate;
    }
}