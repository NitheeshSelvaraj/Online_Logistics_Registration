

namespace OnlineLogisticsRegistration.Entity
{
    public class Vehicle
    {
        public int vehicleID;
        public string vehicleNumber;
        public string vehicleType;
        public string startLocation;
        public string destinationLocation;
        public int vehicleLoadWeight;
        public Vehicle(int vehicleID, string vehicleNumber, string vehicleType, string startLocation, string destinationLocation, int vehicleLoadWeight)
        {
            this.vehicleID = vehicleID;
            this.vehicleNumber = vehicleNumber;
            this.vehicleType = vehicleType;
            this.startLocation = startLocation;
            this.destinationLocation = destinationLocation;
            this.vehicleLoadWeight = vehicleLoadWeight;
        }
    }
}
