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
    public partial class Frmnhavanchuyen : Form
    {
        public Frmnhavanchuyen()
        {
            InitializeComponent();
        }

        private void Frmnhavanchuyen_Load(object sender, EventArgs e)
        {
            load_datagridview();
            loaddatacollection();
            string sql;
            sql = "select * from tblnhavanchuyen ";
            tblNVC = Class.functions.GetDataTable(sql);
            lblnvc.Text = tblNVC.Rows.Count.ToString();

        }
        private void loaddatacollection()
        {
            //string sql;
            //sql = "select * from tblnhavanchuyen ";
            //tblNVC = Class.functions.GetDataTable(sql);
            //AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            //int i, j;
            //for (i = 0; i < tblNVC.Columns.Count - 1; i++)
            //{
            //    for (j = 0; i < tblNVC.Rows.Count - 1; i++)
            //    {

            //        auto.Add(tblNVC.Rows[j][i].ToString());

            //        j++;

            //    }
            //    i++;
            //}


            //txttimkiem1.AutoCompleteCustomSource = auto;
            AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();

            //string strConnection = "Data Source=.\\SQLEXPRESS; Database=Northwind;Integrated Security=true;";
            //string strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\OS\source\repos\QuanLyBanHang\QuanLyBanHang\Quanlybanhang\Quanlybanhang.mdf;Integrated Security=True;Connect Timeout=30";


            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = strConnection;

            //Class.functions.connect();
            //SqlCommand cmd = new SqlCommand(sql);
            //cmd.Connection = conn;
            //cmd.CommandType = CommandType.Text;

            string sql = "Select *    from tblnhavanchuyen";
            SQLiteCommand com = new SQLiteCommand(sql,Class.functions.conn);
            
            //com.Connection = conn;
            //com.CommandText = sql;
            //com.CommandType = CommandType.Text;
            //conn.Open();
            SQLiteDataReader reader;
            reader = com.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    auto2.Add(reader["manhavanchuyen"].ToString());
                    auto2.Add(reader["tennhavanchuyen"].ToString());
                    auto2.Add(reader["ketnoigiaohang"].ToString());
                    auto2.Add(reader["mota"].ToString());
                    auto2.Add(reader["ghichu"].ToString());


                }
            }
            reader.Close();
            //txttimkiem1.AutoCompleteMode = AutoCompleteMode.Append;
            //txttimkiem1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //txttimkiem1.AutoCompleteCustomSource = auto2;

            //txttimkiem1.AutoCompleteMode = AutoCompleteMode.Suggest;
            //txttimkiem1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txttimkiem1.AutoCompleteCustomSource = auto2;

        }
        DataTable tblNVC;

        private void load_datagridview()
        {
            string sql;
            sql = "select * from tblnhavanchuyen ";
            tblNVC= Class.functions.GetDataTable(sql);
            dataGridView1.DataSource = tblNVC;
            dataGridView1.Columns[0].HeaderText = "Mã NVC";
            dataGridView1.Columns[1].HeaderText = "Tên NVC";

            dataGridView1.Columns[2].HeaderText = "Phí vận chuyển";
            dataGridView1.Columns[3].HeaderText = "Kết nối giao hàng";
            dataGridView1.Columns[4].HeaderText = "Mô tả";
            dataGridView1.Columns[5].HeaderText = "Ghi chú";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[5].Width = 100;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Forms.Frmthemmoinvc f = new Frmthemmoinvc();
            f.ShowDialog();
            this.Hide();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select * from tblnhavanchuyen where manhavanchuyen=N'" + txttimkiem1.Text + "' or tennhavanchuyen=N'" + txttimkiem1.Text + "' or ketnoigiaohang=N'" + txttimkiem1.Text + "' or mota=N'" + txttimkiem1.Text + "' or ghichu=N'" + txttimkiem1.Text + "' ";

            tblNVC = Class.functions.GetDataTable(sql);
            if(tblNVC.Rows.Count==0)
            {
                MessageBox.Show("Không có bản ghi nào","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txttimkiem1.Text = "";
            }
            dataGridView1.DataSource = tblNVC;
        }

        private void lblcapnhat_Click(object sender, EventArgs e)
        {
            //string sql;

            //if (txttimkiem1.Text == "Nhập để tìm kiếm ..")
            //{
            //    MessageBox.Show("Tìm nhà vận chuyển để cập nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;

            //}
            if(tblNVC.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi nào ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string s = dataGridView1.CurrentRow.Cells["manhavanchuyen"].Value.ToString();
          
            Frmcapnhatnvc.Manhavc =s ;
            Forms.Frmcapnhatnvc f = new Frmcapnhatnvc();
            f.ShowDialog();
            this.Close();



        }
        // tìm kiếm -> hiển thị trên datagri->chọn dòng muốn xóa
        private void lblxoa_Click(object sender, EventArgs e)
        {
            string sql;

            //if(txttimkiem1.Text== "Nhập để tìm kiếm ..")
            //{
            //    MessageBox.Show("Tìm nhà vận chuyển để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;

            //}
            //sql = "select * from tblnhavanchuyen where manhavanchuyen=N'" + txttimkiem1.Text + "' ";

            //tblNVC = Class.functions.GetDataTable(sql);
            //if (tblNVC.Rows.Count == 0)
            //{
            //    MessageBox.Show("Không có bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txttimkiem1.Text = "";
            //}
            //dataGridView1.DataSource = tblNVC;
            //sql = "select * from tblnhavanchuyen where manhavanchuyen=N'" + txttimkiem1.Text + "' or tennhavanchuyen=N'" + txttimkiem1.Text + "' or ketnoigiaohang=N'" + txttimkiem1.Text + "' or mota=N'" + txttimkiem1.Text + "' or ghichu=N'" + txttimkiem1.Text + "' ";

            //tblNVC = Class.functions.GetDataTable(sql);
            //if(tblNVC.Rows.Count==0)
            //{
            //    MessageBox.Show("Không có bản ghi nào ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //    return;

            
            if (tblNVC.Rows.Count!=0)
            {
                if (MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    sql = "delete tblnhavanchuyen where   manhavanchuyen=N'" + dataGridView1.CurrentRow.Cells["manhavanchuyen"].Value.ToString() + "' ";// chỉ xóa dòng dữ liệu đc chọn khi datagrid có 2 dòng trở nên
                    Class.functions.runsql(sql);
                    load_datagridview();
                    txttimkiem1.Text = "";

                }
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            
            
        }

        //private void txttimkiem_Enter(object sender, EventArgs e)
        //{
        //    //if(txttimkiem.Text== "Nhập từ khóa để tìm kiếm ")
        //    //{
        //    //    txttimkiem.Text = "";
        //    //    txttimkiem.ForeColor = Color.Black;

        //    //}

        

       
        //{
        //    if (txttimkiem.Text == "")
        //    {
        //        txttimkiem.Text = "Nhập từ khóa để tìm kiếm ";
        //        txttimkiem.ForeColor = Color.Silver;

        //    }
       

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Frmnhavanchuyen_Click(object sender, EventArgs e)
        {
           
        }

        private void txttimkiem1_Enter(object sender, EventArgs e)
        {
            if(txttimkiem1.Text== "Nhập để tìm kiếm ..")
            {
                txttimkiem1.Text = "";
                txttimkiem1.ForeColor = Color.Black;
            }
        }

        private void txttimkiem1_Leave(object sender, EventArgs e)
        {
            if (txttimkiem1.Text == "")
            {
                txttimkiem1.Text = "Nhập để tìm kiếm ..";
                txttimkiem1.ForeColor = Color.Silver;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string sql;

            
            if(MessageBox.Show("Bạn có muốn xóa không ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                sql = "delete tblnhavanchuyen where manhavanchuyen = N'"+dataGridView1.CurrentRow.Cells["manhavanchuyen"].Value.ToString()+"'";
                Class.functions.runsql(sql);
                load_datagridview();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
