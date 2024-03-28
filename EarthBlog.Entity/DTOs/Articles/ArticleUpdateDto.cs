using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EarthBlog.Entity.DTOs.Cateogories;
using EarthBlog.Entity.Entities;
using Microsoft.AspNetCore.Http;

namespace EarthBlog.Entity.DTOs.Articles
{
	public class ArticleUpdateDto
	{
        public Guid Id { get; set; }
        public string Title { get; set; }
		public string Content { get; set; }
		public Guid CategoryId { get; set; }
		public Image Image { get; set; }
		public IFormFile? Photo { get; set; }
		public IList<CategoryDto> Categories { get; set; }
	}
}
