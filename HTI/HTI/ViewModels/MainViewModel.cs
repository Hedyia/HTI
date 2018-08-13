using HTI.Models;
using System;
using System.Collections.ObjectModel;

namespace HTI.ViewModels
{
    public class MainViewModel
    {
        public LoginViewModel Login { get; set; }
        public HomeViewModel Home { get; set; }
        public CourseItemView CourseItem { get; set; }
        public CourseDetailViewModel CourseDetail { get; set; }
        public RegisterViewModel Registration { get; set; }
        public PdfCourseViewerViewModel pdfCourseViewer { get; set; }
        public PlayListViewModel playList { get; set; }
        public LoginAsProfViewModel ProfLogin { get; set; }
        public ProfCoursesListViewModel ProfPage { get; set; }
        public FavoritesViewModel Favorites { get; set; }
        public UserProfileViewModel UserProfile { get; set; }
        public CoursesSpecialistViewModel CourseSpecialist { get; set; }

        public ObservableCollection<Menu> MyMenu { get; set; }
        public MainViewModel()
        {
            Login = new LoginViewModel();
            Registration = new RegisterViewModel();
            _staticMainView = this;
            MyMenu = new ObservableCollection<Menu>();
            LoadMenu();
        }

        private void LoadMenu()
        {
            MyMenu.Add(new Menu
            {
                Title = "Department",
                Icon = "ic_settings",
                PageName = "CoursesSpecialist"
            });
            MyMenu.Add(new Menu
            {
                Title = "Faviorates",
                Icon = "ic_favorite",
                PageName = "FavoritesView"
            });
            MyMenu.Add(new Menu
            {
                Title = "Logout",
                Icon = "ic_exit_to_app",
                PageName = "LoginView"
            });
        }

        private static MainViewModel _staticMainView;
        public static MainViewModel StaticMainView()
        {
            return _staticMainView;
        }
    }
}
