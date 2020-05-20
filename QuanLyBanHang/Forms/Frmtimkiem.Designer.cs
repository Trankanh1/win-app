namespace QuanLyBanHang.Forms
{
    partial class Frmtimkiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmtimkiem));
            this.btntkdonhang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btntkhdban = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntkdonhang
            // 
            this.btntkdonhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btntkdonhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntkdonhang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntkdonhang.Image = ((System.Drawing.Image)(resources.GetObject("btntkdonhang.Image")));
            this.btntkdonhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntkdonhang.Location = new System.Drawing.Point(12, 140);
            this.btntkdonhang.Name = "btntkdonhang";
            this.btntkdonhang.Size = new System.Drawing.Size(577, 70);
            this.btntkdonhang.TabIndex = 9;
            this.btntkdonhang.Text = "Đơn đặt hàng";
            this.btntkdonhang.UseVisualStyleBackColor = false;
            this.btntkdonhang.Click += new System.EventHandler(this.btntkdonhang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(232, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(529, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "      ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btntkhdban
            // 
            this.btntkhdban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btntkhdban.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntkhdban.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntkhdban.Image = ((System.Drawing.Image)(resources.GetObject("btntkhdban.Image")));
            this.btntkhdban.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntkhdban.Location = new System.Drawing.Point(12, 79);
            this.btntkhdban.Name = "btntkhdban";
            this.btntkhdban.Size = new System.Drawing.Size(577, 65);
            this.btntkhdban.TabIndex = 7;
            this.btntkhdban.Text = "Hóa đơn bán";
            this.btntkhdban.UseVisualStyleBackColor = false;
            this.btntkhdban.Click += new System.EventHandler(this.btntkhdban_Click);
            // 
            // Frmtimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(595, 329);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntkdonhang);
            this.Controls.Add(this.btntkhdban);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmtimkiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmtimkiem";
            this.Load += new System.EventHandler(this.Frmtimkiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntkdonhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btntkhdban;
    }
}