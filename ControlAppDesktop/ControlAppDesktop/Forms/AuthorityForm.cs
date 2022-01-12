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
    }
}
