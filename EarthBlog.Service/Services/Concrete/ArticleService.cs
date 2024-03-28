using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EarthBlog.Data.UnitOfWorks;
using EarthBlog.Entity.DTOs.Articles;
using EarthBlog.Entity.Entities;
using EarthBlog.Entity.Enums;
using EarthBlog.Service.Extensions;
using EarthBlog.Service.Helpers.Images;
using EarthBlog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Http;

namespace EarthBlog.Service.Services.Concrete
{
	public class ArticleService : IArticleService
	{
		private readonly IUnitOfWork unitOfWork;
		private readonly IMapper mapper;
		private readonly IHttpContextAccessor httpContextAccessor;
		private readonly IImageHelper imageHelper;
		private readonly ClaimsPrincipal _user;

		public ArticleService(IUnitOfWork unitOfWork, IMapper mapper , IHttpContextAccessor httpContextAccessor , IImageHelper imageHelper)
		{
			this.unitOfWork = unitOfWork;
			this.mapper = mapper;
			this.httpContextAccessor = httpContextAccessor;
			this.imageHelper = imageHelper;
			_user = httpContextAccessor.HttpContext.User;
		}

		public async Task CreateArticleAsync(ArticleAddDto articleAddDto)
		{
			//var userId = Guid.Parse("66D01B81-288C-44AA-A8B1-B021D7041AF5");

			var userId = _user.GetLoggedInUserId();
			var userEmail =_user.GetLoggedInEmail();
			var imageUpload = await imageHelper.Upload(articleAddDto.Title, articleAddDto.Photo, ImageType.Post);
			Image image = new(imageUpload.FullName, articleAddDto.Photo.ContentType, userEmail);
			await unitOfWork.GetRepository<Image>().AddAsync(image);


			var article = new Article(articleAddDto.Title, articleAddDto.Content ,userId,articleAddDto.CategorId,image.Id, userEmail);

			await unitOfWork.GetRepository<Article>().AddAsync(article);
			await unitOfWork.SaveAsync();
		}

		public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync()
		{

			var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.IsDeleted, x => x.Category);
			var map = mapper.Map<List<ArticleDto>>(articles);

			return map;
		}

		public async Task<ArticleDto> GetAllArticlesWithCategoryNonDeletedAsync(Guid articleId)
		{
			var article = await unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted && x.Id == articleId, x => x.Category 
			, i => i.Image );
			var map = mapper.Map<ArticleDto>(article);

			return map;
		}

		public async Task<string> UpdateArticleAsync(ArticleUpdateDto articleUpdateDto)
		{
			var userEmail = _user.GetLoggedInEmail();
			var article = await unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted && x.Id == articleUpdateDto.Id, x => x.Category, i=>i.Image);

			if(articleUpdateDto.Photo != null)
			{
				 imageHelper.Delete(article.Image.FileName);
				var imageUpload = await imageHelper.Upload(articleUpdateDto.Title,articleUpdateDto.Photo,ImageType.Post);
				Image image = new(imageUpload.FullName, articleUpdateDto.Photo.ContentType, userEmail);
				await unitOfWork.GetRepository<Image>().AddAsync(image);

				article.ImageId = image.Id;
			}

			article.Title = articleUpdateDto.Title;
			article.Content = articleUpdateDto.Content;
			article.CategoryId = articleUpdateDto.CategoryId;
			article.ModifiedTime = DateTime.Now;
			article.ModifiedBy = userEmail;

			await unitOfWork.GetRepository<Article>().UpdateAsync(article);

			await unitOfWork.SaveAsync();

			return article.Title;
		}

		public async Task<string> SafeDeleteArticleAsync(Guid articleId) 
		{
			var userEmail = _user.GetLoggedInEmail();
			var article = await unitOfWork.GetRepository<Article>().GetByGuidAsync(articleId);

			article.IsDeleted = true;
			article.DeletedDate = DateTime.Now;
			article.DeletedBy = userEmail;

			await unitOfWork.GetRepository<Article>().UpdateAsync(article);

			await unitOfWork.SaveAsync();

			return article.Title;
		}


	}
}
