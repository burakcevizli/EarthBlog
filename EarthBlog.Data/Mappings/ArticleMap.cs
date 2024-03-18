using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EarthBlog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EarthBlog.Data.Mappings
{
	public class ArticleMap : IEntityTypeConfiguration<Article>
	{
		public void Configure(EntityTypeBuilder<Article> builder)
		{
			builder.HasData(new Article
			{
				Id = Guid.NewGuid(),
				Title = "Asp.net Core Deneme Makalesi 1",
				Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ac justo eget leo fringilla suscipit. Nullam vitae sapien vel ligula ultrices fermentum. Phasellus sollicitudin, nisi a fermentum convallis, eros dui varius ex, sed hendrerit ligula nisi eget magna. Integer posuere nibh at sem faucibus, in accumsan quam efficitur. Vivamus nec mi nec dolor fermentum aliquam. Duis ullamcorper feugiat magna, a suscipit metus mattis nec. Quisque sed velit quis nisi convallis feugiat nec eu lacus. Proin id ipsum sit amet magna consequat aliquet. Ut viverra magna in erat laoreet, ac lacinia ipsum luctus. Nam sodales convallis aliquam. Morbi in libero urna. Fusce sed est a nulla tincidunt tempus non eu odio. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer efficitur turpis a nisi fringilla, at vestibulum lorem cursus. Suspendisse potenti. Nulla facilisi. Vivamus ac dui non odio aliquam gravida.",
				ViewCount = 15,
				CategoryId = Guid.Parse("D8F762D7-D360-4573-A717-EACAFEF67266"),
				ImageId = Guid.Parse("24760B47-F5AE-4CF6-BFEE-B17FCAB0E9F1"),
				CreatedBy = "Admin Test",
				CreatedDate = DateTime.Now,
				IsDeleted = false,
			},
			new Article
			{
				Id = Guid.NewGuid(),
				Title = "Visual Studio Deneme Makalesi 1",
				Content = "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ac justo eget leo fringilla suscipit. Nullam vitae sapien vel ligula ultrices fermentum. Phasellus sollicitudin, nisi a fermentum convallis, eros dui varius ex, sed hendrerit ligula nisi eget magna. Integer posuere nibh at sem faucibus, in accumsan quam efficitur. Vivamus nec mi nec dolor fermentum aliquam. Duis ullamcorper feugiat magna, a suscipit metus mattis nec. Quisque sed velit quis nisi convallis feugiat nec eu lacus. Proin id ipsum sit amet magna consequat aliquet. Ut viverra magna in erat laoreet, ac lacinia ipsum luctus. Nam sodales convallis aliquam. Morbi in libero urna. Fusce sed est a nulla tincidunt tempus non eu odio. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Integer efficitur turpis a nisi fringilla, at vestibulum lorem cursus. Suspendisse potenti. Nulla facilisi. Vivamus ac dui non odio aliquam gravida.",
				ViewCount = 15,
				CategoryId = Guid.Parse("FD18E57B-2B39-4768-A1F3-2300C7C2069A"),
				ImageId = Guid.Parse("3BD041F8-A798-4B61-ADC3-669191A54D9B"),
				CreatedBy = "Admin Test",
				CreatedDate = DateTime.Now,
				IsDeleted = false
			}
			
			
			);
		}
	}
}
