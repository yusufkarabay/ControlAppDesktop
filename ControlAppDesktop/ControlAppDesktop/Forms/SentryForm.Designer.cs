namespace ControlAppDesktop.Forms
{
    partial class SentryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rtbxSentry = new System.Windows.Forms.RichTextBox();
            this.gbSentry = new System.Windows.Forms.GroupBox();
            this.dgvSentryTodo = new System.Windows.Forms.DataGridView();
            this.rightMenuToDo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSentry = new System.Windows.Forms.DataGridView();
            this.rightMenuDone = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSentryListDone = new System.Windows.Forms.Button();
            this.btnSentryDoneAdd = new System.Windows.Forms.Button();
            this.btnSentryToDoAdd = new System.Windows.Forms.Button();
            this.btnSentryListToDo = new System.Windows.Forms.Button();
            this.rtbxSentryToDo = new System.Windows.Forms.RichTextBox();
            this.btnSentryDoneUpdate = new System.Windows.Forms.Button();
            this.btnSentryToDoUpdate = new System.Windows.Forms.Button();
            this.gbSentry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentryTodo)).BeginInit();
            this.rightMenuToDo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentry)).BeginInit();
            this.rightMenuDone.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(467, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // rtbxSentry
            // 
            this.rtbxSentry.Location = new System.Drawing.Point(12, 122);
            this.rtbxSentry.Name = "rtbxSentry";
            this.rtbxSentry.Size = new System.Drawing.Size(472, 149);
            this.rtbxSentry.TabIndex = 1;
            this.rtbxSentry.Text = "Nöbet sırasında yapılan işler...";
            this.rtbxSentry.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtbxSentry_MouseClick);
            // 
            // gbSentry
            // 
            this.gbSentry.Controls.Add(this.dgvSentryTodo);
            this.gbSentry.Controls.Add(this.dgvSentry);
            this.gbSentry.Location = new System.Drawing.Point(55, 398);
            this.gbSentry.Name = "gbSentry";
            this.gbSentry.Size = new System.Drawing.Size(1039, 266);
            this.gbSentry.TabIndex = 2;
            this.gbSentry.TabStop = false;
            this.gbSentry.Text = "Yapılan İşler";
            // 
            // dgvSentryTodo
            // 
            this.dgvSentryTodo.AllowUserToAddRows = false;
            this.dgvSentryTodo.AllowUserToDeleteRows = false;
            this.dgvSentryTodo.AllowUserToResizeColumns = false;
            this.dgvSentryTodo.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            this.dgvSentryTodo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSentryTodo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSentryTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSentryTodo.ContextMenuStrip = this.rightMenuToDo;
            this.dgvSentryTodo.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvSentryTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSentryTodo.Location = new System.Drawing.Point(3, 16);
            this.dgvSentryTodo.MultiSelect = false;
            this.dgvSentryTodo.Name = "dgvSentryTodo";
            this.dgvSentryTodo.ReadOnly = true;
            this.dgvSentryTodo.RowHeadersVisible = false;
            this.dgvSentryTodo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSentryTodo.Size = new System.Drawing.Size(1033, 247);
            this.dgvSentryTodo.TabIndex = 2;
            // 
            // rightMenuToDo
            // 
            this.rightMenuToDo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gToolStripMenuItem,
            this.silToolStripMenuItem1,
            this.yenileToolStripMenuItem1});
            this.rightMenuToDo.Name = "rightMenuToDo";
            this.rightMenuToDo.Size = new System.Drawing.Size(205, 70);
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.gToolStripMenuItem.Text = "Güncellenecek Kaydı Seç";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.gToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.silToolStripMenuItem1.Text = "Sil";
            this.silToolStripMenuItem1.Click += new System.EventHandler(this.silToolStripMenuItem1_Click);
            // 
            // yenileToolStripMenuItem1
            // 
            this.yenileToolStripMenuItem1.Name = "yenileToolStripMenuItem1";
            this.yenileToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.yenileToolStripMenuItem1.Text = "Yenile";
            this.yenileToolStripMenuItem1.Click += new System.EventHandler(this.yenileToolStripMenuItem1_Click);
            // 
            // dgvSentry
            // 
            this.dgvSentry.AllowUserToAddRows = false;
            this.dgvSentry.AllowUserToDeleteRows = false;
            this.dgvSentry.AllowUserToResizeColumns = false;
            this.dgvSentry.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvSentry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSentry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSentry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSentry.ContextMenuStrip = this.rightMenuDone;
            this.dgvSentry.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvSentry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSentry.Location = new System.Drawing.Point(3, 16);
            this.dgvSentry.MultiSelect = false;
            this.dgvSentry.Name = "dgvSentry";
            this.dgvSentry.ReadOnly = true;
            this.dgvSentry.RowHeadersVisible = false;
            this.dgvSentry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSentry.Size = new System.Drawing.Size(1033, 247);
            this.dgvSentry.TabIndex = 1;
            // 
            // rightMenuDone
            // 
            this.rightMenuDone.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.yenileToolStripMenuItem});
            this.rightMenuDone.Name = "contextMenuStrip1";
            this.rightMenuDone.Size = new System.Drawing.Size(205, 70);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.güncelleToolStripMenuItem.Text = "Güncellenecek Kaydı Seç";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // btnSentryListDone
            // 
            this.btnSentryListDone.Location = new System.Drawing.Point(253, 277);
            this.btnSentryListDone.Name = "btnSentryListDone";
            this.btnSentryListDone.Size = new System.Drawing.Size(75, 23);
            this.btnSentryListDone.TabIndex = 3;
            this.btnSentryListDone.Text = "Listele";
            this.btnSentryListDone.UseVisualStyleBackColor = true;
            this.btnSentryListDone.Click += new System.EventHandler(this.btnSentryListDone_Click);
            // 
            // btnSentryDoneAdd
            // 
            this.btnSentryDoneAdd.Location = new System.Drawing.Point(119, 277);
            this.btnSentryDoneAdd.Name = "btnSentryDoneAdd";
            this.btnSentryDoneAdd.Size = new System.Drawing.Size(114, 23);
            this.btnSentryDoneAdd.TabIndex = 5;
            this.btnSentryDoneAdd.Text = "Yapılan İş Ekle";
            this.btnSentryDoneAdd.UseVisualStyleBackColor = true;
            this.btnSentryDoneAdd.Click += new System.EventHandler(this.btnSentryDoneAdd_Click);
            // 
            // btnSentryToDoAdd
            // 
            this.btnSentryToDoAdd.Location = new System.Drawing.Point(622, 287);
            this.btnSentryToDoAdd.Name = "btnSentryToDoAdd";
            this.btnSentryToDoAdd.Size = new System.Drawing.Size(162, 23);
            this.btnSentryToDoAdd.TabIndex = 6;
            this.btnSentryToDoAdd.Text = "Takip Edilecek İş Ekle";
            this.btnSentryToDoAdd.UseVisualStyleBackColor = true;
            this.btnSentryToDoAdd.Click += new System.EventHandler(this.btnSentryToDoAdd_Click);
            // 
            // btnSentryListToDo
            // 
            this.btnSentryListToDo.Location = new System.Drawing.Point(806, 287);
            this.btnSentryListToDo.Name = "btnSentryListToDo";
            this.btnSentryListToDo.Size = new System.Drawing.Size(75, 23);
            this.btnSentryListToDo.TabIndex = 7;
            this.btnSentryListToDo.Text = "Listele";
            this.btnSentryListToDo.UseVisualStyleBackColor = true;
            this.btnSentryListToDo.Click += new System.EventHandler(this.btnSentryListToDo_Click);
            // 
            // rtbxSentryToDo
            // 
            this.rtbxSentryToDo.Location = new System.Drawing.Point(622, 122);
            this.rtbxSentryToDo.Name = "rtbxSentryToDo";
            this.rtbxSentryToDo.Size = new System.Drawing.Size(472, 149);
            this.rtbxSentryToDo.TabIndex = 8;
            this.rtbxSentryToDo.Text = "Takip edilecek işlemler...";
            this.rtbxSentryToDo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtbxSentryToDo_MouseClick);
            // 
            // btnSentryDoneUpdate
            // 
            this.btnSentryDoneUpdate.Location = new System.Drawing.Point(361, 277);
            this.btnSentryDoneUpdate.Name = "btnSentryDoneUpdate";
            this.btnSentryDoneUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnSentryDoneUpdate.TabIndex = 9;
            this.btnSentryDoneUpdate.Text = "Güncelle";
            this.btnSentryDoneUpdate.UseVisualStyleBackColor = true;
            this.btnSentryDoneUpdate.Click += new System.EventHandler(this.btnSentryDoneUpdate_Click);
            // 
            // btnSentryToDoUpdate
            // 
            this.btnSentryToDoUpdate.Location = new System.Drawing.Point(961, 302);
            this.btnSentryToDoUpdate.Name = "btnSentryToDoUpdate";
            this.btnSentryToDoUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnSentryToDoUpdate.TabIndex = 11;
            this.btnSentryToDoUpdate.Text = "Güncelle";
            this.btnSentryToDoUpdate.UseVisualStyleBackColor = true;
            this.btnSentryToDoUpdate.Click += new System.EventHandler(this.btnSentryToDoUpdate_Click);
            // 
            // SentryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.btnSentryToDoUpdate);
            this.Controls.Add(this.btnSentryDoneUpdate);
            this.Controls.Add(this.rtbxSentryToDo);
            this.Controls.Add(this.btnSentryListToDo);
            this.Controls.Add(this.btnSentryToDoAdd);
            this.Controls.Add(this.btnSentryDoneAdd);
            this.Controls.Add(this.btnSentryListDone);
            this.Controls.Add(this.gbSentry);
            this.Controls.Add(this.rtbxSentry);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SentryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SentryForm";
            this.Load += new System.EventHandler(this.SentryForm_Load);
            this.gbSentry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentryTodo)).EndInit();
            this.rightMenuToDo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentry)).EndInit();
            this.rightMenuDone.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox rtbxSentry;
        private System.Windows.Forms.GroupBox gbSentry;
        private System.Windows.Forms.DataGridView dgvSentry;
        private System.Windows.Forms.Button btnSentryListDone;
        private System.Windows.Forms.Button btnSentryDoneAdd;
        private System.Windows.Forms.Button btnSentryToDoAdd;
        private System.Windows.Forms.Button btnSentryListToDo;
        private System.Windows.Forms.RichTextBox rtbxSentryToDo;
        private System.Windows.Forms.ContextMenuStrip rightMenuDone;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnSentryDoneUpdate;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvSentryTodo;
        private System.Windows.Forms.ContextMenuStrip rightMenuToDo;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem1;
        private System.Windows.Forms.Button btnSentryToDoUpdate;
    }
}