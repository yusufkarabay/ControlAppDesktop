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
using DataAccess.Concrete;
using System.IO;

namespace ControlAppDesktop.Forms
{
    public partial class PasswordNotesForm : Form
    {
        public object[] infos;
        PasswordNotesManager passwordNotesManager;
        PasswordNotes passwordNotes;
        public PasswordNotesForm()
        {
            InitializeComponent();
            passwordNotesManager =  PasswordNotesManager.GetInstance();
        }
        void GridDisplay()
        {
            if (dgvPassword.Rows.Count>0)
            {
                dgvPassword.Columns["PASSWORDID"].Visible=false;
                dgvPassword.Columns["PASSWORD"].HeaderText="Şifre";
                dgvPassword.Columns["PASSWORDTITLE"].HeaderText="Şifre Başlığı";
                dgvPassword.Columns["PASSWORDNOTE"].HeaderText="Şifre Notları";
                dgvPassword.Columns["CREATEDTIME"].HeaderText="Eklenme Zamanı";
                dgvPassword.Columns["CREATEDEMPLOYEE"].Visible=false;
                dgvPassword.Columns["EmployeeName"].HeaderText="Ekleyen Personel";
                dgvPassword.Columns["DepartmentId"].HeaderText ="Departman Id";
                dgvPassword.Columns["DepartmentId"].Visible =false;
            }
            


        }
        void allPasswordList()
        {
            dgvPassword.DataSource = passwordNotesManager.GetAllByDepartment("PasswordNotesList", Guid.Parse(infos[5].ToString()));


            GridDisplay();
        }
        void addPassword()
        {
            passwordNotes = new PasswordNotes(
              txtPasswordTitle.Text.ToString(),
              txtPassword.Text.ToString(),
              txtPasswordNotes.Text.ToString(),
              Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),
              infos[0].ToString(),
               Guid.Parse(infos[5].ToString()));

            passwordNotesManager.Add(passwordNotes);

            MessageBox.Show("Şifre Başarı İle Kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void updatePassword()
        {
            if (passwordNotes == null)
            {

                MessageBox.Show("Şifre Güncellenemedi");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Seçili Şifreyi Güncellemek İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                passwordNotes.PasswordTitle = txtPasswordTitle.Text;
                passwordNotes.CreatedTime = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
                passwordNotes.PasswordNote = txtPasswordNotes.Text;
                passwordNotes.Password = txtPassword.Text;                
                passwordNotes.CreatedEmployee = infos[0].ToString();
                passwordNotes.DepartmentId = Guid.Parse(infos[5].ToString());


                MessageBox.Show(passwordNotesManager.UpdateNew(passwordNotes));

            }
            else if (dialogResult==DialogResult.No)
            {
                return;
            }
        }
        void searchPasswordTitle()
        {
            dgvPassword.DataSource = passwordNotesManager.GetPasswordTitle("GetPasswordTitle", txtSearchTitle.Text, Guid.Parse(infos[5].ToString()));
            GridDisplay();
        }
        private void PasswordNotesForm_Load(object sender, EventArgs e)
        {
            allPasswordList();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPassword.SelectedRows == null)
            {
                MessageBox.Show("Listeden Güncellenecek Şifre seçiniz");
                return;
            }

            passwordNotes = new PasswordNotes(
                Guid.Parse(dgvPassword.CurrentRow.Cells["PasswordId"].Value.ToString()),
                dgvPassword.CurrentRow.Cells["PasswordTitle"].Value.ToString(),
               dgvPassword.CurrentRow.Cells["Password"].Value.ToString(),
               dgvPassword.CurrentRow.Cells["PasswordNote"].Value.ToString(),
                DateTime.Parse(dgvPassword.CurrentRow.Cells["CreatedTime"].Value.ToString()),
               dgvPassword.CurrentRow.Cells["CreatedEmployee"].Value.ToString());


            DialogResult dialogResult = MessageBox.Show("Seçili Şifreyi Güncelleme Yapmak İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                txtPassword.Text = passwordNotes.Password;
                txtPasswordNotes.Text = passwordNotes.PasswordNote;
                txtPasswordTitle.Text = passwordNotes.PasswordTitle;

            }
            if (btnUpdate.Visible == false)
            {
                btnUpdate.Visible = true;
            }
            if (btnAdd.Visible==true)
            {
                btnAdd.Visible=false;
            }
            

        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allPasswordList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtPasswordTitle.Text=="")
            {
                MessageBox.Show("Şifre Başlığı Boş Bırakılamaz");
                return;
            }
            else if (txtPassword.Text=="")
            {
                MessageBox.Show("Şifre Alanı Boş Bırakılamaz");
                return;
            }

            else
            {
                addPassword();
            }

            txtPassword.Text = "";
            txtPasswordNotes.Text = "";
            txtPasswordTitle.Text = "";

            allPasswordList();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtPasswordTitle.Text=="")
            {
                MessageBox.Show("Şifre Başlığı Boş Bırakılamaz");
                return;
            }
            else if (txtPassword.Text=="")
            {
                MessageBox.Show("Şifre Alanı Boş Bırakılamaz");
                return;
            }

            else
            {
                updatePassword();
            }

            txtPassword.Text = "";
            txtPasswordNotes.Text = "";
            txtPasswordTitle.Text = "";
            if (btnUpdate.Visible == true)
            {
                btnUpdate.Visible = false;
            }
            if (btnAdd.Visible==false)
            {
                btnAdd.Visible=true;
            }

            allPasswordList();
        }

        private void txtSearchTitle_TextChanged(object sender, EventArgs e)
        {
            searchPasswordTitle();
            if (dgvPassword.RowCount < 1)
            {
                MessageBox.Show("Aranan Şifre Başlığı Bulunamadı");
                return;
            }
        }

        private void txtSearchTitle_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearchTitle.Text="";
        }
    }
}
