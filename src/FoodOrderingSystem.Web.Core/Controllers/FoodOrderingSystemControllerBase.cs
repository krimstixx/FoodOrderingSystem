using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace FoodOrderingSystem.Controllers
{
    public abstract class FoodOrderingSystemControllerBase: AbpController
    {
        protected FoodOrderingSystemControllerBase()
        {
            LocalizationSourceName = FoodOrderingSystemConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
