using DataLayer.Database;
using DataLayer.Model;
using Welcome.Model;
using Welcome.Others;

namespace DataLayer
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();
                //DatabaseUser inputUser = new DatabaseUser("user", "password", "email", UserRolesEnum.STUDENT);
                //context.Add<DatabaseUser>(inputUser);
                //inputUser.Id = 5;
                //inputUser.FacultyNumber = "inputUserFacultyNumber";
                //inputUser.Expires = DateTime.UtcNow.AddYears(7);
                context.SaveChanges();
                var users = context.Users.ToList();


                Console.WriteLine("Enter username:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();

                bool exists = (from user in users
                               where user.Name == name && user.Password == password
                               select user).Any();

                string result = exists ? "Valid User!" : "Invalid User!";

                Console.WriteLine(result);
            }
        }
    }
}