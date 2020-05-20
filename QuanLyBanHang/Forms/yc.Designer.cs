namespace QuanLyBanHang.Forms
{
    partial class yc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yc));
            this.txttimkiem1 = new System.Windows.Forms.TextBox();
            this.lbltimkiem = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txttimkiem1
            // 
            this.txttimkiem1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txttimkiem1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txttimkiem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem1.ForeColor = System.Drawing.Color.Silver;
            this.txttimkiem1.Location = new System.Drawing.Point(194, 23);
            this.txttimkiem1.Name = "txttimkiem1";
            this.txttimkiem1.Size = new System.Drawing.Size(454, 34);
            this.txttimkiem1.TabIndex = 117;
            this.txttimkiem1.Text = "Nhập để tìm kiếm ..";
            // 
            // lbltimkiem
            // 
            this.lbltimkiem.AutoSize = true;
            this.lbltimkiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbltimkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimkiem.Image = ((System.Drawing.Image)(resources.GetObject("lbltimkiem.Image")));
            this.lbltimkiem.Location = new System.Drawing.Point(706, 23);
            this.lbltimkiem.Name = "lbltimkiem";
            this.lbltimkiem.Size = new System.Drawing.Size(66, 34);
            this.lbltimkiem.TabIndex = 121;
            this.lbltimkiem.Text = "       ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(194, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(578, 335);
            this.dataGridView1.TabIndex = 122;
            // 
            // yc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(872, 612);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbltimkiem);
            this.Controls.Add(this.txttimkiem1);
            this.Cursor = System.Windows.Forms.Cursors.UpArrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "yc";
            this.Text = "8";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.yc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttimkiem1;
        private System.Windows.Forms.Label lbltimkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}