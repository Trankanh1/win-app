namespace QuanLyBanHang.Forms
{
    partial class Frmnhanvien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmnhanvien));
            this.btndong = new System.Windows.Forms.Button();
            this.dgridnhanvien = new System.Windows.Forms.DataGridView();
            this.chknu = new System.Windows.Forms.CheckBox();
            this.chknam = new System.Windows.Forms.CheckBox();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.lblngaysinh = new System.Windows.Forms.Label();
            this.lbldienthoai = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.lbltennhanvien = new System.Windows.Forms.Label();
            this.lblmnv = new System.Windows.Forms.Label();
            this.txtcongviec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbomahanvien = new System.Windows.Forms.ComboBox();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.btntimlai = new System.Windows.Forms.Button();
            this.txtngaysinh = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtanh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgridnhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btndong
            // 
            this.btndong.BackColor = System.Drawing.Color.Teal;
            this.btndong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndong.Image = ((System.Drawing.Image)(resources.GetObject("btndong.Image")));
            this.btndong.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndong.Location = new System.Drawing.Point(860, 628);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(162, 62);
            this.btndong.TabIndex = 41;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = false;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // dgridnhanvien
            // 
            this.dgridnhanvien.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgridnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridnhanvien.Location = new System.Drawing.Point(22, 443);
            this.dgridnhanvien.Name = "dgridnhanvien";
            this.dgridnhanvien.RowTemplate.Height = 24;
            this.dgridnhanvien.Size = new System.Drawing.Size(1000, 179);
            this.dgridnhanvien.TabIndex = 35;
            this.dgridnhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridnhanvien_CellContentClick);
            this.dgridnhanvien.Click += new System.EventHandler(this.dgridnhanvien_Click);
            // 
            // chknu
            // 
            this.chknu.AutoSize = true;
            this.chknu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chknu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chknu.Location = new System.Drawing.Point(263, 135);
            this.chknu.Name = "chknu";
            this.chknu.Size = new System.Drawing.Size(52, 24);
            this.chknu.TabIndex = 34;
            this.chknu.Text = "Nữ";
            this.chknu.UseVisualStyleBackColor = true;
            this.chknu.Click += new System.EventHandler(this.chknu_Click);
            this.chknu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chknu_KeyUp);
            // 
            // chknam
            // 
            this.chknam.AutoSize = true;
            this.chknam.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chknam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chknam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chknam.Location = new System.Drawing.Point(158, 135);
            this.chknam.Name = "chknam";
            this.chknam.Size = new System.Drawing.Size(66, 24);
            this.chknam.TabIndex = 33;
            this.chknam.Text = "Nam";
            this.chknam.UseVisualStyleBackColor = false;
            this.chknam.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chknam_KeyUp);
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdienthoai.Location = new System.Drawing.Point(158, 247);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(267, 27);
            this.txtdienthoai.TabIndex = 31;
            this.txtdienthoai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdienthoai_KeyUp);
            // 
            // lblngaysinh
            // 
            this.lblngaysinh.AutoSize = true;
            this.lblngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngaysinh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblngaysinh.Location = new System.Drawing.Point(16, 187);
            this.lblngaysinh.Name = "lblngaysinh";
            this.lblngaysinh.Size = new System.Drawing.Size(93, 20);
            this.lblngaysinh.TabIndex = 30;
            this.lblngaysinh.Text = "Ngày sinh :";
            // 
            // lbldienthoai
            // 
            this.lbldienthoai.AutoSize = true;
            this.lbldienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldienthoai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldienthoai.Location = new System.Drawing.Point(15, 247);
            this.lbldienthoai.Name = "lbldienthoai";
            this.lbldienthoai.Size = new System.Drawing.Size(94, 20);
            this.lbldienthoai.TabIndex = 29;
            this.lbldienthoai.Text = "Điện thoại :";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(158, 309);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(267, 27);
            this.txtdiachi.TabIndex = 28;
            this.txtdiachi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdiachi_KeyUp);
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiachi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldiachi.Location = new System.Drawing.Point(16, 312);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(71, 20);
            this.lbldiachi.TabIndex = 27;
            this.lbldiachi.Text = "Địa chỉ :";
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttennhanvien.Location = new System.Drawing.Point(158, 80);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(267, 27);
            this.txttennhanvien.TabIndex = 26;
            this.txttennhanvien.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttennhanvien_KeyUp);
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgioitinh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblgioitinh.Location = new System.Drawing.Point(19, 135);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(81, 20);
            this.lblgioitinh.TabIndex = 24;
            this.lblgioitinh.Text = "Giới tính :";
            // 
            // lbltennhanvien
            // 
            this.lbltennhanvien.AutoSize = true;
            this.lbltennhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltennhanvien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltennhanvien.Location = new System.Drawing.Point(19, 83);
            this.lbltennhanvien.Name = "lbltennhanvien";
            this.lbltennhanvien.Size = new System.Drawing.Size(123, 20);
            this.lbltennhanvien.TabIndex = 23;
            this.lbltennhanvien.Text = "Tên nhân viên :";
            // 
            // lblmnv
            // 
            this.lblmnv.AutoSize = true;
            this.lblmnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmnv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblmnv.Location = new System.Drawing.Point(19, 26);
            this.lblmnv.Name = "lblmnv";
            this.lblmnv.Size = new System.Drawing.Size(118, 20);
            this.lblmnv.TabIndex = 22;
            this.lblmnv.Text = "Mã nhân viên :";
            // 
            // txtcongviec
            // 
            this.txtcongviec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcongviec.Location = new System.Drawing.Point(158, 369);
            this.txtcongviec.Name = "txtcongviec";
            this.txtcongviec.Size = new System.Drawing.Size(267, 27);
            this.txtcongviec.TabIndex = 43;
            this.txtcongviec.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcongviec_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(15, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Công việc :";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "t9batty.png");
            this.imageList1.Images.SetKeyName(1, "t9dog1_trans.png");
            this.imageList1.Images.SetKeyName(2, "t9elephant.png");
            this.imageList1.Images.SetKeyName(3, "t9ducky.png");
            this.imageList1.Images.SetKeyName(4, "t9foxy.png");
            this.imageList1.Images.SetKeyName(5, "t9tuqui.png");
            this.imageList1.Images.SetKeyName(6, "t9lion.png");
            this.imageList1.Images.SetKeyName(7, "t9ratty.png");
            this.imageList1.Images.SetKeyName(8, "t9panda_trans.png");
            this.imageList1.Images.SetKeyName(9, "Knob Add.png");
            this.imageList1.Images.SetKeyName(10, "Knob Cancel.png");
            this.imageList1.Images.SetKeyName(11, "Knob Help.png");
            this.imageList1.Images.SetKeyName(12, "Knob Remove Red.png");
            this.imageList1.Images.SetKeyName(13, "Knob Valid Green.png");
            this.imageList1.Images.SetKeyName(14, "Knob Search.png");
            this.imageList1.Images.SetKeyName(15, "Knob Stop.png");
            this.imageList1.Images.SetKeyName(16, "Add_32x32.png");
            this.imageList1.Images.SetKeyName(17, "Favorites.ico");
            this.imageList1.Images.SetKeyName(18, "Find_48x48.png");
            this.imageList1.Images.SetKeyName(19, "Find.ico");
            this.imageList1.Images.SetKeyName(20, "Open_48x48.png");
            this.imageList1.Images.SetKeyName(21, "Save_48x48.png");
            this.imageList1.Images.SetKeyName(22, "User_48x48.png");
            this.imageList1.Images.SetKeyName(23, "Cancel_48x48.png");
            this.imageList1.Images.SetKeyName(24, "Edit_48x48.png");
            this.imageList1.Images.SetKeyName(25, "Key_48x48.png");
            this.imageList1.Images.SetKeyName(26, "Picture_48x48.png");
            this.imageList1.Images.SetKeyName(27, "Search_48x48.png");
            // 
            // cbomahanvien
            // 
            this.cbomahanvien.FormattingEnabled = true;
            this.cbomahanvien.Location = new System.Drawing.Point(158, 22);
            this.cbomahanvien.Name = "cbomahanvien";
            this.cbomahanvien.Size = new System.Drawing.Size(267, 24);
            this.cbomahanvien.TabIndex = 44;
            this.cbomahanvien.TextChanged += new System.EventHandler(this.cbomahanvien_TextChanged);
            this.cbomahanvien.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbomahanvien_KeyUp);
            // 
            // btnhienthi
            // 
            this.btnhienthi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnhienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhienthi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnhienthi.Image = ((System.Drawing.Image)(resources.GetObject("btnhienthi.Image")));
            this.btnhienthi.Location = new System.Drawing.Point(450, 12);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(69, 54);
            this.btnhienthi.TabIndex = 45;
            this.btnhienthi.UseVisualStyleBackColor = false;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click_3);
            // 
            // btntimlai
            // 
            this.btntimlai.BackColor = System.Drawing.Color.Teal;
            this.btntimlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimlai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntimlai.Image = ((System.Drawing.Image)(resources.GetObject("btntimlai.Image")));
            this.btntimlai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimlai.Location = new System.Drawing.Point(667, 628);
            this.btntimlai.Name = "btntimlai";
            this.btntimlai.Size = new System.Drawing.Size(150, 62);
            this.btntimlai.TabIndex = 46;
            this.btntimlai.Text = "       Tìm lại";
            this.btntimlai.UseVisualStyleBackColor = false;
            this.btntimlai.Click += new System.EventHandler(this.btntimlai_Click);
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtngaysinh.Location = new System.Drawing.Point(158, 187);
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(267, 27);
            this.txtngaysinh.TabIndex = 32;
            this.txtngaysinh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtngaysinh_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(536, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // txtanh
            // 
            this.txtanh.Location = new System.Drawing.Point(536, 415);
            this.txtanh.Name = "txtanh";
            this.txtanh.Size = new System.Drawing.Size(486, 22);
            this.txtanh.TabIndex = 49;
            // 
            // Frmnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1050, 701);
            this.Controls.Add(this.txtanh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btntimlai);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.cbomahanvien);
            this.Controls.Add(this.txtcongviec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.dgridnhanvien);
            this.Controls.Add(this.chknu);
            this.Controls.Add(this.chknam);
            this.Controls.Add(this.txtngaysinh);
            this.Controls.Add(this.txtdienthoai);
            this.Controls.Add(this.lblngaysinh);
            this.Controls.Add(this.lbldienthoai);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.lbldiachi);
            this.Controls.Add(this.txttennhanvien);
            this.Controls.Add(this.lblgioitinh);
            this.Controls.Add(this.lbltennhanvien);
            this.Controls.Add(this.lblmnv);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frmnhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục nhân viên";
            this.Load += new System.EventHandler(this.Frmnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgridnhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.DataGridView dgridnhanvien;
        private System.Windows.Forms.CheckBox chknu;
        private System.Windows.Forms.CheckBox chknam;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.Label lblngaysinh;
        private System.Windows.Forms.Label lbldienthoai;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.TextBox txttennhanvien;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.Label lbltennhanvien;
        private System.Windows.Forms.Label lblmnv;
        private System.Windows.Forms.TextBox txtcongviec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cbomahanvien;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.Button btntimlai;
        private System.Windows.Forms.TextBox txtngaysinh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtanh;
    }
}