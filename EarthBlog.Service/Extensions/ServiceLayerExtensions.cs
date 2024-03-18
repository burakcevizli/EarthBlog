using System.Reflection;
using EarthBlog.Service.Services.Abstractions;
using EarthBlog.Service.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;



namespace EarthBlog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IArticleService, ArticleService>();

            services.AddAutoMapper(assembly);

            return services;
        }
    }
}
