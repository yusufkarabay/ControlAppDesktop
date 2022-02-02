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
    public partial class PasswordForgotForm : Form
    {
        public PasswordForgotForm()
        {
            InitializeComponent();
        }

        private void btnCheckCode_Click(object sender, EventArgs e)
        {
            MailCheckedCodeForm form = new MailCheckedCodeForm();
            form.Show();
        }
    }
}
