using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    public static class UserHelper
    {
        public static void ToUserString(this User user) 
        {
            Console.WriteLine($"User: {user.Name}, Password: {user.Password}, Email: {user.Email}, Role: {user.Role}");
        }

        public static bool ValidateCredentials(this UserData userData, string name, string password)
        {

            if (String.IsNullOrWhiteSpace(name) || String.IsNullOrWhiteSpace(password))
            {
                string field = String.IsNullOrWhiteSpace(name) ? "name" : "password";
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
