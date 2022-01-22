using Business;
using Business.Concrete;
using DataAccess.Concrete;
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
    public partial class AdminForm : Form
    {
        public object[] infos;
      
        public AdminForm()
        {
            InitializeComponent();            
        }

        private void btnDepartmentForm_Click(object sender, EventArgs e)
        {
            DepartmentForm departmentForm= new DepartmentForm();
            departmentForm.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthorityForm  authorityForm= new AuthorityForm();
            authorityForm.Show();
        }

        private void btnEmployeeChecked_Click(object sender, EventArgs e)
        {
            EmployeeCheckedForm employeeCheckedForm= new EmployeeCheckedForm();
            employeeCheckedForm.infos = infos;
            employeeCheckedForm.Show();

        }
    }
}
