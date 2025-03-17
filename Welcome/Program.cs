using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("name", "password", "facoltyNumber", "email", Others.UserRolesEnum.ADMIN);
            UserViewModel viewModel = new UserViewModel(user);
            UserView view = new UserView(viewModel);
            Console.WriteLine(view.Display());
        }
    }
}