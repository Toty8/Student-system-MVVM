using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        private int id;
        private string name;
        private string password;
        private string facultyNumber;
        private string email;
        private DateTime expires;
        private UserRolesEnum role;
        public User(string name, string password, string facultyNumber, string email, UserRolesEnum role)
        {
            this.Name = name;
            this.Password = password;
            this.FacultyNumber = facultyNumber;
            this.Email = email;
            this.Role = role;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Password 
        {
            get 
            {
                string decryptedValue = string.Empty;
                int currCharValue;
                foreach (var letter in this.password)
                {
                    currCharValue = letter + 18;
                    decryptedValue += (char)currCharValue;
                }
                return decryptedValue; 
            }
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

        public DateTime Expires { get; set; }

        public UserRolesEnum Role { get; set; }
    }
}
