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
using Business;

namespace ControlAppDesktop.Forms
{
    public partial class CabinetDeliveryForm : Form
    {
        public object[] infos;
        CabinetManager cabinetManager;
        EmployeeManager employeeManager;
        List<Employee> employees;
        Cabinet cabinet;
        public CabinetDeliveryForm()
        {
            InitializeComponent();
            employeeManager = EmployeeManager.GetInstance();
            cabinetManager = CabinetManager.GetInstance();
        }
        void cbxFill()
        {
            employees = employeeManager.GetEmployeeMiniList();
            cbxDeliveryEmployee.DataSource = employees;
            cbxDeliveryEmployee.ValueMember = "Tc";
            cbxDeliveryEmployee.DisplayMember = "FullName";
        }

        private void btnCabinetDelivery_Click(object sender, EventArgs e)
        {
            cabinet = new Cabinet(
       txtCabinetNo.Text.ToString(),
       cbxDeliveryEmployee.SelectedValue.ToString(),
       infos[0].ToString(),
       Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")));
            MessageBox.Show(cabinetManager.Add(cabinet));
            this.Close();
        }

        private void CabinetDeliveryForm_Load(object sender, EventArgs e)
        {
            cbxFill();
            cbxDeliveryEmployee.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
