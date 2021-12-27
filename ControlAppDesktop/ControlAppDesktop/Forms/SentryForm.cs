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
        public object[] infos;
        private Guid _sentryDoneId = Guid.Empty;

        public SentryForm()
        {
            InitializeComponent();
            departmentManager = DepartmentManager.GetInstance();
            sentryDoneManager = SentryDoneManager.GetInstance();

        }
        public SentryForm(Guid sentrydoneId)
        {
            this.InitializeComponent();
            _sentryDoneId=sentrydoneId;

        }

        private void btnSentryListDone_Click(object sender, EventArgs e)
        {
            thisDate();
        }
        void thisDate()
        {
            dgvSentry.DataSource = sentryDoneManager.GetSentryByDate("SentryDoneGetByDate",
            Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")));
            dgvSentry.Columns[0].Visible = false;
        }

        private void btnSentryDoneAdd_Click(object sender, EventArgs e)
        {

            if (rtbxSentry.Text == null)
            {
                MessageBox.Show("Yapılan İş Alanı Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            sentryDone = new SentryDone(rtbxSentry.Text.ToString(),
           Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")), infos[0].ToString());

            sentryDoneManager.Add(sentryDone);
            MessageBox.Show("İş Başarı İle Kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            rtbxSentry.Text = "Nöbet sırasında yapılan işler...";
            thisDate();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool getSentry = GetSentryDone();
            if (getSentry == true)
            {
                if (dgvSentry.SelectedRows == null)
                {
                    MessageBox.Show("Güncellenecek İş Seçiniz");
                    return;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Seçili İş İçin Güncelleme Yapmak İstediğinize Emin Misiniz?",
                                 "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        rtbxSentry.Text = dgvSentry.CurrentRow.Cells[1].Value.ToString();

                    }
                }
            }

        }

        private void btnSentryDoneUpdate_Click(object sender, EventArgs e)
        {


            if (rtbxSentry.Text == null)
            {
                MessageBox.Show("Yapılan İş Alanı Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            updateSentryDone();



        }

        bool GetSentryDone()
        {
            sentryDone = sentryDoneManager.GetSentryDone(_sentryDoneId);
            if (sentryDone == null)
            {
                MessageBox.Show("Yapılan İş Yüklenemedi");
                return false;
            }

            sentryDone.SentrydoneId = Guid.Parse(dgvSentry.CurrentRow.Cells[0].Value.ToString());
            sentryDone.Done = rtbxSentry.Text;
            sentryDone.CreatedTime = DateTime.Parse(dateTimePicker1.Value.ToString());
            sentryDone.CreatedEmployee = infos[1].ToString();
            return true;

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
                sentryDone.CreatedTime=Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            }

            MessageBox.Show(sentryDoneManager.UpdateNew(sentryDone));

        }

    }
}

