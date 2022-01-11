namespace ControlAppDesktop.Forms
{
    partial class GeneratorForm
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
            this.dtpFirst = new System.Windows.Forms.DateTimePicker();
            this.dtpSecond = new System.Windows.Forms.DateTimePicker();
            this.txtWorkedTime = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddWorkedTime = new System.Windows.Forms.Button();
            this.btnTimeSearch = new System.Windows.Forms.Button();
            this.lblWorkedTime = new System.Windows.Forms.Label();
            this.lblLastFullTime = new System.Windows.Forms.Label();
            this.lblLastFullTimeInfo = new System.Windows.Forms.Label();
            this.lblLastFullEmployee = new System.Windows.Forms.Label();
            this.lblAllWorkedTime = new System.Windows.Forms.Label();
            this.lblLastYear = new System.Windows.Forms.Label();
            this.lblLast3Month = new System.Windows.Forms.Label();
            this.lblLast6Month = new System.Windows.Forms.Label();
            this.lblLastWorked = new System.Windows.Forms.Label();
            this.lblListByTwoTime = new System.Windows.Forms.Label();
            this.lblFirstTime = new System.Windows.Forms.Label();
            this.lblSecondTime = new System.Windows.Forms.Label();
            this.lblListByTwoTimeInfo = new System.Windows.Forms.Label();
            this.lblAllWorkedTimeInfo = new System.Windows.Forms.Label();
            this.lblLastYearInfo = new System.Windows.Forms.Label();
            this.lblLast6MonthInfo = new System.Windows.Forms.Label();
            this.lblLast3MonthInfo = new System.Windows.Forms.Label();
            this.lblLastWorkedInfo = new System.Windows.Forms.Label();
            this.lblLastFullEmployeeInfo = new System.Windows.Forms.Label();
            this.btnFull = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFirst
            // 
            this.dtpFirst.Location = new System.Drawing.Point(255, 100);
            this.dtpFirst.Name = "dtpFirst";
            this.dtpFirst.Size = new System.Drawing.Size(200, 20);
            this.dtpFirst.TabIndex = 0;
            // 
            // dtpSecond
            // 
            this.dtpSecond.Location = new System.Drawing.Point(483, 100);
            this.dtpSecond.Name = "dtpSecond";
            this.dtpSecond.Size = new System.Drawing.Size(200, 20);
            this.dtpSecond.TabIndex = 1;
            // 
            // txtWorkedTime
            // 
            this.txtWorkedTime.Location = new System.Drawing.Point(353, 346);
            this.txtWorkedTime.Name = "txtWorkedTime";
            this.txtWorkedTime.Size = new System.Drawing.Size(59, 20);
            this.txtWorkedTime.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.editToolStripMenuItem.Text = "Düzenle";
            // 
            // btnAddWorkedTime
            // 
            this.btnAddWorkedTime.Location = new System.Drawing.Point(337, 380);
            this.btnAddWorkedTime.Name = "btnAddWorkedTime";
            this.btnAddWorkedTime.Size = new System.Drawing.Size(38, 23);
            this.btnAddWorkedTime.TabIndex = 19;
            this.btnAddWorkedTime.Text = "Ekle";
            this.btnAddWorkedTime.UseVisualStyleBackColor = true;
            this.btnAddWorkedTime.Click += new System.EventHandler(this.btnAddWorkedTime_Click);
            // 
            // btnTimeSearch
            // 
            this.btnTimeSearch.Location = new System.Drawing.Point(431, 145);
            this.btnTimeSearch.Name = "btnTimeSearch";
            this.btnTimeSearch.Size = new System.Drawing.Size(75, 23);
            this.btnTimeSearch.TabIndex = 20;
            this.btnTimeSearch.Text = "Listele";
            this.btnTimeSearch.UseVisualStyleBackColor = true;
            this.btnTimeSearch.Click += new System.EventHandler(this.btnTimeSearch_Click);
            // 
            // lblWorkedTime
            // 
            this.lblWorkedTime.AutoSize = true;
            this.lblWorkedTime.Location = new System.Drawing.Point(260, 349);
            this.lblWorkedTime.Name = "lblWorkedTime";
            this.lblWorkedTime.Size = new System.Drawing.Size(87, 13);
            this.lblWorkedTime.TabIndex = 21;
            this.lblWorkedTime.Text = "Çalışma Zamanı :";
            // 
            // lblLastFullTime
            // 
            this.lblLastFullTime.AutoSize = true;
            this.lblLastFullTime.Location = new System.Drawing.Point(459, 251);
            this.lblLastFullTime.Name = "lblLastFullTime";
            this.lblLastFullTime.Size = new System.Drawing.Size(123, 13);
            this.lblLastFullTime.TabIndex = 22;
            this.lblLastFullTime.Text = "Son Yakıt Alma Zamanı :";
            // 
            // lblLastFullTimeInfo
            // 
            this.lblLastFullTimeInfo.AutoSize = true;
            this.lblLastFullTimeInfo.Location = new System.Drawing.Point(613, 251);
            this.lblLastFullTimeInfo.Name = "lblLastFullTimeInfo";
            this.lblLastFullTimeInfo.Size = new System.Drawing.Size(49, 13);
            this.lblLastFullTimeInfo.TabIndex = 23;
            this.lblLastFullTimeInfo.Text = "00.00.00";
            // 
            // lblLastFullEmployee
            // 
            this.lblLastFullEmployee.AutoSize = true;
            this.lblLastFullEmployee.Location = new System.Drawing.Point(462, 290);
            this.lblLastFullEmployee.Name = "lblLastFullEmployee";
            this.lblLastFullEmployee.Size = new System.Drawing.Size(127, 13);
            this.lblLastFullEmployee.TabIndex = 24;
            this.lblLastFullEmployee.Text = "Son Yakıt Alan Personel :";
            // 
            // lblAllWorkedTime
            // 
            this.lblAllWorkedTime.AutoSize = true;
            this.lblAllWorkedTime.Location = new System.Drawing.Point(255, 197);
            this.lblAllWorkedTime.Name = "lblAllWorkedTime";
            this.lblAllWorkedTime.Size = new System.Drawing.Size(90, 13);
            this.lblAllWorkedTime.TabIndex = 25;
            this.lblAllWorkedTime.Text = "Toplam Kullanım :";
            // 
            // lblLastYear
            // 
            this.lblLastYear.AutoSize = true;
            this.lblLastYear.Location = new System.Drawing.Point(255, 218);
            this.lblLastYear.Name = "lblLastYear";
            this.lblLastYear.Size = new System.Drawing.Size(55, 13);
            this.lblLastYear.TabIndex = 26;
            this.lblLastYear.Text = "Son 1 Yıl :";
            // 
            // lblLast3Month
            // 
            this.lblLast3Month.AutoSize = true;
            this.lblLast3Month.Location = new System.Drawing.Point(255, 260);
            this.lblLast3Month.Name = "lblLast3Month";
            this.lblLast3Month.Size = new System.Drawing.Size(56, 13);
            this.lblLast3Month.TabIndex = 27;
            this.lblLast3Month.Text = "Son 3 Ay :";
            // 
            // lblLast6Month
            // 
            this.lblLast6Month.AutoSize = true;
            this.lblLast6Month.Location = new System.Drawing.Point(255, 239);
            this.lblLast6Month.Name = "lblLast6Month";
            this.lblLast6Month.Size = new System.Drawing.Size(53, 13);
            this.lblLast6Month.TabIndex = 28;
            this.lblLast6Month.Text = "Son 6 Ay:";
            // 
            // lblLastWorked
            // 
            this.lblLastWorked.AutoSize = true;
            this.lblLastWorked.Location = new System.Drawing.Point(255, 281);
            this.lblLastWorked.Name = "lblLastWorked";
            this.lblLastWorked.Size = new System.Drawing.Size(74, 13);
            this.lblLastWorked.TabIndex = 29;
            this.lblLastWorked.Text = "Son Kullanım :";
            // 
            // lblListByTwoTime
            // 
            this.lblListByTwoTime.AutoSize = true;
            this.lblListByTwoTime.Location = new System.Drawing.Point(556, 150);
            this.lblListByTwoTime.Name = "lblListByTwoTime";
            this.lblListByTwoTime.Size = new System.Drawing.Size(138, 13);
            this.lblListByTwoTime.TabIndex = 30;
            this.lblListByTwoTime.Text = "Sorgulama Aralığı Kullanımı :";
            // 
            // lblFirstTime
            // 
            this.lblFirstTime.AutoSize = true;
            this.lblFirstTime.Location = new System.Drawing.Point(255, 81);
            this.lblFirstTime.Name = "lblFirstTime";
            this.lblFirstTime.Size = new System.Drawing.Size(82, 13);
            this.lblFirstTime.TabIndex = 31;
            this.lblFirstTime.Text = "Başlangıç Tarihi";
            // 
            // lblSecondTime
            // 
            this.lblSecondTime.AutoSize = true;
            this.lblSecondTime.Location = new System.Drawing.Point(500, 81);
            this.lblSecondTime.Name = "lblSecondTime";
            this.lblSecondTime.Size = new System.Drawing.Size(55, 13);
            this.lblSecondTime.TabIndex = 32;
            this.lblSecondTime.Text = "Bitiş Tarihi";
            // 
            // lblListByTwoTimeInfo
            // 
            this.lblListByTwoTimeInfo.AutoSize = true;
            this.lblListByTwoTimeInfo.Location = new System.Drawing.Point(713, 150);
            this.lblListByTwoTimeInfo.Name = "lblListByTwoTimeInfo";
            this.lblListByTwoTimeInfo.Size = new System.Drawing.Size(19, 13);
            this.lblListByTwoTimeInfo.TabIndex = 36;
            this.lblListByTwoTimeInfo.Text = "00";
            // 
            // lblAllWorkedTimeInfo
            // 
            this.lblAllWorkedTimeInfo.AutoSize = true;
            this.lblAllWorkedTimeInfo.Location = new System.Drawing.Point(350, 197);
            this.lblAllWorkedTimeInfo.Name = "lblAllWorkedTimeInfo";
            this.lblAllWorkedTimeInfo.Size = new System.Drawing.Size(19, 13);
            this.lblAllWorkedTimeInfo.TabIndex = 37;
            this.lblAllWorkedTimeInfo.Text = "00";
            // 
            // lblLastYearInfo
            // 
            this.lblLastYearInfo.AutoSize = true;
            this.lblLastYearInfo.Location = new System.Drawing.Point(350, 218);
            this.lblLastYearInfo.Name = "lblLastYearInfo";
            this.lblLastYearInfo.Size = new System.Drawing.Size(19, 13);
            this.lblLastYearInfo.TabIndex = 38;
            this.lblLastYearInfo.Text = "00";
            // 
            // lblLast6MonthInfo
            // 
            this.lblLast6MonthInfo.AutoSize = true;
            this.lblLast6MonthInfo.Location = new System.Drawing.Point(350, 239);
            this.lblLast6MonthInfo.Name = "lblLast6MonthInfo";
            this.lblLast6MonthInfo.Size = new System.Drawing.Size(19, 13);
            this.lblLast6MonthInfo.TabIndex = 39;
            this.lblLast6MonthInfo.Text = "00";
            // 
            // lblLast3MonthInfo
            // 
            this.lblLast3MonthInfo.AutoSize = true;
            this.lblLast3MonthInfo.Location = new System.Drawing.Point(350, 260);
            this.lblLast3MonthInfo.Name = "lblLast3MonthInfo";
            this.lblLast3MonthInfo.Size = new System.Drawing.Size(19, 13);
            this.lblLast3MonthInfo.TabIndex = 40;
            this.lblLast3MonthInfo.Text = "00";
            // 
            // lblLastWorkedInfo
            // 
            this.lblLastWorkedInfo.AutoSize = true;
            this.lblLastWorkedInfo.Location = new System.Drawing.Point(350, 281);
            this.lblLastWorkedInfo.Name = "lblLastWorkedInfo";
            this.lblLastWorkedInfo.Size = new System.Drawing.Size(19, 13);
            this.lblLastWorkedInfo.TabIndex = 41;
            this.lblLastWorkedInfo.Text = "00";
            // 
            // lblLastFullEmployeeInfo
            // 
            this.lblLastFullEmployeeInfo.AutoSize = true;
            this.lblLastFullEmployeeInfo.Location = new System.Drawing.Point(616, 290);
            this.lblLastFullEmployeeInfo.Name = "lblLastFullEmployeeInfo";
            this.lblLastFullEmployeeInfo.Size = new System.Drawing.Size(53, 13);
            this.lblLastFullEmployeeInfo.TabIndex = 42;
            this.lblLastFullEmployeeInfo.Text = "Employee";
            // 
            // btnFull
            // 
            this.btnFull.Location = new System.Drawing.Point(443, 197);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(75, 23);
            this.btnFull.TabIndex = 43;
            this.btnFull.Text = "Yakıt Alındı";
            this.btnFull.UseVisualStyleBackColor = true;
            // 
            // GeneratorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.btnFull);
            this.Controls.Add(this.lblLastFullEmployeeInfo);
            this.Controls.Add(this.lblLastWorkedInfo);
            this.Controls.Add(this.lblLast3MonthInfo);
            this.Controls.Add(this.lblLast6MonthInfo);
            this.Controls.Add(this.lblLastYearInfo);
            this.Controls.Add(this.lblAllWorkedTimeInfo);
            this.Controls.Add(this.lblListByTwoTimeInfo);
            this.Controls.Add(this.lblSecondTime);
            this.Controls.Add(this.lblFirstTime);
            this.Controls.Add(this.lblListByTwoTime);
            this.Controls.Add(this.lblLastWorked);
            this.Controls.Add(this.lblLast6Month);
            this.Controls.Add(this.lblLast3Month);
            this.Controls.Add(this.lblLastYear);
            this.Controls.Add(this.lblAllWorkedTime);
            this.Controls.Add(this.lblLastFullEmployee);
            this.Controls.Add(this.lblLastFullTimeInfo);
            this.Controls.Add(this.lblLastFullTime);
            this.Controls.Add(this.lblWorkedTime);
            this.Controls.Add(this.btnTimeSearch);
            this.Controls.Add(this.btnAddWorkedTime);
            this.Controls.Add(this.txtWorkedTime);
            this.Controls.Add(this.dtpSecond);
            this.Controls.Add(this.dtpFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneratorForm";
            this.Text = "GeneratorForm";
            this.Load += new System.EventHandler(this.GeneratorForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFirst;
        private System.Windows.Forms.DateTimePicker dtpSecond;
        private System.Windows.Forms.TextBox txtWorkedTime;
        private System.Windows.Forms.Button btnAddWorkedTime;
        private System.Windows.Forms.Button btnTimeSearch;
        private System.Windows.Forms.Label lblWorkedTime;
        private System.Windows.Forms.Label lblLastFullTime;
        private System.Windows.Forms.Label lblLastFullTimeInfo;
        private System.Windows.Forms.Label lblLastFullEmployee;
        private System.Windows.Forms.Label lblAllWorkedTime;
        private System.Windows.Forms.Label lblLastYear;
        private System.Windows.Forms.Label lblLast3Month;
        private System.Windows.Forms.Label lblLast6Month;
        private System.Windows.Forms.Label lblLastWorked;
        private System.Windows.Forms.Label lblListByTwoTime;
        private System.Windows.Forms.Label lblFirstTime;
        private System.Windows.Forms.Label lblSecondTime;
        private System.Windows.Forms.Label lblListByTwoTimeInfo;
        private System.Windows.Forms.Label lblAllWorkedTimeInfo;
        private System.Windows.Forms.Label lblLastYearInfo;
        private System.Windows.Forms.Label lblLast6MonthInfo;
        private System.Windows.Forms.Label lblLast3MonthInfo;
        private System.Windows.Forms.Label lblLastWorkedInfo;
        private System.Windows.Forms.Label lblLastFullEmployeeInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button btnFull;
    }
}