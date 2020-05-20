namespace QuanLyBanHang.Forms
{
    partial class Frmhdnhapxuatcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmhdnhapxuatcs));
            this.btnhdxuat = new System.Windows.Forms.Button();
            this.btnhdnhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnhdxuat
            // 
            this.btnhdxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnhdxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhdxuat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnhdxuat.Image = ((System.Drawing.Image)(resources.GetObject("btnhdxuat.Image")));
            this.btnhdxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhdxuat.Location = new System.Drawing.Point(12, 138);
            this.btnhdxuat.Name = "btnhdxuat";
            this.btnhdxuat.Size = new System.Drawing.Size(585, 63);
            this.btnhdxuat.TabIndex = 5;
            this.btnhdxuat.Text = "Hóa đơn bán";
            this.btnhdxuat.UseVisualStyleBackColor = false;
            this.btnhdxuat.Click += new System.EventHandler(this.btnhdxuat_Click);
            // 
            // btnhdnhap
            // 
            this.btnhdnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnhdnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhdnhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnhdnhap.Image = ((System.Drawing.Image)(resources.GetObject("btnhdnhap.Image")));
            this.btnhdnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnhdnhap.Location = new System.Drawing.Point(12, 71);
            this.btnhdnhap.Name = "btnhdnhap";
            this.btnhdnhap.Size = new System.Drawing.Size(585, 71);
            this.btnhdnhap.TabIndex = 6;
            this.btnhdnhap.Text = "Hóa đơn nhập";
            this.btnhdnhap.UseVisualStyleBackColor = false;
            this.btnhdnhap.Click += new System.EventHandler(this.btnhdnhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Hóa đơn nhập-bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(536, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "      ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Frmhdnhapxuatcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(609, 213);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhdnhap);
            this.Controls.Add(this.btnhdxuat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmhdnhapxuatcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmhdnhapxuatcs";
            this.Load += new System.EventHandler(this.Frmhdnhapxuatcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhdxuat;
        private System.Windows.Forms.Button btnhdnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}