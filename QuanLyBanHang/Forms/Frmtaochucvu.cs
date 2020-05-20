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
    public partial class Frmtaochucvu : Form
    {
        public Frmtaochucvu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void resetvalues()
        {
            txtbophan.Text = "";
            txtquyen.Text = "";

        }
        private void button2_Click(object sender, EventArgs e)
        {

            string sql;
            sql = "insert into tblchucvu values('"+txtquyen.Text+"','"+txtbophan.Text+"')";
            Class.functions.runsql(sql);
            Frmadmin.Chucvu = txtquyen.Text.ToString();
            Frmadmin f = new Frmadmin();
            f.ShowDialog();
           
          
            this.Close();

        }

        private void button2_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void Frmtaochucvu_Load(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtquyen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtbophan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
