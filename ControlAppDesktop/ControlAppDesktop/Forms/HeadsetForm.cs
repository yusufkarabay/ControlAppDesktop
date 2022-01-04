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
            lblHeadsetSeriNoInfo.Text = headset.HeadsetSeriNo;
            lblReceiverPersonInfo.Text = headset.ReceiverPerson;
            lblDeliveryPersonInfo.Text = headset.DeliveryPerson;
            lblHeadsetStatusInfo.Text = headset.HeadsetStatusInfo;
        }
        void AllReceiverHeadset()
        {
            dgvHeadset.DataSource = headsetManager.GetAll();
        }

        private void HeadsetForm_Load(object sender, EventArgs e)
        {
            AllReceiverHeadset();
             
        }

        private void dgvHeadset_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (dgvHeadset.CurrentRow == null)
            {
                MessageBox.Show("Teslim Almak İçin Bir Kulaklık Seçiniz");
                return;
            }
            //headset = new Headset(
            //    Guid.Parse(dgvHeadset.CurrentRow.Cells["HEADSETID"].Value.ToString()),
            //    dgvHeadset.CurrentRow.Cells["HEADSETSERINO"].Value.ToString(),
            //    dgvHeadset.CurrentRow.Cells["RECEIVERPERSON"].Value.ToString(),
            //    dgvHeadset.CurrentRow.Cells["DELIVERYPERSON"].Value.ToString(),
            //    dgvHeadset.CurrentRow.Cells["HEADSETSTATUSINFO"].Value.ToString(),
            //    DateTime.Parse(dgvHeadset.CurrentRow.Cells["DELIVERYDATE"].Value.ToString()));

            FillInfos();
        }
    }
}

