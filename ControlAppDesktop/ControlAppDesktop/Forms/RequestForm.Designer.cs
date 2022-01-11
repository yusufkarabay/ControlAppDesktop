namespace ControlAppDesktop.Forms
{
    partial class RequestForm
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
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.employeeSurname = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.Label();
            this.lblDepartmentInfo = new System.Windows.Forms.Label();
            this.lblSurnameInfo = new System.Windows.Forms.Label();
            this.lblNameInfo = new System.Windows.Forms.Label();
            this.lblTcInfo = new System.Windows.Forms.Label();
            this.tlblTime = new System.Windows.Forms.Label();
            this.grpRequest = new System.Windows.Forms.GroupBox();
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTxtRequestContent = new System.Windows.Forms.RichTextBox();
            this.txtRequested = new System.Windows.Forms.TextBox();
            this.txtRequestTitle = new System.Windows.Forms.TextBox();
            this.requested = new System.Windows.Forms.Label();
            this.requestDetail = new System.Windows.Forms.Label();
            this.requestName = new System.Windows.Forms.Label();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.btnCompleteRequest = new System.Windows.Forms.Button();
            this.btnMyRequest = new System.Windows.Forms.Button();
            this.btnCreateRequest = new System.Windows.Forms.Button();
            this.btnWeb = new System.Windows.Forms.Button();
            this.btnRequestRefresh = new System.Windows.Forms.Button();
            this.btnRequestEnd = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCountInfo = new System.Windows.Forms.Label();
            this.grpInfo.SuspendLayout();
            this.grpRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.department);
            this.grpInfo.Controls.Add(this.employeeSurname);
            this.grpInfo.Controls.Add(this.employeeName);
            this.grpInfo.Controls.Add(this.lblDepartmentInfo);
            this.grpInfo.Controls.Add(this.lblSurnameInfo);
            this.grpInfo.Controls.Add(this.lblNameInfo);
            this.grpInfo.Controls.Add(this.lblTcInfo);
            this.grpInfo.Location = new System.Drawing.Point(82, 12);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(300, 159);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Kişi Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "TC:";
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Location = new System.Drawing.Point(6, 103);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(62, 13);
            this.department.TabIndex = 8;
            this.department.Text = "Departman:";
            // 
            // employeeSurname
            // 
            this.employeeSurname.AutoSize = true;
            this.employeeSurname.Location = new System.Drawing.Point(6, 77);
            this.employeeSurname.Name = "employeeSurname";
            this.employeeSurname.Size = new System.Drawing.Size(40, 13);
            this.employeeSurname.TabIndex = 3;
            this.employeeSurname.Text = "Soyad:";
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Location = new System.Drawing.Point(6, 51);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(23, 13);
            this.employeeName.TabIndex = 2;
            this.employeeName.Text = "Ad:";
            // 
            // lblDepartmentInfo
            // 
            this.lblDepartmentInfo.AutoSize = true;
            this.lblDepartmentInfo.Location = new System.Drawing.Point(100, 103);
            this.lblDepartmentInfo.Name = "lblDepartmentInfo";
            this.lblDepartmentInfo.Size = new System.Drawing.Size(19, 13);
            this.lblDepartmentInfo.TabIndex = 9;
            this.lblDepartmentInfo.Text = "00";
            // 
            // lblSurnameInfo
            // 
            this.lblSurnameInfo.AutoSize = true;
            this.lblSurnameInfo.Location = new System.Drawing.Point(100, 77);
            this.lblSurnameInfo.Name = "lblSurnameInfo";
            this.lblSurnameInfo.Size = new System.Drawing.Size(19, 13);
            this.lblSurnameInfo.TabIndex = 5;
            this.lblSurnameInfo.Text = "00";
            // 
            // lblNameInfo
            // 
            this.lblNameInfo.AutoSize = true;
            this.lblNameInfo.Location = new System.Drawing.Point(100, 51);
            this.lblNameInfo.Name = "lblNameInfo";
            this.lblNameInfo.Size = new System.Drawing.Size(19, 13);
            this.lblNameInfo.TabIndex = 4;
            this.lblNameInfo.Text = "00";
            // 
            // lblTcInfo
            // 
            this.lblTcInfo.AutoSize = true;
            this.lblTcInfo.Location = new System.Drawing.Point(100, 25);
            this.lblTcInfo.Name = "lblTcInfo";
            this.lblTcInfo.Size = new System.Drawing.Size(19, 13);
            this.lblTcInfo.TabIndex = 1;
            this.lblTcInfo.Text = "00";
            // 
            // tlblTime
            // 
            this.tlblTime.AutoSize = true;
            this.tlblTime.Location = new System.Drawing.Point(941, 9);
            this.tlblTime.Name = "tlblTime";
            this.tlblTime.Size = new System.Drawing.Size(40, 13);
            this.tlblTime.TabIndex = 1;
            this.tlblTime.Text = "Zaman";
            // 
            // grpRequest
            // 
            this.grpRequest.Controls.Add(this.dgvRequest);
            this.grpRequest.Location = new System.Drawing.Point(82, 191);
            this.grpRequest.Name = "grpRequest";
            this.grpRequest.Size = new System.Drawing.Size(1014, 272);
            this.grpRequest.TabIndex = 2;
            this.grpRequest.TabStop = false;
            this.grpRequest.Text = "Benden Talep Edilenler";
            // 
            // dgvRequest
            // 
            this.dgvRequest.AllowUserToAddRows = false;
            this.dgvRequest.AllowUserToDeleteRows = false;
            this.dgvRequest.AllowUserToResizeColumns = false;
            this.dgvRequest.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.dgvRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequest.Location = new System.Drawing.Point(3, 16);
            this.dgvRequest.MultiSelect = false;
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.ReadOnly = true;
            this.dgvRequest.RowHeadersVisible = false;
            this.dgvRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequest.Size = new System.Drawing.Size(1008, 253);
            this.dgvRequest.TabIndex = 0;
            this.dgvRequest.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRequest_CellMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTxtRequestContent);
            this.groupBox1.Controls.Add(this.txtRequested);
            this.groupBox1.Controls.Add(this.txtRequestTitle);
            this.groupBox1.Controls.Add(this.requested);
            this.groupBox1.Controls.Add(this.requestDetail);
            this.groupBox1.Controls.Add(this.requestName);
            this.groupBox1.Location = new System.Drawing.Point(85, 482);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 240);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Talep Bilgileri";
            // 
            // richTxtRequestContent
            // 
            this.richTxtRequestContent.Location = new System.Drawing.Point(183, 99);
            this.richTxtRequestContent.Name = "richTxtRequestContent";
            this.richTxtRequestContent.Size = new System.Drawing.Size(282, 96);
            this.richTxtRequestContent.TabIndex = 5;
            this.richTxtRequestContent.Text = "";
            this.richTxtRequestContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTxtRequestContent_KeyDown);
            this.richTxtRequestContent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTxtRequestContent_KeyPress);
            // 
            // txtRequested
            // 
            this.txtRequested.Location = new System.Drawing.Point(183, 64);
            this.txtRequested.Name = "txtRequested";
            this.txtRequested.Size = new System.Drawing.Size(282, 20);
            this.txtRequested.TabIndex = 4;
            this.txtRequested.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRequested_KeyDown);
            this.txtRequested.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRequested_KeyPress);
            // 
            // txtRequestTitle
            // 
            this.txtRequestTitle.Location = new System.Drawing.Point(183, 27);
            this.txtRequestTitle.Name = "txtRequestTitle";
            this.txtRequestTitle.Size = new System.Drawing.Size(282, 20);
            this.txtRequestTitle.TabIndex = 3;
            this.txtRequestTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRequestTitle_KeyDown);
            this.txtRequestTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRequestTitle_KeyPress);
            // 
            // requested
            // 
            this.requested.AutoSize = true;
            this.requested.Location = new System.Drawing.Point(16, 71);
            this.requested.Name = "requested";
            this.requested.Size = new System.Drawing.Size(62, 13);
            this.requested.TabIndex = 2;
            this.requested.Text = "Talep Eden";
            // 
            // requestDetail
            // 
            this.requestDetail.AutoSize = true;
            this.requestDetail.Location = new System.Drawing.Point(16, 102);
            this.requestDetail.Name = "requestDetail";
            this.requestDetail.Size = new System.Drawing.Size(87, 13);
            this.requestDetail.TabIndex = 1;
            this.requestDetail.Text = "Talep Açıklaması";
            // 
            // requestName
            // 
            this.requestName.AutoSize = true;
            this.requestName.Location = new System.Drawing.Point(16, 35);
            this.requestName.Name = "requestName";
            this.requestName.Size = new System.Drawing.Size(52, 13);
            this.requestName.TabIndex = 0;
            this.requestName.Text = "Talep Adı";
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.btnCompleteRequest);
            this.grpAction.Controls.Add(this.btnMyRequest);
            this.grpAction.Controls.Add(this.btnCreateRequest);
            this.grpAction.Controls.Add(this.btnWeb);
            this.grpAction.Controls.Add(this.btnRequestRefresh);
            this.grpAction.Controls.Add(this.btnRequestEnd);
            this.grpAction.Location = new System.Drawing.Point(687, 482);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(245, 211);
            this.grpAction.TabIndex = 4;
            this.grpAction.TabStop = false;
            this.grpAction.Text = "Aksiyonlar";
            // 
            // btnCompleteRequest
            // 
            this.btnCompleteRequest.Location = new System.Drawing.Point(13, 172);
            this.btnCompleteRequest.Name = "btnCompleteRequest";
            this.btnCompleteRequest.Size = new System.Drawing.Size(137, 23);
            this.btnCompleteRequest.TabIndex = 5;
            this.btnCompleteRequest.Text = "Tamamlanan Talepler";
            this.btnCompleteRequest.UseVisualStyleBackColor = true;
            // 
            // btnMyRequest
            // 
            this.btnMyRequest.Location = new System.Drawing.Point(6, 135);
            this.btnMyRequest.Name = "btnMyRequest";
            this.btnMyRequest.Size = new System.Drawing.Size(109, 23);
            this.btnMyRequest.TabIndex = 5;
            this.btnMyRequest.Text = "Talep Ettiklerim";
            this.btnMyRequest.UseVisualStyleBackColor = true;
            this.btnMyRequest.Click += new System.EventHandler(this.btnMyRequest_Click);
            // 
            // btnCreateRequest
            // 
            this.btnCreateRequest.Location = new System.Drawing.Point(6, 106);
            this.btnCreateRequest.Name = "btnCreateRequest";
            this.btnCreateRequest.Size = new System.Drawing.Size(144, 23);
            this.btnCreateRequest.TabIndex = 6;
            this.btnCreateRequest.Text = "Talep Oluştur";
            this.btnCreateRequest.UseVisualStyleBackColor = true;
            // 
            // btnWeb
            // 
            this.btnWeb.Location = new System.Drawing.Point(6, 77);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(176, 23);
            this.btnWeb.TabIndex = 1;
            this.btnWeb.Text = "Web\'de Görüntüle";
            this.btnWeb.UseVisualStyleBackColor = true;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // btnRequestRefresh
            // 
            this.btnRequestRefresh.Location = new System.Drawing.Point(6, 48);
            this.btnRequestRefresh.Name = "btnRequestRefresh";
            this.btnRequestRefresh.Size = new System.Drawing.Size(91, 23);
            this.btnRequestRefresh.TabIndex = 0;
            this.btnRequestRefresh.Text = "Listeyi Yenile";
            this.btnRequestRefresh.UseVisualStyleBackColor = true;
            this.btnRequestRefresh.Click += new System.EventHandler(this.btnRequestRefresh_Click);
            // 
            // btnRequestEnd
            // 
            this.btnRequestEnd.Location = new System.Drawing.Point(6, 19);
            this.btnRequestEnd.Name = "btnRequestEnd";
            this.btnRequestEnd.Size = new System.Drawing.Size(59, 23);
            this.btnRequestEnd.TabIndex = 0;
            this.btnRequestEnd.Text = "İşi Bitir";
            this.btnRequestEnd.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(427, 37);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(132, 13);
            this.lblCount.TabIndex = 11;
            this.lblCount.Text = "Devam Eden Talep Sayısı:";
            // 
            // lblCountInfo
            // 
            this.lblCountInfo.AutoSize = true;
            this.lblCountInfo.Location = new System.Drawing.Point(567, 37);
            this.lblCountInfo.Name = "lblCountInfo";
            this.lblCountInfo.Size = new System.Drawing.Size(19, 13);
            this.lblCountInfo.TabIndex = 12;
            this.lblCountInfo.Text = "00";
            // 
            // RequestForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.lblCountInfo);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpRequest);
            this.Controls.Add(this.tlblTime);
            this.Controls.Add(this.grpInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestForm";
            this.Text = "Talep";
            this.Load += new System.EventHandler(this.Request_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.Label lblTcInfo;
      
        private System.Windows.Forms.Label tlblTime;
        private System.Windows.Forms.Label lblSurnameInfo;
        private System.Windows.Forms.Label lblNameInfo;
        private System.Windows.Forms.Label employeeSurname;
        private System.Windows.Forms.Label lblDepartmentInfo;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.GroupBox grpRequest;
        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label requested;
        private System.Windows.Forms.Label requestDetail;
        private System.Windows.Forms.Label requestName;
        private System.Windows.Forms.RichTextBox richTxtRequestContent;
        private System.Windows.Forms.TextBox txtRequested;
        private System.Windows.Forms.TextBox txtRequestTitle;
        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.Button btnRequestRefresh;
        private System.Windows.Forms.Button btnRequestEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWeb;
        private System.Windows.Forms.Button btnMyRequest;
        private System.Windows.Forms.Button btnCreateRequest;
        private System.Windows.Forms.Button btnCompleteRequest;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblCountInfo;
    }
}