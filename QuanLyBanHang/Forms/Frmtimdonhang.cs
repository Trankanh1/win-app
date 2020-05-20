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
    public partial class Frmtimdonhang : Form
    {
        public Frmtimdonhang()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        DataTable tblTDH;
        private void btntimkiem_Click(object sender, EventArgs e)
        {

            string sql;
            sql = "select madonnhan as [Số] ,manhanvien as[ Nhân viên] ,ngaynhan as [Ngày nhận] ,mahang as [Mã hàng] ,tenkhach as [Tên khách],diachi as [Địa chỉ] ,dienthoai as [Điện thoại] ,soluong as [Số lượng] from tbldonhang as N where ( Day(N.ngaynhan)>='"+dateTimePicker1.Value.Day+"' and and Month(N.ngaynhan)>='"+dateTimePicker1.Value.Month+"' and Year(N.ngaynhan)>='"+dateTimePicker1.Value.Year+"' or ( Day(N.ngaynhan)<='"+dateTimePicker1.Value.Day+"' and Month(N.ngaynhan)<='"+dateTimePicker1.Value.Month +"' and and Year(N.ngaynhan)<='"+dateTimePicker1.Value.Year+"') ";
            tblTDH = Class.functions.GetDataTable(sql);
            dataGridView1.DataSource = tblTDH;
            load_datagridview();

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmtimdonhang_Load(object sender, EventArgs e)
        {
          
           label7.Text =  Class.functions.getfieldvalues("select count(*) from tbldonhang where ngaynhan ='" + DateTime.Now.ToString("MM/dd/yyyy") + "'");
            MessageBox.Show("select count(*) from tbldonhang where ngaynhan ='" + DateTime.Now.ToString("MM/dd/yyyy") + "'");
            label6.Text = "( "  +DateTime.Now.ToString("MM/dd/yyyy") + " )";
            dateTimePicker1.Text = DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy");
           // dateTimePicker2.Text = DateTime.Now.ToShortDateString();
            string sql;
            sql = "SELECT * FROM tbldonhang where ngaynhan >= '" + dateTimePicker1.Value.ToString("MM/dd/yyyy")+"'";

            // sql = "select N.madonnhan,N.ngaynhan,v.tennhanvien,n.tenkhach,n.diachi,n.dienthoai,n.tongtien,n.trangthai from tbldonhang as N ,tblnhanvien as V  where  n.manhanvien =v.manhanvien  and  ( Day(N.ngaynhan)>='" + dateTimePicker1.Value.Day + "' and Day(N.ngaynhan)<='" + dateTimePicker2.Value.Day + "' and Month(N.ngaynhan)>='" + dateTimePicker1.Value.Month + "' and Month(N.ngaynhan)<='" + dateTimePicker2.Value.Month + "' and Year(N.ngaynhan)>='" + dateTimePicker1.Value.Year + "' and Year(N.ngaynhan)<= '" + dateTimePicker2.Value.Year + "' ) or ( Day(N.ngaynhan)<='" + dateTimePicker1.Value.Day + "' and Day(N.ngaynhan)>='" + dateTimePicker2.Value.Day + "' and Month(N.ngaynhan)<='" + dateTimePicker1.Value.Month + "' and Month(N.ngaynhan)>='" + dateTimePicker2.Value.Month + "' and Year(N.ngaynhan)<='" + dateTimePicker1.Value.Year + "' and Year(N.ngaynhan)>= '" + dateTimePicker2.Value.Year + "') ";
            // sql = "select N.madonnhan,N.ngaynhan,v.tennhanvien,n.tenkhach,n.diachi,n.dienthoai,n.tongtien,n.trangthai ,n.makhach from tbldonhang as N ,tblnhanvien as V  where  n.manhanvien =v.manhanvien  and strftime('%m/%d/%Y',  N.ngaynhan) between  '" + dateTimePicker1.Value.ToShortDateString() + "' and  '" + DateTime.Now.ToShortDateString() + "' ";
            tblTDH = Class.functions.GetDataTable(sql);
            dataGridView1.DataSource = tblTDH;
            load_datagridview();
          
            loaddatacollection();
        }
        private void load_datagridview()
        {
        //    string sql;
         
        //    sql = "select * from tbldonhang ";
        //    tblTDH = Class.functions.GetDataTable(sql);
        //    dataGridView1.DataSource =tblTDH;
            dataGridView1.Columns[0].HeaderText = "Mã đơn ";
            dataGridView1.Columns[1].HeaderText = "Nhân viên ";
            dataGridView1.Columns[2].HeaderText = "Ngày nhận";
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
                   // auto2.Add(reader["ngaynhan"].ToString());
                    auto2.Add(reader["tongtien"].ToString());
                    auto2.Add(reader["manhanvien"].ToString());
                    
                    auto2.Add(reader["tenkhach"].ToString());
                    auto2.Add(reader["diachi"].ToString());
                    auto2.Add(reader["dienthoai"].ToString());
                    auto2.Add(reader["trangthai"].ToString());

                }
            }
            reader.Close();
            txttimkiem1.AutoCompleteCustomSource = auto2;

        }
       
        private void btntimkiem_Click_1(object sender, EventArgs e)
        {
            string sql;
            // sql = "select * from tbldonhang as N where (( Day(N.ngaynhan)>='" + dateTimePicker1.Value.Day + "' and Day(N.ngaynhan)<='" + dateTimePicker2.Value.Day + "' and Month
            // sql = "select * from tbldonhang as N where (( Day(N.ngaynhan)>='" + dateTimePicker1.Value.Day + "' and Day(N.ngaynhan)<='" + dateTimePicker2.Value.Day + "' and Month(N.ngaynhan)>='" + dateTimePicker1.Value.Month + "' and Month(N.ngaynhan)<='" + dateTimePicker2.Value.Month + "' and Year(N.ngaynhan)>='" + dateTimePicker1.Value.Year + "' and Year(N.ngaynhan)<= '" + dateTimePicker2.Value.Year + "' ) or ( Day(N.ngaynhan)<='" + dateTimePicker1.Value.Day + "' and Day(N.ngaynhan)>='" + dateTimePicker2.Value.Day + "' and Month(N.ngaynhan)<='" + dateTimePicker1.Value.Month + "' and Month(N.ngaynhan)>='" + dateTimePicker2.Value.Month + "' and Year(N.ngaynhan)<='" + dateTimePicker1.Value.Year + "' and Year(N.ngaynhan)>= '" + dateTimePicker2.Value.Year + "')) ";
            sql = "SELECT * FROM tbldonhang where ngaynhan >= '"+ dateTimePicker1.Value.ToString("MM/dd/yyyy") +"'";
         
            //sql = "select * from tbldonhang  where ngaynhan>='" + dateTimePicker1.Value.ToShortDateString() + "' and ngaynhan<='" + dateTimePicker2.Value.ToShortDateString() + "' and ngaynhan<='" + dateTimePicker1.Value.ToShortDateString() + "' and ngaynhan>='" + dateTimePicker2.Value.ToShortDateString() + "' and 1=1 ";
            tblTDH = Class.functions.GetDataTable(sql);
            dataGridView1.DataSource = tblTDH;
            load_datagridview();
        }

        private void txttimkiem1_Enter(object sender, EventArgs e)
        {
            if (txttimkiem1.Text == "Nhập để tìm kiếm ..")
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

        private void lbltimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select * from tbldonhang where madonnhan='" + txttimkiem1.Text + "' or manhanvien='" + txttimkiem1.Text + "'  or tenkhach='" + txttimkiem1.Text + "' or diachi='" + txttimkiem1.Text + "' or  dienthoai='" + txttimkiem1.Text + "' or trangthai='" +txttimkiem1.Text + "'  ";
            tblTDH = Class.functions.GetDataTable(sql);
            if (tblTDH.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttimkiem1.Text = "";
            }
            dataGridView1.DataSource = tblTDH;
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }


        private void lblcapnhat_Click(object sender, EventArgs e)
        {
            if(tblTDH.Rows.Count==0)
            {
                MessageBox.Show("Không có bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Frmtrangthaics.Trangthai = dataGridView1.CurrentRow.Cells["madonnhan"].Value.ToString();
            this.Hide();
            Forms.Frmtrangthaics f = new Frmtrangthaics();
            f.ShowDialog();
           
        }

        private void lbltimkiem_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
           
            Frmdondathang f = new Frmdondathang();
            Frmdondathang.Madon = dataGridView1.CurrentRow.Cells["madonnhan"].Value.ToString();
            f.ShowDialog();
        }

        private void txttimkiem1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
