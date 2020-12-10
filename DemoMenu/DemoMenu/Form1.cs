using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DemoMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode==Keys.O)
            {
                openToolStripMenuItem_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                saveCrtSToolStripMenuItem_Click(sender, e);
            }
            if (e.Control && e.KeyCode == Keys.F4 )
            {
                closeToolStripMenuItem_Click(sender, e);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogOpen = new OpenFileDialog();
            dialogOpen.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialogOpen.InitialDirectory = @"Desktop";
            dialogOpen.Title = "Mở file txt";
            if(dialogOpen.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(dialogOpen.FileName);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                lblGioiThieu.Font = fontDialog1.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lblGioiThieu.ForeColor = colorDialog1.Color;
            }
        }

        private void saveCrtSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogSave = new SaveFileDialog();
            string filename = null;
            if(dialogSave.ShowDialog() == DialogResult.OK)
            {
                filename = dialogSave.FileName;
                StreamWriter swt = new StreamWriter(filename, false, Encoding.UTF8);
                swt.WriteLine(richTextBox1.Text);
                swt.Close();
            }
        }
    }
}
