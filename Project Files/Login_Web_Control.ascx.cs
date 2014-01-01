using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Declared_Classes;

public partial class Login_Web_Control : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login_Button_Click(object sender, EventArgs e)
    {
        Declared_Classes.Login Login_Object = new Declared_Classes.Login();
        string userid = Login_Object.check_user(User_Name_Label.Text, Password_Label.Text);
        userid = userid.TrimEnd(' ');
        if (userid != "")
        {
            Message_Label.Visible = false;
            Response.Redirect("Home_Screen.aspx?");
        }
    }

}