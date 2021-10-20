using System.Runtime.CompilerServices;
using XF.Components.Helper;
using XF.Components.Services;

namespace XF.Components.Selectors.Interfaces
{
    public interface IApiRequestSelector<T> : IServiceBase
    {
        T GetApiRequestByPriority(IApiRequest<T> apiRequest, PriorityType priorityType, [CallerMemberName] string methodName = "");
    }
}