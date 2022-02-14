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
    public partial class SentryForm : Form
    {
        SentryDoneManager sentryDoneManager;
        DepartmentManager departmentManager;
        Employee employee;
        SentryDone sentryDone;
        SentryToDo sentryToDo;
        public object[] infos;
        private Guid _sentryDoneId = Guid.Empty;
        SentryToDoManager sentryToDoManager;

        public SentryForm()
        {
            InitializeComponent();
            departmentManager = DepartmentManager.GetInstance();
            sentryDoneManager = SentryDoneManager.GetInstance();
            sentryToDoManager = SentryToDoManager.GetInstance();

        }

        void DataGridSettings(DataGridView dataGridView)
        {
            dataGridView.BorderStyle=BorderStyle.None;
            dataGridView.BackgroundColor=Color.LightGray;
            dataGridView.DefaultCellStyle.SelectionBackColor=Color.FromArgb(26, 110, 145);
            dataGridView.EnableHeadersVisualStyles=false;
            
           
        }
        private void btnSentryListDone_Click(object sender, EventArgs e)
        {
            if (dgvSentry.Visible == true)
            {
                dgvSentryTodo.Visible = false;
            }
            dgvSentry.Visible = true;

            thisDateDone();

        }
        private void btnSentryDoneAdd_Click(object sender, EventArgs e)
        {
            if (dgvSentry.Visible == true)
            {
                dgvSentryTodo.Visible = false;
            }
            dgvSentry.Visible = true;

            if (rtbxSentry.Text == "" | rtbxSentry.Text == "Nöbet sırasında yapılan işler...")
            {
                MessageBox.Show("Yapılan İş Alanı Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            sentryDone = new SentryDone(rtbxSentry.Text.ToString(),
           Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")), infos[0].ToString(), Guid.Parse(infos[5].ToString()));

            string result = sentryDoneManager.Add(sentryDone);
            if (result == "")
            {
                MessageBox.Show("İş Başarı İle Kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == "-1")
            {
                MessageBox.Show("İş Kaydedilemedi Lütfen Sistem Yöneticisine Bilgi Veriniz", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            rtbxSentry.Text = "Nöbet sırasında yapılan işler...";
            thisDateDone();
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvSentry.SelectedRows == null)
            {
                MessageBox.Show("Listeden Güncellenecek İş seçiniz");
                return;
            }

            sentryDone = new SentryDone(
                 Guid.Parse(dgvSentry.CurrentRow.Cells["SentrydoneId"].Value.ToString()),
                 dgvSentry.CurrentRow.Cells["Done"].Value.ToString(),
                 DateTime.Parse(dgvSentry.CurrentRow.Cells["CreatedTime"].Value.ToString()),
                 dgvSentry.CurrentRow.Cells["CreatedEmployee"].ToString());
            if (infos[0].ToString() != dgvSentry.CurrentRow.Cells["CreatedEmployee"].Value.ToString())
            {
                MessageBox.Show("Yalnızca Kendi Oluşturduğunuz Kayıtları Güncelleyebilirsiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Seçili İş İçin Güncelleme Yapmak İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                btnSentryDoneUpdate.Visible = true;
                btnSentryDoneAdd.Visible = false;
                rtbxSentry.Text = sentryDone.Done;
            }



        }
        private void btnSentryDoneUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSentry.Visible == true)
            {
                dgvSentryTodo.Visible = false;
            }
            dgvSentry.Visible = true;
            if (rtbxSentry.Text == "" | rtbxSentry.Text == "Nöbet sırasında yapılan işler...")
            {
                MessageBox.Show("Yapılan İş Alanı Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            updateSentryDone();
            rtbxSentry.Text = "Nöbet sırasında yapılan işler...";
            btnSentryDoneAdd.Visible = true;
            thisDateDone();


        }
        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thisDateDone();
            sentryDone = null;
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

            deleteSentyrDone();
        }
        private void btnSentryListToDo_Click(object sender, EventArgs e)
        {
            if (dgvSentryTodo.Visible == true)
            {
                dgvSentry.Visible = false;
            }
            dgvSentryTodo.Visible = true;
            thisDateToDo();

        }


        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvSentryTodo.SelectedRows == null)
            {
                MessageBox.Show("Listeden Güncellenecek İş seçiniz");
                return;
            }

            sentryToDo = new SentryToDo(
                 Guid.Parse(dgvSentryTodo.CurrentRow.Cells["SentryToDoId"].Value.ToString()),
                 dgvSentryTodo.CurrentRow.Cells["ToDo"].Value.ToString(),
                 DateTime.Parse(dgvSentryTodo.CurrentRow.Cells["CreatedTime"].Value.ToString()),
                 dgvSentryTodo.CurrentRow.Cells["CreatedEmployee"].ToString());
            if (infos[0].ToString() != dgvSentryTodo.CurrentRow.Cells["CreatedEmployee"].Value.ToString())
            {
                MessageBox.Show("Yalnızca Kendi Oluşturduğunuz Kayıtları Güncelleyebilirsiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Seçili İş İçin Güncelleme Yapmak İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                rtbxSentryToDo.Text = sentryToDo.ToDo;
                btnSentryToDoUpdate.Visible = true;
            }

        }
        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            deleteSentryToDo();
        }
        private void yenileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            thisDateToDo();
            sentryToDo = null;
        }
        private void btnSentryToDoUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSentryTodo.Visible == true)
            {
                dgvSentry.Visible = false;
            }
            dgvSentryTodo.Visible = true;
            if (rtbxSentryToDo.Text == "" | rtbxSentryToDo.Text == "Takip edilecek işlemler...")
            {
                MessageBox.Show("Yapılacak İş Alanı Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            updateSentyToDo();
            rtbxSentryToDo.Text = "Takip edilecek işlemler...";
            btnSentryToDoUpdate.Visible = false;
            thisDateToDo();
        }
        private void SentryForm_Load(object sender, EventArgs e)
        {
            btnSentryToDoUpdate.Visible = false;
            btnSentryDoneUpdate.Visible = false;
            dgvSentry.Visible = true;
            dgvSentryTodo.Visible = false;
        }
        private void btnSentryToDoAdd_Click(object sender, EventArgs e)
        {
            if (dgvSentryTodo.Visible == true)
            {
                dgvSentry.Visible = false;
            }
            dgvSentryTodo.Visible = true;

            if (rtbxSentryToDo.Text == "" || rtbxSentryToDo.Text == "Takip edilecek işlemler...")
            {
                MessageBox.Show("Yapılacak İş Alanı Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else
            {

                sentryToDo = new SentryToDo(rtbxSentryToDo.Text.ToString(),
               Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")), infos[0].ToString(), Guid.Parse(infos[5].ToString()));

                sentryToDoManager.Add(sentryToDo);
                MessageBox.Show("Yapılacak İş Başarı İle Kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtbxSentryToDo.Text = "Takip Edilecek İşlemler...";
            }

            thisDateToDo();
        }

        void GridDisplayDone()
        {
            dgvSentry.Columns[0].Visible = false;
            dgvSentry.Columns[3].Visible = false;
            dgvSentry.Columns[5].Visible = false;
            dgvSentry.Columns["Done"].HeaderText ="Yapılan İşlemler";
            dgvSentry.Columns["EmployeeName"].HeaderText ="Personel Adı";
            dgvSentry.Columns["CreatedTime"].HeaderText ="Eklenme Zamanı";


        }
        //*********************************
        void thisDateDone()
        {
            dgvSentry.DataSource = sentryDoneManager.GetSentryByDate("SentryDoneGetByDate",
            Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")),
            Guid.Parse(infos[5].ToString()));

            sentryDone = new SentryDone(rtbxSentry.Text.ToString(),
           Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")), infos[0].ToString(), Guid.Parse(infos[5].ToString()));

            if (dgvSentry.Rows.Count < 1)
            {
                MessageBox.Show("Bu Tarihte Bir İş Kaydı Yok");
            }
            else
            {

                GridDisplayDone();
            }
        }
        void updateSentryDone()
        {
            if (sentryDone == null)
            {
                MessageBox.Show("İş Kaydı Güncellenemedi");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Seçili İş Değişikliğini Güncellemek İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                sentryDone.Done = rtbxSentry.Text.ToString();
                sentryDone.CreatedTime = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                sentryDone.CreatedEmployee = infos[0].ToString();

                MessageBox.Show(sentryDoneManager.UpdateNew(sentryDone));

            }


        }
        void deleteSentyrDone()
        {
            if (sentryDone == null)
            {
                MessageBox.Show("İş Kaydı Silinemedi");
                return;
            }

            sentryDone = new SentryDone(
                Guid.Parse(dgvSentry.CurrentRow.Cells["SentrydoneId"].Value.ToString()),
                dgvSentry.CurrentRow.Cells["Done"].Value.ToString(),
                DateTime.Parse(dgvSentry.CurrentRow.Cells["CreatedTime"].Value.ToString()),
                dgvSentry.CurrentRow.Cells["CreatedEmployee"].Value.ToString(),
                dgvSentry.CurrentRow.Cells["EmployeeName"].Value.ToString(),
                Guid.Parse(dgvSentry.CurrentRow.Cells["DepartmentId"].Value.ToString()));


            DialogResult dialogResult = MessageBox.Show("Seçili İş Silmek İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (infos[0].ToString() != dgvSentry.CurrentRow.Cells["CreatedEmployee"].Value.ToString())
                {
                    MessageBox.Show("Yalnızce Kendi Oluşturduğunuz Kayıtları Silebilirsiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show(sentryDoneManager.Delete(sentryDone.SentrydoneId, infos[0].ToString()));
                thisDateDone();

            }

        }
        //************************************
        void GridDisplayToDo()
        {
            dgvSentryTodo.Columns[0].Visible = false;
            dgvSentryTodo.Columns[3].Visible = false;
            dgvSentryTodo.Columns[5].Visible = false;
            dgvSentryTodo.Columns["ToDo"].HeaderText ="Yapılacak İşlemler";
            dgvSentryTodo.Columns["EmployeeName"].HeaderText ="Personel Adı";
            dgvSentryTodo.Columns["CreatedTime"].HeaderText ="Eklenme Zamanı";

        }
        void thisDateToDo()
        {

            dgvSentryTodo.DataSource = sentryToDoManager.GetSentryToDoByDate(
                "SentryToDoGetByDate",
             Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")),
             Guid.Parse(infos[5].ToString()));

            sentryToDo = new SentryToDo(rtbxSentryToDo.Text.ToString(),
           Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")), infos[0].ToString(), Guid.Parse(infos[5].ToString()));

            if (dgvSentryTodo.Rows.Count < 1)
            {
                MessageBox.Show("Bu Tarihte Bir İş Kaydı Yok");
            }
            else
            {
                GridDisplayToDo();
            }


        }
        void deleteSentryToDo()
        {
            if (sentryToDo == null)
            {
                MessageBox.Show("İş Kaydı Silinemedi");
                return;
            }
            sentryToDo = new SentryToDo(
                 Guid.Parse(dgvSentryTodo.CurrentRow.Cells["SentryToDoId"].Value.ToString()),
                 dgvSentryTodo.CurrentRow.Cells["ToDo"].Value.ToString(),
                 DateTime.Parse(dgvSentryTodo.CurrentRow.Cells["CreatedTime"].Value.ToString()),
                 dgvSentryTodo.CurrentRow.Cells["CreatedEmployee"].ToString());

            if (infos[0].ToString() != dgvSentryTodo.CurrentRow.Cells["CreatedEmployee"].Value.ToString())
            {
                MessageBox.Show("Yalnızce Kendi Oluşturduğunuz Kayıtları Silebilirsiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Seçili İş Silmek İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                MessageBox.Show(sentryToDoManager.Delete(sentryToDo.SentryToDoId));
                thisDateToDo();

            }
        }
        void updateSentyToDo()
        {
            if (sentryToDo == null)
            {
                MessageBox.Show("İş Kaydı Güncellenemedi");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Seçili İş Değişikliğini Güncellemek İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                sentryToDo.ToDo = rtbxSentryToDo.Text.ToString();
                sentryToDo.CreatedTime = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                sentryToDo.CreatedEmployee = infos[0].ToString();

                MessageBox.Show(sentryToDoManager.UpdateNew(sentryToDo));

            }

        }

        private void rtbxSentry_MouseClick(object sender, MouseEventArgs e)
        {
            rtbxSentry.Text = "";
        }

        private void rtbxSentryToDo_MouseClick(object sender, MouseEventArgs e)
        {
            rtbxSentryToDo.Text = "";
            btnSentryToDoAdd.Enabled = true;
        }

       

     
        private void dgvSentry_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            sentryDone = new SentryDone(
                Guid.Parse(dgvSentry.CurrentRow.Cells["SentrydoneId"].Value.ToString()),
                    dgvSentry.CurrentRow.Cells["Done"].Value.ToString(),
                    DateTime.Parse(dgvSentry.CurrentRow.Cells["CreatedTime"].Value.ToString()),
                    dgvSentry.CurrentRow.Cells["CreatedEmployee"].Value.ToString(),
                    dgvSentry.CurrentRow.Cells["EmployeeName"].Value.ToString(),
                    Guid.Parse(dgvSentry.CurrentRow.Cells["DepartmentId"].Value.ToString()));

            rtbxSentry.Text=sentryDone.Done.ToString();
        }

        private void dgvSentryTodo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            sentryToDo = new SentryToDo(
                Guid.Parse(dgvSentryTodo.CurrentRow.Cells["SentryToDoId"].Value.ToString()),
                dgvSentryTodo.CurrentRow.Cells["ToDo"].Value.ToString(),
                DateTime.Parse(dgvSentryTodo.CurrentRow.Cells["CreatedTime"].Value.ToString()),
                dgvSentryTodo.CurrentRow.Cells["CreatedEmployee"].ToString());
            rtbxSentryToDo.Text=sentryToDo.ToDo.ToString();
        }
    }
}

