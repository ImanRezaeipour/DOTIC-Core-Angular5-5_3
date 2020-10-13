using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PTC.DOTIC.Authorization.Permissions.Dto;

namespace PTC.DOTIC.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
