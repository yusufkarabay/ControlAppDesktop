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
            if (employee == null)
            {
                MessageBox.Show("personel yüklenemedi ve ya bulunamadı.");
                return false;
            }
            mtxtTcInfo.Text = employee.Tc;
            txtNameInfo.Text = employee.Name;
            txtSurnmaeInfo.Text = employee.Surname;

            mtxtBdate.Text = employee.Bdate.ToString();
            mtxtTel.Text = employee.Tel;
            mtxtMail.Text = employee.Mail;
            rtbxAdressInfo.Text = employee.Adress;

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
            if (cbAuthorityInfo.SelectedIndex == -1)
            {
                MessageBox.Show("department seçiniz");
                return;
            }
            UpdadeteEmployee();
            MessageBox.Show(employee.Name + " " + employee.Surname + " Bilgileri Güncellendi");

        }
        void UpdadeteEmployee()
        {
            if (employee == null)
            {
                MessageBox.Show("personel güncellenemedi");
                return;
            }
            DialogResult dialogResult = MessageBox.Show(employee.Name + " " + employee.Surname + " Personeli İçin Güncelleme İşlemi Yapmak İstediğinize Emin Misiniz?",
               "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                employee.Tc = mtxtTcInfo.Text;
                txtNameInfo.Text = employee.Name;
                employee.Surname = txtSurnmaeInfo.Text;
                employee.Bdate = mtxtBdate.Text.ConDate();
                employee.Tel = mtxtTel.Text;
                employee.Mail = mtxtMail.Text;
                employee.Adress = rtbxAdressInfo.Text;
                MessageBox.Show(employeeManager.Update(employee));
            }


        }


    }
}
