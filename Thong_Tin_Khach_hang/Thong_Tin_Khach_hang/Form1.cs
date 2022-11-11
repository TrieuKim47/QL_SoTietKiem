using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thong_Tin_Khach_hang
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            dateTimePicker3.CustomFormat = "dd-MM-yyyy";
            tabControl1.TabPages.Remove(tabPage2);
        }
        private void iconButton7_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Add(tabPage2);
            tabPage2.Text = "Mở sổ";
        }

        private void iconbtnAdd_Click(object sender, EventArgs e)
        {
            if(cbochiNhanh.Text == "" || cboloaiTietKiem.Text == "" || txtsoTien.Text == "" || cbotuGiaHan.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Mở sổ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                iconbtnAdd.Hide();
                iconbtnphieuGuiTien.Show();
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Add(tabPage1);
            tabPage1.Text = "Thông tin khách hàng";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconbtnphieuGuiTien_Click(object sender, EventArgs e)
        {
            iconbtnphieuGuiTien.Hide();
            iconbtninSo.Show();
        }

        private void iconButton7_Click_1(object sender, EventArgs e)
        {
            cbochiNhanh.Text = "";
            cboloaiTietKiem.Text = "";
            cbotuGiaHan.Text = "";
            txtsoTien.Text = "";
        }

        private void iconBtnreDo_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
