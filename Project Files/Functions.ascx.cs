using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Functions : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Engineer_Panel.Visible = false;
        Team_Lead_Panel.Visible = false;
        Manager_Panel.Visible = false;

        if (Session["user_type"] != null)
        {
            string useridentity;

            useridentity = (string)Session["user_type"];

            if (useridentity == "MGR")
            {
                Manager_Panel.Visible = true;
            }
            if (useridentity == "TL")
            {
                Team_Lead_Panel.Visible = true;
            }
            if (useridentity == "ENG")
            {
                Engineer_Panel.Visible = true;
            }

        }
        else
        {
            Response.Redirect("Default.aspx");
        }

    }
    protected void Make_Booking_Engineer_Click(object sender, EventArgs e)
    {
        Response.Redirect("Make_Booking_Engineer.aspx");
    }
    protected void View_Boooking_Engineer_Click(object sender, EventArgs e)
    {
        Response.Redirect("View_Activities_Engineer.aspx");
    }
    protected void Start_Activity_Engineer_Click(object sender, EventArgs e)
    {
        Response.Redirect("Start_Activity_Engineer.aspx");
    }
    protected void Close_Activity_Engineer_Click(object sender, EventArgs e)
    {
        Response.Redirect("Close_Activity_Enginner.aspx");
    }
    protected void Make_Booking_TL_Click(object sender, EventArgs e)
    {
        Response.Redirect("Make_Booking_TL.aspx");
    }
    protected void View_Previous_Booking_TL_Click(object sender, EventArgs e)
    {
        Response.Redirect("View_Activities_Engineer.aspx");
    }
    protected void View_Booking_Manager_Click(object sender, EventArgs e)
    {
        Response.Redirect("View_Activities_Engineer.aspx");
    }
}