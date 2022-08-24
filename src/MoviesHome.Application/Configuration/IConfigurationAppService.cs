using System.Threading.Tasks;
using MoviesHome.Configuration.Dto;

namespace MoviesHome.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
