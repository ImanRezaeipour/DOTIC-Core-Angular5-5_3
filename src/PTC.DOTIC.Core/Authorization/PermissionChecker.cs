using Abp.Authorization;
using PTC.DOTIC.Authorization.Roles;
using PTC.DOTIC.Authorization.Users;

namespace PTC.DOTIC.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
