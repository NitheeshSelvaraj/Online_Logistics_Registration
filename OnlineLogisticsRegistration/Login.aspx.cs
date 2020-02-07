using System;
using OnlineLogisticsRegistration.DAL;

namespace OnlineLogisticsRegistration
{
    public partial class Login : System.Web.UI.Page
    {
       // public void Display()
        //{
          //  Console.WriteLine("Registered successfully");
        //}
        protected void Click_Register(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
        protected void Click_Login(object sender, EventArgs e)
        {
            string role = new UserRepository().LogIn(userName.Text, password.Text);
            if (role == "ADMIN" || role == "USER")
            {
                Response.Write("Role: " + role);
                Response.Write("Logged In Successfully!!!");
            }
            else if(role=="NoUser")
                Response.Write("UserName or Password Incorrect");
        }
    }
}