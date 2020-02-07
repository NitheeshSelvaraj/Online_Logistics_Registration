using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineLogisticsRegistration
{
    public partial class Home : System.Web.UI.MasterPage
    {
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        protected void BtnRegistration_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
        protected void BtnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}