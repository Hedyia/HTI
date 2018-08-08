using HTI.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace HTI.ViewModels
{
    public class CourseDetailViewModel : ViewModelBase
    {
        private string _buttonText;
        private Course _course;

        public Course Course
        {
            get => _course;
            set { SetValue(ref _course, value); }
        }
        public string ButtonText
        {
            get => _buttonText;
            set { SetValue(ref _buttonText, value); }
        }

        public CourseDetailViewModel(Course course)
        {
            Course = course;
            if (course.IsFavoirate)
            {
                ButtonText = "Remove from favoirates";
            }
            else
            {
                ButtonText = "Add to favoirates";
            }
        }
        public ICommand FavoirateCommand { get => new Command(Favoirate); }
        private void Favoirate()
        {
            Course.IsFavoirate = !Course.IsFavoirate;
            if (Course.IsFavoirate)
            {
                ButtonText = "Remove from favoirates";
            }
            else
            {
                ButtonText = "Add to favoirates";
            }
        }
    }
}
