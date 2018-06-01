using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using UsingRedisInAbp.Authorization.Roles;
using UsingRedisInAbp.Editions;
using UsingRedisInAbp.Users;

namespace UsingRedisInAbp.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager
            )
        {
        }
    }
}