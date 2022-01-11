namespace ControlAppDesktop.Forms
{
    partial class DirectoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDirectoryAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.gbDirectory = new System.Windows.Forms.GroupBox();
            this.dgvDirectory = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.rbtInfo = new System.Windows.Forms.RadioButton();
            this.rbtPhone = new System.Windows.Forms.RadioButton();
            this.rbtName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.btnAllList = new System.Windows.Forms.Button();
            this.gbDirectory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectory)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.gbAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDirectoryAdd
            // 
            this.btnDirectoryAdd.Location = new System.Drawing.Point(115, 113);
            this.btnDirectoryAdd.Name = "btnDirectoryAdd";
            this.btnDirectoryAdd.Size = new System.Drawing.Size(75, 23);
            this.btnDirectoryAdd.TabIndex = 0;
            this.btnDirectoryAdd.Text = "Ekle";
            this.btnDirectoryAdd.UseVisualStyleBackColor = true;
            this.btnDirectoryAdd.Click += new System.EventHandler(this.btnDirectoryAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(26, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Ad :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(18, 59);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 13);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Telefon :";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(18, 86);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(38, 13);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Detay:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(88, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(88, 56);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(149, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(88, 87);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(149, 20);
            this.txtInfo.TabIndex = 6;
            // 
            // gbDirectory
            // 
            this.gbDirectory.Controls.Add(this.dgvDirectory);
            this.gbDirectory.Location = new System.Drawing.Point(88, 219);
            this.gbDirectory.Name = "gbDirectory";
            this.gbDirectory.Size = new System.Drawing.Size(1025, 362);
            this.gbDirectory.TabIndex = 25;
            this.gbDirectory.TabStop = false;
            this.gbDirectory.Text = "Telefon Rehberi";
            // 
            // dgvDirectory
            // 
            this.dgvDirectory.AllowUserToAddRows = false;
            this.dgvDirectory.AllowUserToDeleteRows = false;
            this.dgvDirectory.AllowUserToResizeColumns = false;
            this.dgvDirectory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvDirectory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDirectory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDirectory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirectory.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDirectory.Location = new System.Drawing.Point(3, 16);
            this.dgvDirectory.MultiSelect = false;
            this.dgvDirectory.Name = "dgvDirectory";
            this.dgvDirectory.ReadOnly = true;
            this.dgvDirectory.RowHeadersVisible = false;
            this.dgvDirectory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDirectory.Size = new System.Drawing.Size(1019, 343);
            this.dgvDirectory.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(961, 76);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(187, 20);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.Text = "Ara...";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.rbtInfo);
            this.gbSearch.Controls.Add(this.rbtPhone);
            this.gbSearch.Controls.Add(this.rbtName);
            this.gbSearch.Location = new System.Drawing.Point(735, 57);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(200, 100);
            this.gbSearch.TabIndex = 27;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Arama Seçenekleri";
            // 
            // rbtInfo
            // 
            this.rbtInfo.AutoSize = true;
            this.rbtInfo.Location = new System.Drawing.Point(7, 67);
            this.rbtInfo.Name = "rbtInfo";
            this.rbtInfo.Size = new System.Drawing.Size(100, 17);
            this.rbtInfo.TabIndex = 2;
            this.rbtInfo.TabStop = true;
            this.rbtInfo.Text = "Detay\' Göre Ara";
            this.rbtInfo.UseVisualStyleBackColor = true;
            this.rbtInfo.CheckedChanged += new System.EventHandler(this.rbtInfo_CheckedChanged);
            // 
            // rbtPhone
            // 
            this.rbtPhone.AutoSize = true;
            this.rbtPhone.Location = new System.Drawing.Point(6, 43);
            this.rbtPhone.Name = "rbtPhone";
            this.rbtPhone.Size = new System.Drawing.Size(114, 17);
            this.rbtPhone.TabIndex = 1;
            this.rbtPhone.TabStop = true;
            this.rbtPhone.Text = "Telefon\'a Göre Ara";
            this.rbtPhone.UseVisualStyleBackColor = true;
            this.rbtPhone.CheckedChanged += new System.EventHandler(this.rbtPhone_CheckedChanged);
            // 
            // rbtName
            // 
            this.rbtName.AutoSize = true;
            this.rbtName.Location = new System.Drawing.Point(6, 20);
            this.rbtName.Name = "rbtName";
            this.rbtName.Size = new System.Drawing.Size(91, 17);
            this.rbtName.TabIndex = 0;
            this.rbtName.TabStop = true;
            this.rbtName.Text = "Ad\'a Göre Ara";
            this.rbtName.UseVisualStyleBackColor = true;
            this.rbtName.CheckedChanged += new System.EventHandler(this.rbtName_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1015, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(719, 632);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(394, 13);
            this.lblMessage.TabIndex = 29;
            this.lblMessage.Text = "Rehbere Yanlış Bir Kayıt Eklediyseniz Lütfen Sistem Yöneticisi İle İletişime Geçi" +
    "niz..";
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.txtPhone);
            this.gbAdd.Controls.Add(this.lblName);
            this.gbAdd.Controls.Add(this.lblPhone);
            this.gbAdd.Controls.Add(this.lblInfo);
            this.gbAdd.Controls.Add(this.txtName);
            this.gbAdd.Controls.Add(this.txtInfo);
            this.gbAdd.Controls.Add(this.btnDirectoryAdd);
            this.gbAdd.Location = new System.Drawing.Point(41, 41);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(287, 161);
            this.gbAdd.TabIndex = 30;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Rehbere Ekle";
            // 
            // btnAllList
            // 
            this.btnAllList.Location = new System.Drawing.Point(421, 57);
            this.btnAllList.Name = "btnAllList";
            this.btnAllList.Size = new System.Drawing.Size(75, 23);
            this.btnAllList.TabIndex = 31;
            this.btnAllList.Text = "Tümünü Listele";
            this.btnAllList.UseVisualStyleBackColor = true;
            this.btnAllList.Click += new System.EventHandler(this.btnAllList_Click);
            // 
            // DirectoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.btnAllList);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gbDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DirectoryForm";
            this.Text = "DirectoryForm";
            this.Load += new System.EventHandler(this.DirectoryForm_Load);
            this.gbDirectory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirectory)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDirectoryAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.GroupBox gbDirectory;
        private System.Windows.Forms.DataGridView dgvDirectory;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.RadioButton rbtInfo;
        private System.Windows.Forms.RadioButton rbtPhone;
        private System.Windows.Forms.RadioButton rbtName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Button btnAllList;
    }
}