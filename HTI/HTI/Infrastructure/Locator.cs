using HTI.ViewModels;

namespace HTI.Infrastructure
{
    public class Locator
    {
        public MainViewModel MainViewModel { get; set; }
        public Locator()
        {
            MainViewModel = new MainViewModel();
        }
    }
}
