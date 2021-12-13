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
    public partial class Request : Form
    {
        RequestDetailManager requestDetailManager;
        public object[] infos;
        string tc;
        public Request()
        {
            InitializeComponent();
            requestDetailManager = RequestDetailManager.GetInstance();
        }
        void Fillİnfos()
        {
            tc = infos[0].ToString();
            lblDepartmentInfo.Text = infos[3].ToString();
            lblNameInfo.Text = infos[1].ToString();
            lblSurnameInfo.Text = infos[2].ToString();
            lblTcInfo.Text = tc;

        }
        void RequestList()
        {

            dgvRequest.DataSource = requestDetailManager.GetAll(tc);

        }
        private void Request_Load(object sender, EventArgs e)
        {
            Fillİnfos();
            tlblTime.Text = DateTime.Now.ToString("f");
            RequestList();
        }
    }
}
