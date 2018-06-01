using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using UsingRedisInAbp.MultiTenancy.Dto;

namespace UsingRedisInAbp.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
