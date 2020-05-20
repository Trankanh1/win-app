using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Data.SqlClient;
namespace QuanLyBanHang.Forms
{
    public partial class Frmmauhang : Form
    {
        public Frmmauhang()
        {
            InitializeComponent();
        }

        private void btnopen_ClientSizeChanged(object sender, EventArgs e)
        {
        }
        SqlCommand cmd;
        DataTable tblMH;
        

        string imagelocation;
        private void btnopen_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlgopen = new OpenFileDialog();
            dlgopen.Filter = "all files(*.*)|*.*|BM(*.bmp)|*.bmp|GIF(*.gif)|*.gif";
            dlgopen.InitialDirectory = "D:\\";
            dlgopen.Title = "Chọn hình ảnh để hiển thị";
            if (dlgopen.ShowDialog() == DialogResult.OK)
            {
                imagelocation = dlgopen.FileName.ToString();
                pictureBox1.Image = Image.FromFile(dlgopen.FileName);
                txtanh.Text = dlgopen.FileName;
                string app_path = Path.GetDirectoryName(Application.ExecutablePath) + @"\images";
                pictureBox1.Image.Save(@""+ app_path + @"\" + (Path.GetFileName(dlgopen.FileName)));
                txtanh.Text = app_path + @"\" + (Path.GetFileName(dlgopen.FileName));
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtanh.Text = "";
            txtghichu.Text = "";
            txtmamau.Text = "";
            string sql, ma = "";
            sql = "select * from tblmauhang ";
            DataTable dt = Class.functions.GetDataTable(sql); // lấy toàn bộ số lượng nhân viên cho vào bảng dt
            if (dt.Rows.Count <= 0)
            {
                ma = "MH01";
            }
            else
            {
                int k;
                ma = "MH";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 2)); // dùng hàm substring để lấy ra kí 4 số cuối dùng trong chuỗi
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "0";
                }
                else if (k < 100)
                {
                    ma = ma + "";
                }

                ma = ma + k.ToString();

            }
            txtmamau.Text = ma;
        }
        private void resetvalues()
        {

            txtanh.Text = "";
            txtghichu.Text = "";
            txtmamau.Text = "";
            txtmamau.Focus();
            pictureBox1.Image =null;

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            Class.functions.connect();
            string sql;
            if (txtmamau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmamau.Focus();
                return;
            }
            if (txtanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtanh.Focus();
                return;
            }
            if (txtghichu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtghichu.Focus();
                return;
            }
            sql = "SELECT mamau FROM tblmauhang WHERE mamau='" + txtmamau.Text.Trim() + "'";
           
            if (Class.functions.checkkey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmamau.Focus();
                txtmamau.Text = "";
                return;
            }

            sql = "INSERT INTO tblmauhang(mamau,anh,ghichu) VALUES('" + txtmamau.Text.Trim() + "','" + txtanh.Text.Trim() + "','" + txtghichu.Text.Trim() + "')";
            
            Class.functions.runsql(sql);
            load_datagridview();
            resetvalues();
        }
        
        private void dgridmauhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgridmauhang_DoubleClick(object sender, EventArgs e)
        {
           

        }

        private void Frmmauhang_Load(object sender, EventArgs e)
        {
            txtmamau.Enabled = false;
            txtanh.Visible = false;
            load_datagridview();
            
        }

        private void dgridmauhang_Click(object sender, EventArgs e)
        {


        }
        
        private void load_datagridview()
        {
            string sql;
            sql = "select * from tblmauhang";
            tblMH = Class.functions.GetDataTable(sql);
            dataGridView1.DataSource = tblMH;     
            dataGridView1.Columns[0].HeaderText = "Mã mẫu";
            dataGridView1.Columns[1].HeaderText = "Ảnh";
            dataGridView1.Columns[2].HeaderText = "Ghi chú";
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 400;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;


        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
           
            if (txtmamau.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblmauhang WHERE mamau=N'" + txtmamau.Text + "'";
                Class.functions.runsql(sql);
                load_datagridview();
                pictureBox1.Image = null;
                resetvalues();
            }
          

        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            Class.functions.connect();
            string sql;
            sql = "select mamau from tblmauhang where mamau=N'"+txtmamau.Text.Trim()+"'";
            tblMH = Class.functions.GetDataTable(sql);
            if(tblMH.Rows.Count==0)
            {
                MessageBox.Show("Mã mẫu này không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            if (txtmamau.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmamau.Focus();
                return;
            }
            if (txtanh.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtanh.Focus();
                return;
            }
            if (txtghichu.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtghichu.Focus();
                return;
            }
            if(pictureBox1.Image==null)
            {

                MessageBox.Show("Bạn chưa nhập ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtanh.Focus();
                return;
            }
            Class.functions.connect();
            string sql;
            sql = "update tblmauhang set lo";
            load_datagridview();
            resetvalues();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            if (tblMH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmamau.Text = dataGridView1.CurrentRow.Cells["mamau"].Value.ToString();
            txtanh.Text = dataGridView1.CurrentRow.Cells["anh"].Value.ToString();
            txtghichu.Text = dataGridView1.CurrentRow.Cells["ghichu"].Value.ToString();
            pictureBox1.Image = Image.FromFile(txtanh.Text);
         
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
