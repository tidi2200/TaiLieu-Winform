using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPTHDT
{
    class PTB2
    {
        protected int _a;
        protected int _b;
        protected int _c;

        public PTB2()
        {
            this._a = 0;
            this._b = 0;
            this._c = 0;
        }

        public PTB2(int a, int b, int c)
        {
            this._a = a;
            this._b = b;
            this._c = c;
        }

        public int a
        {
            get { return this._a; }
            set { this._a = value; }
        }
        public int b
        {
            get { return this._b; }
            set { this._b = value; }
        }
        public int c
        {
            get { return this._c; }
            set { this._c = value; }
        }

        public String GiaiPT2()
        {
            String kq = null;
            if( a == 0 )
            {
                PTB1 pt1 = new PTB1(this._a, this._b);
                kq = pt1.GiaiPT();
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    return kq = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {
                    return kq = "Nghiệm kép: " + (-(double)-b / (2 * a)).ToString();
                }
                else
                {
                    double canDelta = Math.Sqrt(delta);
                    double x1 = (-b + canDelta) / (2 * a);
                    double x2 = (-b - canDelta) / (2 * a);
                    kq = "x1 = " + x1 + "và x2 = " + x2;
                }
            }
            return kq;
                
        }
    }
}
