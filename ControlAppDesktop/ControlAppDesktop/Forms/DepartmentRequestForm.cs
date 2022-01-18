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

namespace ControlAppDesktop
{
    public partial class DepartmentRequestForm : Form
    {//İNFOS 5 DE DEPARTMAN İD VAR
        public object[] infos;
     
       
        RequestOnDepartmentManager requestOnDepartmentManager;

        public DepartmentRequestForm()
        {
            InitializeComponent();
         
           
            requestOnDepartmentManager = RequestOnDepartmentManager.GetInstance();
        }
        void takeToMyDepartmentRequest()
        {
            dgvMyDepartmentRequest.DataSource = requestOnDepartmentManager.GetByDepartmentId("deneme",
               Guid.Parse(infos[5].ToString()));
            if (dgvMyDepartmentRequest.Rows.Count > 0)
            {
                dgvMyDepartmentRequest.Columns[0].Visible = false;
                dgvMyDepartmentRequest.Columns[1].Visible = false;
                dgvMyDepartmentRequest.Columns[3].Visible = false;
                dgvMyDepartmentRequest.Columns[4].Visible = false;
                dgvMyDepartmentRequest.Columns[2].Visible = false;

                dgvMyDepartmentRequest.Columns["Requesting"].HeaderText = "Talep Eden";
                dgvMyDepartmentRequest.Columns["RequestTitle"].HeaderText = "Talep Konusu";
                dgvMyDepartmentRequest.Columns["RequestContent"].HeaderText = "Talep İçeriği";
                dgvMyDepartmentRequest.Columns["RequestTime"].HeaderText = "Talep Tarihi";
                dgvMyDepartmentRequest.Columns["RequestingName"].HeaderText = "Talep Eden";



            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DepartmentRequestForm_Load(object sender, EventArgs e)
        {
            takeToMyDepartmentRequest();
        }
    }
}
