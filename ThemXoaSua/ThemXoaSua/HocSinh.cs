using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemXoaSua
{
    class HocSinh
    {
        private string mssv;
        private string hoten;
        private string diachi;
        private string ngaysinh;
        private string lop;

        public HocSinh()
        {
            mssv = null;
            hoten = null;
            diachi = null;
            ngaysinh = null;
            lop = null;
        }

        public HocSinh(string masv, string hovaten, string dc, string bd, string lophs)
        {
            mssv = masv;
            hoten = hovaten;
            diachi = dc;
            ngaysinh = bd;
            lop = lophs;
        }

        public string Mssv
        {
            get { return this.mssv; }
            set { this.mssv = value; }
        }
        public string Hoten
        {
            get { return this.hoten; }
            set { this.hoten = value; }
        }

        public string Diachi
        {
            get { return this.diachi; }
            set { this.diachi = value; }
        }

        public string Ngaysinh
        {
            get { return this.ngaysinh; }
            set { this.ngaysinh = value; }
        }

        public string Lop
        {
            get { return this.lop; }
            set { this.lop = value; }
        }
    }
}
