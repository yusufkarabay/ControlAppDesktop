﻿namespace ControlAppDesktop.Forms
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
            this.lblHeadsetSeriNoInfo = new System.Windows.Forms.Label();
            this.lblDeliveryEmployee = new System.Windows.Forms.Label();
            this.lblHeadsetInfo = new System.Windows.Forms.Label();
            this.txtHeadsetSeriNo = new System.Windows.Forms.TextBox();
            this.cbxDeliveryEmployee = new System.Windows.Forms.ComboBox();
            this.txtHeadsetInfo = new System.Windows.Forms.TextBox();
            this.btnHeadsetDelivery = new System.Windows.Forms.Button();
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
            this.gbxHeadsetDelivery.Location = new System.Drawing.Point(265, 41);
            this.gbxHeadsetDelivery.Name = "gbxHeadsetDelivery";
            this.gbxHeadsetDelivery.Size = new System.Drawing.Size(421, 339);
            this.gbxHeadsetDelivery.TabIndex = 0;
            this.gbxHeadsetDelivery.TabStop = false;
            this.gbxHeadsetDelivery.Text = "Kulaklık Teslim Et";
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
            // lblDeliveryEmployee
            // 
            this.lblDeliveryEmployee.AutoSize = true;
            this.lblDeliveryEmployee.Location = new System.Drawing.Point(6, 69);
            this.lblDeliveryEmployee.Name = "lblDeliveryEmployee";
            this.lblDeliveryEmployee.Size = new System.Drawing.Size(111, 13);
            this.lblDeliveryEmployee.TabIndex = 1;
            this.lblDeliveryEmployee.Text = "Teslim Alan Personel :";
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
            // txtHeadsetSeriNo
            // 
            this.txtHeadsetSeriNo.Location = new System.Drawing.Point(122, 33);
            this.txtHeadsetSeriNo.Name = "txtHeadsetSeriNo";
            this.txtHeadsetSeriNo.Size = new System.Drawing.Size(195, 20);
            this.txtHeadsetSeriNo.TabIndex = 3;
            // 
            // cbxDeliveryEmployee
            // 
            this.cbxDeliveryEmployee.FormattingEnabled = true;
            this.cbxDeliveryEmployee.Location = new System.Drawing.Point(123, 66);
            this.cbxDeliveryEmployee.Name = "cbxDeliveryEmployee";
            this.cbxDeliveryEmployee.Size = new System.Drawing.Size(194, 21);
            this.cbxDeliveryEmployee.TabIndex = 4;
            // 
            // txtHeadsetInfo
            // 
            this.txtHeadsetInfo.Location = new System.Drawing.Point(122, 100);
            this.txtHeadsetInfo.Name = "txtHeadsetInfo";
            this.txtHeadsetInfo.Size = new System.Drawing.Size(195, 20);
            this.txtHeadsetInfo.TabIndex = 5;
            // 
            // btnHeadsetDelivery
            // 
            this.btnHeadsetDelivery.Location = new System.Drawing.Point(174, 221);
            this.btnHeadsetDelivery.Name = "btnHeadsetDelivery";
            this.btnHeadsetDelivery.Size = new System.Drawing.Size(75, 23);
            this.btnHeadsetDelivery.TabIndex = 6;
            this.btnHeadsetDelivery.Text = "Teslim Et";
            this.btnHeadsetDelivery.UseVisualStyleBackColor = true;
            this.btnHeadsetDelivery.Click += new System.EventHandler(this.btnHeadsetDelivery_Click);
            // 
            // HeadsetDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxHeadsetDelivery);
            this.Name = "HeadsetDeliveryForm";
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
    }
}