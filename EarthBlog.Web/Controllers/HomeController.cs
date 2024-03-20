using System.Diagnostics;
using EarthBlog.Service.Services.Abstractions;
using EarthBlog.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EarthBlog.Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly IArticleService articleService;

		public HomeController(ILogger<HomeController> logger , IArticleService articleService)
		{
			_logger = logger;
			this.articleService = articleService;
		}

		public async Task<IActionResult> Index()
		{
			var articles = await articleService.GetAllArticlesWithCategoryNonDeletedAsync();
			return View(articles);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
