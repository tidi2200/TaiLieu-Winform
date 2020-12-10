using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HinhChuNhat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhChuVi_Click(object sender, EventArgs e)
        {
            double cd = double.Parse(txtChieuDai.Text);
            double cr = double.Parse(txtChieuRong.Text);
            HinhChuNhat hcn = new HinhChuNhat(cd, cr);
            double chuvi = hcn.TinhChuVi();
            lblKetQua.Text = "Chu vi là";
            txtKetQua.Text = chuvi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTinhDienTich_Click(object sender, EventArgs e)
        {
            double cd = double.Parse(txtChieuDai.Text);
            double cr = double.Parse(txtChieuRong.Text);
            HinhChuNhat hcn = new HinhChuNhat(cd, cr);
            double dientich = hcn.TinhDienTich();
            lblKetQua.Text = "Diện tích là";
            txtKetQua.Text = dientich.ToString();
        }
    }
}
