using HTI.Models;
using HTI.Services;
using HTI.Views;
using Syncfusion.DataSource.Extensions;
using System.Collections.ObjectModel;
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
        private CourseService _courseService;
        private ProfService _apiService;
        private ObservableCollection<Course> _courses;
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
            _courseService = new CourseService();
           _courses = _courseService.GetCourses().Where(c => c.ProfName == prof.Name).ToObservableCollection();
            MainViewModel.StaticMainView().Home = new HomeViewModel(_courses);
            await Application.Current.MainPage.Navigation.PushAsync(new HomeView());
        }

    }
}
