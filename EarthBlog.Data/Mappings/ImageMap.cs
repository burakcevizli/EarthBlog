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
	public class ImageMap : IEntityTypeConfiguration<Image>
	{
		public void Configure(EntityTypeBuilder<Image> builder)
		{
			builder.HasData(new Image
			{
					Id = Guid.Parse("24760B47-F5AE-4CF6-BFEE-B17FCAB0E9F1"),
					FileName = "images/testimage",
					FileType= "jpg",
					CreatedBy = "Admin Test",
					CreatedDate = DateTime.Now,
					IsDeleted = false,

			},
			new Image
			{
				Id = Guid.Parse("3BD041F8-A798-4B61-ADC3-669191A54D9B"),
				FileName = "images/vstest",
				FileType = "png",
				CreatedBy = "Admin Test",
				CreatedDate = DateTime.Now,
				IsDeleted = false,
			});
		}
	}
}
