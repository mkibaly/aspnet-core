using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using gimc.Configuration.Dto;

namespace gimc.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : gimcAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
