using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiPhuongTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (cboPT.SelectedItem.ToString() == "Vui lòng chọn")
            {
                MessageBox.Show("Vui lòng chọn bậc phương trình !");
            }
            if (cboPT.SelectedItem.ToString() == "Giải phương trình bậc nhất")
            {
                if(string.IsNullOrEmpty(txtSoA.Text))
                {
                    MessageBox.Show("Chưa nhập số A !");
                    txtSoA.Focus();
                }
                else if (string.IsNullOrEmpty(txtSoB.Text))
                {
                     MessageBox.Show("Chưa nhập số B !");
                     txtSoB.Focus();
                }
                else
                {
                    float SoA = float.Parse(txtSoA.Text);
                    float SoB = float.Parse(txtSoB.Text);
                     if (SoA == 0)
                     {
                        if (SoB == 0)
                            txtx1.Text = "Vô số nghiệm ";
                        else
                            txtx1.Text = "Vô nghiệm";
                     }
                     else
                     {
                        float x = -SoB / SoA;
                        txtx1.Text = x.ToString();
                        txtx2.Text = "";
                     }
                }
            }
            if(cboPT.SelectedItem.ToString() == "Giải phương trình bậc hai")
            {
                if (string.IsNullOrEmpty(txtSoA.Text))
                {
                    MessageBox.Show("Chưa nhập số A !");
                    txtSoA.Focus();
                }
                else if (string.IsNullOrEmpty(txtSoB.Text))
                {
                    MessageBox.Show("Chưa nhập số B !");
                    txtSoB.Focus();
                }
                else if (string.IsNullOrEmpty(txtSoC.Text))
                {
                    MessageBox.Show("Chưa nhập số C !");
                    txtSoC.Focus();
                }
                else
                {
                    float SoA = float.Parse(txtSoA.Text);
                    float SoB = float.Parse(txtSoB.Text);
                    float SoC = float.Parse(txtSoC.Text);
                    float delta = SoB * SoB - 4 * SoA * SoC;
                    if (delta < 0)
                    {
                        MessageBox.Show("Phương trình vô nghiệm");
                    }
                    else if (delta == 0)
                    {
                        float kq = -SoB / (2 * SoA);
                        txtx1.Text = kq.ToString();
                        txtx2.Text = kq.ToString();
                    }
                    else
                    {
                        double canDelta = Math.Sqrt(delta);                           
                        double x1 = (-SoB + canDelta) / (2 * SoA);
                        double x2 = (-SoB - canDelta) / (2 * SoA);
                        txtx1.Text = x1.ToString();
                        txtx2.Text = x2.ToString();
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoPhuongThuc(cboPT);
        }

        private void KhoiTaoPhuongThuc (ComboBox cbo)
        {
            cbo.Items.Add("Vui lòng chọn");
            cbo.Items.Add("Giải phương trình bậc nhất");
            cbo.Items.Add("Giải phương trình bậc hai");
            cbo.SelectedIndex = 0;
        }
    }
}
