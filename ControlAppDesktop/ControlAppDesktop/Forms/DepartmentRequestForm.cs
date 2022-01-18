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
        DepartmentManager departmentManager;
        Department department;
        List<Department> departments;
        RequestManager requestManager;
        Request request;
        RequestDetailManager requestDetailManager;
        RequestDetail requestDetail;
        RequestOnDepartmentManager requestOnDepartmentManager;

        public DepartmentRequestForm()
        {
            InitializeComponent();
            departmentManager = DepartmentManager.GetInstance();
            requestManager = RequestManager.GetInstance();
            requestDetailManager = RequestDetailManager.GetInstance();
        }
        void takeToMyDepartmentRequest()
        {
            dgvMyDepartmentRequest.DataSource = requestOnDepartmentManager.GetByDepartmentId("deneme", 
               Guid.Parse(infos[5].ToString()));
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
