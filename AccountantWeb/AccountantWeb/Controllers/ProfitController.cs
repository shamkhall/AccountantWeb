using AccountantWeb.Model;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using AccountantWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace AccountantWeb.Controllers
{
    [Authorize]
    public class ProfitController : Controller
    {
        private readonly IEmployeeRepository _profitRepository;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly AppDbContext _context;


        public ProfitController(IEmployeeRepository employeeRepository,
            IWebHostEnvironment hostingEnvironment, AppDbContext context)
        {
            _profitRepository = employeeRepository;
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }


        public async Task<IActionResult> Account()
        {
            ViewBag.NavProfitAccount = "active";
            ViewBag.NavAccountOpen = "open";


            int profitResult = 0;
            int expencesResult = 0;
            int gainResult = 0;
            int i = 0;
            foreach (var item in await _context.Profits.ToListAsync())
            {
                double d = 1.2;
                if (item.RoleName == "admin" && !item.Own)
                {
                    if (item.Status == Stat.Gəlir)
                    {
                        if (item.Currency == Curr.Dollar)
                        {
                            profitResult = profitResult + (item.Amount / 17 / 10);
                        }
                        else if (item.Currency == Curr.Avro)
                        {
                            profitResult += item.Amount / 2;
                        }
                        else
                        {
                            profitResult += item.Amount;
                        }
                    }

                    if (item.Status == Stat.Xərc)
                    {
                        if (item.Currency == Curr.Dollar)
                        {
                            expencesResult += (item.Amount / 17 * 10);
                        }
                        else if (item.Currency == Curr.Avro)
                        {
                            expencesResult += item.Amount / 2;
                        }
                        else
                        {
                            expencesResult += item.Amount;
                        }
                    }

                    i++;
                }
            }

            gainResult = profitResult - expencesResult;

            ViewBag.ProfitResult = profitResult;
            ViewBag.ExpencesResult = expencesResult;
            ViewBag.GainResult = gainResult;
            ViewBag.ReceiptCountAdmin = i;
            ViewBag.NavHome = "active";
            var model = _profitRepository.GetAllEmployees();
            return View(model);
        }


        public IActionResult Index()
        {
            ViewBag.NavProfitHome = "active";
            ViewBag.NavProfitOpen = "open";
            var model = _profitRepository.GetAllEmployees();
            return View(model);
        }


        public IActionResult Details(int? id)
        {
            ViewBag.NavProfitDetails = "active";
            Profit profit = _profitRepository.GetEmployee(id.Value);

            return View(profit);
        }


        [HttpGet]
        public ViewResult Edit(int id)
        {
            ViewBag.NavProfitEdit = "active";
            var model = _profitRepository.GetEmployee(id);

            return View(model);
        }


        [HttpPost]
        public IActionResult Edit(Profit model)
        {
            Console.WriteLine("Edit");
            if (ModelState.IsValid)
            {
                Console.WriteLine("Edit 2");

                Profit profit = _profitRepository.GetEmployee(model.Id);
                profit.RoleName = model.RoleName;
                profit.Author = model.Author;
                profit.Name = model.Name;
                profit.Date = model.Date;
                profit.Amount = model.Amount;
                profit.Currency = model.Currency;
                profit.Status = model.Status;
                profit.Comment = model.Comment;
                profit.Own = model.Own;


                _profitRepository.Update(profit);
                if (model.Own)
                {
                    return RedirectToAction("Index", "OwnProfit");
                }
                else if (model.RoleName == "user")
                {
                    return RedirectToAction("index", "Worker");

                }
                else
                {
                    return RedirectToAction("Index");
                }
            }

            return View();
        }


        [HttpGet]
        public IActionResult Delete(int? id)
        {
            ViewBag.NavProfitDelete = "active";
            var model = _profitRepository.GetEmployee(id.Value);
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            Profit model = _profitRepository.Delete(id);
            if (model.Own)
            {
                return RedirectToAction("Index", "OwnProfit");
            }
            else if (model.RoleName == "user")
            {
                return RedirectToAction("index", "Worker");

            }
            else
            {
                return RedirectToAction("Index");
            }
        }


        [HttpGet]
        public ViewResult Create()
        {
            ViewBag.NavProfitCreate = "active";
            ViewBag.NavCreateOpen = "open";
            ViewBag.NavCreateActive = "active";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Profit model)
        {
            if (ModelState.IsValid)
            {
                Profit newProfit = new Profit()
                {
                    RoleName = model.RoleName,
                    Author = model.Author,
                    Name = model.Name,
                    Date = model.Date,
                    Amount = model.Amount,
                    Currency = model.Currency,
                    Status = model.Status,
                    Comment = model.Comment,
                    Own = model.Own
                };
                _profitRepository.Add(newProfit);
                if (model.RoleName == "user")
                {
                    var item = await _context.Profits.ToListAsync();


                    return RedirectToAction("index", "Worker");
                }
                else if (model.Own)
                {
                    return RedirectToAction("index", "OwnProfit");

                }
                else
                {
                    ViewBag.UserAuthor = "model.Author";

                    Console.WriteLine(model.Author);

                    //Console.WriteLine(model.RoleName);
                    return RedirectToAction("index");
                }
            }

            return View();
        }
    }
}