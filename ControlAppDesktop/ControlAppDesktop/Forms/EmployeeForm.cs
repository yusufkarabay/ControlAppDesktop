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

    public partial class EmployeeForm : Form
    {
        EmployeeManager employeeManager;
        public EmployeeForm()
        {
            InitializeComponent();
            employeeManager = EmployeeManager.GetInstance();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

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
            Employee employee = new Employee(dgvEmployee.CurrentRow.Cells["Tc"].Value.ToString(),
                dgvEmployee.CurrentRow.Cells["Name"].Value.ToString(),
                dgvEmployee.CurrentRow.Cells["Surname"].Value.ToString(),
                dgvEmployee.CurrentRow.Cells["Bdate"].Value.ToString(),
                dgvEmployee.CurrentRow.Cells["Adress"].Value.ToString(),
                dgvEmployee.CurrentRow.Cells["Tel"].Value.ToString(),
                dgvEmployee.CurrentRow.Cells["Mail"].Value.ToString(),
                dgvEmployee.CurrentRow.Cells["DepartmentName"].Value.ToString(),
                dgvEmployee.CurrentRow.Cells["AuthorityName"].Value.ToString());
                

        }
    }
}
