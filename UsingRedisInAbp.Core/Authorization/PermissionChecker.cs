using Abp.Authorization;
using UsingRedisInAbp.Authorization.Roles;
using UsingRedisInAbp.MultiTenancy;
using UsingRedisInAbp.Users;

namespace UsingRedisInAbp.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
