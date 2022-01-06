namespace ControlAppDesktop.Forms
{
    partial class EntranceCardDeliveryForm
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
            this.gbxEntranceCardDelivery = new System.Windows.Forms.GroupBox();
            this.btnHeadsetDelivery = new System.Windows.Forms.Button();
            this.cbxDeliveryEmployee = new System.Windows.Forms.ComboBox();
            this.txtEntranceCardSeriNo = new System.Windows.Forms.TextBox();
            this.lblDeliveryEmployee = new System.Windows.Forms.Label();
            this.lblEntranceCardSeriNoInfo = new System.Windows.Forms.Label();
            this.gbxEntranceCardDelivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // gbxEntranceCardDelivery
            // 
            this.gbxEntranceCardDelivery.Controls.Add(this.btnHeadsetDelivery);
            this.gbxEntranceCardDelivery.Controls.Add(this.cbxDeliveryEmployee);
            this.gbxEntranceCardDelivery.Controls.Add(this.txtEntranceCardSeriNo);
            this.gbxEntranceCardDelivery.Controls.Add(this.lblDeliveryEmployee);
            this.gbxEntranceCardDelivery.Controls.Add(this.lblEntranceCardSeriNoInfo);
            this.gbxEntranceCardDelivery.Location = new System.Drawing.Point(307, 56);
            this.gbxEntranceCardDelivery.Name = "gbxEntranceCardDelivery";
            this.gbxEntranceCardDelivery.Size = new System.Drawing.Size(421, 339);
            this.gbxEntranceCardDelivery.TabIndex = 2;
            this.gbxEntranceCardDelivery.TabStop = false;
            this.gbxEntranceCardDelivery.Text = "Giriş Kartı Teslim Et";
            // 
            // btnHeadsetDelivery
            // 
            this.btnHeadsetDelivery.Location = new System.Drawing.Point(165, 125);
            this.btnHeadsetDelivery.Name = "btnHeadsetDelivery";
            this.btnHeadsetDelivery.Size = new System.Drawing.Size(75, 23);
            this.btnHeadsetDelivery.TabIndex = 6;
            this.btnHeadsetDelivery.Text = "Teslim Et";
            this.btnHeadsetDelivery.UseVisualStyleBackColor = true;
            // 
            // cbxDeliveryEmployee
            // 
            this.cbxDeliveryEmployee.FormattingEnabled = true;
            this.cbxDeliveryEmployee.Location = new System.Drawing.Point(123, 66);
            this.cbxDeliveryEmployee.Name = "cbxDeliveryEmployee";
            this.cbxDeliveryEmployee.Size = new System.Drawing.Size(194, 21);
            this.cbxDeliveryEmployee.TabIndex = 4;
            // 
            // txtEntranceCardSeriNo
            // 
            this.txtEntranceCardSeriNo.Location = new System.Drawing.Point(122, 33);
            this.txtEntranceCardSeriNo.Name = "txtEntranceCardSeriNo";
            this.txtEntranceCardSeriNo.Size = new System.Drawing.Size(195, 20);
            this.txtEntranceCardSeriNo.TabIndex = 3;
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
            // lblEntranceCardSeriNoInfo
            // 
            this.lblEntranceCardSeriNoInfo.AutoSize = true;
            this.lblEntranceCardSeriNoInfo.Location = new System.Drawing.Point(6, 40);
            this.lblEntranceCardSeriNoInfo.Name = "lblEntranceCardSeriNoInfo";
            this.lblEntranceCardSeriNoInfo.Size = new System.Drawing.Size(95, 13);
            this.lblEntranceCardSeriNoInfo.TabIndex = 0;
            this.lblEntranceCardSeriNoInfo.Text = "Giriş Kartı Seri No :";
            // 
            // EntranceCardDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gbxEntranceCardDelivery);
            this.Name = "EntranceCardDelivery";
            this.Text = "EntranceCardDelivery";
            this.gbxEntranceCardDelivery.ResumeLayout(false);
            this.gbxEntranceCardDelivery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbxEntranceCardDelivery;
        private System.Windows.Forms.Button btnHeadsetDelivery;
        private System.Windows.Forms.ComboBox cbxDeliveryEmployee;
        private System.Windows.Forms.TextBox txtEntranceCardSeriNo;
        private System.Windows.Forms.Label lblDeliveryEmployee;
        private System.Windows.Forms.Label lblEntranceCardSeriNoInfo;
    }
}