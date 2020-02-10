<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VehicleDetails.aspx.cs" Inherits="OnlineLogisticsRegistration.VehicleDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>vehicle Details</title>
    <link rel="stylesheet" type="text/css" href="OnlineLogisticsRegistrationStyleSheet.css" />
</head>
<body>
    <form id="vehicleDetailsForm" runat="server">
        <div class="Heading">
            <h1 class="Center">Vehicle Details</h1>
        </div>
    <div style="vertical-align:central">
       <asp:GridView ID="vehicleDetailsGrid" runat="server" Class="TableColor" DataKeyNames="VehicleID" AutoGenerateColumns="false" ShowFooter="true" OnRowEditing="vehicleDetailsGrid_RowEditing" OnRowUpdating="vehicleDetailsGrid_RowUpdating" OnRowCancelingEdit="vehicleDetailsGrid_RowCancelingEdit" OnRowDeleting="vehicleDetailsGrid_RowDeleting">
           <Columns>
                <asp:TemplateField HeaderText="S.No">
                   <ItemTemplate>
                       <asp:Label ID="serialNumberLabel" Text='<%# Container.DataItemIndex+1 %>' style="text-align:center" runat="server"></asp:Label>
                   </ItemTemplate>
                   <FooterTemplate>
                       <asp:Button ID="addbtn" Text="Add" runat="server" OnClick="addbtn_Click" />
                   </FooterTemplate>
               </asp:TemplateField>
               <asp:TemplateField HeaderText="Vehicle ID">
                   <ItemTemplate>
                       <asp:Label ID="vehicleIdLabel" Text='<%# Bind("VehicleID") %>' style="text-align:center" runat="server"></asp:Label>
                   </ItemTemplate>
                   <%--<EditItemTemplate>
                       <asp:TextBox ID="vehicleIdtxt" Text='<%# Bind("VehicleID") %>' runat="server" MaxLength="5"></asp:TextBox>
                   </EditItemTemplate>--%>
                   <FooterTemplate>
                       <asp:TextBox ID="vehicleIDAddtxt" runat="server" MaxLength="5"></asp:TextBox> 
                   </FooterTemplate>
                   
               </asp:TemplateField>
               <asp:TemplateField HeaderText="Vehicle Number">
                   <ItemTemplate>
                       <asp:Label ID="vehicleNumberLabel" Text='<%# Eval("VehicleNumber") %>' style="text-align:center" runat="server"></asp:Label>
                   </ItemTemplate>
                   <EditItemTemplate>
                       <asp:TextBox ID="vehicleNumbertxt" Text='<%# Eval("VehicleNumber") %>' runat="server" MaxLength="15"></asp:TextBox>
                   </EditItemTemplate>
                   <FooterTemplate>
                       <asp:TextBox ID="vehicleNumberAddtxt" runat="server" MaxLength="15"></asp:TextBox>
                   </FooterTemplate>
               </asp:TemplateField>
               <asp:TemplateField HeaderText="Vehicle Type">
                   <ItemTemplate>
                       <asp:Label ID="vehicleTypeLabel" Text='<%# Bind("VehicleType") %>' style="text-align:center" runat="server"></asp:Label>
                   </ItemTemplate>
                   <EditItemTemplate>
                       <asp:TextBox ID="vehicleTypetxt" Text='<%# Eval("VehicleType") %>' runat="server" MaxLength="20"></asp:TextBox>
                   </EditItemTemplate>
                   <FooterTemplate>
                       <asp:TextBox ID="vehicleTypeAddtxt" runat="server" MaxLength="20"></asp:TextBox>
                   </FooterTemplate>
               </asp:TemplateField>
               <asp:TemplateField HeaderText="Start Location">
                   <ItemTemplate>
                       <asp:Label ID="startLocationLabel" Text='<%# Bind("StartLocation") %>' style="text-align:center" runat="server"></asp:Label>
                   </ItemTemplate>
                   <EditItemTemplate>
                       <asp:TextBox ID="startLocationtxt" Text='<%# Bind("StartLocation") %>' runat="server" MaxLength="15"></asp:TextBox>
                   </EditItemTemplate>
                   <FooterTemplate>
                       <asp:TextBox ID="startLocationAddtxt" runat="server" MaxLength="15"></asp:TextBox>
                   </FooterTemplate>
               </asp:TemplateField>
               <asp:TemplateField HeaderText="Destination Location">
                   <ItemTemplate>
                       <asp:Label ID="destinationLocationLabel" Text='<%# Bind("DestinationLocation") %>' style="text-align:center" runat="server"></asp:Label>
                   </ItemTemplate>
                   <EditItemTemplate>
                       <asp:TextBox ID="destinationLocationtxt" Text='<%# Bind("DestinationLocation") %>' runat="server" MaxLength="15"></asp:TextBox>
                   </EditItemTemplate>
                   <FooterTemplate>
                       <asp:TextBox ID="destinationLocationAddtxt" runat="server" MaxLength="15"></asp:TextBox>
                   </FooterTemplate>
               </asp:TemplateField>
               <asp:TemplateField HeaderText="Vehicle Load Weight(In tons)">
                   <ItemTemplate>
                       <asp:Label ID="vehicleLoadWeightLabel" Text='<%# Bind("VehicleLoadWeight") %>' style="text-align:center" runat="server"></asp:Label>
                   </ItemTemplate>
                   <EditItemTemplate>
                       <asp:TextBox ID="vehicleLoadWeighttxt" Text='<%# Bind("VehicleLoadWeight") %>' runat="server" MaxLength="3"></asp:TextBox>
                   </EditItemTemplate>
                   <FooterTemplate>
                       <asp:TextBox ID="vehicleLoadWeightAddTxt" runat="server" MaxLength="3"></asp:TextBox>
                   </FooterTemplate>
               </asp:TemplateField>
               
              <%-- <asp:ButtonField ButtonType="Button" Text="Edit" />
               <asp:ButtonField ButtonType="Button" Text="Delete" />--%>
       
               <asp:CommandField ShowEditButton="true" />
               <asp:CommandField ShowDeleteButton="true" />
  
           </Columns>
       </asp:GridView>   
    </div>
    </form>
</body>
</html>
