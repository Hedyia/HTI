using HTI.ViewModels;
using HTI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HTI.Models
{
    public class Menu
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }
        public ICommand NavigateCommand { get => new Command(Navigate); }

        private void Navigate()
        {
            switch (PageName)
            {
                case "LoginView":
                    MainViewModel.StaticMainView().Login = new LoginViewModel();
                    Application.Current.MainPage.Navigation.PushAsync(new LoginView());
                    break;
                case "FavoritesView":
                    MainViewModel.StaticMainView().Favorites = new FavoritesViewModel();
                    Application.Current.MainPage.Navigation.PushAsync(new FavoritesView());
                    break;
                case "CoursesSpecialist":
                    MainViewModel.StaticMainView().CourseSpecialist = new CoursesSpecialistViewModel();
                    Application.Current.MainPage.Navigation.PushAsync(new CoursesSpecialist());
                    break;


            }
        }
    }
}
