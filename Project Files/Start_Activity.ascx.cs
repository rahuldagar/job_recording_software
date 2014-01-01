using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Datagridfunctionsclass;

public partial class Start_Activity : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Datagridfunctions ds = new Datagridfunctions();
            DataGridOpenEmployee.DataSource = ds.getbookedactivities();
            DataGridOpenEmployee.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int count = 0;
        while (count < DataGridOpenEmployee.Items.Count)
        {
            CheckBox checkbooking = (CheckBox)DataGridOpenEmployee.Items[count].FindControl("CloseBooking_Checkbox");
            Label activitycode = (Label)DataGridOpenEmployee.Items[count].FindControl("Activity_Code_Close");
            Label employeecode = (Label)DataGridOpenEmployee.Items[count].FindControl("Employee_Code_Close");
            if (checkbooking.Checked == true)
            {
                Datagridfunctions ds = new Datagridfunctions();
                ds.startbookedactivity(activitycode.Text);
            }
            count++;
        }
        Response.Redirect("Home_Screen.aspx?");
    }
}