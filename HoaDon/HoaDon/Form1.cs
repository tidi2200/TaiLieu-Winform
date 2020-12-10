using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoaDon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            float SoLuong = float.Parse(txtSoLuong.Text);
            float DonGia = float.Parse(txtDonGia.Text);
            float Thue = (SoLuong * DonGia) / 100 * 5;
            txtThue.Text = Thue.ToString();
            float Tong = SoLuong*DonGia;
            string name = txtTenHang.Text;
            if (radioButton1.Checked)
            {
                Tong += Thue + 10000;
                txtThanhTien.Text = Tong.ToString();
                MessageBox.Show("       Thông tin hóa đơn\nTên hàng: " + name + "\nSố lượng: " + SoLuong +
               "\nĐơn giá: " + DonGia + "\nGiao hàng: Có" + "\nThuế: " + Thue + "\nThanh Tiền: " + Tong, "Hóa đơn tính tiền");
            }
            if (radioButton2.Checked)
            {
                Tong += + Thue;
                txtThanhTien.Text = Tong.ToString();
                MessageBox.Show("       Thông tin hóa đơn\nTên hàng: " + name + "\nSố lượng: " + SoLuong +
               "\nĐơn giá: " + DonGia + "\nGiao hàng: Không" + "\nThuế: " + Thue + "\nThanh Tiền: " + Tong, "Hóa đơn tính tiền");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
