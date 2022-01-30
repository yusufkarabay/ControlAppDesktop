using Business.Concrete;
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
    public partial class MailCheckedCodeForm : Form
    {
        EmployeeManager employeeManager;
        public MailCheckedCodeForm()
        {
            InitializeComponent();
            employeeManager = EmployeeManager.GetInstance();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
           employeeManager.MailCheck("MailCheck", txtMail.Text.ToString());
            
            
        }
    }
}
