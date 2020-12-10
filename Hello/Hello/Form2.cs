using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //test.ShowLines = false;
            //test.ShowPlusMinus = true;
            //test.ShowRootLines = false;
            //test.ExpandAll();
            comboBox1.Items.Add("abc");
            listBox1.Items.Add("Monday");
            int i = 3;
            int j = 5;
            int k = 2;
            if (i < j)
                if (i < k) i = 4; 
                else i = 5;
            textBox1.Text = i.ToString();
        }
    }
}
