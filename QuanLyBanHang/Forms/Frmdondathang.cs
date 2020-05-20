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
    public partial class Frmdondathang : Form
    {
        public Frmdondathang()
        {
            InitializeComponent();
        }
        public static string Madon = string.Empty;
        private void Frmdondathang_Load(object sender, EventArgs e)
        {
            txtmadonnhan.Enabled = false;
            Class.functions.fillcombo("select mahang from tblhang ", cbomahang, "mahang", "mahang");
            cbomahang.SelectedIndex = -1;
            Class.functions.fillcombo("select manhanvien,tennhanvien from tblnhanvien ", cbonvnhan, "manhanvien", "manhanvien");
            cbonvnhan.SelectedIndex = -1;
          
            Class.functions.fillcombo("select makhach,tenkhach from tblkhach ", cbomakhach, "makhach", "makhach");
            cbomakhach.SelectedIndex = -1;
        
            txtmadonnhan.Text = Madon;
            cbonvnhan.Text = Class.functions.getfieldvalues("select manhanvien from tbldonhang where madonnhan ='"+txtmadonnhan.Text+"'");
            dateTimePicker1.Text= Class.functions.getfieldvalues("select ngaynhan from tbldonhang where madonnhan ='" + txtmadonnhan.Text + "'");
            load_datagridview();
            //dataGridView1.DataSource = Class.functions.GetDataTable("select mahang ,soluong,dongia,giamgia,thanhtien from tblchitietdonhang where madonnhan=N'" + txtmadonnhan.Text + "'");
            cbomakhach.Text= Class.functions.getfieldvalues("select makhach from tbldonhang where madonnhan ='" + txtmadonnhan.Text + "'");
            txttenkhach.Text=Class.functions.getfieldvalues("select tenkhach from tbldonhang where madonnhan ='"+txtmadonnhan.Text+"'");
            txtdiachi.Text= Class.functions.getfieldvalues("select diachi from tbldonhang where madonnhan ='" + txtmadonnhan.Text + "'");
            txtdienthoai.Text= Class.functions.getfieldvalues("select dienthoai from tbldonhang where madonnhan ='" + txtmadonnhan.Text + "'");
            txttongtien.Text= Class.functions.getfieldvalues("select tongtien from tbldonhang where madonnhan ='" + txtmadonnhan.Text + "'");


        }
        DataTable tblMDH;
        private void load_datagridview()
        {
            string sql;
            sql = "select  A.mahang as [Mã hàng],B.tenhang as [Tên hàng],A.soluong as [Số lượng],A.dongia as [Đơn giá] ,A.giamgia [Giảm giá]from tblchitietdonhang as A,tblhang as B where a.mahang=b.mahang and a.madonnhan='"+txtmadonnhan.Text+"' ";
            //dataGridView1.Columns[0].Width = 120;
            //dataGridView1.Columns[1].Width = 120;
            //dataGridView1.Columns[2].Width = 120;
            //dataGridView1.Columns[3].Width = 120;
            //dataGridView1.Columns[4].Width = 120;
            tblMDH = Class.functions.GetDataTable(sql);
            dataGridView1.DataSource = tblMDH;
        }
        private void resetvaluehangs()
        {
            cbomahang.Text = "";
            txttenhang.Text = "";
            txtsoluong.Text = "";
            cbomakhach.Text = "";
         
            cbonvnhan.Text = "";
            txtdongia.Text = "";
            txtgiamgia.Text = "";
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
            string sql;
           
                if (txtmadonnhan.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập mã đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cbomahang.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (cbonvnhan.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập nhân viên nhận đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtdiachi.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdiachi.Focus();
                    return;
                }
                if (txtsoluong.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsoluong.Focus();
                    return;
                }
                if (txtdienthoai.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập số điện thoại của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdienthoai.Focus();
                    return;
                }
                sql = "SELECT mahang FROM tblchitietdonhang WHERE mahang='" + cbomahang.SelectedValue + "' AND madonnhan= '" + txtmadonnhan.Text.Trim() + "'";
                if (Class.functions.checkkey(sql))
                {
                    MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    resetvaluehangs();

                    cbomahang.Focus();
                    return;
                }

            sql = "insert into tblchitietdonhang (madonnhan,mahang,soluong,dongia,giamgia,thanhtien) values ( '" + txtmadonnhan.Text.Trim() + "','" + cbomahang.Text + "','" + txtsoluong.Text + "','" + txtdongia.Text + "','" + txtgiamgia.Text + "','" + txtthanhtien.Text + "')";

            Class.functions.runsql(sql);
            txttongtien.Text = capnhaptongtien();
            sql = "insert into tbldonhang(madonnhan ,manhanvien,ngaynhan,tenkhach,diachi,dienthoai,tongtien,makhach) values('" + txtmadonnhan.Text.Trim() + "','" + cbonvnhan.Text + "','" + dateTimePicker1.Text + "','" + txttenkhach.Text + "','" + txtdiachi.Text + "','" + txtdienthoai.Text + "','" + txttongtien.Text + "','" + cbomakhach.Text + "')";
            Class.functions.runsql(sql);
            load_datagridview();

            resethang();
        }
        private  string  capnhaptongtien()
        {
            double tt;
            string sql;
            sql = "select sum(thanhtien) from tblchitietdonhang where madonnhan='" + txtmadonnhan.Text + "'";
            tt = Convert.ToDouble(Class.functions.getfieldvalues(sql));

            return tt.ToString();


        }
             
        private void resetvalues()
        {
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            cbomakhach.Text = "";
            txttenkhach.Text = "";
            txtmadonnhan.Text = "";
            cbonvnhan.Text = "";
            cbomahang.Text = "";
            dateTimePicker1.Text = "";
            cbonvnhan.Text = "";
            txttongtien.Text = "";


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string sql;
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete tblchitietdonhang where madonnhan='" + txtmadonnhan.Text + "' and mahang='" + cbomahang.Text + "'";// madonnhan=N'" +txtmadonnhan.text+"' and mahang=N'" + datagridview .currentrow.cell[mahang].value.tostring+ "';
                Class.functions.runsql(sql);
                MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_datagridview();
                txtsoluong.Text = "";
                cbomahang.Text = "";


            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           if(tblMDH.Rows.Count==0)
            {
                MessageBox.Show("Không có dữ liệu ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
          cbomahang.Text = dataGridView1.CurrentRow.Cells["Mã hàng"].Value.ToString();
           txtsoluong.Text = dataGridView1.CurrentRow.Cells["Số lượng"].Value.ToString();
            txtdongia.Text = dataGridView1.CurrentRow.Cells["Đơn giá"].Value.ToString();
            txtgiamgia.Text=dataGridView1.CurrentRow.Cells["Đơn giá"].Value.ToString();
            txttenhang.Text=dataGridView1.CurrentRow.Cells["Tên hàng"].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblMDH.Rows.Count != 0)
            {
                MessageBox.Show("Bạn phải xóa hết hàng hóa đã chọn trước khi hủy đơn hàng này ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            else
                sql = "delete tbldonhang where madonnhan='"+txtmadonnhan.Text+"'";
            Class.functions.runsql(sql);
            resetvalues();
            resethang();

            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            //if(dataGridView1.DataSource!=null)
            //{
            //    MessageBox.Show("Bạn phải lưu đơn hàng này trước khi thêm đơn hàng mới !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
      

            resetvalues();
            // txtmadonnhan.Text = Class.functions.createkey("DH");
            string sql, ma = "";
            sql = "select * from tbldonhang ";
            DataTable dt = Class.functions.GetDataTable(sql); // lấy toàn bộ số lượng nhân viên cho vào bảng dt
            if (dt.Rows.Count <= 0)
            {
                ma = "DH00000001";
            }
            else
            {
                int k;
                ma = "DH";
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
                else if(k<10000)
                {
                    ma = ma + "0000";
                }
                else if(k<100000)
                {
                    ma = ma + "000";
                }
                else if(k<1000000)
                {
                    ma = ma + "00";
                }
                else if(k<10000000)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();

            }
            txtmadonnhan.Text = ma;

        }
        
        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
           
            if (txtmadonnhan.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           

            if (cbonvnhan.Text == "")
            {
                MessageBox.Show("Bạn phải nhập nhân viên nhận đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiachi.Focus();
                return;
            }         
            if (txtdienthoai.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số điện thoại của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdienthoai.Focus();
                return;
            }
           
            if (tblMDH.Rows.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn hàng hóa nào cho đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
          
            //sql = "select sum(thanhtien) from tblchitietdonhang where madonnhan=N'" + txtmadonnhan.Text + "'";
            //double tt;
            //tt = Convert.ToDouble(Class.functions.getfieldvalues(sql)) + Convert.ToDouble(txtphiship.Text.ToString());
            //txttongtien.Text = tt.ToString();

            //sql = "insert into tbldonhang(madonnhan ,manhanvien,ngaynhan,tenkhach,diachi,dienthoai,tongtien,makhach) values(N'" + txtmadonnhan.Text.Trim() + "',N'" + cbonvnhan.Text + "','" + dateTimePicker1.Text + "',N'" + txttenkhach.Text + "',N'" + txtdiachi.Text + "',N'" + txtdienthoai.Text + "','" + txttongtien.Text + "',N'" + cbomakhach.Text + "')";
            //Class.functions.runsql(sql);




            MessageBox.Show("Đã lưu"," Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
           dataGridView1.DataSource = null;
            resetvalues();

        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

            string sql;

            if(dataGridView1.DataSource==null)
            {
                if (MessageBox.Show("Bạn có muốn thoát không ? ", " Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.Close();
                    return;
                }
            }
            if (tblMDH.Rows.Count > 0)
            {
                if (MessageBox.Show("Bạn có muốn tiếp tục tạo đơn hàng không ? ", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    sql = "delete  tblchitietdonhang where madonnhan='" + txtmadonnhan.Text + "' ";
                    Class.functions.runsql(sql);
                    this.Close();
                }

            }
            else
                this.Close();
            
          
         

        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtmadonnhan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void cbonvnhan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void dateTimePicker1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void cbomahang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txttenkhach_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtdiachi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtdienthoai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtsoluong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void button1_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void cbomahang_TextChanged(object sender, EventArgs e)
        {

            if (cbomahang.Text == "")
            {
                txttenhang.Text = "";
                txtdongia.Text = "";

            }
            txttenhang.Text = Class.functions.getfieldvalues("select tenhang from tblhang where mahang='"+cbomahang.SelectedValue+"'");
            txtdongia.Text = Class.functions.getfieldvalues("select dongiaban from tblhang where mahang='" + cbomahang.SelectedValue+ "'");
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtsoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtsoluong.Text);
            if (txtgiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtgiamgia.Text);
            if (txtdongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtdongia.Text);
            tt = sl * dg - sl * gg * dg / 100;
            txtthanhtien.Text = tt.ToString();
        }

        private void txtgiamgia_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtsoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtsoluong.Text);
            if (txtgiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtgiamgia.Text);
            if (txtdongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtdongia.Text);
            tt = sl * dg - sl * gg * dg / 100;
            txtthanhtien.Text = tt.ToString();
        }
        private void resethang()
        {
            txtsoluong.Text = "";
            cbomahang.Text = "";
            txttenhang.Text = "";
            txtdongia.Text = "";
            txtgiamgia.Text = "";
            txtthanhtien.Text = "";
        }
        private void ddataGridView1_Click(object sender, EventArgs e)
        {

            string sql;
            if (MessageBox.Show("Bạn có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete tblchitietdonhang where madonnhan='" + txtmadonnhan.Text + "' and mahang='" + cbomahang.Text + "'";// madonnhan=N'" +txtmadonnhan.text+"' and mahang=N'" + datagridview .currentrow.cell[mahang].value.tostring+ "';
                Class.functions.runsql(sql);
                MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttongtien.Text = capnhaptongtien();
                load_datagridview();
                resethang();



            }
        }

        private void cboadkm_TextChanged(object sender, EventArgs e)
        {



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHang;
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
            exRange.Range["A1:B1"].Value = "Dreaming catcher Shop";

            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Cầu Giấy - Hà Nội";

            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0962346553";


            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "ĐƠN ĐẶT HÀNG";
            // Biểu diễn thông tin chung của hóa đơn bán
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:D6"].MergeCells = true;
            exRange.Range["C6:D6"].Value = txtmadonnhan.Text;
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:D7"].MergeCells = true;
            exRange.Range["C7:D7"].Value = txttenkhach.Text;
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:F8"].MergeCells = true;
            exRange.Range["C8:C8"].Value = txtdiachi.Text;
            exRange.Range["B9:B9"].Value = "Điện thoại:";
           
            //exRange.Range["C9:D9"].MergeCells = true;
            exRange.Range["C9:C9"].Value = txtdienthoai.Text;
            exRange.Range["B10:B10"].Value = "Phí ship :";
          
          
            sql = "SELECT b.tenhang, a.soluong, b.dongiaban, a.giamgia, a.thanhtien  FROM tblchitietdonhang AS a , tblhang AS b WHERE a.madonnhan = '" + txtmadonnhan.Text + "' AND a.mahang = b.mahang";
            tblThongtinHang = Class.functions.GetDataTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang <= tblThongtinHang.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinHang.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền :";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = txttongtien.Text;
            exRange = exSheet.Cells[4][hang + 15]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = dateTimePicker1.Value;
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = txtnhanvien.Text;
            exSheet.Name = "Hóa đơn bán";
            exApp.Visible = true;
        }

        private void cbonvnhan_TextChanged(object sender, EventArgs e)
        {

            txtnhanvien.Text = Class.functions.getfieldvalues("select tennhanvien from tblnhanvien where manhanvien='"+cbonvnhan.SelectedValue+"'");
        }

        private void cbomakhach_TextChanged(object sender, EventArgs e)
        {
            txttenkhach.Text = Class.functions.getfieldvalues("select tenkhach from tblkhach where makhach='" + cbomakhach.SelectedValue + "'");
            txtdiachi.Text = Class.functions.getfieldvalues("select diachi from tblkhach where makhach='" + cbomakhach.SelectedValue + "'");
            txtdienthoai.Text = Class.functions.getfieldvalues("select dienthoai from tblkhach where makhach='" + cbomakhach.SelectedValue + "'");
        }

        private void Frmdondathang_Click(object sender, EventArgs e)
        {

        }

        private void Frmdondathang_FormClosing(object sender, FormClosingEventArgs e)
        {
            //string sql;

            //if (dataGridView1.DataSource == null)
            //{


            //    e.Cancel = false;

            //}
            //else
            //{
            //    if (MessageBox.Show("Bạn có muốn tiếp tục tạo đơn hàng không ? ", " Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //    {
            //        sql = "delete  tblchitietdonhang where madonnhan=N'" + txtmadonnhan.Text + "' ";
            //        Class.functions.runsql(sql);
            //        e.Cancel = false;
            //        return;
            //    }
            //    else
            //        e.Cancel = true;

            //}


        }

    
    }
    
    
}
