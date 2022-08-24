using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MoviesHome.Controllers
{
    public abstract class MoviesHomeControllerBase: AbpController
    {
        protected MoviesHomeControllerBase()
        {
            LocalizationSourceName = MoviesHomeConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
