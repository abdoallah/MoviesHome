using Abp.Application.Services;
using MoviesHome.MultiTenancy.Dto;

namespace MoviesHome.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

