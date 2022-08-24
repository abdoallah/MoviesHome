using System.Threading.Tasks;
using Abp.Application.Services;
using MoviesHome.Authorization.Accounts.Dto;

namespace MoviesHome.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
