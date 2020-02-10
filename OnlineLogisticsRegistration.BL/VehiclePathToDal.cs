using OnlineLogisticsRegistration.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLogisticsRegistration.BL
{
    public class VehiclePathToDAL
    {
        public DataTable BindData()
        {
            return new VehicleRepository().BindData();
        }
        public int Update(int vehicleID, string vehicleNumber, string vehicleType, string startLocation, string destinationLocation, int vehicleLoadWeight)
        {
            return new VehicleRepository().Update(vehicleID, vehicleNumber, vehicleType, startLocation, destinationLocation, vehicleLoadWeight);
        }
        public int Add(int vehicleID, string vehicleNumber, string vehicleType, string startLocation, string destinationLocation, int vehicleLoadWeight)
        {
            return new VehicleRepository().Add(vehicleID, vehicleNumber, vehicleType, startLocation, destinationLocation, vehicleLoadWeight);
        }
        public int Delete(int vehicleID)
        {
            return new VehicleRepository().Delete(vehicleID);
        }
    }
}
