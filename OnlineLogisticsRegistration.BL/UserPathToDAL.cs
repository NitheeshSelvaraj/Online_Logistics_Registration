using OnlineLogisticsRegistration.Entity;
using OnlineLogisticsRegistration.DAL;

namespace OnlineLogisticsRegistration.BL
{
    public class UserPathToDAL
    {
        public int SignUp(User user)
        {
            return new UserRepository().SignUp(user);
        }
        public string LogIn(string userName, string password)
        {
            return new UserRepository().LogIn(userName, password);
        }
    }
}
