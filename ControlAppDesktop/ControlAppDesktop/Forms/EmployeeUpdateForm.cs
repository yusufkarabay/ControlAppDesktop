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

            dateTimePicker1.Value = employee.Bdate;
            mtxtTel.Text = employee.Tel;
            mtxtMail.Text = employee.Mail;
            rtbxAdressInfo.Text = employee.Adress;

            return true;
        }

        void FillCbAuthority()
        {
            _departmentList = departmentManager.GetAll();

            cbAuthorityInfo.DataSource = _departmentList;
            cbAuthorityInfo.ValueMember = "DepartmentId";
            cbAuthorityInfo.DisplayMember = "DepartmentName";
            cbAuthorityInfo.SelectedValue = employee.DepartmentId;

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

            else if (cbAuthorityInfo.SelectedIndex == -1)
            {
                MessageBox.Show("department seçiniz");
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
                employee.Tc = mtxtTcInfo.Text;
                employee.Name = txtNameInfo.Text;
                employee.Surname = txtSurnmaeInfo.Text;
                employee.Bdate = dateTimePicker1.Value;
                employee.Tel = mtxtTel.Text;
                employee.Mail = mtxtMail.Text;
                employee.Adress = rtbxAdressInfo.Text;
                employee.DepartmentId = Guid.Parse(cbAuthorityInfo.SelectedValue.ToString());
                employee.DepartmentName = cbAuthorityInfo.SelectedText.ToString();

            }
            MessageBox.Show(employeeManager.UpdateNew(employee));


        }


    }
}
