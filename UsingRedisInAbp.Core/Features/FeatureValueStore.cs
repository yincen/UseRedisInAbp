using Abp.Application.Features;
using UsingRedisInAbp.Authorization.Roles;
using UsingRedisInAbp.MultiTenancy;
using UsingRedisInAbp.Users;

namespace UsingRedisInAbp.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}