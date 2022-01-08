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
    public partial class CabinetForm : Form
    {
        public object[] infos;
        CabinetManager cabinetManager;
        Cabinet cabinet;
        public CabinetForm()
        {
            InitializeComponent();
            cabinetManager = CabinetManager.GetInstance();
        }

        private void btnCabinetDelivery_Click(object sender, EventArgs e)
        {
            CabinetDeliveryForm cabinetDeliveryForm = new CabinetDeliveryForm();
            cabinetDeliveryForm.infos = infos;
            cabinetDeliveryForm.Show();
        }
        void allCabinetList()
        {
            dgvCabinet.DataSource = cabinetManager.GetAll();
            if (dgvCabinet.Rows.Count <= 0)
            {
                MessageBox.Show("Teslim Edilen Dolap Bulunmamaktadır");
                return;
            }
            dgvCabinet.Columns[0].Visible = false;
            dgvCabinet.Columns[2].Visible = false;
            dgvCabinet.Columns[3].Visible = false;
        }
        void fillInfos()
        {
            lblDeliveryPersonInfo.Text = cabinet.DeliveryPersonName.ToString();
            lblCabinetNoInfo.Text = cabinet.CabinetNo.ToString();
            lblReceiverPersonInfo.Text = cabinet.ReceiverPersonName.ToString();
        }
        void searcCabinetByDeliveryEmployee()
        {
            dgvCabinet.DataSource = cabinetManager.CabinetByDeliveryEmployee("CabinetByDeliveryEmployee", txtDrawerSearch.Text);
        }
        void searchCabinetByReceiverEmployee()
        {
            dgvCabinet.DataSource = cabinetManager.CabinetByReceiverEmployee("CabinetByReceiverEmployee", txtDrawerSearch.Text);
        }
        void searcCabinetByCabinetNo()
        {
            dgvCabinet.DataSource = cabinetManager.CabinetByCabinetNo("CabinetByCabinetNo", txtDrawerSearch.Text);
        }
        void cabinetReturnDelivery()
        {
            cabinet = new Cabinet(
                Guid.Parse(dgvCabinet.CurrentRow.Cells["CABINETID"].Value.ToString()),
                dgvCabinet.CurrentRow.Cells["CABINETNO"].Value.ToString(),
                dgvCabinet.CurrentRow.Cells["RECEIVEREMPLOYEE"].Value.ToString(),
                dgvCabinet.CurrentRow.Cells["RECEIVERPERSONNAME"].Value.ToString(),
                dgvCabinet.CurrentRow.Cells["DELIVERYEMPLOYEE"].Value.ToString(),
                 dgvCabinet.CurrentRow.Cells["DELIVERYPERSONNAME"].Value.ToString(),
                 DateTime.Parse(dgvCabinet.CurrentRow.Cells["DELIVERYDATE"].Value.ToString()));

            DialogResult dialogResult = MessageBox.Show("Seçili Dolabı Teslim Almak İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(cabinetManager.Delete(cabinet.CabinetId));

            }
        }

        private void btnDrawerSearch_Click(object sender, EventArgs e)
        {
            if (rbDeliveryEmployee.Checked == false & rbCabinetNo.Checked == false & rbReciverEmployee.Checked == false)
            {
                MessageBox.Show("Lütfen Bir Arama Kriteri Seçiniz");
                return;
            }
            else if (rbReciverEmployee.Checked == true)
            {
                searchCabinetByReceiverEmployee();
                if (dgvCabinet.Rows.Count < 1)
                {
                    MessageBox.Show("Girilen Personele Dolap Teslim Edilmemiştir...");
                    return;
                }

            }
            else if (rbDeliveryEmployee.Checked == true)
            {
                searcCabinetByDeliveryEmployee();
                if (dgvCabinet.Rows.Count < 1)
                {
                    MessageBox.Show("Girilen Personel Dolap Teslim Etmemiştir...");
                    return;
                }

            }
            else if (rbCabinetNo.Checked == true)
            {
                searcCabinetByCabinetNo();
                if (dgvCabinet.Rows.Count < 1)
                {
                    MessageBox.Show("Girilen No İle Çekmece Teslim Edilmemiştir...");
                    return;
                }

            }

            dgvCabinet.Columns[0].Visible = false;
            dgvCabinet.Columns[2].Visible = false;
            dgvCabinet.Columns[3].Visible = false;
        }

        private void btnCabinetList_Click(object sender, EventArgs e)
        {
            allCabinetList();
        }

        private void dgvCabinet_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCabinet.CurrentRow == null)
            {
                MessageBox.Show("Teslim Almak İçin Bir Dolap Seçiniz");
                return;
            }

            cabinet = new Cabinet(
                Guid.Parse(dgvCabinet.CurrentRow.Cells["CABINETID"].Value.ToString()),
                dgvCabinet.CurrentRow.Cells["CABINETNO"].Value.ToString(),
                dgvCabinet.CurrentRow.Cells["RECEIVEREMPLOYEE"].Value.ToString(),
                dgvCabinet.CurrentRow.Cells["RECEIVERPERSONNAME"].Value.ToString(),
                dgvCabinet.CurrentRow.Cells["DELIVERYEMPLOYEE"].Value.ToString(),
                 dgvCabinet.CurrentRow.Cells["DELIVERYPERSONNAME"].Value.ToString(),
                 DateTime.Parse(dgvCabinet.CurrentRow.Cells["DELIVERYDATE"].Value.ToString()));
            fillInfos();
        }

        private void teslimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cabinetReturnDelivery();
            lblCabinetNo.Text = "";
            lblDeliveryPersonInfo.Text = "";
            lblReceiverPersonInfo.Text = "";
            allCabinetList();
        }

        private void rbReciverEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtDrawerSearch.Text = "Personel Adı Giriniz...";
        }

        private void rbCabinetNo_CheckedChanged(object sender, EventArgs e)
        {
            txtDrawerSearch.Text = "Dolap No Giriniz...";
        }

        private void rbDeliveryEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtDrawerSearch.Text = "Personel Adı Giriniz...";
        }

        private void txtDrawerSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtDrawerSearch.Text = "";
        }
    }
}
