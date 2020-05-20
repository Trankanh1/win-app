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
    public partial class Frmtimkiem : Form
    {
        public Frmtimkiem()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btntkhdban_Click(object sender, EventArgs e)
        {
            Forms.Frmtimhdban f = new Forms.Frmtimhdban();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void btntkdonhang_Click(object sender, EventArgs e)
        {
            Forms.Frmtimdonhang f = new Forms.Frmtimdonhang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void Frmtimkiem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.yc f = new Forms.yc();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }
    }
}
