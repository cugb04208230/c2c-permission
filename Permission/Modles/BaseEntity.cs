using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Permission.Modles
{
	public class BaseEntity
	{
		public int Id { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public string Extra01 { get; set; }
		public string Extra02 { get; set; }
		public string Extra03 { get; set; }
		public string Extra04 { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime? DeletedAt { get; set; }
	}
}
