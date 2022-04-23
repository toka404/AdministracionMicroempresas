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
using Banding.Core.Interfaces.Repository.MySql;

namespace Banding.Web.Controllers
{
    [Authorize]
    public class ProveedorController : Controller
    {
        private readonly IProveedorRepository _proveedorRepository;

        public ProveedorController(IProveedorRepository proveedorRepository)
        {
            _proveedorRepository = proveedorRepository;
        }

        // GET: Proveedor
        public async Task<IActionResult> Index()
        {
            return View(_proveedorRepository.GetProveedores());
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
            return View();
        }

        // POST: Proveedor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Proveedor,Id_Provincia,Nombre_Proveedor,Telefono,E_Mail_Proveedor,Producto,RUC")] Proveedor proveedor)
        {
            if (ModelState.IsValid)
            {
                _proveedorRepository.CreateProveedor(proveedor);
                return RedirectToAction(nameof(Index));
            }
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
            return View(proveedor);
        }

        // POST: Proveedor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Proveedor,Id_Provincia,Nombre_Proveedor,Telefono,E_Mail_Proveedor,Producto,RUC")] Proveedor proveedor)
        {
            if (id != proveedor.Id_Proveedor)
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
                    if (!_proveedorRepository.ProveedorExists(proveedor.Id_Proveedor))
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
