using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Study.Controllers
{
    public abstract class StudyControllerBase: AbpController
    {
        protected StudyControllerBase()
        {
            LocalizationSourceName = StudyConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
