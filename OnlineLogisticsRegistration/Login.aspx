<%@ Page Language="C#" MasterPagefILE="~/Home.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineLogisticsRegistration.Login" %>
<asp:Content ID="LoginTitle" runat="server" ContentPlaceHolderID="masterhead">
        <title>Login Page</title>
</asp:Content> 

<asp:Content ID="LOGIN" runat="server" ContentPlaceHolderID="masterbody">
         
    
    <link rel="stylesheet" type="text/css" href="OnlineLogisticsRegistrationStyleSheet.css" />

   
    <div class="Heading">
       <h1 class="Center">Login</h1>
    </div>
    <div align="center">
       <table class="TableColor">
           <tr>
               <td>UserName </td>
               <td><asp:TextBox ID="txtUserName" runat="server" BorderColor="Gray" TextMode="SingleLine" MaxLength="7" CssClass="Roundedcorner"></asp:TextBox>
               </td>
           </tr>
           <tr>
               <td>Password </td>
               <td><asp:TextBox ID="txtPassword" runat="server" BorderColor="Gray" TextMode="Password" MaxLength="20" CssClass="Roundedcorner"></asp:TextBox>
               </td>
           </tr>
       </table>
    </div>
    <div align="center">
        <table>
           <tr>  
               <td><asp:Button text="Register" id="btnRegister" runat="server" onclick="BtnClick_Register"/></td>
               <td></td>
               <td><asp:Button text="Login" id="btnLogin" runat="server" onclick="BtnClick_Login"/></td>
            </tr>
        </table>
   </div>

</asp:Content>