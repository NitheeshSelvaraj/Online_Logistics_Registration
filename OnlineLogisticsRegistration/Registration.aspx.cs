using System;
using OnlineLogisticsRegistration.Entity;
using OnlineLogisticsRegistration.DAL;


namespace OnlineLogisticsRegistration
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Click_Register(object sender, EventArgs e)
        {
            User user = new User(name.Text, mobileNumber.Text, userName.Text, password.Text);
            int result= new UserRepository().SignUp(user);
            if (result == 1)
            {
                // new Login().Display();
                Response.Redirect("Login.aspx");
                //Response.Write("Registered Successfully!!!");
            }
            else if (result == 0)
                Response.Write("Registration Error Occured");
            else
                Response.Write("UserName or MobileNumber or Password Already Exists");
        }
    }
}