using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EarthBlog.Entity.DTOs.Articles;
using EarthBlog.Entity.Entities;

namespace EarthBlog.Service.Services.Abstractions
{
	public interface IArticleService
	{
		Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync();
	}
}
