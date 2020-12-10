using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace KetNoiCSDL
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhSachSinhVien(dataGridView1);
            HienThiDanhSachLop(cboLop);
        }

        public void HienThiDanhSachSinhVien(DataGridView dgv)
        {
            //BAL_DM_SINHVIEN xulysinhvien = new BAL_DM_SINHVIEN();
            //dgv.DataSource = xulysinhvien.LayDanhSachSinhVien();
            dgv.DataSource = Read("tbSINHVIEN A, tbLOP B");
        }

        public void HienThiDanhSachLop(ComboBox cbo)
        {
            cbo.DataSource = ReadDSL("tbLOP");
            cbo.DisplayMember = "Tenlop";
            //cbo.ValueMember = "MaLop";
        }

        public void HienThiDanhSachTheoLop(DataGridView dgv)
        {   
            dgv.DataSource = Read2(cboLop.Text);
        }

        public SqlConnection con = new SqlConnection(@"Data Source=TRUONGDAT;Initial Catalog=QLSV;Integrated Security=True");
        public SqlConnection GetCon()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }
        public DataTable Read(string table)
        {
            DataTable dt = new DataTable(); //Hien thi thong tin sinh vien
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("Select MaSV MãSV, Hoten HọTên, Gioitinh GiớiTính, Ngaysinh NgàySinh, Diachi ĐịaChỉ, Tenlop TênLớp from " + table + " where A.MaLop = B.MaLop", con); //select * from tbSINHVIEN A, tbLOP B where A.MaLop=B.MaLop 

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();

                dt.Load(rd);

                return dt;
            }

            catch
            {
                throw;
            }
        }

        public DataTable dt1 = new DataTable(); //Hien thi thong tin lop hoc
        public DataTable ReadDSL(string table)
        {
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("Select Tenlop from " + table, con); 

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();

                dt1.Load(rd);

                return dt1; 
            }

            catch
            {
                throw;
            }
        }

        public DataTable dt2 = new DataTable(); //Hien thi danh sach theo lop
        public DataTable Read2(string tenlop)
        {
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("Select MaSV MãSV, Hoten HọTên, Gioitinh GiớiTính, Ngaysinh NgàySinh, Diachi ĐịaChỉ, Tenlop TênLớp from tbSINHVIEN A, tbLOP B where A.MaLop = B.MaLop and Tenlop = N'" + tenlop + "'", con);
            //SqlCommand cmd = new SqlCommand("Select MaSV MãSV, Hoten HọTên, Gioitinh GiớiTính, Ngaysinh NgàySinh, Diachi ĐịaChỉ, Tenlop TênLớp from tbSINHVIEN A, tbLOP B where A.MaLop = B.MaLop",con);

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();

                dt2.Load(rd);

                return dt2;
            }

            catch (Exception err)
            {
                throw;
            }
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dt2.Clear();
            HienThiDanhSachTheoLop(dataGridView1);
        }

        public string LayMaLop(string tenlop)
        {
            DataTable dt = new DataTable();
            string malop = null;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select MaLop from tbLOP where Tenlop=N'" + tenlop + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                    malop = dt.Rows[0]["malop"].ToString();
                return malop;
            }
            catch (Exception err)
            {
                throw;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Mssv = txtMSSV.Text;
            sv.Hoten = txtHoTen.Text;
            sv.Diachi = txtDiaChi.Text;
            sv.Malop = LayMaLop(cboLop2.Text);
            sv.Ngaysinh = dateTimePicker1.Text;
            if (radNam.Checked)
                sv.Gioitinh = "Nam";
            if (radNu.Checked)
                sv.Gioitinh = "Nữ";
            if (KiemTraTonTai(sv.Mssv))
                MessageBox.Show("Sinh viên đã có (trùng MSSV)", "Thêm thất bại");
            else
                ThemSinhVien(dataGridView1);
        }

        public bool KiemTraTonTai(string mssv)
        {
            DataTable dt = new DataTable();
            bool kq = false;
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbSINHVIEN where MaSV='" + mssv + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                    kq = true;
            }
            catch (Exception err)
            {
                throw;
            }
            return kq;
        }
        public void ThemSinhVien(DataGridView dgv)
        {
            dgv.DataSource = Them();
        }
        public DataTable Them()
        {
            DataTable dt = new DataTable(); //Them sinh vien
            if (ConnectionState.Closed == con.State)
                con.Open();
            string sql = "insert into tbSINHVIEN values ('"+txtMSSV+"',N'"+txtHoTen+"',NULL,N'"+dateTimePicker1.Text+"',N'"+txtDiaChi.Text+"','"+LayMaLop(cboLop2.Text)+"')";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                return dt;
            }
            catch (Exception err)
            {
                throw;
            }
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
                dateTimePicker1.Text = row.Cells[3].Value.ToString();
                cboLop2.Text = row.Cells[5].Value.ToString();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMSSV.Text))
                MessageBox.Show("Chưa chọn sinh viên cần xóa", "Thông báo");
            else
            {
                XoaSinhVien(dataGridView1);
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

        public void XoaSinhVien(DataGridView dgv)
        {
            dgv.DataSource = Xoa(txtMSSV.Text);
        }

        
        public DataTable Xoa(string mssv)
        {
            DataTable dt3 = new DataTable(); //Xoa sinh vien duoc chon
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("delete from tbSINHVIEN where MaSV=N'" + txtMSSV.Text + "'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt3.Load(rd);
                return dt3;
            }
            catch (Exception err)
            {
                throw;
            }
        }
    }
}
