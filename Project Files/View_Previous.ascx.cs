using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datagridfunctionsclass;
using System.Data.SqlClient;

public partial class View_Previous : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
         Datagridfunctions ds = new Datagridfunctions();


         string type = (string)HttpContext.Current.Session["user_type"];

        if (type == "ENG")
        {
            DataGridPre.DataSource = ds.searchpreengineer();
        }
        else
        {
            DataGridPre.DataSource = ds.searchpre();
        }
        DataGridPre.DataBind();

        if (type != "MGR")
        {
            if (type != "TL" && CheckBox1.Checked==true)
            {
                hide(Convert.ToInt32(DropDownList1.SelectedValue));
            }
        }
    }


    private void hide(int daysback)
    {
        System.DateTime dt = new DateTime();
        System.DateTime dtnow = new System.DateTime();

        int count = 0;
        while (count < DataGridPre.Items.Count)
        {
            dtnow = DateTime.Now;
            DataGridPre.Items[count].FindControl("Book_Checkbox");
            int x = DataGridPre.CurrentPageIndex;

            Label starttime = (Label)DataGridPre.Items[count].FindControl("Start_Time");
            if (starttime.Text == "" || starttime.Text == null)
            {
                DataGridPre.Items[count].Visible = false;
            }
            else
            {
                dt = Convert.ToDateTime(starttime.Text);
                int hour = -dtnow.Hour;
                int sec = -dtnow.Second;
                int min = -dtnow.Minute;
                dtnow = dtnow.AddHours(hour);
                dtnow = dtnow.AddSeconds(sec);
                dtnow = dtnow.AddMinutes(min);
                dtnow = dtnow.AddDays(Convert.ToInt32(DropDownList1.SelectedValue));

                if (dtnow.CompareTo(dt) < 0)
                {
                    DataGridPre.Items[count].Visible = false;
                }
            }

            count++;
        }
    
    }

    protected void DataGridPre_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}