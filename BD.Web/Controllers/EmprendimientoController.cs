using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BD.Web.Data;

namespace BD.Web.Controllers
{
    public class EmprendimientoController : Controller
    {
        private readonly MyDbContext _context;

        public EmprendimientoController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Emprendimiento
        public async Task<IActionResult> Index()
        {
            return View(await _context.Emprendimiento.ToListAsync());
        }

        // GET: Emprendimiento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emprendimiento = await _context.Emprendimiento
                .FirstOrDefaultAsync(m => m.Id_Emprendimiento == id);
            if (emprendimiento == null)
            {
                return NotFound();
            }

            return View(emprendimiento);
        }

        // GET: Emprendimiento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Emprendimiento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Emprendimiento,Id_Categoria,Nombre_Emprendimiento,Descripcion_Emprendimiento,Logo")] Emprendimiento emprendimiento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emprendimiento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(emprendimiento);
        }

        // GET: Emprendimiento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emprendimiento = await _context.Emprendimiento.FindAsync(id);
            if (emprendimiento == null)
            {
                return NotFound();
            }
            return View(emprendimiento);
        }

        // POST: Emprendimiento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Emprendimiento,Id_Categoria,Nombre_Emprendimiento,Descripcion_Emprendimiento,Logo")] Emprendimiento emprendimiento)
        {
            if (id != emprendimiento.Id_Emprendimiento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emprendimiento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmprendimientoExists(emprendimiento.Id_Emprendimiento))
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
            return View(emprendimiento);
        }

        // GET: Emprendimiento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emprendimiento = await _context.Emprendimiento
                .FirstOrDefaultAsync(m => m.Id_Emprendimiento == id);
            if (emprendimiento == null)
            {
                return NotFound();
            }

            return View(emprendimiento);
        }

        // POST: Emprendimiento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var emprendimiento = await _context.Emprendimiento.FindAsync(id);
            _context.Emprendimiento.Remove(emprendimiento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmprendimientoExists(int id)
        {
            return _context.Emprendimiento.Any(e => e.Id_Emprendimiento == id);
        }
    }
}
