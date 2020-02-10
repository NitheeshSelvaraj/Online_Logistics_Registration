using System;
using OnlineLogisticsRegistration.Entity;
using OnlineLogisticsRegistration.BL;


namespace OnlineLogisticsRegistration
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void BtnClick_Register(object sender, EventArgs e)
        {
            User user = new User(txtName.Text, txtMobileNumber.Text, txtUserName.Text, txtPassword.Text);
            int result= new UserPathToDAL().SignUp(user);
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