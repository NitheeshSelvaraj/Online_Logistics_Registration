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
        protected void BtnClick_Register(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
        protected void BtnClick_Login(object sender, EventArgs e)
        {
            string role = new UserRepository().LogIn(txtUserName.Text, txtPassword.Text);
            if (role == "ADMIN" || role == "USER")
            {
                if(role=="ADMIN")
                {
                    Response.Redirect("VehicleDetails.aspx");
                }
                else
                {
                    Response.Write("Role: " + role);
                    Response.Write("Logged In Successfully!!!");
                }
            }
            else if(role=="NoUser")
                Response.Write("UserName or Password Incorrect");
        }
    }
}