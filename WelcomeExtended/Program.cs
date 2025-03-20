using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
using static WelcomeExtended.Others.Delegates;

namespace WelcomeExtended
{
    public class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                var user = new User("TestName", "TestPassword", "TestFacoltyNumber", "TestEmail", UserRolesEnum.STUDENT);
                var viewModel = new UserViewModel(user);
                var view = new UserView(viewModel);
                Console.WriteLine(view.Display());
                Console.WriteLine(view.DysplayFacoltyNumber());
                Console.WriteLine(viewModel.Password);
                view.DisplayError();
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