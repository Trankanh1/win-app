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
    public partial class yc : Form
    {
        public yc()
        {
            InitializeComponent();
        }

        private void yc_Load(object sender, EventArgs e)
        {
            loaddatacollection();
            load_datagridview();

            
        }
        DataTable tblTDH;
        private void load_datagridview()
        {
            string sql;

            sql = "select * from tbldonhang ";
            tblTDH = Class.functions.GetDataTable(sql);
            dataGridView1.DataSource = tblTDH;
            dataGridView1.Columns[0].HeaderText = "Mã đơn ";
            dataGridView1.Columns[1].HeaderText = "Ngày nhận ";
            dataGridView1.Columns[2].HeaderText = "Nhân viên";
            dataGridView1.Columns[3].HeaderText = "Tên khách";
            dataGridView1.Columns[4].HeaderText = "Địa chỉ";
            dataGridView1.Columns[5].HeaderText = "Điện thoại";
            dataGridView1.Columns[6].HeaderText = "Tổng tiền ";
            dataGridView1.Columns[7].HeaderText = "Trạng thái";
            dataGridView1.Columns[8].HeaderText = "Mã khách";
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 120;
            dataGridView1.Columns[6].Width = 120;
            dataGridView1.Columns[7].Width = 120;
            dataGridView1.Columns[8].Width = 120;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void loaddatacollection()
        {
            AutoCompleteStringCollection auto2 = new AutoCompleteStringCollection();
            string sql = "Select *   from tbldonhang ";
            SQLiteCommand com = new SQLiteCommand(sql, Class.functions.conn);
            SQLiteDataReader reader;
            reader = com.ExecuteReader();
            if (reader != null)
            {
                while (reader.Read())
                {
                    auto2.Add(reader["madonnhan"].ToString());
                   

                }
            }
            reader.Close();
            txttimkiem1.AutoCompleteCustomSource = auto2;

        }
    }
}
