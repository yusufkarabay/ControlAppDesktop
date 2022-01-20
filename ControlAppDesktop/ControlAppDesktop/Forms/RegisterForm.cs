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
    public partial class RegisterForm : Form
    {
        EmployeeManager employeeManager;
        Employee employee;

        public RegisterForm()
        {
            InitializeComponent();
            employeeManager=EmployeeManager.GetInstance();  
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
        void addEmployee()
        {
             employee = new Employee(
                mtxbTC.Text.ToString(),
                txtName.Text.ToString(),
                txtSurname.Text.ToString(),
                txtPassword.Text.ToString(),
                txtRepassword.Text.ToString(),                
                DateTime.Parse(mtxtBDate.Text.ToString()),
                rtxtAdress.Text.ToString(),
                mtxtTel.Text.ToString(),
                txtMail.Text.ToString());
                MessageBox.Show(employeeManager.Add(employee));
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (mtxbTC.Text=="")
            {
                MessageBox.Show("T.C. Kimlik Numarası Boş Bırakılamaz","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (mtxbTC.Text.Length != 11)
            {
                MessageBox.Show("T.C. Kimlik Numarasını Hatalı Girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else  if (txtName.Text == "")
            {
                MessageBox.Show("Ad Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtSurname.Text == "")
            {
                MessageBox.Show("Soyad Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Parola Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }          
            else if (txtRepassword.Text == "")
            {
                MessageBox.Show("Kontrol Parolası Boş Bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtPassword.Text.Length <1 & txtPassword.Text.Length>15 )
            {
                MessageBox.Show("Parola 15 Karakterden Fazla olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtRepassword.Text.Length < 1 & txtRepassword.Text.Length > 15)
            {
                MessageBox.Show("Parola 15 Karakterden Fazla olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtRepassword.Text != txtPassword.Text )
            {
                MessageBox.Show("Şifreler Uyuşmamaktadır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (mtxtBDate.Text.Length >10 )
            {
                MessageBox.Show("Doğum Tarihi Yanlış Girildi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           //else if (mtxtTel.Text.Length > 10)
           // {
           //     MessageBox.Show("Telefon Numarası Yanlış Girildi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
           //     return;
           // }
            else if (mtxtTel.Text.Length > 80)
            {
                MessageBox.Show("Mail Adresi 80 Karakterden Fazla Olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                addEmployee();
            }
            //this.Close();
        }

        private void mtxbTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mtxtBDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mtxtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
