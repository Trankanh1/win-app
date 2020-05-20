namespace QuanLyBanHang.Forms
{
    partial class Frmhanghoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmhanghoa));
            this.btnboqua = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.txtanh = new System.Windows.Forms.TextBox();
            this.lblmahang = new System.Windows.Forms.Label();
            this.dgridhanghoa = new System.Windows.Forms.DataGridView();
            this.cbomahang = new System.Windows.Forms.ComboBox();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.lbltenhang = new System.Windows.Forms.Label();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.txtdongiaban = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtdongianhap = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgridhanghoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnboqua
            // 
            this.btnboqua.BackColor = System.Drawing.Color.Teal;
            this.btnboqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnboqua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnboqua.Location = new System.Drawing.Point(880, 714);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(118, 60);
            this.btnboqua.TabIndex = 78;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = false;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btndong
            // 
            this.btndong.BackColor = System.Drawing.Color.Teal;
            this.btndong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndong.Location = new System.Drawing.Point(1043, 714);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(113, 60);
            this.btndong.TabIndex = 75;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = false;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // txtanh
            // 
            this.txtanh.Location = new System.Drawing.Point(294, 462);
            this.txtanh.Name = "txtanh";
            this.txtanh.Size = new System.Drawing.Size(447, 22);
            this.txtanh.TabIndex = 70;
            // 
            // lblmahang
            // 
            this.lblmahang.AutoSize = true;
            this.lblmahang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmahang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblmahang.Location = new System.Drawing.Point(14, 13);
            this.lblmahang.Name = "lblmahang";
            this.lblmahang.Size = new System.Drawing.Size(83, 20);
            this.lblmahang.TabIndex = 57;
            this.lblmahang.Text = "Mã hàng :";
            // 
            // dgridhanghoa
            // 
            this.dgridhanghoa.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgridhanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridhanghoa.Location = new System.Drawing.Point(18, 394);
            this.dgridhanghoa.Name = "dgridhanghoa";
            this.dgridhanghoa.RowTemplate.Height = 24;
            this.dgridhanghoa.Size = new System.Drawing.Size(1138, 314);
            this.dgridhanghoa.TabIndex = 73;
            this.dgridhanghoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridhanghoa_CellContentClick);
            this.dgridhanghoa.Click += new System.EventHandler(this.dgridhanghoa_Click);
            // 
            // cbomahang
            // 
            this.cbomahang.FormattingEnabled = true;
            this.cbomahang.Location = new System.Drawing.Point(166, 9);
            this.cbomahang.Name = "cbomahang";
            this.cbomahang.Size = new System.Drawing.Size(250, 24);
            this.cbomahang.TabIndex = 85;
            this.cbomahang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbomahang_KeyUp);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(463, 5);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(54, 38);
            this.btntimkiem.TabIndex = 86;
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // lbltenhang
            // 
            this.lbltenhang.AutoSize = true;
            this.lbltenhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenhang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltenhang.Location = new System.Drawing.Point(14, 65);
            this.lbltenhang.Name = "lbltenhang";
            this.lbltenhang.Size = new System.Drawing.Size(88, 20);
            this.lbltenhang.TabIndex = 58;
            this.lbltenhang.Text = "Tên hàng :";
            // 
            // txttenhang
            // 
            this.txttenhang.Location = new System.Drawing.Point(166, 55);
            this.txttenhang.Multiline = true;
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(250, 30);
            this.txttenhang.TabIndex = 60;
            this.txttenhang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttenhang_KeyUp);
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoluong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblsoluong.Location = new System.Drawing.Point(14, 121);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(84, 20);
            this.lblsoluong.TabIndex = 62;
            this.lblsoluong.Text = "Số lượng :";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(166, 110);
            this.txtsoluong.Multiline = true;
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(250, 31);
            this.txtsoluong.TabIndex = 63;
            this.txtsoluong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtsoluong_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(14, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 64;
            this.label7.Text = "Đơn giá nhập :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(14, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Đơn giá bán :";
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(166, 283);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(250, 88);
            this.txtghichu.TabIndex = 72;
            this.txtghichu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtghichu_KeyUp);
            // 
            // txtdongiaban
            // 
            this.txtdongiaban.Location = new System.Drawing.Point(166, 223);
            this.txtdongiaban.Multiline = true;
            this.txtdongiaban.Name = "txtdongiaban";
            this.txtdongiaban.Size = new System.Drawing.Size(250, 31);
            this.txtdongiaban.TabIndex = 67;
            this.txtdongiaban.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdongiaban_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(14, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 71;
            this.label9.Text = "Ghi chú :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtdongianhap
            // 
            this.txtdongianhap.Location = new System.Drawing.Point(166, 166);
            this.txtdongianhap.Multiline = true;
            this.txtdongianhap.Name = "txtdongianhap";
            this.txtdongianhap.Size = new System.Drawing.Size(250, 32);
            this.txtdongianhap.TabIndex = 66;
            this.txtdongianhap.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdongianhap_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(543, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // Frmhanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1190, 786);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.cbomahang);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.dgridhanghoa);
            this.Controls.Add(this.txtghichu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtanh);
            this.Controls.Add(this.txtdongiaban);
            this.Controls.Add(this.txtdongianhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.lblsoluong);
            this.Controls.Add(this.txttenhang);
            this.Controls.Add(this.lbltenhang);
            this.Controls.Add(this.lblmahang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmhanghoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục hàng hóa";
            this.Load += new System.EventHandler(this.Frmhanghoa_Load);
            this.Click += new System.EventHandler(this.Frmhanghoa_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgridhanghoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.TextBox txtanh;
        private System.Windows.Forms.Label lblmahang;
        private System.Windows.Forms.DataGridView dgridhanghoa;
        private System.Windows.Forms.ComboBox cbomahang;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label lbltenhang;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.TextBox txtdongiaban;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdongianhap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}