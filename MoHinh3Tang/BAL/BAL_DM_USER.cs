using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class BAL_DM_USER
    {
        public bool login(string username, string password)
        {
            try
            {
                DAL_DM_USER objdal = new DAL_DM_USER();
                return objdal.login(username, password);
            }
            catch(Exception err)
            {
                throw;
            }
        }
    }
}
