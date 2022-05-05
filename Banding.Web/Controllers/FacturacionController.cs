using Banding.Core.Interfaces.Service;
using Banding.Core.Models.Entities.MySql;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using X.PagedList;

namespace Banding.Web.Controllers
{
    public class FacturacionController : Controller
    {
        private readonly IFacturacionService _facturacionService;
        public FacturacionController(IFacturacionService facturacionService)
        {
            _facturacionService = facturacionService;
        }
        public IActionResult Index(int page = 1)
        {
            var facturas = _facturacionService.GetFacturas().ToPagedList(page, 1);
            return View(facturas);
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
        public IActionResult Create([Bind("Id_Producto,Id_Emprendimiento,Nombre_Producto,Precio_Fabricacion,Descripcion,Foto,Stock,Stock_Minimo,Email_Enviado,Fecha_Caducidad,Precio_Venta,Iva")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                _facturacionService.CreateFactura();
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        // POST: Producto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            /*var producto = _productoRepository.GetProductoById(id);
            _productoRepository.DeleteProducto(producto);
            */

            return RedirectToAction(nameof(Index));
        }
    }
}
