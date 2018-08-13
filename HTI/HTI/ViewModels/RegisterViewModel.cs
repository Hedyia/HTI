using HTI.Helpers;
using HTI.Models;
using HTI.Persistence;
using HTI.Services;
using HTI.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HTI.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        private ObservableCollection<CourseSpecialist> _courseSpecialist;
        private CourseService _courseService;
        private CourseSpecialist _course;
        private SQLiteAsyncConnection _database;

        public ICommand AddStudentCommand { get => new Command(AddStudent); }

        private async void AddStudent()
        {
            if (Student.Password != Student.ConfirmPassword)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "The Password is not same.", "Accept");
                Student.Password = "";
                Student.ConfirmPassword = "";
                return;
            }
            if (string.IsNullOrEmpty(Student.Email) || string.IsNullOrEmpty(Student.FirstName))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Required field is empty", "Accept");
                return;
            }
            await _database.InsertAsync(Student);
            await Application.Current.MainPage.DisplayAlert("Registration", "You Registered Sucessfully", "Accept");
            MainViewModel.StaticMainView().Login = new LoginViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new LoginView());
        }

        public CourseSpecialist Course
        {
            get { return _course; }
            set { SetValue(ref _course, value); }
        }


        public ObservableCollection<CourseSpecialist> Specialist
        {
            get { return _courseSpecialist; }
            set { SetValue(ref _courseSpecialist, value); }
        }
        private Student _student;

        public Student Student
        {
            get { return _student; }
            set { _student = value; }
        }
        public RegisterViewModel()
        {
            _student = new Student();
            _courseService = new CourseService();
            _courseSpecialist = _courseService.GetCourseSpecialists();
            _database = DependencyService.Get<ISQLiteDb>().GetConnection();
            _database.CreateTableAsync<Student>();
        }

    }
}
