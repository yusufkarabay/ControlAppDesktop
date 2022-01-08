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
    public partial class DrawerForm : Form
    {
        public object[] infos;
        DrawerManager drawerManager;
        Drawer drawer;
        public DrawerForm()
        {
            InitializeComponent();
            drawerManager = DrawerManager.GetInstance();
        }

        void allDrawerList()
        {
            dgvDrawer.DataSource = drawerManager.GetAll();
            if (dgvDrawer.Rows.Count <= 0)
            {
                MessageBox.Show("Teslim Edilen Çekmece Bulunmamaktadır");
                return;
            }
            dgvDrawer.Columns[0].Visible = false;
            dgvDrawer.Columns[2].Visible = false;
            dgvDrawer.Columns[3].Visible = false;
        }
        void fillInfos()
        {
            lblDeliveryPersonInfo.Text = drawer.DeliveryPersonName.ToString();
            lblDrawerNoInfo.Text = drawer.DrawerNo.ToString();
            lblReceiverPersonInfo.Text = drawer.ReceiverPersonName.ToString();
        }
        void searcDrawerByDeliveryEmployee()
        {
            dgvDrawer.DataSource = drawerManager.DrawerByDeliveryEmployee("DrawerByDeliveryEmployee", txtDrawerSearch.Text);
        }
        void searchDrawerByReceiverEmployee()
        {
            dgvDrawer.DataSource = drawerManager.DrawerByReceiverEmployee("DrawerByReceiverEmployee", txtDrawerSearch.Text);
        }
        void searchDrawerByNo()
        {
            dgvDrawer.DataSource = drawerManager.DrawerByDrawerNo("DrawerByDrawerNo", txtDrawerSearch.Text);
        }


        void drawerReturnDelivery()
        {
            drawer = new Drawer(
                Guid.Parse(dgvDrawer.CurrentRow.Cells["DRAWERID"].Value.ToString()),
                dgvDrawer.CurrentRow.Cells["DRAWERNO"].Value.ToString(),
                dgvDrawer.CurrentRow.Cells["RECEIVEREMPLOYEE"].Value.ToString(),
                dgvDrawer.CurrentRow.Cells["RECEIVERPERSONNAME"].Value.ToString(),
                dgvDrawer.CurrentRow.Cells["DELIVERYEMPLOYEE"].Value.ToString(),
                 dgvDrawer.CurrentRow.Cells["DELIVERYPERSONNAME"].Value.ToString(),
                 DateTime.Parse(dgvDrawer.CurrentRow.Cells["DELIVERYDATE"].Value.ToString()));

            DialogResult dialogResult = MessageBox.Show("Seçili Çekmeceyi Teslim Almak İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(drawerManager.Delete(drawer.DrawerId));

            }
        }
        private void btnDrawerSearch_Click(object sender, EventArgs e)
        {
            if (rbDeliveryEmployee.Checked == false & rbDrawerNo.Checked == false & rbReciverEmployee.Checked == false)
            {
                MessageBox.Show("Lütfen Bir Arama Kriteri Seçiniz");
                return;
            }
            else if (rbReciverEmployee.Checked == true)
            {
                searchDrawerByReceiverEmployee();
                if (dgvDrawer.Rows.Count < 1)
                {
                    MessageBox.Show("Girilen Personele Çekmece Teslim Edilmemiştir...");
                    return;
                }

            }
            else if (rbDeliveryEmployee.Checked == true)
            {
                searcDrawerByDeliveryEmployee();
                if (dgvDrawer.Rows.Count < 1)
                {
                    MessageBox.Show("Girilen Personel Çekmece Teslim Etmemiştir...");
                    return;
                }

            }
            else if (rbDrawerNo.Checked == true)
            {
                searchDrawerByNo();
                if (dgvDrawer.Rows.Count < 1)
                {
                    MessageBox.Show("Girilen No İle Çekmece Teslim Edilmemiştir...");
                    return;
                }

            }

            dgvDrawer.Columns[0].Visible = false;
            dgvDrawer.Columns[2].Visible = false;
            dgvDrawer.Columns[3].Visible = false;
        }
        private void btnDrawerList_Click(object sender, EventArgs e)
        {
            allDrawerList();
        }
        private void dgvDrawer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvDrawer.CurrentRow == null)
            {
                MessageBox.Show("Teslim Almak İçin Bir Çekmece Seçiniz");
                return;
            }

            drawer = new Drawer(
                Guid.Parse(dgvDrawer.CurrentRow.Cells["DRAWERID"].Value.ToString()),
                dgvDrawer.CurrentRow.Cells["DRAWERNO"].Value.ToString(),
                dgvDrawer.CurrentRow.Cells["RECEIVEREMPLOYEE"].Value.ToString(),
                dgvDrawer.CurrentRow.Cells["RECEIVERPERSONNAME"].Value.ToString(),
                dgvDrawer.CurrentRow.Cells["DELIVERYEMPLOYEE"].Value.ToString(),
                 dgvDrawer.CurrentRow.Cells["DELIVERYPERSONNAME"].Value.ToString(),
                 DateTime.Parse(dgvDrawer.CurrentRow.Cells["DELIVERYDATE"].Value.ToString()));
            fillInfos();
        }
        private void teslimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawerReturnDelivery();
            lblDrawerNoInfo.Text = "";
            lblDeliveryPersonInfo.Text = "";
            lblReceiverPersonInfo.Text = "";
            allDrawerList();
        }

        private void rbReciverEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtDrawerSearch.Text = "Personel Adı Giriniz...";

        }

        private void rbDrawerNo_CheckedChanged(object sender, EventArgs e)
        {
            txtDrawerSearch.Text = "Çekmece No Giriniz...";
        }

        private void rbDeliveryEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtDrawerSearch.Text = "Personel Adı Giriniz...";
        }

        private void txtDrawerSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtDrawerSearch.Text = "";
        }

        private void btnDrawerDelivery_Click(object sender, EventArgs e)
        {
            DrawerDeliveryForm drawerDeliveryForm = new DrawerDeliveryForm();
            drawerDeliveryForm.infos = infos;
            drawerDeliveryForm.Show();
        }
    }
}
