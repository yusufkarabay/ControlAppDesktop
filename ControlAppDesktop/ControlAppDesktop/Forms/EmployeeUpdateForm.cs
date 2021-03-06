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
    public partial class EmployeeUpdateForm : Form
    {
        EmployeeManager employeeManager;
        public object[] infos;
        private Guid _employeeId = Guid.Empty;
        Employee employee;
        DepartmentManager departmentManager;
        List<Department> _departmentList;
        AuthorityManager authorityManager;
        Authority authority;
        List<Authority> _authorityList;

        public EmployeeUpdateForm()
        {
            InitializeComponent();
            employeeManager = EmployeeManager.GetInstance();
           
        }

        public EmployeeUpdateForm(Guid employeeId)
        {
            this.InitializeComponent();

            _employeeId = employeeId;
            employeeManager = EmployeeManager.GetInstance();
            departmentManager = DepartmentManager.GetInstance();
            authorityManager = AuthorityManager.GetInstance();
        }

        private void updateEmployeeFrom_Load(object sender, EventArgs e)
        {
            bool isEmployeeLoaded = GetEmployeeById();
            if (isEmployeeLoaded == true)
            {
                FillCbAuthority();

            }
            if (infos[4].ToString()!="Administrator")
            {
                cbAuthority.Enabled=false;
                cbDepartment.Enabled=false;
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
            mtxbTC.Text = employee.Tc;
            txtNameInfo.Text = employee.Name;
            txtSurnmaeInfo.Text = employee.Surname;

            dateTimePicker1.Value = employee.Bdate;
            mtxtTel.Text = employee.Tel;
            mtxtMail.Text = employee.Mail;
            rtbxAdressInfo.Text = employee.Adress;

            return true;
        }

        void FillCbAuthority()
        {
            _departmentList = departmentManager.GetAll();
            _authorityList = authorityManager.GetAll();

            cbDepartment.DataSource = _departmentList;
            cbDepartment.ValueMember = "DepartmentId";
            cbDepartment.DisplayMember = "DepartmentName";
            cbDepartment.SelectedValue = employee.DepartmentId;

            cbAuthority.DataSource = _authorityList;

            cbAuthority.ValueMember = "AuthorityId";
            cbAuthority.DisplayMember = "AuthorityName";
            cbAuthority.SelectedValue = employee.AuthorityId;

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNameInfo.Text == "")
            {
                MessageBox.Show("TC Kimlik No Alanı Boş Bırakılamaz"); return;
            }
            else if (txtNameInfo.Text == "")
            {
                MessageBox.Show("Ad Alanı Boş Bırakılamaz"); return;
            }
            else if (txtSurnmaeInfo.Text == "")
            {
                MessageBox.Show("Soyad Alanı Boş Bırakılamaz"); return;
            }
            else if (txtNameInfo.Text == "")
            {
                MessageBox.Show("Ad Alanı Boş Bırakılamaz");
                return;
            }

            else if (cbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Departman seçiniz");
                return;
            }
            else if (cbAuthority.SelectedIndex == -1)
            {
                MessageBox.Show("Yetki seçiniz");
                return;
            }
            
            else
            {
                UpdadeteEmployee();
            }

            this.Close();


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
                employee.Tc = mtxbTC.Text;
                employee.Name = txtNameInfo.Text;
                employee.Surname = txtSurnmaeInfo.Text;
                employee.Bdate = dateTimePicker1.Value;
                employee.Tel = mtxtTel.Text;
                employee.Mail = mtxtMail.Text;
                employee.Adress = rtbxAdressInfo.Text;
                employee.DepartmentId = Guid.Parse(cbDepartment.SelectedValue.ToString());
                employee.DepartmentName = cbDepartment.SelectedText.ToString();
                employee.AuthorityId = Guid.Parse(cbAuthority.SelectedValue.ToString());
                employee.AuthorityName = cbAuthority.SelectedText.ToString();

            }
            MessageBox.Show(employeeManager.UpdateNew(employee));


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
