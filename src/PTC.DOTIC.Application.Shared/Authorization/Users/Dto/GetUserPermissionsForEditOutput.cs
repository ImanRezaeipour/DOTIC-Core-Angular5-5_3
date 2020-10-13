using System.Collections.Generic;
using PTC.DOTIC.Authorization.Permissions.Dto;

namespace PTC.DOTIC.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}