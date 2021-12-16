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
    public partial class UpdateEmployeeFrom : Form
    {
        EmployeeManager employeeManager;
        public object[] infos;
        private Guid _employeeId = Guid.Empty;
        Employee employee;
        DepartmentManager departmentManager;
        List<Department> _departmentList;

        public UpdateEmployeeFrom()
        {
            InitializeComponent();
            employeeManager = EmployeeManager.GetInstance();
        }
       
        public UpdateEmployeeFrom(Guid employeeId)
        {
            this.InitializeComponent();

            _employeeId = employeeId;
            employeeManager = EmployeeManager.GetInstance();
            departmentManager = DepartmentManager.GetInstance();
        }

        private void updateEmployeeFrom_Load(object sender, EventArgs e)
        {
            bool isEmployeeLoaded = GetEmployeeById();
            if (isEmployeeLoaded == true)
            {
                FillCbAuthority();
            }
        }

        bool GetEmployeeById()
        {
            employee = employeeManager.GetById(_employeeId);
            if(employee == null)
            {
                MessageBox.Show("personel yüklenemedi ve ya bulunamadı.");
                return false;
            }
            
            return true;
        }

        void FillCbAuthority()
        {
            _departmentList = departmentManager.GetAll();

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = _departmentList;

           cbAuthorityInfo.DataSource = bindingSource1;
           cbAuthorityInfo.ValueMember = "DepartmentId";
           cbAuthorityInfo.DisplayMember = "DepartmentName";
           cbAuthorityInfo.SelectedValue = employee.DepartmentId;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(cbAuthorityInfo.SelectedIndex == -1)
            {
                MessageBox.Show("department seçiniz");
                return;
            }

            Department selectedDeparment = _departmentList[cbAuthorityInfo.SelectedIndex];
            MessageBox.Show(selectedDeparment.DepartmentName.ToString() + " - " + selectedDeparment.DepartmentId.ToString());
           
        }

        private void cbAuthorityInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
