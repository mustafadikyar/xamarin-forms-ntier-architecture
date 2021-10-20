using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using XF.Components.Helper;
using XF.Components.ViewModels.Base;
using XF.Mobile.Models;
using XF.Mobile.Services.User;

namespace XF.Mobile.ViewModels
{
    public class ListPageViewModel : ViewModelBase
    {
        private IList<User> _users;
        public IList<User> Users
        {
            get
            {
                if (_users == null)
                    _users = new ObservableCollection<User>();
                return _users;
            }
            set
            {
                _users = value;
            }
        }

        private readonly IUserService _userService;
        public ListPageViewModel(IUserService userService)
        {
            _userService = userService;
        }
        public override async Task InitializeAsync(object navigationData)
        {
            IsBusy = true;
            var result = await _userService.Get(PriorityType.UserInitiated);
            foreach (var item in result)
                Users.Add(item);
            IsBusy = false;
        }
    }
}