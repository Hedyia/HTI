using HTI.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace HTI.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        #region BackingField
        private string _email;
        private string _password;
        private bool _isRemembered;
        #endregion
        #region Propirties
        public string Email
        {
            get => _email;
            set { SetValue(ref _email, value); }
        }

        public string Password
        {
            get => _password;
            set { SetValue(ref _password, value); }
        }

        public bool IsRemembered
        {
            get => _isRemembered;
            set { SetValue(ref _isRemembered, value); }
        }
        #endregion
        #region Constructors
        public LoginViewModel()
        {
            Email = "muo.cpp@gmail.com";
            Password = "92325922";
        }
        #endregion
        #region Commands
        public ICommand LoginCommand { get => new Command(Login); }
        public ICommand RegisterCommand { get => new Command(Register); }
        public ICommand ProfCommand { get => new Command(Prof); }
        #endregion
        #region Methods
        private async void Login()
        {
            MainViewModel.StaticMainView().Home = new HomeViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new HomeView());
        }
        private async void Register()
        {
            MainViewModel.StaticMainView().Registration = new RegisterViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new RegisterView());
        }
        private async void Prof()
        {
            MainViewModel.StaticMainView().ProfLogin = new LoginAsProfViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new LoginAsProfView());
        }
        #endregion
    }
}
