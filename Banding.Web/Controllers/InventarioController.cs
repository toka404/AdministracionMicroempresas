using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Models.Entities.MySql;
using Banding.Repository.DataBaseContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Banding.Web.Controllers
{
    [Authorize]
    public class InventarioController : Controller
    {
        private readonly IProductoRepository _productoRepository;
        public InventarioController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }
        public IActionResult Index()
        {
            var productos = _productoRepository.GetProductos().Where(p => p.Id_Emprendimiento == Convert.ToInt32(User.Claims.ElementAt(3).Value)).ToList();
            return View(productos);
        }

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
        public async Task<IActionResult> Create([Bind("Id_Producto,Id_Emprendimiento,Nombre_Producto,Precio_Fabricacion,Descripcion,Foto,Stock,Stock_Minimo,Email_Enviado,Fecha_Caducidad,Precio_Venta,Iva")] Producto producto)
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
        public async Task<IActionResult> Edit(int id, [Bind("Id_Producto,Id_Emprendimiento,Nombre_Producto,Precio_Fabricacion,Descripcion,Foto,Stock,Stock_Minimo,Email_Enviado,Fecha_Caducidad,Precio_Venta,Iva")] Producto producto)
        {
            if (id != producto.Id_Producto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (producto.Email_Enviado.Equals("1") && producto.Stock_Minimo<producto.Stock)
                    {
                        producto.Email_Enviado = "0";
                    }
                    _productoRepository.UpdateProducto(producto);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_productoRepository.ProductoExists(producto.Id_Producto))
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
