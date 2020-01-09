using Abp.Authorization;
using gimc.Authorization.Roles;
using gimc.Authorization.Users;

namespace gimc.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
