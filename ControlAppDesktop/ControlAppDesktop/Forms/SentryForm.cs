﻿using Business.Concrete;
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
            _sentryDoneId = sentrydoneId;

        }

        private void btnSentryListDone_Click(object sender, EventArgs e)
        {
            thisDateDone();
            sentryDone = null;
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

            DialogResult dialogResult = MessageBox.Show("Seçili İş İçin Güncelleme Yapmak İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                rtbxSentry.Text = sentryDone.Done;
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
            gbSentry.Text = "Yapılacak İşler";
        }
        void thisDateDone()
        {
            dgvSentry.DataSource = sentryDoneManager.GetSentryByDate("SentryDoneGetByDate",
            Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")));

            if (dgvSentry.Rows.Count < 1)
            {

                MessageBox.Show("Bu Tarihte Bir İş Kaydı Yok");
            }
            else
            {
                dgvSentry.Columns[0].Visible = false;
            }



        }
        void thisDateTodo()
        {
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
                dgvSentry.CurrentRow.Cells["CreatedEmployee"].ToString());


            DialogResult dialogResult = MessageBox.Show("Seçili İş Silmek İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(sentryDoneManager.Delete(sentryDone.SentrydoneId));
                thisDateDone();

            }

        }
    }
}
