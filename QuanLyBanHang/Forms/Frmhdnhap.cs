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
    public partial class Frmhdnhap : Form
    {
        public Frmhdnhap()
        {
            InitializeComponent();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmahdnhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahdnhap.Focus();
                return;
            }
            if (datetimengaylap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày lập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                datetimengaylap.Focus();
                return;
            }
 
            if (txttongtien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tổng tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtanh.Focus();
                return;
            }
            sql = "SELECT mahdnhap FROM tblhdnhap WHERE mahdnhap='" + txtmahdnhap.Text.Trim() + "'";
            if (Class.functions.checkkey(sql))
            {
                MessageBox.Show("Mã hóa đơn này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmahdnhap.Focus();
                txtmahdnhap.Text = "";
                return;
            }
            sql = "INSERT INTO tblhdnhap VALUES('" + txtmahdnhap.Text.Trim() + "','" + datetimengaylap.Text.Trim() + "','" +txtanh.Text.Trim() + "','" + txtghichu.Text.Trim() + "','"+txttongtien.Text.Trim()+ "','" +cboncc.Text.Trim() + "')";
            Class.functions.runsql(sql);
            load_datagridview();
            resetvalues();
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

        private void Frmhdnhap_Load(object sender, EventArgs e)
        {
            txtmahdnhap.Enabled = false;
            load_datagridview();
            txtmahdnhap.Focus();
            Class.functions.fillcombo("select mahdnhap from tblhdnhap ", cbomadonhap, "mahdnhap", "mahdnhap");
            cbomadonhap.SelectedIndex = -1;
            Class.functions.fillcombo("select mancc from tblnhacc ", cboncc, "mancc", "mancc");
            cboncc.SelectedIndex = -1;

            txtanh.Visible = false;
        }
        DataTable tblHDN;
        private void load_datagridview()
        {
            string sql;
            sql = "select mahdnhap,ngaynhap,tongtien,mancc,ghichu,anh from tblhdnhap";
            tblHDN = Class.functions.GetDataTable(sql);
            dataGridView1.DataSource = tblHDN;
            dataGridView1.Columns[0].HeaderText = "Mã đơn nhập";
            dataGridView1.Columns[1].HeaderText = "Ngày nhập";
            dataGridView1.Columns[2].HeaderText = "Tổng tiền";
            dataGridView1.Columns[3].HeaderText = "Nhà CC ";
            dataGridView1.Columns[4].HeaderText = "Ghi chú";
            dataGridView1.Columns[5].HeaderText = "Ảnh";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 80;



            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;


        }
        private void resetvalues()
        {
            txttongtien.Text = "";
            txtanh.Text = "";
            txtghichu.Text = "";
            txtmahdnhap.Text = "";
            datetimengaylap.Text = "";
            pictureBox1.Image = null;
            txttenncc.Text = "";
            cboncc.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           
           
            if (tblHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmahdnhap.Text =dataGridView1.CurrentRow.Cells["mahdnhap"].Value.ToString();
            datetimengaylap.Text = dataGridView1.CurrentRow.Cells["ngaynhap"].Value.ToString();
            txtanh.Text = dataGridView1.CurrentRow.Cells["anh"].Value.ToString();
            txtghichu.Text = dataGridView1.CurrentRow.Cells["ghichu"].Value.ToString();
            txttongtien.Text = dataGridView1.CurrentRow.Cells["tongtien"].Value.ToString();
            if (txtanh.Text != "")
            {
                pictureBox1.Image = Image.FromFile(txtanh.Text);
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

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            string sql; 

            if (cbomadonhap.Text== "")
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn để hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahdnhap.Focus();
                return;

            }
            sql = "select mahdnhap from tblhdnhap where mahdnhap='"+txtmahdnhap.Text.Trim()+ "' or  mahdnhap='" + cbomadonhap.SelectedValue+ "'  ";
            tblHDN = Class.functions.GetDataTable(sql);
            if(tblHDN.Rows.Count==0)
            {
                MessageBox.Show("Không tồn tại mã này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahdnhap.Text = "";
                txtmahdnhap.Focus();

            }
            txtmahdnhap.Text = Class.functions.getfieldvalues("select mahdnhap from tblhdnhap where mahdnhap='" + cbomadonhap.SelectedValue + "' ");
            datetimengaylap.Text = Class.functions.getfieldvalues("select ngaynhap from tblhdnhap where mahdnhap='" + cbomadonhap.SelectedValue + "' ");
            txtanh.Text = Class.functions.getfieldvalues("select anh from tblhdnhap where  mahdnhap='" + cbomadonhap.SelectedValue + "' ");
            txtghichu.Text = Class.functions.getfieldvalues("select ghichu from tblhdnhap where  mahdnhap='" + cbomadonhap.SelectedValue + "' ");
            txttongtien.Text = Class.functions.getfieldvalues("select tongtien from tblhdnhap where mahdnhap='" + cbomadonhap.SelectedValue + "' ");
            if (txtanh.Text != "")
                pictureBox1.Image = Image.FromFile(txtanh.Text);
            else pictureBox1.Image = null;


        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btninhd_Click(object sender, EventArgs e)
        {

        }

        private void txtmahdnhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txttongtien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void cboncc_TextChanged(object sender, EventArgs e)
        {
            txttenncc.Text= Class.functions.getfieldvalues("select congty from tblnhacc where  mancc='" +cboncc.Text + "' ");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            resetvalues();
            string sql, ma = "";
            sql = "select * from tblhdnhap ";
            DataTable dt = Class.functions.GetDataTable(sql); // lấy toàn bộ số lượng nhân viên cho vào bảng dt
            if (dt.Rows.Count <= 0)
            {
                ma = "DN00000001";
            }
            else
            {
                int k;
                ma = "DN";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 8)); // dùng hàm substring để lấy ra kí 4 số cuối dùng trong chuỗi
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "0000000";
                }
                else if (k < 100)
                {
                    ma = ma + "000000";
                }
                else if (k < 1000)
                {
                    ma = ma + "00000";
                }
                else if (k < 10000)
                {
                    ma = ma + "0000";
                }
                else if (k < 100000)
                {
                    ma = ma + "000";
                }
                else if (k < 1000000)
                {
                    ma = ma + "00";
                }
                else if (k < 10000000)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();

            }
            txtmahdnhap.Text = ma;

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
          
            if (txtmahdnhap.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahdnhap.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "delete from tblhdnhap where mahdnhap='" + txtmahdnhap.Text + "'";
                Class.functions.runsql(sql);
                load_datagridview();
                resetvalues();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

        }
    }
}
