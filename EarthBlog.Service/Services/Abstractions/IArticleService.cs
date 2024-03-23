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

		Task CreateArticleAsync(ArticleAddDto articleAddDto);

		Task<ArticleDto> GetAllArticlesWithCategoryNonDeletedAsync(Guid articleId);

		Task<string> UpdateArticleAsync(ArticleUpdateDto articleUpdateDto);

		Task<string> SafeDeleteArticleAsync(Guid articleId);
	}
}
