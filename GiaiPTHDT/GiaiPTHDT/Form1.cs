using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiPTHDT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTinh1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtHeSoA.Text);
            int b = int.Parse(txtHeSoB.Text);
            PTB1 pt1 = new PTB1(a, b);
            String kq = pt1.GiaiPT();
            txtKetQua1.Text = kq.ToString();
        }

        private void btnTinh2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtHeSoA2.Text);
            int b = int.Parse(txtHeSoB2.Text);
            int c = int.Parse(txtHeSoC2.Text);
            PTB2 pt2 = new PTB2(a, b, c);
            String kq = pt2.GiaiPT2();
            txtKetQua2.Text = kq.ToString();
        }
    }
}
