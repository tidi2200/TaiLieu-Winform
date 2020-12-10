using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool batdau = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(batdau == true)
            {
                int Gio = DateTime.Now.Hour;
                int Phut = DateTime.Now.Minute;
                int Giay = DateTime.Now.Second;

                lblRunTime.Text = Gio + ":" + Phut + ":" + Giay;

                int GioHen = int.Parse(txtGio.Text);
                int PhutHen = int.Parse(txtPhut.Text);
                int GiayHen = int.Parse(txtGiay.Text);

                if(Gio == GioHen && Phut == PhutHen && Giay == GiayHen)
                {
                    Process.Start(txtDuongDan.Text);
                    batdau = false;
                }
            }
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            timer1.Start();
            batdau = true;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            batdau = false;
        }

        private void btnBrows_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogOpen = new OpenFileDialog();
            dialogOpen.Filter = "";
            dialogOpen.Title = "Application open";
            string filename = null;
            if(dialogOpen.ShowDialog() == DialogResult.OK)
            {
                filename = dialogOpen.FileName;
                txtDuongDan.Text = filename;
            }
        }
    }
}
