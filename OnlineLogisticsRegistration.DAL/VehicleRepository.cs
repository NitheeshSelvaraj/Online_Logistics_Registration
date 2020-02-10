using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using OnlineLogisticsRegistration.Entity;

namespace OnlineLogisticsRegistration.DAL
{
    public class VehicleRepository
    {
        public DataTable BindData()
        {
            SqlConnection sqlConnection = DataBaseConnection.GetDBConnection();
            using (SqlCommand sqlCommand = new SqlCommand("VEHICLE_Select", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = sqlCommand;
                DataTable table = new DataTable();
                sqlDataAdapter.Fill(table);
                return table;
                
            }
        }
        public int Update(Vehicle vehicle)
        {
            SqlConnection sqlConnection = DataBaseConnection.GetDBConnection();
            using (SqlCommand sqlCommand = new SqlCommand("VEHICLE_Update", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@VehicleID", vehicle.vehicleID);
                sqlCommand.Parameters.AddWithValue("@VehicleNumber", vehicle.vehicleNumber);
                sqlCommand.Parameters.AddWithValue("@VehicleType", vehicle.vehicleType);
                sqlCommand.Parameters.AddWithValue("@StartLocation", vehicle.startLocation);
                sqlCommand.Parameters.AddWithValue("@DestinationLocation", vehicle.destinationLocation);
                sqlCommand.Parameters.AddWithValue("@VehicleLoadWeight", vehicle.vehicleLoadWeight);
                sqlConnection.Open();
                int rows = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return rows;
            }
        }
        public int Add(Vehicle vehicle)
        {
            SqlConnection sqlConnection = DataBaseConnection.GetDBConnection();
            using (SqlCommand sqlCommand = new SqlCommand("VEHICLE_Insert", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@VehicleID", vehicle.vehicleID);
                sqlCommand.Parameters.AddWithValue("@VehicleNumber", vehicle.vehicleNumber);
                sqlCommand.Parameters.AddWithValue("@VehicleType", vehicle.vehicleType);
                sqlCommand.Parameters.AddWithValue("@StartLocation", vehicle.startLocation);
                sqlCommand.Parameters.AddWithValue("@DestinationLocation", vehicle.destinationLocation);
                sqlCommand.Parameters.AddWithValue("@VehicleLoadWeight", vehicle.vehicleLoadWeight);
                sqlConnection.Open();
                int rows = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return rows;
            }
        }
        public int Delete(int vehicleID)
        {
            SqlConnection sqlConnection = DataBaseConnection.GetDBConnection();
            using (SqlCommand sqlCommand = new SqlCommand("VEHICLE_Delete", sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@VehicleID", vehicleID);
                sqlConnection.Open();
                int rows = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return rows;
                
            }
        }
            
           
    }
}
