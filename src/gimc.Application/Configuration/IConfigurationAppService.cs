using System.Threading.Tasks;
using gimc.Configuration.Dto;

namespace gimc.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
