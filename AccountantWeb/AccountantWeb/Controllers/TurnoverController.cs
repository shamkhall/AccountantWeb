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
    public class TurnoverController : Controller
    {
        private readonly AppDbContext _context;

        public TurnoverController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Turnover
        public async Task<IActionResult> Index()
        {
            ViewBag.BagCardId = CardController.CardId;

            return View(await _context.Turnovers.ToListAsync());
        }

        // GET: Turnover/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var turnoverModel = await _context.Turnovers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (turnoverModel == null)
            {
                return NotFound();
            }

            return View(turnoverModel);
        }

        // GET: Turnover/Create
        public IActionResult Create()
        {
            ViewBag.BagCardId = CardController.CardId;

            Console.WriteLine("Card Id " + CardController.CardId);

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CardId,Author,Date,Amount,Currency,Comment,Status")] TurnoverModel turnoverModel)
        {

            foreach (var item in await _context.Cards.ToListAsync())
            {
                if (item.Id == CardController.CardId)
                {
                    if (turnoverModel.Status == "Balansı Artır")
                    {
                        item.Amount += turnoverModel.Amount;
                    }
                    else
                    {
                        item.Amount -= turnoverModel.Amount;
                    }
                    
                }

            }


            if (ModelState.IsValid)
            {
                _context.Add(turnoverModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(turnoverModel);
        }

        
        
       
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
        
            var turnoverModel = await _context.Turnovers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (turnoverModel == null)
            {
                return NotFound();
            }
        
            return View(turnoverModel);
        }
        
        // POST: Turnover/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var turnoverModel = await _context.Turnovers.FindAsync(id);
            _context.Turnovers.Remove(turnoverModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TurnoverModelExists(int id)
        {
            return _context.Turnovers.Any(e => e.Id == id);
        }
    }
}
