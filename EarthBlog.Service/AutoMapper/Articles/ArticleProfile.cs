using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EarthBlog.Entity.DTOs.Articles;
using EarthBlog.Entity.Entities;

namespace EarthBlog.Service.AutoMapper.Articles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile() 
        {
            CreateMap<ArticleDto, Article>().ReverseMap();
            CreateMap<ArticleUpdateDto, Article>().ReverseMap();
            CreateMap<ArticleUpdateDto, ArticleDto>().ReverseMap();
		}
    }
}
