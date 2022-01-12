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
    public partial class AuthorityForm : Form
    {
        public object[] infos;
        AuthorityManager authorityManager;
        Authority authority;
        public AuthorityForm()
        {
            InitializeComponent();
            authorityManager = AuthorityManager.GetInstance();
        }
        void allAuthorityList()
        {
            dgvAuthority.DataSource = authorityManager.GetAll();
            if (dgvAuthority.Rows.Count <= 0)
            {
                MessageBox.Show("Oluşturulan Yetki kBulunmamaktadır");
                return;
            }
            dgvAuthority.Columns[1].Visible = false;

        }
        void fillInfos()
        {
            lblAuthorityNameInfo.Text = authority.AuthorityName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AuthorityForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAuthorityList_Click(object sender, EventArgs e)
        {
            allAuthorityList();
        }
        void updateAuthority()
        {
            if (authority == null)
            {
                MessageBox.Show("Yetki Güncellenemedi");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Seçili Yetki Değişikliğini Güncellemek İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                authority.AuthorityName = txtAuthorityName.Text.ToString();
                MessageBox.Show(authorityManager.UpdateNew(authority));
            }
        }

        private void btnCreateAuthority_Click(object sender, EventArgs e)
        {
            if (txtAuthorityName.Text == "" | txtAuthorityName.Text == "Yetki Adı Giriniz...")
            {
                MessageBox.Show("Yetki Adı Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            authority = new Authority(txtAuthorityName.Text.ToString());
            authorityManager.Add(authority);
            MessageBox.Show("Yetki Başarı İle Kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtAuthorityName.Text = "Yetkis Adı Giriniz...";
            allAuthorityList();
        }

        private void txtAuthorityName_MouseClick(object sender, MouseEventArgs e)
        {
            txtAuthorityName.Text = "";
        }

        private void dgvAuthority_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvAuthority.CurrentRow == null)
            {

                MessageBox.Show("Listeden Departman Seçiniz");
                return;
            }
            authority = new Authority(
                dgvAuthority.CurrentRow.Cells["AuthorityName"].Value.ToString());
            fillInfos();
        }

        private void authorityNameUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAuthorityUpdate_Click(object sender, EventArgs e)
        {
            if (txtAuthorityName.Text == null)
            {
                MessageBox.Show("Yetki Alanı Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            updateAuthority();
            txtAuthorityName.Text = "Yetki Adı Giriniz...";
            allAuthorityList();
            btnAuthorityUpdate.Visible = false;
        }

        private void updateAuthorityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAuthority.SelectedRows == null)
            {
                MessageBox.Show("Listeden Güncellenecek Yetki seçiniz");
                return;
            }

            btnAuthorityUpdate.Visible = true;

            authority = new Authority(
                 Guid.Parse(dgvAuthority.CurrentRow.Cells["AuthorityId"].Value.ToString()),
                 dgvAuthority.CurrentRow.Cells["AuthorityName"].Value.ToString());

            DialogResult dialogResult = MessageBox.Show("Seçili Yetki İçin Güncelleme Yapmak İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                txtAuthorityName.Text = authority.AuthorityName;
            }

        }
    }
}
