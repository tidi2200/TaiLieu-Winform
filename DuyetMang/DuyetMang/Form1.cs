using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DuyetMang
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

        private ArrayList arrTrai = new ArrayList();
        private ArrayList arrPhai = new ArrayList();
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtNhapChuoi.Text == "")
            {
                MessageBox.Show("Chưa nhập chuỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string ChuoiNhap = txtNhapChuoi.Text;
                if (KiemTraTrung(arrTrai, ChuoiNhap))
                {
                    MessageBox.Show("Đã có chuỗi này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    arrTrai.Add(ChuoiNhap);
                }
                arrTrai.Sort();
                HienThienLenListBox(lbTrai, arrTrai);
                txtNhapChuoi.Text = "";
                txtNhapChuoi.Focus();
            }
        }

        private bool KiemTraTrung(ArrayList arr, string str)
        {
            bool KetQua = false;
            for (int i = 0; i < arrTrai.Count; i++)
            {
                if (arr[i].Equals(str))
                {
                    KetQua = true;
                    break;
                }
            }
            return KetQua;
        }

        private void HienThienLenListBox(ListBox lb, ArrayList arr)
        {
            lb.Items.Clear();
            for (int i = 0; i < arr.Count; i++)
            {
                lb.Items.Add(arr[i]);
            }
        }

        private void btnQuaPhai_Click(object sender, EventArgs e)
        {
            if (lbTrai.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn chuỗi để chuyển.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string PhanTuBentrai = lbTrai.SelectedItem.ToString();
                lbPhai.Items.Add(PhanTuBentrai);
                lbTrai.Items.RemoveAt(lbTrai.SelectedIndex);
            }
        }

        private void btnQuaPhaiHet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbTrai.Items.Count; i++)
            {
                lbPhai.Items.Add(lbTrai.Items[i]);
            }
            lbTrai.Items.Clear();
        }

        private void btnQuaTrai_Click(object sender, EventArgs e)
        {
            if (lbPhai.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn chuỗi để chuyển.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string PhanTuBentrai = lbPhai.SelectedItem.ToString();
                lbTrai.Items.Add(PhanTuBentrai);
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

        private void btnXoaTrai_Click(object sender, EventArgs e)
        {
            lbTrai.Items.RemoveAt(lbTrai.SelectedIndex);
        }

        private void btnXoaPhai_Click(object sender, EventArgs e)
        {
            lbPhai.Items.RemoveAt(lbPhai.SelectedIndex);
        }
    }
}
