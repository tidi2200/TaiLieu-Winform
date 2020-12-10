using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyPhepToan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sothunhat = double.Parse(txtSoA.Text);
            double sothuhai = double.Parse(txtSoB.Text);

            string pheptoan = cboPhepToan.Text;

            XuLyPhepToan doituong = new XuLyPhepToan(sothunhat, sothuhai);
            txtKetQua.Text = doituong.XuLyPhepTinh(pheptoan).ToString();
        }
    }
}
