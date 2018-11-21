using System;
using System.Collections.Generic;

namespace Permission.Modles
{
    public partial class PixiuGroupPermission : BaseEntity
	{
        public string GroupCode { get; set; }
        public string PermissionCode { get; set; }
    }
}
