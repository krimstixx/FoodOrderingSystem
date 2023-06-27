using System.Threading.Tasks;
using Abp.Application.Services;
using FoodOrderingSystem.Sessions.Dto;

namespace FoodOrderingSystem.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
