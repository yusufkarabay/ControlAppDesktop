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
    public partial class RequestCreateForm : Form
    {
        public object[] infos;
        DepartmentManager departmentManager;
        Department department;
        List<Department> departments;
        RequestManager requestManager;
        Request request;
        public RequestCreateForm()
        {
            InitializeComponent();
            departmentManager = DepartmentManager.GetInstance();
            requestManager = RequestManager.GetInstance();  
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

        }
        void requestAdd()
        {
            if (txtRequestTitle.Text == "")
            {
                MessageBox.Show("Talep Konusu Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else  if (rtxtRequestContext.Text == "")
            {
                MessageBox.Show("Talep İçeriği Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //else if (cbDepartment.SelectedItem == null)
            //{
            //    MessageBox.Show("Talep Edilecek Departman Boş Bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            else
            {
                request = new Request(
                    txtRequestTitle.Text.ToString(),
                    rtxtRequestContext.Text.ToString(),
                    DateTime.Parse(DateTime.Now.ToString()));

                requestManager.Add(request);
                MessageBox.Show("Talep Başarı İle Kaydedildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void RequestCreateForm_Load(object sender, EventArgs e)
        {
            cbFill();
        }

        private void btnRequestCreate_Click(object sender, EventArgs e)
        {
            requestAdd();
        }
    }
}
