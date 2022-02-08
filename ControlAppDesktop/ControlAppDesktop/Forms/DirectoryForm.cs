using Business;
using Business.Concrete;
using DataAccess.Concrete;
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
    public partial class DirectoryForm : Form
    {
        public object[] infos;
        DirectoryManager directoryManager;
        Directory directory;
        public DirectoryForm()
        {
            InitializeComponent();
            directoryManager = DirectoryManager.GetInstance();
        }
        void allDirectoryList()
        {
            dgvDirectory.DataSource = directoryManager.GetAll();
            if (dgvDirectory.Rows.Count <= 0)
            {
                MessageBox.Show("Telefon Rehberinde Kayıt Bulunmamaktadır");
                return;
            }
            dgvDesign();


        }
        void dgvDesign()
        {
            dgvDirectory.Columns[0].Visible = false;
            dgvDirectory.Columns[1].HeaderText = "Kişi Bilgisi";
            dgvDirectory.Columns[2].HeaderText = "Telefon Numarası";
            dgvDirectory.Columns[3].HeaderText = "Detay";
        }
        void deleteDirectory()
        {
            directory = new Directory(
                Guid.Parse(dgvDirectory.CurrentRow.Cells["DIRECTORYID"].Value.ToString()),
                dgvDirectory.CurrentRow.Cells["DIRECTORYUSERNAME"].Value.ToString(),
                dgvDirectory.CurrentRow.Cells["DIRECTORYPHONE"].Value.ToString(),
                dgvDirectory.CurrentRow.Cells["INFO"].Value.ToString());

            DialogResult dialogResult = MessageBox.Show("Seçili Kaydı Silmek İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(directoryManager.Delete(directory.DirectoryId));

            }
        }
        void updateDirectory()
        {
            if (directory == null)
            {
                MessageBox.Show("Rehber Güncellenemedi");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Seçili Kayıt Değişikliğini Güncellemek İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                directory.DirectoryUserName = txtName.Text.ToString();
                directory.DirectoryPhone = txtPhone.Text.ToString();
                directory.Info = txtInfo.Text.ToString();

                MessageBox.Show(directoryManager.UpdateNew(directory));
            }


        }

        private void btnDirectoryAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Ad Alanı Boş Bırakılamaz");
                return;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Telefon Alanı Boş Bırakılamaz");
                return;
            }
            if (txtInfo.Text == "")
            {
                MessageBox.Show("Detay Alanı Boş Bırakılamaz");
                return;
            }

            directory = new Directory(

                txtName.Text.ToString(),
                txtPhone.Text.ToString(),
                txtInfo.Text.ToString());
            MessageBox.Show(directoryManager.Add(directory));
            allDirectoryList();

            txtInfo.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }

        private void DirectoryForm_Load(object sender, EventArgs e)
        {
            allDirectoryList();
            if (infos[4].ToString()!="Administrator")
            {
                contextMenuStrip1.Enabled=false;
            }

        }

        private void rbtName_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "Ad Giriniz...";
        }

        private void rbtPhone_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "Telefon Giriniz...";
        }

        private void rbtInfo_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "Bilgi Giriniz...";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbtInfo.Checked == false & rbtName.Checked == false & rbtPhone.Checked == false)
            {
                MessageBox.Show("Arama Kriteri Seçiniz Bırakılamaz");
                return;
            }
            else if (rbtName.Checked == true)
            {
                dgvDirectory.DataSource = directoryManager.DirectoryByUserName("DirectoryByUserName", txtSearch.Text);
                return;
            }
            else if (rbtPhone.Checked == true)
            {
                dgvDirectory.DataSource = directoryManager.DirectoryByUserPhone("DirectoryByUserPhone", txtSearch.Text);
                return;
            }
            else if (rbtInfo.Checked == true)
            {
                dgvDirectory.DataSource = directoryManager.DirectoryByInfo("DirectoryByInfo", txtSearch.Text); return;
            }
            dgvDesign();


        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            allDirectoryList();
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteDirectory();

            allDirectoryList();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDirectory.SelectedRows == null)
            {
                MessageBox.Show("Güncellenecek Kaydı Seçiniz");
                return;
            }
            directory = new Directory(
                Guid.Parse(dgvDirectory.CurrentRow.Cells["DIRECTORYID"].Value.ToString()),
                dgvDirectory.CurrentRow.Cells["DIRECTORYUSERNAME"].Value.ToString(),
                dgvDirectory.CurrentRow.Cells["DIRECTORYPHONE"].Value.ToString(),
                dgvDirectory.CurrentRow.Cells["INFO"].Value.ToString());

            DialogResult dialogResult = MessageBox.Show("Kaydı Güncellemek İstediğinize Emin Misiniz?",
                          "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                txtInfo.Text =directory.Info;
                txtName.Text=directory.DirectoryUserName;
                txtPhone.Text=directory.DirectoryPhone;
            }


            btnUpdate.Visible = true;

            if (btnDirectoryAdd.Visible==true)
            {
                btnDirectoryAdd.Visible=false;
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if(txtName.Text == "")
            {
                MessageBox.Show("Ad Alanı Boş Bırakılamaz");
                return;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Telefon Alanı Boş Bırakılamaz");
                return;
            }
            if (txtInfo.Text == "")
            {
                MessageBox.Show("Detay Alanı Boş Bırakılamaz");
                return;
            }
            updateDirectory();
            txtPhone.Text = "";
            txtName.Text = "";
            txtInfo.Text="";
            allDirectoryList();
            if (btnDirectoryAdd.Visible==false)
            {
                btnDirectoryAdd.Visible=true;
            }
            if (btnUpdate.Visible==true)
            {
                btnUpdate.Visible=false;
            }
        }
    }
}
