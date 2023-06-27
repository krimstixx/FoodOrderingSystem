using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using FoodOrderingSystem.Configuration.Dto;

namespace FoodOrderingSystem.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : FoodOrderingSystemAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
