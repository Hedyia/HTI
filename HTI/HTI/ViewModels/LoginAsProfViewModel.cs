using HTI.Services;
using HTI.Views;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace HTI.ViewModels
{
    public class LoginAsProfViewModel
    {
        private string _email;
        private string _password;
        private bool _isRemembered;
        private ProfService _apiService;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public bool IsRemembered
        {
            get { return _isRemembered; }
            set { _isRemembered = value; }
        }

        public LoginAsProfViewModel()
        {
            _apiService = new ProfService();
        }
        public ICommand LoginCommand { get => new Command(Login); }

        private async void Login()
        {
            var prof = _apiService.GetProfs().Where(p=>p.Email == Email).SingleOrDefault();

            MainViewModel.StaticMainView().ProfPage = new ProfCoursesListViewModel(prof.Id);
            await Application.Current.MainPage.Navigation.PushAsync(new ProfCoursesListView());
        }

    }
}
