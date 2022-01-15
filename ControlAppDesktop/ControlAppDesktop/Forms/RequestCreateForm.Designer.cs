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
            this.lblRequestTitle = new System.Windows.Forms.Label();
            this.lblRequestContent = new System.Windows.Forms.Label();
            this.lblRequestDepartment = new System.Windows.Forms.Label();
            this.txtRequestTitle = new System.Windows.Forms.TextBox();
            this.rtxtRequestContext = new System.Windows.Forms.RichTextBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRequestCreate = new System.Windows.Forms.Button();
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
            this.lblRequestContent.Location = new System.Drawing.Point(56, 119);
            this.lblRequestContent.Name = "lblRequestContent";
            this.lblRequestContent.Size = new System.Drawing.Size(65, 13);
            this.lblRequestContent.TabIndex = 1;
            this.lblRequestContent.Text = "Talep İçeriği";
            // 
            // lblRequestDepartment
            // 
            this.lblRequestDepartment.AutoSize = true;
            this.lblRequestDepartment.Location = new System.Drawing.Point(56, 222);
            this.lblRequestDepartment.Name = "lblRequestDepartment";
            this.lblRequestDepartment.Size = new System.Drawing.Size(97, 13);
            this.lblRequestDepartment.TabIndex = 2;
            this.lblRequestDepartment.Text = "Talep Departmanı :";
            // 
            // txtRequestTitle
            // 
            this.txtRequestTitle.Location = new System.Drawing.Point(167, 38);
            this.txtRequestTitle.Name = "txtRequestTitle";
            this.txtRequestTitle.Size = new System.Drawing.Size(178, 20);
            this.txtRequestTitle.TabIndex = 3;
            // 
            // rtxtRequestContext
            // 
            this.rtxtRequestContext.Location = new System.Drawing.Point(167, 116);
            this.rtxtRequestContext.Name = "rtxtRequestContext";
            this.rtxtRequestContext.Size = new System.Drawing.Size(178, 72);
            this.rtxtRequestContext.TabIndex = 4;
            this.rtxtRequestContext.Text = "";
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(167, 222);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(158, 21);
            this.cbDepartment.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(650, 78);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRequestCreate
            // 
            this.btnRequestCreate.Location = new System.Drawing.Point(605, 327);
            this.btnRequestCreate.Name = "btnRequestCreate";
            this.btnRequestCreate.Size = new System.Drawing.Size(75, 23);
            this.btnRequestCreate.TabIndex = 7;
            this.btnRequestCreate.Text = "Oluştur";
            this.btnRequestCreate.UseVisualStyleBackColor = true;
            this.btnRequestCreate.Click += new System.EventHandler(this.btnRequestCreate_Click);
            // 
            // RequestCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 592);
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
    }
}