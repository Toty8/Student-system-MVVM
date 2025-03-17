using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        public User(string name, string password, string facultyNumber, string email, UserRolesEnum role)
        {
            this.Name = name;
            this.Password = password;
            this.FacultyNumber = facultyNumber;
            this.Email = email;
            this.Role = role;
        }

        public string Name { get; set; }

        public string Password { get; set; }

        public string FacultyNumber { get; set; }

        public string Email { get; set; }

        public UserRolesEnum Role { get; set; }
    }
}
