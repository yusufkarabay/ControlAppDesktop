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
        public object[] infos;
        Employee employee;
        List<Department> departmentList;
        public AddEmployeeForm()
        {
            InitializeComponent();
            employeeManager = EmployeeManager.GetInstance();
            departmentManager = DepartmentManager.GetInstance();
        }
        void EmployeeAdd()
        {
            employee = new Employee(mtxtTcInfo.Text.ToString(),
                txtNameInfo.Text.ToString(),
                txtSurnmaeInfo.Text.ToString(),
                DateTime.Parse(dtpEmployeeBDate.Value.ToString("yyyy-MM-dd")),
                 rtbxAdressInfo.Text.ToString(),
                  mtxtTel.Text.ToString(),
                  mtxtMail.Text.ToString(),
                cbAuthorityInfo.SelectedValue.ToString());
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
            if (cbAuthorityInfo.SelectedIndex == -1)
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
            else
            {
                EmployeeAdd();
            }
            mtxtTcInfo.Text = "";
            txtNameInfo.Text = "";
            txtSurnmaeInfo.Text = "";
            cbAuthorityInfo.SelectedIndex = 0;
            mtxtTel.Text = "";
            mtxtMail.Text = "";
            rtbxAdressInfo.Text = "";


        }
        void FillCbAuthority()
        {
            departmentList = departmentManager.GetAll();
            cbAuthorityInfo.DataSource = departmentList;
            cbAuthorityInfo.ValueMember = "DepartmentId";
            cbAuthorityInfo.DisplayMember = "DepartmentName";
           

        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            FillCbAuthority();

        }
    }
}
