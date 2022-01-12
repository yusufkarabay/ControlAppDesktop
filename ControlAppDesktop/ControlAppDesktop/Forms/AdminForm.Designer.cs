namespace ControlAppDesktop.Forms
{
    partial class AdminForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnDepartmentForm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yetki İşlemleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDepartmentForm
            // 
            this.btnDepartmentForm.Location = new System.Drawing.Point(89, 155);
            this.btnDepartmentForm.Name = "btnDepartmentForm";
            this.btnDepartmentForm.Size = new System.Drawing.Size(164, 23);
            this.btnDepartmentForm.TabIndex = 1;
            this.btnDepartmentForm.Text = "Departman İşlemleri";
            this.btnDepartmentForm.UseVisualStyleBackColor = true;
            this.btnDepartmentForm.Click += new System.EventHandler(this.btnDepartmentForm_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Personel Onaylama İşlemleri";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(89, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Personel Yetki Düzenleme İşlemleri";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDepartmentForm);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDepartmentForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}