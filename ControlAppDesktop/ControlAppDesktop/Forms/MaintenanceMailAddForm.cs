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
    public partial class MaintenanceMailAddForm : Form
    {
        public object[] infos;
        MaintenanceMailManager maintenanceMailManager;
        MaintenanceMail maintenanceMail;
        List<MaintenanceMail> _maintenanceMails;
        public MaintenanceMailAddForm()
        {
            InitializeComponent();
            maintenanceMailManager = MaintenanceMailManager.GetInstance();
        }
        void allMailList()
        {
            dgvMail.DataSource = maintenanceMailManager.GetAll();
            if (dgvMail.Rows.Count < 1)
            {
                MessageBox.Show("Mail Bulunmamaktadır");
                return;
            }
            dgvMail.Columns[0].Visible = false;
        }
        void updateMail()
        {
            if (maintenanceMail == null)
            {
                MessageBox.Show("Mail Adresi Bulunmamaktadır...");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Seçili Mail Değişikliğini Güncellemek İstediğinize Emin Misiniz?",
                           "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                maintenanceMail.MaintenanceEMail = txtMail.Text.ToString();
                maintenanceMail.MaintenanceEmployeeName = txtEmployee.Text.ToString();
                MessageBox.Show(maintenanceMailManager.UpdateNew(maintenanceMail));
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEmployee.Text == "")
            {
                MessageBox.Show("Mail Sahibi Boş Bırakılamaz");
                return;
            }
            else if (txtEmployee.Text == "")
            {
                MessageBox.Show("Mail Adresi Boş Bırakılamaz");
                return;
            }
            maintenanceMail = new MaintenanceMail(
                txtEmployee.Text.ToString(),
                txtMail.Text.ToString());
            maintenanceMailManager.Add(maintenanceMail);
            MessageBox.Show("Mail Başarı İle Kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            allMailList();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            allMailList();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMail.SelectedRows == null)
            {
                MessageBox.Show("Güncellenecek Mail Seçiniz");
                return;
            }
            btnUpdate.Visible = true;
            maintenanceMail = new MaintenanceMail(     
                Guid.Parse(dgvMail.CurrentRow.Cells["MaintenanceMailId"].Value.ToString()),
                dgvMail.CurrentRow.Cells["MaintenanceEMail"].Value.ToString(),
                dgvMail.CurrentRow.Cells["MaintenanceEmployeeName"].Value.ToString());

            DialogResult dialogResult = MessageBox.Show("Seçili Mail İçin Güncelleme Yapmak İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                txtEmployee.Text = maintenanceMail.MaintenanceEmployeeName;
                txtMail.Text = maintenanceMail.MaintenanceEMail;
               
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEmployee.Text == "" )
            {
                MessageBox.Show("Mail Sahibi Boş Geçilemez", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else if (txtMail.Text == "")
            {
                MessageBox.Show("Mail Adresi Boş Geçilemez", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            updateMail();
            allMailList();
            txtEmployee.Text = "";
            txtMail.Text = "";
            btnUpdate.Visible = false;
        }
        void deleteMail()
        {

            maintenanceMail = new MaintenanceMail(
               Guid.Parse(dgvMail.CurrentRow.Cells["MAINTENANCEMAILID"].Value.ToString()),
                dgvMail.CurrentRow.Cells["MAINTENANCEEMAIL"].Value.ToString(),
               dgvMail.CurrentRow.Cells["MAINTENANCEEMPLOYEENAME"].Value.ToString());

            DialogResult dialogResult = MessageBox.Show("Seçili Mail Adresini Silmek İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(maintenanceMailManager.Delete(maintenanceMail.MaintenanceMailId));

            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteMail();
            allMailList();
        }
    }
}
