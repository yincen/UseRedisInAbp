using System.Threading.Tasks;
using Abp.Application.Services;
using UsingRedisInAbp.Roles.Dto;

namespace UsingRedisInAbp.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
