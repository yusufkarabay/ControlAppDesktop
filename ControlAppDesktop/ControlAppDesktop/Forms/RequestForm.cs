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
using System.IO;

namespace ControlAppDesktop.Forms
{
    public partial class RequestForm : Form
    {
        RequestDetailManager requestDetailManager;
        public object[] infos;
        string tc;
        public RequestForm()
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
        void RequestForMeList()
        {
            dgvRequest.DataSource = requestDetailManager.GetAll("MyRequestList", tc);
            
            DataGridDisplay();
            lblCountInfo.Text =dgvRequest.RowCount.ToString();
            if (dgvRequest.RowCount > 0)
            {
                dgvRequest.Columns[0].Visible = false;
                dgvRequest.Columns[1].Visible = false;
                dgvRequest.Columns[2].Visible = false;
                dgvRequest.Columns[3].Visible = false;
                dgvRequest.Columns[7].Visible = false;
                dgvRequest.Columns[8].Visible = false;
                dgvRequest.Columns[9].Visible = false;
                dgvRequest.Columns[11].Visible = false;
                dgvRequest.Columns["RequestTitle"].HeaderText = "Talep Başlığı";
                dgvRequest.Columns["RequestContent"].HeaderText = "Talep Açıklaması";
                dgvRequest.Columns["RequestingName"].HeaderText = "Talep Eden";
                dgvRequest.Columns["RequestTime"].HeaderText = "Talep Zamanı";
            }
        }
        void MyRequest()
        {
            dgvRequest.DataSource = requestDetailManager.GetAll("MyRequestingList", tc);
            DataGridDisplay();
            lblCountInfo.Text = dgvRequest.RowCount.ToString();
        }

        private void Request_Load(object sender, EventArgs e)
        {
            Fillİnfos();
            tlblTime.Text = DateTime.Now.ToString("f");
            RequestForMeList();

        }
        void DataGridDisplay()
        {
            if (dgvRequest.RowCount > 0)
            {
                dgvRequest.Columns[0].Visible = false;
                dgvRequest.Columns[1].Visible = false;
                dgvRequest.Columns[2].Visible = false;
                dgvRequest.Columns[3].Visible = false;
                dgvRequest.Columns[7].Visible = false;
                dgvRequest.Columns[8].Visible = false;
                dgvRequest.Columns[9].Visible = false;
                dgvRequest.Columns[11].Visible = false;
                dgvRequest.Columns["RequestTitle"].HeaderText = "Talep Başlığı";
                dgvRequest.Columns["RequestContent"].HeaderText = "Talep Açıklaması";
                dgvRequest.Columns["RequestingName"].HeaderText = "Talep Eden";
                dgvRequest.Columns["RequestTime"].HeaderText = "Talep Zamanı";
            }

        }

        private void dgvRequest_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvRequest.CurrentRow == null)
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
            RequestForMeList();
        }
        private void btnWeb_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Talepleri HTML Ortamında Masaüstü'ne Kaydetmek İstiyor Musunuz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string content = Html_Out(dgvRequest);
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                File.WriteAllText(desktopPath + "\\" + infos[1] + " " + infos[2] + " adına gelen talepler.html", content);
               
            }
           


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
        private void btnMyRequest_Click(object sender, EventArgs e)
        {
            grpRequest.Text = "Taleplerim";
            MyRequest();
            dgvRequest.Columns["RequestingName"].HeaderText = "Talep Edilen";
        }

        private void txtRequestTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtRequested_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void richTxtRequestContent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void richTxtRequestContent_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void txtRequested_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void txtRequestTitle_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void btnCreateRequest_Click(object sender, EventArgs e)
        {
            RequestCreateForm requestCreateForm = new RequestCreateForm();
            requestCreateForm.infos = infos;
            requestCreateForm.Show();
        }

        private void btnDepartmentRequest_Click(object sender, EventArgs e)
        {
            DepartmentRequestForm departmentRequestForm = new DepartmentRequestForm();  
            departmentRequestForm.infos = infos;
            departmentRequestForm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RequestForMeList();
        }
    }
}
