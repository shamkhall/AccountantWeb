using System.Threading.Tasks;
using AccountantWeb.Model;
using AccountantWeb.Models;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AccountantWeb.Controllers
{
    public class OwnProfitController : Controller
    {
        private readonly AppDbContext _context;

        public OwnProfitController(AppDbContext context)
        {
            _context = context;
        }


        // GET
        public async Task<IActionResult> Index()
        {
            ViewBag.NavOwnIndex = "active";
            ViewBag.NavProfitOpen = "open";
            var model = await _context.Profits.ToListAsync();

            return View(model);
        }

        public async Task<IActionResult> Account()
        {
            ViewBag.NavOwnAccount = "active";
            ViewBag.NavAccountOpen = "open";


            int ProfitResult = 0;
            int ExpencesResult = 0;
            int GainResult = 0;
            int i = 0;
            foreach (var item in await _context.Profits.ToListAsync())
            {
                double d = 1.2;
                if (item.Own)
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