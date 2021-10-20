using System.Reflection;
using Xamarin.Forms;
using XF.Components.Helper;
using XF.Components.ViewModels.Base;
using XF.Mobile.ViewModels;

namespace XF.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            GlobalSetting.Instance.PagesPath = "Pages";
            GlobalSetting.Instance.ViewsPath = "Views";
            GlobalSetting.Instance.ViewModelPath = "ViewModels";
            GlobalSetting.Instance.BaseEndpoint = "https://jsonplaceholder.typicode.com";

            GlobalSetting.Instance.UseAppCenter = true;
            GlobalSetting.Instance.AppCenterAndroidKey = "your-key;";

            ViewModelLocator.Init<AppShellPageViewModel>(Assembly.GetExecutingAssembly());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
