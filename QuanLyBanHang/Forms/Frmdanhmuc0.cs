using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class Frmdanhmuc0 : Form
    {
        public Frmdanhmuc0()
        {
            InitializeComponent();
        }

        private void btnhdnhap_Click(object sender, EventArgs e)
        {
            Forms.Frmnhanvien f = new Frmnhanvien();
            f.ShowDialog();
        }

        private void btnhdxuat_Click(object sender, EventArgs e)
        {
            Forms.Frmkhachhang f =new Frmkhachhang();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.Frmhanghoa f = new Frmhanghoa();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.Frmmauhang f = new Frmmauhang();
            f.ShowDialog();
        }

        private void button3_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forms.Frmnhacungcap f = new Frmnhacungcap();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Forms.Frmnhavanchuyen f = new Frmnhavanchuyen();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Forms.Frmchuongtrinhkm f = new Frmchuongtrinhkm();
            f.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frmdanhmuc0_Load(object sender, EventArgs e)
        {

        }
    }
}
