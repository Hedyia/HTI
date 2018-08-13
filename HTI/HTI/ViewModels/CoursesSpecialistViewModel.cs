using HTI.Models;
using HTI.Services;
using HTI.Views;
using Syncfusion.DataSource.Extensions;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace HTI.ViewModels
{
    public class CoursesSpecialistViewModel : ViewModelBase
    {
        private CourseService _courseService;
        private ObservableCollection<CourseSpecialist> _courseSpecialist;
        private CourseSpecialist _course;

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
        public ICommand ShowCoursesSpecialistCommand { get => new Command(SelectDepartment); }
        private void SelectDepartment()
        {
            var courses = _courseService.GetCourses(); ;
            if (Course.Specialist == Models.Specialist.ALL)
            {
                MainViewModel.StaticMainView().Home = new HomeViewModel(courses);
                Application.Current.MainPage.Navigation.PushAsync(new HomeView());
            }
            else
            {
                courses = _courseService.GetCourses().Where
                    (c => c.Specialist == Course.Specialist).ToObservableCollection();
                MainViewModel.StaticMainView().Home = new HomeViewModel(courses);
                Application.Current.MainPage.Navigation.PushAsync(new HomeView());
            }
        }

        public CoursesSpecialistViewModel()
        {
            _courseService = new CourseService();
            Specialist = _courseService.GetCourseSpecialists();
        }
    }
}
