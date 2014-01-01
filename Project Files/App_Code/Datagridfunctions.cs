using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Web.SessionState;


namespace Datagridfunctionsclass
{
    public class Datagridfunctions
    {
        public Datagridfunctions()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private SqlConnection getconnection()
        {

            return new SqlConnection("Data Source=RAHUL-PC\\INTERNSHIP2005;Initial Catalog=Job_Recording;Integrated Security=SSPI;Pooling=False");
        }
        public SqlDataReader getactivitydata()
        {
            SqlConnection conn = getconnection();
            conn.Open();
            SqlCommand comm = new SqlCommand("getactivity", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            return comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
           
        }


        public SqlDataReader getactivitydataopen()
        {
            SqlDataReader rdr = null;
            SqlConnection conn = getconnection();
            conn.Open();
            SqlCommand comm = new SqlCommand("getactivityopen", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter employeecode = new SqlParameter("@Employee_Code", System.Data.SqlDbType.VarChar,50);
            employeecode.Value = HttpContext.Current.Session["employee_id"];
            comm.Parameters.Add(employeecode);
            return comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

        }


        public void opengangbooking(string gangid,string code)
        {

            

            string[] ga = gangid.Split('+');
            for (int i = 1; i < ga.Length; i++)
            {

                SqlConnection conn = getconnection();
                conn.Open();
                SqlCommand comm = new SqlCommand("openbookinggang", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                                                
                SqlParameter activitycode = new SqlParameter("@Activity_Code", System.Data.SqlDbType.VarChar, 50);
                activitycode.Value = code;
                comm.Parameters.Add(activitycode);


                SqlParameter employeecode = new SqlParameter("@Employee_Code", System.Data.SqlDbType.VarChar, 50);

                employeecode.Value = ga[i];
                comm.Parameters.Add(employeecode);

                comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                
            }
                     
            entergangactivity(gangid, code);
            changestatus(code, 'O');
        }



        public void entergangactivity(string gangid, string code)
        {
            
            //Guid gangguid = new Guid();
            Random rd = new Random();
            //rd.Next(1000);
            string[] gangidsplit = gangid.Split('+');
            for (int i = 1; i < gangidsplit.Length; i++)
            {
                SqlConnection conn = getconnection();
                conn.Open();
                SqlCommand comm = new SqlCommand("newgang", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter gangid2 = new SqlParameter("@GangId", System.Data.SqlDbType.VarChar, 50);
                gangid2.Value = 'G' + gangid + Convert.ToString(rd.Next(1000));
                comm.Parameters.Add(gangid2);


                SqlParameter employeecode = new SqlParameter("@Employee_Code", System.Data.SqlDbType.VarChar, 50);                
                employeecode.Value = gangidsplit[i];
                comm.Parameters.Add(employeecode);


                SqlParameter activitycode = new SqlParameter("@Activity_Code", System.Data.SqlDbType.VarChar, 50);
                activitycode.Value = code;
                comm.Parameters.Add(activitycode);

                comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }

            
        }



        public void closeboking(string code)
        {

            SqlConnection conn = getconnection();
            conn.Open();
            SqlCommand comm = new SqlCommand("closebooking", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            
            SqlParameter stoptime = new SqlParameter("@Stop_TIme", System.Data.SqlDbType.DateTime);
            stoptime.Value = DateTime.Now;
            comm.Parameters.Add(stoptime);
            SqlParameter activitycode = new SqlParameter("@Activity_Code", System.Data.SqlDbType.VarChar, 50);
            activitycode.Value = code;
            comm.Parameters.Add(activitycode);


            SqlParameter employeecode = new SqlParameter("@Employee_Code", System.Data.SqlDbType.VarChar, 50);
            employeecode.Value = HttpContext.Current.Session["employee_id"];
            //employeecode.Value = 'e';
            comm.Parameters.Add(employeecode);
            
            comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

        }

        public void changestatus(string code, char statusval)
        {
            SqlConnection conn = getconnection();
            conn.Open();

            SqlCommand comm = new SqlCommand("changestatus", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter activitycode = new SqlParameter("@Activity_Code", System.Data.SqlDbType.VarChar, 50);
            activitycode.Value = code;
            comm.Parameters.Add(activitycode);

            SqlParameter status = new SqlParameter("@Status", System.Data.SqlDbType.VarChar,50);
            status.Value = statusval;
            comm.Parameters.Add(status);

            comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }



        public void openbookingtl(string emp,string code)
        {
            SqlConnection conn = getconnection();
            conn.Open();

            SqlCommand comm = new SqlCommand("openbooking", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter activitycode = new SqlParameter("@Activity_Code", System.Data.SqlDbType.VarChar, 50);
            activitycode.Value = code;
            comm.Parameters.Add(activitycode);

            SqlParameter employeecode = new SqlParameter("@Employee_Code", System.Data.SqlDbType.VarChar, 50);
            employeecode.Value = emp;
            comm.Parameters.Add(employeecode);


            comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            changestatus(code, 'O');
        }



        public SqlDataReader startbookedactivity(string code)
        {

            SqlConnection conn = getconnection();
            conn.Open();

            SqlCommand comm = new SqlCommand("startbookedactivity", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter activitycode = new SqlParameter("@Activity_Code", System.Data.SqlDbType.VarChar, 50);
            activitycode.Value = code;
            comm.Parameters.Add(activitycode);

            SqlParameter employeecode = new SqlParameter("@Employee_Code", System.Data.SqlDbType.VarChar, 50);
            employeecode.Value = HttpContext.Current.Session["employee_id"];
            //employeecode.Value = 'e';
            comm.Parameters.Add(employeecode);

            SqlParameter stoptime = new SqlParameter("@Start_TIme", System.Data.SqlDbType.DateTime);
            stoptime.Value = DateTime.Now;
            comm.Parameters.Add(stoptime);

            return comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

        }


        public void openbooking(string code)
        {
            SqlConnection conn = getconnection();
            conn.Open();
            
            SqlCommand comm = new SqlCommand("openbooking", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            
            SqlParameter activitycode = new SqlParameter("@Activity_Code", System.Data.SqlDbType.VarChar, 50);
            activitycode.Value = code;
            comm.Parameters.Add(activitycode);

            SqlParameter employeecode = new SqlParameter("@Employee_Code", System.Data.SqlDbType.VarChar, 50);
            employeecode.Value = HttpContext.Current.Session["employee_id"];
            //employeecode.Value = 'e';
            comm.Parameters.Add(employeecode);

         //   SqlParameter stoptime = new SqlParameter("@Start_TIme", System.Data.SqlDbType.DateTime);
         //   stoptime.Value = DateTime.Now;
         //   comm.Parameters.Add(stoptime);
            
            comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }


        public Boolean checkemployid(string empcode)
        {
            SqlDataReader rdr = null;
            SqlConnection conn = getconnection();
            conn.Open();
            SqlCommand comm = new SqlCommand("checkemployid", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter employeecode = new SqlParameter("@Employee_Code", System.Data.SqlDbType.VarChar, 50);
            employeecode.Value = empcode;
            comm.Parameters.Add(employeecode);
            rdr = comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            if (rdr.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        public SqlDataReader searchpreengineer()
        {
            SqlConnection conn = getconnection();
            conn.Open();
            SqlCommand comm = new SqlCommand("searchpreengineer", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter employeecode = new SqlParameter("@Employee_Code", System.Data.SqlDbType.VarChar, 50);
            employeecode.Value = HttpContext.Current.Session["employee_id"];
            comm.Parameters.Add(employeecode);
            return comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }



        public SqlDataReader searchpreengineernotstarted()
        {
            SqlConnection conn = getconnection();
            conn.Open();
            SqlCommand comm = new SqlCommand("searchpreengineernotstarted", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter employeecode = new SqlParameter("@Employee_Code", System.Data.SqlDbType.VarChar, 50);
            employeecode.Value = HttpContext.Current.Session["employee_id"];
            comm.Parameters.Add(employeecode);
            return comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }

        public SqlDataReader getactivityown()
        {
            SqlConnection conn = getconnection();
            conn.Open();
            SqlCommand comm = new SqlCommand("getactivityemp", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter employeecode = new SqlParameter("@Employee_Code", System.Data.SqlDbType.VarChar, 50);
            employeecode.Value = HttpContext.Current.Session["employee_id"];
            //employeecode.Value = 'b';
            comm.Parameters.Add(employeecode);
            return comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }


        public SqlDataReader getactivityemp(string code)
        {
            SqlConnection conn = getconnection();
            conn.Open();
            SqlCommand comm = new SqlCommand("getactivityemp", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter employeecode = new SqlParameter("@Employee_Code", System.Data.SqlDbType.VarChar, 50);
            employeecode.Value = code;
            comm.Parameters.Add(employeecode);
            return comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }



        public SqlDataReader searchpre()
        {
            SqlConnection conn = getconnection();
            conn.Open();
            SqlCommand comm = new SqlCommand("searchpre", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            return comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }

        public SqlDataReader getactivitybooktl()
        {
            SqlConnection conn = getconnection();
            conn.Open();
            SqlCommand comm = new SqlCommand("getactivitybooktl", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            return comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }

        public SqlDataReader getemployeecode()
        {
            SqlConnection conn = getconnection();
            conn.Open();
            SqlCommand comm = new SqlCommand("getemployeecode", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            return comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }

        public SqlDataReader getbookedactivities()
        {
            SqlConnection conn = getconnection();
            conn.Open();
            SqlCommand comm = new SqlCommand("getbookedactivities", conn);
            comm.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter employeecode = new SqlParameter("@Employee_Code", System.Data.SqlDbType.VarChar, 50);
            employeecode.Value =(string) HttpContext.Current.Session["employee_id"];
            //employeecode.Value = Convert.ToString(22);
            comm.Parameters.Add(employeecode);

            return comm.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        }



    }
}