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
    public partial class HeadsetDeliveryForm : Form
    {

        Employee employee;
        HeadsetManager headsetManager;
        Headset headset;
        EmployeeManager employeeManager;
        public object[] infos;
        List<Employee> employees;
        public HeadsetDeliveryForm()
        {
            InitializeComponent();
            headsetManager = HeadsetManager.GetInstance();
            employeeManager = EmployeeManager.GetInstance();
        }
        void cbxFill()
        {

            employees = employeeManager.GetEmployeeMiniList();

            cbxDeliveryEmployee.DataSource = employees;
            cbxDeliveryEmployee.ValueMember = "Tc";
            cbxDeliveryEmployee.DisplayMember ="Name"+" "+"Surname";
            //$"{dataRow["NAME"].ToString()} {dataRow["SURNAME"].ToString()}")

        }

        private void btnHeadsetDelivery_Click(object sender, EventArgs e)
        {
            headset = new Headset(
             txtHeadsetSeriNo.Text.ToString(),
             infos[0].ToString(),
             cbxDeliveryEmployee.SelectedValue.ToString(),
             txtHeadsetInfo.Text.ToString(),
             Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")));

            headsetManager.Add(headset);
            MessageBox.Show("Kulaklık Başarı İle Teslim Edildi",
                "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void HeadsetDeliveryForm_Load(object sender, EventArgs e)
        {
            cbxFill();
        }
    }
}
