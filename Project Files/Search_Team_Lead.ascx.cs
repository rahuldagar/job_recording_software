using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datagridfunctionsclass;

public partial class Search_Team_Lead : System.Web.UI.UserControl
{
    static string gangid = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Visible = false;
        if (!IsPostBack)
        {
            Datagridfunctions ds = new Datagridfunctions();
            DataGrid1.DataSource = ds.getactivitybooktl();
            DataGrid1.DataBind();
            TextBox1.Visible = true;
            TextBox2.Visible = false;
            Button1.Visible = false;
           // Button2.Visible = false;
            Single_Engineer.Checked = true;
        }

    }
    protected void Gang_Book_CheckedChanged(object sender, EventArgs e)
    {
        if (Gang_Book.Checked == false)
        {
            TextBox2.Visible = false;
            Button1.Visible = false;
            //Button2.Visible = false;
        }
        else
        {
            TextBox2.Visible = true;
            Button1.Visible = true;
            //Button2.Visible = true;
            TextBox1.Visible = false;
        }
    }
    protected void Single_Engineer_CheckedChanged(object sender, EventArgs e)
    {
        if (Single_Engineer.Checked == false)
        {
            TextBox1.Visible = false;

        }
        else
        {
            TextBox1.Visible = true;
            TextBox2.Visible = false;
            Button1.Visible = false;
           // Button2.Visible = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {        
        gangid = gangid + "+" + TextBox2.Text;
        string[] ga = gangid.Split('+');
        Label1.Text = "";
        int i = 0;
        Label1.Text = "";
        for (i = 1; i < ga.Length; i++)
        {
            Label1.Text += ga[i]+" ";
        }
        TextBox2.Text = "";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Datagridfunctions ds = new Datagridfunctions();
        
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        int x = 1;
        if (Single_Engineer.Checked == true)
        {
            if (TextBox1.Text != "")
            {
                Datagridfunctions ds = new Datagridfunctions();
                if (ds.checkemployid(TextBox1.Text))
                {
                    int count = 0;
                    while (count < DataGrid1.Items.Count)
                    {
                        CheckBox checkbooking = (CheckBox)DataGrid1.Items[count].FindControl("Book_Checkbox_Book_TL");
                        Label activitycode = (Label)DataGrid1.Items[count].FindControl("Activity_Code_Book_TL");
                        if (checkbooking.Checked == true)
                        {

                            ds.openbookingtl(TextBox1.Text, activitycode.Text);
                        }
                        count++;
                    }
                }

                else
                {
                    Label2.Visible = true;
                    Label2.Text += Convert.ToString(TextBox1.Text) + "  " + "not a valid Employee Code";
                    x = 0;
                }
            }
          
        }
        else 
        {
            Datagridfunctions ds = new Datagridfunctions();
            string[] checkid = gangid.Split('+');
            
            for (int i = 1; i < checkid.Length; i++) 
            {
                if (ds.checkemployid(checkid[i]))
                {
                }
                else
                {
                    x = 0;
                    Label2.Visible = true;
                    Label2.Text += checkid[i] + "  " + "not a valid Employee Code. ";
                }
            }
           
            
            if (gangid != "" & x==1)
                {

               
                    int count = 0;
                    while (count < DataGrid1.Items.Count)
                    {
                        CheckBox checkbooking = (CheckBox)DataGrid1.Items[count].FindControl("Book_Checkbox_Book_TL");
                        Label activitycode = (Label)DataGrid1.Items[count].FindControl("Activity_Code_Book_TL");
                        if (checkbooking.Checked == true)
                        {

                            ds.opengangbooking(gangid, activitycode.Text);
                        }
                        count++;
                    }
                }
        }

        if (x == 1)
        {
            Response.Redirect("Home_Screen.aspx?");
            gangid = "";
        }
     }
}