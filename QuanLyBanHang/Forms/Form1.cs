using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace QuanLyBanHang.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_Validated(object sender, EventArgs e)
        {

        }

        private void btnread_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            txtfilepath.Text = op.FileName;
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            txtfilepath.Text = op.FileName;
            BinDataCsv(txtfilepath.Text);
        }
        private void BinDataCsv(string filepath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(filepath);



            if (lines.Length > 0)
            {
                string firstline = lines[0];
                string[] headerLabels = firstline.Split(',');
                foreach (string headerword in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerword));

                }


                for (int r = 1; r < lines.Length; r++)
                {

                    string[] dataWords = lines[r].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);

                }
            }
            if (dt.Rows.Count > 0)
                dgvCsv.DataSource = dt;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            using (StreamWriter sw = File.AppendText(@"C:\Users\OS\Documents\csvdemo.csv"))
            {
                sw.WriteLine(txtusername.Text + ',' + txtemail.Text + ',' + txtpassword.Text + ',' + txtconfirm.Text);
                MessageBox.Show("Data saved successfully!");

            }
        }

        private void btnthunghiem_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\OS\Documents\csvdemo.csv";
            string delimiter = ",";
            string[][] output = new string[][]{
                 new string[]{"Col 1 Row 1", "Col 2 Row 1", "Col 3 Row 1"},
                 new string[]{"Col1 Row 2", "Col2 Row 2", "Col3 Row 2"}
            };
            int length = output.GetLength(0);
            MessageBox.Show("OK");
            StringBuilder sb = new StringBuilder();
            for (int index = 0; index < length; index++)
                sb.AppendLine(string.Join(delimiter, output[index]));

            File.WriteAllText(filePath, sb.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "(*.csv)|*.csv";
            save.RestoreDirectory = true;
            if(save.ShowDialog() == DialogResult.OK)
            {
                txtconfirm.Text = save.FileName;
            }
        }
    }
}
