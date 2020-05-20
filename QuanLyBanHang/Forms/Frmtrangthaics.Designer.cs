namespace QuanLyBanHang.Forms
{
    partial class Frmtrangthaics
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
            this.rddonmoi = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdxuly = new System.Windows.Forms.RadioButton();
            this.rddanggiao = new System.Windows.Forms.RadioButton();
            this.rdthanhcong = new System.Windows.Forms.RadioButton();
            this.rdhuybo = new System.Windows.Forms.RadioButton();
            this.lblok = new System.Windows.Forms.Label();
            this.lblthoat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rddonmoi
            // 
            this.rddonmoi.AutoSize = true;
            this.rddonmoi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rddonmoi.Location = new System.Drawing.Point(15, 38);
            this.rddonmoi.Name = "rddonmoi";
            this.rddonmoi.Size = new System.Drawing.Size(133, 24);
            this.rddonmoi.TabIndex = 0;
            this.rddonmoi.TabStop = true;
            this.rddonmoi.Text = "Đơn hàng mới";
            this.rddonmoi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblthoat);
            this.groupBox1.Controls.Add(this.lblok);
            this.groupBox1.Controls.Add(this.rdhuybo);
            this.groupBox1.Controls.Add(this.rdthanhcong);
            this.groupBox1.Controls.Add(this.rddanggiao);
            this.groupBox1.Controls.Add(this.rdxuly);
            this.groupBox1.Controls.Add(this.rddonmoi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 283);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật trạng thái đơn hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdxuly
            // 
            this.rdxuly.AutoSize = true;
            this.rdxuly.ForeColor = System.Drawing.Color.SteelBlue;
            this.rdxuly.Location = new System.Drawing.Point(15, 80);
            this.rdxuly.Name = "rdxuly";
            this.rdxuly.Size = new System.Drawing.Size(108, 24);
            this.rdxuly.TabIndex = 1;
            this.rdxuly.TabStop = true;
            this.rdxuly.Text = "Đang xử lý";
            this.rdxuly.UseVisualStyleBackColor = true;
            // 
            // rddanggiao
            // 
            this.rddanggiao.AutoSize = true;
            this.rddanggiao.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.rddanggiao.Location = new System.Drawing.Point(15, 119);
            this.rddanggiao.Name = "rddanggiao";
            this.rddanggiao.Size = new System.Drawing.Size(146, 24);
            this.rddanggiao.TabIndex = 2;
            this.rddanggiao.TabStop = true;
            this.rddanggiao.Text = "Đang giao hàng";
            this.rddanggiao.UseVisualStyleBackColor = true;
            // 
            // rdthanhcong
            // 
            this.rdthanhcong.AutoSize = true;
            this.rdthanhcong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdthanhcong.Location = new System.Drawing.Point(15, 163);
            this.rdthanhcong.Name = "rdthanhcong";
            this.rdthanhcong.Size = new System.Drawing.Size(193, 24);
            this.rdthanhcong.TabIndex = 3;
            this.rdthanhcong.TabStop = true;
            this.rdthanhcong.Text = "Giao hàng thành công";
            this.rdthanhcong.UseVisualStyleBackColor = true;
            // 
            // rdhuybo
            // 
            this.rdhuybo.AutoSize = true;
            this.rdhuybo.ForeColor = System.Drawing.Color.Red;
            this.rdhuybo.Location = new System.Drawing.Point(15, 207);
            this.rdhuybo.Name = "rdhuybo";
            this.rdhuybo.Size = new System.Drawing.Size(83, 24);
            this.rdhuybo.TabIndex = 4;
            this.rdhuybo.TabStop = true;
            this.rdhuybo.Text = "Hủy bỏ";
            this.rdhuybo.UseVisualStyleBackColor = true;
            // 
            // lblok
            // 
            this.lblok.AutoSize = true;
            this.lblok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblok.Location = new System.Drawing.Point(156, 250);
            this.lblok.Name = "lblok";
            this.lblok.Size = new System.Drawing.Size(33, 20);
            this.lblok.TabIndex = 5;
            this.lblok.Text = "OK";
            this.lblok.Click += new System.EventHandler(this.lblok_Click);
            // 
            // lblthoat
            // 
            this.lblthoat.AutoSize = true;
            this.lblthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthoat.ForeColor = System.Drawing.Color.Red;
            this.lblthoat.Location = new System.Drawing.Point(307, 0);
            this.lblthoat.Name = "lblthoat";
            this.lblthoat.Size = new System.Drawing.Size(21, 20);
            this.lblthoat.TabIndex = 6;
            this.lblthoat.Text = "X";
            this.lblthoat.Click += new System.EventHandler(this.lblthoat_Click);
            // 
            // Frmtrangthaics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 290);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmtrangthaics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmtrangthaics";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rddonmoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblthoat;
        private System.Windows.Forms.Label lblok;
        private System.Windows.Forms.RadioButton rdhuybo;
        private System.Windows.Forms.RadioButton rdthanhcong;
        private System.Windows.Forms.RadioButton rddanggiao;
        private System.Windows.Forms.RadioButton rdxuly;
    }
}