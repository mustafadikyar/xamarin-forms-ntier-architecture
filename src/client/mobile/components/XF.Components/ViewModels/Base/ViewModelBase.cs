using System.Threading.Tasks;
using XF.Components.Services.Dialog;
using XF.Components.Services.Navigation;

namespace XF.Components.ViewModels.Base
{
    public class ViewModelBase : ExtendedBindableObject
    {
        private bool _isBusy;
        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }
            set
            {
                _isBusy = value;

                if (IsBusy)
                    DialogService.ShowLoading();
                else
                    DialogService.HideLoading();

                RaisePropertyChanged(() => IsBusy);
            }
        }
        protected readonly IDialogService DialogService;
        protected readonly INavigationService NavigationService;
        public ViewModelBase()
        {
            DialogService = ViewModelLocator.Resolve<IDialogService>();
            NavigationService = ViewModelLocator.Resolve<INavigationService>();
        }
        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}
