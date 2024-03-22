using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthBlog.Core.Entities
{
	public abstract class EntityBase : IEntityBase
	{

        public virtual Guid Id { get; set; } = Guid.NewGuid();
		public virtual string CreatedBy { get; set; } = "Undefined";
		public virtual string? ModifiedBy { get; set; } // Burdaki soru işareti nullable olabilme ifadesini temsil eder.
														// Yani Direkt başta olusturulmasına gerek yoktur gibi.

		public virtual string? DeletedBy { get; set; }
		public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
		public virtual DateTime? ModifiedTime { get; set; }
		public virtual DateTime? DeletedDate { get; set; }
		public virtual bool IsDeleted { get; set; } = false;
	}
}
