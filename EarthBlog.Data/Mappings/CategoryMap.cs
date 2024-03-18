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
	public class CategoryMap : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasData(new Category
			{

				Id = Guid.Parse("D8F762D7-D360-4573-A717-EACAFEF67266"),
				Name = "ASP.NET CORE",
				CreatedBy = "Admin Test",
				CreatedDate = DateTime.Now,
				IsDeleted = false,

			},
			new Category
			{
				Id = Guid.Parse("FD18E57B-2B39-4768-A1F3-2300C7C2069A"),
				Name = "Visual Studio 2024",
				CreatedBy = "Admin Test",
				CreatedDate = DateTime.Now,
				IsDeleted = false,

			});
		}
	}
}
