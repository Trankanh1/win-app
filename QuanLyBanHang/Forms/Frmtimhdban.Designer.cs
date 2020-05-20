namespace QuanLyBanHang.Forms
{
    partial class Frmtimhdban
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btntimkiem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmtimhdban));
            this.btntimlai = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtmahdban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmakhach = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            btntimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btntimkiem
            // 
            btntimkiem.BackColor = System.Drawing.SystemColors.ControlLight;
            btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            btntimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btntimkiem.Location = new System.Drawing.Point(469, 176);
            btntimkiem.Margin = new System.Windows.Forms.Padding(4);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new System.Drawing.Size(133, 47);
            btntimkiem.TabIndex = 30;
            btntimkiem.Text = "    Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = false;
            btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btntimlai
            // 
            this.btntimlai.BackColor = System.Drawing.Color.DarkKhaki;
            this.btntimlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimlai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntimlai.Image = ((System.Drawing.Image)(resources.GetObject("btntimlai.Image")));
            this.btntimlai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimlai.Location = new System.Drawing.Point(627, 176);
            this.btntimlai.Margin = new System.Windows.Forms.Padding(4);
            this.btntimlai.Name = "btntimlai";
            this.btntimlai.Size = new System.Drawing.Size(133, 47);
            this.btntimlai.TabIndex = 24;
            this.btntimlai.Text = "   Tìm lại";
            this.btntimlai.UseVisualStyleBackColor = false;
            this.btntimlai.Click += new System.EventHandler(this.btntimlai_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 231);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(838, 336);
            this.dataGridView1.TabIndex = 22;
            // 
            // txtmahdban
            // 
            this.txtmahdban.ForeColor = System.Drawing.Color.Silver;
            this.txtmahdban.Location = new System.Drawing.Point(142, 17);
            this.txtmahdban.Margin = new System.Windows.Forms.Padding(4);
            this.txtmahdban.Name = "txtmahdban";
            this.txtmahdban.Size = new System.Drawing.Size(220, 27);
            this.txtmahdban.TabIndex = 91;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "Mã HĐ :";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(142, 62);
            this.txtmanv.Margin = new System.Windows.Forms.Padding(4);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(220, 27);
            this.txtmanv.TabIndex = 97;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(8, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 96;
            this.label7.Text = "Mã NV :";
            // 
            // txtmakhach
            // 
            this.txtmakhach.Location = new System.Drawing.Point(540, 13);
            this.txtmakhach.Margin = new System.Windows.Forms.Padding(4);
            this.txtmakhach.Name = "txtmakhach";
            this.txtmakhach.Size = new System.Drawing.Size(220, 27);
            this.txtmakhach.TabIndex = 99;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(401, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 98;
            this.label8.Text = "Mã khách :";
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(540, 62);
            this.txttongtien.Margin = new System.Windows.Forms.Padding(4);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(220, 27);
            this.txttongtien.TabIndex = 101;
            this.txttongtien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttongtien_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(401, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 100;
            this.label9.Text = "Tổng tiền :";
            // 
            // Frmtimhdban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(844, 569);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtmakhach);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmahdban);
            this.Controls.Add(this.label4);
            this.Controls.Add(btntimkiem);
            this.Controls.Add(this.btntimlai);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmtimhdban";
            this.Text = "Tìm hóa đơn bán";
            this.Load += new System.EventHandler(this.Frmtimhdban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btntimlai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtmahdban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmakhach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label9;
    }
}