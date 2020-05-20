using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void hÀNGHÓAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Frmhanghoa f = new Forms.Frmhanghoa();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
           
        }

        private void kHÁCHHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Frmkhachhang f = new Forms.Frmkhachhang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuthoat_Click(object sender, EventArgs e)
        {
           
        }

        private void mnunhanvien_Click(object sender, EventArgs e)
        {

            Forms.Frmnhanvien f = new Forms.Frmnhanvien();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuhdnhap_Click(object sender, EventArgs e)
        {

            Forms.Frmhdnhap f = new Forms.Frmhdnhap();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuhdban_Click(object sender, EventArgs e)
        {

            Forms.Frmhdban f = new Forms.Frmhdban();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnumathang_Click(object sender, EventArgs e)
        {

            Forms.Frmmauhang f = new Forms.Frmmauhang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnukh_Click(object sender, EventArgs e)
        {

            Forms.Frmkhachhang f = new Forms.Frmkhachhang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuhangton_Click(object sender, EventArgs e)
        {

            Forms.Frmhanghoa f = new Forms.Frmhanghoa();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuhangbanchay_Click(object sender, EventArgs e)
        {

            Forms.Frmmathangbanchay f = new Forms.Frmmathangbanchay();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void Frmain_Load(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void tHOÁTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class.functions.disconnect();
            if (MessageBox.Show("Bạn có muốn thoát ra khỏi hệ thống không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Frmadmindangnhapcs f = new Forms.Frmadmindangnhapcs();
            f.Show();
        }

        private void mnuhoadonban_Click(object sender, EventArgs e)
        {
            Forms.Frmtimhdban f = new Forms.Frmtimhdban();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnudondathang_Click(object sender, EventArgs e)
        {
            Forms.Frmdondathang f = new Forms.Frmdondathang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnutimdondathang_Click(object sender, EventArgs e)
        {
            Forms.Frmtimdonhang f = new Forms.Frmtimdonhang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
