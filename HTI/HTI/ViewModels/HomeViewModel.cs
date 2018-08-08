using HTI.Models;
using HTI.Services;
using HTI.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace HTI.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private CourseService _service = new CourseService();
        public ObservableCollection<Course> Courses
        {
            get => _service.GetCourses();
        }
        

        public  async void SelectCourse(Course course)
        {

            MainViewModel.StaticMainView().CourseItem = new CourseItemView(course);
            await Application.Current.MainPage.Navigation.PushAsync(new TappedView());
        }

    }
    
}
