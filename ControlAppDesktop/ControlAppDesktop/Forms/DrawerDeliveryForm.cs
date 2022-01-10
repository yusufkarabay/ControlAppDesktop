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
    public partial class DrawerDeliveryForm : Form
    {
        public object[] infos;
        DrawerManager drawerManager;
        EmployeeManager employeeManager;
        List<Employee> employees;
        Drawer drawer;

        public DrawerDeliveryForm()
        {
            InitializeComponent();
            employeeManager = EmployeeManager.GetInstance();
            drawerManager = DrawerManager.GetInstance();
        }
        void cbxFill()
        {
            employees = employeeManager.GetEmployeeMiniList();
            cbxDeliveryEmployee.DataSource = employees;
            cbxDeliveryEmployee.ValueMember = "Tc";
            cbxDeliveryEmployee.DisplayMember = "FullName";
        }

        private void DrawerDeliveryForm_Load(object sender, EventArgs e)
        {
            cbxFill();
            cbxDeliveryEmployee.SelectedIndex = -1;
        }

        private void btnDrawerDelivery_Click(object sender, EventArgs e)
        {
            drawer = new Drawer(
         txtDrawerNo.Text.ToString(),
         cbxDeliveryEmployee.SelectedValue.ToString(),
         infos[0].ToString(),
         Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")));
            MessageBox.Show(drawerManager.Add(drawer));
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
