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
using System.Runtime.InteropServices;

namespace ControlAppDesktop
{
    public partial class Login : Form
    {
        EmployeeManager employeeManager;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
   (
       int nLeftRect,
       int nTopRect,
       int nRightRect,
       int nBottomRect,
       int nWidthEllipse,
       int nHeightEllipse
   );
        public Login()
        {
            InitializeComponent();
            employeeManager = EmployeeManager.GetInstance();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int Iparam);
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
           
        }

        private void LnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordForgotForm passwordForgotForm = new PasswordForgotForm();
            passwordForgotForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlLoginTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void mtxtTC_MouseClick(object sender, MouseEventArgs e)
        {

            if (pnlTc.BackColor==Color.White)
            {
                pnlTc.BackColor=Color.FromArgb(39, 162, 214);
            }
            if (mtxtTC.ForeColor==Color.White)
            {
                mtxtTC.ForeColor=Color.FromArgb(39, 162, 214);
            }
            if (pnlPassword.BackColor==Color.FromArgb(39, 162, 214))
            {
                pnlPassword.BackColor=Color.White;

            }
            if (txtPassword.ForeColor==Color.FromArgb(39, 162, 214))
            {
                txtPassword.ForeColor=Color.White;
            }
            if (pbPassword.Image!=Properties.Resources.lock_16)
            {
                pbPassword.Image=Properties.Resources.lock_16;
            }
            mtxtTC.Clear();
            pbTc.Image=Properties.Resources.userblue;
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (pnlPassword.BackColor==Color.White)
            {
                pnlPassword.BackColor=Color.FromArgb(39, 162, 214);

            }
            if (txtPassword.ForeColor==Color.White)
            {
                txtPassword.ForeColor=Color.FromArgb(39, 162, 214);
            }
            if (pbPassword.Image!=Properties.Resources.lockblue)
            {
                pbPassword.Image=Properties.Resources.lockblue;
            }
            if (pbTc.Image!=Properties.Resources.user_16)
            {
                pbTc.Image=Properties.Resources.user_16;
            }
            if (mtxtTC.ForeColor!=Color.White)
            {
                mtxtTC.ForeColor=Color.White;
            }
            if (pnlTc.BackColor!=Color.White)
            {
                pnlTc.BackColor=Color.White;
            }
            txtPassword.Clear();
            
        }

        private void cbPassShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassShow.Checked)
            {
                txtPassword.PasswordChar='\0';
            }
            else
            {
                txtPassword.PasswordChar='*';
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }
    }
}
