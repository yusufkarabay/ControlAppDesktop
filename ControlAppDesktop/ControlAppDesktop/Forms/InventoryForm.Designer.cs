namespace ControlAppDesktop.Forms
{
    partial class InventoryForm
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
            this.grpInventory = new System.Windows.Forms.GroupBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpInventoryInfo = new System.Windows.Forms.GroupBox();
            this.rtxbxInventoryInfo = new System.Windows.Forms.RichTextBox();
            this.txtbxAmount = new System.Windows.Forms.TextBox();
            this.txtbxInventoryName = new System.Windows.Forms.TextBox();
            this.txtbxInventorySeriNo = new System.Windows.Forms.TextBox();
            this.lblInventoryInfo = new System.Windows.Forms.Label();
            this.lblInventoryAmount = new System.Windows.Forms.Label();
            this.lblInventoryName = new System.Windows.Forms.Label();
            this.lblInventorySeriNo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnList = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnInventoryPdf = new System.Windows.Forms.Button();
            this.btnInventoryWeb = new System.Windows.Forms.Button();
            this.btnAllList = new System.Windows.Forms.Button();
            this.grpInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.grpInventoryInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInventory
            // 
            this.grpInventory.Controls.Add(this.dgvInventory);
            this.grpInventory.Location = new System.Drawing.Point(51, 238);
            this.grpInventory.Name = "grpInventory";
            this.grpInventory.Size = new System.Drawing.Size(1014, 272);
            this.grpInventory.TabIndex = 4;
            this.grpInventory.TabStop = false;
            this.grpInventory.Text = "Envanter Listesi";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeColumns = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvInventory.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventory.Location = new System.Drawing.Point(3, 16);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(1008, 253);
            this.dgvInventory.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateInventoryToolStripMenuItem,
            this.deleteInventoryToolStripMenuItem,
            this.refreshInventoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(225, 70);
            // 
            // updateInventoryToolStripMenuItem
            // 
            this.updateInventoryToolStripMenuItem.Name = "updateInventoryToolStripMenuItem";
            this.updateInventoryToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.updateInventoryToolStripMenuItem.Text = "Güncellenecek Envanteri Seç";
            this.updateInventoryToolStripMenuItem.Click += new System.EventHandler(this.updateInventoryToolStripMenuItem_Click);
            // 
            // deleteInventoryToolStripMenuItem
            // 
            this.deleteInventoryToolStripMenuItem.Name = "deleteInventoryToolStripMenuItem";
            this.deleteInventoryToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.deleteInventoryToolStripMenuItem.Text = "Sil";
            this.deleteInventoryToolStripMenuItem.Click += new System.EventHandler(this.deleteInventoryToolStripMenuItem_Click);
            // 
            // refreshInventoryToolStripMenuItem
            // 
            this.refreshInventoryToolStripMenuItem.Name = "refreshInventoryToolStripMenuItem";
            this.refreshInventoryToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.refreshInventoryToolStripMenuItem.Text = "Yenile";
            this.refreshInventoryToolStripMenuItem.Click += new System.EventHandler(this.refreshInventoryToolStripMenuItem_Click);
            // 
            // grpInventoryInfo
            // 
            this.grpInventoryInfo.Controls.Add(this.rtxbxInventoryInfo);
            this.grpInventoryInfo.Controls.Add(this.txtbxAmount);
            this.grpInventoryInfo.Controls.Add(this.txtbxInventoryName);
            this.grpInventoryInfo.Controls.Add(this.txtbxInventorySeriNo);
            this.grpInventoryInfo.Controls.Add(this.lblInventoryInfo);
            this.grpInventoryInfo.Controls.Add(this.lblInventoryAmount);
            this.grpInventoryInfo.Controls.Add(this.lblInventoryName);
            this.grpInventoryInfo.Controls.Add(this.lblInventorySeriNo);
            this.grpInventoryInfo.Location = new System.Drawing.Point(51, 12);
            this.grpInventoryInfo.Name = "grpInventoryInfo";
            this.grpInventoryInfo.Size = new System.Drawing.Size(345, 198);
            this.grpInventoryInfo.TabIndex = 5;
            this.grpInventoryInfo.TabStop = false;
            this.grpInventoryInfo.Text = "Envanter Bilgileri";
            // 
            // rtxbxInventoryInfo
            // 
            this.rtxbxInventoryInfo.Location = new System.Drawing.Point(105, 124);
            this.rtxbxInventoryInfo.Name = "rtxbxInventoryInfo";
            this.rtxbxInventoryInfo.Size = new System.Drawing.Size(206, 55);
            this.rtxbxInventoryInfo.TabIndex = 7;
            this.rtxbxInventoryInfo.Text = "";
            // 
            // txtbxAmount
            // 
            this.txtbxAmount.Location = new System.Drawing.Point(105, 96);
            this.txtbxAmount.Name = "txtbxAmount";
            this.txtbxAmount.Size = new System.Drawing.Size(100, 20);
            this.txtbxAmount.TabIndex = 6;
            // 
            // txtbxInventoryName
            // 
            this.txtbxInventoryName.Location = new System.Drawing.Point(105, 59);
            this.txtbxInventoryName.Name = "txtbxInventoryName";
            this.txtbxInventoryName.Size = new System.Drawing.Size(100, 20);
            this.txtbxInventoryName.TabIndex = 5;
            // 
            // txtbxInventorySeriNo
            // 
            this.txtbxInventorySeriNo.Location = new System.Drawing.Point(105, 22);
            this.txtbxInventorySeriNo.Name = "txtbxInventorySeriNo";
            this.txtbxInventorySeriNo.Size = new System.Drawing.Size(100, 20);
            this.txtbxInventorySeriNo.TabIndex = 4;
            // 
            // lblInventoryInfo
            // 
            this.lblInventoryInfo.AutoSize = true;
            this.lblInventoryInfo.Location = new System.Drawing.Point(19, 135);
            this.lblInventoryInfo.Name = "lblInventoryInfo";
            this.lblInventoryInfo.Size = new System.Drawing.Size(56, 13);
            this.lblInventoryInfo.TabIndex = 3;
            this.lblInventoryInfo.Text = "Açıklama :";
            // 
            // lblInventoryAmount
            // 
            this.lblInventoryAmount.AutoSize = true;
            this.lblInventoryAmount.Location = new System.Drawing.Point(19, 96);
            this.lblInventoryAmount.Name = "lblInventoryAmount";
            this.lblInventoryAmount.Size = new System.Drawing.Size(42, 13);
            this.lblInventoryAmount.TabIndex = 2;
            this.lblInventoryAmount.Text = "Miktar :";
            // 
            // lblInventoryName
            // 
            this.lblInventoryName.AutoSize = true;
            this.lblInventoryName.Location = new System.Drawing.Point(19, 62);
            this.lblInventoryName.Name = "lblInventoryName";
            this.lblInventoryName.Size = new System.Drawing.Size(74, 13);
            this.lblInventoryName.TabIndex = 1;
            this.lblInventoryName.Text = "Envanter Adı :";
            // 
            // lblInventorySeriNo
            // 
            this.lblInventorySeriNo.AutoSize = true;
            this.lblInventorySeriNo.Location = new System.Drawing.Point(19, 30);
            this.lblInventorySeriNo.Name = "lblInventorySeriNo";
            this.lblInventorySeriNo.Size = new System.Drawing.Size(48, 13);
            this.lblInventorySeriNo.TabIndex = 0;
            this.lblInventorySeriNo.Text = "Seri No :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(571, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(418, 74);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 7;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(499, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(499, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnInventoryPdf
            // 
            this.btnInventoryPdf.Location = new System.Drawing.Point(917, 42);
            this.btnInventoryPdf.Name = "btnInventoryPdf";
            this.btnInventoryPdf.Size = new System.Drawing.Size(124, 23);
            this.btnInventoryPdf.TabIndex = 11;
            this.btnInventoryPdf.Text = "Pdf Olarak Dışarı Aktar";
            this.btnInventoryPdf.UseVisualStyleBackColor = true;
            // 
            // btnInventoryWeb
            // 
            this.btnInventoryWeb.Location = new System.Drawing.Point(917, 74);
            this.btnInventoryWeb.Name = "btnInventoryWeb";
            this.btnInventoryWeb.Size = new System.Drawing.Size(124, 23);
            this.btnInventoryWeb.TabIndex = 12;
            this.btnInventoryWeb.Text = "Web\'de Görüntüle";
            this.btnInventoryWeb.UseVisualStyleBackColor = true;
            // 
            // btnAllList
            // 
            this.btnAllList.Location = new System.Drawing.Point(590, 74);
            this.btnAllList.Name = "btnAllList";
            this.btnAllList.Size = new System.Drawing.Size(111, 23);
            this.btnAllList.TabIndex = 13;
            this.btnAllList.Text = "Tümünü Listele";
            this.btnAllList.UseVisualStyleBackColor = true;
            this.btnAllList.Click += new System.EventHandler(this.btnAllList_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 608);
            this.Controls.Add(this.btnAllList);
            this.Controls.Add(this.btnInventoryWeb);
            this.Controls.Add(this.btnInventoryPdf);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.grpInventoryInfo);
            this.Controls.Add(this.grpInventory);
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.grpInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.grpInventoryInfo.ResumeLayout(false);
            this.grpInventoryInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInventory;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.GroupBox grpInventoryInfo;
        private System.Windows.Forms.Label lblInventoryInfo;
        private System.Windows.Forms.Label lblInventoryAmount;
        private System.Windows.Forms.Label lblInventoryName;
        private System.Windows.Forms.Label lblInventorySeriNo;
        private System.Windows.Forms.RichTextBox rtxbxInventoryInfo;
        private System.Windows.Forms.TextBox txtbxAmount;
        private System.Windows.Forms.TextBox txtbxInventoryName;
        private System.Windows.Forms.TextBox txtbxInventorySeriNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnInventoryPdf;
        private System.Windows.Forms.Button btnInventoryWeb;
        private System.Windows.Forms.Button btnAllList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshInventoryToolStripMenuItem;
    }
}