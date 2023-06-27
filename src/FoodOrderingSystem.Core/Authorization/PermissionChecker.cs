using Abp.Authorization;
using FoodOrderingSystem.Authorization.Roles;
using FoodOrderingSystem.Authorization.Users;

namespace FoodOrderingSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
