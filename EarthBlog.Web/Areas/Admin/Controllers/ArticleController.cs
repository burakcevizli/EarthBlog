﻿using AutoMapper;
using EarthBlog.Entity.DTOs.Articles;
using EarthBlog.Entity.Entities;
using EarthBlog.Service.Extensions;
using EarthBlog.Service.Services.Abstractions;
using EarthBlog.Web.ResultMessages;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace EarthBlog.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ArticleController : Controller
	{
		private readonly IArticleService articleService;
		private readonly ICategoryService categoryService;
		private readonly IMapper mapper;
		private readonly IValidator<Article> validator;
		private readonly IToastNotification toastNotification;

		public ArticleController(IArticleService articleService , ICategoryService categoryService , IMapper mapper,IValidator<Article> validator , IToastNotification toastNotification)
        {
			this.articleService = articleService;
			this.categoryService = categoryService;
			this.mapper = mapper;
			this.validator = validator;
			this.toastNotification = toastNotification;
		}
		[HttpGet]
        public async Task<IActionResult> Index()
		{
			var articles = await articleService.GetAllArticlesWithCategoryNonDeletedAsync();
			return View(articles);
		}
		[HttpGet]
		public async Task<IActionResult> DeletedArticle()
		{
			var articles = await articleService.GetAllArticlesWithCategoryDeletedAsync();
			return View(articles);
		}
		[HttpGet]
		public async Task<IActionResult> Add()
		{
			var categories = await categoryService.GetAllCategoriesNonDeleted(); 
			return View(new ArticleAddDto { Categories = categories});
		}

		[HttpPost]
		public async Task<IActionResult> Add(ArticleAddDto articleAddDto)
		{
			var map = mapper.Map<Article>(articleAddDto);
			var result = await validator.ValidateAsync(map);

			if (result.IsValid)
			{
				await articleService.CreateArticleAsync(articleAddDto);
				toastNotification.AddSuccessToastMessage(Messages.Article.Add(articleAddDto.Title), new ToastrOptions { Title = "İşlem Başarılı"});
				return RedirectToAction("Index", "Article", new { Area = "Admin" });
			}
			else
			{
				result.AddToModelState(this.ModelState);
			}
			var categories = await categoryService.GetAllCategoriesNonDeleted();
			return View(new ArticleAddDto { Categories = categories });
		}

		[HttpGet]
		public async Task<IActionResult> Update(Guid articleId)
		{
			var article = await articleService.GetAllArticlesWithCategoryNonDeletedAsync(articleId);
			var categories = await categoryService.GetAllCategoriesNonDeleted();

			var articleUpdateDto = mapper.Map<ArticleUpdateDto>(article);
			articleUpdateDto.Categories = categories;

			return View(articleUpdateDto);
		}

		[HttpPost]
		public async Task<IActionResult> Update(ArticleUpdateDto articleUpdateDto)
		{

			var map = mapper.Map<Article>(articleUpdateDto);
			var result = await validator.ValidateAsync(map);

			if(result.IsValid)
			{
				var title = await articleService.UpdateArticleAsync(articleUpdateDto);
				toastNotification.AddSuccessToastMessage(Messages.Article.Update(title),new ToastrOptions() { Title = "İşlem Başarılı"});
				return RedirectToAction("Index", "Article", new { Area = "Admin" });
			}
			else
			{
				result.AddToModelState(this.ModelState);
			}
			var categories = await categoryService.GetAllCategoriesNonDeleted();

			articleUpdateDto.Categories = categories;

			return View(articleUpdateDto);
		}

			
		public async Task<IActionResult> Delete(Guid articleId)
		{

			var title = await articleService.SafeDeleteArticleAsync(articleId);

			toastNotification.AddSuccessToastMessage(Messages.Article.Delete(title), new ToastrOptions() { Title = "İşlem Başarılı" });

			return RedirectToAction("Index","Article",new {Area = "Admin"});
		}
		public async Task<IActionResult> UndoDelete(Guid articleId)
		{

			var title = await articleService.UndoDeleteArticleAsync(articleId);

			toastNotification.AddSuccessToastMessage(Messages.Article.UndoDelete(title), new ToastrOptions() { Title = "İşlem Başarılı" });

			return RedirectToAction("Index", "Article", new { Area = "Admin" });
		}
	}
}
