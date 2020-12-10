using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLyPhepToan
{
    class XuLyPhepToan
    {
        private double SoA;
        private double SoB;

        public XuLyPhepToan()
        {
            this.SoA = 0;
            this.SoB = 0;
        }
        public XuLyPhepToan(double a, double b)
        {
            this.SoA = a;
            this.SoB = b;
        }

        public double XuLyPhepTinh(string pheptoan)
        {
            if (pheptoan.Equals("+"))
            {
                return this.SoA + this.SoB;
            }
            else if (pheptoan.Equals("-"))
            {
                return this.SoA - this.SoB;
            }
            else if (pheptoan.Equals("*"))
            {
                return this.SoA * this.SoB;
            }
            else
                return this.SoA / this.SoB;
        }
    }
}
