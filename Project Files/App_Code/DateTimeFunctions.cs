using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Text;


/// <summary>
/// Summary description for DateTimeFunctions
/// </summary>
/// 
namespace DataTimeNamespace
{

    public class DateTimeFunctions
    {
        public DateTimeFunctions()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public int getmin(DateTime date)
        {
            //string st2 = date.ToLongTimeString();
            //string[] st3 = st2.Split(':');
            //string[] st4 = st3[2].Split(' ');
            //return Convert.ToInt32(st3[1]);

            return date.Minute;
        }

        public int gethour(DateTime date)
        {
            //string st2 = date.ToLongTimeString();
            //string[] st3 = st2.Split(':');
            //string[] st4 = st3[2].Split(' ');
            //int i = Convert.ToInt32(st3[0]);
            //if (st4[1] == "PM")
            //{
            //    i += 12;
            //}
            //return i;

            return date.Hour;
        }


        public int getsec(DateTime date)
        {
            //string st2 = date.ToLongTimeString();
            //string[] st3 = st2.Split(':');
            //string[] st4 = st3[2].Split(' ');
            //return Convert.ToInt32(st4[0]);
            return date.Second;
        }

        
        


    }
}