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
using DataAccess.Concrete;

namespace ControlAppDesktop.Forms
{

    public partial class InventoryForm : Form
    {
        InventoryManager inventoryManager;
        Employee employee;
        Inventory inventory;
        public object[] infos;

        public InventoryForm()
        {
            InitializeComponent();
            inventoryManager = InventoryManager.GetInstance();
        }

        void thisDateAddedInventoryList()
        {
            dgvInventory.DataSource = inventoryManager.GetInventoryByCreatedDate("InventoryGetByCreatedTime",
            Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")));

            if (dgvInventory.Rows.Count < 1)
            {
                MessageBox.Show("Seçili Tarihte Eklenmiş Envanter Kaydı Bulunamadı");
            }
            else
            {
                dgvInventory.Columns[0].Visible = false;
                dgvInventory.Columns[4].Visible = false;
            }
            
        }
        void allInventoryList()
        {
            dgvInventory.DataSource = inventoryManager.GetAll();
            dgvInventory.Columns[0].Visible = false;
            dgvInventory.Columns[4].Visible = false;
        }
        void addInventory()
        {
            inventory = new Inventory(txtbxInventorySeriNo.Text.ToString(),
              txtbxInventoryName.Text.ToString(),
              txtbxAmount.Text.ContInt(),
              rtxbxInventoryInfo.Text.ToString(),
              infos[0].ToString(),
             Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")));

            inventoryManager.Add(inventory);

            MessageBox.Show("Envanter Başarı İle Kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void deleteInventory()
        {
          

            inventory = new Inventory(
            Guid.Parse(dgvInventory.CurrentRow.Cells["InventoryId"].Value.ToString()),
            dgvInventory.CurrentRow.Cells["InventorySeriNo"].Value.ToString(),
            dgvInventory.CurrentRow.Cells["InventoryName"].Value.ToString(),
            Int32.Parse(dgvInventory.CurrentRow.Cells["Amount"].Value.ToString()),
            dgvInventory.CurrentRow.Cells["Info"].Value.ToString(),
            DateTime.Parse(dgvInventory.CurrentRow.Cells["CreatedTime"].Value.ToString()),
            dgvInventory.CurrentRow.Cells["CreatedEmployee"].ToString(),
            dgvInventory.CurrentRow.Cells["EmployeeName"].ToString());


            DialogResult dialogResult = MessageBox.Show("Seçili İş Silmek İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(inventoryManager.Delete(inventory.InventoryId));
                thisDateAddedInventoryList();
            }

        }
        void updateInventory()
        {
            if (inventory==null)
            {

                MessageBox.Show("Envanter Güncellenemedi");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Seçili Envanteri Güncellemek İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                inventory.InventorySeriNo=txtbxInventorySeriNo.Text;
                inventory.CreatedTime = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                inventory.Amount = txtbxAmount.Text.ContInt();
                inventory.Info = rtxbxInventoryInfo.Text;
                inventory.InventoryName=txtbxInventoryName.Text;
                inventory.CreatedEmployee = infos[0].ToString();


                MessageBox.Show(inventoryManager.UpdateNew(inventory));

            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            thisDateAddedInventoryList();
        }
        private void btnAllList_Click(object sender, EventArgs e)
        {
            allInventoryList();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtbxInventorySeriNo.Text =="")
            {
                MessageBox.Show("Seri Numarası Alanı Boş Bırakılamaz");
            }
            else if (txtbxInventoryName.Text =="")
            {
                MessageBox.Show("Envanter Adı Alanı Boş Bırakılamaz");
            }
            else if (txtbxAmount.Text =="")
            {
                MessageBox.Show("Envanter Miktarı Boş Bırakılamaz");
            }
            else 
            {
                addInventory();
            }

            txtbxAmount.Text = "";
            txtbxInventoryName.Text = "";
            txtbxInventorySeriNo.Text = "";
            rtxbxInventoryInfo.Text = "";
            allInventoryList();

        }
        private void deleteInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteInventory();
        }
        private void refreshInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allInventoryList();
        }
        private void updateInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows == null)
            {
                MessageBox.Show("Listeden Güncellenecek İş seçiniz");
                return;
            }
            if (btnAdd.Visible=true)
            {
                btnAdd.Visible = false;
            }
            inventory = new Inventory(
                Guid.Parse(dgvInventory.CurrentRow.Cells["InventoryId"].Value.ToString()),
                dgvInventory.CurrentRow.Cells["InventorySeriNo"].Value.ToString(),
               dgvInventory.CurrentRow.Cells["InventoryName"].Value.ToString(),
               dgvInventory.CurrentRow.Cells["Amount"].Value.ContInt(),
               dgvInventory.CurrentRow.Cells["Info"].Value.ToString(),
               dgvInventory.CurrentRow.Cells["CreatedEmployee"].ToString(),
               DateTime.Parse(dgvInventory.CurrentRow.Cells["CreatedTime"].Value.ToString()));

            DialogResult dialogResult = MessageBox.Show("Seçili Envanteri Güncelleme Yapmak İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                rtxbxInventoryInfo.Text = inventory.Info;
                txtbxAmount.Text = inventory.Amount.ToString();
                txtbxInventoryName.Text = inventory.InventoryName;
                txtbxInventorySeriNo.Text = inventory.InventorySeriNo;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtbxInventorySeriNo == null)
            {
                MessageBox.Show("Seri Numarası Alanı Boş Bırakılamaz");
            }
            else if (txtbxInventoryName == null)
            {
                MessageBox.Show("Envanter Adı Alanı Boş Bırakılamaz");
            }
            else if (txtbxAmount == null)
            {
                MessageBox.Show("Envanter Miktarı Boş Bırakılamaz");
            }
            else
            {
                updateInventory();
            }
            
            txtbxAmount.Text = "";
            txtbxInventoryName.Text = "";
            txtbxInventorySeriNo.Text = "";
            rtxbxInventoryInfo.Text = "";
            allInventoryList();
            if (btnAdd.Visible=false)
            {
                btnAdd.Visible = true;
            }


        }
        private void InventoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
