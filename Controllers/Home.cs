using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SpringPI.Data;
using SpringPI.Models;

namespace SpringPI.Controllers
{
    public class Spring : Controller
    {
        private readonly SpringPIContext _context;

        public Spring(SpringPIContext context)
        {
            _context = context;
        }
            
        // GET: Furnitures
        public async Task<IActionResult> Index()
        {
            return _context.Furniture != null ?
                        View(await _context.Furniture.ToListAsync()) :
                        Problem("Entity set 'SpringPIContext.Furniture'  is null.");
        }

        // GET: Furnitures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Furniture == null)
            {
                return NotFound();
            }

            var furniture = await _context.Furniture
                .FirstOrDefaultAsync(m => m.Id == id);
            if (furniture == null)
            {
                return NotFound();
            }

            return View(furniture);
        }

        // GET: Furnitures/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Furnitures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Room,Type,Brand,Colour,Price")] Furniture furniture)
        {
            if (ModelState.IsValid)
            {
                _context.Add(furniture);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(furniture);
        }

        // GET: Furnitures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Furniture == null)
            {
                return NotFound();
            }

            var furniture = await _context.Furniture.FindAsync(id);
            if (furniture == null)
            {
                return NotFound();
            }
            return View(furniture);
        }

        // POST: Furnitures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Room,Type,Brand,Colour,Price")] Furniture furniture)
        {
            if (id != furniture.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(furniture);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FurnitureExists(furniture.Id))
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
            return View(furniture);
        }

        // GET: Furnitures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Furniture == null)
            {
                return NotFound();
            }

            var furniture = await _context.Furniture
                .FirstOrDefaultAsync(m => m.Id == id);
            if (furniture == null)
            {
                return NotFound();
            }

            return View(furniture);
        }

        // POST: Furnitures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Furniture == null)
            {
                return Problem("Entity set 'SpringPIContext.Furniture'  is null.");
            }
            var furniture = await _context.Furniture.FindAsync(id);
            if (furniture != null)
            {
                _context.Furniture.Remove(furniture);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FurnitureExists(int id)
        {
            return (_context.Furniture?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
