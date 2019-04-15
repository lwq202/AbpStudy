using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Study.Configuration.Dto;

namespace Study.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : StudyAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
