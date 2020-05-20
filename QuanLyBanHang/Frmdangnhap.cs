using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
namespace QuanLyBanHang
{
    public partial class Frmdangnhap : Form
    {
        public Frmdangnhap()
        {
            InitializeComponent();
          
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

            this.Close();

        }
        DataTable tblDN;
        private void btndangnhap_Click(object sender, EventArgs e)
        {

        }

        private void txtdangnhap_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void txtmatkhau_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Frmdangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát không ?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btndangnhap_Click_1(object sender, EventArgs e)
        {

            if (txtdangnhap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên đăng nhập để đăng nhập vào hệ thống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdangnhap.Focus();
            }
            if (txtmatkhau.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mật khẩu để đăng nhập vào hệ thống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmatkhau.Focus();
            }
            Class.functions.connect();
            if (txtdangnhap.Text != "" && txtmatkhau.Text != "")
            {
                string sql;
                sql = "select count(*) from tbltaikhoan where tendangnhap ='" + txtdangnhap.Text.Trim() + "' and matkhau='" + txtmatkhau.Text.Trim() + "'";
                tblDN = Class.functions.GetDataTable(sql);
                if (tblDN.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Chúc mừng bạn đã đăng nhập thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Frmchinh.Tendangnhap = Class.functions.getfieldvalues("select hovaten from tbltaikhoan where  tendangnhap='" + txtdangnhap.Text + "'").ToString();
                    this.Hide();
                    Frmchinh f = new Frmchinh();
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.Show();

                }
                else
                {
                    MessageBox.Show(" Tên đăng nhập hoặc mật khẩu của bạn không đúng ! \n                            Mời bạn nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdangnhap.Text = "";
                    txtmatkhau.Text = "";

                }
            }
        }

        private void txtdangnhap_KeyUp_1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtmatkhau_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndangnhap_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtmatkhau.UseSystemPasswordChar = false;
            }
            else
                txtmatkhau.UseSystemPasswordChar = true;
        }
    }
}
