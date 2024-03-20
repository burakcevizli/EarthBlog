using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EarthBlog.Entity.DTOs.Cateogories;

namespace EarthBlog.Service.Services.Abstractions
{
	public interface ICategoryService
	{
		public Task<List<CategoryDto>> GetAllCategoriesNonDeleted();
	}
}
