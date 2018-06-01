using Abp.Authorization.Roles;
using UsingRedisInAbp.MultiTenancy;
using UsingRedisInAbp.Users;

namespace UsingRedisInAbp.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}