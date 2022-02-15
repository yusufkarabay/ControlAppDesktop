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
    public partial class GuestCardForm : Form
    {
        public object[] infos;
        GuestCardManager guestCardManager;
        GuestCard guestCard;
        public GuestCardForm()
        {
            InitializeComponent();
            guestCardManager = GuestCardManager.GetInstance();
        }

        private void btnGuestCardDelivery_Click(object sender, EventArgs e)
        {
            GuestCardDeliveryForm guestCardDeliveryForm=new GuestCardDeliveryForm();    
            guestCardDeliveryForm.infos=infos;
            guestCardDeliveryForm.Show();
        }
        void GridDisplay()
        {
            dgvGuestCard.Columns[0].Visible = false;
            dgvGuestCard.Columns[2].Visible = false;
            dgvGuestCard.Columns[3].Visible = false;
            dgvGuestCard.Columns["GuestCardNo"].HeaderText = "Misafir Kart No";
            dgvGuestCard.Columns["ReceiverPersonName"].HeaderText = "Teslim Alan Personel";
            dgvGuestCard.Columns["DeliveryPersonName"].HeaderText = "Teslim Eden Alan Personel";
            dgvGuestCard.Columns["DeliveryDate"].HeaderText = "Teslim Tarihi";

            

        }
        void allGuestCardList()
        {
            dgvGuestCard.DataSource = guestCardManager.GetAll();
            if (dgvGuestCard.Rows.Count <= 0)
            {
                MessageBox.Show("Teslim Edilen Misafir Kartı Bulunmamaktadır");
                return;
            }
            GridDisplay();
        }
        void fillInfos()
        {
            lblDeliveryPersonInfo.Text = guestCard.DeliveryPersonName.ToString();
            lblGuestCardNoInfo.Text = guestCard.GuestCardNo.ToString();
            lblReceiverPersonInfo.Text = guestCard.ReceiverPersonName.ToString();
        }
        void searcGuestCardByDeliveryEmployee()
        {
            dgvGuestCard.DataSource = guestCardManager.GuestCardByDeliveryEmployee("GuestCardByDeliveryEmployee", txtGuestCardearch.Text);
        }
        void searchGuestCardByReceiverEmployee()
        {
            dgvGuestCard.DataSource = guestCardManager.GuestCardByReceiverEmployee("GuestCardByReceiverEmployee", txtGuestCardearch.Text);
        }
        void searcGuestCardByCabinetNo()
        {
            dgvGuestCard.DataSource = guestCardManager.GuestCardByGuestCardNo("GuestCardByGuestCardNo", txtGuestCardearch.Text);
        }
        void guestCardReturnDelivery()
        {
            guestCard = new GuestCard(
                Guid.Parse(dgvGuestCard.CurrentRow.Cells["GUESTCARDID"].Value.ToString()),
                dgvGuestCard.CurrentRow.Cells["GUESTCARDNO"].Value.ToString(),
                dgvGuestCard.CurrentRow.Cells["RECEIVEREMPLOYEE"].Value.ToString(),
                dgvGuestCard.CurrentRow.Cells["RECEIVERPERSONNAME"].Value.ToString(),
                dgvGuestCard.CurrentRow.Cells["DELIVERYEMPLOYEE"].Value.ToString(),
                 dgvGuestCard.CurrentRow.Cells["DELIVERYPERSONNAME"].Value.ToString(),
                 DateTime.Parse(dgvGuestCard.CurrentRow.Cells["DELIVERYDATE"].Value.ToString()));

            DialogResult dialogResult = MessageBox.Show("Seçili Dolabı Teslim Almak İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(guestCardManager.Delete(guestCard.GuestCardId));

            }
        }

        private void btnGuestCardSearch_Click(object sender, EventArgs e)
        {
            if (rbDeliveryEmployee.Checked == false & rbGuestCardNo.Checked == false & rbReciverEmployee.Checked == false)
            {
                MessageBox.Show("Lütfen Bir Arama Kriteri Seçiniz");
                return;
            }
            else if (rbReciverEmployee.Checked == true)
            {
                searchGuestCardByReceiverEmployee();
                if (dgvGuestCard.Rows.Count < 1)
                {
                    MessageBox.Show("Girilen Personele Misafir Kart Teslim Edilmemiştir...");
                    return;
                }
                GridDisplay();

            }
            else if (rbDeliveryEmployee.Checked == true)
            {
                searcGuestCardByDeliveryEmployee();
                if (dgvGuestCard.Rows.Count < 1)
                {
                    MessageBox.Show("Girilen Personel Misafir Kart Teslim Etmemiştir...");
                    return;
                }

            }
            else if (rbGuestCardNo.Checked == true)
            {
                searcGuestCardByCabinetNo();
                if (dgvGuestCard.Rows.Count < 1)
                {
                    MessageBox.Show("Girilen No İle Misafir Kart Teslim Edilmemiştir...");
                    return;
                }

            }

            dgvGuestCard.Columns[0].Visible = false;
            dgvGuestCard.Columns[2].Visible = false;
            dgvGuestCard.Columns[3].Visible = false;
        }

        private void btnGuestCardList_Click(object sender, EventArgs e)
        {
            allGuestCardList();
        }

        private void dgvGuestCard_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvGuestCard.CurrentRow == null)
            {
                MessageBox.Show("Teslim Almak İçin Bir Misafir Kart Seçiniz");
                return;
            }

            guestCard = new GuestCard(
                Guid.Parse(dgvGuestCard.CurrentRow.Cells["GUESTCARDID"].Value.ToString()),
                dgvGuestCard.CurrentRow.Cells["GUESTCARDNO"].Value.ToString(),
                dgvGuestCard.CurrentRow.Cells["RECEIVEREMPLOYEE"].Value.ToString(),
                dgvGuestCard.CurrentRow.Cells["RECEIVERPERSONNAME"].Value.ToString(),
                dgvGuestCard.CurrentRow.Cells["DELIVERYEMPLOYEE"].Value.ToString(),
                 dgvGuestCard.CurrentRow.Cells["DELIVERYPERSONNAME"].Value.ToString(),
                 DateTime.Parse(dgvGuestCard.CurrentRow.Cells["DELIVERYDATE"].Value.ToString()));
            fillInfos();
        }

        private void teslimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guestCardReturnDelivery();
            lblGuestCardNoInfo.Text = "";
            lblDeliveryPersonInfo.Text = "";
            lblReceiverPersonInfo.Text = "";
            allGuestCardList();
        }

        private void rbReciverEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtGuestCardearch.Text = "Personel Adı Giriniz...";
        }

        private void rbDeliveryEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtGuestCardearch.Text = "Personel Adı Giriniz...";
        }

        private void rbGuestCardNo_CheckedChanged(object sender, EventArgs e)
        {
            txtGuestCardearch.Text = "Misafir Kart No Giriniz...";
        }

        private void txtGuestCardearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtGuestCardearch.Text = "";
        }

        private void grpInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
