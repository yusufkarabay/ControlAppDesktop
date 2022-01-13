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
    public partial class MaintenanceForm : Form
    {
        public object[] infos;
        ContractManager contractManager;
        Contract contract;
        Maintenance maintenance;
        MaintenanceManager maintenanceManager;
        public MaintenanceForm()
        {
            InitializeComponent();
            contractManager = ContractManager.GetInstance();
        }
        void allContractList()
        {
            dgvContract.DataSource = contractManager.GetAll();
            if (dgvContract.Rows.Count < 1)
            {
                MessageBox.Show("Sözleşme Bulunmamaktadır");
                return;
            }
            dgvContract.Columns[0].Visible = false;
        }
        void updateContract()
        {
            if (contract == null)
            {
                MessageBox.Show("Sözleşme Güncellenemedi");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Seçili Sözleşme Değişikliğini Güncellemek İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                contract.ContractName = txtContractName.Text.ToString();
                contract.ContractStart = dtpContractStartTime.Value;
                contract.ContractEnd = dtpContractEndTime.Value;  
                contract.Company=txtContractCompany.Text.ToString();
                contract.CompanyAdress = txtCompanyAdress.Text.ToString();
                contract.CompanyTel = txtCompanyTel.Text.ToString();
                contract.Notes = rtbContractNotes.Text.ToString();
               
               

                MessageBox.Show(contractManager.UpdateNew(contract));
            }
        }
        void txtClear()
        {
            txtContractName.Text = "Sözleşme Adı...";
            txtContractCompany.Text = "Firma Adı...";
            txtCompanyTel.Text = "Firma Telefon...";
            txtCompanyAdress.Text = "Firma Adresi...";
        }
        private void btnContractAdd_Click(object sender, EventArgs e)
        {
            if (txtContractName.Text == "" | txtContractName.Text == "Sözleşme Adı...")
            {
                MessageBox.Show("Sözleşme Adı Boş Geçilemez");
                return;
            }
            else if (txtContractCompany.Text == "" | txtContractCompany.Text == "Firma Adı...")
            {
                MessageBox.Show("Sözleşme Firma Adı Boş Geçilemez");
                return;
            }
            contract = new Contract(
            txtContractName.Text.ToString(),
            DateTime.Parse(dtpContractStartTime.Value.ToString()),
            DateTime.Parse(dtpContractEndTime.Value.ToString()),
            txtContractCompany.Text.ToString(),
            txtCompanyAdress.Text.ToString(),
            txtCompanyTel.Text.ToString(),
            rtbContractNotes.Text.ToString());
            contractManager.Add(contract);
            MessageBox.Show("Sözleşme Başarı İle Kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtClear();
            allContractList();
        }
        private void btnContractList_Click(object sender, EventArgs e)
        {
            allContractList();
        }
        private void txtContractName_MouseClick(object sender, MouseEventArgs e)
        {
            txtContractName.Text = "";
        }
        private void txtContractCompany_MouseClick(object sender, MouseEventArgs e)
        {
            txtContractCompany.Text = "";
        }
        private void txtCompanyAdress_MouseClick(object sender, MouseEventArgs e)
        {
            txtCompanyAdress.Text = "";
        }
        private void txtCompanyTel_MouseClick(object sender, MouseEventArgs e)
        {
            txtCompanyTel.Text = "";
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvContract.SelectedRows == null)
            {
                MessageBox.Show("Güncellenecek Sözlşeme Seçiniz");
                return;
            }
            btnContractUpdate.Visible = true;
            contract = new Contract(
                Guid.Parse(dgvContract.CurrentRow.Cells["ContractId"].Value.ToString()),
                dgvContract.CurrentRow.Cells["ContractName"].Value.ToString(),
                DateTime.Parse(dgvContract.CurrentRow.Cells["ContractStart"].Value.ToString()),
                DateTime.Parse(dgvContract.CurrentRow.Cells["ContractEnd"].Value.ToString()),
                dgvContract.CurrentRow.Cells["Company"].Value.ToString(),
                dgvContract.CurrentRow.Cells["CompanyAdress"].Value.ToString(),
                dgvContract.CurrentRow.Cells["CompanyTel"].Value.ToString(),
                dgvContract.CurrentRow.Cells["Notes"].Value.ToString());

            DialogResult dialogResult = MessageBox.Show("Seçili Sözleşme İçin Güncelleme Yapmak İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                txtContractName.Text = contract.ContractName;
                txtCompanyTel.Text = contract.CompanyTel;
                rtbContractNotes.Text = contract.Notes;
                txtCompanyTel.Text = contract.CompanyTel;
                txtContractCompany.Text = contract.Company;
                txtCompanyAdress.Text = contract.CompanyAdress;
                dtpContractEndTime.Value = contract.ContractEnd;
                dtpContractStartTime.Value = contract.ContractStart;
            }

        }

        private void btnContractUpdate_Click(object sender, EventArgs e)
        {
            if (txtContractName.Text == "" | txtContractName.Text == "Sözleşme Adı...")
            {
                MessageBox.Show("Sözleşme Adı Boş Geçilemez", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else if (txtContractCompany.Text == "" | txtContractCompany.Text == "Firma Adı...")
            {
                MessageBox.Show("Sözleşme Firma Adı Boş Geçilemez", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            updateContract();
            txtClear();
            allContractList();
            btnContractUpdate.Visible = false;


        }
    }
}
