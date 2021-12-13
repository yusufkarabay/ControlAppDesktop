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
    public partial class HomePage : Form
    {
        public object[] infos;
        public HomePage()
        {
            InitializeComponent();
        }
        void panelActiveVisible()
        {
            pnlActive.Visible = true;
        }
        private void homePage_Load(object sender, EventArgs e)
        {
            pnlActive.Visible = false;
            lblTime.Text = DateTime.Now.ToString("f");
            btnUserName.Text=infos[1]+ " "+ infos[2].ToString();
        }
        private void btnSentry_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnSentry.Height;
            pnlActive.Top = btnSentry.Top;
            
            
            //borderColored(sender);

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnInventory.Height;
            pnlActive.Top = btnInventory.Top;
           // borderColored(sender);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnEmployee.Height;
            pnlActive.Top = btnEmployee.Top;
           // borderColored(sender);
        }
        private void btnRequest_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnRequest.Height;
            pnlActive.Top = btnRequest.Top;
            Request request = new Request();
            request.infos = infos;
            request.Show();
            // borderColored(sender);
        }
        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnMaintenance.Height;
            pnlActive.Top = btnMaintenance.Top;
          //  borderColored(sender);
        }

        private void btnHeadset_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnHeadset.Height;
            pnlActive.Top = btnHeadset.Top;
           // borderColored(sender);
        }

        private void btnIdCard_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnIdCard.Height; ;
            pnlActive.Top = btnIdCard.Top;
          //  borderColored(sender);
        }

        private void btnDrawer_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnDrawer.Height; ;
            pnlActive.Top = btnDrawer.Top;
           // borderColored(sender);
        }

        private void btnCabinet_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnCabinet.Height; ;
            pnlActive.Top = btnCabinet.Top;
            //borderColored(sender);
        }

        private void btnGuestCard_Click(object sender, EventArgs e)
        {
            borderColored(sender);
            panelActiveVisible();
            pnlActive.Height = btnGuestCard.Height; ;
            pnlActive.Top = btnGuestCard.Top;

        }

        private void btnGenarator_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnGenarator.Height; ;
            pnlActive.Top = btnGenarator.Top;
           // borderColored(sender);
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnDirectory.Height; ;
            pnlActive.Top = btnDirectory.Top;
           // borderColored(sender);
           
        }
        void borderColored(object sender)
        {
            Button btn = sender as Button;

            if (btn.FlatAppearance.BorderSize == 0)
            {
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            }
        }
        void borderClear(object sender)
        {
            Button btn = sender as Button;

            if (btn.FlatAppearance.BorderSize == 1)
            {
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.BorderColor = System.Drawing.Color.Transparent;

            }
        }

       
    }
}
