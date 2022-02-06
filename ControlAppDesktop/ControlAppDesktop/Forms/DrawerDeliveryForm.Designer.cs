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
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxDrawerDelivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 35);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // gbxDrawerDelivery
            // 
            this.gbxDrawerDelivery.Controls.Add(this.btnDrawerDelivery);
            this.gbxDrawerDelivery.Controls.Add(this.cbxDeliveryEmployee);
            this.gbxDrawerDelivery.Controls.Add(this.txtDrawerNo);
            this.gbxDrawerDelivery.Controls.Add(this.lblDeliveryEmployee);
            this.gbxDrawerDelivery.Controls.Add(this.lblDrawerNoInfo);
            this.gbxDrawerDelivery.Location = new System.Drawing.Point(40, 90);
            this.gbxDrawerDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.gbxDrawerDelivery.Name = "gbxDrawerDelivery";
            this.gbxDrawerDelivery.Padding = new System.Windows.Forms.Padding(4);
            this.gbxDrawerDelivery.Size = new System.Drawing.Size(491, 236);
            this.gbxDrawerDelivery.TabIndex = 4;
            this.gbxDrawerDelivery.TabStop = false;
            this.gbxDrawerDelivery.Text = "Çekmece Teslim Et";
            // 
            // btnDrawerDelivery
            // 
            this.btnDrawerDelivery.Location = new System.Drawing.Point(207, 131);
            this.btnDrawerDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.btnDrawerDelivery.Name = "btnDrawerDelivery";
            this.btnDrawerDelivery.Size = new System.Drawing.Size(88, 28);
            this.btnDrawerDelivery.TabIndex = 2;
            this.btnDrawerDelivery.Text = "Teslim Et";
            this.btnDrawerDelivery.UseVisualStyleBackColor = true;
            this.btnDrawerDelivery.Click += new System.EventHandler(this.btnDrawerDelivery_Click);
            // 
            // cbxDeliveryEmployee
            // 
            this.cbxDeliveryEmployee.FormattingEnabled = true;
            this.cbxDeliveryEmployee.Location = new System.Drawing.Point(164, 86);
            this.cbxDeliveryEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDeliveryEmployee.Name = "cbxDeliveryEmployee";
            this.cbxDeliveryEmployee.Size = new System.Drawing.Size(226, 25);
            this.cbxDeliveryEmployee.TabIndex = 1;
            // 
            // txtDrawerNo
            // 
            this.txtDrawerNo.Location = new System.Drawing.Point(163, 44);
            this.txtDrawerNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtDrawerNo.Name = "txtDrawerNo";
            this.txtDrawerNo.Size = new System.Drawing.Size(226, 23);
            this.txtDrawerNo.TabIndex = 0;
            // 
            // lblDeliveryEmployee
            // 
            this.lblDeliveryEmployee.AutoSize = true;
            this.lblDeliveryEmployee.Location = new System.Drawing.Point(8, 90);
            this.lblDeliveryEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeliveryEmployee.Name = "lblDeliveryEmployee";
            this.lblDeliveryEmployee.Size = new System.Drawing.Size(143, 17);
            this.lblDeliveryEmployee.TabIndex = 1;
            this.lblDeliveryEmployee.Text = "Teslim Alan Personel :";
            // 
            // lblDrawerNoInfo
            // 
            this.lblDrawerNoInfo.AutoSize = true;
            this.lblDrawerNoInfo.Location = new System.Drawing.Point(8, 52);
            this.lblDrawerNoInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDrawerNoInfo.Name = "lblDrawerNoInfo";
            this.lblDrawerNoInfo.Size = new System.Drawing.Size(102, 17);
            this.lblDrawerNoInfo.TabIndex = 0;
            this.lblDrawerNoInfo.Text = "Çekmece No :";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::ControlAppDesktop.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(559, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 34);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DrawerDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(604, 414);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gbxDrawerDelivery);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DrawerDeliveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btnClose;
    }
}