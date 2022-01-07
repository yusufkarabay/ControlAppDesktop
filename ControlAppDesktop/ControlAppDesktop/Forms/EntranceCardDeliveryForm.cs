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
    public partial class EntranceCardDeliveryForm : Form
    {
        public object[] infos;
        EntranceCardManager entranceCardManager;
        EntranceCard entranceCard;
        EmployeeManager employeeManager;
        List<Employee> employees;   
            
        public EntranceCardDeliveryForm()
        {
            InitializeComponent();
            entranceCardManager = EntranceCardManager.GetInstance();
            employeeManager = EmployeeManager.GetInstance();

        }
        void cbxFill()
        {
            employees = employeeManager.GetEmployeeMiniList();
            cbxDeliveryEmployee.DataSource = employees;
            cbxDeliveryEmployee.ValueMember = "Tc";
            cbxDeliveryEmployee.DisplayMember = "FullName";
        }

        private void btnHeadsetDelivery_Click(object sender, EventArgs e)
        {
            entranceCard= new EntranceCard(
                txtEntranceCardSeriNo.Text.ToString(),
                infos[0].ToString(),
                cbxDeliveryEmployee.SelectedValue.ToString(),
                Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd")));
            MessageBox.Show(entranceCardManager.Add(entranceCard));
            this.Close();
        }

        private void EntranceCardDeliveryForm_Load(object sender, EventArgs e)
        {
            cbxFill();
            cbxDeliveryEmployee.SelectedIndex = -1;
        }
    }
}
