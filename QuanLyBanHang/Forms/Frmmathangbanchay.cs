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
    public partial class Frmmathangbanchay : Form
    {
        public Frmmathangbanchay()
        {
            InitializeComponent();
        }

        private void Frmmathangbanchay_Load(object sender, EventArgs e)
        {
            
           
        }
        DataTable tblTK;
        private void load_datagridview()
        {
            //having Month(CT.ngayban)= '" + datetimethongke.Value.Month + "' and Year(CT.ngayban) = '" + datetimethongke.Value.Year + "'
            //string sql;
            //sql = "select mahang from tblchitiethdban as CT where  Month(CT.ngayban)= '" + datetimethongke.Value.Month + "' and Year(CT.ngayban) = '" + datetimethongke.Value.Year + "'";
            //sql = "select  mahang as [Mã hàng],sum(soluong) as [Số lượng đã bán] from tblchitiethdban as A where Month(A.ngayban)= '" + datetimethongke.Value.Month + "' and Year(A.ngayban) = '" + datetimethongke.Value.Year + "' group by mahang  order by sum(soluong) DESC";
            //tblTK = Class.functions.GetDataTable(sql);
            //dataGridView1.DataSource = tblTK;
            //string sql;
            //sql = "select A.mahdban as [Mã hóa đơn] ,A.mahang as [Mã hàng],A.soluong as [ Số lượng ],A.dongia as [Đơn giá] ,A.giamgia as [Giảm giá],A.thanhtien as [Thành tiền] from tblchitiethdban as A,tblhdban as B where B.ngayban='" + DateTime.Now.ToShortDateString() + "' and A.mahdban=B.mahdban";
            //tblTK = Class.functions.GetDataTable(sql);
            //dataGridView1.DataSource = tblTK;
            //dataGridView1.DataSource = tblTDH;
            dataGridView1.Columns[0].HeaderText = "Ngày bán ";
            dataGridView1.Columns[1].HeaderText = " Mã hàng ";
            dataGridView1.Columns[2].HeaderText = "Số lượng";
            dataGridView1.Columns[3].HeaderText = "Đơn giá";
            dataGridView1.Columns[4].HeaderText = "Giảm giá";
            dataGridView1.Columns[5].HeaderText = "Thành tiền";
            
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 150;
          

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbotop.Text=="")
            {
                MessageBox.Show("Nhập tốp sản phẩm để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql;
            //sql = "select top " + Convert.ToInt32(cbotop.Text) + "   B.ngayban ,A.mahang  ,A.soluong ,A.dongia ,A.giamgia ,A.thanhtien  from tblchitiethdban as A , tblhdban as B   where  A.mahdban=B.mahdban and  (Day(B.ngayban)>='" + dateTimePicker1.Value.Day + "' and Day(B.ngayban)<='" + dateTimePicker2.Value.Day + "' and Month(B.ngayban)>='" + dateTimePicker1.Value.Month + "' and Month(B.ngayban)<='" + dateTimePicker2.Value.Month + "' and Year(B.ngayban)>='" + dateTimePicker1.Value.Year + "' and Year(B.ngayban)<= '" + dateTimePicker2.Value.Year + "' ) or ( Day(B.ngayban)<='" + dateTimePicker1.Value.Day + "' and Day(B.ngayban)>='" + dateTimePicker2.Value.Day + "' and Month(B.ngayban)<='" + dateTimePicker1.Value.Month + "' and Month(B.ngayban)>='" + dateTimePicker2.Value.Month + "' and Year(B.ngayban)<='" + dateTimePicker1.Value.Year + "' and Year(B.ngayban)>= '" + dateTimePicker2.Value.Year + "') order by A.soluong DESC ";
            sql = "select  B.ngayban ,A.mahang  ,A.soluong ,A.dongia ,A.giamgia ,A.thanhtien  from tblchitiethdban as A , tblhdban as B  where  A.mahdban=B.mahdban and  ngayban >= '" + dateTimePicker1.Value.ToShortDateString() + "'  and ngayban <= '" + dateTimePicker2.Value.ToShortDateString() + "'   limit "+  Convert.ToInt32(cbotop.Text) ;
        
            tblTK = Class.functions.GetDataTable(sql);
            dataGridView1.DataSource = tblTK;
            load_datagridview();
            //string sql;
            //sql = "select ngayban from tblchitiethdban as CT where Month(CT.ngayban)='" + datetimethongke.Value.Month + "' and Year(CT.ngayban) ='" + datetimethongke.Value.Year + "' ";
            //tblTK = Class.functions.GetDataTable(sql);
            //if (tblTK.Rows.Count == 0)
            //{
            //    MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //load_datagridview();


        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbotop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                string sql;
                sql = "select  B.ngayban as [Ngày bán] ,A.mahang as [Mã hàng],A.soluong as [ Số lượng ],A.dongia as [Đơn giá] ,A.giamgia as [Giảm giá],A.thanhtien as [Thành tiền] from tblchitiethdban as A,tblhdban as B  where  A.mahdban=B.mahdban and ( strftime('%d',B.ngayban)>='" + dateTimePicker1.Value.Day + "' and strftime('%d',B.ngayban)<='" + dateTimePicker2.Value.Day + "' and strftime('%m',B.ngayban)>='" + dateTimePicker1.Value.Month + "' and strftime('%m',B.ngayban)<='" + dateTimePicker2.Value.Month + "' and  strftime('%Y',B.ngayban)>='" + dateTimePicker1.Value.Year + "' and  strftime('%Y',B.ngayban)<= '" + dateTimePicker2.Value.Year + "' ) or (  strftime('%d',B.ngayban)<='" + dateTimePicker1.Value.Day + "' and strftime('%d',B.ngayban)>='" + dateTimePicker2.Value.Day + "' and strftime('%m',B.ngayban)<='" + dateTimePicker1.Value.Month + "' and strftime('%m',B.ngayban)>='" + dateTimePicker2.Value.Month + "' and strftime('%Y',B.ngayban)<='" + dateTimePicker1.Value.Year + "' and strftime('%Y',B.ngayban)>= '" + dateTimePicker2.Value.Year + "')  order by A.soluong DESC " + " limit " + Convert.ToInt32(cbotop.Text);
                tblTK = Class.functions.GetDataTable(sql);
                dataGridView1.DataSource = tblTK;
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
