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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace ControlAppDesktop.Forms
{

    public partial class InventoryForm : Form
    {
        InventoryManager inventoryManager;
        Employee employee;
        Inventory inventory;
        public object[] infos;
        string fullpath;

        public InventoryForm()
        {
            InitializeComponent();
            inventoryManager = InventoryManager.GetInstance();
        }
        void GridDisplay()
        {
            if (dgvInventory.Rows.Count > 0)
            {
                dgvInventory.Columns[0].Visible = false;
                dgvInventory.Columns[4].Visible = false;
                dgvInventory.Columns[8].Visible = false;
                dgvInventory.Columns["InventorySeriNo"].HeaderText = "Envanter Seri No";
                dgvInventory.Columns["InventoryName"].HeaderText = "Envanter Adı";
                dgvInventory.Columns["Amount"].HeaderText = "Miktar";
                dgvInventory.Columns["CreatedTime"].HeaderText = "Eklenme Zamanı";
                dgvInventory.Columns["Info"].HeaderText = "Detay";
                dgvInventory.Columns["EmployeeName"].HeaderText = "Oluşturan Personel";



            }


        }

        void thisDateAddedInventoryList()
        {
            dgvInventory.DataSource = inventoryManager.GetInventoryByCreatedDate("InventoryGetByCreatedTime",
            Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")),
            Guid.Parse(infos[5].ToString()));

            if (dgvInventory.Rows.Count < 1)
            {
                MessageBox.Show("Seçili Tarihte Eklenmiş Envanter Kaydı Bulunamadı");
            }
            else
            {
                GridDisplay();
            }

        }
        void allInventoryList()
        {
            dgvInventory.DataSource = inventoryManager.GetAllByDepartment("InventoryList", Guid.Parse(infos[5].ToString()));

            GridDisplay();

        }
        void addInventory()
        {
            inventory = new Inventory(
              txtbxInventorySeriNo.Text.ToString(),
              txtbxInventoryName.Text.ToString(),
              Int32.Parse(txtbxAmount.Text.ToString()),
              rtxbxInventoryInfo.Text.ToString(),
              infos[0].ToString(),
               Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")),
               Guid.Parse(infos[5].ToString()));

            inventoryManager.Add(inventory);

            MessageBox.Show("Envanter Başarı İle Kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void deleteInventory()
        {

            if (dgvInventory.CurrentRow == null)
            {
                MessageBox.Show("Sİlmek İçin Bir Kayıt Seçiniz");
                return;
            }
            inventory = new Inventory(
            Guid.Parse(dgvInventory.CurrentRow.Cells["InventoryId"].Value.ToString()),
            dgvInventory.CurrentRow.Cells["InventorySeriNo"].Value.ToString(),
            dgvInventory.CurrentRow.Cells["InventoryName"].Value.ToString(),
            Int32.Parse(dgvInventory.CurrentRow.Cells["Amount"].Value.ToString()),
            dgvInventory.CurrentRow.Cells["Info"].Value.ToString(),
            DateTime.Parse(dgvInventory.CurrentRow.Cells["CreatedTime"].Value.ToString()),
            dgvInventory.CurrentRow.Cells["CreatedEmployee"].ToString(),
            dgvInventory.CurrentRow.Cells["EmployeeName"].ToString(),
            Guid.Parse(dgvInventory.CurrentRow.Cells["DepartmentId"].Value.ToString()));


            DialogResult dialogResult = MessageBox.Show("Seçili İş Silmek İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(inventoryManager.Delete(inventory.InventoryId));

            }

        }
        void updateInventory()
        {
            if (inventory == null)
            {

                MessageBox.Show("Envanter Güncellenemedi");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Seçili Envanteri Güncellemek İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                inventory.InventorySeriNo = txtbxInventorySeriNo.Text;
                inventory.CreatedTime = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                inventory.Amount = txtbxAmount.Text.ContInt();
                inventory.Info = rtxbxInventoryInfo.Text;
                inventory.InventoryName = txtbxInventoryName.Text;
                inventory.CreatedEmployee = infos[0].ToString();


                MessageBox.Show(inventoryManager.UpdateNew(inventory));

            }
        }
        void searchInventoryByName()
        {

            dgvInventory.DataSource = inventoryManager.GetInventoryByName("InventoryGetByName", txtbxtSearchInventoryName.Text, Guid.Parse(infos[5].ToString()));
            GridDisplay();
        }
        void searchInventoryBySeriNo()
        {

            dgvInventory.DataSource = inventoryManager.GetInventoryBySeriNo("InventoryGetBySeriNo", txtInventorySearchSeriNo.Text, Guid.Parse(infos[5].ToString()));
            GridDisplay();

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
            if (txtbxInventorySeriNo.Text == "")
            {
                MessageBox.Show("Seri Numarası Alanı Boş Bırakılamaz");
                return;
            }
            else if (txtbxInventoryName.Text == "")
            {
                MessageBox.Show("Envanter Adı Alanı Boş Bırakılamaz");
                return;
            }
            else if (txtbxAmount.Text == "")
            {
                MessageBox.Show("Envanter Miktarı Boş Bırakılamaz");
                return;
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
            allInventoryList();
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
            if (btnUpdate.Visible == false)
            {
                btnUpdate.Visible = true;
            }
            inventory = new Inventory(
                Guid.Parse(dgvInventory.CurrentRow.Cells["InventoryId"].Value.ToString()),
                dgvInventory.CurrentRow.Cells["InventorySeriNo"].Value.ToString(),
               dgvInventory.CurrentRow.Cells["InventoryName"].Value.ToString(),
               dgvInventory.CurrentRow.Cells["Amount"].Value.ContInt(),
               dgvInventory.CurrentRow.Cells["Info"].Value.ToString(),
               dgvInventory.CurrentRow.Cells["CreatedEmployee"].ToString(),
               DateTime.Parse(dgvInventory.CurrentRow.Cells["CreatedTime"].Value.ToString()));
            Guid.Parse(dgvInventory.CurrentRow.Cells["DepartmentId"].Value.ToString());


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
            if (btnUpdate.Visible == true)
            {
                btnUpdate.Visible = false;
            }
            btnUpdate.Visible = false;



        }
        private void txtbzxSearchInventory_MouseClick(object sender, MouseEventArgs e)
        {
            txtbxtSearchInventoryName.Clear();
            // txtInventorySearchSeriNo.Text = "Seri No'ya Göre Ara...";
        }


        public string Html_Out(DataGridView dg)
        {
            StringBuilder strB = new StringBuilder();
            strB.AppendLine("<html><head><meta charset=utf-8><style>table{padding:10px;} th,td{padding:8px;}</style></head><body><center><table border='1' cellpadding='0' cellspacing='0'>");
            strB.AppendLine("<tr>");
            for (int i = 0; i < dg.Columns.Count; i++) { if (dg.Columns[i].Visible == true) { strB.AppendLine("<th align='center' valign='middle'>" + dg.Columns[i].HeaderText + "</th>"); } }
            strB.AppendLine("</tr>");
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                if (dg.Rows[i].Visible)
                {
                    strB.AppendLine("<tr>");
                    foreach (DataGridViewCell dgvc in dg.Rows[i].Cells)
                    {
                        if (dgvc.OwningColumn.Visible == true) { strB.AppendLine("<td align='center' valign='middle'>" + dgvc.Value.ToString() + "</td>"); }
                    }
                    strB.AppendLine("</tr>");
                }
            }
            strB.AppendLine("</table></center>");
            strB.AppendLine("</body></html>");
            return strB.ToString();
        }

        private void btnInventoryWeb_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Envanter Listesini HTML Ortamında Masaüstü'ne Kaydetmek İstiyor Musunuz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                allInventoryList();
                string content = Html_Out(dgvInventory);
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                File.WriteAllText(desktopPath + "\\ Envanter Listesi.html", content);
                MessageBox.Show("Envanter Listesi HTML Formatında Masaüstüne Kaydedildi...");
            }
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {

        }

        private void txtbxtSearchInventory_TextChanged(object sender, EventArgs e)
        {

            searchInventoryByName();
            if (dgvInventory.RowCount < 1)
            {
                MessageBox.Show("Aranan Ürün Bulunamadı");
                return;
            }


        }

        private void txtInventorySearchSeriNo_TextChanged(object sender, EventArgs e)
        {
            searchInventoryBySeriNo();
            if (dgvInventory.RowCount < 1)
            {
                MessageBox.Show("Aranan Ürün Bulunamadı");
                return;
            }


        }

        private void txtInventorySearchSeriNo_MouseClick(object sender, MouseEventArgs e)
        {
            txtInventorySearchSeriNo.Clear();
            // txtbxtSearchInventoryName.Text = "Envanter Adına Göre Ara...";
        }

        private void txtbxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }



    }
}
