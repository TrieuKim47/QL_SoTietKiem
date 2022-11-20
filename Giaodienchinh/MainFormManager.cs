using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Lần_1;
using Thong_Tin_Khach_hang;

namespace WindowsFormsApp1
{
    public partial class MainFormManager : Form
    {

        private Form curentChildForm;
        public static MainFormManager Instance;
        public MainFormManager()
        {
            InitializeComponent();
            customizeDesign();
            Instance = this;
        }
        private void customizeDesign()
        {
            panelThongTinKhachHang.Visible = false;
            panelThongTinSo.Visible=false;
            panelNhanVien.Visible=false;
            panelBCTK.Visible=false;
            pnChinhSach.Visible = false;
        }

        private void hidenSubMenu()
        {
            if(panelThongTinKhachHang.Visible==true)
            { 
                panelThongTinKhachHang.Visible=false;
            }
            if(panelThongTinSo.Visible==true)
            {
                panelThongTinSo.Visible= false;
            }
            if(panelNhanVien.Visible==true)
            {
                panelNhanVien.Visible= false;
            }
            if(panelBCTK.Visible==true)
            {
                panelBCTK.Visible= false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible==false)
            {
                hidenSubMenu();
                subMenu.Visible=true;
            }
            else
                subMenu.Visible=false;  
        }

        public void iconKhachHang_Click(object sender, EventArgs e)
        {
            showSubMenu(panelThongTinKhachHang);
        }

        private void iconThongTinSo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelThongTinSo);
        }
    
        private void iconNhanVien_Click(object sender, EventArgs e)
        {
            showSubMenu(panelNhanVien);
        }
               
        private void iconBCTK_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBCTK);
        }              
                    
        private void btnThongTinChung_Click(object sender, EventArgs e)
        {
            hidenSubMenu();
            openChildForm(new frmthongTinKhachHang());
        }


        public void openChildForm(Form childForm)
        {
            if (curentChildForm != null)
            {
                curentChildForm.Close();
            }
            curentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(curentChildForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnThemSo_Click(object sender, EventArgs e)
        {
            hidenSubMenu();
            openChildForm(new frmThongtinso());
        }

        private void btnRutSo_Click(object sender, EventArgs e)
        {
            hidenSubMenu();
            
        }

        private void btnGuIThemVon_Click(object sender, EventArgs e)
        {
            hidenSubMenu();
            openChildForm(new fGuiThemVon());
        }

        private void btnGiaHanSo_Click(object sender, EventArgs e)
        {
            hidenSubMenu();
            openChildForm(new fGiaHanSo());
        }

        private void btnQuanLyNV_Click(object sender, EventArgs e)
        {
            hidenSubMenu();
            openChildForm(new Form1());
        }

        private void btnSoTienGiaoDich_Click(object sender, EventArgs e)
        {
            hidenSubMenu();
        }

        private void btnTopKhachHang_Click(object sender, EventArgs e)
        {
            hidenSubMenu();
            openChildForm(new frmTopKhachHang());
        }

        private void btnLuongGiaoDich_Click(object sender, EventArgs e)
        {
            hidenSubMenu();
            openChildForm(new frmLuongGiaoDich());
        }

        private void iconChinhSach_Click(object sender, EventArgs e)
        {
            showSubMenu(pnChinhSach);
        }

        private void btCSLX_Click(object sender, EventArgs e)
        {
            openChildForm(new ChinhSuaLoaiTK());
            hidenSubMenu();
        }

        private void btCSNH_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongTinChinhSach());
            hidenSubMenu();
        }
    }
    
    
}
