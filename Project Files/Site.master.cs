using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Default_Menu.Visible = false;
        Engineer_Menu.Visible = false;
        Team_Leader_Menu.Visible = false;
        Manager_Menu.Visible = false;

        if ((string)HttpContext.Current.Session["user_type"] == null)
        {
            Default_Menu.Visible = true;

        }

        if ((string)HttpContext.Current.Session["user_type"] == "ENG")
        {
            Engineer_Menu.Visible = true;

        }
        if ((string)HttpContext.Current.Session["user_type"] == "TL")
        {
            Team_Leader_Menu.Visible = true;

        }
        if ((string)HttpContext.Current.Session["user_type"] == "MGR")
        {
            Manager_Menu.Visible = true;

        }
    }
    protected void Team_Leader_Menu_MenuItemClick(object sender, MenuEventArgs e)
    {

    }
}
