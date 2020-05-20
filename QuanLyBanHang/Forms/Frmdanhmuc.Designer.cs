namespace QuanLyBanHang.Forms
{
    partial class Frmdanhmuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmdanhmuc));
            this.btnhang = new System.Windows.Forms.Button();
            this.btnnhan = new System.Windows.Forms.Button();
            this.btnkhach = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnnhacungcap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnmathang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnhang
            // 
            this.btnhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnhang.Image = ((System.Drawing.Image)(resources.GetObject("btnhang.Image")));
            this.btnhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhang.Location = new System.Drawing.Point(-1, 267);
            this.btnhang.Name = "btnhang";
            this.btnhang.Size = new System.Drawing.Size(578, 73);
            this.btnhang.TabIndex = 1;
            this.btnhang.Text = "Kho hàng";
            this.btnhang.UseVisualStyleBackColor = false;
            this.btnhang.Click += new System.EventHandler(this.btnhang_Click);
            // 
            // btnnhan
            // 
            this.btnnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnnhan.Image = ((System.Drawing.Image)(resources.GetObject("btnnhan.Image")));
            this.btnnhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhan.Location = new System.Drawing.Point(-1, 137);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(578, 67);
            this.btnnhan.TabIndex = 3;
            this.btnnhan.Text = "Nhân viên";
            this.btnnhan.UseVisualStyleBackColor = false;
            this.btnnhan.Click += new System.EventHandler(this.btnnhan_Click);
            // 
            // btnkhach
            // 
            this.btnkhach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnkhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkhach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnkhach.Image = ((System.Drawing.Image)(resources.GetObject("btnkhach.Image")));
            this.btnkhach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkhach.Location = new System.Drawing.Point(-1, 201);
            this.btnkhach.Name = "btnkhach";
            this.btnkhach.Size = new System.Drawing.Size(578, 69);
            this.btnkhach.TabIndex = 4;
            this.btnkhach.Text = "Khách hàng";
            this.btnkhach.UseVisualStyleBackColor = false;
            this.btnkhach.Click += new System.EventHandler(this.btnkhach_Click);
            this.btnkhach.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.btnkhach_ChangeUICues);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(578, 64);
            this.button1.TabIndex = 11;
            this.button1.Text = "Nhà vận chuyển";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnnhacungcap
            // 
            this.btnnhacungcap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnnhacungcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhacungcap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnnhacungcap.Image = ((System.Drawing.Image)(resources.GetObject("btnnhacungcap.Image")));
            this.btnnhacungcap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhacungcap.Location = new System.Drawing.Point(-1, 333);
            this.btnnhacungcap.Name = "btnnhacungcap";
            this.btnnhacungcap.Size = new System.Drawing.Size(578, 68);
            this.btnnhacungcap.TabIndex = 12;
            this.btnnhacungcap.Text = "Nhà cung cấp";
            this.btnnhacungcap.UseVisualStyleBackColor = false;
            this.btnnhacungcap.Click += new System.EventHandler(this.btnnhacungcap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "Danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(528, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "      ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnmathang
            // 
            this.btnmathang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnmathang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmathang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmathang.Image = ((System.Drawing.Image)(resources.GetObject("btnmathang.Image")));
            this.btnmathang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmathang.Location = new System.Drawing.Point(0, 71);
            this.btnmathang.Name = "btnmathang";
            this.btnmathang.Size = new System.Drawing.Size(577, 69);
            this.btnmathang.TabIndex = 15;
            this.btnmathang.Text = "Mặt hàng";
            this.btnmathang.UseVisualStyleBackColor = false;
            this.btnmathang.Click += new System.EventHandler(this.btnmathang_Click);
            // 
            // Frmdanhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(577, 460);
            this.Controls.Add(this.btnmathang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnnhacungcap);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnkhach);
            this.Controls.Add(this.btnnhan);
            this.Controls.Add(this.btnhang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmdanhmuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmdanhmuc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhang;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.Button btnkhach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnnhacungcap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnmathang;
    }
}