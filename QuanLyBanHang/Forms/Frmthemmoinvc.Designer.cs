namespace QuanLyBanHang.Forms
{
    partial class Frmthemmoinvc
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu1 = new System.Windows.Forms.Button();
            this.btnlamlai1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtketnoi = new System.Windows.Forms.TextBox();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmanvc = new System.Windows.Forms.TextBox();
            this.txttennvc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtphivc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon1";
            this.notifyIcon2.Visible = true;
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnthoat.Location = new System.Drawing.Point(785, 302);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(103, 61);
            this.btnthoat.TabIndex = 112;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu1
            // 
            this.btnluu1.BackColor = System.Drawing.Color.LimeGreen;
            this.btnluu1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnluu1.Location = new System.Drawing.Point(581, 302);
            this.btnluu1.Name = "btnluu1";
            this.btnluu1.Size = new System.Drawing.Size(96, 61);
            this.btnluu1.TabIndex = 111;
            this.btnluu1.Text = "Lưu";
            this.btnluu1.UseVisualStyleBackColor = false;
            this.btnluu1.Click += new System.EventHandler(this.btnluu1_Click);
            // 
            // btnlamlai1
            // 
            this.btnlamlai1.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnlamlai1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlamlai1.Location = new System.Drawing.Point(683, 302);
            this.btnlamlai1.Name = "btnlamlai1";
            this.btnlamlai1.Size = new System.Drawing.Size(96, 61);
            this.btnlamlai1.TabIndex = 110;
            this.btnlamlai1.Text = "Làm lại";
            this.btnlamlai1.UseVisualStyleBackColor = false;
            this.btnlamlai1.Click += new System.EventHandler(this.btnlamlai1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(90, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 36);
            this.label9.TabIndex = 112;
            this.label9.Text = "*";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Red;
            this.label30.Location = new System.Drawing.Point(90, 62);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(27, 36);
            this.label30.TabIndex = 111;
            this.label30.Text = "*";
            // 
            // txtghichu
            // 
            this.txtghichu.Location = new System.Drawing.Point(588, 106);
            this.txtghichu.Multiline = true;
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(288, 86);
            this.txtghichu.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(395, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ghi chú  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(395, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mô tả  :";
            // 
            // txtketnoi
            // 
            this.txtketnoi.Location = new System.Drawing.Point(588, 14);
            this.txtketnoi.Name = "txtketnoi";
            this.txtketnoi.Size = new System.Drawing.Size(288, 22);
            this.txtketnoi.TabIndex = 7;
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(588, 61);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(288, 22);
            this.txtmota.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mô tả  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kết nối giao hàng :";
            // 
            // txtmanvc
            // 
            this.txtmanvc.Location = new System.Drawing.Point(123, 15);
            this.txtmanvc.Name = "txtmanvc";
            this.txtmanvc.Size = new System.Drawing.Size(211, 22);
            this.txtmanvc.TabIndex = 3;
            // 
            // txttennvc
            // 
            this.txttennvc.Location = new System.Drawing.Point(123, 62);
            this.txttennvc.Name = "txttennvc";
            this.txttennvc.Size = new System.Drawing.Size(211, 22);
            this.txttennvc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã NVC :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtphivc);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.txtghichu);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtketnoi);
            this.panel1.Controls.Add(this.txtmota);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtmanvc);
            this.panel1.Controls.Add(this.txttennvc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 226);
            this.panel1.TabIndex = 108;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(340, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 116;
            this.label12.Text = "VNĐ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(90, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 36);
            this.label10.TabIndex = 115;
            this.label10.Text = "*";
            // 
            // txtphivc
            // 
            this.txtphivc.Location = new System.Drawing.Point(123, 114);
            this.txtphivc.Name = "txtphivc";
            this.txtphivc.Size = new System.Drawing.Size(211, 22);
            this.txtphivc.TabIndex = 114;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 113;
            this.label11.Text = "Phí VC :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên NVC :";
            // 
            // Frmthemmoinvc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(939, 416);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnluu1);
            this.Controls.Add(this.btnlamlai1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frmthemmoinvc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới nhà vận chuyển";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frmthemmoinvc_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu1;
        private System.Windows.Forms.Button btnlamlai1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtketnoi;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmanvc;
        private System.Windows.Forms.TextBox txttennvc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtphivc;
        private System.Windows.Forms.Label label11;
    }
}