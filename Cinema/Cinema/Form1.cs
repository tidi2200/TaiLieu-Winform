using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HangGhe.Controls.Clear();
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    CheckBox cb = new CheckBox();
                    cb.Name = "cb" + i + "." + j;
                    cb.Text = i + "." + j;
                    HangGhe.Controls.Add(cb);
                    cb.Click += cb_Click;
                    txtThanhTien.Text = "0";
                    txtTongTien.Text = "0";
                }
            }         
        }

        int ThanhTien = 0;
        private void cb_Click (object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
           
            if (cb.Checked == true ) //Chon lan dau tien
            {
                lbPhai.Items.Add(cb.Text);
                ThanhTien += 50000;
                txtThanhTien.Text = ThanhTien.ToString();
            }
            else
            {
                lbPhai.Items.Remove(cb.Text);
                ThanhTien -= 50000;
                txtThanhTien.Text = ThanhTien.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbPhai.Items.Count == 0)
            {
                MessageBox.Show("Chưa chọn ghế");
            }
            else
            {
                txtTongTien.Text = txtThanhTien.Text;
                txtThanhTien.Text = "0";
                for (int i = 0; i < lbPhai.Items.Count; i++)
                {
                    listBox1.Items.Add(lbPhai.Items[i]);
                }
                lbPhai.Items.Clear();

                foreach (CheckBox cb in HangGhe.Controls)
                {
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        if (cb.Text.Equals(listBox1.Items[i]))
                            cb.Enabled = false;
                    }
                }
            }
        }

        private void btnXoaGheDaChon_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                MessageBox.Show("Chưa chọn ghế cần xóa");
            else
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                ThanhTien -= 50000;
                txtTongTien.Text = ThanhTien.ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            CheckBox cb = new CheckBox();
            lbPhai.Items.Clear();
            listBox1.Items.Clear();
            txtThanhTien.Text = "0";
            txtTongTien.Text = "0";
            ThanhTien = 0;
            foreach (CheckBox chk in HangGhe.Controls)
            {
                chk.Enabled = true;
                chk.Checked = false;
            }
        }

        private void btnInVe_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("====In vé không thành công====");
            }
            else
            {
                DateTime dt = DateTime.Now;
                string SoGhe = null;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    SoGhe += listBox1.Items[i] + "  ";
                }

                DialogResult result = MessageBox.Show("====Bạn đã in vé thành công==== \nSố ghế: " + SoGhe + "\nTổng tiền: " + ThanhTien + "\nNgày in: " + dt.ToString("dd/MM/yyyy h:m:ss"
                    + "\nRạp: "), "Thông báo", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    listBox1.Items.Clear();
                    txtThanhTien.Text = "0";
                    txtTongTien.Text = "0";
                    ThanhTien = 0;
                }
            }
        }
    }
}
