<%@ Page Language="C#" MasterPagefILE="~/Home.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="OnlineLogisticsRegistration.Registration" %>

<asp:Content ID="RegistrationTitle" runat="server" ContentPlaceHolderID="masterhead">
        <title>Registration Page</title>
</asp:Content>
<asp:Content ID="Registration" runat="server" ContentPlaceHolderID="masterbody">
    
    <link rel="stylesheet" type="text/css" href="OnlineLogisticsRegistrationStyleSheet.css" />

    <div class="Heading">
       <h1 class="Center">Registration</h1>
    </div>
    <div align="center">
        <table class="TableColor">
            <tr>
                <td>Name </td>
                <td><asp:TextBox ID="txtName" runat="server" BorderColor="Gray" TextMode="SingleLine" MaxLength="20" CssClass="Roundedcorner"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvRequiredName" runat="server" ErrorMessage="Name Required" ControlToValidate="txtName"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revCheckName" runat="server" ErrorMessage="First Letter should be <b>Capital</b>" ControlToValidate="txtName" ValidationExpression="^[A-Z][a-z]*$"></asp:RegularExpressionValidator>
                </td>
            </tr>
             <tr>
                <td>Mobile Number </td>
                <td><asp:TextBox ID="txtMobileNumber" runat="server" BorderColor="Gray" TextMode="Number" CssClass="Roundedcorner"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvRequiredMobileNumber" runat="server" ErrorMessage="Mobile Number Required" ControlToValidate="txtMobileNumber"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revCheckMobileNumber" runat="server" ErrorMessage="Enter the valid Mobile Number" ControlToValidate="txtMobileNumber" ValidationExpression="^[6-9][0-9]{9}$"></asp:RegularExpressionValidator>                
                </td>
            </tr>
             <tr>
                <td>UserName </td>
                <td><asp:TextBox ID="txtUserName" runat="server" BorderColor="Gray" TextMode="SingleLine" MaxLength="7" CssClass="Roundedcorner"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvRequiredUserName" runat="server" ErrorMessage="User Name Required" ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revCheckUserName" runat="server" ErrorMessage="UserName should have atmost 5 letters and 2 numbers" ControlToValidate="txtUserName" ValidationExpression="([a-z]|[a-z]{2}|[a-z]{3}|[a-z]{4}|[a-z]{5})[0-9]{2}$"></asp:RegularExpressionValidator>
                </td>
            </tr>
             <tr>
                <td>Password </td>
                <td><asp:TextBox ID="txtPassword" runat="server" BorderColor="Gray" TextMode="Password" MaxLength="20" CssClass="Roundedcorner"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvRequiredPassword" runat="server" ErrorMessage="Password Required" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revCheckPassword" runat="server" ErrorMessage="Password should have letters and numbers followed by special character '@'" ControlToValidate="txtPassword" ValidationExpression="[a-z]*[@][0-9]*$"></asp:RegularExpressionValidator>
                </td>
            </tr>
             <tr>
                <td>Confirm Password </td>
                <td><asp:TextBox ID="txtConfirmPassword" runat="server" BorderColor="Gray" TextMode="password" MaxLength="20" CssClass="Roundedcorner"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvRequiredConfirmation" runat="server" ErrorMessage="Should be filled" ControlToValidate="txtConfirmPassword"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvComparePassword" runat="server" ErrorMessage="Should be same as Password" ControlToCompare="password" ControlToValidate="txtConfirmPassword"></asp:CompareValidator>
                </td>
            </tr>
            <tr>  
               <td colspan="2" style="text-align:center"><asp:Button text="Register" id="btnRegister" runat="server" onclick="Click_Register"/></td>
            </tr>
        </table>
        
    </div>
   </asp:Content>
