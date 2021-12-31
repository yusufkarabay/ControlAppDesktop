using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ControlAppDesktop.Forms
{
    public partial class HomePage : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse
      );
        public object[] infos;
        public HomePage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int Iparam);
        void panelActiveVisible()
        {
            pnlActive.Visible = true;
        }
        private void homePage_Load(object sender, EventArgs e)
        {
            pnlActive.Visible = false;
            lblTime.Text = DateTime.Now.ToString("f");
            btnUserName.Text = infos[1] + " " + infos[2].ToString();
        }
        private void btnSentry_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnSentry.Height;
            pnlActive.Top = btnSentry.Top;
        
            
            SentryForm sentryForm = new SentryForm();
            sentryForm.infos = infos;
            sentryForm.Show();


            //borderColored(sender);

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnInventory.Height;
            pnlActive.Top = btnInventory.Top;

            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.infos = infos;
            inventoryForm.Show(); 
            // borderColored(sender);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnEmployee.Height;
            pnlActive.Top = btnEmployee.Top;
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.infos = infos;
            employeeForm.Show();
            // borderColored(sender);
        }
        private void btnRequest_Click(object sender, EventArgs e)
        {
            panelActiveVisible();
            pnlActive.Height = btnRequest.Height;
            pnlActive.Top = btnRequest.Top;
            RequestForm request = new RequestForm();
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
            HeadsetForm headsetForm = new HeadsetForm();
            headsetForm.Show();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlTopMenu_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
