using HTI.Helpers;
using HTI.Models;
using HTI.Persistence;
using HTI.Services;
using HTI.Views;
using SQLite;
using Syncfusion.DataSource.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HTI.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {

        private ObservableCollection<Course> _courses;
        private CourseService _courseService;
        private string _filter;

        public ObservableCollection<Course> Courses
        {
            get
            {
                return _courses;
            }
            set
            {
                SetValue(ref _courses, value);
            }

        }
        public ObservableCollection<Course> FavCourses
        {
            get
            {
                return Courses.Where(c => c.IsFavoirate == true).ToObservableCollection();
            }
        }
        public async void SelectCourse(Course course)
        {

            MainViewModel.StaticMainView().CourseItem = new CourseItemView(course);
            await Application.Current.MainPage.Navigation.PushAsync(new TappedView());
        }
        public string Filter
        {
            get
            {
                return _filter;
            }
            set
            {
                SetValue(ref _filter, value);
                Search();
            }
        }
        public ICommand SearchCommand
        {
            get
            {
                return new Command(Search);
            }
        }

        private void Search()
        {
            if (String.IsNullOrEmpty(Filter))
            {
                Courses = _courseService.GetCourses();

            }
            else
            {
                this.Courses = new ObservableCollection<Course>(
                    Courses.Where(c => c.CourseName.ToLower().StartsWith(Filter.ToLower())
                    || c.CourseId.ToLower().StartsWith(Filter.ToLower())));

            }
        }

        public HomeViewModel()
        {
            _courseService = new CourseService();
            Courses = _courseService.GetCourses();
        }
        public HomeViewModel(ObservableCollection<Course> courses)
        {
            _courseService = new CourseService();
            Courses = courses;
        }
    }

}
