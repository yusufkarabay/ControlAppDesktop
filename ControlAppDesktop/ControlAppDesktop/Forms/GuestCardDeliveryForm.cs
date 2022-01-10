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
    public partial class GuestCardDeliveryForm : Form
    {
        public object[] infos;
        GuestCardManager guestCardManager;
        EmployeeManager employeeManager;
        List<Employee> employees;
        GuestCard guestCard;
        public GuestCardDeliveryForm()
        {
            InitializeComponent();
            employeeManager = EmployeeManager.GetInstance();
            guestCardManager = GuestCardManager.GetInstance();
        }
        void cbxFill()
        {
            employees = employeeManager.GetEmployeeMiniList();
            cbxDeliveryEmployee.DataSource = employees;
            cbxDeliveryEmployee.ValueMember = "Tc";
            cbxDeliveryEmployee.DisplayMember = "FullName";
        }

        private void btnGuestCardDelivery_Click(object sender, EventArgs e)
        {
             guestCard = new GuestCard(
           txtGuestCardNo.Text.ToString(),
          cbxDeliveryEmployee.SelectedValue.ToString(),
           infos[0].ToString(),
          Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")));
            MessageBox.Show(guestCardManager.Add(guestCard));
            this.Close();
        }

        private void GuestCardDeliveryForm_Load(object sender, EventArgs e)
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
