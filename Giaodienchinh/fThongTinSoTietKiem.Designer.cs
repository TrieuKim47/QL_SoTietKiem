namespace WindowsFormsApp1
{
    partial class fThongTinSoTietKiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pDanhSachSTK = new System.Windows.Forms.Panel();
            this.dgvDanhSachSTK = new System.Windows.Forms.DataGridView();
            this.MaSTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChiNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMoSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDuSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuDongGiaHan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbTimKiemThongTinSo = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLoaiTimKiem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pDanhSachSTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSTK)).BeginInit();
            this.gbTimKiemThongTinSo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDanhSachSTK
            // 
            this.pDanhSachSTK.Controls.Add(this.dgvDanhSachSTK);
            this.pDanhSachSTK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDanhSachSTK.Location = new System.Drawing.Point(0, 273);
            this.pDanhSachSTK.Margin = new System.Windows.Forms.Padding(4);
            this.pDanhSachSTK.Name = "pDanhSachSTK";
            this.pDanhSachSTK.Size = new System.Drawing.Size(1467, 496);
            this.pDanhSachSTK.TabIndex = 1;
            // 
            // dgvDanhSachSTK
            // 
            this.dgvDanhSachSTK.AllowUserToAddRows = false;
            this.dgvDanhSachSTK.AllowUserToDeleteRows = false;
            this.dgvDanhSachSTK.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvDanhSachSTK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachSTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachSTK.ColumnHeadersHeight = 50;
            this.dgvDanhSachSTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDanhSachSTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSTK,
            this.MaKH,
            this.MaLoaiTK,
            this.MaNV,
            this.MaChiNhanh,
            this.NgayMoSo,
            this.SoDuSo,
            this.TuDongGiaHan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachSTK.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachSTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachSTK.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachSTK.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSachSTK.Name = "dgvDanhSachSTK";
            this.dgvDanhSachSTK.ReadOnly = true;
            this.dgvDanhSachSTK.RowHeadersVisible = false;
            this.dgvDanhSachSTK.RowHeadersWidth = 40;
            this.dgvDanhSachSTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachSTK.Size = new System.Drawing.Size(1467, 496);
            this.dgvDanhSachSTK.TabIndex = 0;
            // 
            // MaSTK
            // 
            this.MaSTK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaSTK.HeaderText = "Mã Sổ Tiết Kiệm";
            this.MaSTK.MinimumWidth = 6;
            this.MaSTK.Name = "MaSTK";
            this.MaSTK.ReadOnly = true;
            this.MaSTK.Width = 115;
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Width = 147;
            // 
            // MaLoaiTK
            // 
            this.MaLoaiTK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaLoaiTK.HeaderText = "Mã Loại Tiết Kiệm";
            this.MaLoaiTK.MinimumWidth = 6;
            this.MaLoaiTK.Name = "MaLoaiTK";
            this.MaLoaiTK.ReadOnly = true;
            this.MaLoaiTK.Width = 126;
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaNV.HeaderText = "Mã Nhân Viên Lập Sổ";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 141;
            // 
            // MaChiNhanh
            // 
            this.MaChiNhanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaChiNhanh.HeaderText = "Mã Chi Nhánh";
            this.MaChiNhanh.MinimumWidth = 6;
            this.MaChiNhanh.Name = "MaChiNhanh";
            this.MaChiNhanh.ReadOnly = true;
            this.MaChiNhanh.Width = 137;
            // 
            // NgayMoSo
            // 
            this.NgayMoSo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NgayMoSo.HeaderText = "Ngày Mở Sổ";
            this.NgayMoSo.MinimumWidth = 6;
            this.NgayMoSo.Name = "NgayMoSo";
            this.NgayMoSo.ReadOnly = true;
            this.NgayMoSo.Width = 105;
            // 
            // SoDuSo
            // 
            this.SoDuSo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SoDuSo.HeaderText = "Số Dư";
            this.SoDuSo.MinimumWidth = 6;
            this.SoDuSo.Name = "SoDuSo";
            this.SoDuSo.ReadOnly = true;
            this.SoDuSo.Width = 79;
            // 
            // TuDongGiaHan
            // 
            this.TuDongGiaHan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TuDongGiaHan.HeaderText = "Tự Động Gia Hạn";
            this.TuDongGiaHan.MinimumWidth = 6;
            this.TuDongGiaHan.Name = "TuDongGiaHan";
            this.TuDongGiaHan.ReadOnly = true;
            this.TuDongGiaHan.Width = 105;
            // 
            // gbTimKiemThongTinSo
            // 
            this.gbTimKiemThongTinSo.BackColor = System.Drawing.Color.White;
            this.gbTimKiemThongTinSo.Controls.Add(this.btnTimKiem);
            this.gbTimKiemThongTinSo.Controls.Add(this.textBox1);
            this.gbTimKiemThongTinSo.Controls.Add(this.label3);
            this.gbTimKiemThongTinSo.Controls.Add(this.cbLoaiTimKiem);
            this.gbTimKiemThongTinSo.Controls.Add(this.label2);
            this.gbTimKiemThongTinSo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTimKiemThongTinSo.ForeColor = System.Drawing.Color.Black;
            this.gbTimKiemThongTinSo.Location = new System.Drawing.Point(132, 11);
            this.gbTimKiemThongTinSo.Margin = new System.Windows.Forms.Padding(4);
            this.gbTimKiemThongTinSo.Name = "gbTimKiemThongTinSo";
            this.gbTimKiemThongTinSo.Padding = new System.Windows.Forms.Padding(4);
            this.gbTimKiemThongTinSo.Size = new System.Drawing.Size(1200, 197);
            this.gbTimKiemThongTinSo.TabIndex = 2;
            this.gbTimKiemThongTinSo.TabStop = false;
            this.gbTimKiemThongTinSo.Text = "Tìm kiếm thông tin sổ tiết kiệm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(923, 101);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(133, 49);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(335, 110);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(547, 34);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập thông tin tìm kiếm:";
            // 
            // cbLoaiTimKiem
            // 
            this.cbLoaiTimKiem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbLoaiTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiTimKiem.FormattingEnabled = true;
            this.cbLoaiTimKiem.Location = new System.Drawing.Point(448, 37);
            this.cbLoaiTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiTimKiem.Name = "cbLoaiTimKiem";
            this.cbLoaiTimKiem.Size = new System.Drawing.Size(332, 36);
            this.cbLoaiTimKiem.TabIndex = 1;
            this.cbLoaiTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbLoaiTimKiem_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm theo:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 211);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1467, 62);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1467, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SỔ TIẾT KIỆM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fThongTinSoTietKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1467, 769);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbTimKiemThongTinSo);
            this.Controls.Add(this.pDanhSachSTK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fThongTinSoTietKiem";
            this.Text = "fThongTinSoTietKiem";
            this.pDanhSachSTK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSTK)).EndInit();
            this.gbTimKiemThongTinSo.ResumeLayout(false);
            this.gbTimKiemThongTinSo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pDanhSachSTK;
        private System.Windows.Forms.GroupBox gbTimKiemThongTinSo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDanhSachSTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMoSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDuSo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TuDongGiaHan;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLoaiTimKiem;
        private System.Windows.Forms.Label label2;
    }
}