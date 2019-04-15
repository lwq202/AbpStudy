using System.Collections.Generic;
using Study.Roles.Dto;
using Study.Users.Dto;

namespace Study.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
