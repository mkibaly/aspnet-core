using System.Threading.Tasks;
using Abp.Application.Services;
using gimc.Sessions.Dto;

namespace gimc.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
