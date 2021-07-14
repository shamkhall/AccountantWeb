using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AccountantWeb.Models;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Authorization;

namespace AccountantWeb.Controllers
{
    
    [Authorize]
    public class NoteController : Controller
    {
        private readonly AppDbContext _context;

        public NoteController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Note
        public async Task<IActionResult> Index(string search)
        {
            Console.WriteLine("search = " + search);
            ViewBag.ControllerName = "Note";
            
            ViewBag.NavNote = "active";
            return View(await _context.Notes.ToListAsync());
        }

        // GET: Note/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewBag.NavNote = "active";
            if (id == null)
            {
                return NotFound();
            }

            var noteModel = await _context.Notes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (noteModel == null)
            {
                return NotFound();
            }

            return View(noteModel);
        }

        // GET: Note/Create
        public IActionResult Create()
        {
            ViewBag.NavNoteCreate = "active";
            ViewBag.NavCreateOpen = "open";
            ViewBag.NavCreateActive = "active";
            return View();
        }

        // POST: Note/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Author,Name,Date,Note,RoleName")] NoteModel noteModel)
        {
            
            
            if (ModelState.IsValid)
            {
                _context.Add(noteModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(noteModel);
        }

        // GET: Note/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.NavNote = "active";
            if (id == null)
            {
                return NotFound();
            }

            var noteModel = await _context.Notes.FindAsync(id);
            if (noteModel == null)
            {
                return NotFound();
            }
            return View(noteModel);
        }

        // POST: Note/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Author,Name,Date,Note,RoleName")] NoteModel noteModel)
        {
            if (id != noteModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(noteModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NoteModelExists(noteModel.Id))
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
            return View(noteModel);
        }

        // GET: Note/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            ViewBag.NavNote = "active";
            
            if (id == null)
            {
                return NotFound();
            }

            var noteModel = await _context.Notes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (noteModel == null)
            {
                return NotFound();
            }

            return View(noteModel);
        }

        // POST: Note/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var noteModel = await _context.Notes.FindAsync(id);
            _context.Notes.Remove(noteModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NoteModelExists(int id)
        {
            return _context.Notes.Any(e => e.Id == id);
        }
    }
}
