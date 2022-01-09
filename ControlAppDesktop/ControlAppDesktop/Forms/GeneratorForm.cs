using Business;
using Business.Concrete;
using DataAccess.Concrete;
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
    public partial class GeneratorForm : Form
    {
        public object[] infos;
        GeneratorManager generatorManager;
        Generator generator;
        public GeneratorForm()
        {
            InitializeComponent();
            generatorManager = GeneratorManager.GetInstance();
        }
        void alWorkedTimeList()
        {
            lblAllWorkedTimeInfo.Text = generatorManager.AllWorkedTime();
        }
        void betweenTimeList()
        {
            lblListByTwoTimeInfo.Text = generatorManager.BetweemTimeList("GeneratorBetweenTimeWorked", dtpFirst.Value, dtpSecond.Value).ToString();
        }
        void betweenTimeListDataGrid()
        {

        }

        private void btnAllTime_Click(object sender, EventArgs e)
        {
            alWorkedTimeList();
        }

        private void btnAddWorkedTime_Click(object sender, EventArgs e)
        {
            generator = new Generator(
                Int32.Parse(txtWorkedTime.Text.ToString()),
                infos[0].ToString(),
                DateTime.Parse(DateTime.Now.ToString()));
            MessageBox.Show(generatorManager.Add(generator));

            txtWorkedTime.Text = "";

        }

        private void GeneratorForm_Load(object sender, EventArgs e)
        {
            alWorkedTimeList();
        }

        private void btnEmployeeList_Click(object sender, EventArgs e)
        {

        }

        private void btnTimeSearch_Click(object sender, EventArgs e)
        {
            betweenTimeList();
        }
    }
}
