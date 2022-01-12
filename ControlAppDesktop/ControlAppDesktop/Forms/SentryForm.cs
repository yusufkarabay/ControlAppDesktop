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


        private void btnSentryListDone_Click(object sender, EventArgs e)
        {
            if (dgvSentry.Visible = true)
            {
                dgvSentryTodo.Visible = false;
            }
            dgvSentry.Visible = true;

            thisDateDone();

        }
        private void btnSentryDoneAdd_Click(object sender, EventArgs e)
        {
            if (dgvSentry.Visible = true)
            {
                dgvSentryTodo.Visible = false;
            }
            dgvSentry.Visible = true;

            if (rtbxSentry.Text =="")
            {
                MessageBox.Show("Yapılan İş Alanı Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            sentryDone = new SentryDone(rtbxSentry.Text.ToString(),
           Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")), infos[0].ToString());

            sentryDoneManager.Add(sentryDone);
            MessageBox.Show("İş Başarı İle Kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            btnSentryDoneUpdate.Visible = true;
            sentryDone = new SentryDone(
                 Guid.Parse(dgvSentry.CurrentRow.Cells["SentrydoneId"].Value.ToString()),
                 dgvSentry.CurrentRow.Cells["Done"].Value.ToString(),
                 DateTime.Parse(dgvSentry.CurrentRow.Cells["CreatedTime"].Value.ToString()),
                 dgvSentry.CurrentRow.Cells["CreatedEmployee"].ToString());

            DialogResult dialogResult = MessageBox.Show("Seçili İş İçin Güncelleme Yapmak İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                rtbxSentry.Text = sentryDone.Done;
            }


        }
        private void btnSentryDoneUpdate_Click(object sender, EventArgs e)
        {
             if (dgvSentry.Visible = true)
            {
                dgvSentryTodo.Visible = false;
            }
            dgvSentry.Visible = true;
            if (rtbxSentry.Text == null)
            {
                MessageBox.Show("Yapılan İş Alanı Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            updateSentryDone();
            rtbxSentry.Text = "Nöbet sırasında yapılan işler...";
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
            if (dgvSentryTodo.Visible=true)
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
            btnSentryToDoUpdate.Visible=true;
            sentryToDo = new SentryToDo(
                 Guid.Parse(dgvSentryTodo.CurrentRow.Cells["SentryToDoId"].Value.ToString()),
                 dgvSentryTodo.CurrentRow.Cells["ToDo"].Value.ToString(),
                 DateTime.Parse(dgvSentryTodo.CurrentRow.Cells["CreatedTime"].Value.ToString()),
                 dgvSentryTodo.CurrentRow.Cells["CreatedEmployee"].ToString());

            DialogResult dialogResult = MessageBox.Show("Seçili İş İçin Güncelleme Yapmak İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                rtbxSentryToDo.Text = sentryToDo.ToDo;
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
            if (dgvSentryTodo.Visible = true)
            {
                dgvSentry.Visible = false;
            }
            dgvSentryTodo.Visible = true;
            if (rtbxSentryToDo.Text == null)
            {
                MessageBox.Show("Yapılacak İş Alanı Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            updateSentyToDo();
            rtbxSentryToDo.Text = "Takip edilecek İşlemler...";
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
            if (dgvSentryTodo.Visible = true)
            {
                dgvSentry.Visible = false;
            }
            dgvSentryTodo.Visible = true;

            if (rtbxSentryToDo.Text == null)
            {
                MessageBox.Show("Yapılacak İş Alanı Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            else
            {

                sentryToDo = new SentryToDo(rtbxSentryToDo.Text.ToString(),
               Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")), infos[0].ToString());

                sentryToDoManager.Add(sentryToDo);
                MessageBox.Show("Yapılacak İş Başarı İle Kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rtbxSentryToDo.Text = "Takip Edilecek İşlemler...";
            }

            thisDateToDo();
        }


        //*********************************
        void thisDateDone()
        {
            dgvSentry.DataSource = sentryDoneManager.GetSentryByDate("SentryDoneGetByDate",
            Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")));

            sentryDone = new SentryDone(rtbxSentry.Text.ToString(),
           Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")), infos[0].ToString());

            if (dgvSentry.Rows.Count < 1)
            {
                MessageBox.Show("Bu Tarihte Bir İş Kaydı Yok");
            }
            else
            {
                dgvSentry.Columns[0].Visible = false;
                dgvSentry.Columns[3].Visible = false;
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
                dgvSentry.CurrentRow.Cells["CreatedEmployee"].ToString(),
                dgvSentry.CurrentRow.Cells["EmployeeName"].ToString());


            DialogResult dialogResult = MessageBox.Show("Seçili İş Silmek İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(sentryDoneManager.Delete(sentryDone.SentrydoneId));
                thisDateDone();

            }

        }
        //************************************
        void thisDateToDo()
        {

            dgvSentryTodo.DataSource = sentryToDoManager.GetSentryToDoByDate("SentryToDoGetByDate",
             Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")));

            sentryToDo = new SentryToDo(rtbxSentryToDo.Text.ToString(),
           Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")), infos[0].ToString());

            if (dgvSentryTodo.Rows.Count < 1)
            {
                MessageBox.Show("Bu Tarihte Bir İş Kaydı Yok");
            }
            else
            {
                dgvSentryTodo.Columns[0].Visible = false;
                dgvSentryTodo.Columns[3].Visible = false;
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
        }
    }
}

