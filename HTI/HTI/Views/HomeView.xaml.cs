using HTI.Models;
using HTI.Services;
using HTI.ViewModels;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HTI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeView : ContentPage
	{
        public HomeView ()
		{
			InitializeComponent ();
            picker.Title = "Courses List...";
		}

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var course = e.SelectedItem as Course;
            var homeViewModel = new HomeViewModel();
            homeViewModel.SelectCourse(course);
        }

        private void Picker_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var course = picker.SelectedItem as Course;
            var homeViewModel = new HomeViewModel();
            
            homeViewModel.SelectCourse(course);
        }
    }
}