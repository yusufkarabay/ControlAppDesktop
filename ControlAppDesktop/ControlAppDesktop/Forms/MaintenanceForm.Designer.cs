namespace ControlAppDesktop.Forms
{
    partial class MaintenanceForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblContractName = new System.Windows.Forms.Label();
            this.lblContractStartTime = new System.Windows.Forms.Label();
            this.lblContractCompany = new System.Windows.Forms.Label();
            this.lblCompanyAdress = new System.Windows.Forms.Label();
            this.lblContractCompanyTel = new System.Windows.Forms.Label();
            this.lblContractNotes = new System.Windows.Forms.Label();
            this.gbContact = new System.Windows.Forms.GroupBox();
            this.dgvContract = new System.Windows.Forms.DataGridView();
            this.gbContract = new System.Windows.Forms.GroupBox();
            this.rtbContractNotes = new System.Windows.Forms.RichTextBox();
            this.txtCompanyTel = new System.Windows.Forms.TextBox();
            this.dtpContractStartTime = new System.Windows.Forms.DateTimePicker();
            this.txtCompanyAdress = new System.Windows.Forms.TextBox();
            this.txtContractCompany = new System.Windows.Forms.TextBox();
            this.txtContractName = new System.Windows.Forms.TextBox();
            this.btnContractList = new System.Windows.Forms.Button();
            this.btnContractUpdate = new System.Windows.Forms.Button();
            this.gbMaintanance = new System.Windows.Forms.GroupBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbContractSelect = new System.Windows.Forms.ComboBox();
            this.dtpFirstMaintenance = new System.Windows.Forms.DateTimePicker();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblContractSelect = new System.Windows.Forms.Label();
            this.lblFirstMaintenance = new System.Windows.Forms.Label();
            this.btnContractAdd = new System.Windows.Forms.Button();
            this.btnMaintananceAdd = new System.Windows.Forms.Button();
            this.btnMaintananceList = new System.Windows.Forms.Button();
            this.btnMaintananceUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblContractEndTime = new System.Windows.Forms.Label();
            this.dtpContractEndTime = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStripContract = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            this.gbContract.SuspendLayout();
            this.gbMaintanance.SuspendLayout();
            this.contextMenuStripContract.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContractName
            // 
            this.lblContractName.AutoSize = true;
            this.lblContractName.Location = new System.Drawing.Point(19, 30);
            this.lblContractName.Name = "lblContractName";
            this.lblContractName.Size = new System.Drawing.Size(76, 13);
            this.lblContractName.TabIndex = 0;
            this.lblContractName.Text = "Sözleşme Adı :";
            // 
            // lblContractStartTime
            // 
            this.lblContractStartTime.AutoSize = true;
            this.lblContractStartTime.Location = new System.Drawing.Point(19, 63);
            this.lblContractStartTime.Name = "lblContractStartTime";
            this.lblContractStartTime.Size = new System.Drawing.Size(97, 13);
            this.lblContractStartTime.TabIndex = 1;
            this.lblContractStartTime.Text = "Başlangıç Zamanı :";
            // 
            // lblContractCompany
            // 
            this.lblContractCompany.AutoSize = true;
            this.lblContractCompany.Location = new System.Drawing.Point(19, 126);
            this.lblContractCompany.Name = "lblContractCompany";
            this.lblContractCompany.Size = new System.Drawing.Size(124, 13);
            this.lblContractCompany.TabIndex = 2;
            this.lblContractCompany.Text = "Sözleşme Yapılan Firma :";
            // 
            // lblCompanyAdress
            // 
            this.lblCompanyAdress.AutoSize = true;
            this.lblCompanyAdress.Location = new System.Drawing.Point(19, 159);
            this.lblCompanyAdress.Name = "lblCompanyAdress";
            this.lblCompanyAdress.Size = new System.Drawing.Size(68, 13);
            this.lblCompanyAdress.TabIndex = 3;
            this.lblCompanyAdress.Text = "Firma Adres :";
            // 
            // lblContractCompanyTel
            // 
            this.lblContractCompanyTel.AutoSize = true;
            this.lblContractCompanyTel.Location = new System.Drawing.Point(19, 192);
            this.lblContractCompanyTel.Name = "lblContractCompanyTel";
            this.lblContractCompanyTel.Size = new System.Drawing.Size(77, 13);
            this.lblContractCompanyTel.TabIndex = 4;
            this.lblContractCompanyTel.Text = "Firma Telefon :";
            // 
            // lblContractNotes
            // 
            this.lblContractNotes.AutoSize = true;
            this.lblContractNotes.Location = new System.Drawing.Point(19, 225);
            this.lblContractNotes.Name = "lblContractNotes";
            this.lblContractNotes.Size = new System.Drawing.Size(91, 13);
            this.lblContractNotes.TabIndex = 5;
            this.lblContractNotes.Text = "Sözleşme Notları :";
            // 
            // gbContact
            // 
            this.gbContact.Controls.Add(this.dgvContract);
            this.gbContact.Location = new System.Drawing.Point(120, 363);
            this.gbContact.Name = "gbContact";
            this.gbContact.Size = new System.Drawing.Size(914, 269);
            this.gbContact.TabIndex = 25;
            this.gbContact.TabStop = false;
            this.gbContact.Text = "Sözleşme Listesi";
            // 
            // dgvContract
            // 
            this.dgvContract.AllowUserToAddRows = false;
            this.dgvContract.AllowUserToDeleteRows = false;
            this.dgvContract.AllowUserToResizeColumns = false;
            this.dgvContract.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvContract.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContract.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContract.ContextMenuStrip = this.contextMenuStripContract;
            this.dgvContract.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContract.Location = new System.Drawing.Point(3, 16);
            this.dgvContract.MultiSelect = false;
            this.dgvContract.Name = "dgvContract";
            this.dgvContract.ReadOnly = true;
            this.dgvContract.RowHeadersVisible = false;
            this.dgvContract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContract.Size = new System.Drawing.Size(908, 250);
            this.dgvContract.TabIndex = 2;
            // 
            // gbContract
            // 
            this.gbContract.Controls.Add(this.dtpContractEndTime);
            this.gbContract.Controls.Add(this.lblContractEndTime);
            this.gbContract.Controls.Add(this.rtbContractNotes);
            this.gbContract.Controls.Add(this.txtCompanyTel);
            this.gbContract.Controls.Add(this.dtpContractStartTime);
            this.gbContract.Controls.Add(this.txtCompanyAdress);
            this.gbContract.Controls.Add(this.txtContractCompany);
            this.gbContract.Controls.Add(this.txtContractName);
            this.gbContract.Controls.Add(this.lblContractName);
            this.gbContract.Controls.Add(this.lblContractStartTime);
            this.gbContract.Controls.Add(this.lblContractNotes);
            this.gbContract.Controls.Add(this.lblContractCompany);
            this.gbContract.Controls.Add(this.lblContractCompanyTel);
            this.gbContract.Controls.Add(this.lblCompanyAdress);
            this.gbContract.Location = new System.Drawing.Point(31, 12);
            this.gbContract.Name = "gbContract";
            this.gbContract.Size = new System.Drawing.Size(366, 310);
            this.gbContract.TabIndex = 26;
            this.gbContract.TabStop = false;
            this.gbContract.Text = "Sözleşme Bilgileri";
            // 
            // rtbContractNotes
            // 
            this.rtbContractNotes.Location = new System.Drawing.Point(141, 215);
            this.rtbContractNotes.Name = "rtbContractNotes";
            this.rtbContractNotes.Size = new System.Drawing.Size(157, 71);
            this.rtbContractNotes.TabIndex = 15;
            this.rtbContractNotes.Text = "";
            // 
            // txtCompanyTel
            // 
            this.txtCompanyTel.Location = new System.Drawing.Point(141, 189);
            this.txtCompanyTel.Name = "txtCompanyTel";
            this.txtCompanyTel.Size = new System.Drawing.Size(187, 20);
            this.txtCompanyTel.TabIndex = 14;
            this.txtCompanyTel.Text = "Firma Telefon...";
            this.txtCompanyTel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCompanyTel_MouseClick);
            // 
            // dtpContractStartTime
            // 
            this.dtpContractStartTime.Location = new System.Drawing.Point(141, 60);
            this.dtpContractStartTime.Name = "dtpContractStartTime";
            this.dtpContractStartTime.Size = new System.Drawing.Size(200, 20);
            this.dtpContractStartTime.TabIndex = 13;
            // 
            // txtCompanyAdress
            // 
            this.txtCompanyAdress.Location = new System.Drawing.Point(141, 159);
            this.txtCompanyAdress.Name = "txtCompanyAdress";
            this.txtCompanyAdress.Size = new System.Drawing.Size(187, 20);
            this.txtCompanyAdress.TabIndex = 9;
            this.txtCompanyAdress.Text = "Firma Adresi...";
            this.txtCompanyAdress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCompanyAdress_MouseClick);
            // 
            // txtContractCompany
            // 
            this.txtContractCompany.Location = new System.Drawing.Point(141, 123);
            this.txtContractCompany.Name = "txtContractCompany";
            this.txtContractCompany.Size = new System.Drawing.Size(187, 20);
            this.txtContractCompany.TabIndex = 8;
            this.txtContractCompany.Text = "Firma Adı...";
            this.txtContractCompany.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtContractCompany_MouseClick);
            // 
            // txtContractName
            // 
            this.txtContractName.Location = new System.Drawing.Point(141, 27);
            this.txtContractName.Name = "txtContractName";
            this.txtContractName.Size = new System.Drawing.Size(187, 20);
            this.txtContractName.TabIndex = 7;
            this.txtContractName.Text = "Sözleşme Adı...";
            this.txtContractName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtContractName_MouseClick);
            // 
            // btnContractList
            // 
            this.btnContractList.Location = new System.Drawing.Point(31, 329);
            this.btnContractList.Name = "btnContractList";
            this.btnContractList.Size = new System.Drawing.Size(75, 23);
            this.btnContractList.TabIndex = 32;
            this.btnContractList.Text = "Listele";
            this.btnContractList.UseVisualStyleBackColor = true;
            this.btnContractList.Click += new System.EventHandler(this.btnContractList_Click);
            // 
            // btnContractUpdate
            // 
            this.btnContractUpdate.Location = new System.Drawing.Point(112, 329);
            this.btnContractUpdate.Name = "btnContractUpdate";
            this.btnContractUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnContractUpdate.TabIndex = 31;
            this.btnContractUpdate.Text = "Güncelle";
            this.btnContractUpdate.UseVisualStyleBackColor = true;
            this.btnContractUpdate.Visible = false;
            this.btnContractUpdate.Click += new System.EventHandler(this.btnContractUpdate_Click);
            // 
            // gbMaintanance
            // 
            this.gbMaintanance.Controls.Add(this.cbMonth);
            this.gbMaintanance.Controls.Add(this.cbContractSelect);
            this.gbMaintanance.Controls.Add(this.dtpFirstMaintenance);
            this.gbMaintanance.Controls.Add(this.lblMonth);
            this.gbMaintanance.Controls.Add(this.lblContractSelect);
            this.gbMaintanance.Controls.Add(this.lblFirstMaintenance);
            this.gbMaintanance.Location = new System.Drawing.Point(785, 42);
            this.gbMaintanance.Name = "gbMaintanance";
            this.gbMaintanance.Size = new System.Drawing.Size(366, 211);
            this.gbMaintanance.TabIndex = 27;
            this.gbMaintanance.TabStop = false;
            this.gbMaintanance.Text = "Sözleşme Bilgileri";
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(154, 46);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 21);
            this.cbMonth.TabIndex = 15;
            // 
            // cbContractSelect
            // 
            this.cbContractSelect.FormattingEnabled = true;
            this.cbContractSelect.Location = new System.Drawing.Point(154, 19);
            this.cbContractSelect.Name = "cbContractSelect";
            this.cbContractSelect.Size = new System.Drawing.Size(121, 21);
            this.cbContractSelect.TabIndex = 14;
            // 
            // dtpFirstMaintenance
            // 
            this.dtpFirstMaintenance.Location = new System.Drawing.Point(154, 75);
            this.dtpFirstMaintenance.Name = "dtpFirstMaintenance";
            this.dtpFirstMaintenance.Size = new System.Drawing.Size(200, 20);
            this.dtpFirstMaintenance.TabIndex = 14;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(17, 55);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(94, 13);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Bakım Aralığı (Ay) :";
            // 
            // lblContractSelect
            // 
            this.lblContractSelect.AutoSize = true;
            this.lblContractSelect.Location = new System.Drawing.Point(19, 30);
            this.lblContractSelect.Name = "lblContractSelect";
            this.lblContractSelect.Size = new System.Drawing.Size(95, 13);
            this.lblContractSelect.TabIndex = 0;
            this.lblContractSelect.Text = "Sözleşme Seçiniz :";
            // 
            // lblFirstMaintenance
            // 
            this.lblFirstMaintenance.AutoSize = true;
            this.lblFirstMaintenance.Location = new System.Drawing.Point(17, 81);
            this.lblFirstMaintenance.Name = "lblFirstMaintenance";
            this.lblFirstMaintenance.Size = new System.Drawing.Size(97, 13);
            this.lblFirstMaintenance.TabIndex = 1;
            this.lblFirstMaintenance.Text = "İlk Bakım  Zamanı :";
            // 
            // btnContractAdd
            // 
            this.btnContractAdd.Location = new System.Drawing.Point(331, 329);
            this.btnContractAdd.Name = "btnContractAdd";
            this.btnContractAdd.Size = new System.Drawing.Size(75, 23);
            this.btnContractAdd.TabIndex = 33;
            this.btnContractAdd.Text = "Ekle";
            this.btnContractAdd.UseVisualStyleBackColor = true;
            this.btnContractAdd.Click += new System.EventHandler(this.btnContractAdd_Click);
            // 
            // btnMaintananceAdd
            // 
            this.btnMaintananceAdd.Location = new System.Drawing.Point(1085, 275);
            this.btnMaintananceAdd.Name = "btnMaintananceAdd";
            this.btnMaintananceAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMaintananceAdd.TabIndex = 36;
            this.btnMaintananceAdd.Text = "Ekle";
            this.btnMaintananceAdd.UseVisualStyleBackColor = true;
            // 
            // btnMaintananceList
            // 
            this.btnMaintananceList.Location = new System.Drawing.Point(785, 275);
            this.btnMaintananceList.Name = "btnMaintananceList";
            this.btnMaintananceList.Size = new System.Drawing.Size(75, 23);
            this.btnMaintananceList.TabIndex = 35;
            this.btnMaintananceList.Text = "Listele";
            this.btnMaintananceList.UseVisualStyleBackColor = true;
            // 
            // btnMaintananceUpdate
            // 
            this.btnMaintananceUpdate.Location = new System.Drawing.Point(866, 275);
            this.btnMaintananceUpdate.Name = "btnMaintananceUpdate";
            this.btnMaintananceUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnMaintananceUpdate.TabIndex = 34;
            this.btnMaintananceUpdate.Text = "Güncelle";
            this.btnMaintananceUpdate.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Bilgilendirme Mail İşlemleri";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblContractEndTime
            // 
            this.lblContractEndTime.AutoSize = true;
            this.lblContractEndTime.Location = new System.Drawing.Point(19, 96);
            this.lblContractEndTime.Name = "lblContractEndTime";
            this.lblContractEndTime.Size = new System.Drawing.Size(73, 13);
            this.lblContractEndTime.TabIndex = 16;
            this.lblContractEndTime.Text = "Bitiş  Zamanı :";
            // 
            // dtpContractEndTime
            // 
            this.dtpContractEndTime.Location = new System.Drawing.Point(141, 90);
            this.dtpContractEndTime.Name = "dtpContractEndTime";
            this.dtpContractEndTime.Size = new System.Drawing.Size(200, 20);
            this.dtpContractEndTime.TabIndex = 17;
            // 
            // contextMenuStripContract
            // 
            this.contextMenuStripContract.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.contextMenuStripContract.Name = "contextMenuStripContract";
            this.contextMenuStripContract.Size = new System.Drawing.Size(121, 26);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Güncelle";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // MaintenanceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMaintananceAdd);
            this.Controls.Add(this.btnMaintananceList);
            this.Controls.Add(this.btnMaintananceUpdate);
            this.Controls.Add(this.btnContractAdd);
            this.Controls.Add(this.gbMaintanance);
            this.Controls.Add(this.btnContractList);
            this.Controls.Add(this.btnContractUpdate);
            this.Controls.Add(this.gbContract);
            this.Controls.Add(this.gbContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaintenanceForm";
            this.Text = "MaintenanceForm";
            this.gbContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            this.gbContract.ResumeLayout(false);
            this.gbContract.PerformLayout();
            this.gbMaintanance.ResumeLayout(false);
            this.gbMaintanance.PerformLayout();
            this.contextMenuStripContract.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblContractName;
        private System.Windows.Forms.Label lblContractStartTime;
        private System.Windows.Forms.Label lblContractCompany;
        private System.Windows.Forms.Label lblCompanyAdress;
        private System.Windows.Forms.Label lblContractCompanyTel;
        private System.Windows.Forms.Label lblContractNotes;
        private System.Windows.Forms.GroupBox gbContact;
        private System.Windows.Forms.DataGridView dgvContract;
        private System.Windows.Forms.GroupBox gbContract;
        private System.Windows.Forms.Button btnContractList;
        private System.Windows.Forms.Button btnContractUpdate;
        private System.Windows.Forms.GroupBox gbMaintanance;
        private System.Windows.Forms.Label lblContractSelect;
        private System.Windows.Forms.Label lblFirstMaintenance;
        private System.Windows.Forms.TextBox txtCompanyTel;
        private System.Windows.Forms.DateTimePicker dtpContractStartTime;
        private System.Windows.Forms.TextBox txtCompanyAdress;
        private System.Windows.Forms.TextBox txtContractCompany;
        private System.Windows.Forms.TextBox txtContractName;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbContractSelect;
        private System.Windows.Forms.DateTimePicker dtpFirstMaintenance;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnContractAdd;
        private System.Windows.Forms.Button btnMaintananceAdd;
        private System.Windows.Forms.Button btnMaintananceList;
        private System.Windows.Forms.Button btnMaintananceUpdate;
        private System.Windows.Forms.RichTextBox rtbContractNotes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpContractEndTime;
        private System.Windows.Forms.Label lblContractEndTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripContract;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}