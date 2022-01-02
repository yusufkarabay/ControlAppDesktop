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
    public partial class AddEmployeeForm : Form
    {
        EmployeeManager employeeManager;
        DepartmentManager departmentManager;
        AuthorityManager authorityManager;
        public object[] infos;
        Employee employee;
        List<Department> departmentList;
        List<Authority> authorityList;

        private Guid _employeeId = Guid.Empty;


        public AddEmployeeForm()
        {
            InitializeComponent();
            employeeManager = EmployeeManager.GetInstance();
            departmentManager = DepartmentManager.GetInstance();
            authorityManager = AuthorityManager.GetInstance();

        }
        void EmployeeAdd()
        {
            employee = new Employee(
             mtxtTcInfo.Text.ToString(),
             txtNameInfo.Text.ToString(),
             txtSurnmaeInfo.Text.ToString(),
             DateTime.Parse(dtpEmployeeBDate.Value.ToString("yyyy-MM-dd")),
              rtbxAdressInfo.Text.ToString(),
               mtxtTel.Text.ToString(),
               mtxtMail.Text.ToString(), 
               Guid.Parse(cbDepartmentInfo.SelectedValue.ToString()),

             Guid.Parse(cmbAuthority.SelectedValue.ToString()));



            employeeManager.Add(employee);
            MessageBox.Show("Personel Başarı İle Kaydedildi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
            if (mtxtTcInfo.Text == "")
            {
                MessageBox.Show("TC Kimlik Numarası Alanı Boş Geçilemez");
            }
            if (txtNameInfo.Text == "")
            {
                MessageBox.Show("Ad Alanı Boş Geçilemez");
            }
            if (txtSurnmaeInfo.Text == "")
            {
                MessageBox.Show("Soyad Alanı Boş Geçilemez");
            }
            if (cbDepartmentInfo.SelectedIndex == -1)
            {
                MessageBox.Show("Departman Seçiniz");
            }
            if (mtxtTel.Text == "")
            {
                MessageBox.Show("Telefon Alanı Boş Geçilemez");
            }

            if (mtxtMail.Text == "")
            {
                MessageBox.Show("Mail Alanı Boş Geçilemez");
            }
            if (rtbxAdressInfo.Text == "")
            {
                MessageBox.Show("Adres Alanı Boş Geçilemez");
            }

            EmployeeAdd();

            mtxtTcInfo.Text = "";
            txtNameInfo.Text = "";
            txtSurnmaeInfo.Text = "";
            cbDepartmentInfo.SelectedIndex = -1;
            cmbAuthority.SelectedIndex = -1;
            mtxtTel.Text = "";
            mtxtMail.Text = "";
            rtbxAdressInfo.Text = "";


        }
        void FillCbAuthority()
        {
            departmentList = departmentManager.GetAll();
            authorityList = authorityManager.GetAll();

            cbDepartmentInfo.DataSource = departmentList;
            cbDepartmentInfo.ValueMember = "DepartmentId";
            cbDepartmentInfo.DisplayMember = "DepartmentName";

            cmbAuthority.DataSource = authorityList;
            cmbAuthority.ValueMember = "AuthorityId";
            cmbAuthority.DisplayMember = "AuthorityName";



        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            FillCbAuthority();

        }
    }
}
