using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ANK15Identity;
using ANK15Identity.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace ANK15Identity.Controllers
{
    public class RolController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        //Rol işlemleri için role manager'ı kullanacağız
        public RolController(RoleManager<IdentityRole> roleManager)
        {

            _roleManager = roleManager;
        }

        // GET: Rol
        public async Task<IActionResult> Index()
        {
            //Bütün rolleri getir ve görünüme model olarak gönder
            return View(await _roleManager.Roles.ToListAsync());
        }

        // GET: Rol/Details/5
        public async Task<IActionResult> Details(string id)
        {

            var rol = await _roleManager.Roles.FirstOrDefaultAsync(r => r.Id == id);
            if (rol == null)
            {
                return NotFound();
            }

            return View(rol);
        }

        // GET: Rol/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rol/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] IdentityRole rol)
        {
            if (ModelState.IsValid)
            {

                await _roleManager.CreateAsync(rol);


                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Rol/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rol = await _roleManager.FindByIdAsync(id);
            if (rol == null)
            {
                return NotFound();
            }
            return View(rol);
        }

        // POST: Rol/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, IdentityRole rol)
        {
            if (id != rol.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _roleManager.UpdateAsync(rol);

                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(rol);
        }

        // GET: Rol/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rol = await _roleManager.Roles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rol == null)
            {
                return NotFound();
            }

            return View(rol);
        }

        // POST: Rol/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
         
            var rol = await _roleManager.FindByIdAsync(id);
            if (rol != null)
            {
                await _roleManager.DeleteAsync(rol);
            }

            
            return RedirectToAction(nameof(Index));
        }


    }
}
