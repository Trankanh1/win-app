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
    public partial class Frmkh : Form
    {
        public Frmkh()
        {
            InitializeComponent();
        }
        public static string Dienthoai = string.Empty;

        private void Frmkh_Load(object sender, EventArgs e)
        {
            this.lbldienthoai.Text = Dienthoai;
            lbldiachi.Text = Class.functions.getfieldvalues("select diachi from tblkhach where dienthoai=N'"+lbldienthoai.Text+"'");
            lblemail.Text = Class.functions.getfieldvalues("select email from tblkhach where dienthoai=N'" + lbldienthoai.Text + "'");
            lblmakhach.Text = Class.functions.getfieldvalues("select makhach from tblkhach where dienthoai=N'" + lbldienthoai.Text + "'");
            lbltenkhach.Text = Class.functions.getfieldvalues("select tenkhach from tblkhach where dienthoai=N'" + lbldienthoai.Text + "'");

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnok_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
