using System;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace AccountantWeb.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext _context;

        public SearchController(AppDbContext context)
        {
            _context = context;
        }

        
        public void Search([FromQuery(Name = "query")] string query)
        {
            Console.WriteLine("query "+query);
            
        }

        // POST
        
    }
}