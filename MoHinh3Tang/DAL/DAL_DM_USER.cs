using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
namespace DAL
{
    public class DAL_DM_USER:General
    {
        public bool login(string username, string password)
        {
            bool kq = false;
            DataTable dt = new DataTable();
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password); //dua pw vao 1 mang kieu byte
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp); // luu mat khau da ma hoa 

            string hasPass = "";
            foreach (byte item in  hasData)
            {
                hasPass += item;
            } //mã hóa mật khẩu
            
            
            if (ConnectionState.Closed == con.State)
                con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbACCOUNT where username='" + username + "' AND password='"+hasPass+"'", con);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                if (dt.Rows.Count > 0)
                    kq = true;
            }
            catch (Exception err)
            {
                throw;
            }
            return kq;
        }
    }
}
