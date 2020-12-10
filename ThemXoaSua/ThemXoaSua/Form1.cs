using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThemXoaSua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<HocSinh> dsHocSinh = new List<HocSinh>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            string mahs = txtmssv.Text;
            string hoten = txthoten.Text;
            string diachi = txtdiachi.Text;
            string ngaysinh = dtpngaysinh.Value.ToString();
            string lop = cbolop.Text;

            HocSinh hocsinh = new HocSinh(mahs, hoten, diachi, ngaysinh, lop);
            if (txtmssv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin!");
            }
            else
            {
                dsHocSinh.Add(hocsinh);
                HienThiDanhSachHocSinh(lvDanhSach, dsHocSinh);
            }
        }

        private bool KiemTraTrung(HocSinh hs, List<HocSinh> ds)
        {
            bool ketqua = false;
            foreach (HocSinh hocsinh in ds)
            {
                
            }
            return ketqua;
        }
        private void HienThiDanhSachHocSinh(ListView lv, List<HocSinh> ds)
        {
            lv.Items.Clear();
            foreach (HocSinh hs in ds)
            {
                ListViewItem lvi = new ListViewItem(hs.Mssv);
                lvi.SubItems.Add(hs.Hoten);
                lvi.SubItems.Add(hs.Diachi);
                lvi.SubItems.Add(hs.Ngaysinh);
                lvi.SubItems.Add(hs.Lop);

                lv.Items.Add(lvi);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
               lvDanhSach.SelectedItems.Clear();
        }

        private void lvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            HocSinh hs = new HocSinh();
            if(lvDanhSach.SelectedItems.Count > 0) //Kiem tra co chon dong` trong listview chua
            {
                lvi = lvDanhSach.SelectedItems[0]; //Lay dong` gan vao` doi tuong lvi
                hs.Mssv = lvi.SubItems[0].Text;
                hs.Hoten = lvi.SubItems[1].Text;
                hs.Diachi = lvi.SubItems[2].Text;
                hs.Ngaysinh = lvi.SubItems[3].Text;
                hs.Lop = lvi.SubItems[4].Text; //Lay gia tri trong cot de gan vao doi tuong

                txtmssv.Text = hs.Mssv;
                txthoten.Text = hs.Hoten;
                txtdiachi.Text = hs.Diachi;
                dtpngaysinh.Value = DateTime.Parse(hs.Ngaysinh);
                cbolop.Text = hs.Lop; //Gan lai len textbox
            }
        }
    }
}
