namespace ControlAppDesktop.Forms
{
    partial class CabinetDeliveryForm
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
            this.gbxCabinetDelivery = new System.Windows.Forms.GroupBox();
            this.btnCabinetDelivery = new System.Windows.Forms.Button();
            this.cbxDeliveryEmployee = new System.Windows.Forms.ComboBox();
            this.txtCabinetNo = new System.Windows.Forms.TextBox();
            this.lblDeliveryEmployee = new System.Windows.Forms.Label();
            this.lblCabinetNoInfo = new System.Windows.Forms.Label();
            this.gbxCabinetDelivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // gbxCabinetDelivery
            // 
            this.gbxCabinetDelivery.Controls.Add(this.btnCabinetDelivery);
            this.gbxCabinetDelivery.Controls.Add(this.cbxDeliveryEmployee);
            this.gbxCabinetDelivery.Controls.Add(this.txtCabinetNo);
            this.gbxCabinetDelivery.Controls.Add(this.lblDeliveryEmployee);
            this.gbxCabinetDelivery.Controls.Add(this.lblCabinetNoInfo);
            this.gbxCabinetDelivery.Location = new System.Drawing.Point(307, 56);
            this.gbxCabinetDelivery.Name = "gbxCabinetDelivery";
            this.gbxCabinetDelivery.Size = new System.Drawing.Size(421, 339);
            this.gbxCabinetDelivery.TabIndex = 6;
            this.gbxCabinetDelivery.TabStop = false;
            this.gbxCabinetDelivery.Text = "Dolap Teslim Et";
            // 
            // btnCabinetDelivery
            // 
            this.btnCabinetDelivery.Location = new System.Drawing.Point(165, 125);
            this.btnCabinetDelivery.Name = "btnCabinetDelivery";
            this.btnCabinetDelivery.Size = new System.Drawing.Size(75, 23);
            this.btnCabinetDelivery.TabIndex = 6;
            this.btnCabinetDelivery.Text = "Teslim Et";
            this.btnCabinetDelivery.UseVisualStyleBackColor = true;
            this.btnCabinetDelivery.Click += new System.EventHandler(this.btnCabinetDelivery_Click);
            // 
            // cbxDeliveryEmployee
            // 
            this.cbxDeliveryEmployee.FormattingEnabled = true;
            this.cbxDeliveryEmployee.Location = new System.Drawing.Point(123, 66);
            this.cbxDeliveryEmployee.Name = "cbxDeliveryEmployee";
            this.cbxDeliveryEmployee.Size = new System.Drawing.Size(194, 21);
            this.cbxDeliveryEmployee.TabIndex = 4;
            // 
            // txtCabinetNo
            // 
            this.txtCabinetNo.Location = new System.Drawing.Point(122, 33);
            this.txtCabinetNo.Name = "txtCabinetNo";
            this.txtCabinetNo.Size = new System.Drawing.Size(195, 20);
            this.txtCabinetNo.TabIndex = 3;
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
            // lblCabinetNoInfo
            // 
            this.lblCabinetNoInfo.AutoSize = true;
            this.lblCabinetNoInfo.Location = new System.Drawing.Point(6, 40);
            this.lblCabinetNoInfo.Name = "lblCabinetNoInfo";
            this.lblCabinetNoInfo.Size = new System.Drawing.Size(75, 13);
            this.lblCabinetNoInfo.TabIndex = 0;
            this.lblCabinetNoInfo.Text = "Çekmece No :";
            // 
            // CabinetDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gbxCabinetDelivery);
            this.Name = "CabinetDeliveryForm";
            this.Text = "CabinetDeliveryForm";
            this.Load += new System.EventHandler(this.CabinetDeliveryForm_Load);
            this.gbxCabinetDelivery.ResumeLayout(false);
            this.gbxCabinetDelivery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbxCabinetDelivery;
        private System.Windows.Forms.Button btnCabinetDelivery;
        private System.Windows.Forms.ComboBox cbxDeliveryEmployee;
        private System.Windows.Forms.TextBox txtCabinetNo;
        private System.Windows.Forms.Label lblDeliveryEmployee;
        private System.Windows.Forms.Label lblCabinetNoInfo;
    }
}