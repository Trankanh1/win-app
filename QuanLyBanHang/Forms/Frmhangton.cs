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
    public partial class Frmhangton : Form
    {
        public Frmhangton()
        {
            InitializeComponent();
        }

        private void Frmhangton_Load(object sender, EventArgs e)
        {
            load_datagridview();
        }
        private void load_datagridview()
        {

            string sql;
            sql = "select mahang as[Mã sản phẩm],tenhang as[Tên sản phẩm],soluong as [Tồn thực tế],dongianhap as [Đơn giá nhập],dongiaban as [Đơn giá bán],ghichu  as [Ghi chú ] from tblhang ";
            dataGridView1.DataSource = Class.functions.GetDataTable(sql);

        }
    }
}
