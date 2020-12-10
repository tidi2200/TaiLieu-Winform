using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flowcontrolpanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear(); //neu khong co dong nay thi an nut hien thi se bi cong don
            for(int i=2; i<=9; i++)
            { 
                for(int j = 1; j<=10; j++)
                {
                    TextBox txt = new TextBox();
                    txt.Name = "txt" + i + j;
                    txt.Text = i + "x" + j + "=" + i * j;
                    txt.Enabled = false;
                    flowLayoutPanel1.Controls.Add(txt);
                }
            }
        }
    }
}
