

namespace OnlineLogisticsRegistration.Entity
{
    public class User
    {
        public string name;
        public string mobileNumber;
        public string userName;
        public string password;
        public User(string name, string mobileNumber, string userName, string password)
        {
            this.name = name;
            this.mobileNumber = mobileNumber;
            this.userName = userName;
            this.password = password;
        }
    }
}
