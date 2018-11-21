using System;
using System.Collections.Generic;

namespace Permission.Modles
{
    public partial class PixiuPermission : BaseEntity
	{
        public string PermissionCode { get; set; }
        public string RoutePath { get; set; }
        public string Description { get; set; }
        public int HttpMethod { get; set; }
        public string ParentPermissionCode { get; set; }
        public bool IsAllowAny { get; set; }
    }
}
