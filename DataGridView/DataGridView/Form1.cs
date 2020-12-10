using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int dongthu = -1;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu = e.RowIndex;

                DataGridViewRow row = dataGridView1.Rows[dongthu];
                txtmssv.Text = row.Cells["mssv"].Value.ToString();
                txthoten.Text = row.Cells["hoten"].Value.ToString();
                txtdiemtoan.Text = row.Cells["diemtoan"].Value.ToString();
                txtdiemvan.Text = row.Cells["diemvan"].Value.ToString();
            }catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private float tinhDTB(float toan, float van)
        {
            return (toan + van) / 2;
        }

        private string folk(float diemtb)
        {
            string folk = null;
            if (diemtb < 3)
                folk = "Kém";
            else
                if (diemtb < 5)
                    folk = "Yếu";
                else
                    if (diemtb < 7)
                        folk = "Trung bình";
                    else
                        if (diemtb < 8)
                            folk = "Khá";
                        else
                            folk = "Giỏi";
            return folk;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txthoten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên ");
            }
            else if(txtmssv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập MSSV");
            }
            else if(txtdiemtoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập điểm toán");
            }
            else if (txtdiemvan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập điểm văn");
            }
            else
            {
                float dtb = tinhDTB(float.Parse(txtdiemtoan.Text), float.Parse(txtdiemvan.Text));
                string xeploai = folk(dtb);
                dataGridView1.Rows.Add(txtmssv.Text, txthoten.Text,
                    txtdiemtoan.Text, txtdiemvan.Text, dtb, xeploai);

                txtdiemtoan.Text = "";
                txtdiemvan.Text = "";
                txthoten.Text = "";
                txtmssv.Text = "";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }

                txtdiemtoan.Text = "";
                txtdiemvan.Text = "";
                txthoten.Text = "";
                txtmssv.Text = "";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }
    }
}
