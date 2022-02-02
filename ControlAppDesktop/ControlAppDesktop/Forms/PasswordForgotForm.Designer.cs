namespace ControlAppDesktop.Forms
{
    partial class PasswordForgotForm
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
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtCheckCode = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCheckCode = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(193, 65);
            this.txtTC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(288, 22);
            this.txtTC.TabIndex = 0;
            this.txtTC.Text = "T.C. Kimlik No";
            // 
            // txtCheckCode
            // 
            this.txtCheckCode.Location = new System.Drawing.Point(193, 119);
            this.txtCheckCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCheckCode.Name = "txtCheckCode";
            this.txtCheckCode.Size = new System.Drawing.Size(288, 22);
            this.txtCheckCode.TabIndex = 1;
            this.txtCheckCode.Text = "Onay Kodu";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(193, 167);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(288, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Şifre";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(193, 214);
            this.txtRePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(288, 22);
            this.txtRePassword.TabIndex = 3;
            this.txtRePassword.Text = "Tekrar Şifre";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(249, 302);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCheckCode
            // 
            this.btnCheckCode.Location = new System.Drawing.Point(517, 750);
            this.btnCheckCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckCode.Name = "btnCheckCode";
            this.btnCheckCode.Size = new System.Drawing.Size(100, 28);
            this.btnCheckCode.TabIndex = 5;
            this.btnCheckCode.Text = "Onay Kodu Al";
            this.btnCheckCode.UseVisualStyleBackColor = true;
            this.btnCheckCode.Click += new System.EventHandler(this.btnCheckCode_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(37, 764);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 28);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "GeriDön";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // PasswordForgotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 871);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCheckCode);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCheckCode);
            this.Controls.Add(this.txtTC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PasswordForgotForm";
            this.Text = "PasswordForgotForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtCheckCode;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCheckCode;
        private System.Windows.Forms.Button btnReturn;
    }
}