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
    public class IvaController : Controller
    {
        private readonly MyDbContext _context;

        public IvaController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Iva
        public async Task<IActionResult> Index()
        {
            return View(await _context.Iva.ToListAsync());
        }

        // GET: Iva/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iva = await _context.Iva
                .FirstOrDefaultAsync(m => m.Id_Iva == id);
            if (iva == null)
            {
                return NotFound();
            }

            return View(iva);
        }

        // GET: Iva/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Iva/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Iva,Valor_Iva")] Iva iva)
        {
            if (ModelState.IsValid)
            {
                _context.Add(iva);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(iva);
        }

        // GET: Iva/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iva = await _context.Iva.FindAsync(id);
            if (iva == null)
            {
                return NotFound();
            }
            return View(iva);
        }

        // POST: Iva/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Iva,Valor_Iva")] Iva iva)
        {
            if (id != iva.Id_Iva)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(iva);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IvaExists(iva.Id_Iva))
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
            return View(iva);
        }

        // GET: Iva/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iva = await _context.Iva
                .FirstOrDefaultAsync(m => m.Id_Iva == id);
            if (iva == null)
            {
                return NotFound();
            }

            return View(iva);
        }

        // POST: Iva/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var iva = await _context.Iva.FindAsync(id);
            _context.Iva.Remove(iva);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IvaExists(int id)
        {
            return _context.Iva.Any(e => e.Id_Iva == id);
        }
    }
}
