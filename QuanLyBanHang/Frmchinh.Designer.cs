namespace QuanLyBanHang
{
    partial class Frmchinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmchinh));
            this.pnlmain = new System.Windows.Forms.Panel();
            this.btnadmin = new System.Windows.Forms.Button();
            this.btnmini = new System.Windows.Forms.Button();
            this.btndanhmuc = new System.Windows.Forms.Button();
            this.btndathang = new System.Windows.Forms.Button();
            this.btnnhapxuat = new System.Windows.Forms.Button();
            this.btnthongke = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btntrogiup = new System.Windows.Forms.Button();
            this.lbltendangnhap = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblmain = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlmain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmain
            // 
            this.pnlmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlmain.Controls.Add(this.btnadmin);
            this.pnlmain.Controls.Add(this.btnmini);
            this.pnlmain.Controls.Add(this.btndanhmuc);
            this.pnlmain.Controls.Add(this.btndathang);
            this.pnlmain.Controls.Add(this.btnnhapxuat);
            this.pnlmain.Controls.Add(this.btnthongke);
            this.pnlmain.Controls.Add(this.btntimkiem);
            this.pnlmain.Controls.Add(this.btntrogiup);
            this.pnlmain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlmain.Location = new System.Drawing.Point(0, 0);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(339, 857);
            this.pnlmain.TabIndex = 1;
            this.pnlmain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlmain_Paint);
            // 
            // btnadmin
            // 
            this.btnadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmin.Image = ((System.Drawing.Image)(resources.GetObject("btnadmin.Image")));
            this.btnadmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadmin.Location = new System.Drawing.Point(1, 73);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(338, 74);
            this.btnadmin.TabIndex = 1;
            this.btnadmin.Text = "Admin";
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btnmini
            // 
            this.btnmini.BackColor = System.Drawing.Color.DimGray;
            this.btnmini.Image = ((System.Drawing.Image)(resources.GetObject("btnmini.Image")));
            this.btnmini.Location = new System.Drawing.Point(3, 2);
            this.btnmini.Name = "btnmini";
            this.btnmini.Size = new System.Drawing.Size(57, 47);
            this.btnmini.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnmini, "Thu nhỏ,phóng to");
            this.btnmini.UseVisualStyleBackColor = false;
            this.btnmini.ClientSizeChanged += new System.EventHandler(this.btnmini_ClientSizeChanged);
            this.btnmini.Click += new System.EventHandler(this.btnmini_Click);
            // 
            // btndanhmuc
            // 
            this.btndanhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndanhmuc.Image = ((System.Drawing.Image)(resources.GetObject("btndanhmuc.Image")));
            this.btndanhmuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndanhmuc.Location = new System.Drawing.Point(1, 143);
            this.btndanhmuc.Name = "btndanhmuc";
            this.btndanhmuc.Size = new System.Drawing.Size(338, 74);
            this.btndanhmuc.TabIndex = 2;
            this.btndanhmuc.Text = " Danh mục";
            this.btndanhmuc.UseVisualStyleBackColor = true;
            this.btndanhmuc.Click += new System.EventHandler(this.btndanhmuc_Click);
            this.btndanhmuc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btndanhmuc_MouseDown);
            this.btndanhmuc.MouseLeave += new System.EventHandler(this.btndanhmuc_MouseLeave);
            this.btndanhmuc.MouseHover += new System.EventHandler(this.btndanhmuc_MouseHover);
            this.btndanhmuc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btndanhmuc_MouseMove);
            this.btndanhmuc.Move += new System.EventHandler(this.btndanhmuc_Move);
            // 
            // btndathang
            // 
            this.btndathang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndathang.Image = ((System.Drawing.Image)(resources.GetObject("btndathang.Image")));
            this.btndathang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndathang.Location = new System.Drawing.Point(1, 214);
            this.btndathang.Name = "btndathang";
            this.btndathang.Size = new System.Drawing.Size(338, 74);
            this.btndathang.TabIndex = 7;
            this.btndathang.Text = "Đặt hàng";
            this.btndathang.UseVisualStyleBackColor = true;
            this.btndathang.Click += new System.EventHandler(this.btndathang_Click_1);
            // 
            // btnnhapxuat
            // 
            this.btnnhapxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhapxuat.Image = ((System.Drawing.Image)(resources.GetObject("btnnhapxuat.Image")));
            this.btnnhapxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhapxuat.Location = new System.Drawing.Point(1, 286);
            this.btnnhapxuat.Name = "btnnhapxuat";
            this.btnnhapxuat.Size = new System.Drawing.Size(338, 74);
            this.btnnhapxuat.TabIndex = 2;
            this.btnnhapxuat.Text = "     Hoạt động nhập, bán";
            this.btnnhapxuat.UseVisualStyleBackColor = true;
            this.btnnhapxuat.Click += new System.EventHandler(this.btnnhapxuat_Click);
            this.btnnhapxuat.MouseHover += new System.EventHandler(this.btnnhapxuat_MouseHover);
            this.btnnhapxuat.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.btnnhapxuat_ChangeUICues);
            // 
            // btnthongke
            // 
            this.btnthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongke.Image = ((System.Drawing.Image)(resources.GetObject("btnthongke.Image")));
            this.btnthongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthongke.Location = new System.Drawing.Point(1, 353);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(338, 74);
            this.btnthongke.TabIndex = 2;
            this.btnthongke.Text = "Thống kê và báo cáo";
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntimkiem.Location = new System.Drawing.Point(1, 422);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(338, 74);
            this.btntimkiem.TabIndex = 2;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btntrogiup
            // 
            this.btntrogiup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrogiup.Image = ((System.Drawing.Image)(resources.GetObject("btntrogiup.Image")));
            this.btntrogiup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntrogiup.Location = new System.Drawing.Point(0, 492);
            this.btntrogiup.Name = "btntrogiup";
            this.btntrogiup.Size = new System.Drawing.Size(339, 74);
            this.btntrogiup.TabIndex = 2;
            this.btntrogiup.Text = "Trợ giúp";
            this.btntrogiup.UseVisualStyleBackColor = true;
            this.btntrogiup.Click += new System.EventHandler(this.btntrogiup_Click);
            // 
            // lbltendangnhap
            // 
            this.lbltendangnhap.AutoSize = true;
            this.lbltendangnhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltendangnhap.ForeColor = System.Drawing.Color.White;
            this.lbltendangnhap.Location = new System.Drawing.Point(943, 30);
            this.lbltendangnhap.Name = "lbltendangnhap";
            this.lbltendangnhap.Size = new System.Drawing.Size(128, 26);
            this.lbltendangnhap.TabIndex = 4;
            this.lbltendangnhap.Text = "Trần Kim Anh";
            // 
            // lblmain
            // 
            this.lblmain.AutoSize = true;
            this.lblmain.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblmain.Location = new System.Drawing.Point(6, 15);
            this.lblmain.Name = "lblmain";
            this.lblmain.Size = new System.Drawing.Size(860, 43);
            this.lblmain.TabIndex = 3;
            this.lblmain.Text = "Phần mềm quản lý hàng hóa công ty TNHH Thành Phú";
            this.lblmain.Click += new System.EventHandler(this.lblmain_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbltendangnhap);
            this.panel1.Controls.Add(this.lblmain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Cornsilk;
            this.panel1.Location = new System.Drawing.Point(339, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1530, 73);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(982, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Xin chào !";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(1127, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = " Đăng xuất";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Frmchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1869, 857);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Frmchinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frmphucs_Load);
            this.pnlmain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.Button btntrogiup;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btnnhapxuat;
        private System.Windows.Forms.Button btndanhmuc;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btnmini;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblmain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btndathang;
        private System.Windows.Forms.Label lbltendangnhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}