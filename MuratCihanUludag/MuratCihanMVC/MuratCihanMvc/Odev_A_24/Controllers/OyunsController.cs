using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Odev_A_24.Context;
using Odev_A_24.Entities;

namespace Odev_A_24.Controllers
{
    public class OyunsController : Controller
    {
        private readonly OyunDbContext _context;

        public OyunsController(OyunDbContext context)
        {
            _context = context;
        }

        // GET: Oyuns
        public async Task<IActionResult> Index()
        {
            return View(await _context.Oyun.ToListAsync());
        }

        // GET: Oyuns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oyun = await _context.Oyun
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oyun == null)
            {
                return NotFound();
            }

            return View(oyun);
        }

        // GET: Oyuns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Oyuns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Adi,Paltform,tekPaltform")] Oyun oyun)
        {
            if (ModelState.IsValid)
            {
                _context.Add(oyun);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(oyun);
        }

        // GET: Oyuns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oyun = await _context.Oyun.FindAsync(id);
            if (oyun == null)
            {
                return NotFound();
            }
            return View(oyun);
        }

        // POST: Oyuns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Adi,Paltform,BarkodNumarasi,tekPaltform")] Oyun oyun)
        {
            if (id != oyun.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(oyun);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OyunExists(oyun.Id))
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
            return View(oyun);
        }

        // GET: Oyuns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oyun = await _context.Oyun
                .FirstOrDefaultAsync(m => m.Id == id);
            if (oyun == null)
            {
                return NotFound();
            }

            return View(oyun);
        }

        // POST: Oyuns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var oyun = await _context.Oyun.FindAsync(id);
            if (oyun != null)
            {
                _context.Oyun.Remove(oyun);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OyunExists(int id)
        {
            return _context.Oyun.Any(e => e.Id == id);
        }
    }
}
