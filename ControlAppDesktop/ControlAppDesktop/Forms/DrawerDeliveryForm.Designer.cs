﻿namespace ControlAppDesktop.Forms
{
    partial class DrawerDeliveryForm
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
            this.gbxDrawerDelivery = new System.Windows.Forms.GroupBox();
            this.btnDrawerDelivery = new System.Windows.Forms.Button();
            this.cbxDeliveryEmployee = new System.Windows.Forms.ComboBox();
            this.txtDrawerNo = new System.Windows.Forms.TextBox();
            this.lblDeliveryEmployee = new System.Windows.Forms.Label();
            this.lblDrawerNoInfo = new System.Windows.Forms.Label();
            this.gbxDrawerDelivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // gbxDrawerDelivery
            // 
            this.gbxDrawerDelivery.Controls.Add(this.btnDrawerDelivery);
            this.gbxDrawerDelivery.Controls.Add(this.cbxDeliveryEmployee);
            this.gbxDrawerDelivery.Controls.Add(this.txtDrawerNo);
            this.gbxDrawerDelivery.Controls.Add(this.lblDeliveryEmployee);
            this.gbxDrawerDelivery.Controls.Add(this.lblDrawerNoInfo);
            this.gbxDrawerDelivery.Location = new System.Drawing.Point(307, 56);
            this.gbxDrawerDelivery.Name = "gbxDrawerDelivery";
            this.gbxDrawerDelivery.Size = new System.Drawing.Size(421, 339);
            this.gbxDrawerDelivery.TabIndex = 4;
            this.gbxDrawerDelivery.TabStop = false;
            this.gbxDrawerDelivery.Text = "Çekmece Teslim Et";
            // 
            // btnDrawerDelivery
            // 
            this.btnDrawerDelivery.Location = new System.Drawing.Point(165, 125);
            this.btnDrawerDelivery.Name = "btnDrawerDelivery";
            this.btnDrawerDelivery.Size = new System.Drawing.Size(75, 23);
            this.btnDrawerDelivery.TabIndex = 6;
            this.btnDrawerDelivery.Text = "Teslim Et";
            this.btnDrawerDelivery.UseVisualStyleBackColor = true;
            this.btnDrawerDelivery.Click += new System.EventHandler(this.btnDrawerDelivery_Click);
            // 
            // cbxDeliveryEmployee
            // 
            this.cbxDeliveryEmployee.FormattingEnabled = true;
            this.cbxDeliveryEmployee.Location = new System.Drawing.Point(123, 66);
            this.cbxDeliveryEmployee.Name = "cbxDeliveryEmployee";
            this.cbxDeliveryEmployee.Size = new System.Drawing.Size(194, 21);
            this.cbxDeliveryEmployee.TabIndex = 4;
            // 
            // txtDrawerNo
            // 
            this.txtDrawerNo.Location = new System.Drawing.Point(122, 33);
            this.txtDrawerNo.Name = "txtDrawerNo";
            this.txtDrawerNo.Size = new System.Drawing.Size(195, 20);
            this.txtDrawerNo.TabIndex = 3;
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
            // lblDrawerNoInfo
            // 
            this.lblDrawerNoInfo.AutoSize = true;
            this.lblDrawerNoInfo.Location = new System.Drawing.Point(6, 40);
            this.lblDrawerNoInfo.Name = "lblDrawerNoInfo";
            this.lblDrawerNoInfo.Size = new System.Drawing.Size(75, 13);
            this.lblDrawerNoInfo.TabIndex = 0;
            this.lblDrawerNoInfo.Text = "Çekmece No :";
            // 
            // DrawerDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gbxDrawerDelivery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DrawerDeliveryForm";
            this.Text = "DrawerDeliveryForm";
            this.Load += new System.EventHandler(this.DrawerDeliveryForm_Load);
            this.gbxDrawerDelivery.ResumeLayout(false);
            this.gbxDrawerDelivery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbxDrawerDelivery;
        private System.Windows.Forms.Button btnDrawerDelivery;
        private System.Windows.Forms.ComboBox cbxDeliveryEmployee;
        private System.Windows.Forms.TextBox txtDrawerNo;
        private System.Windows.Forms.Label lblDeliveryEmployee;
        private System.Windows.Forms.Label lblDrawerNoInfo;
    }
}