using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EarthBlog.Data.UnitOfWorks;
using EarthBlog.Entity.DTOs.Articles;
using EarthBlog.Entity.Entities;
using EarthBlog.Service.Services.Abstractions;

namespace EarthBlog.Service.Services.Concrete
{
	public class ArticleService : IArticleService
	{
		private readonly IUnitOfWork unitOfWork;
		private readonly IMapper mapper;

		public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			this.unitOfWork = unitOfWork;
			this.mapper = mapper;
		}

		public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync()
		{

			var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.IsDeleted, x => x.Category);
			var map = mapper.Map<List<ArticleDto>>(articles);

			return map;
		}
	}
}
