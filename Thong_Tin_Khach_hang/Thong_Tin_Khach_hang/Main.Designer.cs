namespace Thong_Tin_Khach_hang
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnthongKeGiaoDich = new FontAwesome.Sharp.IconButton();
            this.btnthongTinKhachHang = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnthongKeGiaoDich);
            this.panel1.Controls.Add(this.btnthongTinKhachHang);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 904);
            this.panel1.TabIndex = 0;
            // 
            // btnthongKeGiaoDich
            // 
            this.btnthongKeGiaoDich.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnthongKeGiaoDich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthongKeGiaoDich.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnthongKeGiaoDich.IconColor = System.Drawing.Color.Black;
            this.btnthongKeGiaoDich.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnthongKeGiaoDich.Location = new System.Drawing.Point(0, 49);
            this.btnthongKeGiaoDich.Name = "btnthongKeGiaoDich";
            this.btnthongKeGiaoDich.Size = new System.Drawing.Size(221, 49);
            this.btnthongKeGiaoDich.TabIndex = 0;
            this.btnthongKeGiaoDich.Text = "Thống kê lượng giao dịch theo từng nhân viên";
            this.btnthongKeGiaoDich.UseVisualStyleBackColor = true;
            this.btnthongKeGiaoDich.Click += new System.EventHandler(this.btnthongKeGiaoDich_Click);
            // 
            // btnthongTinKhachHang
            // 
            this.btnthongTinKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnthongTinKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthongTinKhachHang.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnthongTinKhachHang.IconColor = System.Drawing.Color.Black;
            this.btnthongTinKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnthongTinKhachHang.Location = new System.Drawing.Point(0, 0);
            this.btnthongTinKhachHang.Name = "btnthongTinKhachHang";
            this.btnthongTinKhachHang.Size = new System.Drawing.Size(221, 49);
            this.btnthongTinKhachHang.TabIndex = 0;
            this.btnthongTinKhachHang.Text = "Thông tin khách hàng";
            this.btnthongTinKhachHang.UseVisualStyleBackColor = true;
            this.btnthongTinKhachHang.Click += new System.EventHandler(this.btnthongTinKhachHang_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(221, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1591, 904);
            this.panel2.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1812, 904);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnthongTinKhachHang;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnthongKeGiaoDich;
    }
}