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
    public partial class EntranceCardForm : Form
    {
        public object[] infos;
        EntranceCardManager entranceCardManager;
        EntranceCard entranceCard;
        public EntranceCardForm()
        {
            InitializeComponent();
            entranceCardManager = EntranceCardManager.GetInstance();
        }
        void GridDisplay()
        {
            dgvEntranceCard.Columns[0].Visible = false;
            dgvEntranceCard.Columns[2].Visible = false;
            dgvEntranceCard.Columns[3].Visible = false;
            dgvEntranceCard.Columns["EntranceCardSeriNo"].HeaderText = "Misafir Kart No";
            dgvEntranceCard.Columns["ReceiverPersonName"].HeaderText = "Teslim Alan Personel";
            dgvEntranceCard.Columns["DeliveryPersonName"].HeaderText = "Teslim Eden Alan Personel";
            dgvEntranceCard.Columns["DeliveryDate"].HeaderText = "Teslim Tarihi";



        }
        void allReceiverEntranceCard()
        {
            dgvEntranceCard.DataSource = entranceCardManager.GetAll();
            if (dgvEntranceCard.Rows.Count <= 0)
            {
                MessageBox.Show("Teslim Edilen Giriş Kartı Bulunmamaktadır");
                return;
            }
           GridDisplay();
        }
        void fillInfos()
        {
            lblDeliveryPersonInfo.Text = entranceCard.DeliveryPersonName.ToString();
            lblEntranceCardNoInfo.Text = entranceCard.EntranceCardSeriNo.ToString();
            lblReceiverPersonInfo.Text = entranceCard.ReceiverPersonName.ToString();
        }
        void searchEntranceCardByDeliveryEmployee()
        {
            dgvEntranceCard.DataSource = entranceCardManager.EntranceCardByDeliveryEmployee("EntranceByDeliveryEmployee", txtEntranceCardSearch.Text);
        }
        void searchEntranceCardBySeriNo()
        {
            dgvEntranceCard.DataSource = entranceCardManager.EntranceCardBySeriNo("EntranceCardBySeriNo", txtEntranceCardSearch.Text);
        }
        void searchEntranceCardByReceiverEmployee()
        {
            dgvEntranceCard.DataSource = entranceCardManager.EntranceCardByReceiverEmployee("EntranceByReceiverEmployee", txtEntranceCardSearch.Text);
        }
        void entranceCardReturnDelivery()
        {
            entranceCard = new EntranceCard(
                Guid.Parse(dgvEntranceCard.CurrentRow.Cells["ENTRANCECARDID"].Value.ToString()),
                dgvEntranceCard.CurrentRow.Cells["ENTRANCECARDSERINO"].Value.ToString(),
                dgvEntranceCard.CurrentRow.Cells["RECEIVEREMPLOYEE"].Value.ToString(),
                dgvEntranceCard.CurrentRow.Cells["RECEIVERPERSONNAME"].Value.ToString(),
                dgvEntranceCard.CurrentRow.Cells["DELIVERYEMPLOYEE"].Value.ToString(),
                 dgvEntranceCard.CurrentRow.Cells["DELIVERYPERSONNAME"].Value.ToString(),
                 DateTime.Parse(dgvEntranceCard.CurrentRow.Cells["DELIVERYDATE"].Value.ToString()));

            DialogResult dialogResult = MessageBox.Show("Seçili Kartı Teslim Almak İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(entranceCardManager.Delete(entranceCard.EntranceCardId));

            }
        }
        private void btnEntranceCardSearch_Click(object sender, EventArgs e)
        {
                if (rbDeliveryEmployee.Checked == false & rbEntranceCardSeriNo.Checked == false & rbReciverEmployee.Checked == false)
            {
                MessageBox.Show("Lütfen Bir Arama Kriteri Seçiniz");
                return;
            }
            else if (rbDeliveryEmployee.Checked == true)
            {
                searchEntranceCardByDeliveryEmployee();
                if (dgvEntranceCard.RowCount < 1)
                {
                    MessageBox.Show("Girilen Personel Kart Teslim Etmemiştir...");
                    return;
                }
            }
            else if (rbEntranceCardSeriNo.Checked == true)
            {
                searchEntranceCardBySeriNo();
                if (dgvEntranceCard.RowCount < 1)
                {
                    MessageBox.Show("Girilen Seri No'ya Ait Kart Bulunamadı...");
                    return;
                }
            }
            else if (rbReciverEmployee.Checked == true)
            {
                searchEntranceCardByReceiverEmployee();
                if (dgvEntranceCard.RowCount < 1)
                {
                    MessageBox.Show("Personele Kart Teslim Edilmemiştir...");
                    return;
                }
            }
            GridDisplay();

        }
        private void btnEntranceCardList_Click(object sender, EventArgs e)
        {
            allReceiverEntranceCard();
        }
        private void dgvEntranceCard_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvEntranceCard.CurrentRow == null)
            {
                MessageBox.Show("Teslim Almak İçin Bir Kart Seçiniz");
                return;
            }

            entranceCard = new EntranceCard(
                Guid.Parse(dgvEntranceCard.CurrentRow.Cells["ENTRANCECARDID"].Value.ToString()),
                dgvEntranceCard.CurrentRow.Cells["ENTRANCECARDSERINO"].Value.ToString(),
                dgvEntranceCard.CurrentRow.Cells["RECEIVEREMPLOYEE"].Value.ToString(),
                dgvEntranceCard.CurrentRow.Cells["RECEIVERPERSONNAME"].Value.ToString(),
                dgvEntranceCard.CurrentRow.Cells["DELIVERYEMPLOYEE"].Value.ToString(),
                 dgvEntranceCard.CurrentRow.Cells["DELIVERYPERSONNAME"].Value.ToString(),
                 DateTime.Parse(dgvEntranceCard.CurrentRow.Cells["DELIVERYDATE"].Value.ToString()));
            fillInfos();
        }
        private void btnEntranceCardDelivery_Click(object sender, EventArgs e)
        {
            EntranceCardDeliveryForm entranceCardDeliveryForm = new EntranceCardDeliveryForm();
            entranceCardDeliveryForm.infos = infos;
            entranceCardDeliveryForm.Show();
        }
        private void teslimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entranceCardReturnDelivery();
            lblDeliveryPersonInfo.Text = "";
            lblEntranceCardNoInfo.Text = "";
            lblReceiverPersonInfo.Text = "";
            allReceiverEntranceCard();
        }
        private void txtEntranceCardSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtEntranceCardSearch.Text = "";
        }
        private void rbReciverEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtEntranceCardSearch.Text = "Personel Adı Giriniz..";
        }
        private void rbDeliveryEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtEntranceCardSearch.Text = "Personel Adı Giriniz..";
        }
        private void rbEntranceCardSeriNo_CheckedChanged(object sender, EventArgs e)
        {
            txtEntranceCardSearch.Text = "Giriş Kartı Seri No Giriniz..";
        }
    }
}
