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
    public partial class Frmadmindangnhapcs : Form
    {
        public Frmadmindangnhapcs()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable tblDN;
        private void btndangnhap_Click(object sender, EventArgs e)
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
            //chucvu like N'%Quản lý kho%' or chucvu like N'%Quản lý%'
            if (txtdangnhap.Text != "" && txtmatkhau.Text != "")
            {
                string sql;
                sql = "select count(*) from tbltaikhoan where tendangnhap ='" + txtdangnhap.Text.Trim() + "' and matkhau='" + txtmatkhau.Text.Trim() + "' and chucvu ='Quản lý' ";
                tblDN = Class.functions.GetDataTable(sql);
            
                if (tblDN.Rows[0][0].ToString()=="1")
                {
                    this.Hide();
                    Forms.Frmadmin f = new Frmadmin();
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.ShowDialog();

                }
                else
                {
                    MessageBox.Show(" Tên đăng nhập hoặc mật khẩu của bạn không đúng ! \n                            Mời bạn nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdangnhap.Text = "";
                    txtmatkhau.Text = "";

                }
            }
        }

        private void txtdangnhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtmatkhau_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btndangnhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void Frmadmindangnhapcs_Load(object sender, EventArgs e)
        {

        }
    }
}
