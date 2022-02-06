namespace ControlAppDesktop.Forms
{
    partial class HeadsetDeliveryForm
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
            this.gbxHeadsetDelivery = new System.Windows.Forms.GroupBox();
            this.btnHeadsetDelivery = new System.Windows.Forms.Button();
            this.txtHeadsetInfo = new System.Windows.Forms.TextBox();
            this.cbxDeliveryEmployee = new System.Windows.Forms.ComboBox();
            this.txtHeadsetSeriNo = new System.Windows.Forms.TextBox();
            this.lblHeadsetInfo = new System.Windows.Forms.Label();
            this.lblDeliveryEmployee = new System.Windows.Forms.Label();
            this.lblHeadsetSeriNoInfo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxHeadsetDelivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxHeadsetDelivery
            // 
            this.gbxHeadsetDelivery.Controls.Add(this.btnHeadsetDelivery);
            this.gbxHeadsetDelivery.Controls.Add(this.txtHeadsetInfo);
            this.gbxHeadsetDelivery.Controls.Add(this.cbxDeliveryEmployee);
            this.gbxHeadsetDelivery.Controls.Add(this.txtHeadsetSeriNo);
            this.gbxHeadsetDelivery.Controls.Add(this.lblHeadsetInfo);
            this.gbxHeadsetDelivery.Controls.Add(this.lblDeliveryEmployee);
            this.gbxHeadsetDelivery.Controls.Add(this.lblHeadsetSeriNoInfo);
            this.gbxHeadsetDelivery.Location = new System.Drawing.Point(43, 69);
            this.gbxHeadsetDelivery.Name = "gbxHeadsetDelivery";
            this.gbxHeadsetDelivery.Size = new System.Drawing.Size(421, 211);
            this.gbxHeadsetDelivery.TabIndex = 0;
            this.gbxHeadsetDelivery.TabStop = false;
            this.gbxHeadsetDelivery.Text = "Kulaklık Teslim Et";
            // 
            // btnHeadsetDelivery
            // 
            this.btnHeadsetDelivery.Location = new System.Drawing.Point(173, 159);
            this.btnHeadsetDelivery.Name = "btnHeadsetDelivery";
            this.btnHeadsetDelivery.Size = new System.Drawing.Size(75, 23);
            this.btnHeadsetDelivery.TabIndex = 3;
            this.btnHeadsetDelivery.Text = "Teslim Et";
            this.btnHeadsetDelivery.UseVisualStyleBackColor = true;
            this.btnHeadsetDelivery.Click += new System.EventHandler(this.btnHeadsetDelivery_Click);
            // 
            // txtHeadsetInfo
            // 
            this.txtHeadsetInfo.Location = new System.Drawing.Point(122, 100);
            this.txtHeadsetInfo.Name = "txtHeadsetInfo";
            this.txtHeadsetInfo.Size = new System.Drawing.Size(195, 20);
            this.txtHeadsetInfo.TabIndex = 2;
            // 
            // cbxDeliveryEmployee
            // 
            this.cbxDeliveryEmployee.FormattingEnabled = true;
            this.cbxDeliveryEmployee.Location = new System.Drawing.Point(123, 66);
            this.cbxDeliveryEmployee.Name = "cbxDeliveryEmployee";
            this.cbxDeliveryEmployee.Size = new System.Drawing.Size(194, 21);
            this.cbxDeliveryEmployee.TabIndex = 1;
            // 
            // txtHeadsetSeriNo
            // 
            this.txtHeadsetSeriNo.Location = new System.Drawing.Point(122, 33);
            this.txtHeadsetSeriNo.Name = "txtHeadsetSeriNo";
            this.txtHeadsetSeriNo.Size = new System.Drawing.Size(195, 20);
            this.txtHeadsetSeriNo.TabIndex = 0;
            // 
            // lblHeadsetInfo
            // 
            this.lblHeadsetInfo.AutoSize = true;
            this.lblHeadsetInfo.Location = new System.Drawing.Point(7, 103);
            this.lblHeadsetInfo.Name = "lblHeadsetInfo";
            this.lblHeadsetInfo.Size = new System.Drawing.Size(90, 13);
            this.lblHeadsetInfo.TabIndex = 2;
            this.lblHeadsetInfo.Text = "Kulaklık Durumu :";
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
            // lblHeadsetSeriNoInfo
            // 
            this.lblHeadsetSeriNoInfo.AutoSize = true;
            this.lblHeadsetSeriNoInfo.Location = new System.Drawing.Point(6, 40);
            this.lblHeadsetSeriNoInfo.Name = "lblHeadsetSeriNoInfo";
            this.lblHeadsetSeriNoInfo.Size = new System.Drawing.Size(88, 13);
            this.lblHeadsetSeriNoInfo.TabIndex = 0;
            this.lblHeadsetSeriNoInfo.Text = "Kulaklık Seri No :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(43, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::ControlAppDesktop.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(471, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // HeadsetDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(540, 437);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gbxHeadsetDelivery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HeadsetDeliveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeadsetDeliveryForm";
            this.Load += new System.EventHandler(this.HeadsetDeliveryForm_Load);
            this.gbxHeadsetDelivery.ResumeLayout(false);
            this.gbxHeadsetDelivery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxHeadsetDelivery;
        private System.Windows.Forms.Button btnHeadsetDelivery;
        private System.Windows.Forms.TextBox txtHeadsetInfo;
        private System.Windows.Forms.ComboBox cbxDeliveryEmployee;
        private System.Windows.Forms.TextBox txtHeadsetSeriNo;
        private System.Windows.Forms.Label lblHeadsetInfo;
        private System.Windows.Forms.Label lblDeliveryEmployee;
        private System.Windows.Forms.Label lblHeadsetSeriNoInfo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnClose;
    }
}