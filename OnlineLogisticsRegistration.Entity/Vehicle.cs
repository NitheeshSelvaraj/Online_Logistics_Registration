

namespace OnlineLogisticsRegistration.Entity
{
    class Vehicle
    {
        public int vehicleId;
        public string vehicleNumber;
        public string vehicleType;
        public string startLocation;
        public string destinationLocation;
        public int vehicleLoadWeight;
        public Vehicle(int vehicleId, string vehicleNumber, string vehicleType, string startLocation, string destinationLocation, int vehicleLoadWeight)
        {
            this.vehicleId = vehicleId;
            this.vehicleNumber = vehicleNumber;
            this.vehicleType = vehicleType;
            this.startLocation = startLocation;
            this.destinationLocation = destinationLocation;
            this.vehicleLoadWeight = vehicleLoadWeight;
        }
    }
}
