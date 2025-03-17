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

        public string DysplayFacoltyNumber()
        {
            return this._viewModel.Role == Others.UserRolesEnum.STUDENT ? $"{this._viewModel.Name}`s faculty number: {this._viewModel.FacultyNumber}" : "A user cannot have a faculty number if he/she is not a student!";
        }
    }
}
