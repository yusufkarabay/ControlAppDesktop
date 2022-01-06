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

        void allReceiverEntranceCard()
        {
            dgvEntranceCard.DataSource = entranceCardManager.GetAll();
            if (dgvEntranceCard.Rows.Count<=0)
            {
                MessageBox.Show("Teslim Edilen Giriş Kartı Bulunmamaktadır");
                return;
            }
            dgvEntranceCard.Columns[0].Visible = false;
            dgvEntranceCard.Columns[2].Visible = false;
            dgvEntranceCard.Columns[3].Visible = false;
        }
        void fillInfos()
        {
            lblDeliveryPersonInfo.Text = entranceCard.DeliveryPersonName.ToString();
            lblEntranceCardNoInfo.Text = entranceCard.EntranceCardSeriNo.ToString();
            lblReceiverPersonInfo.Text = entranceCard.ReceiverPersonName.ToString();
        }

        private void btnEntranceCardSearch_Click(object sender, EventArgs e)
        {

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
    }
}
