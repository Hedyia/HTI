using HTI.Models;
using HTI.Persistence;
using HTI.Views;
using SQLite;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
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
        private SQLiteAsyncConnection _database;
        private Task<List<Student>> users;
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
            _database = DependencyService.Get<ISQLiteDb>().GetConnection();
            var users_db =  _database.Table<Student>().ToListAsync();
            users = users_db;
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
            var user = users.Result.Where(u => u.Email == Email).SingleOrDefault();
            if (user == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "The user doesn't exisit please check the email", "Accept");
                Email = "";
                Password = "";
                return;
            }
            if (user.Password != Password)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "The password is incorrect", "Accept");
                Email = "";
                Password = "";
                return;
            }
            MainViewModel.StaticMainView().Home = new HomeViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new MasterView());
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
