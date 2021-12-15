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

    public partial class EmployeeForm : Form
    {
        EmployeeManager employeeManager;
        DepartmentManager departmentManager;
        public object[] infos;
        public EmployeeForm()
        {
            InitializeComponent();
            employeeManager = EmployeeManager.GetInstance();
            departmentManager = DepartmentManager.GetInstance();    
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            EmployeeList();
        }
        void EmployeeList()
        {
            dgvEmployee.DataSource = employeeManager.GetAll();
        }

        private void dgvEmployee_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvEmployee.CurrentRow == null)
            {
                MessageBox.Show("Listeden Personel Seçiniz");
                return;
            }
            Employee employee = new Employee(dgvEmployee.CurrentRow.Cells["Id"].Value.ConGuidToString(), dgvEmployee.CurrentRow.Cells["Tc"].Value.ToString(),
                dgvEmployee.CurrentRow.Cells["Name"].Value.ToString(),
                dgvEmployee.CurrentRow.Cells["Surname"].Value.ToString(),
                dgvEmployee.CurrentRow.Cells["Bdate"].Value.ConDate(),
                dgvEmployee.CurrentRow.Cells["Adress"].Value.ToString(),
                dgvEmployee.CurrentRow.Cells["Tel"].Value.ToString(),
                dgvEmployee.CurrentRow.Cells["Mail"].Value.ToString(),
                dgvEmployee.CurrentRow.Cells["DepartmentName"].Value.ToString(),
                // dgvEmployee.CurrentRow.Cells["AuthorityName"].Value.ToString(),
                dgvEmployee.CurrentRow.Cells["DepartmentId"].Value.ConGuidToString(),
                dgvEmployee.CurrentRow.Cells["AuthorityId"].Value.ConGuidToString());

            lblTcInfo.Text = employee.Tc;
            lblNameInfo.Text = employee.Name; ;
            lblSurnameInfo.Text = employee.Surname;
            lblDepartmentInfo.Text = employee.DepartmentName;
            lblBdateInfo.Text = employee.Bdate.ToString();
            lblTelInfo.Text = employee.Tel;
            lblMailInfo.Text = employee.Mail;



        }
    }
}
