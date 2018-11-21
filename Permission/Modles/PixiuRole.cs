using System;
using System.Collections.Generic;

namespace Permission.Modles
{
    public partial class PixiuRole : BaseEntity
	{
        public string GroupCode { get; set; }
        public string RoleCode { get; set; }
        public string Description { get; set; }
    }
}
