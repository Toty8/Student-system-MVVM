using Welcome.Model;

namespace WelcomeExtended.Data
{
    public class UserData
    {
        private List<User> users;
        private int _nextId;

        public UserData()
        {
            users = new List<User>();
            _nextId = 0;
        }

        public void AddUser(User user)
        {
            user.Id = _nextId++;
            users.Add(user);
        }

        public void DeleteUser(User user)
        {
            users.Remove(user);
        }
    }
}
