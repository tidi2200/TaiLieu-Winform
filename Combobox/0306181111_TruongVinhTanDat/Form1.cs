using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0306181111_TruongVinhTanDat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtkq_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KhoiTaoPhepToan(cbbpt);
        }

        private void KhoiTaoPhepToan(ComboBox cbo)
        {
            cbo.Items.Add("Vui lòng chọn phép toán");
            cbo.Items.Add("Cộng");
            cbo.Items.Add("Trừ");
            cbo.Items.Add("Nhân");
            cbo.Items.Add("Chia");

            cbo.SelectedIndex = 0;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtstn.Text))
            {
                MessageBox.Show("Vui lòng nhập số thứ nhất !");
                txtstn.Focus();
            }
            else
            {
                if(cbbpt.SelectedItem.ToString() == "Cộng")
                {
                    float SoA = float.Parse(txtstn.Text);
                    float SoB = float.Parse(txtsth.Text);
                    float Tong = SoA + SoB;
                    txtkq.Text = Tong.ToString();
                }
                if (cbbpt.SelectedItem.ToString() == "Trừ")
                {
                    float SoA = float.Parse(txtstn.Text);
                    float SoB = float.Parse(txtsth.Text);
                    float Tong = SoA - SoB;
                    txtkq.Text = Tong.ToString();
                }
                if (cbbpt.SelectedItem.ToString() == "Nhân")
                {
                    float SoA = float.Parse(txtstn.Text);
                    float SoB = float.Parse(txtsth.Text);
                    float Tong = SoA * SoB;
                    txtkq.Text = Tong.ToString();
                }
                if (cbbpt.SelectedItem.ToString() == "Chia")
                {
                    float sth = float.Parse(txtsth.Text);
                    if (sth == 0)
                    {
                        MessageBox.Show("Vui lòng nhập số thứ 2 khác 0");
                        txtsth.Focus();
                    }
                    else
                    {
                        float SoA = float.Parse(txtstn.Text);
                        float SoB = float.Parse(txtsth.Text);
                        float Tong = SoA / SoB;
                        txtkq.Text = Tong.ToString();
                    }
                }
            }
        }
    }
}
