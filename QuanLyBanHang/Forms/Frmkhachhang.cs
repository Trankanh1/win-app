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
    public partial class Frmkhachhang : Form
    {
        public Frmkhachhang()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Frmkhachhang_Load(object sender, EventArgs e)
        {;
            Class.functions.fillcombo("SELECT makhach FROM tblkhach", comboBox1, "makhach", "makhach");
            comboBox1.SelectedIndex = -1;

            load_datagridview();
        }
        DataTable tblKH;
        private void load_datagridview()
        {
            string sql;
            sql = "select makhach,tenkhach,diachi,dienthoai from tblkhach";
            tblKH = Class.functions.GetDataTable(sql);
            dgridkhachhang.DataSource = tblKH;
            dgridkhachhang.Columns[0].HeaderText = "Mã khách hàng";
            dgridkhachhang.Columns[1].HeaderText = "Tên khách hàng";
            dgridkhachhang.Columns[2].HeaderText = "Địa chỉ";
            dgridkhachhang.Columns[3].HeaderText = "Điện thoại";
            dgridkhachhang.Columns[0].Width = 150;
            dgridkhachhang.Columns[1].Width = 150;
            dgridkhachhang.Columns[2].Width = 150;
            dgridkhachhang.Columns[3].Width = 150;
            dgridkhachhang.AllowUserToAddRows = false;
            dgridkhachhang.EditMode = DataGridViewEditMode.EditProgrammatically;


        }

       
        //{
        //    if(tblKH.Rows.Count == 0)
        //    {
        //        MessageBox.Show("Không có dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    txtmakhach.Text = dgridkhachhang.CurrentRow.Cells["makhach"].Value.ToString();
        //    txttenkhach.Text = dgridkhachhang.CurrentRow.Cells["tenkhach"].Value.ToString();
        //    txtdiachi.Text = dgridkhachhang.CurrentRow.Cells["diachi"].Value.ToString();
        //    txtdienthoai.Text = dgridkhachhang.CurrentRow.Cells["dienthoai"].Value.ToString();
        

        private void btnthem_Click(object sender, EventArgs e)
        {

            resetvalues();
        
            string sql, ma = "";
            sql = "select * from tblkhach ";
            DataTable dt = Class.functions.GetDataTable(sql); // lấy toàn bộ số lượng nhân viên cho vào bảng dt
            if (dt.Rows.Count <= 0)
            {
                ma = "KH0001";
            }
            else
            {
                int k;
                ma = "KH";
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
            txtmakhach.Text = ma;
        }

        private void resetvalues()
        {
            txtmakhach.Text = "";
            txttenkhach.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            comboBox1.Text = "";
            txtemai.Text = "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmakhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmakhach.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiachi.Focus();
                return;
            }
            if (txtdienthoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdienthoai.Focus();
                return;
            }

          
            sql = "select  dienthoai from tblkhach where dienthoai='" + txtdienthoai.Text.Trim() + "'";
           

            if (Class.functions.checkkey(sql))
            {
                MessageBox.Show("Số điện thoại này đã có !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdienthoai.Focus();
                txtdienthoai.Text = "";

                return;
            }

            sql = "insert into tblkhach values ('" + txtmakhach.Text.Trim() + "','" + txttenkhach.Text.Trim().ToUpper() + "','" + txtdiachi.Text.Trim().ToUpper() + "','" + txtdienthoai.Text + "','" +txtemai.Text + "')";
            Class.functions.runsql(sql);
            load_datagridview();
            resetvalues();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmakhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmakhach.Focus();
                return;
            }
            if (txttenkhach.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenkhach.Focus();
                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiachi.Focus();
                return;
            }
            if (txtdienthoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdienthoai.Focus();
                return;
            }
            sql = "update tblkhach set tenkhach='" + txttenkhach.Text.Trim().ToString() + "',diachi='" + txtdiachi.Text.Trim().ToString() + "',dienthoai='" + txtdienthoai.Text.Trim().ToString() + "' where makhach='" + txtmakhach.Text + "'";
            Class.functions.runsql(sql);
            load_datagridview();
            resetvalues();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmakhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmakhach.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete from tblkhach where makhach='" + txtmakhach.Text + "'";
                Class.functions.runsql(sql);
                load_datagridview();
                resetvalues();
            }
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            resetvalues();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmakhach_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txttenkhach_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtdiachi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void dgridkhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mskdienthoai_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtmakhach_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtemai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtdienthoai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select  * from tblkhach where makhach ='" + comboBox1.SelectedValue + "'";
            tblKH = Class.functions.GetDataTable(sql);
          
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Mã này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtmakhach.Text = Class.functions.getfieldvalues("select makhach from  tblkhach where makhach ='" + comboBox1.SelectedValue + "'");
            txtdiachi.Text = Class.functions.getfieldvalues("select diachi from  tblkhach where makhach ='" + comboBox1.SelectedValue + "'");
            txtdienthoai.Text = Class.functions.getfieldvalues("select dienthoai from  tblkhach where makhach ='" + comboBox1.SelectedValue + "'");
            txtemai.Text = Class.functions.getfieldvalues("select email from  tblkhach where makhach ='" + comboBox1.SelectedValue + "'");
            txttenkhach.Text = Class.functions.getfieldvalues("select tenkhach from  tblkhach where makhach ='" + comboBox1.SelectedValue + "'");
        }

        private void txtdienthoai_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
