using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;
namespace QuanLyBanHang.Forms
{
    public partial class Frmtkvabc : Form
    {
        public Frmtkvabc()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        DataTable tblBC, BCN, tblLN;
        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();

            label4.Enabled = false;
            //label4.Text = tblHT.Rows.Count.ToString();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            label1.Text = "Hôm nay  " + DateTime.Now.ToShortDateString();
            Class.functions.fillcombo("select manhanvien ,tennhanvien from tblnhanvien ", comboBox1, "manhanvien", "tennhanvien");
            comboBox1.SelectedIndex = -1;
            Class.functions.fillcombo("select manhanvien ,tennhanvien from tblnhanvien ", comboBox4, "manhanvien", "tennhanvien");
            comboBox4.SelectedIndex = -1;
            Class.functions.fillcombo("select manhanvien ,tennhanvien from tblnhanvien ", cbonv, "manhanvien", "tennhanvien");
            cbonv.SelectedIndex = -1;
            loadttbcngay();
            loadttbcthang();
            //string sql;
            //sql = "select  ngayban from tblhdban where ngayban='" + DateTime.Now.ToShortDateString() + "'";
            //tblBC = Class.functions.GetDataTable(sql);
            //if (tblBC.Rows.Count == 0)
            //{
            //    MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    return;
            //}


            load_datagridview();



        }
        private void loadbcquy()
        {
            string sql;

         //  sql = "select sum(b.thanhtien) from tblhdban as a,tblchitiethdban as b where month(a.ngayban) in (1,2,3)    and a.mahdban=b.mahdban";
            
        }
   
        private void loadttbcngay()
        {
            string sql;
            sql = "select sum(b.thanhtien) from tblhdban as a,tblchitiethdban as b where  a.ngayban='" + DateTime.Now.ToShortDateString() + "' and a.mahdban=b.mahdban";
            label16.Text = Class.functions.getfieldvalues(sql);
            sql = "select sum(a.soluong) from tblchitiethdban  as a,tblhdban as b where  b.ngayban= '" + DateTime.Now.ToShortDateString() + "'      and a.mahdban=b.mahdban";
            label36.Text = Class.functions.getfieldvalues(sql);
            sql = "select b.mahdban,a.ngayban,b.mahang,b.soluong,b.giamgia,b.thanhtien from tblhdban  as a,tblchitiethdban as b where a.ngayban='" + DateTime.Now.ToShortDateString() + "' and a.mahdban=b.mahdban";
            BCN = Class.functions.GetDataTable(sql);
           // MessageBox.Show()
            dataGridView3.DataSource = BCN;
            baocaongay();

            sql = "select b.mahdban,a.ngayban,b.mahang,b.soluong,c.dongianhap from tblhdban  as a,tblchitiethdban as b  ,tblhang as c where a.ngayban='" + dateTimePicker1.Value.ToShortDateString() + "'   and a.mahdban=b.mahdban and c.mahang=b.mahang";
            BCT = Class.functions.GetDataTable(sql);
            double tongnhap = 0, nhap, dt;
            for (int i = 0; i < BCT.Rows.Count; i++)
            {


                nhap = Convert.ToDouble(BCT.Rows[i][3].ToString()) * Convert.ToDouble(BCT.Rows[i][4].ToString());
                tongnhap = nhap + tongnhap;

            }

            dt = Convert.ToDouble(label16.Text);
            label17.Text = (dt - tongnhap).ToString();

            //dt = Convert.ToDouble(label16.Text);
            //label17.Text = (dt - tongnhap).ToString();
        }

        private void baocaothang()
        {
            dataGridView4.Columns[0].HeaderText = "Mã HD";
            dataGridView4.Columns[1].HeaderText = "Ngày bán";
            dataGridView4.Columns[2].HeaderText = "Mã hàng";
            dataGridView4.Columns[3].HeaderText = "Số lượng";
            dataGridView4.Columns[4].HeaderText = "Giảm giá %";
            dataGridView4.Columns[5].HeaderText = "Thành tiền";

            dataGridView4.Columns[0].Width = 180;
            dataGridView4.Columns[1].Width = 130;
            dataGridView4.Columns[2].Width = 150;
            dataGridView4.Columns[3].Width = 100;
            dataGridView4.Columns[4].Width = 120;
            dataGridView4.Columns[5].Width = 120;

            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        DataTable BCT;
        private void loadttbcthang()
        {

            string sql;
            sql = "select sum(b.thanhtien) from tblhdban as a,tblchitiethdban as b where  strftime('%m', a.ngayban)='" + DateTime.Now.Month + "'  and strftime('%Y', a.ngayban)='" + DateTime.Now.Year + "'  and a.mahdban=b.mahdban";
            label23.Text = Class.functions.getfieldvalues(sql);
            sql = "select sum(a.soluong) from tblchitiethdban  as a,tblhdban as b where   strftime('%m', b.ngayban)= '" + DateTime.Now.Month + "' and strftime('%Y', b.ngayban)= '" + DateTime.Now.Year + "'   and a.mahdban=b.mahdban";
            label37.Text = Class.functions.getfieldvalues(sql);
            sql = "select b.mahdban,a.ngayban,b.mahang,b.soluong,b.giamgia,b.thanhtien from tblhdban  as a,tblchitiethdban as b where strftime('%m', a.ngayban)='" + DateTime.Now.Month + "' and strftime('%Y', a.ngayban)='" + DateTime.Now.Year + "'   and a.mahdban=b.mahdban";
            BCT= Class.functions.GetDataTable(sql);
            dataGridView4.DataSource = BCT;
            baocaothang();
            sql = "select b.mahdban,a.ngayban,b.mahang,b.soluong,c.dongianhap from tblhdban  as a,tblchitiethdban as b  ,tblhang as c where strftime('%m', a.ngayban)='" + DateTime.Now.Month + "' and  strftime('%Y', a.ngayban)='" + DateTime.Now.Year + "'  and a.mahdban=b.mahdban and c.mahang=b.mahang";
            tblLN = Class.functions.GetDataTable(sql);
            double tongnhap = 0, nhap, dt;
            for (int i = 0; i < tblLN.Rows.Count; i++)
            {


                nhap = Convert.ToDouble(tblLN.Rows[i][3].ToString()) * Convert.ToDouble(tblLN.Rows[i][4].ToString());
                tongnhap = nhap + tongnhap;

            }
            //dt = Convert.ToDouble(label16.Text);
            //label24.Text = (dt - tongnhap).ToString();
            //label26.Text = label23.Text;
            //label25.Text = label24.Text;
        }
        private void baocaongay()
        {

            dataGridView3.Columns[0].HeaderText = "Mã HD";
            dataGridView3.Columns[1].HeaderText = "Ngày bán";
            dataGridView3.Columns[2].HeaderText = "Mã hàng";
            dataGridView3.Columns[3].HeaderText = "Số lượng";
            dataGridView3.Columns[4].HeaderText = "Giảm giá %";
            dataGridView3.Columns[5].HeaderText = "Thành tiền";

            dataGridView3.Columns[0].Width = 180;
            dataGridView3.Columns[1].Width = 130;
            dataGridView3.Columns[2].Width = 150;
            dataGridView3.Columns[3].Width = 100;
            dataGridView3.Columns[4].Width = 120;
            dataGridView3.Columns[5].Width = 120;

            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.EditMode = DataGridViewEditMode.EditProgrammatically;


        }
        DataTable tblHT;
        private void load_datagridview()
        {
            string sql;
            sql = "select B.ngayban as [Ngày bán] ,A.mahang as [Mã hàng],A.soluong as [ Số lượng ],A.dongia as [Đơn giá] ,A.giamgia as [Giảm giá],A.thanhtien as [Thành tiền] from tblchitiethdban as A,tblhdban as B where B.ngayban='" + DateTime.Now.ToShortDateString() + "' and A.mahdban=B.mahdban";
            tblBC = Class.functions.GetDataTable(sql);
            dataGridView1.DataSource = tblBC;
            sql = "select mahang as[Mã sản phẩm],tenhang as[Tên sản phẩm],soluong as [Tồn thực tế],dongianhap as [Đơn giá nhập],dongiaban as [Đơn giá bán],ghichu  as [Ghi chú ] from tblhang ";
            tblHT = Class.functions.GetDataTable(sql);
            dataGridView2.DataSource = tblHT;
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 150;
            dataGridView2.Columns[0].Width = 150;
            dataGridView2.Columns[1].Width = 150;
            dataGridView2.Columns[2].Width = 100;
            dataGridView2.Columns[3].Width = 150;
            dataGridView2.Columns[4].Width = 150;
            dataGridView2.Columns[5].Width = 150;


        }
        private void label10_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }
        private void domainUpDown1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void label8_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void label7_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbotop_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbotop_SelectedIndexChanged(object sender, EventArgs e)
        {

            string sql;
            if (panel11.BackColor == Color.Turquoise)
            {
                sql = "select B.ngayban as [Ngày bán] ,A.mahang as [Mã hàng],A.soluong as [ Số lượng ],A.dongia as [Đơn giá] ,A.giamgia as [Giảm giá],A.thanhtien as [Thành tiền] from tblchitiethdban as A,tblhdban as B where B.ngayban='" + DateTime.Now.ToShortDateString() + "' and A.mahdban=B.mahdban order by A.soluong DESC"+ " limit " + Convert.ToInt32(cbotop.Text);

                dataGridView1.DataSource = Class.functions.GetDataTable(sql);
                return;
            }
            if (panel12.BackColor == Color.Turquoise)
            {
                sql = "select B.ngayban as [Ngày bán] ,A.mahang as [Mã hàng],A.soluong as [ Số lượng ],A.dongia as [Đơn giá] ,A.giamgia as [Giảm giá],A.thanhtien as [Thành tiền] from tblchitiethdban as A,tblhdban as B where B.ngayban='" + DateTime.Now.AddDays(-1).ToShortDateString() + "' and A.mahdban=B.mahdban order by A.soluong DESC" + " limit " + Convert.ToInt32(cbotop.Text);
                dataGridView1.DataSource = Class.functions.GetDataTable(sql);
                return;
            }
            if (panel13.BackColor == Color.Turquoise)
            {
                sql = "select B.ngayban as [Ngày bán] ,A.mahang as [Mã hàng],A.soluong as [ Số lượng ],A.dongia as [Đơn giá] ,A.giamgia as [Giảm giá],A.thanhtien as [Thành tiền] from tblchitiethdban as A,tblhdban as B where   strftime('%m',B.ngayban)='" + DateTime.Today.Month + "' and A.mahdban=B.mahdban order by A.soluong DESC" + " limit " + Convert.ToInt32(cbotop.Text);
                dataGridView1.DataSource = Class.functions.GetDataTable(sql);
                return;
            }
            if (panel14.BackColor == Color.Turquoise)
            {
                sql = "select B.ngayban as [Ngày bán] ,A.mahang as [Mã hàng],A.soluong as [ Số lượng ],A.dongia as [Đơn giá] ,A.giamgia as [Giảm giá],A.thanhtien as [Thành tiền] from tblchitiethdban as A,tblhdban as B where   strftime('%m',B.ngayban)='" + DateTime.Today.AddMonths(-1).ToShortDateString() + "' and A.mahdban=B.mahdban order by A.soluong DESC" + " limit " + Convert.ToInt32(cbotop.Text);
                dataGridView1.DataSource = Class.functions.GetDataTable(sql);
                return;
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {
            panel11.BackColor = Color.Transparent;
            panel12.BackColor = Color.Turquoise;
            panel13.BackColor = Color.Transparent;
            panel14.BackColor = Color.Transparent;
            panel15.BackColor = Color.Transparent;
            if (cbotop.Text == "")
            {
                MessageBox.Show("Nhập tốp sản phẩm để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql;
            label1.Text = "Hôm qua  " + DateTime.Today.AddDays(-1).ToShortDateString();
            sql = "select  B.ngayban as [Ngày bán] ,A.mahang as [Mã hàng],A.soluong as [ Số lượng ],A.dongia as [Đơn giá] ,A.giamgia as [Giảm giá],A.thanhtien as [Thành tiền] from tblchitiethdban as A,tblhdban as B where B.ngayban='" + DateTime.Now.AddDays(-1).ToShortDateString() + "' and A.mahdban=B.mahdban order by A.soluong DESC" + " limit " + Convert.ToInt32(cbotop.Text);
            dataGridView1.DataSource = Class.functions.GetDataTable(sql);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            panel11.BackColor = Color.Transparent;
            panel12.BackColor = Color.Transparent;
            panel13.BackColor = Color.Turquoise;
            panel14.BackColor = Color.Transparent;
            panel15.BackColor = Color.Transparent;
            if (cbotop.Text == "")
            {
                MessageBox.Show("Nhập tốp sản phẩm để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql;
            label1.Text = "Tháng " + DateTime.Today.Month + "/" + DateTime.Today.Year;
            sql = "select   B.ngayban as [Ngày bán] ,A.mahang as [Mã hàng],A.soluong as [ Số lượng ],A.dongia as [Đơn giá] ,A.giamgia as [Giảm giá],A.thanhtien as [Thành tiền] from tblchitiethdban as A,tblhdban as B where  B.ngayban <= '" + DateTime.Today.AddMonths(1).AddDays(-1) + "' and  B.ngayban >= '" + new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1) + "'  and A.mahdban=B.mahdban order by A.soluong DESC" + " limit " + Convert.ToInt32(cbotop.Text);

            dataGridView1.DataSource = Class.functions.GetDataTable(sql);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel11.BackColor = Color.Transparent;
            panel12.BackColor = Color.Transparent;
            panel13.BackColor = Color.Transparent;
            panel15.BackColor = Color.Turquoise;
            panel14.BackColor = Color.Transparent;
            label1.Text = "Tháng trước  " + DateTime.Today.AddMonths(-1).Month + "/" + DateTime.Today.Year;
            if (cbotop.Text == "")
            {
                MessageBox.Show("Nhập tốp sản phẩm để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql;
            sql = "select   B.ngayban as [Ngày bán] ,A.mahang as [Mã hàng],A.soluong as [ Số lượng ],A.dongia as [Đơn giá] ,A.giamgia as [Giảm giá],A.thanhtien as [Thành tiền] from tblchitiethdban as A,tblhdban as B where strftime('%m',B.ngayban)='" + DateTime.Today.AddMonths(-1).Month + "' and strftime('%Y',B.ngayban)='" + DateTime.Today.Year + "' and A.mahdban=B.mahdban order by A.soluong DESC" + " limit " + Convert.ToInt32(cbotop.Text);
            dataGridView1.DataSource = Class.functions.GetDataTable(sql);

        }

        private void label10_Click(object sender, EventArgs e)
        {
            panel11.BackColor = Color.Turquoise;
            panel12.BackColor = Color.Transparent;
            panel13.BackColor = Color.Transparent;
            panel15.BackColor = Color.Transparent;
            panel14.BackColor = Color.Transparent;

            label1.Text = "Hôm nay  " + DateTime.Now.ToShortDateString();
            if (cbotop.Text == "")
            {
                MessageBox.Show("Nhập tốp sản phẩm để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql;
            sql = "select B.ngayban as [Ngày bán] ,A.mahang as [Mã hàng],A.soluong as [ Số lượng ],A.dongia as [Đơn giá] ,A.giamgia as [Giảm giá],A.thanhtien as [Thành tiền] from tblchitiethdban as A,tblhdban as B where B.ngayban='" + DateTime.Now.ToShortDateString() + "' and A.mahdban=B.mahdban order by A.soluong DESC" + " limit " + Convert.ToInt32(cbotop.Text);
            dataGridView1.DataSource = Class.functions.GetDataTable(sql);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel14.BackColor = Color.Turquoise;
            panel15.BackColor = Color.Transparent;
            panel11.BackColor = Color.Transparent;
            panel12.BackColor = Color.Transparent;
            panel13.BackColor = Color.Transparent;
            Forms.Frmmathangbanchay f = new Frmmathangbanchay();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select * from tblhang where soluong>0 ";
            tblHT = Class.functions.GetDataTable(sql);
            label4.Text = tblHT.Rows.Count.ToString();


        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void lblin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn in báo cáo không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Khởi động chương trình Excel
                COMExcel.Application exApp = new COMExcel.Application();
                COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
                COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
                COMExcel.Range exRange;
                string sql;
                int hang = 0, cot = 0;
                DataTable tblThongtinHH;
                exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
                exSheet = exBook.Worksheets[1];
                // Định dạng chung
                exRange = exSheet.Cells[1, 1];
                exRange.Range["A1:B3"].Font.Size = 10;
                exRange.Range["A1:B3"].Font.Name = "Times new roman";
                exRange.Range["A1:B3"].Font.Bold = true;
                exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu  xanh
                exRange.Range["A1:A1"].ColumnWidth = 7;
                exRange.Range["B1:B1"].ColumnWidth = 15;
                exRange.Range["A1:B1"].MergeCells = true;
                exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A1:B1"].Value = "TNHH Thành Phú";

                exRange.Range["A2:B2"].MergeCells = true;
                exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:B2"].Value = "Hà Nội";

                exRange.Range["A3:B3"].MergeCells = true;
                exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A3:B3"].Value = "Điện thoại: 0962346553";


                exRange.Range["C5:E5"].Font.Size = 16;
                exRange.Range["C5:E5"].Font.Name = "Times new roman";
                exRange.Range["C5:E5"].Font.Bold = true;
                exRange.Range["C5:E5"].Font.ColorIndex = 3; //Màu đỏ
                exRange.Range["C5:E5"].MergeCells = true;
                exRange.Range["C5:E5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["C5:E5"].Value = "BÁO CÁO TỒN KHO";

                sql = "SELECT mahang,tenhang ,soluong,dongianhap from tblhang where soluong>" + 0 + " ";
                tblThongtinHH = Class.functions.GetDataTable(sql);
                double tonggt = 0, gt, sl;
                //sql = "select soluong from tblhang where soluong > " + 0 + " ";
                //sl = Convert.ToDouble(Class.functions.getfieldvalues(sql));
                //sql = "select dongianhap from tblhang where soluong > " + 0 + " ";

                exRange.Range["A8:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A8:F11"].Font.Bold = false;
                exRange.Range["C11:F11"].ColumnWidth = 12;
                exRange.Range["A8:A8"].Value = "STT";
                exRange.Range["B8:B8"].Value = "Mã hàng";
                exRange.Range["C8:C8"].Value = "Tên hàng";
                exRange.Range["D8:D8"].Value = "Số lượng";
                exRange.Range["E8:E8"].Value = "Đơn giá nhập";
                //exRange.Range["F11:F11"].Value = "Thành tiền";
                for (hang = 0; hang <= tblThongtinHH.Rows.Count - 1; hang++)
                {
                    //Điền số thứ tự vào cột 1 từ dòng 12
                    exSheet.Cells[1][hang + 9] = hang + 1;
                    for (cot = 0; cot <= tblThongtinHH.Columns.Count - 1; cot++)
                        //Điền thông tin hàng từ cột thứ 2, dòng 12
                        exSheet.Cells[cot + 2][hang + 9] = tblThongtinHH.Rows[hang][cot].ToString();
                }
                exRange = exSheet.Cells[cot][hang + 11];
                exRange.Font.Bold = true;
              
                exRange = exSheet.Cells[cot + 1][hang + 11];
                exRange.Font.Bold = true;
                for (int i = 0; i < tblThongtinHH.Rows.Count; i++)
                {
                    gt = Convert.ToDouble(tblThongtinHH.Rows[i][3].ToString()) * Convert.ToDouble(tblThongtinHH.Rows[i][2].ToString());
                    tonggt = gt + tonggt;

                }
              
                exRange = exSheet.Cells[1][hang + 12]; //Ô A1 
                exRange = exSheet.Cells[4][hang + 13]; //Ô A1 
                exRange.Range["A1:C1"].MergeCells = true;
                exRange.Range["A1:C1"].Font.Italic = true;
                exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                DateTime d = DateTime.Now;
                exRange.Range["A1:C1"].Value = "Phú Thọ, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
                exRange.Range["A2:C2"].MergeCells = true;
                exRange.Range["A2:C2"].Font.Italic = true;
                exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:C2"].Value = "Nhân viên lập phiếu";
                exRange.Range["A6:C6"].MergeCells = true;
                exRange.Range["A6:C6"].Font.Italic = true;

                exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A6:C6"].Value = cbonv.Text;

                exSheet.Name = "Báo cáo tồn kho";
                exApp.Visible = true;
            }

        }
        DataTable kt;
        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            sql = " select * from tblhdban where ngayban='" + dateTimePicker1.Value.ToShortDateString() + "'";
            kt = Class.functions.GetDataTable(sql);
            if (kt.Rows.Count == 0)
            {
                MessageBox.Show("Không có hóa đơn bán trong ngày ngày  ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label17.Text = "";
                label16.Text = "";
                dataGridView3.DataSource = null;

            }
            else
                {
                sql = "select sum(b.thanhtien) from tblhdban as a,tblchitiethdban as b where  a.ngayban='" + dateTimePicker1.Value.ToShortDateString() + "' and a.mahdban=b.mahdban";
                label16.Text = Class.functions.getfieldvalues(sql);
                sql = "select sum(a.soluong) from tblchitiethdban  as a,tblhdban as b where  b.ngayban= '" + dateTimePicker1.Value.ToShortDateString() + "'      and a.mahdban=b.mahdban";
                label36.Text = Class.functions.getfieldvalues(sql);

                sql = "select b.mahdban,a.ngayban,b.mahang,b.soluong,b.giamgia,b.thanhtien from tblhdban  as a,tblchitiethdban as b where a.ngayban='" + dateTimePicker1.Value.ToShortDateString() + "' and a.mahdban=b.mahdban";
                BCN = Class.functions.GetDataTable(sql);
                dataGridView3.DataSource = BCN;
                baocaongay();


                sql = "select b.mahdban,a.ngayban,b.mahang,b.soluong,c.dongianhap from tblhdban  as a,tblchitiethdban as b  ,tblhang as c where a.ngayban='" + dateTimePicker1.Value.ToShortDateString() + "'   and a.mahdban=b.mahdban and c.mahang=b.mahang";
                BCT = Class.functions.GetDataTable(sql);
                double tongnhap = 0, nhap, dt;
                for (int i = 0; i < BCT.Rows.Count; i++)
                {


                    nhap = Convert.ToDouble(BCT.Rows[i][3].ToString()) * Convert.ToDouble(BCT.Rows[i][4].ToString());
                    tongnhap = nhap + tongnhap;

                }

                dt = Convert.ToDouble(label16.Text);
                label17.Text = (dt - tongnhap).ToString();
                
        }

   

        }

        private void label30_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu  xanh
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "TNHH Thành Phú";

            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Hà Nội";

            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0962346553";

            exRange.Range["C5:G5"].Font.Size = 16;
            exRange.Range["C5:G6"].Font.Name = "Times new roman";
            exRange.Range["C5:G6"].Font.Bold = true;
            exRange.Range["C5:G6"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C5:G6"].MergeCells = true;
            exRange.Range["C5:G6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C5:G6"].Value = "BÁO CÁO DOANH HÀNG THÁNG " + dateTimePicker2.Text;
            sql = "SELECT a.mahdban,a.mahang,a.soluong,a.dongia,a.giamgia,a.thanhtien from tblchitiethdban as a,tblhdban as b  where a.mahdban=b.mahdban  and   B.ngayban <= '" + dateTimePicker2.Value.AddMonths(1).AddDays(-1) + "' and  B.ngayban >= '" + new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, 1) + "'    ";
            tblThongtinHD = Class.functions.GetDataTable(sql);
            exRange.Range["A9:G9"].Font.Bold = true;
            exRange.Range["A9:G9"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C9:G9"].ColumnWidth = 12;
            exRange.Range["A9:A9"].Value = "STT";
            exRange.Range["B9:B9"].Value = " Mã hóa đơn ";
            exRange.Range["C9:C9"].Value = " Mã hàng ";
            exRange.Range["D9:D9"].Value = " Số lượng ";
            exRange.Range["E9:E9"].Value = " Đơn giá ";
            exRange.Range["F9:F9"].Value = " Giảm giá ";
            exRange.Range["G9:G9"].Value = " Thành tiền ";
            for (hang = 0; hang <= tblThongtinHD.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 10] = hang + 1;
                for (cot = 0; cot <= tblThongtinHD.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 10] = tblThongtinHD.Rows[hang][cot].ToString();
            }
            double tong = 0, tt;

            exRange = exSheet.Cells[cot][hang + 12];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng DT: ";
            exRange = exSheet.Cells[cot + 1][hang + 12];
            exRange.Font.Bold = true;
            for (int i = 0; i < tblThongtinHD.Rows.Count; i++)
            {
                tt = Convert.ToDouble(tblThongtinHD.Rows[i][5].ToString());
                tong = tt + tong;
            }
            exRange.Value2 = tong.ToString();
            exRange = exSheet.Cells[cot][hang + 14]; //Ô A1 
            exRange.Font.Bold = true;
            exRange.Value2 = "Lợi nhuận : ";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = label24.Text;
            exRange = exSheet.Cells[7][hang + 15];

            exRange.Font.Bold = true;



            exRange = exSheet.Cells[4][hang + 16]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = DateTime.Now;
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên lập báo cáo";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = comboBox4.Text;
            exSheet.Name = "Báo cáo hàng tháng";
            exApp.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql;
            sql = " select * from tblhdban  as b where B.ngayban <= '" + dateTimePicker2.Value.AddMonths(1).AddDays(-1).ToShortDateString() + "' and  B.ngayban >= '" + new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, 1) + "'  ";
            kt = Class.functions.GetDataTable(sql);
            if (kt.Rows.Count == 0)
            {
                MessageBox.Show("Không có hóa đơn bán trong ngày ngày  ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label23.Text = "";
                label24.Text = "";
                label25.Text = "";
                label26.Text = "";
                dataGridView4.DataSource = null;

            }
            else
            {
                sql = "select sum(b.thanhtien) from tblhdban as a,tblchitiethdban as b where  a.ngayban <= '" + dateTimePicker2.Value.AddMonths(1).AddDays(-1) + "' and  a.ngayban >= '" + new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, 1) + "'   and a.mahdban=b.mahdban";
                label23.Text = Class.functions.getfieldvalues(sql);
                sql = "select sum(a.soluong) from tblchitiethdban  as a,tblhdban as b where B.ngayban <= '" + dateTimePicker2.Value.AddMonths(1).AddDays(-1) + "' and  B.ngayban >= '" + new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, 1) + "'      and a.mahdban=b.mahdban";
                label37.Text = Class.functions.getfieldvalues(sql);

                sql = "select b.mahdban,a.ngayban,b.mahang,b.soluong,b.giamgia,b.thanhtien from tblhdban  as a,tblchitiethdban as b where a.ngayban <= '"+  dateTimePicker2.Value.AddMonths(1).AddDays(-1).ToShortDateString() + "' and  a.ngayban >= '" + new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, 1) + "'   and a.mahdban=b.mahdban";
                BCT = Class.functions.GetDataTable(sql);
                dataGridView4.DataSource = BCT;
                baocaothang();

                sql = "select b.mahdban,a.ngayban,b.mahang,b.soluong,c.dongianhap from tblhdban  as a,tblchitiethdban as b  ,tblhang as c where a.ngayban <= '" + dateTimePicker2.Value.AddMonths(1).AddDays(-1).ToShortDateString() + "' and  a.ngayban >= '" + new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, 1) + "'   and a.mahdban=b.mahdban and c.mahang=b.mahang";
                BCT = Class.functions.GetDataTable(sql);
                double tongnhap = 0, nhap, dt;
                for (int i = 0; i < BCT.Rows.Count; i++)
                {


                    nhap = Convert.ToDouble(BCT.Rows[i][3].ToString()) * Convert.ToDouble(BCT.Rows[i][4].ToString());
                    tongnhap = nhap + tongnhap;

                }
                dt = Convert.ToDouble(label23.Text);
                label24.Text = (dt - tongnhap).ToString();
                label25.Text = label24.Text;
                label26.Text = label23.Text;
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        DataTable BCQUY;
       



        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu  xanh
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "TNHH Thành Phú";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0962346553";
            exRange.Range["C6:G6"].Font.Size = 16;
            exRange.Range["C6:G6"].Font.Name = "Times new roman";
            exRange.Range["C6:G6"].Font.Bold = true;
            exRange.Range["C6:G6"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C6:G6"].MergeCells = true;
            exRange.Range["C6:G6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C6:G6"].Value = "BÁO CÁO DOANH THU NGÀY " +dateTimePicker1.Value.ToShortDateString();
         
            sql = "SELECT a.mahdban,a.mahang,a.soluong,a.dongia,a.giamgia,a.thanhtien from tblchitiethdban as a,tblhdban as b  where a.mahdban=b.mahdban  and ngayban ='" + dateTimePicker1.Value.ToShortDateString() + "' ";
            tblThongtinHD = Class.functions.GetDataTable(sql);
            exRange.Range["A9:G9"].Font.Bold = true;
            exRange.Range["A9:G9"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C9:G9"].ColumnWidth = 12;
            exRange.Range["A9:A9"].Value = "STT";
            exRange.Range["B9:B9"].Value = "Mã hóa đơn";
            exRange.Range["C9:C9"].Value = "Mã hàng";
            exRange.Range["D9:D9"].Value = "Số lượng";
            exRange.Range["E9:E9"].Value = "Đơn giá";
            exRange.Range["F9:F9"].Value = "Giảm giá";
            exRange.Range["G9:G9"].Value = "Thành tiền";
        
            for (hang = 0; hang <= tblThongtinHD.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 10] = hang + 10;
                for (cot = 0; cot <= tblThongtinHD.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 10] = tblThongtinHD.Rows[hang][cot].ToString();
            }
       
            double tong=0, tt;
            exRange = exSheet.Cells[cot][hang + 12];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng DT: ";
            exRange = exSheet.Cells[cot + 1][hang + 12];
            exRange.Font.Bold = true;
            for (int i = 0; i < tblThongtinHD.Rows.Count; i++)
            {
                tt = Convert.ToDouble(tblThongtinHD.Rows[i][5].ToString());
                tong = tt + tong;
            }

            exRange.Value2 = tong.ToString(); 
            exRange = exSheet.Cells[cot][hang + 13]; //Ô A1 
            exRange.Font.Bold = true;
            exRange.Value2 = "Lợi nhuận : ";
            exRange = exSheet.Cells[cot+1][hang + 13];
            exRange.Font.Bold = true;
            exRange.Value2 = label17.Text;
            exRange = exSheet.Cells[7][hang + 13];

            exRange.Font.Bold = true;

            exRange = exSheet.Cells[4][hang + 15]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = DateTime.Now;
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên lập báo cáo";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = comboBox1.Text;
            exSheet.Name = "Báo cáo hàng ngày";
            exApp.Visible = true;
            //if (cboquy.Text == "I")
            //{
            //    sql = "SELECT a.mahdban,a.mahang,a.soluong,a.dongia,a.giamgia,a.thanhtien from tblchitiethdban as a,tblhdban as b  where a.mahdban=b.mahdban  and  month(b.ngayban) between 1 and 3  and year(b.ngayban) ='" + dtnam.Value.Year + "'   ";
            //}
            //if(cboquy.Text=="II")
            //{
            //    sql = "SELECT a.mahdban,a.mahang,a.soluong,a.dongia,a.giamgia,a.thanhtien from tblchitiethdban as a,tblhdban as b  where a.mahdban=b.mahdban  and  month(b.ngayban) between 4 and 6  and year(b.ngayban) ='" + dtnam.Value.Year + "'   ";

            //}
            //if (cboquy.Text == "III")
            //{
            //    sql = "SELECT a.mahdban,a.mahang,a.soluong,a.dongia,a.giamgia,a.thanhtien from tblchitiethdban as a,tblhdban as b  where a.mahdban=b.mahdban  and  month(b.ngayban) between 7 and 9  and year(b.ngayban) ='" + dtnam.Value.Year + "'   ";

            //}
            //if (cboquy.Text == "IV")
            //{
            //    sql = "SELECT a.mahdban,a.mahang,a.soluong,a.dongia,a.giamgia,a.thanhtien from tblchitiethdban as a,tblhdban as b  where a.mahdban=b.mahdban  and  month(b.ngayban) between 10 and   and year(b.ngayban) ='" + dtnam.Value.Year + "'   ";

            //}
            //tblThongtinHD = Class.functions.GetDataTable(sql);
            //exRange.Range["A11:G11"].Font.Bold = true;
            //exRange.Range["A11:G11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //exRange.Range["C11:G11"].ColumnWidth = 12;
            //exRange.Range["A11:A11"].Value = "STT";
            //exRange.Range["B11:B11"].Value = "Mã hóa đơn";
            //exRange.Range["C11:C11"].Value = "Mã hàng";
            //exRange.Range["D11:D11"].Value = "Số lượng";
            //exRange.Range["E11:E11"].Value = "Đơn giá";
            //exRange.Range["F11:F11"].Value = "Giảm giá";
            //exRange.Range["G11:G11"].Value = "Thành tiền";
        }
    }
}
