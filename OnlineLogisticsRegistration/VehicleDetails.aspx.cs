using System;
using System.Web.UI.WebControls;
using OnlineLogisticsRegistration.BL;
using OnlineLogisticsRegistration.Entity;

namespace OnlineLogisticsRegistration
{
    public partial class VehicleDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindData();
            }
        }
        protected void BindData()
        {
            vehicleDetailsGrid.DataSource = new VehiclePathToDAL().BindData();
            vehicleDetailsGrid.DataBind();
        }

        protected void vehicleDetailsGrid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            vehicleDetailsGrid.EditIndex = e.NewEditIndex;
            BindData();
        }

        protected void vehicleDetailsGrid_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            vehicleDetailsGrid.EditIndex = -1;
            BindData();
        }

        protected void vehicleDetailsGrid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int vehicleID=Convert.ToInt32(vehicleDetailsGrid.DataKeys[e.RowIndex].Value.ToString());
            string vehicleNumber=(vehicleDetailsGrid.Rows[e.RowIndex].FindControl("vehicleNumbertxt") as TextBox).Text;
            string vehicleType=((TextBox)vehicleDetailsGrid.Rows[e.RowIndex].FindControl("vehicleTypetxt")).Text;
            string startLocation=((TextBox)vehicleDetailsGrid.Rows[e.RowIndex].FindControl("startLocationtxt")).Text;
            string destinationLocation=((TextBox)vehicleDetailsGrid.Rows[e.RowIndex].FindControl("destinationLocationtxt")).Text;
            int vehicleLoadWeight=Convert.ToInt32(((TextBox)vehicleDetailsGrid.Rows[e.RowIndex].FindControl("vehicleLoadWeighttxt")).Text);
            Vehicle vehicle = new Vehicle(vehicleID, vehicleNumber, vehicleType, startLocation, destinationLocation, vehicleLoadWeight);
            int rows = new VehiclePathToDAL().Update(vehicle);
            if (rows >= 1)
            {
                vehicleDetailsGrid.EditIndex = -1;
                BindData();
                Response.Write("Vehicle Details Updated Successfully");
            }
        }

        protected void vehicleDetailsGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int vehicleID = Convert.ToInt32(vehicleDetailsGrid.DataKeys[e.RowIndex].Value.ToString());
            int rows = new VehiclePathToDAL().Delete(vehicleID);
            if (rows >= 1)
            {
                vehicleDetailsGrid.EditIndex = -1;
                BindData();
                Response.Write("Vehicle Details Deleted");
            }
        }

        protected void addbtn_Click(object sender, EventArgs e)
        {
            int vehicleID = Convert.ToInt32(((TextBox)vehicleDetailsGrid.FooterRow.FindControl("vehicleIDAddtxt")).Text);
            string vehicleNumber = (vehicleDetailsGrid.FooterRow.FindControl("vehicleNumberAddtxt") as TextBox).Text;
            string vehicleType = ((TextBox)vehicleDetailsGrid.FooterRow.FindControl("vehicleTypeAddtxt")).Text;
            string startLocation = ((TextBox)vehicleDetailsGrid.FooterRow.FindControl("startLocationAddtxt")).Text;
            string destinationLocation = ((TextBox)vehicleDetailsGrid.FooterRow.FindControl("destinationLocationAddtxt")).Text;
            int vehicleLoadWeight = Convert.ToInt32(((TextBox)vehicleDetailsGrid.FooterRow.FindControl("vehicleLoadWeightAddtxt")).Text);
            Vehicle vehicle=new Vehicle(vehicleID, vehicleNumber, vehicleType, startLocation, destinationLocation, vehicleLoadWeight);
            int rows = new VehiclePathToDAL().Add(vehicle);
            if (rows >= 1)
            {
                 vehicleDetailsGrid.EditIndex = -1;
                 BindData();
                 Response.Write("Vehicle Details Inserted Successfully");
            }
        }
    }
}