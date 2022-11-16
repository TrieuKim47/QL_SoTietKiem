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



namespace WindowsFormsApp1
{
    public partial class MainFormManager : Form
    {
        public MainFormManager()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            panelThongTinKhachHang.Visible = false;
            panelThongTinSo.Visible=false;
            panelNhanVien.Visible=false;
            panelBCTK.Visible=false;
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

        private void iconKhachHang_Click(object sender, EventArgs e)
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
        }

        private void btnThemSo_Click(object sender, EventArgs e)
        {
            hidenSubMenu();
        }

        private void btnRutSo_Click(object sender, EventArgs e)
        {
            hidenSubMenu();
        }

        private void btnGuIThemVon_Click(object sender, EventArgs e)
        {
            hidenSubMenu();
        }

        private void btnGiaHanSo_Click(object sender, EventArgs e)
        {
            hidenSubMenu();
        }

        private void btnQuanLyNV_Click(object sender, EventArgs e)
        {
            hidenSubMenu();
        }

        private void btnSoTienGiaoDich_Click(object sender, EventArgs e)
        {
            hidenSubMenu();
        }

        private void btnTopKhachHang_Click(object sender, EventArgs e)
        {
            hidenSubMenu();
        }

        private void btnLuongGiaoDich_Click(object sender, EventArgs e)
        {
            hidenSubMenu();
        }
    
    }
    
    
}
