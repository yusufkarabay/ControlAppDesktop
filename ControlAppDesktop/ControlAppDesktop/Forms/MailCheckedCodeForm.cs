using Business.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlAppDesktop.Forms
{
    public partial class MailCheckedCodeForm : Form
    {
        EmployeeManager employeeManager;
        Employee employee;
        public static string checkCode;
        public MailCheckedCodeForm()
        {
            InitializeComponent();
            employeeManager = EmployeeManager.GetInstance();
        }
        string CreateCode()
        {
            Random random = new Random();
            string letters = "ABCDEFGHIJKLMNOPRSTUVYZWX";
            checkCode = "";
            for (int i = 0; i < 6; i++)
            {
                checkCode += letters[random.Next(letters.Length)];
            }
            return checkCode;
        }

        private void btnSend_Click(object sender, EventArgs e)

        {
            if (txtMail.Text == "")
            {
                MessageBox.Show("Mail Adresi Boş Geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTC.Text == "")
            {
                MessageBox.Show("Kimlik Numarası Boş Geçilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Employee checkEmployee = new Employee();
            checkEmployee = employeeManager.MailCheck("MailCheck", txtMail.Text.ToString(), txtTC.Text.ToString());
            if (checkEmployee == null)
            {
                MessageBox.Show("Böyle Bir Personel Bulunamadı");
                return;
            }
            CreateCode();



            MailSend();


        }
        bool MailSend()
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("duzce112tekniktakip@gmail.com", "ControlApp");

            ePosta.To.Add(txtMail.Text);


            ePosta.Subject = "ControlApp-Onay Kodu ";

            ePosta.Body = "ControlApp Şifremi Değişikliği İçin Onay Kodu  " + checkCode + "  || Lütfen Bu İletiyi Cevaplamayınız";

            SmtpClient smtp = new SmtpClient();

            smtp.Credentials = new System.Net.NetworkCredential("duzce112tekniktakip@gmail.com", "duzce112");


            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;

            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;

        }
        private void MailCheckedCodeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
