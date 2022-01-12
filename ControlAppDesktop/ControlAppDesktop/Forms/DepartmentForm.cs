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
    public partial class DepartmentForm : Form
    {
        public object[] infos;
        DepartmentManager departmentManager;
        Department department;
        public DepartmentForm()
        {
            InitializeComponent();
            departmentManager = DepartmentManager.GetInstance();
        }
        void allDepartmentList()
        {
            dgvDepartment.DataSource = departmentManager.GetAll();
            if (dgvDepartment.Rows.Count <= 0)
            {
                MessageBox.Show("Oluşturulan Departman Bulunmamaktadır");
                return;
            }
            dgvDepartment.Columns[0].Visible = false;

        }

        private void btnDepartmentList_Click(object sender, EventArgs e)
        {
            allDepartmentList();
        }

        private void btnCreateDepartment_Click(object sender, EventArgs e)
        {
            if (txtDepartmentName.Text == "" | txtDepartmentName.Text == "Departman Adı Giriniz...")
            {
                MessageBox.Show("Departman Adı Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            department = new Department(txtDepartmentName.Text.ToString());
            departmentManager.Add(department);
            MessageBox.Show("Departman Başarı İle Kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtDepartmentName.Text = "Departman Adı Giriniz...";
            allDepartmentList();
        }

        private void txtDepartmentName_MouseClick(object sender, MouseEventArgs e)
        {
            txtDepartmentName.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void fillInfos()
        {
            lblDepartmentNameInfo.Text = department.DepartmentName;
        }
        void updateDepartment()
        {
            if (department == null)
            {
                MessageBox.Show("Departman Güncellenemedi");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Seçili Departman Değişikliğini Güncellemek İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                department.DepartmentName = txtDepartmentName.Text.ToString();
                MessageBox.Show(departmentManager.UpdateNew(department));
            }
        }

        private void departmentNameUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDepartment.SelectedRows == null)
            {
                MessageBox.Show("Listeden Güncellenecek Departman seçiniz");
                return;
            }

            btnDepartmentUpdate.Visible = true;

            department = new Department(
                 Guid.Parse(dgvDepartment.CurrentRow.Cells["DepartmentId"].Value.ToString()),
                 dgvDepartment.CurrentRow.Cells["DepartmentName"].Value.ToString());

            DialogResult dialogResult = MessageBox.Show("Seçili Departman İçin Güncelleme Yapmak İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                txtDepartmentName.Text = department.DepartmentName;
            }

        }

        private void dgvDepartment_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvDepartment.CurrentRow == null)
            {

                MessageBox.Show("Listeden Departman Seçiniz");
                return;
            }
            department = new Department(
                dgvDepartment.CurrentRow.Cells["DepartmentName"].Value.ToString());
            fillInfos();
        }

        private void btnDepartmentUpdate_Click(object sender, EventArgs e)
        {
            if (txtDepartmentName.Text == null)
            {
                MessageBox.Show("Departman Alanı Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            updateDepartment();
            txtDepartmentName.Text = "Departman Adı Giriniz...";
            allDepartmentList();
            btnDepartmentUpdate.Visible = false;

        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
