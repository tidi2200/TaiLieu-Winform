using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhChuNhat
{
    class HinhChuNhat
    {
        private double ChieuDai;
        private double ChieuRong;

        public HinhChuNhat()
        {
            this.ChieuDai = 0;
            this.ChieuRong = 0;
        }
        public HinhChuNhat (double a, double b)
        {
            this.ChieuDai = a;
            this.ChieuRong = b;
        }
        public double chieudai
        {
            get { return this.ChieuDai; }
            set { this.ChieuDai = value; }
        }
        public double chieurong
        {
            get { return this.ChieuRong; }
            set { this.ChieuRong = value; }
        }
        public double TinhChuVi()
        {
            return (this.ChieuDai+this.ChieuRong)*2;
        }
        public double TinhDienTich()
        {
            return this.ChieuRong * this.ChieuDai;
        }
    }
}
