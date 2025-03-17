using Welcome.Model;
using Welcome.Others;

namespace Welcome.ViewModel
{
    public class UserViewModel
    {
        private User _user;

        public UserViewModel(User user)
        {
            this._user = user;
        }

        public string Name { 
            get { return this._user.Name; }
            set { this._user.Name = value; } 
        }

        public string Password
        {
            get { return this._user.Password; }
            set { this._user.Password = value; }
        }

        public string FacoltyNumber
        {
            get { return this._user.FacoltyNumber; }
            set { this._user.FacoltyNumber = value; }
        }
        public string Email
        {
            get { return this._user.Email; }
            set { this._user.Email = value; }
        }

        public UserRolesEnum Role
        {
            get { return this._user.Role; }
            set { this._user.Role = value; }
        }
    }
}
