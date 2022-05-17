using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Interfaces.Service;
using Banding.Core.Models.Entities.MySql;
using Banding.Core.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Banding.Web.Controllers
{
    [Authorize]
    public class FacturacionController : Controller
    {
        private readonly IFacturacionService _facturacionService;
        private readonly IFacturaCabeceraRepository _facturaCabeceraRepository;
        private readonly IProductoRepository _productoRepository;
        public FacturacionController(IFacturacionService facturacionService,
            IFacturaCabeceraRepository facturaCabeceraRepository,
            IProductoRepository productoRepository)
        {
            _facturacionService = facturacionService;
            _facturaCabeceraRepository = facturaCabeceraRepository;
            _productoRepository = productoRepository;
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
            int idEmprendimiento = int.Parse(User.Claims.ElementAt(3).Value);
            List<int> cantidades = new List<int>();

            var productos = _productoRepository.GetProductosByEmprendimiento(idEmprendimiento);
            ViewBag.productos = productos;
            foreach (var producto in productos)
            {
                cantidades.Add(producto.Stock);
            }
            ViewBag.cantidades = cantidades;

            return View();
        }

        // POST: Producto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("IdIva,FechaCabecera,NombreCliente,CedulaCliente,TelefonoCliente, DireccionCliente, DetalleFactuas, NroFactura, IvaTotal, IvaCero")] FacturaCabecera factura)
        {


            if (ModelState.IsValid)
            {
                factura.Subtotal = 1;
                factura.Total = 1;

                _facturaCabeceraRepository.CreateFacturaCabecera(factura);
                return RedirectToAction(nameof(Index));
            }
            return View(factura);
        }

        // POST: Producto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int IdCabecera)
        {
            _facturaCabeceraRepository.DeleteFacturaCabecera(IdCabecera);

            return RedirectToAction(nameof(Index));
        }
    }
}
