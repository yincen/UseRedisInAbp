using System.Threading.Tasks;
using Abp.Application.Services;
using UsingRedisInAbp.Users.Dto;

namespace UsingRedisInAbp.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);
    }
}