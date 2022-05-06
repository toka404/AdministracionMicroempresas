using Banding.Core.Interfaces.Service;
using Banding.Core.Models.Entities.MySql;
using Banding.Core.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
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
            int idEmprendimiento = int.Parse(User.Claims.ElementAt(3).Value);

            var facturas = _facturacionService.GetFacturasByEmprendimiento(idEmprendimiento).ToPagedList(page, 1);
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
        public IActionResult Create(string NroFactura, FacturaViewModel factura)
        {
            if (ModelState.IsValid)
            {
                _facturacionService.CreateFactura();
                return RedirectToAction(nameof(Index));
            }
            return View(factura);
        }

        // POST: Producto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed()
        {
            /*var producto = _productoRepository.GetProductoById(id);
            _productoRepository.DeleteProducto(producto);
            */


            return RedirectToAction(nameof(Index));
        }
    }
}
