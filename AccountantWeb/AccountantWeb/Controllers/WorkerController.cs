using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AccountantWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AccountantWeb.Models;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace AccountantWeb.Controllers
{
    public class WorkerController : Controller
    {
        private readonly AppDbContext _context;

        public WorkerController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Worker
        public async Task<IActionResult> Index()
        {
            ViewBag.NavWorkerHome = "active";
            ViewBag.NavProfitOpen = "open";
            
            return View(await _context.Profits.ToListAsync());
        }


        public async Task<IActionResult> Account()
        {
            ViewBag.NavWorkerAccount = "active";
            ViewBag.NavAccountOpen = "open";
            
            
            int ProfitResult = 0;
            int ExpencesResult = 0;
            int GainResult = 0;
            int i = 0;
            foreach (var item in await _context.Profits.ToListAsync())
            {
                double d = 1.2;
                if (item.RoleName == "user" && !item.Own)
                {
                    if (item.Status == Stat.Gəlir)
                    {
                        if (item.Currency == Curr.Dollar)
                        {
                            ProfitResult = ProfitResult + (item.Amount / 17 / 10);
                        }
                        else if (item.Currency == Curr.Avro)
                        {
                            ProfitResult += item.Amount / 2;
                        }
                        else
                        {
                            ProfitResult += item.Amount;
                        }
                    }

                    if (item.Status == Stat.Xərc)
                    {
                        if (item.Currency == Curr.Dollar)
                        {
                            ExpencesResult += (item.Amount * (17 / 10));
                        }
                        else if (item.Currency == Curr.Avro)
                        {
                            ExpencesResult += item.Amount * 2;
                        }
                        else
                        {
                            ExpencesResult += item.Amount;
                        }
                    }

                    i++;
                }

            }
            GainResult = ProfitResult - ExpencesResult;

            ViewBag.ProfitResult = ProfitResult;
            ViewBag.ExpencesResult = ExpencesResult;
            ViewBag.GainResult = GainResult;
            ViewBag.ReceiptCount = i;
            
            return View();
        }

      
    }
}
