using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_DM_SINHVIEN
    {
         string _mssv;
        string _hoten;
        string _gioitinh;
        string _ngaysinh;
        string _diachi;
        string _lop;
        string _malop;

        public string Malop
        {
            get { return _malop; }
            set { _malop = value; }
        }

        public string Gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }

        public BEL_DM_SINHVIEN()
        {
            this._mssv = null;
            this._hoten = null;
            this._gioitinh = null;
            this._ngaysinh = null;
            this._diachi = null;
            this._lop = null;
        }

        public BEL_DM_SINHVIEN(string mssv, string hoten, string gioitinh, string ngaysinh, string diachi, string lop)
        {
            this._mssv = mssv;
            this._hoten = hoten;
            this._gioitinh = gioitinh;
            this._ngaysinh = ngaysinh;
            this._diachi =  diachi;
            this._lop = lop;
        }

        public string Mssv
        {
            get { return this._mssv; }
            set { this._mssv = value; }
        }
        public string Hoten
        {
            get { return this._hoten; }
            set { this._hoten = value; }
        }

        public string Diachi
        {
            get { return this._diachi; }
            set { this._diachi = value; }
        }

        public string Ngaysinh
        {
            get { return this._ngaysinh; }
            set { this._ngaysinh = value; }
        }

        public string Lop
        {
            get { return this._lop; }
            set { this._lop = value; }
        }
    }
}
