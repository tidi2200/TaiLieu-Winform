using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuyetAnh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogOpen = new OpenFileDialog();
            dialogOpen.Filter = "";
            dialogOpen.Title = "Image open";
            string filename = null;
            if(dialogOpen.ShowDialog() == DialogResult.OK)
            {
                filename = dialogOpen.FileName;
                picAnh.Image = Image.FromFile(filename);
            }
        }
    }
}
