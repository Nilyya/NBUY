using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ShoppingApp.Core;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.Areas.Admin.Models.Dtos;
using ShoppingApp.Web.EmailServices.Abstract;

namespace ShoppingApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IEmailSender _emailSender;

        public UserController(UserManager<User> userManager, RoleManager<Role> roleManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _emailSender = emailSender;
        }

        public IActionResult Index()
        {
            List<UserDto> users = _userManager.Users.Select(u => new UserDto
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                UserName = u.UserName,
                Email = u.Email,
                EmailConfirmed = u.EmailConfirmed
            }).ToList();

            ViewBag.SelectedMenu = "User";
            return View(users);
        }

        public IActionResult Create()
        {
            UserAddDto userAddDto = new UserAddDto
            {
                Roles = _roleManager.Roles.Select(r => new RoleDto
                {
                    Id = r.Id,
                    Name = r.Name,
                    Description = r.Description
                }).ToList(),
                SelectedRoles = new List<string>()
            };
            return View(userAddDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserAddDto userAddDto)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    FirstName = userAddDto.UserDto.FirstName,
                    LastName = userAddDto.UserDto.LastName,
                    UserName = userAddDto.UserDto.UserName,
                    Email = userAddDto.UserDto.Email,
                    EmailConfirmed = userAddDto.UserDto.EmailConfirmed
                };
                var result = await _userManager.CreateAsync(user, "Qwe123.");
                if (result.Succeeded)
                {
                    await _userManager.AddToRolesAsync(user, userAddDto.SelectedRoles);
                    TempData["Message"] = Jobs.CreateMessage("Başarılı", $"{user.UserName} kullanıcısı oluşturuldu.", "success");

                    return RedirectToAction("Index", "User");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            userAddDto.Roles = _roleManager.Roles.Select(r => new RoleDto
            {
                Id = r.Id,
                Name = r.Name,
                Description = r.Description
            }).ToList();
            userAddDto.SelectedRoles = userAddDto.SelectedRoles ?? new List<string>();
            return View(userAddDto);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) { return NotFound(); }

            UserAddDto userUpdateDto = new UserAddDto
            {
                UserDto = new UserDto
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    UserName = user.UserName,
                    Email = user.Email,
                    EmailConfirmed = user.EmailConfirmed
                },
                SelectedRoles = await _userManager.GetRolesAsync(user),
                Roles = _roleManager.Roles.Select(r => new RoleDto
                {
                    Id = r.Id,
                    Name = r.Name,
                    Description = r.Description
                }).ToList()
            };

            return View(userUpdateDto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserAddDto userUpdateDto)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(userUpdateDto.UserDto.Id);

                if (user == null) { return NotFound(); }

                user.FirstName = userUpdateDto.UserDto.FirstName;
                user.LastName = userUpdateDto.UserDto.LastName;
                user.UserName = userUpdateDto.UserDto.UserName;
                user.Email = userUpdateDto.UserDto.Email;
                user.EmailConfirmed = userUpdateDto.UserDto.EmailConfirmed;

                var result = await _userManager.UpdateAsync(user);
                if (!result.Succeeded) { return NotFound(); }

                var userRoles = await _userManager.GetRolesAsync(user);
                await _userManager.AddToRolesAsync(user, userUpdateDto.SelectedRoles.Except(userRoles).ToList<string>());
                await _userManager.RemoveFromRolesAsync(user, userRoles.Except(userUpdateDto.SelectedRoles).ToList<string>());

                TempData["Message"] = Jobs.CreateMessage("Başarılı", $"{user.UserName} kullanıcısı güncellendi.", "success");
                return RedirectToAction("Index", "User");
            }
            userUpdateDto.Roles = _roleManager.Roles.Select(r => new RoleDto
            {
                Id = r.Id,
                Name = r.Name,
                Description = r.Description
            }).ToList();

            userUpdateDto.SelectedRoles = userUpdateDto.SelectedRoles ?? new List<string>();
            return View(userUpdateDto);
        }
    }
}