using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EarthBlog.Entity.DTOs.Categories;
using EarthBlog.Entity.DTOs.Cateogories;
using EarthBlog.Entity.DTOs.Users;
using EarthBlog.Entity.Entities;

namespace EarthBlog.Service.AutoMapper.Users
{
	public class UserProfile : Profile
	{
		public UserProfile()
		{
			CreateMap<AppUser,UserDto>().ReverseMap();
			CreateMap<AppUser,UserAddDto>().ReverseMap();
			CreateMap<AppUser,UserUpdateDto>().ReverseMap();
		}
	}
}

