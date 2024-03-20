using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EarthBlog.Data.UnitOfWorks;
using EarthBlog.Entity.DTOs.Cateogories;
using EarthBlog.Entity.Entities;
using EarthBlog.Service.Services.Abstractions;

namespace EarthBlog.Service.Services.Concrete
{
	public class CategoryService : ICategoryService
	{
		private readonly IUnitOfWork unitOfWork;
		private readonly IMapper mapper;

		public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
			this.unitOfWork = unitOfWork;
			this.mapper = mapper;
		}
        public async Task<List<CategoryDto>> GetAllCategoriesNonDeleted()
		{
			var categories = await unitOfWork.GetRepository<Category>().GetAllAsync(x=>!x.IsDeleted);
			var map = mapper.Map<List<CategoryDto>>(categories);

			return map;
		}
	}
}
