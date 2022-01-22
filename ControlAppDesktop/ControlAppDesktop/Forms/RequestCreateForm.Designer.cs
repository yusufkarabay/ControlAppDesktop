namespace ControlAppDesktop.Forms
{
    partial class RequestCreateForm
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
            this.lblRequestTitle = new System.Windows.Forms.Label();
            this.lblRequestContent = new System.Windows.Forms.Label();
            this.lblRequestDepartment = new System.Windows.Forms.Label();
            this.txtRequestTitle = new System.Windows.Forms.TextBox();
            this.rtxtRequestContext = new System.Windows.Forms.RichTextBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRequestCreate = new System.Windows.Forms.Button();
            this.grpNotRequest = new System.Windows.Forms.GroupBox();
            this.dgvNotRequest = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.requestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRequestlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSend = new System.Windows.Forms.Button();
            this.grpNotRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotRequest)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRequestTitle
            // 
            this.lblRequestTitle.AutoSize = true;
            this.lblRequestTitle.Location = new System.Drawing.Point(56, 45);
            this.lblRequestTitle.Name = "lblRequestTitle";
            this.lblRequestTitle.Size = new System.Drawing.Size(73, 13);
            this.lblRequestTitle.TabIndex = 0;
            this.lblRequestTitle.Text = "Talep Konusu";
            // 
            // lblRequestContent
            // 
            this.lblRequestContent.AutoSize = true;
            this.lblRequestContent.Location = new System.Drawing.Point(56, 85);
            this.lblRequestContent.Name = "lblRequestContent";
            this.lblRequestContent.Size = new System.Drawing.Size(65, 13);
            this.lblRequestContent.TabIndex = 1;
            this.lblRequestContent.Text = "Talep İçeriği";
            // 
            // lblRequestDepartment
            // 
            this.lblRequestDepartment.AutoSize = true;
            this.lblRequestDepartment.Location = new System.Drawing.Point(512, 55);
            this.lblRequestDepartment.Name = "lblRequestDepartment";
            this.lblRequestDepartment.Size = new System.Drawing.Size(97, 13);
            this.lblRequestDepartment.TabIndex = 2;
            this.lblRequestDepartment.Text = "Talep Departmanı :";
            this.lblRequestDepartment.Visible = false;
            // 
            // txtRequestTitle
            // 
            this.txtRequestTitle.Location = new System.Drawing.Point(167, 38);
            this.txtRequestTitle.Name = "txtRequestTitle";
            this.txtRequestTitle.Size = new System.Drawing.Size(304, 20);
            this.txtRequestTitle.TabIndex = 3;
            // 
            // rtxtRequestContext
            // 
            this.rtxtRequestContext.Location = new System.Drawing.Point(167, 85);
            this.rtxtRequestContext.Name = "rtxtRequestContext";
            this.rtxtRequestContext.Size = new System.Drawing.Size(304, 72);
            this.rtxtRequestContext.TabIndex = 4;
            this.rtxtRequestContext.Text = "";
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(623, 55);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(158, 21);
            this.cbDepartment.TabIndex = 5;
            this.cbDepartment.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1213, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRequestCreate
            // 
            this.btnRequestCreate.Location = new System.Drawing.Point(396, 185);
            this.btnRequestCreate.Name = "btnRequestCreate";
            this.btnRequestCreate.Size = new System.Drawing.Size(75, 23);
            this.btnRequestCreate.TabIndex = 7;
            this.btnRequestCreate.Text = "Oluştur";
            this.btnRequestCreate.UseVisualStyleBackColor = true;
            this.btnRequestCreate.Click += new System.EventHandler(this.btnRequestCreate_Click);
            // 
            // grpNotRequest
            // 
            this.grpNotRequest.Controls.Add(this.dgvNotRequest);
            this.grpNotRequest.Location = new System.Drawing.Point(59, 338);
            this.grpNotRequest.Name = "grpNotRequest";
            this.grpNotRequest.Size = new System.Drawing.Size(1014, 272);
            this.grpNotRequest.TabIndex = 8;
            this.grpNotRequest.TabStop = false;
            this.grpNotRequest.Text = "Atanmamış İşler Listesi";
            // 
            // dgvNotRequest
            // 
            this.dgvNotRequest.AllowUserToAddRows = false;
            this.dgvNotRequest.AllowUserToDeleteRows = false;
            this.dgvNotRequest.AllowUserToResizeColumns = false;
            this.dgvNotRequest.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvNotRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotRequest.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvNotRequest.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvNotRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotRequest.Location = new System.Drawing.Point(3, 16);
            this.dgvNotRequest.MultiSelect = false;
            this.dgvNotRequest.Name = "dgvNotRequest";
            this.dgvNotRequest.ReadOnly = true;
            this.dgvNotRequest.RowHeadersVisible = false;
            this.dgvNotRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotRequest.Size = new System.Drawing.Size(1008, 253);
            this.dgvNotRequest.TabIndex = 0;
            this.dgvNotRequest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvNotRequest_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestToolStripMenuItem,
            this.deleteRequestlToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 48);
            // 
            // requestToolStripMenuItem
            // 
            this.requestToolStripMenuItem.Name = "requestToolStripMenuItem";
            this.requestToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.requestToolStripMenuItem.Text = "Talep Et";
            this.requestToolStripMenuItem.Click += new System.EventHandler(this.requestToolStripMenuItem_Click);
            // 
            // deleteRequestlToolStripMenuItem
            // 
            this.deleteRequestlToolStripMenuItem.Name = "deleteRequestlToolStripMenuItem";
            this.deleteRequestlToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.deleteRequestlToolStripMenuItem.Text = "Sil";
            this.deleteRequestlToolStripMenuItem.Click += new System.EventHandler(this.deleteRequestlToolStripMenuItem_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(824, 53);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Gönder";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // RequestCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 781);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.grpNotRequest);
            this.Controls.Add(this.btnRequestCreate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.rtxtRequestContext);
            this.Controls.Add(this.txtRequestTitle);
            this.Controls.Add(this.lblRequestDepartment);
            this.Controls.Add(this.lblRequestContent);
            this.Controls.Add(this.lblRequestTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestCreateForm";
            this.Text = "RequestCreateForm";
            this.Load += new System.EventHandler(this.RequestCreateForm_Load);
            this.grpNotRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotRequest)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequestTitle;
        private System.Windows.Forms.Label lblRequestContent;
        private System.Windows.Forms.Label lblRequestDepartment;
        private System.Windows.Forms.TextBox txtRequestTitle;
        private System.Windows.Forms.RichTextBox rtxtRequestContext;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRequestCreate;
        private System.Windows.Forms.GroupBox grpNotRequest;
        private System.Windows.Forms.DataGridView dgvNotRequest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem requestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRequestlToolStripMenuItem;
        private System.Windows.Forms.Button btnSend;
    }
}