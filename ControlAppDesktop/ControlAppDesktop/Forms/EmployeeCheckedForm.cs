using System;
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
    public partial class EmployeeCheckedForm : Form
    {
        public object[] infos;
        DepartmentManager departmentManager;
        Department department;
        List<Department> departments;
        EmployeeManager employeeManager;
        Employee employee;
        List<Employee> employees;
        Authority authority;
        AuthorityManager authorityManager;
        List<Authority> authorityList;
        public EmployeeCheckedForm()
        {
            InitializeComponent();
            departmentManager = DepartmentManager.GetInstance();
            employeeManager= EmployeeManager.GetInstance();
            authorityManager=AuthorityManager.GetInstance();
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

            cbAuthority.DataSource = authorityManager.GetAll();
            cbAuthority.DisplayMember = "AuthorityName";
            cbAuthority.ValueMember = "AuthorityId";
            cbAuthority.SelectedIndex = -1;

        }
        void dgvDisplay()
        {
            if (dgvNotCheckedEmployee.Rows.Count > 0)
            {
                dgvNotCheckedEmployee.Columns[0].Visible = false;
                dgvNotCheckedEmployee.Columns[1].Visible = false;
                dgvNotCheckedEmployee.Columns[2].Visible = false;
                dgvNotCheckedEmployee.Columns[3].Visible = false;
                dgvNotCheckedEmployee.Columns[11].Visible = false;
                dgvNotCheckedEmployee.Columns[12].Visible = false;
                dgvNotCheckedEmployee.Columns[13].Visible = false;
                dgvNotCheckedEmployee.Columns[14].Visible = false;
                dgvNotCheckedEmployee.Columns[15].Visible = false;
                dgvNotCheckedEmployee.Columns[16].Visible = false;
                dgvNotCheckedEmployee.Columns[17].Visible = false;
                dgvNotCheckedEmployee.Columns[18].Visible = false;
                dgvNotCheckedEmployee.Columns[19].Visible = false;
                dgvNotCheckedEmployee.Columns[20].Visible = false;
                dgvNotCheckedEmployee.Columns[21].Visible = false;





                dgvNotCheckedEmployee.Columns["Tc"].HeaderText = "T.C. Kimlik No";
                dgvNotCheckedEmployee.Columns["Name"].HeaderText = "Ad";
                dgvNotCheckedEmployee.Columns["Surname"].HeaderText = "Soyad";
                dgvNotCheckedEmployee.Columns["Bdate"].HeaderText = "Doğum Tarihi";
                dgvNotCheckedEmployee.Columns["Tel"].HeaderText = "Telefon";
               
            }
            return;
        }
        void notCheckedEmployeeList()
        {
            dgvNotCheckedEmployee.DataSource = employeeManager.NotCheckedEmployeeList();
            dgvDisplay();
        }
        void Checked()
        {
            DialogResult dialogResult = MessageBox.Show("Seçili Personeli Onaylamak  İstediğinize Emin Misiniz?",
                               "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                employee = new Employee(
                    dgvNotCheckedEmployee.CurrentRow.Cells[4].Value.ToString(),
                    Guid.Parse(cbDepartment.SelectedValue.ToString()),
                    Guid.Parse(cbAuthority.SelectedValue.ToString()),
                    Convert.ToBoolean(dgvNotCheckedEmployee.CurrentRow.Cells[18].Value = true),
                    infos[0].ToString());
                MessageBox.Show(employeeManager.Checked(employee));
            }
            else
            {
                if (cbDepartment.Visible == false)
                {
                    cbDepartment.Visible = true;
                }
                if (btnOk.Visible == false)
                {
                    btnOk.Visible = true;
                }
                if (lblDepartment.Visible == false)
                {
                    lblDepartment.Visible = true;
                }
                if (cbAuthority.Visible == false)
                {
                    cbAuthority.Visible = true;
                }
                if (lblAuthority.Visible == false)
                {
                    lblAuthority.Visible = true;
                }
                return;
            }
            
        }
        private void EmployeeCheckedForm_Load(object sender, EventArgs e)
        {
            
            
            cbFill();
            notCheckedEmployeeList();
        }

        private void okToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvNotCheckedEmployee.CurrentRow == null)
            {
                MessageBox.Show("Onaylamak  İstediğiniz Personeli Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            cbFill();
            if (cbDepartment.Visible == false)
            {
                cbDepartment.Visible = true;
            }
            if (btnOk.Visible == false)
            {
                btnOk.Visible = true;
            }
            if (lblDepartment.Visible == false)
            {
                lblDepartment.Visible = true;
            }
            if (cbAuthority.Visible == false)
            {
                cbAuthority.Visible = true;
            }
            if (lblAuthority.Visible == false)
            {
                lblAuthority.Visible = true;
            }

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cbDepartment.Visible == true)
            {
                cbDepartment.Visible = false;
            }
            if (btnOk.Visible == true)
            {
                btnOk.Visible = false;
            }
            if (lblDepartment.Visible == true)
            {
                lblDepartment.Visible = false;
            }
            if (lblAuthority.Visible == true)
            {
                lblAuthority.Visible = false;
            }

            if (cbAuthority.Visible == true)
            {
                cbAuthority.Visible = false;
            }


            if (cbDepartment.SelectedItem == null)
            {
                MessageBox.Show("Personelin Çalışacağı  Departmanı Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbAuthority.SelectedItem == null)
            {
                MessageBox.Show("Personelin Yetkisini Seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Checked();
            notCheckedEmployeeList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            notCheckedEmployeeList();
        }
    }
}
