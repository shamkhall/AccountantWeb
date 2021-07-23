using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AccountantWeb.Models;
using EmployeeManagement.Models;

namespace AccountantWeb.Controllers
{
    public class DebtsController : Controller
    {
        private readonly AppDbContext _context;

        public DebtsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Account()
        {
            ViewBag.NavDebtsAccount = "active";
            ViewBag.NavDebtsAccountOpen = "open";
            ViewBag.ReceiptCount = _context.Debts.Count();
            if (!User.IsInRole("Admin"))
                return RedirectToAction("Index", "Home");
            return View(await _context.Debts.ToListAsync());
        }
        

        // GET: Debts
        public async Task<IActionResult> Index()
        {
            ViewBag.NavDebts = "active";
            ViewBag.NavDebtsIndexOpen = "open";
            if (!User.IsInRole("Admin"))
                return RedirectToAction("Index", "Home");
            return View(await _context.Debts.ToListAsync());
        }

        public static int DebtsId;
        public static int DebtsAmount;
        // GET: Debts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewBag.NavDebts = "active";
            ViewBag.NavDebtsIndexOpen = "open";

            DebtsId = id.Value;

            if (id == null)
            {
                return NotFound();
            }

            var debtsModel = await _context.Debts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (debtsModel == null)
            {
                return NotFound();
            }
            if (!User.IsInRole("Admin"))
                return RedirectToAction("Index", "Home");
            return View(debtsModel);
        }

        // GET: Debts/Create
        public IActionResult Create()
        {
            ViewBag.NavDebtsCreate = "active";
            ViewBag.NavCreateOpen = "open";
            ViewBag.NavCreateActive = "active";
            if (!User.IsInRole("Admin"))
                return RedirectToAction("Index", "Home");
            return View();
        }

        // POST: Debts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Author,Name,Date,Amount,Currency,Comment, Percent")] DebtsModel debtsModel)
        {
            if (ModelState.IsValid)
            {
                debtsModel.Amount += (debtsModel.Amount*debtsModel.Percent/100);
                DebtsAmount = debtsModel.Amount;
                _context.Add(debtsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(debtsModel);
        }

        // GET: Debts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.NavDebts = "active";
            ViewBag.NavDebtsIndexOpen = "open";
            if (id == null)
            {
                return NotFound();
            }

            var debtsModel = await _context.Debts.FindAsync(id);
            if (debtsModel == null)
            {
                return NotFound();
            }
            if (!User.IsInRole("Admin"))
                return RedirectToAction("Index", "Home");
            return View(debtsModel);
        }

        // POST: Debts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Author,Name,Date,Amount,Currency,Percent,Comment")] DebtsModel debtsModel)
        {
            if (id != debtsModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(debtsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DebtsModelExists(debtsModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(debtsModel);
        }

        // GET: Debts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            ViewBag.NavDebts = "active";
            ViewBag.NavDebtsIndexOpen = "open";

            if (id == null)
            {
                return NotFound();
            }

            var debtsModel = await _context.Debts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (debtsModel == null)
            {
                return NotFound();
            }
            if (!User.IsInRole("Admin"))
                return RedirectToAction("Index", "Home");
            return View(debtsModel);
        }

        // POST: Debts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var debtsModel = await _context.Debts.FindAsync(id);
            _context.Debts.Remove(debtsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DebtsModelExists(int id)
        {
            return _context.Debts.Any(e => e.Id == id);
        }
    }
}
