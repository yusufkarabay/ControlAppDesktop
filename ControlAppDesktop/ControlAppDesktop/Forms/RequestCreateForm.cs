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
            requestDetailManager = RequestDetailManager.GetInstance();
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
        void GridDisplay()
        {
            if (dgvNotRequest.Rows.Count>0)
            {

                dgvNotRequest.Columns[0].Visible = false;
                dgvNotRequest.Columns[4].Visible = false;
                dgvNotRequest.Columns[5].Visible = false;

                dgvNotRequest.Columns["RequestTitle"].HeaderText="Talep Başlığı";
                dgvNotRequest.Columns["RequestContent"].HeaderText="Talep İçeriği";
                dgvNotRequest.Columns["RequestTime"].HeaderText="Talep Zamanı";
            }
        }
        void notRequest()
        {
            dgvNotRequest.DataSource = requestManager.RequestSendedList("RequestSendedList", infos[0].ToString());

            GridDisplay();

        }
        void requestToDepartment()
        {

            DialogResult dialogResult = MessageBox.Show("Seçili Görevi Atamak İstediğinize Emin Misiniz?",
                            "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                requestDetail = new RequestDetail(
             Guid.Parse(dgvNotRequest.CurrentRow.Cells[0].Value.ToString()),
             infos[0].ToString(),
             Guid.Parse(cbDepartment.SelectedValue.ToString()),
             Convert.ToBoolean(dgvNotRequest.CurrentRow.Cells[4].Value = true));
                MessageBox.Show(requestDetailManager.RequestToDepartment(requestDetail));

                request = new Request(
                Guid.Parse(dgvNotRequest.CurrentRow.Cells[0].Value.ToString()),
                Convert.ToBoolean(dgvNotRequest.CurrentRow.Cells[4].Value = true));
                requestManager.RequestIsSend(request);

            }

        }
        void requestSendUpdate()
        {
            dgvNotRequest.DataSource = requestManager.RequestSendedList("RequestSendedList",infos[0].ToString());
            if (dgvNotRequest.Rows.Count <= 0)
            {
                return;
            }
            GridDisplay();
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
               DateTime.Parse(DateTime.Now.ToString()),infos[0].ToString());

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
        //***********************************



        private void RequestCreateForm_Load(object sender, EventArgs e)
        {
            //if (dgvNotRequest.Rows.Count<0)
            //{
            //    contextMenuStrip1.Enabled=false;
            //}
            cbFill();

            requestSendUpdate();
        }

        private void btnRequestCreate_Click(object sender, EventArgs e)
        {
            requestAdd();
            requestSendUpdate();
            rtxtRequestContext.Clear();
            txtRequestTitle.Clear();
        }

        private void requestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvNotRequest.CurrentRow == null)
            {
                MessageBox.Show("Göndermek  İstediğiniz Talebi Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            dgvNotRequest.CurrentRow.Cells["REQUESTTITLE"].Value.ToString();
            dgvNotRequest.CurrentRow.Cells["REQUESTCONTENT"].Value.ToString();

            if (cbDepartment.Visible == false)
            {
                cbDepartment.Visible = true;
            }
            if (lblRequestDepartment.Visible == false)
            {
                lblRequestDepartment.Visible = true;
            }
            if (btnSend.Visible==false)
            {
                btnSend.Visible=true;
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
                MessageBox.Show("Talep Edilecek Departmanı Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            requestToDepartment();
            requestSendUpdate();
            if (btnSend.Visible==true)
            {
                btnSend.Visible=false;

            }
            if (lblRequestDepartment.Visible==true)
            {
                lblRequestDepartment.Visible=false;

            }
            if (cbDepartment.Visible==true)
            {
                cbDepartment.SelectedIndex=-1;
                cbDepartment.Visible=false;

            }
        }

        private void dgvNotRequest_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
