using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace gimc.Controllers
{
    public abstract class gimcControllerBase: AbpController
    {
        protected gimcControllerBase()
        {
            LocalizationSourceName = gimcConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
