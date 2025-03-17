using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {
        private UserViewModel _viewModel;

        public UserView(UserViewModel viewModel)
        {
            this._viewModel = viewModel;
        }

        public string Display()
        {
            return $"Welcome \nUser: {this._viewModel.Name}\nRole: {this._viewModel.Role}\nEmail: {this._viewModel.Email}";
        }
    }
}
