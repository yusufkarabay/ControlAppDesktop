namespace ControlAppDesktop.Forms
{
    partial class HomePage
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
            this.pnlLeftMenu = new System.Windows.Forms.Panel();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.btnUserName = new System.Windows.Forms.Button();
            this.pbMessage = new System.Windows.Forms.PictureBox();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.btnGenarator = new System.Windows.Forms.Button();
            this.btnGuestCard = new System.Windows.Forms.Button();
            this.btnCabinet = new System.Windows.Forms.Button();
            this.btnDrawer = new System.Windows.Forms.Button();
            this.btnIdCard = new System.Windows.Forms.Button();
            this.btnHeadset = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnSentry = new System.Windows.Forms.Button();
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.pnlLeftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMessage)).BeginInit();
            this.pnlTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftMenu
            // 
            this.pnlLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.pnlLeftMenu.Controls.Add(this.pnlActive);
            this.pnlLeftMenu.Controls.Add(this.btnUserName);
            this.pnlLeftMenu.Controls.Add(this.pbMessage);
            this.pnlLeftMenu.Controls.Add(this.btnDirectory);
            this.pnlLeftMenu.Controls.Add(this.btnGenarator);
            this.pnlLeftMenu.Controls.Add(this.btnGuestCard);
            this.pnlLeftMenu.Controls.Add(this.btnCabinet);
            this.pnlLeftMenu.Controls.Add(this.btnDrawer);
            this.pnlLeftMenu.Controls.Add(this.btnIdCard);
            this.pnlLeftMenu.Controls.Add(this.btnHeadset);
            this.pnlLeftMenu.Controls.Add(this.btnMaintenance);
            this.pnlLeftMenu.Controls.Add(this.btnRequest);
            this.pnlLeftMenu.Controls.Add(this.btnEmployee);
            this.pnlLeftMenu.Controls.Add(this.btnInventory);
            this.pnlLeftMenu.Controls.Add(this.btnSentry);
            this.pnlLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftMenu.Name = "pnlLeftMenu";
            this.pnlLeftMenu.Size = new System.Drawing.Size(180, 768);
            this.pnlLeftMenu.TabIndex = 0;
            // 
            // pnlActive
            // 
            this.pnlActive.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlActive.Location = new System.Drawing.Point(0, 57);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(12, 48);
            this.pnlActive.TabIndex = 2;
            // 
            // btnUserName
            // 
            this.btnUserName.Location = new System.Drawing.Point(0, 733);
            this.btnUserName.Name = "btnUserName";
            this.btnUserName.Size = new System.Drawing.Size(180, 23);
            this.btnUserName.TabIndex = 3;
            this.btnUserName.Text = "Personel Adı";
            this.btnUserName.UseVisualStyleBackColor = true;
            // 
            // pbMessage
            // 
            this.pbMessage.Image = global::ControlAppDesktop.Properties.Resources.mail_send;
            this.pbMessage.Location = new System.Drawing.Point(12, 5);
            this.pbMessage.Name = "pbMessage";
            this.pbMessage.Size = new System.Drawing.Size(32, 32);
            this.pbMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMessage.TabIndex = 0;
            this.pbMessage.TabStop = false;
            this.pbMessage.Click += new System.EventHandler(this.pbMessage_Click);
            // 
            // btnDirectory
            // 
            this.btnDirectory.FlatAppearance.BorderSize = 0;
            this.btnDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDirectory.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDirectory.Image = global::ControlAppDesktop.Properties.Resources._001_phonebook;
            this.btnDirectory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirectory.Location = new System.Drawing.Point(12, 585);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(164, 48);
            this.btnDirectory.TabIndex = 2;
            this.btnDirectory.Text = "            Telefon Rehberi";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // btnGenarator
            // 
            this.btnGenarator.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnGenarator.FlatAppearance.BorderSize = 0;
            this.btnGenarator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenarator.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenarator.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGenarator.Image = global::ControlAppDesktop.Properties.Resources.electric_generator;
            this.btnGenarator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenarator.Location = new System.Drawing.Point(12, 535);
            this.btnGenarator.Name = "btnGenarator";
            this.btnGenarator.Size = new System.Drawing.Size(164, 48);
            this.btnGenarator.TabIndex = 2;
            this.btnGenarator.Text = "    Jeneratör";
            this.btnGenarator.UseVisualStyleBackColor = true;
            this.btnGenarator.Click += new System.EventHandler(this.btnGenarator_Click);
            // 
            // btnGuestCard
            // 
            this.btnGuestCard.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnGuestCard.FlatAppearance.BorderSize = 0;
            this.btnGuestCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestCard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuestCard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGuestCard.Image = global::ControlAppDesktop.Properties.Resources.id;
            this.btnGuestCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuestCard.Location = new System.Drawing.Point(12, 487);
            this.btnGuestCard.Name = "btnGuestCard";
            this.btnGuestCard.Size = new System.Drawing.Size(164, 48);
            this.btnGuestCard.TabIndex = 2;
            this.btnGuestCard.Text = "         Misafir Kart";
            this.btnGuestCard.UseVisualStyleBackColor = true;
            this.btnGuestCard.Click += new System.EventHandler(this.btnGuestCard_Click);
            // 
            // btnCabinet
            // 
            this.btnCabinet.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCabinet.FlatAppearance.BorderSize = 0;
            this.btnCabinet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCabinet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCabinet.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCabinet.Image = global::ControlAppDesktop.Properties.Resources.locker;
            this.btnCabinet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCabinet.Location = new System.Drawing.Point(12, 439);
            this.btnCabinet.Name = "btnCabinet";
            this.btnCabinet.Size = new System.Drawing.Size(164, 48);
            this.btnCabinet.TabIndex = 2;
            this.btnCabinet.Text = " Dolap";
            this.btnCabinet.UseVisualStyleBackColor = true;
            this.btnCabinet.Click += new System.EventHandler(this.btnCabinet_Click);
            // 
            // btnDrawer
            // 
            this.btnDrawer.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDrawer.FlatAppearance.BorderSize = 0;
            this.btnDrawer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDrawer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDrawer.Image = global::ControlAppDesktop.Properties.Resources.dresser;
            this.btnDrawer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrawer.Location = new System.Drawing.Point(12, 391);
            this.btnDrawer.Name = "btnDrawer";
            this.btnDrawer.Size = new System.Drawing.Size(164, 48);
            this.btnDrawer.TabIndex = 2;
            this.btnDrawer.Text = "      Çekmece";
            this.btnDrawer.UseVisualStyleBackColor = true;
            this.btnDrawer.Click += new System.EventHandler(this.btnDrawer_Click);
            // 
            // btnIdCard
            // 
            this.btnIdCard.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnIdCard.FlatAppearance.BorderSize = 0;
            this.btnIdCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdCard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIdCard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnIdCard.Image = global::ControlAppDesktop.Properties.Resources.name;
            this.btnIdCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIdCard.Location = new System.Drawing.Point(12, 343);
            this.btnIdCard.Name = "btnIdCard";
            this.btnIdCard.Size = new System.Drawing.Size(164, 48);
            this.btnIdCard.TabIndex = 2;
            this.btnIdCard.Text = "       Giriş Kartı";
            this.btnIdCard.UseVisualStyleBackColor = true;
            this.btnIdCard.Click += new System.EventHandler(this.btnIdCard_Click);
            // 
            // btnHeadset
            // 
            this.btnHeadset.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnHeadset.FlatAppearance.BorderSize = 0;
            this.btnHeadset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeadset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHeadset.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHeadset.Image = global::ControlAppDesktop.Properties.Resources.headphone;
            this.btnHeadset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeadset.Location = new System.Drawing.Point(12, 295);
            this.btnHeadset.Name = "btnHeadset";
            this.btnHeadset.Size = new System.Drawing.Size(164, 48);
            this.btnHeadset.TabIndex = 2;
            this.btnHeadset.Text = "      Kulaklık";
            this.btnHeadset.UseVisualStyleBackColor = true;
            this.btnHeadset.Click += new System.EventHandler(this.btnHeadset_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnMaintenance.FlatAppearance.BorderSize = 0;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaintenance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaintenance.Image = global::ControlAppDesktop.Properties.Resources.schedule;
            this.btnMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaintenance.Location = new System.Drawing.Point(12, 247);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(164, 48);
            this.btnMaintenance.TabIndex = 2;
            this.btnMaintenance.Text = "   Bakım";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnRequest.FlatAppearance.BorderSize = 0;
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRequest.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRequest.Image = global::ControlAppDesktop.Properties.Resources.clipboard;
            this.btnRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequest.Location = new System.Drawing.Point(12, 199);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(164, 48);
            this.btnRequest.TabIndex = 2;
            this.btnRequest.Text = " Talep";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmployee.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmployee.Image = global::ControlAppDesktop.Properties.Resources.employee;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(12, 151);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(164, 48);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "     Personel";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInventory.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInventory.Image = global::ControlAppDesktop.Properties.Resources.inventory;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(12, 103);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(164, 48);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "     Envanter";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnSentry
            // 
            this.btnSentry.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSentry.FlatAppearance.BorderSize = 0;
            this.btnSentry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSentry.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSentry.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSentry.Image = global::ControlAppDesktop.Properties.Resources.rotation;
            this.btnSentry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSentry.Location = new System.Drawing.Point(12, 55);
            this.btnSentry.Name = "btnSentry";
            this.btnSentry.Size = new System.Drawing.Size(164, 48);
            this.btnSentry.TabIndex = 2;
            this.btnSentry.Text = "Nöbet";
            this.btnSentry.UseVisualStyleBackColor = true;
            this.btnSentry.Click += new System.EventHandler(this.btnSentry_Click);
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.pnlTopMenu.Controls.Add(this.btnClose);
            this.pnlTopMenu.Controls.Add(this.lblTime);
            this.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMenu.Location = new System.Drawing.Point(180, 0);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(1186, 35);
            this.pnlTopMenu.TabIndex = 1;
            this.pnlTopMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopMenu_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(802, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTime.Location = new System.Drawing.Point(15, 5);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(65, 19);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Zaman";
            // 
            // pnlCenter
            // 
            this.pnlCenter.Location = new System.Drawing.Point(182, 38);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1184, 730);
            this.pnlCenter.TabIndex = 3;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlTopMenu);
            this.Controls.Add(this.pnlLeftMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "homePage";
            this.Load += new System.EventHandler(this.homePage_Load);
            this.pnlLeftMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMessage)).EndInit();
            this.pnlTopMenu.ResumeLayout(false);
            this.pnlTopMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftMenu;
        private System.Windows.Forms.PictureBox pbMessage;
        private System.Windows.Forms.Panel pnlTopMenu;
        private System.Windows.Forms.Button btnSentry;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnGenarator;
        private System.Windows.Forms.Button btnGuestCard;
        private System.Windows.Forms.Button btnCabinet;
        private System.Windows.Forms.Button btnDrawer;
        private System.Windows.Forms.Button btnIdCard;
        private System.Windows.Forms.Button btnHeadset;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnUserName;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.Panel pnlActive;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlCenter;
    }
}