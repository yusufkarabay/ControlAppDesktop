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
        void FormGet(Form form)
        {
            form.MdiParent = this;
            pnlCenter.Controls.Add(form);
            form.Show();
        }
        void LeftWhitePanel(Button button)
        {
            pnlActive.Visible = true;
            pnlActive.Height = button.Height;
            pnlActive.Top = button.Top;
        }
        private void btnSentry_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnSentry);
            pnlCenter.Controls.Clear();
            SentryForm sentryForm = new SentryForm();
            sentryForm.infos = infos;
            FormGet(sentryForm);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

            LeftWhitePanel(btnInventory);
            pnlCenter.Controls.Clear();
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.infos = infos;
            FormGet(inventoryForm);


        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {

            LeftWhitePanel(btnEmployee);
            pnlCenter.Controls.Clear();
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.infos = infos;
            FormGet(employeeForm);

        }
        private void btnRequest_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnRequest);
            pnlCenter.Controls.Clear();
            RequestForm requestForm = new RequestForm();
            requestForm.infos = infos;
            FormGet(requestForm);

        }
        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnMaintenance);
            pnlCenter.Controls.Clear();
            MaintenanceForm maintenanceForm = new MaintenanceForm();
            maintenanceForm.infos = infos;
            FormGet(maintenanceForm);

        }

        private void btnHeadset_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnHeadset);
            pnlCenter.Controls.Clear();
            HeadsetForm headsetForm = new HeadsetForm();
            headsetForm.infos = infos;
            FormGet(headsetForm);

        }

        private void btnIdCard_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnIdCard);
            pnlCenter.Controls.Clear();
            EntranceCardForm entranceCardForm = new EntranceCardForm();
            entranceCardForm.infos = infos;
            FormGet(entranceCardForm);

        }

        private void btnDrawer_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnDrawer);
            pnlCenter.Controls.Clear();

            DrawerForm drawerForm = new DrawerForm();
            drawerForm.infos = infos;
            FormGet(drawerForm);
            // borderColored(sender);
        }

        private void btnCabinet_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnCabinet);
            pnlCenter.Controls.Clear();
            CabinetForm cabinetForm = new CabinetForm();
            cabinetForm.infos = infos;
            FormGet(cabinetForm);
        }

        private void btnGuestCard_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnGuestCard);
            pnlCenter.Controls.Clear();
            GuestCardForm guestCardForm = new GuestCardForm();
            guestCardForm.infos = infos;
            FormGet(guestCardForm);


        }

        private void btnGenarator_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnGenarator);
            pnlCenter.Controls.Clear();
            GeneratorForm generatorForm = new GeneratorForm();
            generatorForm.infos = infos;
            FormGet(generatorForm);
         
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnDirectory);
            pnlCenter.Controls.Clear();
            DirectoryForm directoryForm = new DirectoryForm();
            directoryForm.infos = infos;
            FormGet(directoryForm);


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

        private void pbMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
