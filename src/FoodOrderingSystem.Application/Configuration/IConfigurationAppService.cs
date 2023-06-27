using System.Threading.Tasks;
using FoodOrderingSystem.Configuration.Dto;

namespace FoodOrderingSystem.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
