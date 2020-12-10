using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_DM_USER
    {
        string _username;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        string _dislayname;

        public string Dislayname
        {
            get { return _dislayname; }
            set { _dislayname = value; }
        }
        int _type;

        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public BEL_DM_USER()
        {
            _username = null;
            _password = null;
            _dislayname = null;
            _type = 0;
        }

        public BEL_DM_USER(string us, string pw, string dl, int type)
        {
            _username = us;
            _password = pw;
            _dislayname = dl;
            _type = type;
        }
    }
}
