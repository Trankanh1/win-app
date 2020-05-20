namespace QuanLyBanHang.Forms
{
    partial class Frmkh
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
            this.lbltenkhach = new System.Windows.Forms.Label();
            this.lblmakhach = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbldienthoai = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltenkhach
            // 
            this.lbltenkhach.AutoSize = true;
            this.lbltenkhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenkhach.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltenkhach.Location = new System.Drawing.Point(137, 60);
            this.lbltenkhach.Name = "lbltenkhach";
            this.lbltenkhach.Size = new System.Drawing.Size(13, 20);
            this.lbltenkhach.TabIndex = 11;
            this.lbltenkhach.Text = ".";
            // 
            // lblmakhach
            // 
            this.lblmakhach.AutoSize = true;
            this.lblmakhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmakhach.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblmakhach.Location = new System.Drawing.Point(137, 19);
            this.lblmakhach.Name = "lblmakhach";
            this.lblmakhach.Size = new System.Drawing.Size(13, 20);
            this.lblmakhach.TabIndex = 9;
            this.lblmakhach.Text = ".";
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.SystemColors.Control;
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnok.Location = new System.Drawing.Point(153, 233);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(42, 30);
            this.btnok.TabIndex = 14;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.ClientSizeChanged += new System.EventHandler(this.btnok_ClientSizeChanged);
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách :";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbldienthoai);
            this.panel7.Controls.Add(this.lbldiachi);
            this.panel7.Controls.Add(this.lblemail);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.lbltenkhach);
            this.panel7.Controls.Add(this.lblmakhach);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(12, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(352, 215);
            this.panel7.TabIndex = 10;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // lbldienthoai
            // 
            this.lbldienthoai.AutoSize = true;
            this.lbldienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldienthoai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldienthoai.Location = new System.Drawing.Point(137, 179);
            this.lbldienthoai.Name = "lbldienthoai";
            this.lbldienthoai.Size = new System.Drawing.Size(13, 20);
            this.lbldienthoai.TabIndex = 17;
            this.lbldienthoai.Text = ".";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiachi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbldiachi.Location = new System.Drawing.Point(137, 140);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(13, 20);
            this.lbldiachi.TabIndex = 16;
            this.lbldiachi.Text = ".";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblemail.Location = new System.Drawing.Point(137, 99);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(13, 20);
            this.lblemail.TabIndex = 15;
            this.lblemail.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(17, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Điện thoại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(17, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Địa chỉ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(17, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email :";
            // 
            // Frmkh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(371, 265);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frmkh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin khách hàng";
            this.Load += new System.EventHandler(this.Frmkh_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbltenkhach;
        private System.Windows.Forms.Label lblmakhach;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbldienthoai;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lblemail;
    }
}