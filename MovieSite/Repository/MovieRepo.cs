using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MovieSite.Repository
{
    public class MovieRepo
    {
        private static string str = ConfigurationManager.ConnectionStrings["MovieConnection"].ConnectionString;
        public static DataTable GetMovies()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(str))
            {
                con.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM tblFilm", con);
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                con.Close();
                da.Dispose();
            }
            return dt;
        }
    }
}