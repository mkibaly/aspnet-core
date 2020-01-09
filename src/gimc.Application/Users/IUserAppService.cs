using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using gimc.Roles.Dto;
using gimc.Users.Dto;

namespace gimc.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
