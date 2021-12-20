namespace ControlAppDesktop.Forms
{
    partial class HeadsetForm
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
            this.gbHeadset = new System.Windows.Forms.GroupBox();
            this.dgvHeadset = new System.Windows.Forms.DataGridView();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblHeadsetSeriNo = new System.Windows.Forms.Label();
            this.headsetstatus = new System.Windows.Forms.Label();
            this.lblDeliveryPerson = new System.Windows.Forms.Label();
            this.lblReceiverPerson = new System.Windows.Forms.Label();
            this.lblHeadsetStatusInfo = new System.Windows.Forms.Label();
            this.lblDeliveryPersonInfo = new System.Windows.Forms.Label();
            this.lblReceiverPersonInfo = new System.Windows.Forms.Label();
            this.lblHeadsetSeriNoInfo = new System.Windows.Forms.Label();
            this.gbHeadset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeadset)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHeadset
            // 
            this.gbHeadset.Controls.Add(this.dgvHeadset);
            this.gbHeadset.Location = new System.Drawing.Point(50, 331);
            this.gbHeadset.Name = "gbHeadset";
            this.gbHeadset.Size = new System.Drawing.Size(767, 255);
            this.gbHeadset.TabIndex = 0;
            this.gbHeadset.TabStop = false;
            this.gbHeadset.Text = "Teslim Edilmiş Kulaklıklar";
            // 
            // dgvHeadset
            // 
            this.dgvHeadset.AllowUserToAddRows = false;
            this.dgvHeadset.AllowUserToDeleteRows = false;
            this.dgvHeadset.AllowUserToResizeColumns = false;
            this.dgvHeadset.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvHeadset.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHeadset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHeadset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeadset.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvHeadset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHeadset.Location = new System.Drawing.Point(3, 16);
            this.dgvHeadset.MultiSelect = false;
            this.dgvHeadset.Name = "dgvHeadset";
            this.dgvHeadset.ReadOnly = true;
            this.dgvHeadset.RowHeadersVisible = false;
            this.dgvHeadset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHeadset.Size = new System.Drawing.Size(761, 236);
            this.dgvHeadset.TabIndex = 1;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblHeadsetSeriNo);
            this.grpInfo.Controls.Add(this.headsetstatus);
            this.grpInfo.Controls.Add(this.lblDeliveryPerson);
            this.grpInfo.Controls.Add(this.lblReceiverPerson);
            this.grpInfo.Controls.Add(this.lblHeadsetStatusInfo);
            this.grpInfo.Controls.Add(this.lblDeliveryPersonInfo);
            this.grpInfo.Controls.Add(this.lblReceiverPersonInfo);
            this.grpInfo.Controls.Add(this.lblHeadsetSeriNoInfo);
            this.grpInfo.Location = new System.Drawing.Point(41, 39);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(300, 159);
            this.grpInfo.TabIndex = 1;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Kulaklık Bilgileri";
            // 
            // lblHeadsetSeriNo
            // 
            this.lblHeadsetSeriNo.AutoSize = true;
            this.lblHeadsetSeriNo.Location = new System.Drawing.Point(6, 25);
            this.lblHeadsetSeriNo.Name = "lblHeadsetSeriNo";
            this.lblHeadsetSeriNo.Size = new System.Drawing.Size(85, 13);
            this.lblHeadsetSeriNo.TabIndex = 10;
            this.lblHeadsetSeriNo.Text = "Kulaklık Seri No:";
            // 
            // headsetstatus
            // 
            this.headsetstatus.AutoSize = true;
            this.headsetstatus.Location = new System.Drawing.Point(6, 103);
            this.headsetstatus.Name = "headsetstatus";
            this.headsetstatus.Size = new System.Drawing.Size(84, 13);
            this.headsetstatus.TabIndex = 8;
            this.headsetstatus.Text = "Kulaklık Durumu";
            // 
            // lblDeliveryPerson
            // 
            this.lblDeliveryPerson.AutoSize = true;
            this.lblDeliveryPerson.Location = new System.Drawing.Point(6, 77);
            this.lblDeliveryPerson.Name = "lblDeliveryPerson";
            this.lblDeliveryPerson.Size = new System.Drawing.Size(68, 13);
            this.lblDeliveryPerson.TabIndex = 3;
            this.lblDeliveryPerson.Text = "Teslim Eden:";
            // 
            // lblReceiverPerson
            // 
            this.lblReceiverPerson.AutoSize = true;
            this.lblReceiverPerson.Location = new System.Drawing.Point(6, 51);
            this.lblReceiverPerson.Name = "lblReceiverPerson";
            this.lblReceiverPerson.Size = new System.Drawing.Size(64, 13);
            this.lblReceiverPerson.TabIndex = 2;
            this.lblReceiverPerson.Text = "Teslim Alan:";
            // 
            // lblHeadsetStatusInfo
            // 
            this.lblHeadsetStatusInfo.AutoSize = true;
            this.lblHeadsetStatusInfo.Location = new System.Drawing.Point(100, 103);
            this.lblHeadsetStatusInfo.Name = "lblHeadsetStatusInfo";
            this.lblHeadsetStatusInfo.Size = new System.Drawing.Size(19, 13);
            this.lblHeadsetStatusInfo.TabIndex = 9;
            this.lblHeadsetStatusInfo.Text = "00";
            // 
            // lblDeliveryPersonInfo
            // 
            this.lblDeliveryPersonInfo.AutoSize = true;
            this.lblDeliveryPersonInfo.Location = new System.Drawing.Point(100, 77);
            this.lblDeliveryPersonInfo.Name = "lblDeliveryPersonInfo";
            this.lblDeliveryPersonInfo.Size = new System.Drawing.Size(19, 13);
            this.lblDeliveryPersonInfo.TabIndex = 5;
            this.lblDeliveryPersonInfo.Text = "00";
            // 
            // lblReceiverPersonInfo
            // 
            this.lblReceiverPersonInfo.AutoSize = true;
            this.lblReceiverPersonInfo.Location = new System.Drawing.Point(100, 51);
            this.lblReceiverPersonInfo.Name = "lblReceiverPersonInfo";
            this.lblReceiverPersonInfo.Size = new System.Drawing.Size(19, 13);
            this.lblReceiverPersonInfo.TabIndex = 4;
            this.lblReceiverPersonInfo.Text = "00";
            // 
            // lblHeadsetSeriNoInfo
            // 
            this.lblHeadsetSeriNoInfo.AutoSize = true;
            this.lblHeadsetSeriNoInfo.Location = new System.Drawing.Point(100, 25);
            this.lblHeadsetSeriNoInfo.Name = "lblHeadsetSeriNoInfo";
            this.lblHeadsetSeriNoInfo.Size = new System.Drawing.Size(19, 13);
            this.lblHeadsetSeriNoInfo.TabIndex = 1;
            this.lblHeadsetSeriNoInfo.Text = "00";
            // 
            // HeadsetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 690);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.gbHeadset);
            this.Name = "HeadsetForm";
            this.Text = "HeadsetForm";
            this.Load += new System.EventHandler(this.HeadsetForm_Load);
            this.gbHeadset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeadset)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHeadset;
        private System.Windows.Forms.DataGridView dgvHeadset;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblHeadsetSeriNo;
        private System.Windows.Forms.Label headsetstatus;
        private System.Windows.Forms.Label lblDeliveryPerson;
        private System.Windows.Forms.Label lblReceiverPerson;
        private System.Windows.Forms.Label lblHeadsetStatusInfo;
        private System.Windows.Forms.Label lblDeliveryPersonInfo;
        private System.Windows.Forms.Label lblReceiverPersonInfo;
        private System.Windows.Forms.Label lblHeadsetSeriNoInfo;
    }
}