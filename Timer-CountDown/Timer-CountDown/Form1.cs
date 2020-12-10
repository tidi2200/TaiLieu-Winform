using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_CountDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool batdau = false;
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            batdau = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (batdau == true)
            {
                int Giay = int.Parse(txtThoiGian.Text);
                Giay --;
                txtThoiGian.Text = Giay.ToString();
                if (txtThoiGian.Text == "0")
                {
                    batdau = false;
                    MessageBox.Show("Game over");
                }
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            batdau = false;
            lblCountDown.Text = "0";
            MessageBox.Show("Game over");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
