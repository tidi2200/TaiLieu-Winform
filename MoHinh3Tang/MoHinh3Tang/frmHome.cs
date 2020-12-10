using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BEL;
using BAL;

namespace MoHinh3Tang
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSinhVien(dataGridView1);
            HienThiDanhSachLop(cboLop);
            HienThiDanhSachLop(cboLop2);
        }

        private void HienThiDanhSachLop(ComboBox cbo)
        {
            BAL_DM_SINHVIEN xulysinhvien = new BAL_DM_SINHVIEN();
            cbo.DataSource = xulysinhvien.LayDSL();
            cbo.DisplayMember = "Tenlop";
        }

        public void HienThiDanhSachSinhVien(DataGridView dgv)
        {
            BAL_DM_SINHVIEN xulysinhvien = new BAL_DM_SINHVIEN();
            dgv.DataSource = xulysinhvien.LayDSSV();
            //dgv.DataSource = Read("tbSINHVIEN A, tbLOP B");
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            HienThiDanhSachTheoLop(dataGridView1);
        }

        private void HienThiDanhSachTheoLop(DataGridView dgv)
        {
            string tenlop = cboLop.Text;
            BAL_DM_SINHVIEN xulysinhvien = new BAL_DM_SINHVIEN();
            dgv.DataSource = xulysinhvien.LayDSSVTheoLop(tenlop);
        }

        private int dongthu = -1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dongthu = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[dongthu];
                txtMSSV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Nam")
                    radNam.Checked = true;
                if (row.Cells[2].Value.ToString() == "Nữ")
                    radNu.Checked = true;
                txtDiaChi.Text = row.Cells[4].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                cboLop2.Text = row.Cells[5].Value.ToString();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BAL_DM_SINHVIEN xulysinhvien = new BAL_DM_SINHVIEN();
            if (string.IsNullOrEmpty(txtMSSV.Text))
                MessageBox.Show("Chưa chọn sinh viên cần xóa", "Thông báo");
            else
            {
                string mssv = txtMSSV.Text;
                xulysinhvien.XoaSV(mssv);
                MessageBox.Show("Đã xóa sinh viên", "Thông báo");
                HienThiDanhSachSinhVien(dataGridView1);
                txtMSSV.Text = null;
                txtHoTen.Text = null;
                txtDiaChi.Text = null;
                radNam.Checked = false;
                radNu.Checked = false;
                dateTimePicker1.Text = null;
                cboLop2.Text = null;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BEL_DM_SINHVIEN sv = new BEL_DM_SINHVIEN();
            sv.Mssv = txtMSSV.Text;
            sv.Hoten = txtHoTen.Text;
            sv.Diachi = txtDiaChi.Text;
            BAL_DM_SINHVIEN xulysinhvien = new BAL_DM_SINHVIEN();
            sv.Malop = xulysinhvien.LayMaLop(cboLop2.Text);
            sv.Ngaysinh = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            if (radNam.Checked)
                sv.Gioitinh = "Nam";
            if (radNu.Checked)
                sv.Gioitinh = "Nữ";
            if (xulysinhvien.KiemTraTonTai(sv.Mssv))
                MessageBox.Show("Sinh viên đã có (trùng MSSV)", "Thêm thất bại");
            else if (String.IsNullOrEmpty(txtMSSV.Text))
            {
                MessageBox.Show("Cần nhập ít nhất MSSV để thêm SV!", "Thêm thất bại");
            }
            else
            {
                xulysinhvien.ThemSV(sv);
                dataGridView1.DataSource = null;
                MessageBox.Show("Thêm thành công!", "Thành công");
                HienThiDanhSachSinhVien(dataGridView1);
                txtMSSV.Text = null;
                txtHoTen.Text = null;
                txtDiaChi.Text = null;
                radNam.Checked = false;
                radNu.Checked = false;
                dateTimePicker1.Text = null;
                cboLop2.Text = null;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HienThiDanhSachLop(cboLop2);
            BEL_DM_SINHVIEN sv = new BEL_DM_SINHVIEN();
            BAL_DM_SINHVIEN xulysinhvien = new BAL_DM_SINHVIEN();
            sv.Mssv = txtMSSV.Text;
            sv.Hoten = txtHoTen.Text;
            sv.Diachi = txtDiaChi.Text;
            sv.Malop = xulysinhvien.LayMaLop(cboLop2.Text);
            sv.Ngaysinh = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            if (radNam.Checked)
                sv.Gioitinh = "Nam";
            if (radNu.Checked)
                sv.Gioitinh = "Nữ";
            if (String.IsNullOrEmpty(txtMSSV.Text))
                MessageBox.Show("Cần nhập ít nhất MSSV để cập nhật thông tin SV!", "Cập nhật thất bại");
            else
            {
                xulysinhvien.CapNhatSV(sv);
                dataGridView1.DataSource = null;
                MessageBox.Show("Cập nhật thành công", "Thành công");
                HienThiDanhSachSinhVien(dataGridView1);
            }
        }
    }
}
