using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datagridfunctionsclass;

public partial class view_open_bookings : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Datagridfunctions ds = new Datagridfunctions();
            DataGridCloseEmployee.DataSource = ds.getactivitydataopen();
            DataGridCloseEmployee.DataBind();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int count = 0;
        while (count < DataGridCloseEmployee.Items.Count)
        {
            CheckBox checkbooking = (CheckBox)DataGridCloseEmployee.Items[count].FindControl("CloseBooking_Checkbox");
            Label activitycode = (Label)DataGridCloseEmployee.Items[count].FindControl("Activity_Code_Close");
            if (checkbooking.Checked == true)
            {
                Datagridfunctions ds = new Datagridfunctions();
                ds.closeboking(activitycode.Text);
            }
            count++;
        }

        Response.Redirect("Home_Screen.aspx?");
    }
}