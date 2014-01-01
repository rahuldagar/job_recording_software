using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Datagridfunctionsclass;

public partial class View_Drop_D : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Datagridfunctions ds = new Datagridfunctions();
        string ty = (string)HttpContext.Current.Session["user_type"];
        int tyi;
        if (ty == "MGR")
        {
            tyi = 1;
            CheckBox2.Visible = false;
            CheckBox2.Checked = false;
        }
        else
        {
            tyi = 0;
        }
        if (!IsPostBack)
        {
            CheckBox1.Checked = false;
            CheckBox2.Checked =false;
            DropDownList1.DataSource = ds.getemployeecode();
            DropDownList1.DataTextField = "Employee_Code";
            DropDownList1.DataValueField = "Employee_Code";
            DropDownList1.DataBind();
            DataGridEmpCode.DataSource = ds.getactivityemp(DropDownList1.SelectedValue);
            DataGridEmpCode.DataBind();
        }

        if (CheckBox2.Checked == true && tyi==0)
        {
            Label1.Visible = false;
            DropDownList1.Visible = false;
            CheckBox1.Visible = false;
            DataGridEmpCode.DataSource = null;
            DataGridEmpCode.DataSource = ds.getactivityown();
            DataGridEmpCode.DataBind();
        }
        else
        {
            Label1.Visible = true;
            DropDownList1.Visible = true;
            CheckBox1.Visible = true;
            DataGridEmpCode.DataSource = ds.getactivityemp(DropDownList1.SelectedValue);
            DataGridEmpCode.DataBind();
            if (CheckBox1.Checked == true)
            {
                hide(Convert.ToInt32(DropDownList2.SelectedValue));
            }
            else
            {
            }
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Datagridfunctions ds = new Datagridfunctions();
        string selectedemp = DropDownList1.SelectedValue;
        DataGridEmpCode.DataSource = null;
        DataGridEmpCode.DataSource = ds.getactivityemp(DropDownList1.SelectedValue);
        DataGridEmpCode.DataBind();
        if (CheckBox1.Checked == true)
        {
            hide(Convert.ToInt32( DropDownList2.SelectedValue));
        }
    }

    private void hide(int daysback)
    {
        System.DateTime dt = new DateTime();
        System.DateTime dtnow = new System.DateTime();

        int count = 0;
        while (count < DataGridEmpCode.Items.Count)
        {
            dtnow = DateTime.Now;
            DataGridEmpCode.Items[count].FindControl("Book_Checkbox");
            int x = DataGridEmpCode.CurrentPageIndex;

            Label starttime = (Label)DataGridEmpCode.Items[count].FindControl("Start_Time");

            if (starttime.Text == "" || starttime.Text == null)
            {
                DataGridEmpCode.Items[count].Visible = false;
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
                dtnow = dtnow.AddDays(daysback);

                if (dtnow.CompareTo(dt) < 0)
                {
                    DataGridEmpCode.Items[count].Visible = false;
                }
            }

            count++;
        }

    }

}