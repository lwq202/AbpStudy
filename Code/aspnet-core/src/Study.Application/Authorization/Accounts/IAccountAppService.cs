using System.Threading.Tasks;
using Abp.Application.Services;
using Study.Authorization.Accounts.Dto;

namespace Study.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
