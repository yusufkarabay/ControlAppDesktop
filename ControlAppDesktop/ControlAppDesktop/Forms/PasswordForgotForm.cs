using Business.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAppDesktop.Forms
{
    public partial class PasswordForgotForm : Form
    {
        Employee employee;
        EmployeeManager employeeManager;
        public PasswordForgotForm()
        {
            InitializeComponent();
            employeeManager= EmployeeManager.GetInstance();
        }

        private void btnCheckCode_Click(object sender, EventArgs e)
        {
            MailCheckedCodeForm form = new MailCheckedCodeForm();
            form.Show();
           this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Close();   
        }

       void PasswordUpdate()
        {
            employee= new Employee(
                txtTC.Text.ToString(),
                txtCheckCode.Text.ToString(),
                txtPassword.Text.ToString(),
                txtRePassword.Text.ToString());
            MessageBox.Show(employeeManager.PasswordUpdate(employee));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTC.Text == "")
            {
                MessageBox.Show("Kimlik Numarası Boş Geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtCheckCode.Text == "")
            {
                MessageBox.Show("Onay Kodu Boş Geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Şifre Boş Geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtRePassword.Text == "")
            {
                MessageBox.Show("Kontrol Şifresi Boş Geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtRePassword.Text!=txtPassword.Text)
            {
                MessageBox.Show("Şifreler Uyuşmamaktadır.");
                return;
            }
            Employee checkEmployee = new Employee();
            checkEmployee = employeeManager.CheckCodeAndTcCheck("CheckCodeAndTcCheck", txtCheckCode.Text.ToString(), txtTC.Text.ToString());
            if (checkEmployee == null)
            {
                MessageBox.Show("Personel ve Onay Kodu Uyuşmazlığı","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            PasswordUpdate();
        }
    }
}
