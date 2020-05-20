using System
    ;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace QuanLyBanHang.Forms
{
    public partial class Frmadmin : Form
    {

        public Frmadmin()
        {
            InitializeComponent();
        }
        public static string Chucvu = string.Empty;
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        DataTable tblHDN, tblHDB;
        SqlCommand cmd;
        string imagelocation;
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btntongtienban_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string sql;
            if (txtmanhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanhanvien.Focus();
                return;
            }
            if (txthoten.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txthoten.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiachi.Focus();
                return;
            }
            if (txtdienthoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdienthoai.Focus();
                return;
            }
            if (chknam.Checked == false && chknu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            
            sql = "select manhanvien from tblnhanvien where manhanvien='" + txtmanhanvien.Text.Trim() + "'";

            if (Class.functions.checkkey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có ,bạn phải nhập mã khác ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanhanvien.Focus();
                txtmanhanvien.Text = "";

                return;
            }
            if (chknam.Checked == true)
            {
                sql = "insert into tblnhanvien  values ('" + txtmanhanvien.Text.Trim() + "','" + txthoten.Text.Trim() + "','" + chknam.Text.ToString() + "','" + txtdiachi.Text.Trim() + "','" + txtdienthoai.Text + "','" + dateTimePicker1.Text.Trim() + "','" + combochucvu.Text.Trim() + "','" + txtanh.Text + "','" + txtnhanxet.Text + "','" + combochucvu.Text.Trim() + "')";
                Class.functions.runsql(sql);
                Frmnhanvienhienthi.Manhanvien = txtmanhanvien.Text;
                Forms.Frmnhanvienhienthi f = new Frmnhanvienhienthi();
                f.ShowDialog();

            }
            if (chknu.Checked == true)
            {
                sql = "insert into tblnhanvien  values ('" + txtmanhanvien.Text.Trim() + "','" + txthoten.Text.Trim() + "','" + chknu.Text.ToString() + "','" + txtdiachi.Text.Trim() + "','" + txtdienthoai.Text + "','" + dateTimePicker1.Text.Trim() + "','" + combochucvu.Text.Trim() + "','" + txtanh.Text + "','" + txtnhanxet.Text + "','" + combochucvu.Text.Trim() + "')";
                Class.functions.runsql(sql);
                Frmnhanvienhienthi.Manhanvien = txtmanhanvien.Text;
                Forms.Frmnhanvienhienthi f = new Frmnhanvienhienthi();
                f.ShowDialog();

            }

            resetvaluesnhanvien();
        }


        private void button9_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlgopen = new OpenFileDialog();
            dlgopen.Filter = "all files(*.*)|*.*|BM(*.bmp)|*.bmp|GIF(*.gif)|*.gif";
            dlgopen.InitialDirectory = "D:\\";
            dlgopen.Title = "Chọn hình ảnh để hiển thị";
            if (dlgopen.ShowDialog() == DialogResult.OK)
            {
                imagelocation = dlgopen.FileName.ToString();
                pictureBox2.Image = Image.FromFile(dlgopen.FileName);
                txtanh1.Text = dlgopen.FileName;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string sql;

            if (txtmahang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbomahang.Focus();
                return;
            }
            if (txttenhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txthoten.Focus();
                return;
            }
            if (txtsoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Focus();
                return;
            }
            if (txtdongianhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdongianhap.Focus();
                return;
            }
            if (txtdongiaban.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá bán ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdongiaban.Focus();
                return;
            }
          
            sql = "select mahang from tblhang where mahang='" + cbomahang.Text.Trim() + "'";

            if (Class.functions.checkkey(sql))
            {
                MessageBox.Show("Mã hàng này đã có ,bạn phải nhập mã khác ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanhanvien.Focus();
                cbomahang.Text = "";

                return;
            }

            sql = "insert into tblhang values ('" + txtmahang.Text.Trim() + "','" + txttenhang.Text.Trim() + "','" + txtsoluong.Text + "','" + txtdongianhap.Text + "','" + txtdongiaban.Text + "','" + txtanh1.Text + "','" + txtghichu.Text + "')";
            Class.functions.runsql(sql);
            MessageBox.Show("Đã lưu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            resetvalueshang();
        }
        DataTable tblNV;
        private void button2_Click(object sender, EventArgs e)
        {

            string sql;

            sql = "select manhanvien from tblnhanvien where manhanvien='" + txtmanhanvien.Text + "'";
            tblNV = Class.functions.GetDataTable(sql);
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmanhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE from tblnhanvien WHERE manhanvien='" + txtmanhanvien.Text + "'";
                Class.functions.runsql(sql);
                pictureBox1.Image = null;
                resetvalues();
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {

            string sql;

            if (cbomahang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE from tblhang WHERE mahang='" + cbomahang.Text + "'";
                Class.functions.runsql(sql);
                MessageBox.Show("Đã xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox2.Image = null;
                resetvalues();
            }

        }
        private void resetvaluesnhanvien()
        {
            txtmanhanvien.Text = "";
            txthoten.Text = "";
            chknam.Checked = false;
            chknu.Checked = false;
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            combochucvu.Text = "";
            txtnhanxet.Text = "";
           pictureBox1.Image = null;

        }
        private void resetvalueshang()
        {
            txtanh1.Text = "";
            txtdongiaban.Text = "";
            txtdongianhap.Text = "";
            txtghichu.Text = "";
            txtsoluong.Text = "";
            txttenhang.Text = "";
            cbomahang.Text = "";
            pictureBox2.Image = null;
            dataGridView5.DataSource = null;
            txtmahang.Text = "";

        }

        private void resetvalues()
        {
            txtanh.Text = "";
            txtanh1.Text = "";
         
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            txtdongiaban.Text = "";
            txtdongianhap.Text = "";
            txtghichu.Text = "";
            txthoten.Text = "";
          
            txtsoluong.Text = "";
            txttenhang.Text = "";

            cbomahang.Text = "";
            txtmanhanvien.Text = "";
            pictureBox1.Image = null;
            pictureBox2.Image = null;
         //   dataGridView1.DataSource = null;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            resetvalueshang();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resetvaluesnhanvien();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }
        private void tabPage4_Click(object sender, EventArgs e)
        {
        }

        private void Frmadmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            //{
            //    e.Cancel = true;
            //}
        }

        private void tabPage4_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Forms.Frmtaochucvu f = new Frmtaochucvu();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txttentk.Text = "";
            txtmatkhau.Text = "";
            cbochucvu.Text = "";


        }
        DataTable tblKT;
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmatkhau.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mật khẩu cho tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmatkhau.Focus();
                return;
            }
            if (txttentk.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mật khẩu cho tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttentk.Focus();
                return;
            }
            if (txthovaten.Text == "")
            {
                MessageBox.Show("Bạn phải nhập họ và tên người dùng cho tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttentk.Focus();
                return;
            }
            string sql;
            sql = "select tendangnhap from tbltaikhoan where tendangnhap='" + txttentk.Text.Trim().ToString() + "'";

            if (Class.functions.checkkey(sql))
            {
                MessageBox.Show("Tên đăng nhập này đã có ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttentk.Text = "";

                return;

            }
            if (this.txtnhaplai.Text != txtmatkhau.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnhaplai.Text = "";

                return;


            }
            sql = "insert into tbltaikhoan(tendangnhap,matkhau,chucvu,hovaten) values ('" + txttentk.Text.Trim().ToString() + "','" + txtmatkhau.Text.Trim().ToString() + "' ,'" + cbochucvu.SelectedValue + "','" + txthovaten.Text + "')";
            Class.functions.runsql(sql);
            MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txttentk.Text = "";
            txtmatkhau.Text = "";
            txtnhaplai.Text = "";
            cbochucvu.Text = "";
            txthovaten.Text = "";


       

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void Frmadmin_Load(object sender, EventArgs e)
        {
            txtmahang.Enabled = false;
            txtmanhanvien.Enabled = false;
            string sql;
           
            sql = "select manhanvien,tennhanvien,gioitinh,chucvu  from tblnhanvien";
            tblNV = Class.functions.GetDataTable(sql);
           // dataGridView4.DataSource = tblNV;
            load_datagridview1();
            sql = "select mahang ,tenhang from tblhang";
            tblKT= Class.functions.GetDataTable(sql);
           // dataGridView5.DataSource = tblKT;
            load_datagridview2();
            
            tblHDN = Class.functions.GetDataTable(sql);
            Class.functions.fillcombo("SELECT mahang FROM tblhang", cbomahang, "mahang", "mahang");
            cbomahang.SelectedIndex = -1;

            Class.functions.fillcombo("select manhanvien from tblnhanvien ", cbomanv, "manhanvien", "manhanvien");
            cbomanv.SelectedIndex = -1;
            Class.functions.fillcombo("select manhanvien from tblnhanvien ", cbomanv, "manhanvien", "manhanvien");
            cbomanv.SelectedIndex = -1;
            Class.functions.fillcombo("select chucvu from tblchucvu ", cbochucvu, "chucvu", "chucvu");
            cbochucvu.SelectedIndex = -1;
            Class.functions.fillcombo("select chucvu from tblchucvu ", combochucvu, "chucvu", "chucvu");
            combochucvu.SelectedIndex = -1;
   
            txtanh.Visible = false;
            txtanh1.Visible = false;



        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;

            if (txtmahang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahang.Focus();
                return;
            }
            if (txttenhang.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên hàng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenhang.Focus();
                return;
            }
            if (txtsoluong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Focus();
                return;
            }
            if (txtdongianhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtdongianhap.Focus();
                return;
            }
            if (txtdongiaban.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giá bán ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdongiaban.Focus();
                return;
            }


            sql = "update tblhang set tenhang='" + txttenhang.Text + "',soluong='" + txtsoluong.Text + "',dongianhap='"+txtdongianhap.Text+"',dongiaban='"+txtdongiaban.Text+"',anh='"+txtanh1.Text+ "',ghichu='" + txtghichu.Text + "'  where mahang='"+txtmahang.Text+"'";
                Class.functions.runsql(sql);
            MessageBox.Show("Cập nhật thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetvalueshang();


           




        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select mahang,tenhang from tblhang where mahang ='" + cbomahang.SelectedValue + "'";
            tblKT= Class.functions.GetDataTable(sql);
           load_datagridview2();
            //if (tblNV.Rows.Count == 0)
            //{
            //    MessageBox.Show("Mã này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
           
            txtmahang.Text = Class.functions.getfieldvalues("select mahang from  tblhang where mahang ='" + cbomahang.SelectedValue + "'");
            txttenhang.Text = Class.functions.getfieldvalues("select tenhang from  tblhang where mahang ='" + cbomahang.SelectedValue + "'");
            txtsoluong.Text = Class.functions.getfieldvalues("select soluong from  tblhang where mahang ='" + cbomahang.SelectedValue + "'");
            txtdongianhap.Text = Class.functions.getfieldvalues("select dongianhap from  tblhang where mahang ='" + cbomahang.SelectedValue + "'");
            txtdongiaban.Text = Class.functions.getfieldvalues("select dongiaban from  tblhang where mahang ='" + cbomahang.SelectedValue + "'");
            txtanh1.Text = Class.functions.getfieldvalues("select anh from  tblhang where mahang ='" + cbomahang.SelectedValue + "'");
            txtghichu.Text = Class.functions.getfieldvalues("select ghichu from  tblhang where mahang ='" + cbomahang.SelectedValue + "'");
            if(txtanh1.Text != "")
            pictureBox2.Image = Image.FromFile(txtanh1.Text);

        }

    
        private void btnsua1_Click(object sender, EventArgs e)
        {
            if (txtmanhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanhanvien.Focus();
                return;
            }
            if (txthoten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên hàng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txthoten.Focus();
                return;
            }
            if (chknam.Checked == false && chknu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtdiachi.Focus();
                return;
            }
            if (txtdienthoai.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdienthoai.Focus();
                return;
            }
           

            string sql;
            sql = "update tblnhanvien  set tennhanvien='" + txthoten.Text.Trim() + "',diachi='" + txtdiachi.Text.Trim() + "',dienthoai='" + txtdienthoai.Text + "',ngaysinh='" + dateTimePicker1.Text.Trim() + "',gioitinh='" + chknu.Text + "',chucvu='" + combochucvu.Text.Trim() + "',anh='" + txtanh.Text + "',nhanxet='" +txtnhanxet.Text + "' where manhanvien ='"+txtmanhanvien.Text+"'";
            Class.functions.runsql(sql);
            MessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            resetvaluesnhanvien();
        }

        private void btntimkiem1_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select manhanvien,tennhanvien,gioitinh,chucvu  from tblnhanvien where  manhanvien ='" + cbomanv.SelectedValue + "'";
            tblNV = Class.functions.GetDataTable(sql);
            load_datagridview1();
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Mã này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
       
            
            txtmanhanvien.Text = Class.functions.getfieldvalues("select manhanvien from  tblnhanvien where manhanvien ='" + cbomanv.SelectedValue + "'");
            txthoten.Text = Class.functions.getfieldvalues("select tennhanvien from  tblnhanvien where manhanvien ='" + cbomanv.SelectedValue + "'");
            txtdiachi.Text = Class.functions.getfieldvalues("select diachi from tblnhanvien where manhanvien ='" + cbomanv.SelectedValue + "'");
            cbochucvu.Text = Class.functions.getfieldvalues("select chucvu from tblnhanvien where manhanvien ='" + cbomanv.SelectedValue + "'");
            txtdienthoai.Text = Class.functions.getfieldvalues("select dienthoai from tblnhanvien where manhanvien ='" + cbomanv.SelectedValue + "'");
            txtnhanxet.Text = Class.functions.getfieldvalues("select nhanxet from tblnhanvien where manhanvien ='" + cbomanv.SelectedValue + "'");
            txtanh.Text = Class.functions.getfieldvalues("select anh from tblnhanvien where manhanvien ='" + cbomanv.SelectedValue + "'");
            if (txtanh.Text != "") 
            pictureBox1.Image = Image.FromFile(txtanh.Text);
            string kt = "";
            sql = "select gioitinh from tblnhanvien where manhanvien='" + cbomanv.SelectedValue + "'";
            kt = Class.functions.getfieldvalues(sql);
            if (kt == "Nam")

            {
                chknam.Checked = true;
                chknu.Checked = false;
            }
            else
            {
                chknu.Checked = true;
                chknam.Checked = false;

            }

        }
        private void txtmatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

     
        private void txtnhaplai_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtmanhanvien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txthoten_KeyUp(object sender, KeyEventArgs e)
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

        private void combochucvu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtnhanxet_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtmahang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txttenhang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtsoluong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtdongianhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtdongiaban_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtghichu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txthovaten_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txttentk_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtmatkhau_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtnhaplai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void cbochucvu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void Frmadmin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void load_datagridview1()
        {

            dataGridView1.DataSource = tblNV;
          
            dataGridView1.Columns[0].HeaderText = "Mã NV";
            dataGridView1.Columns[1].HeaderText = "Tên NV";
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[3].HeaderText = "Công việc";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;            dataGridView1.Columns[3].Width = 180;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btntimkiem1_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            resetvaluesnhanvien();
            string sql,ma="";
            sql = "select * from tblnhanvien ";
            DataTable dt = Class.functions.GetDataTable(sql); // lấy toàn bộ số lượng nhân viên cho vào bảng dt
            if(dt.Rows.Count<=0)
            {
                ma = "NV0001";
            }
            else
            {
                int k;
                ma = "NV";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 4)); // dùng hàm substring để lấy ra kí 4 số cuối dùng trong chuỗi
                k = k + 1;
                if(k<10)
                {
                    ma = ma + "000";
                }
                else if(k<100)
                {
                    ma = ma + "00";
                }else if(k<1000)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();

            }
            txtmanhanvien.Text = ma;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            resetvalueshang();
            string sql, ma = "";
            sql = "select * from tblhang ";
            DataTable dt = Class.functions.GetDataTable(sql); // lấy toàn bộ số lượng nhân viên cho vào bảng dt
            if (dt.Rows.Count <= 0)
            {
                ma = "HH0001";
            }
            else
            {
                int k;
                ma = "HH";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 4)); // dùng hàm substring để lấy ra kí 4 số cuối dùng trong chuỗi
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "000";
                }
                else if (k < 100)
                {
                    ma = ma + "00";
                }
                else if (k < 1000)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();

            }
            txtmahang.Text = ma;
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void load_datagridview2()
        {

            dataGridView5.DataSource = tblKT;
            dataGridView5.Columns[0].HeaderText = "Mã SP";
            dataGridView5.Columns[1].HeaderText = "Tên SP";
            
            dataGridView5.Columns[0].Width = 150;
            dataGridView5.Columns[1].Width = 150;
            dataGridView5.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView5.AllowUserToAddRows = false;
            dataGridView5.EditMode = DataGridViewEditMode.EditProgrammatically;



        }
    }
}
