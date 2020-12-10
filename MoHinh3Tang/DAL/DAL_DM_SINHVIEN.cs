using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BEL;
namespace DAL
{
    public class DAL_DM_SINHVIEN:General
    {
        public DataTable Read(string table)
        {
            DataTable dt = new DataTable(); //Hien thi thong tin sinh vien
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("Select MaSV MãSV, Hoten HọTên, Gioitinh GiớiTính, Ngaysinh NgàySinh, Diachi ĐịaChỉ, Tenlop TênLớp from " + table + " where A.MaLop = B.MaLop and Trangthai=1", con); //select * from tbSINHVIEN A, tbLOP B where A.MaLop=B.MaLop 

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

        public DataTable ReadDSL(string table) //Hien thi danh sach lop len combobox
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("Select Tenlop from " + table, con);

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

        public DataTable Read2(string tenlop)  //Hien danh sach theo lop
        {
            DataTable dt = new DataTable();
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("Select MaSV MãSV, Hoten HọTên, Gioitinh GiớiTính, Ngaysinh NgàySinh, Diachi ĐịaChỉ, Tenlop TênLớp from tbSINHVIEN A, tbLOP B where A.MaLop = B.MaLop and Tenlop = N'" + tenlop + "'", con);
            //SqlCommand cmd = new SqlCommand("Select MaSV MãSV, Hoten HọTên, Gioitinh GiớiTính, Ngaysinh NgàySinh, Diachi ĐịaChỉ, Tenlop TênLớp from tbSINHVIEN A, tbLOP B where A.MaLop = B.MaLop",con);

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

        public bool Xoa(string mssv)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "UPDATE tbSINHVIEN set Trangthai = 0 where MaSV= '" + mssv + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                if (cmd.ExecuteNonQuery() > 0)
                    kq = true;
            }
            catch (Exception err)
            {
                throw;
            }
            return kq;
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

        public bool Them(BEL_DM_SINHVIEN sv)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "insert into tbSINHVIEN values ('" + sv.Mssv + "',N'" + sv.Hoten + "',N'" + sv.Gioitinh + "','" + sv.Ngaysinh + "',N'" + sv.Diachi + "','" + sv.Malop + "', 1)";
                SqlCommand cmd = new SqlCommand(sql, con);
                if (cmd.ExecuteNonQuery() > 0)
                    kq = true;
            }
            catch(Exception err)
            {
                throw;
            }
            return kq;
        }

        public bool CapNhat(BEL_DM_SINHVIEN sv)
        {
            bool kq = false;
            try
            {
                if (ConnectionState.Closed == con.State)
                    con.Open();
                string sql = "UPDATE tbSINHVIEN SET MaSV='" + sv.Mssv + "',Hoten=N'" + sv.Hoten + "',Gioitinh=N'" + sv.Gioitinh + "',Ngaysinh='" + sv.Ngaysinh + "',Diachi='" + sv.Diachi + "',MaLop='" + sv.Malop + "' where MaSV='" + sv.Mssv + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                if (cmd.ExecuteNonQuery() > 0)
                    kq = true;
            }
            catch (Exception err)
            {
                throw;
            }
            return kq;
        }
    }
}
