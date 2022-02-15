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

        MaintenanceMonthManager maintenanceMonthManager;

        MaintenanceMonth maintenanceMonth;
        List<Contract> _contracts;
        List<MaintenanceMonth> _maintenanceMonths;
        public MaintenanceForm()
        {
            InitializeComponent();
            contractManager = ContractManager.GetInstance();
            maintenanceManager = MaintenanceManager.GetInstance();
            maintenanceMonthManager = MaintenanceMonthManager.GetInstance();
        }
        void contractGrid()
        {
            dgvContract.Columns[0].Visible = false;
            dgvContract.Columns["ContractName"].HeaderText ="Sözleşme Adı";
            dgvContract.Columns["ContractStart"].HeaderText ="Sözleşme Başlangıç Tarihi";
            dgvContract.Columns["Company"].HeaderText ="Firma";
            dgvContract.Columns["CompanyAdress"].HeaderText ="Firma Adresi";
            dgvContract.Columns["CompanyTel"].HeaderText ="Firma Telefonu";
            dgvContract.Columns["Notes"].HeaderText ="Notlar";
            dgvContract.Columns["ContractEnd"].HeaderText ="Sözleşme Bitiş Tarihi";

        }
        void maintenanceGrid()
        {
            dgvMaintenance.Columns[0].Visible = false;
            dgvMaintenance.Columns[1].Visible = false;
            dgvMaintenance.Columns["MaintenanceMonth"].HeaderText ="Bakım Aralığı";
            dgvMaintenance.Columns["FirstMaintenanceDate"].HeaderText ="İlk Bakım Tarihi";
            dgvMaintenance.Columns["ContractName"].HeaderText ="Kontrat Adı";

        }
        void allContractList()
        {
            dgvContract.DataSource = contractManager.GetAll();
            if (dgvContract.Rows.Count < 1)
            {
                MessageBox.Show("Sözleşme Bulunmamaktadır");
                return;
            }
            contractGrid();
        }
        void allMaintenanceList()
        {
            dgvMaintenance.DataSource = maintenanceManager.GetAll();
            if (dgvMaintenance.Rows.Count < 1)
            {
                MessageBox.Show("Bakım Bulunmamaktadır");
                return;
            }
            maintenanceGrid();


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
                contract.Company = txtContractCompany.Text.ToString();
                contract.CompanyAdress = txtCompanyAdress.Text.ToString();
                contract.CompanyTel = txtCompanyTel.Text.ToString();
                contract.Notes = rtbContractNotes.Text.ToString();



                MessageBox.Show(contractManager.UpdateNew(contract));
            }
        }
        void updateMaintenance()
        {
            if (maintenance == null)
            {
                MessageBox.Show("Bakım Güncellenemedi");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Seçili Bakım Değişikliğini Güncellemek İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                maintenance.MaintenanceMonth = int.Parse(cbMonth.SelectedValue.ToString());
                maintenance.FirstMaintenanceDate = dtpFirstMaintenance.Value;
                MessageBox.Show(maintenanceManager.UpdateNew(maintenance));
            }
        }
        void txtClear()
        {
            txtContractName.Text = "Sözleşme Adı...";
            txtContractCompany.Text = "Firma Adı...";
            txtCompanyTel.Text = "Firma Telefon...";
            txtCompanyAdress.Text = "Firma Adresi...";
        }
        void cbContractFill()
        {
            _contracts = contractManager.GetAll();
            cbContractSelect.DataSource = _contracts;
            cbContractSelect.ValueMember = "ContractId";
            cbContractSelect.DisplayMember = "ContractName";
            cbContractSelect.SelectedIndex = -1;
        }
        void cbMonthFill()
        {
            _maintenanceMonths = maintenanceMonthManager.GetAll();
            cbMonth.DataSource = _maintenanceMonths;
            cbMonth.ValueMember = "MainTenanceMonth";
            cbMonth.DisplayMember = "MainTenanceMonth";
            cbMonth.SelectedIndex = -1;

        }
        void deleteContract()
        {
            contract = new Contract(
               Guid.Parse(dgvContract.CurrentRow.Cells["CONTRACTID"].Value.ToString()),
                dgvContract.CurrentRow.Cells["CONTRACTNAME"].Value.ToString(),
                 DateTime.Parse(dgvContract.CurrentRow.Cells["CONTRACTSTART"].Value.ToString()),
                  DateTime.Parse(dgvContract.CurrentRow.Cells["CONTRACTEND"].Value.ToString()),
                dgvContract.CurrentRow.Cells["COMPANY"].Value.ToString(),
                dgvContract.CurrentRow.Cells["COMPANYADRESS"].Value.ToString(),
                dgvContract.CurrentRow.Cells["COMPANYTEL"].Value.ToString(),
                 dgvContract.CurrentRow.Cells["NOTES"].Value.ToString());

            DialogResult dialogResult = MessageBox.Show("Seçili Sözleşmeyi Silmek İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(contractManager.Delete(contract.ContractId));

            }
        }
        void deleteMaintenance()
        {
            maintenance = new Maintenance(
               Guid.Parse(dgvMaintenance.CurrentRow.Cells["MAINTENANCEID"].Value.ToString()),
               Guid.Parse(dgvMaintenance.CurrentRow.Cells["CONTRACTID"].Value.ToString()),
               dgvMaintenance.CurrentRow.Cells["CONTRACTNAME"].Value.ToString(),
               int.Parse(dgvMaintenance.CurrentRow.Cells["MAINTENANCEMONTH"].Value.ToString()),
                 DateTime.Parse(dgvMaintenance.CurrentRow.Cells["FIRSTMAINTENANCEDATE"].Value.ToString()));

            DialogResult dialogResult = MessageBox.Show("Seçili Bakımı Silmek İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(maintenanceManager.Delete(maintenance.MaintenanceId));

            }
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
            txtClear(); cbContractFill();
            allContractList();
        }
        private void btnContractList_Click(object sender, EventArgs e)
        {
            if (gbContract.Visible == false)
            {
                gbContract.Visible = true;
            }

            if (gbMaintanance.Visible == true)
            {
                gbMaintanance.Visible = false;
            }

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
        private void MaintenanceForm_Load(object sender, EventArgs e)
        {

            cbContractFill();
            cbMonthFill();
        }

        private void btnMaintananceAdd_Click(object sender, EventArgs e)
        {
            if (cbContractSelect.SelectedValue == null || cbMonth.SelectedValue == null)
            {
                MessageBox.Show("Sözleşme Seçimi Boş Bırakılamaz");
                return;
            }
            else if (cbMonth.SelectedValue == null)
            {
                MessageBox.Show("Bakım Aralığı Boş Bırakılamaz");
                return;
            }
            maintenance = new Maintenance(
                Guid.Parse(cbContractSelect.SelectedValue.ToString()),
                cbContractSelect.Text.ToString(),
                int.Parse(cbMonth.SelectedValue.ToString()),
                DateTime.Parse(dtpFirstMaintenance.Value.ToString()));
            maintenanceManager.Add(maintenance);
            MessageBox.Show("Bakım Hatırlatması Başarı İle Kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            allMaintenanceList();
        }

        private void btnMaintananceList_Click(object sender, EventArgs e)
        {
            if (gbContract.Visible == true)
            {
                gbContract.Visible = false;
            }

            if (gbMaintanance.Visible == false)
            {
                gbMaintanance.Visible = true;
            }

            allMaintenanceList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaintenanceMailAddForm maintenanceMailAddForm = new MaintenanceMailAddForm();
            maintenanceMailAddForm.infos = infos;
            maintenanceMailAddForm.Show();
        }

        private void btnMaintananceUpdate_Click(object sender, EventArgs e)
        {
            if (cbMonth.SelectedValue==null)
            {
                MessageBox.Show("Bakım Aralığı Seçiniz");
                return;
            }
            updateMaintenance();
            allMaintenanceList();
            cbContractSelect.SelectedIndex = -1;
            cbMonth.SelectedIndex = -1;
            cbContractSelect.Enabled = true;
            btnMaintananceUpdate.Visible = false;
        }

        private void updateMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMaintenance.SelectedRows == null)
            {
                MessageBox.Show("Güncellenecek Bakım Seçiniz");
                return;
            }
            btnMaintananceUpdate.Visible = true;
            maintenance = new Maintenance(
                Guid.Parse(dgvMaintenance.CurrentRow.Cells["MaintenanceId"].Value.ToString()),
                Guid.Parse(dgvMaintenance.CurrentRow.Cells["ContractId"].Value.ToString()),
                int.Parse(dgvMaintenance.CurrentRow.Cells["MaintenanceMonth"].Value.ToString()),
                DateTime.Parse(dgvMaintenance.CurrentRow.Cells["FirstMaintenanceDate"].Value.ToString()),
                dgvMaintenance.CurrentRow.Cells["ContractName"].Value.ToString());

            DialogResult dialogResult = MessageBox.Show("Seçili Bakım İçin Güncelleme Yapmak İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                cbContractSelect.Text = maintenance.ContractName.ToString();
                cbMonth.Text = maintenance.MaintenanceMonth.ToString();
                dtpFirstMaintenance.Value=maintenance.FirstMaintenanceDate;
                cbContractSelect.Enabled = false;
            }

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteContract();
            txtClear();
            allContractList();
        }

        private void deleteMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteMaintenance();
            allMaintenanceList();
        }
    }
}
