using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EarthBlog.Entity.DTOs.Cateogories;
using Microsoft.AspNetCore.Http;


namespace EarthBlog.Entity.DTOs.Articles
{
	public class ArticleAddDto
	{
		public string Title { get; set; }
		public string Content { get; set; }
		public Guid CategorId { get; set; }

		public IFormFile Photo { get; set; }
        public IList<CategoryDto> Categories { get; set; }
    }
}
