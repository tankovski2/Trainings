using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Caching;

namespace Pluralsight
{
    public static class DataSource
    {
        const string authorsKey = "authors";
        const string employeesKey = "employees";

        public static void FlushCache()
        {
            HttpContext.Current.Cache.Remove(authorsKey);
        }

        public static DataTable GetEmployees()
        {
            DataTable dt = null;
            if (HttpContext.Current.Cache[employeesKey] == null)
            {
                string fname = HttpContext.Current.Server.MapPath("~/app_data/employees.xml");
                DataSet ds = new DataSet();
                ds.ReadXml(fname);
                dt = ds.Tables[0];
                CacheDependency cd = new CacheDependency(fname);
                HttpContext.Current.Cache.Insert(employeesKey, dt, cd);
            }
            else
                dt = HttpContext.Current.Cache[employeesKey] as DataTable;

            return dt;
        }

        public static DataTable GetAuthors()
        {
            DataTable dt = null;

            if (HttpContext.Current.Cache[authorsKey] == null)
            {
                string dsn = ConfigurationManager.ConnectionStrings["pubsConnectionString1"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(dsn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT au_id, au_fname, au_lname FROM dbo.Authors", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    SqlCacheDependency dep = new SqlCacheDependency(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    //HttpContext.Current.Cache["authors"] = dt;
                    HttpContext.Current.Cache.Insert(authorsKey, dt, dep, DateTime.Now.AddHours(1),
                                    System.Web.Caching.Cache.NoSlidingExpiration);
                }
            }
            else
                dt = HttpContext.Current.Cache[authorsKey] as DataTable;

            return dt;
        }
    }

}