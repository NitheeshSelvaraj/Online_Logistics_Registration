using OnlineLogisticsRegistration.DAL;
using OnlineLogisticsRegistration.Entity;
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
        public int Update(Vehicle vehicle)
        {
            return new VehicleRepository().Update(vehicle);
        }
        public int Add(Vehicle vehicle)
        {
            return new VehicleRepository().Add(vehicle);
        }
        public int Delete(int vehicleID)
        {
            return new VehicleRepository().Delete(vehicleID);
        }
    }
}
