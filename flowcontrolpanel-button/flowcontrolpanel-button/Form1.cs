using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flowcontrolpanel_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int SoN = 0;
        private void btnOK_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SoN = int.Parse(txtNhapN.Text);
            
            for(int i = 0; i < SoN; i++)
            {
                Button btn = new Button();
                btn.Name = "btn" + i;
                btn.Text = i.ToString();
                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += btn_Click;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.Blue;

            int giatri = int.Parse(btn.Text);
            if (KiemTraSNT(giatri))
                MessageBox.Show("Là số nguyên tố!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Không phải số nguyên tố!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool KiemTraSNT(int n)
        {
            if (n < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void btnSoChan_Click(object sender, EventArgs e)
        {
            string name = null;
            string text = null;

            foreach (Button control in flowLayoutPanel1.Controls)
            {
                Button btn = new Button();
                btn = (Button)control;
                name = btn.Name;
                text = btn.Text;
                
                if(int.Parse(text) % 2 == 0)
                {
                    btn.ForeColor = Color.YellowGreen;
                }

                //text = control.Text;
                //if (int.Parse(text) % 2 == 0)
                //{
                //    btn.ForeColor = Color.YellowGreen;
                //}
            }
            MessageBox.Show("Số chẵn đã được đổi màu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
