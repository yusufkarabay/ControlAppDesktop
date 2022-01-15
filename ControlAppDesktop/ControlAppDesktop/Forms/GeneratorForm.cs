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
        FuelManager fuelManager;
        Fuel fuel;
        public GeneratorForm()
        {
            InitializeComponent();
            generatorManager = GeneratorManager.GetInstance();
            fuelManager=FuelManager.GetInstance();  
        }
        void lastFuelTime()
        {            
              lblLastFullTimeInfo.Text = fuelManager.GetLastTime();
        }
        void lastFuelEmployee()
        {
            lblLastFullEmployeeInfo.Text = fuelManager.GetLastEmployee();   
        }
        void alWorkedTimeList()
        {
            lblAllWorkedTimeInfo.Text = generatorManager.AllWorkedTime();
        }
        void betweenTimeList()
        {
            lblListByTwoTimeInfo.Text = generatorManager.BetweemTimeList("GeneratorBetweenTimeWorked", dtpFirst.Value, dtpSecond.Value).ToString();
        }
        void LastWorkedToFuel()
        {
            lblLastWorkedInfo.Text = generatorManager.BetweemTimeList("GeneratorBetweenTimeWorked", DateTime.Parse(lblLastFullTimeInfo.Text.ToString())
                , DateTime.Parse(DateTime.Now.ToString()));
        
        }
        void lastThreeMonthWorkedTime()
        {
            lblThreeMonthInfo.Text = generatorManager.LastThreeMonthWorkedTime();
        }
        void lastSixMonthWorkedTime()
        {
            lblSixMonthInfo.Text = generatorManager.LastSixMonthWorkedTime();
        }
        void lastYearWorkedTime()
        {
            lblLastYearInfo.Text = generatorManager.LastYearWorkedTime();
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
            alWorkedTimeList();
            lastSixMonthWorkedTime();
            lastThreeMonthWorkedTime();
            LastWorkedToFuel();
            txtWorkedTime.Text = "";

        }

        private void GeneratorForm_Load(object sender, EventArgs e)
        {
            alWorkedTimeList();
            lastYearWorkedTime();      
            lastSixMonthWorkedTime();
            lastThreeMonthWorkedTime();

            lastFuelTime();
            lastFuelEmployee();


            LastWorkedToFuel();

        }

      

        private void btnTimeSearch_Click(object sender, EventArgs e)
        {
            betweenTimeList();
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
               fuel = new Fuel
                (DateTime.Parse(DateTime.Now.ToString()),
                infos[0].ToString());
             MessageBox.Show(fuelManager.Add(fuel));

            lastFuelTime();
            lastFuelEmployee();
            LastWorkedToFuel();
        }
    }
}
