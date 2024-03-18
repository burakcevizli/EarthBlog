using EarthBlog.Core.Entities;

namespace EarthBlog.Entity.Entities
{
	public class Category : EntityBase 
	{
		public string Name { get; set; }
		public ICollection<Article> Articles { get; set; }
	}
}
