using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MoviesHome.Configuration.Dto;

namespace MoviesHome.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MoviesHomeAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
