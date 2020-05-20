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
    public partial class Frmnhacungcap : Form
    {
        public Frmnhacungcap()
        {
            InitializeComponent();
        }

        private void Frmnhacungcap_Load(object sender, EventArgs e)
        {
            txtmancc.Enabled = false;
            label12.Text = "Kích đúp một nhà cung cấp để hiển thị";

            load_datagridview();
        }
        DataTable tblNCC;
        private void load_datagridview()
        {
            string sql;
            sql = "select mancc, nguoilienhe,didong,congty,diachi,thanhpho,ghichu from tblnhacc ";
            tblNCC = Class.functions.GetDataTable(sql);
            dataGridView1.DataSource = tblNCC;
            dataGridView1.Columns[0].HeaderText = "Mã NCC";
            dataGridView1.Columns[1].HeaderText = "Người liên hệ";
            dataGridView1.Columns[2].HeaderText = "Di động";
            dataGridView1.Columns[3].HeaderText = "Công ty";
            dataGridView1.Columns[4].HeaderText = "Địa chỉ";
            dataGridView1.Columns[5].HeaderText = "Thành phố";
            dataGridView1.Columns[6].HeaderText = "Ghi chú";
            dataGridView1.Columns[0].Width = 110;
            dataGridView1.Columns[1].Width = 110;
            dataGridView1.Columns[2].Width = 110;
            dataGridView1.Columns[3].Width = 110;
            dataGridView1.Columns[4].Width = 110;
            dataGridView1.Columns[5].Width = 110;
            dataGridView1.Columns[5].Width = 110;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

            if (txtnguoilh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập người liên hệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnguoilh.Focus();
                return;
            }
            if (txtdidong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập di động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdidong.Focus();
                return;
            }
            string sql;
            sql = "SELECT mancc FROM tblnhacc WHERE mancc='" +txtmancc.Text.Trim() + "'";
            if (Class.functions.checkkey(sql))
            {
                MessageBox.Show("Mã NCC này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmancc.Focus();
                txtmancc.Text = "";
                return;
            }
            sql = "insert into tblnhacc values ('" + txtmancc.Text.Trim() + "','" + txtnguoilh.Text.Trim() + "','" + txtdidong.Text.Trim() + "','" + txtcongty.Text + "','" + txtdiachi.Text + "','" + cbothanhpho.Text + "','" + cboquocgia.Text+ "','" + txtemail.Text + "','" + txtdienthoai.Text + "','" + txtfax.Text + "','" + txtghichu.Text + "')";
            Class.functions.runsql(sql);
            load_datagridview();
            label12.Text = "Đã lưu thành công !";

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label12_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (tblNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmancc.Text= dataGridView1.CurrentRow.Cells["mancc"].Value.ToString();
            txtnguoilh.Text = dataGridView1.CurrentRow.Cells["nguoilienhe"].Value.ToString();
            txtdidong.Text = dataGridView1.CurrentRow.Cells["didong"].Value.ToString();
            txtdiachi.Text = dataGridView1.CurrentRow.Cells["diachi"].Value.ToString();
            txtcongty.Text = dataGridView1.CurrentRow.Cells["congty"].Value.ToString();
            cbothanhpho.Text = dataGridView1.CurrentRow.Cells["thanhpho"].Value.ToString();
            cboquocgia.Text = Class.functions.getfieldvalues("select quocgia from tblnhacc where mancc='" + txtmancc.Text + "' ");
            txtemail.Text = Class.functions.getfieldvalues("select email from tblnhacc where  mancc='" + txtmancc.Text + "' ");
            txtdienthoai.Text = Class.functions.getfieldvalues("select dienthoai from tblnhacc where  mancc='" + txtmancc.Text + "' ");
            txtfax.Text = Class.functions.getfieldvalues("select dienthoai from tblnhacc where  mancc='" + txtmancc.Text + "' ");
            txtghichu.Text = dataGridView1.CurrentRow.Cells["ghichu"].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtnguoilh.Text.Length==0 && txtdidong.Text.Length==0 && txtmancc.Text.Length==0)
            {
                MessageBox.Show("Bạn chưa chọn bản ghi để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            string sql;
            //sql = "select nguoilienhe ,didong from tblnhacungcap where nguoilienhe like N'%"+txtnguoilh.Text.Trim()+"%' and didong like N'%"+txtdidong.Text.Trim()+"%'";
            //tblNCC = Class.functions.GetDataTable(sql);

            //if (tblNCC.Rows.Count==0)
            //{
            //    MessageBox.Show("Không có bản ghi nào để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;

            //}
            sql = "update tblnhacc set nguoilienhe='" + txtnguoilh.Text.Trim() + "',didong='" + txtdidong.Text.Trim() + "',congty='" + txtcongty.Text + "',diachi='" + txtdiachi.Text + "',thanhpho='" + cbothanhpho.SelectedValue + "',quocgia='" + cboquocgia.SelectedValue + "',email='" + txtemail.Text + "',dienthoai='" + txtdienthoai.Text + "',fax='" + txtfax.Text + "',ghichu='" + txtghichu.Text + "' where mancc='" + txtmancc.Text+"'";
            Class.functions.runsql(sql);
            load_datagridview();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtmancc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtdidong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtcongty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtdiachi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void cbothanhpho_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void cboquocgia_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtnguoilh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtemail_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtdienthoai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtfax_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtghichu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
        private void restvalues()
        {
            txtcongty.Text = "";
            txtdiachi.Text = "";
            txtdidong.Text = "";
            txtdienthoai.Text = "";
            txtemail.Text = "";
            txtfax.Text = "";
            txtghichu.Text = "";
            txtmancc.Text = "";
            txtnguoilh.Text = "";
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            restvalues();
            string sql, ma = "";
            sql = "select * from tblnhacc ";
            DataTable dt = Class.functions.GetDataTable(sql); // lấy toàn bộ số lượng nhân viên cho vào bảng dt
            if (dt.Rows.Count <= 0)
            {
                ma = "NCC0001";
            }
            else
            {
                int k;
                ma = "NCC";
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
            txtmancc.Text = ma;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
          
            if (txtmancc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmancc.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete from tblnhacc where mancc='" + txtmancc.Text + "'";
                Class.functions.runsql(sql);
                load_datagridview();
               restvalues();
            }
        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            restvalues();
        }
    }
}
