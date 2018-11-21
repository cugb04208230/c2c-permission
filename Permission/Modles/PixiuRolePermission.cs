using System;
using System.Collections.Generic;

namespace Permission.Modles
{
    public partial class PixiuRolePermission : BaseEntity
	{
        public string RoleCode { get; set; }
        public string PermissionCode { get; set; }
        public string GroupCode { get; set; }
    }
}
