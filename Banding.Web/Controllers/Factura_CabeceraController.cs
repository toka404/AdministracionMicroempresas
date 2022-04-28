using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Banding.Core.Models.Entities.MySql;
using Banding.Repository.DataBaseContext;
using Microsoft.AspNetCore.Authorization;

namespace Banding.Web.Controllers
{
    [Authorize(Roles = "admin")]
    public class Factura_CabeceraController : Controller
    {
        private readonly MyDbContext _context;

        public Factura_CabeceraController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Factura_Cabecera
        public async Task<IActionResult> Index()
        {
            return View(await _context.Factura_Cabecera.ToListAsync());
        }

        // GET: Factura_Cabecera/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura_Cabecera = await _context.Factura_Cabecera
                .FirstOrDefaultAsync(m => m.Id_Cabecera == id);
            if (factura_Cabecera == null)
            {
                return NotFound();
            }

            return View(factura_Cabecera);
        }

        // GET: Factura_Cabecera/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Factura_Cabecera/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Cabecera,Id_Iva,Fecha_Cabecera,Nombre_Cliente,Cedula_Cliente,Telefono_Cliente,Direccion_Cliente,Nro_Factura,Subtotal,Iva_Total,Total,Iva_Cero")] Factura_Cabecera factura_Cabecera)
        {
            if (ModelState.IsValid)
            {
                _context.Add(factura_Cabecera);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(factura_Cabecera);
        }

        // GET: Factura_Cabecera/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura_Cabecera = await _context.Factura_Cabecera.FindAsync(id);
            if (factura_Cabecera == null)
            {
                return NotFound();
            }
            return View(factura_Cabecera);
        }

        // POST: Factura_Cabecera/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Cabecera,Id_Iva,Fecha_Cabecera,Nombre_Cliente,Cedula_Cliente,Telefono_Cliente,Direccion_Cliente,Nro_Factura,Subtotal,Iva_Total,Total,Iva_Cero")] Factura_Cabecera factura_Cabecera)
        {
            if (id != factura_Cabecera.Id_Cabecera)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(factura_Cabecera);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Factura_CabeceraExists(factura_Cabecera.Id_Cabecera))
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
            return View(factura_Cabecera);
        }

        // GET: Factura_Cabecera/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var factura_Cabecera = await _context.Factura_Cabecera
                .FirstOrDefaultAsync(m => m.Id_Cabecera == id);
            if (factura_Cabecera == null)
            {
                return NotFound();
            }

            return View(factura_Cabecera);
        }

        // POST: Factura_Cabecera/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var factura_Cabecera = await _context.Factura_Cabecera.FindAsync(id);
            _context.Factura_Cabecera.Remove(factura_Cabecera);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Factura_CabeceraExists(int id)
        {
            return _context.Factura_Cabecera.Any(e => e.Id_Cabecera == id);
        }
    }
}
