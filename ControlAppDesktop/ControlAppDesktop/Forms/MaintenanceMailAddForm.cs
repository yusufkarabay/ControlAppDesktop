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
    }
}
