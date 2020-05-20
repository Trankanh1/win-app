using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QuanLyBanHang.Forms
{
    public partial class Frmhdban : Form
    {
        public Frmhdban()
        {
            InitializeComponent();
        }

        private void btndong_Click(object sender, EventArgs e)
        {

        }

        private void Frmhdban_Load(object sender, EventArgs e)
        {

            Class.functions.fillcombo("SELECT makhach FROM tblkhach", cbomakhachhang, "makhach", "makhach");
            cbomakhachhang.SelectedIndex = -1;
            Class.functions.fillcombo("SELECT manhanvien FROM tblnhanvien", cbomanhanvien, "manhanvien", "manhanvien");
            cbomanhanvien.SelectedIndex = -1;
            Class.functions.fillcombo("SELECT mahang FROM tblhang", cbomahang, "mahang", "mahang");
            cbomahang.SelectedIndex = -1;
            Class.functions.fillcombo("select mahdban from tblhdban", cbomahdtimkiem, "mahdban", "mahdban");
            cbomahdtimkiem.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtmahoadon.Text != "")
            {
                load_thongtinhd();
                btnhuyhd.Enabled = true;
                btninhd.Enabled = true;
                Load_DataGridViewChitiet();
            }
        }
        private void load_thongtinhd()
        {
            string str;
            str = "SELECT ngayban FROM tblhdban WHERE mahdban = '" + txtmahoadon.Text + "'";
            txtngayban.Text = Class.functions.ConvertdateTime(Class.functions.getfieldvalues(str));
            str = "SELECT manhanvien FROM tblhdban WHERE mahdban = '" + txtmahoadon.Text + "'";
            cbomanhanvien.Text = Class.functions.getfieldvalues(str);
            str = "SELECT makhach FROM tblhdban WHERE mahdban = '" + txtmahoadon.Text + "'";
            cbomakhachhang.Text = Class.functions.getfieldvalues(str);
            str = "SELECT tongtien FROM tblhdban WHERE mahdban = '" + txtmahoadon.Text + "'";

            txttongtien.Text = Class.functions.getfieldvalues(str);
            lblbangchu.Text = "Bằng chữ: " + Class.functions.chuyensosangchu(txttongtien.Text);


        }
        DataTable tblHDB;
        private void Load_DataGridViewChitiet()
        {
            string sql;
            sql = "SELECT a.mahang, b.tenhang, a.soluong, b.dongiaban, a.giamgia, a.thanhtien FROM tblchitiethdban AS a, tblhang AS b WHERE a.mahdban = '" + txtmahoadon.Text + "' AND a.mahang=b.mahang";
            tblHDB = Class.functions.GetDataTable(sql);
            dgridhoandonbanhang.DataSource = tblHDB;
            dgridhoandonbanhang.Columns[0].HeaderText = "Mã hàng";
            dgridhoandonbanhang.Columns[1].HeaderText = "Tên hàng";
            dgridhoandonbanhang.Columns[2].HeaderText = "Số lượng";
            dgridhoandonbanhang.Columns[3].HeaderText = "Đơn giá";
            dgridhoandonbanhang.Columns[4].HeaderText = "Giảm giá %";
            dgridhoandonbanhang.Columns[5].HeaderText = "Thành tiền";
            dgridhoandonbanhang.Columns[0].Width = 80;
            dgridhoandonbanhang.Columns[1].Width = 100;
            dgridhoandonbanhang.Columns[2].Width = 80;
            dgridhoandonbanhang.Columns[3].Width = 90;
            dgridhoandonbanhang.Columns[4].Width = 90;
            dgridhoandonbanhang.Columns[5].Width = 90;
            dgridhoandonbanhang.AllowUserToAddRows = false;
            dgridhoandonbanhang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtmahoadon.Text = "";
            txtngayban.Text = DateTime.Now.ToShortDateString();
            cbomanhanvien.Text = "";
            cbomakhachhang.Text = "";
            txttongtien.Text = "0";
            lblbangchu.Text = "Bằng chữ: ";
            cbomahang.Text = "";
            txtsoluong.Text = "";
            txtgiamgia.Text = "0";
            txtthanhtien.Text = "0";
            txttenkhachhang.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
        }

        private void ResetValuesHang()
        {
            cbomahang.Text = "";
            txtsoluong.Text = "";
            txtgiamgia.Text = "0";
            txtthanhtien.Text = "0";
        }
        private void btnluuhd_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT mahdban FROM tblhdban WHERE mahdban='" + txtmahoadon.Text + "'";
            if (!Class.functions.checkkey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (txtngayban.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtngayban.Focus();
                    return;
                }
                if (cbomanhanvien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbomanhanvien.Focus();
                    return;
                }

                sql = "INSERT INTO tblhdban(mahdban,ngayban,manhanvien,makhach,tongtien) VALUES('" + txtmahoadon.Text.Trim() + "', '" + txtngayban.Text + "','" + cbomanhanvien.SelectedValue + "','" + cbomakhachhang.SelectedValue + "','" + txttongtien.Text + "')";
                Class.functions.runsql(sql);
            }
            // Lưu thông tin của các mặt hàng
            if (cbomahang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomahang.Focus();
                return;
            }

            if ((txtsoluong.Text.Trim().Length == 0) || (txtsoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoluong.Text = "";
                txtsoluong.Focus();
                return;
            }
            if (txtgiamgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtgiamgia.Focus();
                return;
            }
            sql = "SELECT mahang FROM tblchitiethdban WHERE mahang='" + cbomahang.SelectedValue + "' AND mahdban = '" + txtmahoadon.Text.Trim() + "'";
            if (Class.functions.checkkey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValuesHang();
                cbomahang.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Class.functions.getfieldvalues("SELECT soluong FROM tblhang wHERE mahang = '" + cbomahang.SelectedValue + "'"));
            if (Convert.ToDouble(txtsoluong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Text = "";
                txtsoluong.Focus();
                return;
            }
            sql = "INSERT INTO tblchitiethdban(mahdban,mahang,soluong,dongia,giamgia,thanhtien) VALUES('" + txtmahoadon.Text.Trim() + "', '" + cbomahang.SelectedValue + "','" + txtsoluong.Text + "','" + txtdongia.Text + "','" + txtgiamgia.Text + "','" + txtthanhtien.Text + "')";
            Class.functions.runsql(sql);
            Load_DataGridViewChitiet();
            // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            SLcon = sl - Convert.ToDouble(txtsoluong.Text);
            sql = "UPDATE tblhang SET soluong =" + SLcon + " WHERE mahang= '" + cbomahang.SelectedValue + "'";
            Class.functions.runsql(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(Class.functions.getfieldvalues("SELECT tongtien FROM tblhdban WHERE mahdban = '" + txtmahoadon.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtthanhtien.Text);
            sql = "UPDATE tblhdban SET tongtien =" + Tongmoi + " WHERE mahdban = '" + txtmahoadon.Text + "'";
            Class.functions.runsql(sql);
            txttongtien.Text = Tongmoi.ToString();
            lblbangchu.Text = "Bằng chữ: " + Class.functions.chuyensosangchu(txttongtien.Text);
            ResetValuesHang();
            btnhuyhd.Enabled = true;
            btnthemdh.Enabled = true;
            btninhd.Enabled = true;

        }

        private void dgridhoandonbanhang_DoubleClick(object sender, EventArgs e)
        {
            string mahang;
            Double Thanhtien;
            //if (tblHDB.Rows.Count == 0)
            //{
            //    MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                mahang = dgridhoandonbanhang.CurrentRow.Cells["mahang"].Value.ToString();
                DelHang(txtmahoadon.Text, mahang);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                Thanhtien = Convert.ToDouble(dgridhoandonbanhang.CurrentRow.Cells["thanhtien"].Value.ToString());
                DelUpdateTongtien(txtmahoadon.Text, Thanhtien);
                Load_DataGridViewChitiet();
            }
        }
        private void DelHang(string Mahoadon, string Mahang)
        {
            Double s, sl, SLcon;
            string sql;
            sql = "SELECT soluong FROM tblchitiethdban WHERE mahdban = '" + Mahoadon + "' AND mahang = '" + Mahang + "'";
            s = Convert.ToDouble(Class.functions.getfieldvalues(sql));
            sql = "delete from tblchitiethdban WHERE mahdban="+'"' + Mahoadon + '"';
            Class.functions.runsql(sql);
            // Cập nhật lại số lượng cho các mặt hàng
            sql = "SELECT soluong FROM tblhang WHERE mahang = '" + Mahang + "'";
            sl = Convert.ToDouble(Class.functions.getfieldvalues(sql));
            SLcon = sl + s;
            sql = "UPDATE tblhang SET soluong =" + SLcon + " WHERE mahang= '" + Mahang + "'";
            Class.functions.runsql(sql);
        }
        private void DelUpdateTongtien(string Mahoadon, double Thanhtien)
        {
            Double Tong, Tongmoi;
            string sql;
            sql = "SELECT tongtien FROM tblhdban WHERE mahdban = '" + Mahoadon + "'";
            Tong = Convert.ToDouble(Class.functions.getfieldvalues(sql));
            Tongmoi = Tong - Thanhtien;
            sql = "UPDATE tblhdban SET tongtien =" + Tongmoi + " WHERE mahdban = '" + Mahoadon + "'";
            Class.functions.runsql(sql);
            txttongtien.Text = Tongmoi.ToString();
            lblbangchu.Text = "Bằng chữ: " + Class.functions.chuyensosangchu(Tongmoi.ToString());


        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {

            if (cbomahdtimkiem.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomahdtimkiem.Focus();
                return;
            }
            txtmahoadon.Text = cbomahdtimkiem.Text;
            load_thongtinhd();
            Load_DataGridViewChitiet();
            btnhuyhd.Enabled = true;
            btnthemdh.Enabled = true;
            btnthemdh.Enabled = true;
            cbomahdtimkiem.SelectedIndex = -1;
        }

        private void btnthemdh_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void btnthemdh_Click(object sender, EventArgs e)
        {
            btnhuyhd.Enabled = false;
            btnluuhd.Enabled = true;
            btninhd.Enabled = false;
            btnthemdh.Enabled = false;
            ResetValues();
            txtmahoadon.Text = Class.functions.createkey("HDB");
            Load_DataGridViewChitiet();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbomanhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbomanhanvien_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomanhanvien.Text == "")

                txttennhanvien.Text = "";
            str = "select tennhanvien from tblnhanvien where manhanvien ='" + cbomanhanvien.SelectedValue + "'";
            txttennhanvien.Text = Class.functions.getfieldvalues(str);

        }

        private void cbomakhachhang_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomakhachhang.Text == "")
            {
                txttenkhachhang.Text = "";
                txtdiachi.Text = "";
                txtdienthoai.Text = "";

            }
            str = "select tenkhach from tblkhach where makhach='" + cbomakhachhang.SelectedValue + "'";
            txttenkhachhang.Text = Class.functions.getfieldvalues(str);
            str = "select diachi from tblkhach where makhach='" + cbomakhachhang.SelectedValue + "'";
            txtdiachi.Text = Class.functions.getfieldvalues(str);
            str = "select dienthoai from tblkhach where makhach='" + cbomakhachhang.SelectedValue + "'";
            txtdienthoai.Text = Class.functions.getfieldvalues(str);


        }

        private void cbomahang_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomahang.Text == "")
            {
                txttenhang.Text = "";
                txtdongia.Text = "";

            }
            str = "select tenhang from tblhang where mahang ='" + cbomahang.SelectedValue + "'";
            txttenhang.Text = Class.functions.getfieldvalues(str);
            str = "select dongiaban from tblhang where mahang ='" + cbomahang.SelectedValue + "'";
            txtdongia.Text = Class.functions.getfieldvalues(str);
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            double tt = 0, sl = 0, dg = 0, gg = 0;

            if (txtsoluong.Text != "")
            {
                //double dd;
                //dd = Convert.ToDouble(txtsoluong.Text);

                //if (dd >= 10 && dd < 15)

                //    txtgiamgia.Text = "0.1";


                //if (dd <= 25 && dd >= 15)
                //    txtgiamgia.Text = "0.15";

                sl = Convert.ToDouble(txtsoluong.Text);

            }
            if (txtgiamgia.Text != "")
            {
                gg = Convert.ToDouble(txtgiamgia.Text);
            }
            else
                gg = 0;
            if (txtdongia.Text != "")
            {
                dg = Convert.ToDouble(txtdongia.Text);
            }
            tt = sl * dg - sl * gg * dg/100;

            txtthanhtien.Text = tt.ToString();


        }

        private void txtgiamgia_TextChanged(object sender, EventArgs e)
        {
           
            double tt = 0, sl = 0, dg = 0, gg = 0;

            if (txtsoluong.Text != "")
            {
            //    double dd;
            //    dd = Convert.ToDouble(txtsoluong.Text);
               
            //    if (dd >= 10 && dd < 15)

            //        txtgiamgia.Text = "0.1";


            //    if (dd <= 25 && dd >= 15)
            //        txtgiamgia.Text = "0.15";
                
                sl = Convert.ToDouble(txtsoluong.Text);

            }
            if (txtgiamgia.Text != "")
            {
                gg = Convert.ToDouble(txtgiamgia.Text);
            }
            else
                gg = 0;
            if (txtdongia.Text != "")
            {
                dg = Convert.ToDouble(txtdongia.Text);
            }
            tt = sl * dg - sl * gg * dg/100;

            txtthanhtien.Text = tt.ToString();

        }

        private void btnhuyhd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] Mahang = new string[20];
                string sql;
                int n = 0;
                int i;
                sql = "SELECT mahang FROM tblchitiethdban WHERE mahdban = '" + txtmahoadon.Text + "'";
                SQLiteCommand cmd = new SQLiteCommand(sql, Class.functions.conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Mahang[n] = reader.GetString(0).ToString();
                    n = n + 1;
                }
                reader.Close();
                sql = "DELETE from tblhdban WHERE mahdban="+'"' + txtmahoadon.Text +'"';
                Class.functions.runsql(sql);
                //Xóa danh sách các mặt hàng của hóa đơn
                for (i = 0; i <= n - 1; i++)
                    DelHang(txtmahoadon.Text, Mahang[i]);

               
                ResetValues();
                Load_DataGridViewChitiet();
                MessageBox.Show("Xoa thanh cong");
            }

        }

        private void btninhd_Click(object sender, EventArgs e)
        {

            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
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
            exRange.Range["A1:B1"].Value = "TNHH NamKang";

            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Phú Thọ";

            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0962346553";


            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Name = "Times new roman";
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            //sql = "SELECT a.mahdban, a.ngayban, a.tongtien, b.tenkhach, b.diachi, b.dienthoai, c.tennhanvien FROM tblhdban AS a, tblkhach AS b, tblnhanvien AS c WHERE a.mahdban = N'" + txtmahoadon.Text + "' AND a.makhach = b.makhach AND a.manhanvien =c.manhanvien";
            sql = "select a.mahdban ,a.ngayban,a.tongtien,b.tennhanvien  from  tblhdban as a,tblnhanvien as   b where a.manhanvien=b.manhanvien and   a.mahdban = '" + txtmahoadon.Text + "'";
            tblThongtinHD = Class.functions.GetDataTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:D6"].MergeCells = true;
            exRange.Range["C6:D6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:D7"].MergeCells = true;
            exRange.Range["C7:D7"].Value = txttenkhachhang.Text;
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:D8"].MergeCells = true;
            exRange.Range["C8:C8"].Value = txtdiachi.Text;
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            //exRange.Range["C9:D9"].MergeCells = true;
            exRange.Range["C9:C9"].Value = txtdienthoai.Text;
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.tenhang, a.soluong, b.dongiaban, a.giamgia, a.thanhtien  FROM tblchitiethdban AS a , tblhang AS b WHERE a.mahdban = '" + txtmahoadon.Text + "' AND a.mahang = b.mahang";
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
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:F1"].Value = "Bằng chữ: " + Class.functions.chuyensosangchu(tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Phú Thọ, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][3];
            exSheet.Name = "Hóa đơn bán";
            exApp.Visible = true;



        }
        private void btnluuhd_ClientSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
