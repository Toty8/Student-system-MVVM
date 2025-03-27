using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    public static class UserHelper
    {
        public static void ToUserString(this User user) 
        { 

        }

        public static void ValidateCredentials(this UserData userData, string name, string password)
        {

            if (name == null || password == null)
            {
                string field = name == null ? "name" : "password";
                throw new Exception($"The {field} cannot be empty");
            }

            userData.ValidateUser(name, password);
        }
    }
}
