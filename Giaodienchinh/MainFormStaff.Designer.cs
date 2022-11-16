﻿namespace WindowsFormsApp1
{
    partial class MainFormStaff
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
            this.panelBar = new System.Windows.Forms.Panel();
            this.panelBCTK = new System.Windows.Forms.Panel();
            this.btnLuongGD = new System.Windows.Forms.Button();
            this.btnSoTienGD = new System.Windows.Forms.Button();
            this.btnTopKachHang = new System.Windows.Forms.Button();
            this.panelThongTinSo = new System.Windows.Forms.Panel();
            this.btnGiaHanSo = new System.Windows.Forms.Button();
            this.btnGuIThemVon = new System.Windows.Forms.Button();
            this.btnRutSo = new System.Windows.Forms.Button();
            this.btnThemSo = new System.Windows.Forms.Button();
            this.panelThongTinKhachHang = new System.Windows.Forms.Panel();
            this.btnSoTietKiem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelChildForm = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.iconChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.iconBCTK = new FontAwesome.Sharp.IconButton();
            this.iconThongTinSo = new FontAwesome.Sharp.IconButton();
            this.iconKhachHang = new FontAwesome.Sharp.IconButton();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelBar.SuspendLayout();
            this.panelBCTK.SuspendLayout();
            this.panelThongTinSo.SuspendLayout();
            this.panelThongTinKhachHang.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBar
            // 
            this.panelBar.AutoScroll = true;
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(102)))), ((int)(((byte)(88)))));
            this.panelBar.Controls.Add(this.panelBCTK);
            this.panelBar.Controls.Add(this.iconBCTK);
            this.panelBar.Controls.Add(this.panelThongTinSo);
            this.panelBar.Controls.Add(this.iconThongTinSo);
            this.panelBar.Controls.Add(this.panelThongTinKhachHang);
            this.panelBar.Controls.Add(this.iconKhachHang);
            this.panelBar.Controls.Add(this.panel2);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(159, 681);
            this.panelBar.TabIndex = 0;
            // 
            // panelBCTK
            // 
            this.panelBCTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(110)))), ((int)(((byte)(95)))));
            this.panelBCTK.Controls.Add(this.btnLuongGD);
            this.panelBCTK.Controls.Add(this.btnSoTienGD);
            this.panelBCTK.Controls.Add(this.btnTopKachHang);
            this.panelBCTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBCTK.Location = new System.Drawing.Point(0, 417);
            this.panelBCTK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBCTK.Name = "panelBCTK";
            this.panelBCTK.Size = new System.Drawing.Size(159, 110);
            this.panelBCTK.TabIndex = 5;
            // 
            // btnLuongGD
            // 
            this.btnLuongGD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLuongGD.FlatAppearance.BorderSize = 0;
            this.btnLuongGD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuongGD.Location = new System.Drawing.Point(0, 58);
            this.btnLuongGD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuongGD.Name = "btnLuongGD";
            this.btnLuongGD.Size = new System.Drawing.Size(159, 24);
            this.btnLuongGD.TabIndex = 2;
            this.btnLuongGD.Text = "Lượng giao dịch";
            this.btnLuongGD.UseVisualStyleBackColor = true;
            this.btnLuongGD.Click += new System.EventHandler(this.btnLuongGD_Click);
            // 
            // btnSoTienGD
            // 
            this.btnSoTienGD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSoTienGD.FlatAppearance.BorderSize = 0;
            this.btnSoTienGD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoTienGD.Location = new System.Drawing.Point(0, 28);
            this.btnSoTienGD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSoTienGD.Name = "btnSoTienGD";
            this.btnSoTienGD.Size = new System.Drawing.Size(159, 30);
            this.btnSoTienGD.TabIndex = 1;
            this.btnSoTienGD.Text = "Số tiền giao dịch";
            this.btnSoTienGD.UseVisualStyleBackColor = true;
            // 
            // btnTopKachHang
            // 
            this.btnTopKachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTopKachHang.FlatAppearance.BorderSize = 0;
            this.btnTopKachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopKachHang.Location = new System.Drawing.Point(0, 0);
            this.btnTopKachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTopKachHang.Name = "btnTopKachHang";
            this.btnTopKachHang.Size = new System.Drawing.Size(159, 28);
            this.btnTopKachHang.TabIndex = 0;
            this.btnTopKachHang.Text = "Top khách hàng ";
            this.btnTopKachHang.UseVisualStyleBackColor = true;
            this.btnTopKachHang.Click += new System.EventHandler(this.btnTopKachHang_Click);
            // 
            // panelThongTinSo
            // 
            this.panelThongTinSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(110)))), ((int)(((byte)(95)))));
            this.panelThongTinSo.Controls.Add(this.btnGiaHanSo);
            this.panelThongTinSo.Controls.Add(this.btnGuIThemVon);
            this.panelThongTinSo.Controls.Add(this.btnRutSo);
            this.panelThongTinSo.Controls.Add(this.btnThemSo);
            this.panelThongTinSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongTinSo.Location = new System.Drawing.Point(0, 237);
            this.panelThongTinSo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelThongTinSo.Name = "panelThongTinSo";
            this.panelThongTinSo.Size = new System.Drawing.Size(159, 131);
            this.panelThongTinSo.TabIndex = 3;
            // 
            // btnGiaHanSo
            // 
            this.btnGiaHanSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGiaHanSo.FlatAppearance.BorderSize = 0;
            this.btnGiaHanSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaHanSo.Location = new System.Drawing.Point(0, 89);
            this.btnGiaHanSo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGiaHanSo.Name = "btnGiaHanSo";
            this.btnGiaHanSo.Size = new System.Drawing.Size(159, 33);
            this.btnGiaHanSo.TabIndex = 3;
            this.btnGiaHanSo.Text = "Gia hạn sổ";
            this.btnGiaHanSo.UseVisualStyleBackColor = true;
            // 
            // btnGuIThemVon
            // 
            this.btnGuIThemVon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuIThemVon.FlatAppearance.BorderSize = 0;
            this.btnGuIThemVon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuIThemVon.Location = new System.Drawing.Point(0, 56);
            this.btnGuIThemVon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuIThemVon.Name = "btnGuIThemVon";
            this.btnGuIThemVon.Size = new System.Drawing.Size(159, 33);
            this.btnGuIThemVon.TabIndex = 2;
            this.btnGuIThemVon.Text = "Gửi thêm  vốn";
            this.btnGuIThemVon.UseVisualStyleBackColor = true;
            // 
            // btnRutSo
            // 
            this.btnRutSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRutSo.FlatAppearance.BorderSize = 0;
            this.btnRutSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutSo.Location = new System.Drawing.Point(0, 28);
            this.btnRutSo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRutSo.Name = "btnRutSo";
            this.btnRutSo.Size = new System.Drawing.Size(159, 28);
            this.btnRutSo.TabIndex = 1;
            this.btnRutSo.Text = "Rút sổ";
            this.btnRutSo.UseVisualStyleBackColor = true;
            // 
            // btnThemSo
            // 
            this.btnThemSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThemSo.FlatAppearance.BorderSize = 0;
            this.btnThemSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSo.Location = new System.Drawing.Point(0, 0);
            this.btnThemSo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemSo.Name = "btnThemSo";
            this.btnThemSo.Size = new System.Drawing.Size(159, 28);
            this.btnThemSo.TabIndex = 0;
            this.btnThemSo.Text = "Thêm sổ";
            this.btnThemSo.UseVisualStyleBackColor = true;
            // 
            // panelThongTinKhachHang
            // 
            this.panelThongTinKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(110)))), ((int)(((byte)(95)))));
            this.panelThongTinKhachHang.Controls.Add(this.btnSoTietKiem);
            this.panelThongTinKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongTinKhachHang.Location = new System.Drawing.Point(0, 151);
            this.panelThongTinKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelThongTinKhachHang.Name = "panelThongTinKhachHang";
            this.panelThongTinKhachHang.Size = new System.Drawing.Size(159, 37);
            this.panelThongTinKhachHang.TabIndex = 2;
            // 
            // btnSoTietKiem
            // 
            this.btnSoTietKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSoTietKiem.FlatAppearance.BorderSize = 0;
            this.btnSoTietKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoTietKiem.Location = new System.Drawing.Point(0, 0);
            this.btnSoTietKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSoTietKiem.Name = "btnSoTietKiem";
            this.btnSoTietKiem.Size = new System.Drawing.Size(159, 28);
            this.btnSoTietKiem.TabIndex = 0;
            this.btnSoTietKiem.Text = "Thông tin chung";
            this.btnSoTietKiem.UseVisualStyleBackColor = true;
            this.btnSoTietKiem.Click += new System.EventHandler(this.btnSoTietKiem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 102);
            this.panel2.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(102)))), ((int)(((byte)(88)))));
            this.panelTitleBar.Controls.Add(this.labelChildForm);
            this.panelTitleBar.Controls.Add(this.iconChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(159, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1105, 55);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // labelChildForm
            // 
            this.labelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelChildForm.AutoSize = true;
            this.labelChildForm.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChildForm.Location = new System.Drawing.Point(40, 18);
            this.labelChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelChildForm.Name = "labelChildForm";
            this.labelChildForm.Size = new System.Drawing.Size(50, 17);
            this.labelChildForm.TabIndex = 1;
            this.labelChildForm.Text = "Home";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(166)))), ((int)(((byte)(143)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(159, 55);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelChildForm.MinimumSize = new System.Drawing.Size(656, 406);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1105, 626);
            this.panelChildForm.TabIndex = 2;
            // 
            // iconChildForm
            // 
            this.iconChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.iconChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(102)))), ((int)(((byte)(88)))));
            this.iconChildForm.ForeColor = System.Drawing.Color.Yellow;
            this.iconChildForm.IconChar = FontAwesome.Sharp.IconChar.HouseChimney;
            this.iconChildForm.IconColor = System.Drawing.Color.Yellow;
            this.iconChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconChildForm.IconSize = 31;
            this.iconChildForm.Location = new System.Drawing.Point(4, 10);
            this.iconChildForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.iconChildForm.Name = "iconChildForm";
            this.iconChildForm.Size = new System.Drawing.Size(31, 33);
            this.iconChildForm.TabIndex = 0;
            this.iconChildForm.TabStop = false;
            // 
            // iconBCTK
            // 
            this.iconBCTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBCTK.FlatAppearance.BorderSize = 0;
            this.iconBCTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBCTK.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBCTK.ForeColor = System.Drawing.Color.White;
            this.iconBCTK.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.iconBCTK.IconColor = System.Drawing.Color.White;
            this.iconBCTK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBCTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBCTK.Location = new System.Drawing.Point(0, 368);
            this.iconBCTK.Margin = new System.Windows.Forms.Padding(2);
            this.iconBCTK.Name = "iconBCTK";
            this.iconBCTK.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.iconBCTK.Size = new System.Drawing.Size(159, 49);
            this.iconBCTK.TabIndex = 4;
            this.iconBCTK.Text = "Báo cáo ";
            this.iconBCTK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBCTK.UseVisualStyleBackColor = true;
            this.iconBCTK.Click += new System.EventHandler(this.iconBCTK_Click);
            // 
            // iconThongTinSo
            // 
            this.iconThongTinSo.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconThongTinSo.FlatAppearance.BorderSize = 0;
            this.iconThongTinSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconThongTinSo.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconThongTinSo.ForeColor = System.Drawing.Color.White;
            this.iconThongTinSo.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconThongTinSo.IconColor = System.Drawing.Color.White;
            this.iconThongTinSo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconThongTinSo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconThongTinSo.Location = new System.Drawing.Point(0, 188);
            this.iconThongTinSo.Margin = new System.Windows.Forms.Padding(2);
            this.iconThongTinSo.Name = "iconThongTinSo";
            this.iconThongTinSo.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.iconThongTinSo.Size = new System.Drawing.Size(159, 49);
            this.iconThongTinSo.TabIndex = 2;
            this.iconThongTinSo.Text = "Sổ tiết kiệm";
            this.iconThongTinSo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconThongTinSo.UseVisualStyleBackColor = true;
            this.iconThongTinSo.Click += new System.EventHandler(this.iconGiaoDich_Click);
            // 
            // iconKhachHang
            // 
            this.iconKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconKhachHang.FlatAppearance.BorderSize = 0;
            this.iconKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconKhachHang.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconKhachHang.ForeColor = System.Drawing.Color.White;
            this.iconKhachHang.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconKhachHang.IconColor = System.Drawing.Color.White;
            this.iconKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconKhachHang.Location = new System.Drawing.Point(0, 102);
            this.iconKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.iconKhachHang.Name = "iconKhachHang";
            this.iconKhachHang.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.iconKhachHang.Size = new System.Drawing.Size(159, 49);
            this.iconKhachHang.TabIndex = 1;
            this.iconKhachHang.Text = "Khách hàng ";
            this.iconKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconKhachHang.UseVisualStyleBackColor = true;
            this.iconKhachHang.Click += new System.EventHandler(this.iconThongTin_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureLogo.Image = global::WindowsFormsApp1.Properties.Resources._7e0c8d2e412f4676b52e692542423cd8;
            this.pictureLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(159, 98);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureLogo.TabIndex = 1;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.Click += new System.EventHandler(this.pictureLogo_Click);
            // 
            // MainFormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelBar);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(833, 507);
            this.Name = "MainFormStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelBar.ResumeLayout(false);
            this.panelBCTK.ResumeLayout(false);
            this.panelThongTinSo.ResumeLayout(false);
            this.panelThongTinKhachHang.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconKhachHang;
        private FontAwesome.Sharp.IconButton iconBCTK;
        private FontAwesome.Sharp.IconButton iconThongTinSo;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconChildForm;
        private System.Windows.Forms.Label labelChildForm;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelThongTinKhachHang;
        private System.Windows.Forms.Button btnSoTietKiem;
        private System.Windows.Forms.Panel panelBCTK;
        private System.Windows.Forms.Button btnLuongGD;
        private System.Windows.Forms.Button btnSoTienGD;
        private System.Windows.Forms.Button btnTopKachHang;
        private System.Windows.Forms.Panel panelThongTinSo;
        private System.Windows.Forms.Button btnGuIThemVon;
        private System.Windows.Forms.Button btnRutSo;
        private System.Windows.Forms.Button btnThemSo;
        private System.Windows.Forms.Button btnGiaHanSo;
    }
}

