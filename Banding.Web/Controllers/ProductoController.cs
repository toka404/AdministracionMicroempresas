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
    public class ProductoController : Controller
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        // GET: Producto
        public async Task<IActionResult> Index(int page = 1)
        {
            return View(_productoRepository.GetProductos().ToPagedList(page, 4));
        }

        // GET: Producto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = _productoRepository.GetProductoById(id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Producto/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Producto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdProducto,IdEmprendimiento,NombreProducto,PrecioFabricacion,Descripcion,Foto,Stock,Stock_Minimo,EmailEnviado,Fecha_Caducidad,PrecioVenta,Iva")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                _productoRepository.CreateProducto(producto);
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        // GET: Producto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = _productoRepository.GetProductoById(id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        // POST: Producto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdProducto,IdEmprendimiento,NombreProducto,PrecioFabricacion,Descripcion,Foto,Stock,Stock_Minimo,EmailEnviado,FechaCaducidad,PrecioVenta,Iva")] Producto producto)
        {
            if (id != producto.IdProducto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _productoRepository.UpdateProducto(producto);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_productoRepository.ProductoExists(producto.IdProducto))
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
            return View(producto);
        }

        // GET: Producto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = _productoRepository.GetProductoById(id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Producto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = _productoRepository.GetProductoById(id);
            _productoRepository.DeleteProducto(producto);
            return RedirectToAction(nameof(Index));
        }
    }
}
