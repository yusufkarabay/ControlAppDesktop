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
    public partial class EmployeePassiveForm : Form
    {
        EmployeeManager employeeManager;
        DepartmentManager departmentManager;
        public object[] infos;
        Employee employee;
        List<Department> departmentList;
        public EmployeePassiveForm()
        {
            InitializeComponent();
            employeeManager = EmployeeManager.GetInstance();
            departmentManager = DepartmentManager.GetInstance();
        }
        void GridDisplay()
        {
            if (dgvEmployee.Rows.Count > 0)
            {
                dgvEmployee.Columns[0].Visible = false;
                dgvEmployee.Columns[1].Visible = false;
                dgvEmployee.Columns[2].Visible = false;
                dgvEmployee.Columns[3].Visible = false;
                dgvEmployee.Columns[15].Visible = false;
                dgvEmployee.Columns[13].Visible = false;
                dgvEmployee.Columns[14].Visible = false;
                dgvEmployee.Columns[15].Visible = false;
                dgvEmployee.Columns[16].Visible = false;
                dgvEmployee.Columns[17].Visible = false;
                dgvEmployee.Columns[18].Visible = false;
                dgvEmployee.Columns[19].Visible = false;
                dgvEmployee.Columns[20].Visible = false;

                dgvEmployee.Columns[4].HeaderText = "T.C. Kimlik No";
                dgvEmployee.Columns[5].HeaderText = "Ad";
                dgvEmployee.Columns[6].HeaderText = "Soyad";
                dgvEmployee.Columns[7].HeaderText = "Doğum Tarihi";
                dgvEmployee.Columns[8].HeaderText = "Adres";
                dgvEmployee.Columns[9].HeaderText = "Telefon";
                dgvEmployee.Columns[10].HeaderText = "Mail";
                dgvEmployee.Columns[11].HeaderText = "Departman";
                dgvEmployee.Columns[12].HeaderText = "Yetki";
            }


        }
        void employeePassiveList()
        {
            dgvEmployee.DataSource = employeeManager.EmployeePassiveList();
            if (dgvEmployee.Rows.Count > 0)
            {
                dgvEmployee.Rows[0].Selected = true;
            }
            GridDisplay();
        }

        //**** tekrar aktif yap güncellemesi hazırla
        void returnActiveEmployee()
        {
            employee = new Employee(
                    dgvEmployee.CurrentRow.Cells[4].Value.ToString(),
                    Convert.ToBoolean(dgvEmployee.CurrentRow.Cells[20].Value = true),
                    infos[0].ToString());
            MessageBox.Show(employeeManager.PassiveEmployeeToActive(employee));
        }
        void fillInfos()
        {
            lblTcInfo.Text = employee.Tc;
            lblNameInfo.Text = employee.Name; ;
            lblSurnameInfo.Text = employee.Surname;
            lblDepartmentInfo.Text = employee.DepartmentName;
            lblBdateInfo.Text = employee.Bdate.ToString();
            lblTelInfo.Text = employee.Tel;
            lblMailInfo.Text = employee.Mail;
        }
        //void deleteEmployee()
        //{
        //       employee = new Employee(
        //       Guid.Parse(dgvEmployee.CurrentRow.Cells["Id"].Value.ToString()),
        //       dgvEmployee.CurrentRow.Cells["Tc"].Value.ToString(),
        //       dgvEmployee.CurrentRow.Cells["Name"].Value.ToString(),
        //       dgvEmployee.CurrentRow.Cells["Surname"].Value.ToString(),
        //       DateTime.Parse(dgvEmployee.CurrentRow.Cells["Bdate"].Value.ToString()),
        //       dgvEmployee.CurrentRow.Cells["Adress"].Value.ToString(),
        //       dgvEmployee.CurrentRow.Cells["Tel"].Value.ToString(),
        //       dgvEmployee.CurrentRow.Cells["Mail"].Value.ToString(),
        //       dgvEmployee.CurrentRow.Cells["DepartmentName"].Value.ToString(),
        //       Guid.Parse(dgvEmployee.CurrentRow.Cells["DepartmentId"].Value.ToString()),
        //       Guid.Parse(dgvEmployee.CurrentRow.Cells["AuthorityId"].Value.ToString()));



        //    DialogResult dialogResult = MessageBox.Show("Seçili İş Silmek İstediğinize Emin Misiniz?",
        //                     "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (dialogResult == DialogResult.Yes)
        //    {
        //        MessageBox.Show(employeeManager.Delete(employee.Id));

        //    }

        //}
        void FillCbDepartment()
        {
            departmentList = departmentManager.GetAll();

            cbDepartment.DataSource = departmentList;

            cbDepartment.ValueMember = "DepartmentId";
            cbDepartment.DisplayMember = "DepartmentName";
            cbDepartment.SelectedIndex = -1;
        }
        //**** silinmiş personellere göre prosedür yaz
        void getEmployeeByTc()
        {
            dgvEmployee.DataSource = employeeManager.GetByTc("PassiveEmployeeListByTc", txtbxSearchEmloyee.Text);
        }
        void getEmployeeByName()
        {
            dgvEmployee.DataSource = employeeManager.GetByName("PassiveEmployeeListByName", txtbxSearchEmloyee.Text);
        }
        void getEmployeeBySurname()
        {
            dgvEmployee.DataSource = employeeManager.GetBySurname("PassiveEmployeeListBySurname", txtbxSearchEmloyee.Text);
        }
        void getEmployeeByDepartment()
        {
            dgvEmployee.DataSource = employeeManager.GetByDepartment("PassiveEmployeeListByDepartment", cbDepartment.SelectedValue.ToString());
        }
        void getEmployyeByMail()
        {
            dgvEmployee.DataSource = employeeManager.GetByMail("PassiveEmployeeListByMail", txtbxSearchEmloyee.Text);
        }
        void getEmployyeByTel()
        {
            dgvEmployee.DataSource = employeeManager.GetByTel("PassiveEmployeeListByTel", txtbxSearchEmloyee.Text);
        }
        private void EmployeePassiveForm_Load(object sender, EventArgs e)
        {
            cbDepartment.Visible = false;
            employeePassiveList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            employeePassiveList();
        }
      
        private void returnActiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows == null)
            {
                MessageBox.Show("Aktif Edilecek Personeli Seçiniz");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(employee.Name + "" + employee.Surname + " Personeli İçin Aktif Etmek İstediğinize Emin Misiniz?",
                              "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    returnActiveEmployee();
                    employeePassiveList();
                }


            }
        }

        private void dgvEmployee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvEmployee.CurrentRow == null)
            {
                MessageBox.Show("Listeden Personel Seçiniz");
                return;
            }
            employee = new Employee(
            dgvEmployee.CurrentRow.Cells["Id"].Value.ConGuidToString(),
            dgvEmployee.CurrentRow.Cells["Tc"].Value.ToString(),
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
            fillInfos();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            employeePassiveList();
        }

        private void rbTc_CheckedChanged(object sender, EventArgs e)
        {
            if (txtbxSearchEmloyee.Visible == false)
            {
                txtbxSearchEmloyee.Visible = true;
            }
            if (cbDepartment.Visible == true)
            {
                cbDepartment.Visible = false;
            }


            txtbxSearchEmloyee.Text = "TC Giriniz...";
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            if (txtbxSearchEmloyee.Visible == false)
            {
                txtbxSearchEmloyee.Visible = true;
            }
            if (cbDepartment.Visible == true)
            {
                cbDepartment.Visible = false;
            }

            txtbxSearchEmloyee.Text = "Personel Adı Giriniz...";
        }

        private void rbSurname_CheckedChanged(object sender, EventArgs e)
        {
            if (txtbxSearchEmloyee.Visible == false)
            {
                txtbxSearchEmloyee.Visible = true;
            }
            if (cbDepartment.Visible == true)
            {
                cbDepartment.Visible = false;
            }

            txtbxSearchEmloyee.Text = "Personel Soyadı Giriniz...";
        }

        private void rbDepartment_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDepartment.Visible == false)
            {
                cbDepartment.Visible = true;
            }
            if (txtbxSearchEmloyee.Visible == true)
            {
                txtbxSearchEmloyee.Visible = false;
            }
            FillCbDepartment();
        }

        private void rbTel_CheckedChanged(object sender, EventArgs e)
        {
            if (txtbxSearchEmloyee.Visible == false)
            {
                txtbxSearchEmloyee.Visible = true;
            }
            if (cbDepartment.Visible == true)
            {
                cbDepartment.Visible = false;
            }

            txtbxSearchEmloyee.Text = "Personele Ait Telefon Numarası Giriniz...";
        }

        private void rbMail_CheckedChanged(object sender, EventArgs e)
        {

            if (txtbxSearchEmloyee.Visible == false)
            {
                txtbxSearchEmloyee.Visible = true;
            }
            if (cbDepartment.Visible == true)
            {
                cbDepartment.Visible = false;
            }

            txtbxSearchEmloyee.Text = "Personele Ait Mail Adresi Giriniz...";
        }

        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {

            if (rbTc.Checked == false & rbName.Checked == false &
                rbSurname.Checked == false & rbDepartment.Checked == false
                & rbTel.Checked == false & rbMail.Checked == false)
            {
                MessageBox.Show("Lütfen Bir Arama Kriteri Seçiniz");
            }
             if (rbTc.Checked == true)
            {
                
                
                getEmployeeByTc();

                if (dgvEmployee.RowCount < 1)
                {
                    MessageBox.Show("Girilin TC Kimlik Numarasına Göre Personel Bulunamadı...");
                    return;
                }
            }
             if (rbName.Checked == true)
            {
                getEmployeeByName();
                if (dgvEmployee.Rows.Count < 1)
                {
                    MessageBox.Show("Girilin Ada Göre Personel Bulunamadı...");
                    return;
                }
            }
             if (rbSurname.Checked == true)
            {
                getEmployeeBySurname();
                if (dgvEmployee.Rows.Count < 1)
                {
                    MessageBox.Show("Girilin Ada Göre Personel Bulunamadı...");
                    return;
                }
            }
             if (rbDepartment.Checked == true)
            {
                if (cbDepartment.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen Departman Seçiniz", "Uyarı", MessageBoxButtons.OK);
                    return;
                }
                getEmployeeByDepartment();
                if (dgvEmployee.Rows.Count < 1)
                {
                    MessageBox.Show("Seçilen Departmanda Çalışan  Personel Bulunamadı...");
                    return;
                }
            }
             if (rbTel.Checked == true)
            {
                getEmployyeByTel();
                if (dgvEmployee.Rows.Count < 1)
                {
                    MessageBox.Show("Girilin Telefon Numarasına Göre Personel Bulunamadı...");
                    return;
                }
            }
             if (rbMail.Checked == true)
            {
                getEmployyeByMail();
                if (dgvEmployee.Rows.Count < 1)
                {
                    MessageBox.Show("Girilin Mail Adresine Göre Personel Bulunamadı...");
                    return;
                }
            }
            GridDisplay();
        }

        private void txtbxSearchEmloyee_MouseClick(object sender, MouseEventArgs e)
        {
            txtbxSearchEmloyee.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
