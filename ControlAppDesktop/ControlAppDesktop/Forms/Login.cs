using Business.Concrete;
using ControlAppDesktop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Concrete;
using Entities;

namespace ControlAppDesktop
{
    public partial class Login : Form
    {
        EmployeeManager employeeManager;
        public Login()
        {
            InitializeComponent();
            employeeManager = EmployeeManager.GetInstance();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("f");



        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (mtxtTC.Text.Trim() == "")
            {
                MessageBox.Show("TC Kimlik Numarası Boş Geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Şifre Boş Geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            object[] infos = employeeManager.Login(mtxtTC.Text, txtPassword.Text);


            if (infos == null)
            {
                MessageBox.Show("Hatalı TC Kimlik Numarası veya Şifre Girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                UserRealName.RealName = infos[1] + " " + infos[2].ToString();

                HomePage homePage = new HomePage();
                homePage.infos = infos;
                homePage.Show();

                this.Hide();

            }




            MessageBox.Show("Sayın " + infos[1] + " " + infos[2] + " Hoşgeldiniz");



        }

        private void LnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void LnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordForgotForm passwordForgotForm= new PasswordForgotForm();
            passwordForgotForm.Show();
            this.Hide();
        }
    }
}
