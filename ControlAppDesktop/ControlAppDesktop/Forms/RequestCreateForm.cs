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

namespace ControlAppDesktop.Forms
{
    public partial class RequestCreateForm : Form
    {
        public object[] infos;
        DepartmentManager departmentManager;
        Department department;
        List<Department> departments;
        RequestManager requestManager;
        Request request;
        RequestDetailManager requestDetailManager;
        RequestDetail requestDetail;
        public RequestCreateForm()
        {
            InitializeComponent();
            departmentManager = DepartmentManager.GetInstance();
            requestManager = RequestManager.GetInstance();
            requestDetailManager=RequestDetailManager.GetInstance();    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void cbFill()
        {
            cbDepartment.DataSource = departmentManager.GetAll();
            cbDepartment.DisplayMember = "DepartmentName";
            cbDepartment.ValueMember = "DepartmentId";
            cbDepartment.SelectedIndex = -1;

        }
        void notRequest()
        {
            dgvNotRequest.DataSource = requestManager.GetAll();
            dgvNotRequest.Columns[0].Visible = false;

        }
        void requestAdd()
        {
            if (txtRequestTitle.Text == "")
            {
                MessageBox.Show("Talep Konusu Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (rtxtRequestContext.Text == "")
            {
                MessageBox.Show("Talep İçeriği Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                request = new Request(
                    txtRequestTitle.Text.ToString(),
                    rtxtRequestContext.Text.ToString(),
                    DateTime.Parse(DateTime.Now.ToString()));

                requestManager.Add(request);
                MessageBox.Show("Talep Başarı İle Kaydedildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        void deleteRequest()
        {
            if (dgvNotRequest.CurrentRow == null)
            {
                MessageBox.Show("Sİlmek İçin Bir Kayıt Seçiniz");
                return;
            }
            request = new Request(
                Guid.Parse(dgvNotRequest.CurrentRow.Cells["REQUESTID"].Value.ToString()),
                dgvNotRequest.CurrentRow.Cells["REQUESTTITLE"].Value.ToString(),
                dgvNotRequest.CurrentRow.Cells["REQUESTCONTENT"].Value.ToString(),
                DateTime.Parse(dgvNotRequest.CurrentRow.Cells["REQUESTTIME"].Value.ToString()));

            DialogResult dialogResult = MessageBox.Show("Seçili Atanmamış Talebi Silmek İstediğinize Emin Misiniz?",
                             "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(requestManager.Delete(request.RequestId));

            }
        }

        private void RequestCreateForm_Load(object sender, EventArgs e)
        {
            cbFill();
            notRequest();
        }

        private void btnRequestCreate_Click(object sender, EventArgs e)
        {
            requestAdd();
            notRequest();
        }

        private void requestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvNotRequest.CurrentRow == null)
            {
                MessageBox.Show("Göndermek  İstediğiniz Talebi Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            txtRequestTitle.Text=dgvNotRequest.CurrentRow.Cells["REQUESTTITLE"].Value.ToString();
            rtxtRequestContext.Text = dgvNotRequest.CurrentRow.Cells["REQUESTCONTENT"].Value.ToString();

            if (cbDepartment.Visible == false)
            {
                cbDepartment.Visible = true;
            }
            if (lblRequestDepartment.Visible == false)
            {
                lblRequestDepartment.Visible = true;
            }
        }

        private void deleteRequestlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteRequest();
            notRequest();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            if (cbDepartment.SelectedItem == null)
            {
                MessageBox.Show("Talep Edilecek Departman Boş Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            requestDetail = new RequestDetail(
                Guid.Parse(dgvNotRequest.CurrentRow.Cells["REQUESTID"].Value.ToString()),
                infos[0].ToString(),
                Guid.Parse(cbDepartment.SelectedValue.ToString()));

            requestDetailManager.RequestToDepartment(requestDetail);
            MessageBox.Show("Talep Başarı İle gönderildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //deleteRequest();
        }

        private void dgvNotRequest_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
