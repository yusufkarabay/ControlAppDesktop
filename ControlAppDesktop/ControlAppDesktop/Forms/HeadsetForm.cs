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
    public partial class HeadsetForm : Form
    {
        HeadsetManager headsetManager;
        Headset headset;



        public HeadsetForm()
        {
            InitializeComponent();
            headsetManager = HeadsetManager.GetInstance();
        }
        void FillInfos()
        {
            lblHeadsetSeriNoInfo.Text = headset.HeadsetSeriNo.ToString();
            lblReceiverPersonInfo.Text = headset.DeliveryPersonName;
            lblDeliveryPersonInfo.Text = headset.ReceiverPersonName;
            lblHeadsetStatusInfo.Text = headset.HeadsetStatusInfo;
        }
        void AllReceiverHeadset()
        {
            dgvHeadset.DataSource = headsetManager.GetAll();
            dgvHeadset.Columns[0].Visible = false;
            dgvHeadset.Columns[2].Visible = false;
            dgvHeadset.Columns[3].Visible = false;
        }
        void headsetReturnDelivery()
        {
                headset = new Headset(
               Guid.Parse(dgvHeadset.CurrentRow.Cells["HEADSETID"].Value.ToString()),
               dgvHeadset.CurrentRow.Cells["HEADSETSERINO"].Value.ToString(),
               dgvHeadset.CurrentRow.Cells["RECEIVERPERSON"].Value.ToString(),
               dgvHeadset.CurrentRow.Cells["DELIVERYPERSONNAME"].Value.ToString(),
               dgvHeadset.CurrentRow.Cells["DELIVERYPERSON"].Value.ToString(),
               dgvHeadset.CurrentRow.Cells["RECEIVERPERSONNAME"].Value.ToString(),
               dgvHeadset.CurrentRow.Cells["HEADSETSTATUSINFO"].Value.ToString(),
               DateTime.Parse(dgvHeadset.CurrentRow.Cells["DELIVERYDATE"].Value.ToString()));

            DialogResult dialogResult = MessageBox.Show("Seçili Kulaklığı Teslim Almak İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(headsetManager.Delete(headset.HeadsetId));

            }
        }

        private void HeadsetForm_Load(object sender, EventArgs e)
        {
           

        }

        private void dgvHeadset_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (dgvHeadset.CurrentRow == null)
            {
                MessageBox.Show("Teslim Almak İçin Bir Kulaklık Seçiniz");
                return;
            }
                headset = new Headset(
                Guid.Parse(dgvHeadset.CurrentRow.Cells["HEADSETID"].Value.ToString()),
                dgvHeadset.CurrentRow.Cells["HEADSETSERINO"].Value.ToString(),
                dgvHeadset.CurrentRow.Cells["RECEIVERPERSON"].Value.ToString(),
                dgvHeadset.CurrentRow.Cells["DELIVERYPERSONNAME"].Value.ToString(),
                dgvHeadset.CurrentRow.Cells["DELIVERYPERSON"].Value.ToString(),
                dgvHeadset.CurrentRow.Cells["RECEIVERPERSONNAME"].Value.ToString(),
                dgvHeadset.CurrentRow.Cells["HEADSETSTATUSINFO"].Value.ToString(),
                DateTime.Parse(dgvHeadset.CurrentRow.Cells["DELIVERYDATE"].Value.ToString()));

           

            FillInfos();
        }

        private void btnHeadsetList_Click(object sender, EventArgs e)
        {
            AllReceiverHeadset();
        }

        private void returnDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            headsetReturnDelivery();
            AllReceiverHeadset();
        }

        private void btnHeadsetDelivery_Click(object sender, EventArgs e)
        {
            HeadsetDeliveryForm headsetDeliveryForm = new HeadsetDeliveryForm();
            headsetDeliveryForm.Show();
        }
    }
}

