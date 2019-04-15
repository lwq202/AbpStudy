using System.Collections.Generic;
using Study.Roles.Dto;

namespace Study.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}