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
    public partial class Frmtrangthaics : Form
    {
        public Frmtrangthaics()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        public static string Trangthai;
        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblok_Click(object sender, EventArgs e)
        {
            string sql;

            if (rddonmoi.Checked == true)
            {
                sql = "update tbldonhang set trangthai='" + rddonmoi.Text + "' where madonnhan='" + Trangthai.ToString() + "'";
            
                Class.functions.runsql(sql);
                Forms.Frmtimdonhang f = new Frmtimdonhang();
                f.ShowDialog();
                this.Hide();
                return;

            }

            if (rdhuybo.Checked == true)
            {
                sql = "update tbldonhang set trangthai='" + rdhuybo.Text + "'  where madonnhan='" + Trangthai + "'";
                Class.functions.runsql(sql);

                Forms.Frmtimdonhang f = new Frmtimdonhang();
                f.ShowDialog();
                this.Hide();
                return;

            }

            if (rdthanhcong.Checked == true)
            {
                sql = "update tbldonhang set trangthai='" + rdthanhcong.Text + "'  where madonnhan='" + Trangthai + "'";
            
                Class.functions.runsql(sql);

                Forms.Frmtimdonhang f = new Frmtimdonhang();
                f.ShowDialog();
                this.Hide();
                return;

            }
            if (rdxuly.Checked == true)
            {
                sql = "update tbldonhang set trangthai='" + rdxuly.Text + "'   where madonnhan='" + Trangthai + "'";
              
                Class.functions.runsql(sql);
             
                Forms.Frmtimdonhang f = new Frmtimdonhang();
                f.ShowDialog();
                this.Hide();
                return;

            }
            if (rddanggiao.Checked == true)
            {
                sql = "update tbldonhang set trangthai='" + rddanggiao.Text + "'   where madonnhan='" + Trangthai + "'";
               
                Class.functions.runsql(sql);
                Forms.Frmtimdonhang f = new Frmtimdonhang();
                f.ShowDialog();
                this.Hide();
                return;

            }
           
          
        }
    }
}
