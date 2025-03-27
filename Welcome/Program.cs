using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("name", "password", "email", Others.UserRolesEnum.STUDENT);
            UserViewModel viewModel = new UserViewModel(user);
            UserView view = new UserView(viewModel);
            Console.WriteLine(view.Display());
            Console.WriteLine(view.DysplayFacoltyNumber());
            Console.WriteLine(viewModel.Password);
        }
    }
}