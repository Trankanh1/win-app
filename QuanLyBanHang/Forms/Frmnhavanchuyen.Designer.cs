namespace QuanLyBanHang.Forms
{
    partial class Frmnhavanchuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmnhavanchuyen));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblthemmoi = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txttimkiem1 = new System.Windows.Forms.TextBox();
            this.lblnvc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblxoa = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblcapnhat = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 575);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblthemmoi);
            this.panel1.Location = new System.Drawing.Point(578, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 48);
            this.panel1.TabIndex = 1;
            // 
            // lblthemmoi
            // 
            this.lblthemmoi.AutoSize = true;
            this.lblthemmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthemmoi.Location = new System.Drawing.Point(3, 12);
            this.lblthemmoi.Name = "lblthemmoi";
            this.lblthemmoi.Size = new System.Drawing.Size(108, 20);
            this.lblthemmoi.TabIndex = 0;
            this.lblthemmoi.Text = "+   Thêm mới";
            this.lblthemmoi.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.txttimkiem1);
            this.panel2.Controls.Add(this.lblnvc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btntimkiem);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1065, 58);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txttimkiem1
            // 
            this.txttimkiem1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txttimkiem1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txttimkiem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem1.ForeColor = System.Drawing.Color.Silver;
            this.txttimkiem1.Location = new System.Drawing.Point(275, 15);
            this.txttimkiem1.Name = "txttimkiem1";
            this.txttimkiem1.Size = new System.Drawing.Size(736, 34);
            this.txttimkiem1.TabIndex = 115;
            this.txttimkiem1.Text = "Nhập để tìm kiếm ..";
            this.txttimkiem1.Enter += new System.EventHandler(this.txttimkiem1_Enter);
            this.txttimkiem1.Leave += new System.EventHandler(this.txttimkiem1_Leave);
            // 
            // lblnvc
            // 
            this.lblnvc.AutoSize = true;
            this.lblnvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnvc.Location = new System.Drawing.Point(191, 11);
            this.lblnvc.Name = "lblnvc";
            this.lblnvc.Size = new System.Drawing.Size(61, 29);
            this.lblnvc.TabIndex = 4;
            this.lblnvc.Text = "........";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhà vận chuyển";
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.Lime;
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(1011, 11);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(45, 40);
            this.btntimkiem.TabIndex = 3;
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblxoa);
            this.panel4.Location = new System.Drawing.Point(839, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(119, 48);
            this.panel4.TabIndex = 3;
            // 
            // lblxoa
            // 
            this.lblxoa.AutoSize = true;
            this.lblxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxoa.Location = new System.Drawing.Point(17, 11);
            this.lblxoa.Name = "lblxoa";
            this.lblxoa.Size = new System.Drawing.Size(71, 20);
            this.lblxoa.TabIndex = 0;
            this.lblxoa.Text = "x     Xóa";
            this.lblxoa.Click += new System.EventHandler(this.lblxoa_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblcapnhat);
            this.panel3.Location = new System.Drawing.Point(714, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 48);
            this.panel3.TabIndex = 2;
            // 
            // lblcapnhat
            // 
            this.lblcapnhat.AutoSize = true;
            this.lblcapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapnhat.Location = new System.Drawing.Point(8, 11);
            this.lblcapnhat.Name = "lblcapnhat";
            this.lblcapnhat.Size = new System.Drawing.Size(97, 20);
            this.lblcapnhat.TabIndex = 0;
            this.lblcapnhat.Text = "-   Cập nhật";
            this.lblcapnhat.Click += new System.EventHandler(this.lblcapnhat_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.Control;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthoat.Location = new System.Drawing.Point(963, 64);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(103, 50);
            this.btnthoat.TabIndex = 113;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-19, -19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 114;
            // 
            // Frmnhavanchuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 729);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frmnhavanchuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà vận chuyển";
            this.Load += new System.EventHandler(this.Frmnhavanchuyen_Load);
            this.Click += new System.EventHandler(this.Frmnhavanchuyen_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblthemmoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblnvc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblxoa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblcapnhat;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txttimkiem1;
    }
}