using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ODEV_A_26.Data;
using ODEV_A_26.Entities;

namespace ODEV_A_26.Controllers
{
    public class CihazsController : Controller
    {
        private readonly ODEV_A_26Context _context;

        public CihazsController(ODEV_A_26Context context)
        {
            _context = context;
        }

        // GET: Cihazs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cihaz.ToListAsync());
        }

        // GET: Cihazs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cihaz = await _context.Cihaz
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cihaz == null)
            {
                return NotFound();
            }

            return View(cihaz);
        }

        // GET: Cihazs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cihazs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ad,Fiyat,ArzaDurumu")] Cihaz cihaz)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cihaz);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cihaz);
        }

        // GET: Cihazs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cihaz = await _context.Cihaz.FindAsync(id);
            if (cihaz == null)
            {
                return NotFound();
            }
            return View(cihaz);
        }

        // POST: Cihazs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ad,Fiyat,ArzaDurumu")] Cihaz cihaz)
        {
            if (id != cihaz.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cihaz);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CihazExists(cihaz.Id))
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
            return View(cihaz);
        }

        // GET: Cihazs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cihaz = await _context.Cihaz
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cihaz == null)
            {
                return NotFound();
            }

            return View(cihaz);
        }

        // POST: Cihazs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cihaz = await _context.Cihaz.FindAsync(id);
            if (cihaz != null)
            {
                _context.Cihaz.Remove(cihaz);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CihazExists(int id)
        {
            return _context.Cihaz.Any(e => e.Id == id);
        }
    }
}
