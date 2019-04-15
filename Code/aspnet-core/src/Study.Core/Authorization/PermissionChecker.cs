using Abp.Authorization;
using Study.Authorization.Roles;
using Study.Authorization.Users;

namespace Study.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
