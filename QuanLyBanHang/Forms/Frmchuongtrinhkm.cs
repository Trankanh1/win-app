using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace QuanLyBanHang.Forms
{
    public partial class Frmchuongtrinhkm : Form
    {
        public Frmchuongtrinhkm()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.Taokm f = new Taokm();
            f.ShowDialog();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txttimkiem1.Text == "Nhập mã hoặc tên để tìm chương trình")
            {
                txttimkiem1.Text = "";
                txttimkiem1.ForeColor = Color.Black;
            }
        }

        private void txttimkiem1_Leave(object sender, EventArgs e)
        {

            if (txttimkiem1.Text == "")
            {
                txttimkiem1.Text = "Nhập mã hoặc tên để tìm chương trình";
                txttimkiem1.ForeColor = Color.Silver;
            }
        }
        private void loaddatacollection()
        {
            AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();
            string sql = "Select makm,tenkm  from tblkhuyenmai ";
            SQLiteCommand com = new SQLiteCommand(sql, Class.functions.conn);
            SQLiteDataReader reader;
            reader = com.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    auto2.Add(reader["makm"].ToString());
                    auto2.Add(reader["tenkm"].ToString());
                    
                }
            }
            reader.Close();
            txttimkiem1.AutoCompleteCustomSource = auto2;

        }
        private void Frmchuongtrinhkm_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "select * from tblkhuyenmai ";
            tblKM = Class.functions.GetDataTable(sql);
            dataGridView1.DataSource = tblKM;
            load_datgridview();
            loaddatacollection();
        }
        DataTable tblKM;
        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            if (txttimkiem1.Text == "" || comboBox1.Text=="")
            {
                MessageBox.Show("Nhập từ khóa để tìm kiếm","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (comboBox1.Text == "Đang hoạt động")
            {
                sql = "select * from tblkhuyenmai where makm='" + txttimkiem1.Text + "' or  tenkm='" + txttimkiem1.Text + "' and   strftime('%m/%d/%Y',ngayketthuc)>'" + DateTime.Now.ToShortDateString()+"' ";
                tblKM = Class.functions.GetDataTable(sql);
                dataGridView1.DataSource = tblKM;
                load_datgridview();
                
            }
            if (comboBox1.Text == "Ngưng hoạt động")
            {
                sql = "select * from tblkhuyenmai where makm='" + txttimkiem1.Text + "' or  tenkm='" + txttimkiem1.Text + "' and strftime('%m/%d/%Y',ngayketthuc)<'" + DateTime.Now.ToShortDateString() + "' ";
                tblKM = Class.functions.GetDataTable(sql);
                dataGridView1.DataSource = tblKM;
                load_datgridview();

            }
        }
        private void load_datgridview()
        {
           dataGridView1.Columns[0].HeaderText = "Mã KM";
            dataGridView1.Columns[1].HeaderText = "Tên ";
            dataGridView1.Columns[2].HeaderText = "Ngày bắt đầu";
            dataGridView1.Columns[3].HeaderText = "Ngày kết thúc";
            dataGridView1.Columns[4].HeaderText = "Giảm giá %";
            dataGridView1.Columns[5].HeaderText = "Hình thức";
            dataGridView1.Columns[6].HeaderText = "Áp dụng";
            dataGridView1.Columns[7].HeaderText = "Ghi chú";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns[5].Width = 50;
            dataGridView1.Columns[6].Width = 90;
            dataGridView1.Columns[7].Width = 150;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
    }
}
