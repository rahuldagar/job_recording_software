using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;


namespace Declared_Classes{
    /// <summary>
    /// Summary description for Login
    /// </summary>
    public class Login
    {
        public Login()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public string check_user(string username, string password)
        {
            /*SqlDataReader rdr = null;
            SqlConnection conn = new SqlConnection("Data Source=RAHUL-PC\\INTERNSHIP2005;Initial Catalog=Job_Recording;Integrated Security=SSPI;Pooling=False");
            conn.Open();
            string sqlquery = "select * from Login_Details where User_Name=" + "'" + username + "'" + " and Password=" + "'" + password + "'";
            SqlCommand comm = new SqlCommand(sqlquery, conn);
            rdr = comm.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                HttpContext.Current.Session["user_type"] = (string)rdr[2];
                string str =(string) HttpContext.Current.Session["user_type"];
                str = str.TrimEnd(' ');
                HttpContext.Current.Session["user_type"] = str;
                HttpContext.Current.Session["employee_id"] = username;
                return (string)rdr[0];
            }
            else
            {
                HttpContext.Current.Session["user_type"] = "Manager";
                HttpContext.Current.Session["employee_id"] = "Rahul";
                return "Rahul";
            }*/
            HttpContext.Current.Session["user_type"] = "MGR";
            HttpContext.Current.Session["employee_id"] = "Rahul";
            return "Rahul";
        }
        
        
    }
}