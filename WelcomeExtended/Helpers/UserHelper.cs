using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    public static class UserHelper
    {
        public static void ToUserString(this User user) 
        { 

        }

        public static bool ValidateCredentials(this UserData userData, string name, string password)
        {

            if (name == null || password == null)
            {
                string field = name == null ? "name" : "password";
                throw new Exception($"The {field} cannot be empty");
            }

            return userData.ValidateUser(name, password);
        }

        public static User GetUser(this UserData userData, string name, string password)
        {
            return userData.GetUser(name, password);
        }
    }
}
