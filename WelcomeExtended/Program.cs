using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;
using static WelcomeExtended.Others.Delegates;

namespace WelcomeExtended
{
    public class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                UserData userData = new UserData();

                User studentUser = new User("student", "123", "studentEmail@gmail.com", UserRolesEnum.STUDENT);
                User teacherUser = new User("teacher", "1234", "teacherEmail@gmail.com", UserRolesEnum.PROFESSOR);
                User adminUser = new User("admin", "12345", "adminEmail@gmail.com", UserRolesEnum.ADMIN);

                userData.AddUser(studentUser);
                userData.AddUser(teacherUser);
                userData.AddUser(adminUser);

                Console.WriteLine("Enter username:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();

                bool exists = userData.ValidateCredentials(name, password);

                if (exists)
                {
                    User user = userData.GetUser(name, password);
                    user.ToUserString();
                }
                else
                {
                    throw new Exception("User is not found!");
                }
            }
            catch (Exception e)
            {
                var log = new ActionOnError(Log);
                log(e.Message);
            }
            finally
            {
                Console.WriteLine("Executed in any case!");
            }
        }
    }
}