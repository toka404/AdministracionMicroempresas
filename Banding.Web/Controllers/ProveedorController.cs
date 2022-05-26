using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Banding.Core.Models.Entities.MySql;
using Banding.Repository.MySql;
using Microsoft.AspNetCore.Authorization;
using Banding.Core.Interfaces.Repository.MySql;
using X.PagedList;

namespace Banding.Web.Controllers
{
    [Authorize(Roles = "admin")]
    public class ProveedorController : Controller
    {
        private readonly IProveedorRepository _proveedorRepository;
        private readonly IProvinciaRepository _provinciaRepository;

        public ProveedorController(IProveedorRepository proveedorRepository,
            IProvinciaRepository provinciaRepository)
        {
            _provinciaRepository = provinciaRepository;
            _proveedorRepository = proveedorRepository;
        }

        // GET: Proveedor
        public async Task<IActionResult> Index(int page = 1)
        {
            return View(_proveedorRepository.GetProveedores().ToPagedList(page, 5));
        }

        // GET: Proveedor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proveedor = _proveedorRepository.GetProveedorById(id);
            if (proveedor == null)
            {
                return NotFound();
            }

            return View(proveedor);
        }

        // GET: Proveedor/Create
        public IActionResult Create()
        {
            ViewData["IdProvincia"] = new SelectList(_provinciaRepository.GetProvincias(), "IdProvincia", "NombreProvincia");
            return View();
        }

        // POST: Proveedor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdProveedor,IdProvincia,NombreProveedor,Telefono,EMailProveedor,Producto,RUC")] Proveedor proveedor)
        {
            if (ModelState.IsValid)
            {
                _proveedorRepository.CreateProveedor(proveedor);
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdProvincia"] = new SelectList(_provinciaRepository.GetProvincias(), "IdProvincia", "NombreProvincia", proveedor.IdProvincia);
            return View(proveedor);
        }

        // GET: Proveedor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proveedor = _proveedorRepository.GetProveedorById(id);
            if (proveedor == null)
            {
                return NotFound();
            }
            ViewData["IdProvincia"] = new SelectList(_provinciaRepository.GetProvincias(), "IdProvincia", "NombreProvincia", proveedor.IdProvincia);

            return View(proveedor);
        }

        // POST: Proveedor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdProveedor,IdProvincia,NombreProveedor,Telefono,EMailProveedor,Producto,Ruc")] Proveedor proveedor)
        {
            if (id != proveedor.IdProveedor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _proveedorRepository.UpdateProveedor(proveedor);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_proveedorRepository.ProveedorExists(proveedor.IdProveedor))
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
            ViewData["IdProvincia"] = new SelectList(_provinciaRepository.GetProvincias(), "IdProvincia", "NombreProvincia", proveedor.IdProvincia);
            return View(proveedor);
        }

        // GET: Proveedor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proveedor = _proveedorRepository.GetProveedorById(id);
            if (proveedor == null)
            {
                return NotFound();
            }

            return View(proveedor);
        }

        // POST: Proveedor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proveedor = _proveedorRepository.GetProveedorById(id);
            _proveedorRepository.DeleteProveedor(proveedor);
            return RedirectToAction(nameof(Index));
        }
    }
}
