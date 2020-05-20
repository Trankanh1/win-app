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
    public partial class Frmtimhdban : Form
    {
        public Frmtimhdban()
        {
            InitializeComponent();
        }

        private void Frmtimhdban_Load(object sender, EventArgs e)
        {
           
            ResetValues();
            dataGridView1.DataSource = null;

        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtmahdban.Focus();
        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
          
            ResetValues();
            dataGridView1.DataSource = null;

        }

        private void btntimkiem1_Click(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        DataTable tblHDB;
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtmahdban.Text == "") &&(txtmanv.Text == "") && (txtmakhach.Text == "") &&(txttongtien.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yeu cau ...",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblhdban WHERE 1=1";
            if (txtmahdban.Text != "")
                sql = sql + " AND mahdban Like '%" + txtmahdban.Text + "%'";
  
            if (txtmanv.Text != "")
                sql = sql + " AND manhanvien Like '%" + txtmanv.Text + "%'";
            if (txtmakhach.Text != "")
                sql = sql + " AND makhach Like '%" + txtmakhach.Text + "%'";
            if (txttongtien.Text != "")
                sql = sql + " AND tongtien <=" + txttongtien.Text;
            
            tblHDB = Class.functions.GetDataTable(sql);
            if (tblHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblHDB.Rows.Count + " bản ghi thỏa mãn điều kiện!!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dataGridView1.DataSource = tblHDB;
            Load_DataGridView();

        }
        private void Load_DataGridView()
        {
            dataGridView1.Columns[0].HeaderText = "Mã HĐB";
            dataGridView1.Columns[1].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[2].HeaderText = "Ngày bán";
            dataGridView1.Columns[3].HeaderText = "Mã khách";
            dataGridView1.Columns[4].HeaderText = "Tổng tiền";
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 180;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void txttongtien_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;

        }
    }
}
