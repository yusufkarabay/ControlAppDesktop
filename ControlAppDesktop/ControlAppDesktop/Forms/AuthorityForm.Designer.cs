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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorityForm));
            this.gbAuthorityList = new System.Windows.Forms.GroupBox();
            this.dgvAuthority = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateAuthorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.contextMenuStrip1.SuspendLayout();
            this.gbAuthorityInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAuthorityList
            // 
            this.gbAuthorityList.Controls.Add(this.dgvAuthority);
            this.gbAuthorityList.Location = new System.Drawing.Point(74, 307);
            this.gbAuthorityList.Margin = new System.Windows.Forms.Padding(4);
            this.gbAuthorityList.Name = "gbAuthorityList";
            this.gbAuthorityList.Padding = new System.Windows.Forms.Padding(4);
            this.gbAuthorityList.Size = new System.Drawing.Size(594, 187);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvAuthority.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuthority.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuthority.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvAuthority.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAuthority.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthority.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAuthority.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvAuthority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAuthority.Location = new System.Drawing.Point(4, 18);
            this.dgvAuthority.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAuthority.MultiSelect = false;
            this.dgvAuthority.Name = "dgvAuthority";
            this.dgvAuthority.ReadOnly = true;
            this.dgvAuthority.RowHeadersVisible = false;
            this.dgvAuthority.RowHeadersWidth = 51;
            this.dgvAuthority.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuthority.Size = new System.Drawing.Size(586, 165);
            this.dgvAuthority.TabIndex = 2;
            this.dgvAuthority.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAuthority_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateAuthorityToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 26);
            // 
            // updateAuthorityToolStripMenuItem
            // 
            this.updateAuthorityToolStripMenuItem.Name = "updateAuthorityToolStripMenuItem";
            this.updateAuthorityToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.updateAuthorityToolStripMenuItem.Text = "Yetki Adını Güncelle";
            this.updateAuthorityToolStripMenuItem.Click += new System.EventHandler(this.updateAuthorityToolStripMenuItem_Click);
            // 
            // btnAuthorityList
            // 
            this.btnAuthorityList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAuthorityList.FlatAppearance.BorderSize = 0;
            this.btnAuthorityList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthorityList.Location = new System.Drawing.Point(553, 274);
            this.btnAuthorityList.Margin = new System.Windows.Forms.Padding(4);
            this.btnAuthorityList.Name = "btnAuthorityList";
            this.btnAuthorityList.Size = new System.Drawing.Size(108, 25);
            this.btnAuthorityList.TabIndex = 0;
            this.btnAuthorityList.Text = "Listele";
            this.btnAuthorityList.UseVisualStyleBackColor = false;
            this.btnAuthorityList.Click += new System.EventHandler(this.btnAuthorityList_Click);
            // 
            // btnAuthorityUpdate
            // 
            this.btnAuthorityUpdate.BackgroundImage = global::ControlAppDesktop.Properties.Resources.upload;
            this.btnAuthorityUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAuthorityUpdate.FlatAppearance.BorderSize = 0;
            this.btnAuthorityUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthorityUpdate.Location = new System.Drawing.Point(474, 158);
            this.btnAuthorityUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnAuthorityUpdate.Name = "btnAuthorityUpdate";
            this.btnAuthorityUpdate.Size = new System.Drawing.Size(32, 28);
            this.btnAuthorityUpdate.TabIndex = 3;
            this.btnAuthorityUpdate.UseVisualStyleBackColor = true;
            this.btnAuthorityUpdate.Visible = false;
            this.btnAuthorityUpdate.Click += new System.EventHandler(this.btnAuthorityUpdate_Click);
            // 
            // lblAuthorityNameEdit
            // 
            this.lblAuthorityNameEdit.AutoSize = true;
            this.lblAuthorityNameEdit.Location = new System.Drawing.Point(80, 162);
            this.lblAuthorityNameEdit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthorityNameEdit.Name = "lblAuthorityNameEdit";
            this.lblAuthorityNameEdit.Size = new System.Drawing.Size(60, 15);
            this.lblAuthorityNameEdit.TabIndex = 29;
            this.lblAuthorityNameEdit.Text = "Yetki Adı :";
            // 
            // txtAuthorityName
            // 
            this.txtAuthorityName.Location = new System.Drawing.Point(165, 162);
            this.txtAuthorityName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthorityName.Name = "txtAuthorityName";
            this.txtAuthorityName.Size = new System.Drawing.Size(274, 21);
            this.txtAuthorityName.TabIndex = 1;
            this.txtAuthorityName.Text = "Yetki Adı Giriniz...";
            this.txtAuthorityName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAuthorityName_MouseClick);
            // 
            // btnCreateAuthority
            // 
            this.btnCreateAuthority.BackgroundImage = global::ControlAppDesktop.Properties.Resources.plus;
            this.btnCreateAuthority.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCreateAuthority.FlatAppearance.BorderSize = 0;
            this.btnCreateAuthority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAuthority.Location = new System.Drawing.Point(273, 189);
            this.btnCreateAuthority.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateAuthority.Name = "btnCreateAuthority";
            this.btnCreateAuthority.Size = new System.Drawing.Size(32, 28);
            this.btnCreateAuthority.TabIndex = 2;
            this.btnCreateAuthority.UseVisualStyleBackColor = true;
            this.btnCreateAuthority.Click += new System.EventHandler(this.btnCreateAuthority_Click);
            // 
            // gbAuthorityInfo
            // 
            this.gbAuthorityInfo.Controls.Add(this.lblAuthorityName);
            this.gbAuthorityInfo.Controls.Add(this.lblAuthorityNameInfo);
            this.gbAuthorityInfo.Location = new System.Drawing.Point(74, 32);
            this.gbAuthorityInfo.Margin = new System.Windows.Forms.Padding(4);
            this.gbAuthorityInfo.Name = "gbAuthorityInfo";
            this.gbAuthorityInfo.Padding = new System.Windows.Forms.Padding(4);
            this.gbAuthorityInfo.Size = new System.Drawing.Size(445, 102);
            this.gbAuthorityInfo.TabIndex = 25;
            this.gbAuthorityInfo.TabStop = false;
            this.gbAuthorityInfo.Text = "Yetki Bilgileri";
            // 
            // lblAuthorityName
            // 
            this.lblAuthorityName.AutoSize = true;
            this.lblAuthorityName.Location = new System.Drawing.Point(36, 47);
            this.lblAuthorityName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthorityName.Name = "lblAuthorityName";
            this.lblAuthorityName.Size = new System.Drawing.Size(60, 15);
            this.lblAuthorityName.TabIndex = 18;
            this.lblAuthorityName.Text = "Yetki Adı :";
            // 
            // lblAuthorityNameInfo
            // 
            this.lblAuthorityNameInfo.AutoSize = true;
            this.lblAuthorityNameInfo.Location = new System.Drawing.Point(162, 47);
            this.lblAuthorityNameInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthorityNameInfo.Name = "lblAuthorityNameInfo";
            this.lblAuthorityNameInfo.Size = new System.Drawing.Size(19, 15);
            this.lblAuthorityNameInfo.TabIndex = 17;
            this.lblAuthorityNameInfo.Text = "00";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::ControlAppDesktop.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(646, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AuthorityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(704, 610);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbAuthorityList);
            this.Controls.Add(this.btnAuthorityList);
            this.Controls.Add(this.btnAuthorityUpdate);
            this.Controls.Add(this.lblAuthorityNameEdit);
            this.Controls.Add(this.txtAuthorityName);
            this.Controls.Add(this.btnCreateAuthority);
            this.Controls.Add(this.gbAuthorityInfo);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AuthorityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.AuthorityForm_Load);
            this.gbAuthorityList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthority)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateAuthorityToolStripMenuItem;
    }
}