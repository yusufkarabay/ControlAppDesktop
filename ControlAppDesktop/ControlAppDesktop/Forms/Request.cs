using Business.Concrete;
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
    public partial class Request : Form
    {
        RequestDetailManager requestDetailManager;
        public object[] infos;
        string tc;
        public Request()
        {
            InitializeComponent();
            requestDetailManager = RequestDetailManager.GetInstance();
        }
        void Fillİnfos()
        {
            tc = infos[0].ToString();
            lblDepartmentInfo.Text = infos[3].ToString();
            lblNameInfo.Text = infos[1].ToString();
            lblSurnameInfo.Text = infos[2].ToString();
            lblTcInfo.Text = tc;

        }
        void RequestList()
        {

            dgvRequest.DataSource = requestDetailManager.GetAll(tc);
            DataGridDisplay();
        }
        private void Request_Load(object sender, EventArgs e)
        {
            Fillİnfos();
            tlblTime.Text = DateTime.Now.ToString("f");
            RequestList();

        }
        void DataGridDisplay()
        {
            dgvRequest.Columns[0].Visible = false;
            dgvRequest.Columns[1].Visible = false;
            dgvRequest.Columns[2].Visible = false;
            dgvRequest.Columns[3].Visible = false;
            dgvRequest.Columns["RequestTitle"].HeaderText = "Talep Başlığı";
            dgvRequest.Columns["RequestContent"].HeaderText = "Talep Açıklaması";
            dgvRequest.Columns["RequestingName"].HeaderText = "Talep Eden";
        }

        private void dgvRequest_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvRequest.CurrentRow==null)
            {
                MessageBox.Show("Detaylarını Görmek İstediğiniz Talebi Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            txtRequestTitle.Text = dgvRequest.CurrentRow.Cells["RequestTitle"].Value.ToString();
            richTxtRequestContent.Text = dgvRequest.CurrentRow.Cells["RequestContent"].Value.ToString();
            txtRequested.Text = dgvRequest.CurrentRow.Cells["RequestingName"].Value.ToString();
        }

        private void btnRequestRefresh_Click(object sender, EventArgs e)
        {
            RequestList();
        }
    }
}
