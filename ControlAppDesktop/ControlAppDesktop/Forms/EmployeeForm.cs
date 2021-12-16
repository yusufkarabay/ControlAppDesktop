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
        Employee employee;

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
            if(dgvEmployee.Rows.Count > 0)
                dgvEmployee.Rows[0].Selected = true;
        }
        void Fillİnfos()
        {
            lblTcInfo.Text = employee.Tc;
            lblNameInfo.Text = employee.Name; ;
            lblSurnameInfo.Text = employee.Surname;
            lblDepartmentInfo.Text = employee.DepartmentName;
            lblBdateInfo.Text = employee.Bdate.ToString();
            lblTelInfo.Text = employee.Tel;
            lblMailInfo.Text = employee.Mail;
        }


        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows == null)
            {
                MessageBox.Show("Güncellenecek Personeli Seçiniz");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(employee.Name + "" + employee.Surname + " Personeli İçin Güncelleme Yapmak İstediğinize Emin Misiniz?",
                              "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    UpdateToEmployeeForm();
                }


            }


        }
        void UpdateToEmployeeForm()
        {
            UpdateEmployeeFrom updateEmployeeFrom = new UpdateEmployeeFrom(employee.Id);
           
            updateEmployeeFrom.Show();

           
        }
        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeList();
        }

        private void dgvEmployee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvEmployee.CurrentRow == null)
            {
                MessageBox.Show("Listeden Personel Seçiniz");
                return;
            }
            employee = new Employee(dgvEmployee.CurrentRow.Cells["Id"].Value.ConGuidToString(), dgvEmployee.CurrentRow.Cells["Tc"].Value.ToString(),
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
            Fillİnfos();
        }

        private void dgvEmployee_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow == null)
            {
                MessageBox.Show("Listeden Personel Seçiniz");
                return;
            }
            employee = new Employee(dgvEmployee.CurrentRow.Cells["Id"].Value.ConGuidToString(), dgvEmployee.CurrentRow.Cells["Tc"].Value.ToString(),
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
            Fillİnfos();
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
