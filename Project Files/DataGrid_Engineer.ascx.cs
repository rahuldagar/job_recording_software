using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datagridfunctionsclass;
using System.Data.SqlClient;

public partial class DataGrid_Engineer : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            databinding();
        }
    }

    private void databinding() 
    {
        Datagridfunctions ds = new Datagridfunctions();
        SqlDataReader rdr = ds.getactivitydata();
        
        DataGridEmployee.DataSource = ds.getactivitydata();

        DataGridEmployee.DataBind();

    
    }
    protected void Update_Click(object sender, EventArgs e)
    {
        int count = 0 ;
        while (count < DataGridEmployee.Items.Count)
        {
            DataGridEmployee.Items[count].FindControl("Book_Checkbox");
            int x=DataGridEmployee.CurrentPageIndex;
            CheckBox checkbooking = (CheckBox)DataGridEmployee.Items[count].FindControl("Book_Checkbox");
            Label activitycode = (Label)DataGridEmployee.Items[count].FindControl("Activity_Code");
            if (checkbooking.Checked == true)
            {
                Datagridfunctions ds = new Datagridfunctions();
                ds.openbooking(activitycode.Text);
                ds.changestatus(activitycode.Text, 'O');
            }
            count++;
        }
        Response.Redirect("Home_Screen.aspx?");
    }
    
   
}