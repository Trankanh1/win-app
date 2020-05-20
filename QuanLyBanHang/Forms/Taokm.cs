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
    public partial class Taokm : Form
    {
        public Taokm()
        {
            InitializeComponent();
        }

        private void Taokm_Load(object sender, EventArgs e)
        {
            txtmakm.Enabled = false;
            string sql, ma = "";
            sql = "select * from tblkhuyenmai ";
            DataTable dt = Class.functions.GetDataTable(sql); // lấy toàn bộ số lượng nhân viên cho vào bảng dt
            if (dt.Rows.Count <= 0)
            {
                ma = "KM0001";
            }
            else
            {
                int k;
                ma = "KM";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 4)); // dùng hàm substring để lấy ra kí 4 số cuối dùng trong chuỗi
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
            txtmakm.Text = ma;
        }

        private void btnluu1_Click(object sender, EventArgs e)
        {
            string sql;
            if (chkonline.Checked == true && rdtatca.Checked == true)
            {
                sql = "insert into tblkhuyenmai values ('" + txtmakm.Text + "','" + txttenct.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + txtgiatrikm.Text + "','" + chkonline.Text + "','" +rdtatca.Text + "','" +txtghichu.Text + "')";
                Class.functions.runsql(sql);
                MessageBox.Show("Đã lưu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                resetvalues();
            }
            if (chktaicuahang.Checked == true && rdrieng.Checked == true)
            {
                sql = "insert into tblkhuyenmai values ('" + txtmakm.Text + "','" + txttenct.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + txtgiatrikm.Text + "','" + chktaicuahang.Text + "','" + rdrieng.Text + "','" + txtghichu.Text + "')";
                Class.functions.runsql(sql);
                MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetvalues();
            }
            if (chkonline.Checked == true && rdrieng.Checked == true)
            {
                sql = "insert into tblkhuyenmai values ('" + txtmakm.Text + "','" + txttenct.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + txtgiatrikm.Text + "','" + chkonline.Text + "','" + rdrieng.Text + "','" + txtghichu.Text + "')";
                Class.functions.runsql(sql);
                MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetvalues();
            }
            if (chktaicuahang.Checked == true && rdtatca.Checked == true)
            {
                sql = "insert into tblkhuyenmai values ('" + txtmakm.Text + "','" + txttenct.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + txtgiatrikm.Text + "','" + chktaicuahang.Text + "','" + rdtatca.Text + "','" +txtghichu.Text + "')";
                Class.functions.runsql(sql);
                MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetvalues();
            }
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.Frmchuongtrinhkm f = new Frmchuongtrinhkm();
            f.ShowDialog();
        }
        private void resetvalues()
        {
            txtghichu.Text = "";
            txtgiatrikm.Text = "";
            txtmakm.Text = "";
            txttenct.Text = "";
            chkonline.Checked = false;
            chktaicuahang.Checked = false;
            rdrieng.Checked = false;
            rdtatca.Checked = false;



        }
    }
}
