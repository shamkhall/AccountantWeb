
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using AccountantWeb.Models;
using EmployeeManagement.Models;

namespace AccountantWeb.Controllers
{
    public class CardController : Controller
    {
        private readonly AppDbContext _context;

        public CardController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Card
        public async Task<IActionResult> Index()
        {

            ViewBag.NavCard = "active";
            
            return View(await _context.Cards.ToListAsync());

        }

        public static int CardId;

        // GET: Card/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewBag.NavCard = "active";

            CardId = id.Value;
            
            Console.WriteLine(CardId);
            if (id == null)
            {
                return NotFound();
            }
            
            var cardModel = await _context.Cards
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cardModel == null)
            {
                return NotFound();
            }

            return View(cardModel);
        }

        // GET: Card/Create
        public IActionResult Create()
        {
            
            ViewBag.NavCardCreate = "active";
            ViewBag.NavCreateOpen = "open";
            ViewBag.NavCreateActive = "active";
            
            
            return View();
        }

        // POST: Card/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RoleName,Author,Name,CardNumber,CVV,EndDate,Amount,Currency")] CardModel cardModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cardModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cardModel);
        }

        // GET: Card/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.NavCard = "active";

            if (id == null)
            {
                return NotFound();
            }

            var cardModel = await _context.Cards.FindAsync(id);
            if (cardModel == null)
            {
                return NotFound();
            }
            return View(cardModel);
        }

        // POST: Card/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RoleName,Author,Name,CardNumber,CVV,EndDate,Amount,Currency")] CardModel cardModel)
        {
            if (id != cardModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cardModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CardModelExists(cardModel.Id))
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
            return View(cardModel);
        }

        // GET: Card/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            ViewBag.NavCard = "active";

            if (id == null)
            {
                return NotFound();
            }

            var cardModel = await _context.Cards
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cardModel == null)
            {
                return NotFound();
            }

            return View(cardModel);
        }

        // POST: Card/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cardModel = await _context.Cards.FindAsync(id);
            _context.Cards.Remove(cardModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CardModelExists(int id)
        {
            return _context.Cards.Any(e => e.Id == id);
        }
    }
}
