using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView_OOP
{
    class DanhSachHocSinh
    {
        private List<HocSinh> _ds;
        public DanhSachHocSinh()
        {
            _ds=new List<HocSinh>();
        }
        public DanhSachHocSinh(List<HocSinh> ds)
        {
            this._ds = ds;
        }
        public List<HocSinh> danhsachHS
        {
            get { return this._ds; }
            set { this._ds = value; }
        }

        public bool ThemHocSinh(HocSinh hs)
        {
            bool ThemDuoc = true;
            if (KiemTraTrungMa(hs.Massv) == false)
                this._ds.Add(hs);
            else
                ThemDuoc = false;
            return ThemDuoc;
        }

        public void SuaHocSinh(HocSinh hs, int ViTri)
        {
            this._ds[ViTri] = hs;
        }

        //public void XoaHocSinh (HocSinh hs)
        //{
        //    this._ds.Remove(hs);
        //}

        public void XoaHocSinh(int ViTri)
        {
            this._ds.RemoveAt(ViTri);
        }

        private bool KiemTraTrungMa(string ma)
        {
            bool ketqua = false; 
            foreach(HocSinh hocsinh in this._ds)
            {
                if(hocsinh.Massv.Equals(ma))
                {
                    ketqua = true;
                    break;
                }
            }
            return ketqua;
        }
    }
}
