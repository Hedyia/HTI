using HTI.Models;
using HTI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HTI.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FavoritesView : ContentPage
	{
		public FavoritesView ()
		{
			InitializeComponent ();
		}
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var course = e.SelectedItem as Course;
            var homeViewModel = new HomeViewModel();
            homeViewModel.SelectCourse(course);
        }
    }
}