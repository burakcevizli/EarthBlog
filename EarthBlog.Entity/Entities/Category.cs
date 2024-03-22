using EarthBlog.Core.Entities;

namespace EarthBlog.Entity.Entities
{
	public class Category : EntityBase 
	{
        public Category()
        {
            
        }
        public Category(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
		public ICollection<Article> Articles { get; set; }
	}
}
