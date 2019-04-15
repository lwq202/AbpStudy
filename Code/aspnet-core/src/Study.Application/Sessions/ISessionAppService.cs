using System.Threading.Tasks;
using Abp.Application.Services;
using Study.Sessions.Dto;

namespace Study.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
