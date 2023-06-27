using Abp.Application.Services;
using FoodOrderingSystem.MultiTenancy.Dto;

namespace FoodOrderingSystem.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

