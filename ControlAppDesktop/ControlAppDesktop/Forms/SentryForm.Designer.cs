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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rtbxSentry = new System.Windows.Forms.RichTextBox();
            this.gbSentry = new System.Windows.Forms.GroupBox();
            this.dgvSentry = new System.Windows.Forms.DataGridView();
            this.btnSentryListDone = new System.Windows.Forms.Button();
            this.btnSentryDoneAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSentryListToDo = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gbSentry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentry)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(520, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // rtbxSentry
            // 
            this.rtbxSentry.Location = new System.Drawing.Point(65, 137);
            this.rtbxSentry.Name = "rtbxSentry";
            this.rtbxSentry.Size = new System.Drawing.Size(472, 149);
            this.rtbxSentry.TabIndex = 1;
            this.rtbxSentry.Text = "Nöbet sırasında yapılan işler...";
            // 
            // gbSentry
            // 
            this.gbSentry.Controls.Add(this.dgvSentry);
            this.gbSentry.Location = new System.Drawing.Point(108, 413);
            this.gbSentry.Name = "gbSentry";
            this.gbSentry.Size = new System.Drawing.Size(1039, 266);
            this.gbSentry.TabIndex = 2;
            this.gbSentry.TabStop = false;
            this.gbSentry.Text = "Yapılan İşler";
            // 
            // dgvSentry
            // 
            this.dgvSentry.AllowUserToAddRows = false;
            this.dgvSentry.AllowUserToDeleteRows = false;
            this.dgvSentry.AllowUserToResizeColumns = false;
            this.dgvSentry.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.dgvSentry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSentry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSentry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // btnSentryListDone
            // 
            this.btnSentryListDone.Location = new System.Drawing.Point(445, 292);
            this.btnSentryListDone.Name = "btnSentryListDone";
            this.btnSentryListDone.Size = new System.Drawing.Size(75, 23);
            this.btnSentryListDone.TabIndex = 3;
            this.btnSentryListDone.Text = "Listele";
            this.btnSentryListDone.UseVisualStyleBackColor = true;
            this.btnSentryListDone.Click += new System.EventHandler(this.btnSentryListDone_Click);
            // 
            // btnSentryDoneAdd
            // 
            this.btnSentryDoneAdd.Location = new System.Drawing.Point(306, 292);
            this.btnSentryDoneAdd.Name = "btnSentryDoneAdd";
            this.btnSentryDoneAdd.Size = new System.Drawing.Size(114, 23);
            this.btnSentryDoneAdd.TabIndex = 5;
            this.btnSentryDoneAdd.Text = "Yapılan İş Ekle";
            this.btnSentryDoneAdd.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(798, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Takip Edilecek İş Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSentryListToDo
            // 
            this.btnSentryListToDo.Location = new System.Drawing.Point(1069, 292);
            this.btnSentryListToDo.Name = "btnSentryListToDo";
            this.btnSentryListToDo.Size = new System.Drawing.Size(75, 23);
            this.btnSentryListToDo.TabIndex = 7;
            this.btnSentryListToDo.Text = "Listele";
            this.btnSentryListToDo.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(675, 137);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(472, 149);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "Takip edilecek işlemler...";
            // 
            // SentryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 811);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSentryListToDo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSentryDoneAdd);
            this.Controls.Add(this.btnSentryListDone);
            this.Controls.Add(this.gbSentry);
            this.Controls.Add(this.rtbxSentry);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "SentryForm";
            this.Text = "SentryForm";
            this.gbSentry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox rtbxSentry;
        private System.Windows.Forms.GroupBox gbSentry;
        private System.Windows.Forms.DataGridView dgvSentry;
        private System.Windows.Forms.Button btnSentryListDone;
        private System.Windows.Forms.Button btnSentryDoneAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSentryListToDo;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}