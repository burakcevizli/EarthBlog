﻿using System;
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

		public async Task CreateArticleAsync(ArticleAddDto articleAddDto)
		{
			var userId = Guid.Parse("66D01B81-288C-44AA-A8B1-B021D7041AF5");

			var article = new Article
			{
				Title = articleAddDto.Title,
				Content = articleAddDto.Content,
				CategoryId = articleAddDto.CategorId,
				UserId = userId,
			};

			await unitOfWork.GetRepository<Article>().AddAsync(article);
			await unitOfWork.SaveAsync();
		}

		public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync()
		{

			var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.IsDeleted, x => x.Category);
			var map = mapper.Map<List<ArticleDto>>(articles);

			return map;
		}


	}
}
