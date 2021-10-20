using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XF.Components.ViewModels.Base;

namespace XF.Mobile.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public override Task InitializeAsync(object navigationData)
        {
            return base.InitializeAsync(navigationData);
        }

        public ICommand DialogCommand => new Command(() =>
        {
            DialogService.AlertAsync("Dialog Service", "Test", "Ok");
        });
    }
}
