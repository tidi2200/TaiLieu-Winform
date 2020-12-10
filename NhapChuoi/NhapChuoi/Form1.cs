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

namespace NhapChuoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtNhapChuoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập chuỗi");
            }
            else
            {
                lbTrai.Items.Add(txtNhapChuoi.Text);
                txtNhapChuoi.Text = "";
                txtNhapChuoi.Focus();
            }
        }

        private void btnQuaPhai_Click(object sender, EventArgs e)
        {
            if (lbTrai.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn chuỗi");
            }
            else
            {
                lbPhai.Items.Add(lbTrai.SelectedItem.ToString());
                lbTrai.Items.RemoveAt(lbTrai.SelectedIndex);
            }
        }

        private void btnQuaPhaiHet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<lbTrai.Items.Count;i++)
            {
                lbPhai.Items.Add(lbTrai.Items[i]);
            }
            lbTrai.Items.Clear();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnXoaTrai_Click(object sender, EventArgs e)
        {
            if (lbTrai.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn chuỗi");
            }
            else
            {
                lbTrai.Items.Remove(lbTrai.SelectedItem);
            }
        }

        private void btnXoaPhai_Click(object sender, EventArgs e)
        {
            if (lbTrai.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn chuỗi");
            }
            else
            {
                lbPhai.Items.Remove(lbPhai.SelectedItem);
            }
        }

        private void btnQuaTrai_Click(object sender, EventArgs e)
        {
            if (lbPhai.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn chuỗi");
            }
            else
            {
                lbTrai.Items.Add(lbPhai.SelectedItem.ToString());
                lbPhai.Items.RemoveAt(lbPhai.SelectedIndex);
            }
        }

        private void btnQuaTraiHet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbPhai.Items.Count; i++)
            {
                lbTrai.Items.Add(lbPhai.Items[i]); 
            }
            lbPhai.Items.Clear();
        }

        private void lbTrai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
    }
}
