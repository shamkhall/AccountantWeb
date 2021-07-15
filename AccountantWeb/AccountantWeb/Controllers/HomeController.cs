using AccountantWeb.Model;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;

namespace AccountantWeb.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        
        private readonly IEmployeeRepository _profitRepository;
        private readonly AppDbContext _context;
        
        public HomeController(IEmployeeRepository employeeRepository, 
                                AppDbContext context) 
        {
            _profitRepository = employeeRepository;
            _context = context;
        }

        [HttpPost]
        public IActionResult CultureManagement(string culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return LocalRedirect(returnUrl);
        }
      
        
        public ViewResult Index()
        {
            ViewBag.NavHome = "active";
            ViewBag.NoteCount = _context.Notes.Count();
            var model = _profitRepository.GetAllEmployees();
            return View(model);
        }

    }
}
