using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KetNoiCSDL
{
    class General_data
    {
        public SqlConnection con = new SqlConnection(@"Data Source=TRUONGDAT;Initial Catalog=QLSV;Integrated Security=True");
        public DataTable dt = new DataTable();
        public SqlConnection GetCon()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }
        public DataTable Read(string table)
        {
            if (ConnectionState.Closed == con.State)
                con.Open();

            SqlCommand cmd = new SqlCommand("Select * from " + table, con);

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();

                dt.Load(rd);

                return dt;
            }

            catch
            {
                throw;
            }
        }
    }
}
