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
    public class DebtsRepaymentController : Controller
    {
        private readonly AppDbContext _context;

        public DebtsRepaymentController(AppDbContext context)
        {
            _context = context;
        }

        // GET: DebtsRepayment
        public async Task<IActionResult> Index()
        {
            ViewBag.DebtsId = DebtsController.DebtsId;

            return View(await _context.DebtRepaymentModels.ToListAsync());
        }

        // GET: DebtsRepayment/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var debtRepaymentModel = await _context.DebtRepaymentModels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (debtRepaymentModel == null)
            {
                return NotFound();
            }

            return View(debtRepaymentModel);
        }

        // GET: DebtsRepayment/Create
        public async Task<IActionResult> Create()
        {
            ViewBag.DebtsId = DebtsController.DebtsId;
            foreach (var item in await _context.Debts.ToListAsync())
            {
                if (item.Id == DebtsController.DebtsId)
                {
                    ViewBag.DebtsAmount = item.Amount;
                    Console.WriteLine("debts" + ViewBag.DebtsAmount);
                    
                }
            }
            
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DebtsId,Author,Date,Amount,Currency,Comment")] DebtRepaymentModel debtRepaymentModel)
        {
            if (ModelState.IsValid)
            {
                foreach (var item in await _context.Debts.ToListAsync())
                {
                    if (item.Id == DebtsController.DebtsId)
                    {
                        ViewBag.DebtsAmount = item.Amount;
                        Console.WriteLine("debts" + ViewBag.DebtsAmount);
                        item.Amount -= debtRepaymentModel.Amount;
                    }
                }
                _context.Add(debtRepaymentModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(debtRepaymentModel);
        }

        
        // GET: DebtsRepayment/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var debtRepaymentModel = await _context.DebtRepaymentModels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (debtRepaymentModel == null)
            {
                return NotFound();
            }

            return View(debtRepaymentModel);
        }

        // POST: DebtsRepayment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var debtRepaymentModel = await _context.DebtRepaymentModels.FindAsync(id);
            _context.DebtRepaymentModels.Remove(debtRepaymentModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DebtRepaymentModelExists(int id)
        {
            return _context.DebtRepaymentModels.Any(e => e.Id == id);
        }
    }
}
