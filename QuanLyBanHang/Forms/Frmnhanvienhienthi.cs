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
    public partial class Frmnhanvienhienthi : Form
    {
        public Frmnhanvienhienthi()
        {
            InitializeComponent();
        }
        public static string Manhanvien = string.Empty;
        private void Frmnhanvienhienthi_Load(object sender, EventArgs e)
        {
            lblanh.Visible = false;

            this.lblmanv.Text = Manhanvien;
            DateTime d ;
            d = Convert.ToDateTime(Class.functions.getfieldvalues("select ngaysinh from tblnhanvien where manhanvien='" + lblmanv.Text + "'"));
            
            lblanh.Text = Class.functions.getfieldvalues("select anh from tblnhanvien where manhanvien='" + lblmanv.Text + "'");
            lbltennv.Text = Class.functions.getfieldvalues("select tennhanvien from tblnhanvien where manhanvien='" + lblmanv.Text + "'");
            lblngaysinh.Text = d.ToShortDateString().ToString();
            lblgioitinh.Text = Class.functions.getfieldvalues("select gioitinh from tblnhanvien where manhanvien='" + lblmanv.Text + "'");
            lbldienthoai.Text = Class.functions.getfieldvalues("select dienthoai from tblnhanvien where manhanvien='" + lblmanv.Text + "'");
            lbldiachi.Text = Class.functions.getfieldvalues("select diachi from tblnhanvien where manhanvien='" + lblmanv.Text + "'");
     
            if (lblanh.Text != "")
            pictureBox1.Image = Image.FromFile(lblanh.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
