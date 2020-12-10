using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLGT_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();

            bool flag = frm2.Flag;

            if(flag == true)
            {
                txtLayGiaTri.Text = frm2.N.ToString();
            }
            else
            {
                MessageBox.Show("Không có giá trị nhập");
                txtLayGiaTri.Text = "null";
            }
            frm2.Close();
        }
    }
}
