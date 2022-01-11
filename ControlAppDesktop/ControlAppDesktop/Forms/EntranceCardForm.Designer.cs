namespace ControlAppDesktop.Forms
{
    partial class EntranceCardForm
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
            this.gbSearchInfo = new System.Windows.Forms.GroupBox();
            this.rbReciverEmployee = new System.Windows.Forms.RadioButton();
            this.rbEntranceCardSeriNo = new System.Windows.Forms.RadioButton();
            this.rbDeliveryEmployee = new System.Windows.Forms.RadioButton();
            this.txtEntranceCardSearch = new System.Windows.Forms.TextBox();
            this.btnEntranceCardSearch = new System.Windows.Forms.Button();
            this.btnEntranceCardList = new System.Windows.Forms.Button();
            this.btnEntranceCardDelivery = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblEntranceCardSeriNo = new System.Windows.Forms.Label();
            this.lblDeliveryPerson = new System.Windows.Forms.Label();
            this.lblReceiverPerson = new System.Windows.Forms.Label();
            this.lblDeliveryPersonInfo = new System.Windows.Forms.Label();
            this.lblReceiverPersonInfo = new System.Windows.Forms.Label();
            this.lblEntranceCardNoInfo = new System.Windows.Forms.Label();
            this.gbHeadset = new System.Windows.Forms.GroupBox();
            this.dgvEntranceCard = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.teslimAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSearchInfo.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.gbHeadset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntranceCard)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearchInfo
            // 
            this.gbSearchInfo.Controls.Add(this.rbReciverEmployee);
            this.gbSearchInfo.Controls.Add(this.rbEntranceCardSeriNo);
            this.gbSearchInfo.Controls.Add(this.rbDeliveryEmployee);
            this.gbSearchInfo.Location = new System.Drawing.Point(557, 74);
            this.gbSearchInfo.Name = "gbSearchInfo";
            this.gbSearchInfo.Size = new System.Drawing.Size(200, 127);
            this.gbSearchInfo.TabIndex = 16;
            this.gbSearchInfo.TabStop = false;
            this.gbSearchInfo.Text = "Arama Seçeneği";
            // 
            // rbReciverEmployee
            // 
            this.rbReciverEmployee.AutoSize = true;
            this.rbReciverEmployee.Location = new System.Drawing.Point(16, 27);
            this.rbReciverEmployee.Name = "rbReciverEmployee";
            this.rbReciverEmployee.Size = new System.Drawing.Size(140, 17);
            this.rbReciverEmployee.TabIndex = 9;
            this.rbReciverEmployee.TabStop = true;
            this.rbReciverEmployee.Text = "AlanPersonel\'e Göre Ara";
            this.rbReciverEmployee.UseVisualStyleBackColor = true;
            this.rbReciverEmployee.CheckedChanged += new System.EventHandler(this.rbReciverEmployee_CheckedChanged);
            // 
            // rbEntranceCardSeriNo
            // 
            this.rbEntranceCardSeriNo.AutoSize = true;
            this.rbEntranceCardSeriNo.Location = new System.Drawing.Point(16, 52);
            this.rbEntranceCardSeriNo.Name = "rbEntranceCardSeriNo";
            this.rbEntranceCardSeriNo.Size = new System.Drawing.Size(163, 17);
            this.rbEntranceCardSeriNo.TabIndex = 7;
            this.rbEntranceCardSeriNo.TabStop = true;
            this.rbEntranceCardSeriNo.Text = "Giriş Kart Seri No\'ya Göre Ara";
            this.rbEntranceCardSeriNo.UseVisualStyleBackColor = true;
            this.rbEntranceCardSeriNo.CheckedChanged += new System.EventHandler(this.rbEntranceCardSeriNo_CheckedChanged);
            // 
            // rbDeliveryEmployee
            // 
            this.rbDeliveryEmployee.AutoSize = true;
            this.rbDeliveryEmployee.Location = new System.Drawing.Point(16, 75);
            this.rbDeliveryEmployee.Name = "rbDeliveryEmployee";
            this.rbDeliveryEmployee.Size = new System.Drawing.Size(178, 17);
            this.rbDeliveryEmployee.TabIndex = 8;
            this.rbDeliveryEmployee.TabStop = true;
            this.rbDeliveryEmployee.Text = "Teslim Eden Personele Göre Ara";
            this.rbDeliveryEmployee.UseVisualStyleBackColor = true;
            this.rbDeliveryEmployee.CheckedChanged += new System.EventHandler(this.rbDeliveryEmployee_CheckedChanged);
            // 
            // txtEntranceCardSearch
            // 
            this.txtEntranceCardSearch.Location = new System.Drawing.Point(566, 213);
            this.txtEntranceCardSearch.Name = "txtEntranceCardSearch";
            this.txtEntranceCardSearch.Size = new System.Drawing.Size(165, 20);
            this.txtEntranceCardSearch.TabIndex = 15;
            this.txtEntranceCardSearch.Text = "Giriş Kartı Ara...";
            this.txtEntranceCardSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEntranceCardSearch_MouseClick);
            // 
            // btnEntranceCardSearch
            // 
            this.btnEntranceCardSearch.Location = new System.Drawing.Point(605, 239);
            this.btnEntranceCardSearch.Name = "btnEntranceCardSearch";
            this.btnEntranceCardSearch.Size = new System.Drawing.Size(75, 23);
            this.btnEntranceCardSearch.TabIndex = 14;
            this.btnEntranceCardSearch.Text = "Ara";
            this.btnEntranceCardSearch.UseVisualStyleBackColor = true;
            this.btnEntranceCardSearch.Click += new System.EventHandler(this.btnEntranceCardSearch_Click);
            // 
            // btnEntranceCardList
            // 
            this.btnEntranceCardList.Location = new System.Drawing.Point(849, 74);
            this.btnEntranceCardList.Name = "btnEntranceCardList";
            this.btnEntranceCardList.Size = new System.Drawing.Size(75, 23);
            this.btnEntranceCardList.TabIndex = 13;
            this.btnEntranceCardList.Text = "Listele";
            this.btnEntranceCardList.UseVisualStyleBackColor = true;
            this.btnEntranceCardList.Click += new System.EventHandler(this.btnEntranceCardList_Click);
            // 
            // btnEntranceCardDelivery
            // 
            this.btnEntranceCardDelivery.Location = new System.Drawing.Point(849, 115);
            this.btnEntranceCardDelivery.Name = "btnEntranceCardDelivery";
            this.btnEntranceCardDelivery.Size = new System.Drawing.Size(108, 23);
            this.btnEntranceCardDelivery.TabIndex = 12;
            this.btnEntranceCardDelivery.Text = "Giriş Kartı Teslim Et";
            this.btnEntranceCardDelivery.UseVisualStyleBackColor = true;
            this.btnEntranceCardDelivery.Click += new System.EventHandler(this.btnEntranceCardDelivery_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblEntranceCardSeriNo);
            this.grpInfo.Controls.Add(this.lblDeliveryPerson);
            this.grpInfo.Controls.Add(this.lblReceiverPerson);
            this.grpInfo.Controls.Add(this.lblDeliveryPersonInfo);
            this.grpInfo.Controls.Add(this.lblReceiverPersonInfo);
            this.grpInfo.Controls.Add(this.lblEntranceCardNoInfo);
            this.grpInfo.Location = new System.Drawing.Point(153, 74);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(349, 152);
            this.grpInfo.TabIndex = 11;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Giriş Kart Bilgileri";
            // 
            // lblEntranceCardSeriNo
            // 
            this.lblEntranceCardSeriNo.AutoSize = true;
            this.lblEntranceCardSeriNo.Location = new System.Drawing.Point(6, 25);
            this.lblEntranceCardSeriNo.Name = "lblEntranceCardSeriNo";
            this.lblEntranceCardSeriNo.Size = new System.Drawing.Size(92, 13);
            this.lblEntranceCardSeriNo.TabIndex = 10;
            this.lblEntranceCardSeriNo.Text = "Giriş Kartı Seri No:";
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
            // lblEntranceCardNoInfo
            // 
            this.lblEntranceCardNoInfo.AutoSize = true;
            this.lblEntranceCardNoInfo.Location = new System.Drawing.Point(100, 25);
            this.lblEntranceCardNoInfo.Name = "lblEntranceCardNoInfo";
            this.lblEntranceCardNoInfo.Size = new System.Drawing.Size(19, 13);
            this.lblEntranceCardNoInfo.TabIndex = 1;
            this.lblEntranceCardNoInfo.Text = "00";
            // 
            // gbHeadset
            // 
            this.gbHeadset.Controls.Add(this.dgvEntranceCard);
            this.gbHeadset.Location = new System.Drawing.Point(210, 366);
            this.gbHeadset.Name = "gbHeadset";
            this.gbHeadset.Size = new System.Drawing.Size(767, 255);
            this.gbHeadset.TabIndex = 10;
            this.gbHeadset.TabStop = false;
            this.gbHeadset.Text = "Teslim Edilmiş Giriş Kartları";
            // 
            // dgvEntranceCard
            // 
            this.dgvEntranceCard.AllowUserToAddRows = false;
            this.dgvEntranceCard.AllowUserToDeleteRows = false;
            this.dgvEntranceCard.AllowUserToResizeColumns = false;
            this.dgvEntranceCard.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvEntranceCard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntranceCard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntranceCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntranceCard.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvEntranceCard.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvEntranceCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEntranceCard.Location = new System.Drawing.Point(3, 16);
            this.dgvEntranceCard.MultiSelect = false;
            this.dgvEntranceCard.Name = "dgvEntranceCard";
            this.dgvEntranceCard.ReadOnly = true;
            this.dgvEntranceCard.RowHeadersVisible = false;
            this.dgvEntranceCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntranceCard.Size = new System.Drawing.Size(761, 236);
            this.dgvEntranceCard.TabIndex = 1;
            this.dgvEntranceCard.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEntranceCard_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teslimAlToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // teslimAlToolStripMenuItem
            // 
            this.teslimAlToolStripMenuItem.Name = "teslimAlToolStripMenuItem";
            this.teslimAlToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.teslimAlToolStripMenuItem.Text = "Teslim Al";
            this.teslimAlToolStripMenuItem.Click += new System.EventHandler(this.teslimAlToolStripMenuItem_Click);
            // 
            // EntranceCardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.gbSearchInfo);
            this.Controls.Add(this.txtEntranceCardSearch);
            this.Controls.Add(this.btnEntranceCardSearch);
            this.Controls.Add(this.btnEntranceCardList);
            this.Controls.Add(this.btnEntranceCardDelivery);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.gbHeadset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntranceCardForm";
            this.Text = "EntranceCardForm";
            this.gbSearchInfo.ResumeLayout(false);
            this.gbSearchInfo.PerformLayout();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.gbHeadset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntranceCard)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchInfo;
        private System.Windows.Forms.RadioButton rbReciverEmployee;
        private System.Windows.Forms.RadioButton rbEntranceCardSeriNo;
        private System.Windows.Forms.RadioButton rbDeliveryEmployee;
        private System.Windows.Forms.TextBox txtEntranceCardSearch;
        private System.Windows.Forms.Button btnEntranceCardSearch;
        private System.Windows.Forms.Button btnEntranceCardList;
        private System.Windows.Forms.Button btnEntranceCardDelivery;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblEntranceCardSeriNo;
        private System.Windows.Forms.Label lblDeliveryPerson;
        private System.Windows.Forms.Label lblReceiverPerson;
        private System.Windows.Forms.Label lblDeliveryPersonInfo;
        private System.Windows.Forms.Label lblReceiverPersonInfo;
        private System.Windows.Forms.Label lblEntranceCardNoInfo;
        private System.Windows.Forms.GroupBox gbHeadset;
        private System.Windows.Forms.DataGridView dgvEntranceCard;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teslimAlToolStripMenuItem;
    }
}