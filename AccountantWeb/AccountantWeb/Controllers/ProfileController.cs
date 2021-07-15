
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AccountantWeb.Models;
using AccountantWeb.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AccountantWeb.Controllers
{
    public class ProfileController : Controller
    {

        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProfileController(SignInManager<ApplicationUser> signInManager,
                                UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Details()
        {
            ViewBag.NavProfile = "active";

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            ViewBag.UserId = userId;
            
            var model = new EditUserViewModel()
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                
                
            };
            
            
            return View(model);
        }
        
        
        // GET
        [HttpGet]
        public async Task<IActionResult> Profile()
        {

            ViewBag.NavProfile = "active";
            
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            IList<string> userRoles = await _userManager.GetRolesAsync(user);
            
            ViewBag.UserId = userId;
            
            
            Console.WriteLine("UserId -- " + userId);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = user cannot be found";
                return View("NotFound");
            }
            
            var model = new EditUserViewModel()
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                Roles = userRoles
                
            };

            
            
            return View(model);
        }
        
        
        [HttpPost]
        public async Task<IActionResult> Profile(EditUserViewModel model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {userId} cannot be found";
                return View("NotFound");
            }
            else
            {
                user.Email = model.Email;
                user.UserName = model.UserName;

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Details");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                
                return View(model);
            }

        }
        
        [HttpPost]
        public async Task<IActionResult> DeleteProfile()
        {
            Console.WriteLine("Delete User");
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.UserId = userId;

            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {userId} cannot be found";
                return View("NotFound");
            }
            else
            {
               
                var result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    await _signInManager.SignOutAsync();
                    return RedirectToAction("Login", "Account");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                
                return View("Profile");
            }

        }
        
        
    }
}