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
    public partial class SentryForm : Form
    {
        SentryDoneManager sentryDoneManager;
        DepartmentManager departmentManager;
        Employee employee;


        public SentryForm()
        {
            InitializeComponent();
            departmentManager = DepartmentManager.GetInstance();
            sentryDoneManager=SentryDoneManager.GetInstance();
        }

        private void btnSentryListDone_Click(object sender, EventArgs e)
        {
            dgvSentry.DataSource = sentryDoneManager.GetSetryByDate("SentryDoneGetByDate", dateTimePicker1.Value);
        }
    }
}
