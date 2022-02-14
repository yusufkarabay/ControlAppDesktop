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
        public object[] infos;


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
            if (dgvHeadset.Rows.Count>1)
            {
                
                dgvHeadset.Columns[0].Visible = false;
                dgvHeadset.Columns[2].Visible = false;
                dgvHeadset.Columns[3].Visible = false;
            }
          
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
        void searchHeadsetByDeliveryEmployee()
        {
            dgvHeadset.DataSource = headsetManager.HeadsetByDeliveryEmployee("HeadsetByDeliveryEmployee", txtHeadsetSearch.Text);
        }
        void searchHeadsetByHeadsetSeriNo()
        {
            dgvHeadset.DataSource = headsetManager.HeadsetBySeriNo("HeadsetBySeriNo", txtHeadsetSearch.Text);

        }
        void searchHeadsetByReceiverEmployee()
        {
            dgvHeadset.DataSource = headsetManager.HeadsetByReceiverEmployee("HeadsetByReceiverEmployee", txtHeadsetSearch.Text);
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
            headsetDeliveryForm.infos = infos;
            headsetDeliveryForm.Show();
        }
        private void rbReciverEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtHeadsetSearch.Text = "Personel Adı Giriniz...";
        }
        private void rbHeadsetSeriNo_CheckedChanged(object sender, EventArgs e)
        {
            txtHeadsetSearch.Text = "Kulaklık Seri No Giriniz...";
        }
        private void rbDeliveryEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtHeadsetSearch.Text = "Personel Adı Giriniz...";
        }
        private void btnHeadsetSearch_Click(object sender, EventArgs e)
        {
            if (rbDeliveryEmployee.Checked == false & rbHeadsetSeriNo.Checked == false & rbReciverEmployee.Checked == false)
            {
                MessageBox.Show("Lütfen Bir Arama Kriteri Seçiniz");
                return;
            }
            else if (rbDeliveryEmployee.Checked == true)
            {
                searchHeadsetByDeliveryEmployee();
                if (dgvHeadset.RowCount < 1)
                {

                    MessageBox.Show("Girilen Personel  Kulaklık Teslim Etmemiştir...");
                    return;
                }
            }

            else if (rbHeadsetSeriNo.Checked == true)
            {
                searchHeadsetByHeadsetSeriNo();
                if (dgvHeadset.RowCount < 1)
                {

                    MessageBox.Show("Girilen Seri No'ya Ait Kulaklık Bulunamadı...");
                    return;
                }
            }
            else if (rbReciverEmployee.Checked == true)
            {
                searchHeadsetByReceiverEmployee();
                if (dgvHeadset.RowCount < 1)
                {

                    MessageBox.Show("Perosnele Teslim Edilmiş Kulaklık Bulunamadı..");
                    return;
                }
            }

            dgvHeadset.Columns[0].Visible = false;
            dgvHeadset.Columns[2].Visible = false;
            dgvHeadset.Columns[3].Visible = false;
        }
        private void txtHeadsetSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtHeadsetSearch.Text = "";
        }
    }
}

