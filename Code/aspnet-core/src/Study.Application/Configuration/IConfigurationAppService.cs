using System.Threading.Tasks;
using Study.Configuration.Dto;

namespace Study.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
