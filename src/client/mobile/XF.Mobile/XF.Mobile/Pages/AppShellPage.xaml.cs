
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShellPage : Shell
    {
        public AppShellPage()
        {
            InitializeComponent();
        }
    }
}