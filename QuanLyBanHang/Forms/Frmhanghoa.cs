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

namespace QuanLyBanHang.Forms
{
    public partial class Frmhanghoa : Form
    {
        public Frmhanghoa()
        {
            InitializeComponent();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

        }

        private void Frmhanghoa_Load(object sender, EventArgs e)
        {
            txtanh.Visible = false;
            load_datagridview();
            Class.functions.fillcombo("select mahang from tblhang ", cbomahang, "mahang", "mahang");
        }
        private void resetvalues()
        {
            txtdongiaban.Text = "";
            txtdongianhap.Text = "";
            cbomahang.Text = "";
            txtsoluong.Text = "";
            txttenhang.Text = "";
            txtghichu.Text = "";
            txtanh.Text = "";



        }
        DataTable tblHH;
        private void load_datagridview()
        {
            string sql;
            sql = "select mahang as [Mã hàng],tenhang as [Tên hàng] ,soluong as [Số lượng] ,dongianhap as [Đơn giá nhập] ,dongiaban as [Đơn giá bán] ,anh as [Ảnh] , ghichu as [Ghi chú] from tblhang";
            tblHH = Class.functions.GetDataTable(sql);
            dgridhanghoa.DataSource = tblHH;

        }

        private void btnopen_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlgopen = new OpenFileDialog();
            dlgopen.Filter = "BM|(*.bmp)|GIF(*.gif)|*.gif|all files(*.*)|*.*";
            dlgopen.InitialDirectory = "D:\\";
            dlgopen.Title = "Chọn hình ảnh để hiển thị";
            if (dlgopen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlgopen.FileName);
                txtanh.Text = dlgopen.FileName;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
        }

        private void dgridhanghoa_Click(object sender, EventArgs e)
        {


            if (tblHH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cbomahang.Text = dgridhanghoa.CurrentRow.Cells["Mã hàng"].Value.ToString();
            txttenhang.Text = dgridhanghoa.CurrentRow.Cells["Tên hàng"].Value.ToString();
            txtsoluong.Text = dgridhanghoa.CurrentRow.Cells["Số lượng"].Value.ToString();
            txtdongianhap.Text = dgridhanghoa.CurrentRow.Cells["Đơn giá nhập"].Value.ToString();
            txtdongiaban.Text = dgridhanghoa.CurrentRow.Cells["Đơn giá bán"].Value.ToString();
            txtanh.Text = dgridhanghoa.CurrentRow.Cells["Ảnh"].Value.ToString();
            txtghichu.Text = dgridhanghoa.CurrentRow.Cells["Ghi chú"].Value.ToString();
            if (txtanh.Text != "")

                pictureBox1.Image = Image.FromFile(txtanh.Text);
            else  pictureBox1.Image = null;


        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            string sql;
            if (tblHH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbomahang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbomahang.Focus();
                return;
            }
            if (txttenhang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenhang.Focus();
                return;
            }
            if (txtsoluong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Focus();
                return;
            }
            if (txtdongiaban.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdongiaban.Focus();
                return;
            }
            if (txtdongianhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdongianhap.Focus();
                return;
            }
            if (txtanh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtanh.Focus();
                return;
            }
            sql = "update tblhang set tenhang='" + txttenhang.Text.Trim().ToString() + "',soluong='" + txtsoluong.Text.Trim().ToString() + "',dongianhap='" + txtdongianhap.Text.Trim().ToString() + "',anh='" + txtanh.Text.Trim() + "',ghichu='" + txtghichu.Text.Trim() + "',dongiaban='" + txtdongiaban.Text.Trim() + "' where mahang = '" + cbomahang.Text + "'";
            Class.functions.runsql(sql);
            load_datagridview();
            resetvalues();

        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            resetvalues();


        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
         
            string sql;
            if ((cbomahang.Text == "") && (txttenhang.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblhang WHERE 1=1";
            if (cbomahang.Text != "")
                sql = sql + " AND mahang Like '%" + cbomahang.Text + "%'";
            if (txttenhang.Text != "")
                sql = sql + " AND Tenhang Like '%" + txttenhang.Text + "%'";
            if (tblHH.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            txttenhang.Text = Class.functions.getfieldvalues("select tenhang from  tblhang where mahang ='" + cbomahang.SelectedValue + "'");
            txtsoluong.Text = Class.functions.getfieldvalues("select soluong from  tblhang where mahang ='" + cbomahang.SelectedValue + "'");
            txtdongianhap.Text = Class.functions.getfieldvalues("select dongianhap from  tblhang where mahang ='" + cbomahang.SelectedValue + "'");
            txtdongiaban.Text = Class.functions.getfieldvalues("select dongiaban from  tblhang where mahang ='" + cbomahang.SelectedValue + "'");
            txtghichu.Text = Class.functions.getfieldvalues("select ghichu from  tblhang where mahang ='" + cbomahang.SelectedValue + "'");
            txtanh.Text = Class.functions.getfieldvalues("select anh from  tblhang where mahang ='" + cbomahang.SelectedValue + "'");

            if (txtanh.Text != "")
                pictureBox1.Image = Image.FromFile(txtanh.Text);
            else pictureBox1.Image = null;
            dgridhanghoa.DataSource = tblHH;
         
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmhanghoa_Click(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbomahang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txttenhang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtsoluong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtdongianhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtdongiaban_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtghichu_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dgridhanghoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
