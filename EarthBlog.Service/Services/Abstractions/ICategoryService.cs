using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EarthBlog.Entity.DTOs.Categories;
using EarthBlog.Entity.DTOs.Cateogories;
using EarthBlog.Entity.Entities;

namespace EarthBlog.Service.Services.Abstractions
{
	public interface ICategoryService
	{
		 Task<List<CategoryDto>> GetAllCategoriesNonDeleted();
		 Task CreateCategoryAsync(CategoryAddDto categoryAddDto);
		 Task<Category> GetCategoryByGuid(Guid id);
		Task<string> UpdateCategoryAsync(CategoryUpdateDto categoryUpdateDto);
		Task<string> SafeDeleteCategoryAsync(Guid categoryId);
	}
}
