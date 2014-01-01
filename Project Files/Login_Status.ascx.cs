using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login_Status : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string user_name = (string)HttpContext.Current.Session["user_type"];
        if (user_name ==null || user_name=="")
        {
            HttpContext.Current.Session["user_type"] = "";
            HttpContext.Current.Session["employee_id"] = "";
            ImageButton2.Visible = false;
            ImageButton1.Visible = true;
            
        }
        else
        {
            ImageButton1.Visible = false;
            ImageButton2.Visible = true;
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        HttpContext.Current.Session["user_type"] = "";
        HttpContext.Current.Session["employee_id"] = "";
        ImageButton2.Visible = false;
        ImageButton1.Visible = true;
        Response.Redirect("Default.aspx");
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        HttpContext.Current.Session["user_type"] = "";
        HttpContext.Current.Session["employee_id"] = "";
        ImageButton2.Visible = false;
        ImageButton1.Visible = true;
        Response.Redirect("Default.aspx");
    }
}