﻿using System.Data;
using AutoMapper;
using EarthBlog.Entity.DTOs.Articles;
using EarthBlog.Entity.DTOs.Users;
using EarthBlog.Entity.Entities;
using EarthBlog.Web.ResultMessages;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;

namespace EarthBlog.Web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class UserController : Controller
	{
		private readonly UserManager<AppUser> userManager;
		private readonly RoleManager<AppRole> roleManager;
		private readonly IMapper mapper;
		private readonly IToastNotification toastNotification;

		public UserController(UserManager<AppUser> userManager,RoleManager<AppRole> roleManager, IMapper mapper,IToastNotification toastNotification)
        {
			this.userManager = userManager;
			this.roleManager = roleManager;
			this.mapper = mapper;
			this.toastNotification = toastNotification;
		}
        public async Task<IActionResult> Index()
		{
			var users = await userManager.Users.ToListAsync();
			var map = mapper.Map<List<UserDto>>(users);
			foreach(var item in map)
			{
				var findUser = await userManager.FindByIdAsync(item.Id.ToString());
				var role =string.Join("",await userManager.GetRolesAsync(findUser));

				item.Role = role;
			}
			return View(map);
		}
		[HttpGet]
		public async Task<IActionResult> Add()
		{
			var roles = await roleManager.Roles.ToListAsync();
			return View(new UserAddDto { Roles = roles });
		}
		[HttpPost]
		public async Task<IActionResult> Add(UserAddDto userAddDto)
		{
			var map = mapper.Map<AppUser>(userAddDto);
			var roles = await roleManager.Roles.ToListAsync();

			if(ModelState.IsValid)
			{
				map.UserName = userAddDto.Email;
				var result = await userManager.CreateAsync(map, string.IsNullOrEmpty(userAddDto.Password) ? "" : userAddDto.Password);
				if(result.Succeeded)
				{
					var findRole = await roleManager.FindByIdAsync(userAddDto.RoleId.ToString());
					await userManager.AddToRoleAsync(map, findRole.ToString());
					toastNotification.AddSuccessToastMessage(Messages.User.Add(userAddDto.Email), new ToastrOptions { Title = "İşlem Başarılı" });
					return RedirectToAction("Index", "User", new { Area = "Admin" });
				}
				else
				{
					foreach(var errors in result.Errors)
						ModelState.AddModelError("",errors.Description);
					return View(new UserAddDto { Roles = roles });

				}
			}
			return View(new UserAddDto { Roles = roles });
		}
	}
}
