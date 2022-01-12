namespace ControlAppDesktop.Forms
{
    partial class AuthorityForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbAuthorityList = new System.Windows.Forms.GroupBox();
            this.dgvAuthority = new System.Windows.Forms.DataGridView();
            this.btnAuthorityList = new System.Windows.Forms.Button();
            this.btnAuthorityUpdate = new System.Windows.Forms.Button();
            this.lblAuthorityNameEdit = new System.Windows.Forms.Label();
            this.txtAuthorityName = new System.Windows.Forms.TextBox();
            this.btnCreateAuthority = new System.Windows.Forms.Button();
            this.gbAuthorityInfo = new System.Windows.Forms.GroupBox();
            this.lblAuthorityName = new System.Windows.Forms.Label();
            this.lblAuthorityNameInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbAuthorityList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthority)).BeginInit();
            this.gbAuthorityInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAuthorityList
            // 
            this.gbAuthorityList.Controls.Add(this.dgvAuthority);
            this.gbAuthorityList.Location = new System.Drawing.Point(127, 342);
            this.gbAuthorityList.Name = "gbAuthorityList";
            this.gbAuthorityList.Size = new System.Drawing.Size(914, 269);
            this.gbAuthorityList.TabIndex = 26;
            this.gbAuthorityList.TabStop = false;
            this.gbAuthorityList.Text = "Yetkiler Listesi";
            // 
            // dgvAuthority
            // 
            this.dgvAuthority.AllowUserToAddRows = false;
            this.dgvAuthority.AllowUserToDeleteRows = false;
            this.dgvAuthority.AllowUserToResizeColumns = false;
            this.dgvAuthority.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            this.dgvAuthority.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAuthority.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuthority.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthority.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvAuthority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAuthority.Location = new System.Drawing.Point(3, 16);
            this.dgvAuthority.MultiSelect = false;
            this.dgvAuthority.Name = "dgvAuthority";
            this.dgvAuthority.ReadOnly = true;
            this.dgvAuthority.RowHeadersVisible = false;
            this.dgvAuthority.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuthority.Size = new System.Drawing.Size(908, 250);
            this.dgvAuthority.TabIndex = 2;
            // 
            // btnAuthorityList
            // 
            this.btnAuthorityList.Location = new System.Drawing.Point(509, 43);
            this.btnAuthorityList.Name = "btnAuthorityList";
            this.btnAuthorityList.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorityList.TabIndex = 31;
            this.btnAuthorityList.Text = "Listele";
            this.btnAuthorityList.UseVisualStyleBackColor = true;
            this.btnAuthorityList.Click += new System.EventHandler(this.btnAuthorityList_Click);
            // 
            // btnAuthorityUpdate
            // 
            this.btnAuthorityUpdate.Location = new System.Drawing.Point(446, 255);
            this.btnAuthorityUpdate.Name = "btnAuthorityUpdate";
            this.btnAuthorityUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorityUpdate.TabIndex = 30;
            this.btnAuthorityUpdate.Text = "Güncelle";
            this.btnAuthorityUpdate.UseVisualStyleBackColor = true;
            // 
            // lblAuthorityNameEdit
            // 
            this.lblAuthorityNameEdit.AutoSize = true;
            this.lblAuthorityNameEdit.Location = new System.Drawing.Point(348, 203);
            this.lblAuthorityNameEdit.Name = "lblAuthorityNameEdit";
            this.lblAuthorityNameEdit.Size = new System.Drawing.Size(55, 13);
            this.lblAuthorityNameEdit.TabIndex = 29;
            this.lblAuthorityNameEdit.Text = "Yetki Adı :";
            // 
            // txtAuthorityName
            // 
            this.txtAuthorityName.Location = new System.Drawing.Point(436, 200);
            this.txtAuthorityName.Name = "txtAuthorityName";
            this.txtAuthorityName.Size = new System.Drawing.Size(177, 20);
            this.txtAuthorityName.TabIndex = 28;
            this.txtAuthorityName.Text = "Yetki Adı Giriniz...";
            this.txtAuthorityName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAuthorityName_MouseClick);
            // 
            // btnCreateAuthority
            // 
            this.btnCreateAuthority.Location = new System.Drawing.Point(351, 43);
            this.btnCreateAuthority.Name = "btnCreateAuthority";
            this.btnCreateAuthority.Size = new System.Drawing.Size(128, 23);
            this.btnCreateAuthority.TabIndex = 27;
            this.btnCreateAuthority.Text = "Yetki Oluştur";
            this.btnCreateAuthority.UseVisualStyleBackColor = true;
            this.btnCreateAuthority.Click += new System.EventHandler(this.btnCreateAuthority_Click);
            // 
            // gbAuthorityInfo
            // 
            this.gbAuthorityInfo.Controls.Add(this.lblAuthorityName);
            this.gbAuthorityInfo.Controls.Add(this.lblAuthorityNameInfo);
            this.gbAuthorityInfo.Location = new System.Drawing.Point(351, 88);
            this.gbAuthorityInfo.Name = "gbAuthorityInfo";
            this.gbAuthorityInfo.Size = new System.Drawing.Size(262, 89);
            this.gbAuthorityInfo.TabIndex = 25;
            this.gbAuthorityInfo.TabStop = false;
            this.gbAuthorityInfo.Text = "Yetki Bilgileri";
            // 
            // lblAuthorityName
            // 
            this.lblAuthorityName.AutoSize = true;
            this.lblAuthorityName.Location = new System.Drawing.Point(25, 42);
            this.lblAuthorityName.Name = "lblAuthorityName";
            this.lblAuthorityName.Size = new System.Drawing.Size(55, 13);
            this.lblAuthorityName.TabIndex = 18;
            this.lblAuthorityName.Text = "Yetki Adı :";
            // 
            // lblAuthorityNameInfo
            // 
            this.lblAuthorityNameInfo.AutoSize = true;
            this.lblAuthorityNameInfo.Location = new System.Drawing.Point(130, 42);
            this.lblAuthorityNameInfo.Name = "lblAuthorityNameInfo";
            this.lblAuthorityNameInfo.Size = new System.Drawing.Size(19, 13);
            this.lblAuthorityNameInfo.TabIndex = 17;
            this.lblAuthorityNameInfo.Text = "00";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(157, 43);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AuthorityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 691);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbAuthorityList);
            this.Controls.Add(this.btnAuthorityList);
            this.Controls.Add(this.btnAuthorityUpdate);
            this.Controls.Add(this.lblAuthorityNameEdit);
            this.Controls.Add(this.txtAuthorityName);
            this.Controls.Add(this.btnCreateAuthority);
            this.Controls.Add(this.gbAuthorityInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorityForm";
            this.Text = "AuthorityForm";
            this.Load += new System.EventHandler(this.AuthorityForm_Load);
            this.gbAuthorityList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthority)).EndInit();
            this.gbAuthorityInfo.ResumeLayout(false);
            this.gbAuthorityInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAuthorityList;
        private System.Windows.Forms.DataGridView dgvAuthority;
        private System.Windows.Forms.Button btnAuthorityList;
        private System.Windows.Forms.Button btnAuthorityUpdate;
        private System.Windows.Forms.Label lblAuthorityNameEdit;
        private System.Windows.Forms.TextBox txtAuthorityName;
        private System.Windows.Forms.Button btnCreateAuthority;
        private System.Windows.Forms.GroupBox gbAuthorityInfo;
        private System.Windows.Forms.Label lblAuthorityName;
        private System.Windows.Forms.Label lblAuthorityNameInfo;
        private System.Windows.Forms.Button btnClose;
    }
}