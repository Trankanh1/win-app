namespace QuanLyBanHang.Forms
{
    partial class Form1
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
            this.dgvCsv = new System.Windows.Forms.DataGridView();
            this.txtfilepath = new System.Windows.Forms.TextBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnread = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnthunghiem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCsv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCsv
            // 
            this.dgvCsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCsv.Location = new System.Drawing.Point(12, 229);
            this.dgvCsv.Name = "dgvCsv";
            this.dgvCsv.RowTemplate.Height = 24;
            this.dgvCsv.Size = new System.Drawing.Size(1045, 459);
            this.dgvCsv.TabIndex = 0;
            // 
            // txtfilepath
            // 
            this.txtfilepath.Location = new System.Drawing.Point(12, 30);
            this.txtfilepath.Name = "txtfilepath";
            this.txtfilepath.Size = new System.Drawing.Size(896, 22);
            this.txtfilepath.TabIndex = 1;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(942, 23);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(115, 40);
            this.btnopen.TabIndex = 2;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(959, 157);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(115, 40);
            this.btnread.TabIndex = 3;
            this.btnread.Text = "Read";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(474, 174);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(115, 40);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(12, 107);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(189, 22);
            this.txtusername.TabIndex = 5;
            // 
            // txtconfirm
            // 
            this.txtconfirm.Location = new System.Drawing.Point(687, 107);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.Size = new System.Drawing.Size(189, 22);
            this.txtconfirm.TabIndex = 7;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(231, 107);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(189, 22);
            this.txtemail.TabIndex = 8;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(474, 107);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(189, 22);
            this.txtpassword.TabIndex = 9;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 69);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(73, 17);
            this.label.TabIndex = 10;
            this.label.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(684, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Confirm password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            // 
            // btnthunghiem
            // 
            this.btnthunghiem.Location = new System.Drawing.Point(655, 174);
            this.btnthunghiem.Name = "btnthunghiem";
            this.btnthunghiem.Size = new System.Drawing.Size(115, 40);
            this.btnthunghiem.TabIndex = 15;
            this.btnthunghiem.Text = "Thu nghiem";
            this.btnthunghiem.UseVisualStyleBackColor = true;
            this.btnthunghiem.Click += new System.EventHandler(this.btnthunghiem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 738);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnthunghiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtconfirm);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.txtfilepath);
            this.Controls.Add(this.dgvCsv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCsv;
        private System.Windows.Forms.TextBox txtfilepath;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnthunghiem;
        private System.Windows.Forms.Button button1;
    }
}