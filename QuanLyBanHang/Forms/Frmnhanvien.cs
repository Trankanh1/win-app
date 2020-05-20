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
    public partial class Frmnhanvien : Form
    {
        public Frmnhanvien()
        {
            InitializeComponent();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

        }
        public void resetvalues()
        {
            txtcongviec.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            cbomahanvien.Text = "";
            txtngaysinh.Text = "";
            txttennhanvien.Text = "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            resetvalues();
        }

        private void Frmnhanvien_Load(object sender, EventArgs e)
        {
            txtanh.Visible = false;
            chknam.Checked = false;
            chknu.Checked = false;
            txtanh.Visible = false;
            Class.functions.fillcombo("select manhanvien from tblnhanvien", cbomahanvien, "manhanvien", "manhanvien");
            cbomahanvien.SelectedIndex = -1;



            load_datagridview();
        }
        DataTable tblNV;
        private void load_datagridview()
        {
            string sql;
            sql = "select * from tblnhanvien";
            tblNV = Class.functions.GetDataTable(sql);
            dgridnhanvien.DataSource = tblNV;
            dgridnhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dgridnhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dgridnhanvien.Columns[2].HeaderText = "Giới tính";
            dgridnhanvien.Columns[3].HeaderText = "Địa chỉ";
            dgridnhanvien.Columns[4].HeaderText = "Điện thoại";
            dgridnhanvien.Columns[5].HeaderText = "Ngày sinh";
            dgridnhanvien.Columns[6].HeaderText = "Nhiệm vụ";
            dgridnhanvien.Columns[7].HeaderText = "Ảnh";

            dgridnhanvien.Columns[0].Width = 100;
            dgridnhanvien.Columns[1].Width = 100;
            dgridnhanvien.Columns[2].Width = 100;
            dgridnhanvien.Columns[3].Width = 100;
            dgridnhanvien.Columns[4].Width = 100;
            dgridnhanvien.Columns[5].Width = 100;
            dgridnhanvien.Columns[6].Width = 100;
            dgridnhanvien.Columns[7].Width = 100;

            dgridnhanvien.AllowUserToAddRows = false;
            dgridnhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;

            Class.functions.fillcombo("select manhanvien from tblnhanvien", cbomahanvien, "manhanvien", "manhanvien");
            cbomahanvien.SelectedValue = -1;

        }

        private void dgridnhanvien_Click(object sender, EventArgs e)
        {


            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cbomahanvien.Text = dgridnhanvien.CurrentRow.Cells["manhanvien"].Value.ToString();
            txttennhanvien.Text = dgridnhanvien.CurrentRow.Cells["tennhanvien"].Value.ToString();
            txtdiachi.Text = dgridnhanvien.CurrentRow.Cells["diachi"].Value.ToString();
            txtdienthoai.Text = dgridnhanvien.CurrentRow.Cells["dienthoai"].Value.ToString();
            txtngaysinh.Text = dgridnhanvien.CurrentRow.Cells["ngaysinh"].Value.ToString();
            txtcongviec.Text = dgridnhanvien.CurrentRow.Cells["nhiemvu"].Value.ToString();
            txtanh.Text = dgridnhanvien.CurrentRow.Cells["anh"].Value.ToString();
            if(txtanh.Text != "")
            pictureBox1.Image = Image.FromFile(txtanh.Text);
            if (dgridnhanvien.CurrentRow.Cells["gioitinh"].Value.ToString().ToLower() == "nam")
            {
                chknam.Checked = true;
                chknu.Checked = false;

            }
            if (dgridnhanvien.CurrentRow.Cells["gioitinh"].Value.ToString().ToLower() == "nữ")
            {
                chknu.Checked = true;
                chknam.Checked = false;

            }


        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {




        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            resetvalues();
        }

        private void dgridnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this
                .Close();
        }

        private void cbomahanvien_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnhienthi_Click_1(object sender, EventArgs e)
        {

        }

        private void btnhienthi_Click_2(object sender, EventArgs e)
        {

        }

        private void btnhienthi_Click_3(object sender, EventArgs e)
        {
            string sql;
            sql = "select manhanvien from tblnhanvien where manhanvien ='" + cbomahanvien.SelectedValue + "'";
            tblNV = Class.functions.GetDataTable(sql);
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Mã này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
 
            txtanh.Text = Class.functions.getfieldvalues("select anh from tblnhanvien where manhanvien = '" + cbomahanvien.SelectedValue + "'");
            if(txtanh.Text != "")
            pictureBox1.Image = Image.FromFile(txtanh.Text);
            txttennhanvien.Text = Class.functions.getfieldvalues("select tennhanvien from  tblnhanvien where manhanvien ='" + cbomahanvien.SelectedValue + "'");
            txttennhanvien.Text = Class.functions.getfieldvalues("select tennhanvien from  tblnhanvien where  manhanvien ='" + cbomahanvien.SelectedValue + "'");
            txtdiachi.Text = Class.functions.getfieldvalues("select diachi from tblnhanvien where  manhanvien ='" + cbomahanvien.SelectedValue + "'");
            txtcongviec.Text = Class.functions.getfieldvalues("select nhiemvu from tblnhanvien where  manhanvien ='" + cbomahanvien.SelectedValue + "'");
            txtdienthoai.Text = Class.functions.getfieldvalues("select dienthoai from tblnhanvien where  manhanvien ='" + cbomahanvien.SelectedValue + "'");
            txtngaysinh.Text = Class.functions.getfieldvalues("select nhanxet from tblnhanvien where manhanvien ='" + cbomahanvien.SelectedValue + "'");
            string kt = "";
            sql = "select gioitinh from tblnhanvien where manhanvien ='" + cbomahanvien.SelectedValue + "'";
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

        private void cbomahanvien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txttennhanvien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void chknam_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void chknu_Click(object sender, EventArgs e)
        {

        }

        private void txtngaysinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void chknu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtdienthoai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtdiachi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtcongviec_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
