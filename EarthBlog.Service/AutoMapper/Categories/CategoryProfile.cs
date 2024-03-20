using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EarthBlog.Entity.DTOs.Cateogories;
using EarthBlog.Entity.Entities;

namespace EarthBlog.Service.AutoMapper.Categories
{
	public class CategoryProfile : Profile
	{
        public CategoryProfile()
        {
            CreateMap<CategoryDto, Category>().ReverseMap();
        }
    }
}
