using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HTI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TappedView : TabbedPage
    {
		public TappedView ()
		{
			InitializeComponent ();
		}
	}
}