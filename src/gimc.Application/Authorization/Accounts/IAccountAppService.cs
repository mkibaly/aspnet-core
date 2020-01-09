using System.Threading.Tasks;
using Abp.Application.Services;
using gimc.Authorization.Accounts.Dto;

namespace gimc.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
