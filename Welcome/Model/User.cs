using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        private string name;
        private string password;
        private string facultyNumber;
        private string email;
        private UserRolesEnum role;
        public User(string name, string password, string facultyNumber, string email, UserRolesEnum role)
        {
            this.Name = name;
            this.Password = password;
            this.FacultyNumber = facultyNumber;
            this.Email = email;
            this.Role = role;
        }

        public string Name { get; set; }

        public string Password 
        {
            get { return this.password; }
            set 
            {
                string encryptedValue = string.Empty;
                int currCharValue;
                foreach (var letter in value)
                {
                    currCharValue = letter - 18;
                    encryptedValue += (char)currCharValue;
                }
                this.password = encryptedValue;
            } }

        public string FacultyNumber { get; set; }

        public string Email { get; set; }

        public UserRolesEnum Role { get; set; }
    }
}
