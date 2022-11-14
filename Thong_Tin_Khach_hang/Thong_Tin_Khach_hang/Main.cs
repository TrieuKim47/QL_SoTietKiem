using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Thong_Tin_Khach_hang
{
    public partial class frmMain : Form
    {
        private Form curentChildForm;
        public frmMain()
        {
            InitializeComponent();
        }

        private void openChildForm(Form childForm)
        {
            if (curentChildForm != null)
            {
                curentChildForm.Close();
            }
            curentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(curentChildForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnthongTinKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new frmthongTinKhachHang());
        }

        private void btnthongKeGiaoDich_Click(object sender, EventArgs e)
        {
            openChildForm(new frmthongKeGiaoDich());
        }
    }
}
