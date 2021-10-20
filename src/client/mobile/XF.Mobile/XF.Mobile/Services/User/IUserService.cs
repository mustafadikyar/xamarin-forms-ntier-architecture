using System.Collections.Generic;
using System.Threading.Tasks;
using XF.Components.Helper;
using XF.Components.Services;

namespace XF.Mobile.Services.User
{
    public interface IUserService : IServiceBase
    {
        Task<List<Models.User>> Get(PriorityType priorityType);
    }
}