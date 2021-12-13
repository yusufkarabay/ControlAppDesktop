namespace ControlAppDesktop.Forms
{
    partial class Request
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
            this.btnRequestRefresh = new System.Windows.Forms.Button();
            this.btnRequestPrint = new System.Windows.Forms.Button();
            this.btnRequestEnd = new System.Windows.Forms.Button();
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
            this.grpInfo.Location = new System.Drawing.Point(23, 12);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(389, 209);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Kişi Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "TC:";
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Location = new System.Drawing.Point(24, 163);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(62, 13);
            this.department.TabIndex = 8;
            this.department.Text = "Departman:";
            // 
            // employeeSurname
            // 
            this.employeeSurname.AutoSize = true;
            this.employeeSurname.Location = new System.Drawing.Point(24, 99);
            this.employeeSurname.Name = "employeeSurname";
            this.employeeSurname.Size = new System.Drawing.Size(40, 13);
            this.employeeSurname.TabIndex = 3;
            this.employeeSurname.Text = "Soyad:";
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Location = new System.Drawing.Point(24, 67);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(23, 13);
            this.employeeName.TabIndex = 2;
            this.employeeName.Text = "Ad:";
            // 
            // lblDepartmentInfo
            // 
            this.lblDepartmentInfo.AutoSize = true;
            this.lblDepartmentInfo.Location = new System.Drawing.Point(132, 162);
            this.lblDepartmentInfo.Name = "lblDepartmentInfo";
            this.lblDepartmentInfo.Size = new System.Drawing.Size(19, 13);
            this.lblDepartmentInfo.TabIndex = 9;
            this.lblDepartmentInfo.Text = "00";
            // 
            // lblSurnameInfo
            // 
            this.lblSurnameInfo.AutoSize = true;
            this.lblSurnameInfo.Location = new System.Drawing.Point(132, 98);
            this.lblSurnameInfo.Name = "lblSurnameInfo";
            this.lblSurnameInfo.Size = new System.Drawing.Size(19, 13);
            this.lblSurnameInfo.TabIndex = 5;
            this.lblSurnameInfo.Text = "00";
            // 
            // lblNameInfo
            // 
            this.lblNameInfo.AutoSize = true;
            this.lblNameInfo.Location = new System.Drawing.Point(132, 66);
            this.lblNameInfo.Name = "lblNameInfo";
            this.lblNameInfo.Size = new System.Drawing.Size(19, 13);
            this.lblNameInfo.TabIndex = 4;
            this.lblNameInfo.Text = "00";
            // 
            // lblTcInfo
            // 
            this.lblTcInfo.AutoSize = true;
            this.lblTcInfo.Location = new System.Drawing.Point(132, 34);
            this.lblTcInfo.Name = "lblTcInfo";
            this.lblTcInfo.Size = new System.Drawing.Size(19, 13);
            this.lblTcInfo.TabIndex = 1;
            this.lblTcInfo.Text = "00";
            // 
            // tlblTime
            // 
            this.tlblTime.AutoSize = true;
            this.tlblTime.Location = new System.Drawing.Point(630, 47);
            this.tlblTime.Name = "tlblTime";
            this.tlblTime.Size = new System.Drawing.Size(40, 13);
            this.tlblTime.TabIndex = 1;
            this.tlblTime.Text = "Zaman";
            // 
            // grpRequest
            // 
            this.grpRequest.Controls.Add(this.dgvRequest);
            this.grpRequest.Location = new System.Drawing.Point(50, 268);
            this.grpRequest.Name = "grpRequest";
            this.grpRequest.Size = new System.Drawing.Size(947, 272);
            this.grpRequest.TabIndex = 2;
            this.grpRequest.TabStop = false;
            this.grpRequest.Text = "Talepler";
            // 
            // dgvRequest
            // 
            this.dgvRequest.AllowUserToAddRows = false;
            this.dgvRequest.AllowUserToDeleteRows = false;
            this.dgvRequest.AllowUserToResizeColumns = false;
            this.dgvRequest.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequest.Location = new System.Drawing.Point(3, 16);
            this.dgvRequest.MultiSelect = false;
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.ReadOnly = true;
            this.dgvRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequest.Size = new System.Drawing.Size(941, 253);
            this.dgvRequest.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTxtRequestContent);
            this.groupBox1.Controls.Add(this.txtRequested);
            this.groupBox1.Controls.Add(this.txtRequestTitle);
            this.groupBox1.Controls.Add(this.requested);
            this.groupBox1.Controls.Add(this.requestDetail);
            this.groupBox1.Controls.Add(this.requestName);
            this.groupBox1.Location = new System.Drawing.Point(53, 546);
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
            // 
            // txtRequested
            // 
            this.txtRequested.Location = new System.Drawing.Point(183, 64);
            this.txtRequested.Name = "txtRequested";
            this.txtRequested.Size = new System.Drawing.Size(282, 20);
            this.txtRequested.TabIndex = 4;
            // 
            // txtRequestTitle
            // 
            this.txtRequestTitle.Location = new System.Drawing.Point(183, 27);
            this.txtRequestTitle.Name = "txtRequestTitle";
            this.txtRequestTitle.Size = new System.Drawing.Size(282, 20);
            this.txtRequestTitle.TabIndex = 3;
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
            this.grpAction.Controls.Add(this.btnRequestRefresh);
            this.grpAction.Controls.Add(this.btnRequestPrint);
            this.grpAction.Controls.Add(this.btnRequestEnd);
            this.grpAction.Location = new System.Drawing.Point(702, 573);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(245, 131);
            this.grpAction.TabIndex = 4;
            this.grpAction.TabStop = false;
            this.grpAction.Text = "Aksiyonlar";
            // 
            // btnRequestRefresh
            // 
            this.btnRequestRefresh.Location = new System.Drawing.Point(22, 56);
            this.btnRequestRefresh.Name = "btnRequestRefresh";
            this.btnRequestRefresh.Size = new System.Drawing.Size(135, 23);
            this.btnRequestRefresh.TabIndex = 0;
            this.btnRequestRefresh.Text = "Listeyi Yenile";
            this.btnRequestRefresh.UseVisualStyleBackColor = true;
            // 
            // btnRequestPrint
            // 
            this.btnRequestPrint.Location = new System.Drawing.Point(22, 94);
            this.btnRequestPrint.Name = "btnRequestPrint";
            this.btnRequestPrint.Size = new System.Drawing.Size(75, 23);
            this.btnRequestPrint.TabIndex = 0;
            this.btnRequestPrint.Text = "Yazdır";
            this.btnRequestPrint.UseVisualStyleBackColor = true;
            // 
            // btnRequestEnd
            // 
            this.btnRequestEnd.Location = new System.Drawing.Point(22, 27);
            this.btnRequestEnd.Name = "btnRequestEnd";
            this.btnRequestEnd.Size = new System.Drawing.Size(75, 23);
            this.btnRequestEnd.TabIndex = 0;
            this.btnRequestEnd.Text = "İşi Bitir";
            this.btnRequestEnd.UseVisualStyleBackColor = true;
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 776);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpRequest);
            this.Controls.Add(this.tlblTime);
            this.Controls.Add(this.grpInfo);
            this.Name = "Request";
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
        private System.Windows.Forms.Button btnRequestPrint;
        private System.Windows.Forms.Button btnRequestEnd;
        private System.Windows.Forms.Label label1;
    }
}