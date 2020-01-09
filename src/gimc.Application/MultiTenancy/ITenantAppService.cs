using Abp.Application.Services;
using Abp.Application.Services.Dto;
using gimc.MultiTenancy.Dto;

namespace gimc.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

