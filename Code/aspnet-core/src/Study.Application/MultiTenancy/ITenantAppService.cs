using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Study.MultiTenancy.Dto;

namespace Study.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

