using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLyBanHang
{
    public partial class Frmchinh : Form
    {
        public Frmchinh()
        {
            InitializeComponent();
        }

        private void btnmini_Click(object sender, EventArgs e)
        {
            pnlmain.Width = (pnlmain.Width == 256) ? 60 : 256;
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            lblmain.Text = btnadmin.Text;
            Forms.Frmadmindangnhapcs f = new Forms.Frmadmindangnhapcs();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
            
          


        }

        private void btndanhmuc_Click(object sender, EventArgs e)
        {
            lblmain.Text = btndanhmuc.Text;      
           
            Forms.Frmdanhmuc0 f = new Forms.Frmdanhmuc0();
            f.ShowDialog();
           
          
        }

        private void btnnhapxuat_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void btnnhapxuat_Click(object sender, EventArgs e)
        {
            lblmain.Text = btnnhapxuat.Text;
           
            Forms.Frmhdnhapxuatcs f = new Forms.Frmhdnhapxuatcs();
            f.ShowDialog();
            
            
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            lblmain.Text = btntimkiem.Text;
          
            Forms.Frmtimkiem f = new Forms.Frmtimkiem();
            f.ShowDialog();



        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
           
            Forms.Frmtkvabc f = new Forms.Frmtkvabc();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();

        }

        private void btntrogiup_Click(object sender, EventArgs e)
        {
            lblmain.Text = btntrogiup.Text;
            
           
            Forms.Frmtrogiup f = new Forms.Frmtrogiup();
            f.ShowDialog();
           
        }
        public static string Tendangnhap = string.Empty;

        private void Frmphucs_Load(object sender, EventArgs e)
        {
            Class.functions.connect();
            this.lbltendangnhap.Text =Tendangnhap;
            thongtin();
            
        }

        private void btnhang_Click(object sender, EventArgs e)
        {
            Forms.Frmhanghoa f = new Forms.Frmhanghoa();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();

        }

      

        private void btnnhan_Click(object sender, EventArgs e)
        {
            Forms.Frmnhanvien f = new Forms.Frmnhanvien();
            f.StartPosition = FormStartPosition.CenterScreen;
           f.ShowDialog();

        }

        private void btnhdnhap_Click(object sender, EventArgs e)
        {
            Forms.Frmhdnhap f = new Forms.Frmhdnhap();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
           
        }

        private void btnhdxuat_Click(object sender, EventArgs e)
        {
            Forms.Frmhdban f = new Forms.Frmhdban();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void btndonhang_Click(object sender, EventArgs e)
        {
            Forms.Frmdondathang f = new Forms.Frmdondathang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void btnmathang_Click(object sender, EventArgs e)
        {

            Forms.Frmmauhang f = new Forms.Frmmauhang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void btnnhacungcap_Click(object sender, EventArgs e)
        {
            Forms.Frmnhacungcap f = new Forms.Frmnhacungcap();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void btntkhdban_Click(object sender, EventArgs e)
        {

            Forms.Frmtimhdban f = new Forms.Frmtimhdban();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void btntkhdnhap_Click(object sender, EventArgs e)
        {

            Forms.Frmhdnhap f = new Forms.Frmhdnhap();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void btntkdonhang_Click(object sender, EventArgs e)
        {

            Forms.Frmtimdonhang f = new Forms.Frmtimdonhang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void btnhangton_Click(object sender, EventArgs e)
        {

            Forms.Frmhangton f = new Forms.Frmhangton();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void btnhangbanchay_Click(object sender, EventArgs e)
        {
            Forms.Frmmathangbanchay f = new Forms.Frmmathangbanchay();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void btndathang_Click(object sender, EventArgs e)
        {
            Forms.Frmdondathang f = new Forms.Frmdondathang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.Frmnhavanchuyen f = new Forms.Frmnhavanchuyen();
            f.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel37_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Class.functions.disconnect();
        }

        private void pnlmain_Paint(object sender, PaintEventArgs e)
        {

        }
        private void thongtin()
        {
            string sql;
            //;
            //sql = "select count(madonnhan) from tbldonhang where ngaynhan='" + DateTime.Now.AddDays(-1).ToShortDateString() + "'";
            //            label15.Text = Class.functions.getfieldvalues(sql);
            //            sql = " select count(madonnhan) from tbldonhang where ngaynhan='" + DateTime.Now.AddDays(-1).ToShortDateString() + "' and trangthai is null ";
            //            label17.Text = Class.functions.getfieldvalues(sql);
            //            sql = " select count(madonnhan) from tbldonhang where ngaynhan='" + DateTime.Now.AddDays(-1).ToShortDateString() + "' and trangthai not like N'' ";
            //            label16.Text = Class.functions.getfieldvalues(sql);
            //            sql = " select count(madonnhan) from tbldonhang where ngaynhan='" + DateTime.Now.AddDays(-1).ToShortDateString() + "' and trangthai like N'Hủy bỏ'  ";
            //label18.Text = Class.functions.getfieldvalues(sql);
            //sql = "select count(mahang) from tblhang ";
            //label19.Text = Class.functions.getfieldvalues(sql);
            //sql = "select top 1 soluong from tblhang order by soluong desc ";
            //label20.Text= Class.functions.getfieldvalues(sql);
            //sql = "select top 1 mahang from tblhang order by soluong desc ";
            //label24.Text = Class.functions.getfieldvalues(sql);
            //sql = "select count(mahang) from tblhang where soluong =0 ";
            //label21.Text= Class.functions.getfieldvalues(sql);
            //sql = "select count(mahang) from tblhang where soluong in (1,2,3,4,5) ";
            //label22.Text = Class.functions.getfieldvalues(sql); ;


        }
        private void btnmini_ClientSizeChanged(object sender, EventArgs e)
        { 

        }
        
      
        
        private void btndanhmuc_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btndanhmuc_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void btndanhmuc_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void btndanhmuc_Move(object sender, EventArgs e)
        {
            
        }

        private void btndanhmuc_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void btnnhapxuat_MouseHover(object sender, EventArgs e)
        {
           
           
        }

        private void btndathang_Click_1(object sender, EventArgs e)
        {
            Forms.Frmdondathang f = new Forms.Frmdondathang();
            f.ShowDialog();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Forms.Frmtimdonhang f = new Forms.Frmtimdonhang();
            f.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Forms.Frmhanghoa f = new Forms.Frmhanghoa();
            f.ShowDialog();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void lblmain_Click(object sender, EventArgs e)
        {

        }
    }
    
}
