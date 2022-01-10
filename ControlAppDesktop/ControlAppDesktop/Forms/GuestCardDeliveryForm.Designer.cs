namespace ControlAppDesktop.Forms
{
    partial class GuestCardDeliveryForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbxGuestCardDelivery = new System.Windows.Forms.GroupBox();
            this.btnGuestCardDelivery = new System.Windows.Forms.Button();
            this.cbxDeliveryEmployee = new System.Windows.Forms.ComboBox();
            this.txtGuestCardNo = new System.Windows.Forms.TextBox();
            this.lblDeliveryEmployee = new System.Windows.Forms.Label();
            this.lblNoInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxGuestCardDelivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // gbxGuestCardDelivery
            // 
            this.gbxGuestCardDelivery.Controls.Add(this.btnGuestCardDelivery);
            this.gbxGuestCardDelivery.Controls.Add(this.cbxDeliveryEmployee);
            this.gbxGuestCardDelivery.Controls.Add(this.txtGuestCardNo);
            this.gbxGuestCardDelivery.Controls.Add(this.lblDeliveryEmployee);
            this.gbxGuestCardDelivery.Controls.Add(this.lblNoInfo);
            this.gbxGuestCardDelivery.Location = new System.Drawing.Point(259, 32);
            this.gbxGuestCardDelivery.Name = "gbxGuestCardDelivery";
            this.gbxGuestCardDelivery.Size = new System.Drawing.Size(421, 197);
            this.gbxGuestCardDelivery.TabIndex = 8;
            this.gbxGuestCardDelivery.TabStop = false;
            this.gbxGuestCardDelivery.Text = "Misafir Kart Teslim Et";
            // 
            // btnGuestCardDelivery
            // 
            this.btnGuestCardDelivery.Location = new System.Drawing.Point(165, 125);
            this.btnGuestCardDelivery.Name = "btnGuestCardDelivery";
            this.btnGuestCardDelivery.Size = new System.Drawing.Size(75, 23);
            this.btnGuestCardDelivery.TabIndex = 6;
            this.btnGuestCardDelivery.Text = "Teslim Et";
            this.btnGuestCardDelivery.UseVisualStyleBackColor = true;
            this.btnGuestCardDelivery.Click += new System.EventHandler(this.btnGuestCardDelivery_Click);
            // 
            // cbxDeliveryEmployee
            // 
            this.cbxDeliveryEmployee.FormattingEnabled = true;
            this.cbxDeliveryEmployee.Location = new System.Drawing.Point(123, 66);
            this.cbxDeliveryEmployee.Name = "cbxDeliveryEmployee";
            this.cbxDeliveryEmployee.Size = new System.Drawing.Size(194, 21);
            this.cbxDeliveryEmployee.TabIndex = 4;
            // 
            // txtGuestCardNo
            // 
            this.txtGuestCardNo.Location = new System.Drawing.Point(122, 33);
            this.txtGuestCardNo.Name = "txtGuestCardNo";
            this.txtGuestCardNo.Size = new System.Drawing.Size(195, 20);
            this.txtGuestCardNo.TabIndex = 3;
            // 
            // lblDeliveryEmployee
            // 
            this.lblDeliveryEmployee.AutoSize = true;
            this.lblDeliveryEmployee.Location = new System.Drawing.Point(6, 69);
            this.lblDeliveryEmployee.Name = "lblDeliveryEmployee";
            this.lblDeliveryEmployee.Size = new System.Drawing.Size(111, 13);
            this.lblDeliveryEmployee.TabIndex = 1;
            this.lblDeliveryEmployee.Text = "Teslim Alan Personel :";
            // 
            // lblNoInfo
            // 
            this.lblNoInfo.AutoSize = true;
            this.lblNoInfo.Location = new System.Drawing.Point(6, 40);
            this.lblNoInfo.Name = "lblNoInfo";
            this.lblNoInfo.Size = new System.Drawing.Size(75, 13);
            this.lblNoInfo.TabIndex = 0;
            this.lblNoInfo.Text = "Çekmece No :";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(133, 181);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GuestCardDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 335);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gbxGuestCardDelivery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestCardDeliveryForm";
            this.Text = "GuestCardDeliveryForm";
            this.Load += new System.EventHandler(this.GuestCardDeliveryForm_Load);
            this.gbxGuestCardDelivery.ResumeLayout(false);
            this.gbxGuestCardDelivery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbxGuestCardDelivery;
        private System.Windows.Forms.Button btnGuestCardDelivery;
        private System.Windows.Forms.ComboBox cbxDeliveryEmployee;
        private System.Windows.Forms.TextBox txtGuestCardNo;
        private System.Windows.Forms.Label lblDeliveryEmployee;
        private System.Windows.Forms.Label lblNoInfo;
        private System.Windows.Forms.Button btnClose;
    }
}