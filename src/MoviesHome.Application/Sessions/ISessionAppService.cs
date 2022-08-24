using System.Threading.Tasks;
using Abp.Application.Services;
using MoviesHome.Sessions.Dto;

namespace MoviesHome.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
