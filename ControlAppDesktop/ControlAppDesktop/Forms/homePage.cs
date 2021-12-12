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
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }
        void panelActiveVisible()
        {
            pnlActive.Visible = true;
        }
        private void btnSentry_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnSentry.Height;
            pnlActive.Top = btnSentry.Top;

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnInventory.Height;
            pnlActive.Top = btnInventory.Top;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnEmployee.Height;
            pnlActive.Top = btnEmployee.Top;
        }

        private void homePage_Load(object sender, EventArgs e)
        {
            pnlActive.Visible = false;
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnRequest.Height;
            pnlActive.Top = btnRequest.Top;

        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnMaintenance.Height;
            pnlActive.Top = btnMaintenance.Top;
        }

        private void btnHeadset_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnHeadset.Height;
            pnlActive.Top = btnHeadset.Top;
        }

        private void btnIdCard_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnIdCard.Height; ;
            pnlActive.Top = btnIdCard.Top;
        }

        private void btnDrawer_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnDrawer.Height; ;
            pnlActive.Top = btnDrawer.Top;
        }

        private void btnCabinet_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnCabinet.Height; ;
            pnlActive.Top = btnCabinet.Top;
        }

        private void btnGuestCard_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnGuestCard.Height; ;
            pnlActive.Top = btnGuestCard.Top;
           
        }

        private void btnGenarator_Click(object sender, EventArgs e)
        {
            borderClear();
            panelActiveVisible();
            pnlActive.Height = btnGenarator.Height; ;
            pnlActive.Top = btnGenarator.Top;
            btnDirectory.FlatAppearance.BorderSize = 1;
            btnDirectory.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;

        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnDirectory.Height; ;
            pnlActive.Top = btnDirectory.Top;
            btnDirectory.FlatAppearance.BorderSize = 1;
            btnDirectory.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
        }
        void borderClear()
        {
            if (btnDirectory.FlatAppearance.BorderSize == 1)
            {
                btnDirectory.FlatAppearance.BorderSize = 0;

            }
            if (btnGenarator.FlatAppearance.BorderSize == 1)
            {
                btnGenarator.FlatAppearance.BorderSize = 0;

            }
            if (btnGuestCard.FlatAppearance.BorderSize == 1)
            {
                btnGuestCard.FlatAppearance.BorderSize = 0;

            }
            if (btnCabinet.FlatAppearance.BorderSize == 1)
            {
                btnCabinet.FlatAppearance.BorderSize = 0;

            }
            if (btnDrawer.FlatAppearance.BorderSize == 1)
            {
                btnDrawer.FlatAppearance.BorderSize = 0;

            }
            if (btnIdCard.FlatAppearance.BorderSize == 1)
            {
                btnIdCard.FlatAppearance.BorderSize = 0;

            }
            if (btnHeadset.FlatAppearance.BorderSize == 1)
            {
                btnHeadset.FlatAppearance.BorderSize = 0;

            }
            if (btnMaintenance.FlatAppearance.BorderSize == 1)
            {
                btnMaintenance.FlatAppearance.BorderSize = 0;

            }
            if (btnRequest.FlatAppearance.BorderSize == 1)
            {
                btnRequest.FlatAppearance.BorderSize = 0;

            }
            if (btnEmployee.FlatAppearance.BorderSize == 1)
            {
                btnEmployee.FlatAppearance.BorderSize = 0;

            }
            if (btnInventory.FlatAppearance.BorderSize == 1)
            {
                btnInventory.FlatAppearance.BorderSize = 0;

            }
            if (btnSentry.FlatAppearance.BorderSize == 1)
            {
                btnSentry.FlatAppearance.BorderSize = 0;

            }



        }
    }
}
