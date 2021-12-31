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
            }
        }
        void allInventoryList()
        {
            dgvInventory.DataSource = inventoryManager.GetAll();
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
            if (inventory == null)
            {
                MessageBox.Show("Envanter Silinemedi");
                return;
            }
            inventory = new Inventory(
            Guid.Parse(dgvInventory.CurrentRow.Cells["InventoryId"].Value.ToString()),
            dgvInventory.CurrentRow.Cells["InventorySeriNo"].ToString(),
            dgvInventory.CurrentRow.Cells["InventoryName"].ToString(),
            dgvInventory.CurrentRow.Cells["Amount"].ContInt(),
            dgvInventory.CurrentRow.Cells["Info"].ToString(),
            dgvInventory.CurrentRow.Cells["CreatedEmployee"].ToString(),
            DateTime.Parse(dgvInventory.CurrentRow.Cells["CreatedTime"].Value.ToString()));

            DialogResult dialogResult = MessageBox.Show("Seçili İş Silmek İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(inventoryManager.Delete(inventory.InventoryId));
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
                addInventory();
            }

            txtbxAmount.Text = "";
            txtbxInventoryName.Text = "";
            txtbxInventorySeriNo.Text = "";
            rtxbxInventoryInfo.Text = "";
            allInventoryList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void deleteInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteInventory();
        }
    }
}
