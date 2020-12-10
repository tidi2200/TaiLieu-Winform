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
    public partial class Form2 : Form
    {
        private bool flag = false;
        private int n;

        public int N
        {
            get { return n; }
            set { n = value; }
        }

        public bool Flag
        {
            get { return flag;}
            set { flag = value;}
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            flag = true;
            this.Close();
            if (txtNhapGiaTri.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập giá trị, vui lòng thử lại");
            }
            else
            {      
                n = int.Parse(txtNhapGiaTri.Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            flag = false;
            this.Close();
        }
    }
}
