using System.Collections.Generic;
using PhoogleZero.Authorization.Permissions.Dto;

namespace PhoogleZero.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}