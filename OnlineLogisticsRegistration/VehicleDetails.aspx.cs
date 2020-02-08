using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using OnlineLogisticsRegistration.DAL;

namespace OnlineLogisticsRegistration
{
    public partial class VehicleDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }
        protected void BindData()
        {
            SqlConnection sqlConnection = DataBaseConnection.GetDBConnection();
            using (SqlCommand sqlCommand = new SqlCommand("VEHICLE_Select", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                DataTable table = new DataTable();
                sqlDataAdapter.Fill(table);
                vehicleDetailsGrid.DataSource = table;
                vehicleDetailsGrid.DataBind();
            }
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
            SqlConnection sqlConnection = DataBaseConnection.GetDBConnection();
            using (SqlCommand sqlCommand = new SqlCommand("VEHICLE_Update", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@UserName", userName);
                sqlCommand.Parameters.AddWithValue("@Password", password);
                sqlCommand.Parameters.AddWithValue("@UserName", userName);
                sqlCommand.Parameters.AddWithValue("@Password", password);
            }
        }

        protected void vehicleDetailsGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}