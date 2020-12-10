using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class General
    {
        public SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=QLSV;Integrated Security=True");
        public DataTable dt = new DataTable();
        public SqlConnection GetCon()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }
    }
}
