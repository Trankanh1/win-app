using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace QuanLyBanHang.Forms
{
    public partial class Frmtrogiup : Form
    {
        public Frmtrogiup()
        {
            InitializeComponent();
        }

        private void Frmtrogiup_Load(object sender, EventArgs e)
        {
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_Click_1(object sender, EventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
          
            System.Diagnostics.Process.Start("https://sites.google.com/site/phanmenqanlybanhangkanhhvnh/");
            //try
            //{
            //    MailMessage mail = new MailMessage();
            //    SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            //    mail.From = new MailAddress(txttu.Text);
            //    mail.To.Add(txtden.Text);
            //    mail.Subject = (txttieude.Text == "") ? "No subject" : txttieude.Text;
            //    mail.Body = txtnoidung.Text;
            //    smtpServer.Port = 587;
            //    smtpServer.Credentials = new NetworkCredential(txttu.Text.Trim(), txtmatkhau.Text.Trim());
            //    smtpServer.EnableSsl = true;
            //    smtpServer.Send(mail);
            //    MessageBox.Show("Gửi email thành công đến: " + txtden.Text);
            //}
            //catch
            //{
            //    MessageBox.Show("Lổi xảy ra trong quá trình gửi mail");
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
