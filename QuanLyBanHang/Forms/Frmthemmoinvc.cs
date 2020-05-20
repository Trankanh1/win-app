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
    public partial class Frmthemmoinvc : Form
    {
        public Frmthemmoinvc()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtmanvc.Enabled = false;
            string sql, ma = "";
            sql = "select * from tblnhavanchuyen ";
            DataTable dt = Class.functions.GetDataTable(sql); // lấy toàn bộ số lượng nhân viên cho vào bảng dt
            if (dt.Rows.Count <= 0)
            {
                ma = "NVC0001";
            }
            else
            {
                int k;
                ma = "NVC";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(3, 4)); // dùng hàm substring để lấy ra kí 4 số cuối dùng trong chuỗi
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "000";
                }
                else if (k < 100)
                {
                    ma = ma + "00";
                }
                else if (k < 1000)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();

            }
            txtmanvc.Text = ma;
        }
        DataTable tblNVC;
        private void btnluu1_Click(object sender, EventArgs e)
        {
            
            string sql;
            sql = "select manhavanchuyen from tblnhavanchuyen where manhavanchuyen ='"+txtmanvc.Text+"'";
            if (Class.functions.checkkey(sql))

            {
                MessageBox.Show("Mã vận chuyển này đã có !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanvc.Focus();
                txtmanvc.Text = "";
                return;
            }
            if (txtmanvc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà vận chuyển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanvc.Focus();
                return;
            }
            if (txttennvc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà vận chuyển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanvc.Focus();
                return;
            }
            sql = "insert into tblnhavanchuyen values ('" + txtmanvc.Text + "','" + txttennvc.Text + "','"+txtphivc.Text+"','" + txtketnoi.Text + "','" + txtmota.Text + "','" + txtghichu.Text + "') ";
            Class.functions.runsql(sql);
            MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetvalues();

        }
        private void resetvalues()
        {
            txtghichu.Text = "";
            txttennvc.Text = "";
            txtmota.Text = "";
            txtmanvc.Text = "";
            txtketnoi.Text = "";
        }
        private void btnlamlai1_Click(object sender, EventArgs e)
        {
            resetvalues();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Forms.Frmnhavanchuyen f = new Frmnhavanchuyen();
            f.ShowDialog();
            this.Hide();
            
        }

        private void Frmthemmoinvc_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Forms.Frmnhavanchuyen f = new Frmnhavanchuyen();
            f.ShowDialog();
        }
    }
}
