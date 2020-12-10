using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPTHDT
{
    class PTB1:PTB2
    {
        public PTB1()
        {
            this._a = 0;
            this._b = 0;
        }
        public PTB1(int a, int b)
        {
            this._a = a;
            this._b = b;
        }
        public int a
        {
            get { return this._a; }
            set { this._b = value; }
        }

        public int b
        {
            get { return this._b; }
            set { this._b = value; }
        }
        
        public String GiaiPT ()
        {
            String kq = null;
            if (a == 0)
            {
                if (b == 0)
                    return (kq = "Vô số nghiệm ");
                else
                    return (kq = "Vô nghiệm");
            }
            else
            {
                return kq = "Có 1 nghiệm: "+ (-(double)this.b / this.a).ToString(); 
            }
        }
    }
}
