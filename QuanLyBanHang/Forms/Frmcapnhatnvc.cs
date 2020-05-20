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
    public partial class Frmcapnhatnvc : Form
    {
        public Frmcapnhatnvc()
        {
            InitializeComponent();
        }
        public static string Manhavc=string.Empty;

        private void Form2_Load(object sender, EventArgs e)
        {
            txtmanvc.Text = Manhavc;
            txttennvc.Text = Class.functions.getfieldvalues("select tennhavanchuyen from tblnhavanchuyen where manhavanchuyen =N'" + txtmanvc.Text + "'");
            txtketnoi.Text = Class.functions.getfieldvalues("select ketnoigiaohang from tblnhavanchuyen  where manhavanchuyen =N'" + txtmanvc.Text + "'");
            txtmota.Text = Class.functions.getfieldvalues("select mota from tblnhavanchuyen  where manhavanchuyen =N'" + txtmanvc.Text + "'");
            txtghichu.Text = Class.functions.getfieldvalues("select ghichu from tblnhavanchuyen  where manhavanchuyen =N'" + txtmanvc.Text + "'");
            txtmanvc.Enabled = false;


        }

        private void btnluu1_Click(object sender, EventArgs e)
        {

        }
        private void resetvalues()
        {
            txtphivc.Text = "";
            txttennvc.Text = "";
            txtmota.Text = "";
            txtmanvc.Text = "";
            txtketnoi.Text = "";
            txtghichu.Text = "";
        }
        private void btncapnhat_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "update tblnhavanchuyen set tennhavanchuyen =N'" + txttennvc.Text + "',ketnoigiaohang=N'" + txtketnoi.Text + "',mota=N'" + txtmota.Text + "',ghichu=N'" + txtghichu.Text + "',phivanchuyen='" +txtphivc.Text + "' where manhavanchuyen =N'" + txtmanvc.Text+"' ";
            Class.functions.runsql(sql);
            MessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetvalues();
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.Frmnhavanchuyen f = new Frmnhavanchuyen();
            f.ShowDialog();
            

        }

        private void Frmcapnhatnvc_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Frmcapnhatnvc_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Forms.Frmnhavanchuyen f = new Frmnhavanchuyen();
            f.ShowDialog();

        }
    }

}
