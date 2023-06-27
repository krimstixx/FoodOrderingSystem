using System.Threading.Tasks;
using Abp.Application.Services;
using FoodOrderingSystem.Authorization.Accounts.Dto;

namespace FoodOrderingSystem.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
