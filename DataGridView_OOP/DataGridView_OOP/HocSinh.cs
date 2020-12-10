using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView_OOP
{
    class HocSinh
    {
        private string _hoten;
        private string _mssv;
        private float _diemtoan;
        private float _diemvan;

        public HocSinh()
        {
             this._hoten = null;
             this._mssv = null;
             this._diemtoan = 0;
             this._diemvan = 0;
        }

        public HocSinh(string hoten, string mssv, float diemtoan, float diemvan)
        {
            hoten = _hoten;
            mssv = _mssv;
            diemtoan = _diemtoan;
            diemvan = _diemvan;
        }

        public string Massv
        {
            get { return this._mssv; }
            set { this._mssv = value; }
        }

        public string HoTen
        {
            get { return this._hoten; }
            set { this._hoten = value; }
        }

        public float DiemToan
        {
            get { return this._diemtoan; }
            set { this._diemtoan = value; }
        }

        public float DiemVan
        {
            get { return this._diemvan; }
            set { this._diemvan = value; }
        }

        public float tinhDTB()
        {
            return (_diemtoan + _diemvan) / 2;
        }

        public string XepLoai()
        {
            string xeploai = null;
            float diemtb = tinhDTB();
            if (diemtb < 3)
                xeploai = "Kém";
            else
                if (diemtb < 5)
                    xeploai = "Yếu";
                else
                    if (diemtb < 7)
                        xeploai = "Trung bình";
                    else
                        if (diemtb < 8)
                            xeploai = "Khá";
                        else
                            xeploai = "Giỏi";
            return xeploai;
        }
    }
}
