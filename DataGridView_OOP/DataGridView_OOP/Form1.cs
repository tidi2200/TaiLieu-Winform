using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DanhSachHocSinh danhsach = new DanhSachHocSinh();
        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinh hocsinh = new HocSinh();
            hocsinh.Massv = txtmssv.Text;
            hocsinh.HoTen = txthoten.Text;
            hocsinh.DiemVan = float.Parse(txtdiemvan.Text);
            hocsinh.DiemToan = float.Parse(txtdiemtoan.Text);

            bool ketquathem = danhsach.ThemHocSinh(hocsinh);
            if(ketquathem == true)
            {
                HienThiDanhSach(dataGridView1,danhsach);

                txtdiemtoan.Text = "";
                txtdiemvan.Text = "";
                txthoten.Text = "";
                txtmssv.Text = "";
            }
            else
            {
                MessageBox.Show("SV này đã có!");
            }
        }

        private void HienThiDanhSach(DataGridView dgv, DanhSachHocSinh ds)
        {
            dgv.Rows.Clear();
            foreach (HocSinh hs in ds.danhsachHS)
            {
                dgv.Rows.Add(hs.Massv, hs.HoTen, hs.DiemToan, hs.DiemVan,
                    hs.tinhDTB(),hs.XepLoai());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            danhsach.XoaHocSinh(dongthu);
            HienThiDanhSach(dataGridView1, danhsach);

            txtdiemtoan.Text = "";
            txtdiemvan.Text = "";
            txthoten.Text = "";
            txtmssv.Text = "";
            txtdtb.Text = "";
            txtxeploai.Text = "";
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
                txtdtb.Text = row.Cells["dtb"].Value.ToString();
                txtxeploai.Text = row.Cells["xeploai"].Value.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HocSinh hocsinh = new HocSinh(txtmssv.Text, txthoten.Text, float.Parse(txtdiemtoan.Text), float.Parse(txtdiemvan.Text));
            danhsach.SuaHocSinh(hocsinh, dongthu);
            HienThiDanhSach(dataGridView1, danhsach);
        }
    }
}
