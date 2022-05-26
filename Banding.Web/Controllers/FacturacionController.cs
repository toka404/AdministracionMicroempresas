using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Interfaces.Service;
using Banding.Core.Models.Entities.MySql;
using Banding.Core.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private readonly IIvaRepository _ivaRepository;
        public FacturacionController(IFacturacionService facturacionService,
            IFacturaCabeceraRepository facturaCabeceraRepository,
            IProductoRepository productoRepository,
            IIvaRepository ivaRepository)
        {
            _facturacionService = facturacionService;
            _facturaCabeceraRepository = facturaCabeceraRepository;
            _productoRepository = productoRepository;
            _ivaRepository = ivaRepository;
        }
        public IActionResult Index(int page = 1)
        {
            int idEmprendimiento = int.Parse(User.Claims.ElementAt(3).Value);

            var facturas = _facturacionService.GetFacturasByEmprendimiento(idEmprendimiento).ToPagedList(page, 1);
            return View(facturas);
        }
        // GET: Producto/Create
        public IActionResult Create(FacturaCabecera factura)
        {
            int idEmprendimiento = int.Parse(User.Claims.ElementAt(3).Value);
            List<int> cantidades = new List<int>();
            List<decimal> precios = new List<decimal>();

            var productos = _productoRepository.GetProductosByEmprendimientoAvailable(idEmprendimiento);
            ViewBag.productos = productos;
            foreach (var producto in productos)
            {
                cantidades.Add(producto.Stock);
                precios.Add(producto.PrecioVenta);
            }
            ViewBag.cantidades = cantidades;
            ViewBag.precios = precios;
            ViewData["IdIva"] = new SelectList(_ivaRepository.GetIvas(), "IdIva", "ValorIva");

            if (factura.NombreCliente != null)
            {
                return View(factura);
            }

            return View();
        }

        // POST: Producto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(int asd, decimal Subtotal,
            [Bind("Subtotal,Total,IdIva,FechaCabecera,NombreCliente,CedulaCliente,TelefonoCliente," +
            "DireccionCliente, DetalleFactuas, NroFactura, IvaTotal, IvaCero")] FacturaCabecera factura,
            [Bind("Cantidades, IdProductos, PrecioTotales")] FacturaViewModel facturaViewModel
            )
        {
            int idEmprendimiento = int.Parse(User.Claims.ElementAt(3).Value);

            if (ModelState.IsValid)
            {
                List<Producto> productosUpdate = new List<Producto>();
                var detallesFactura = new List<DetalleFactura>();
                int contador = 0;

                foreach (var item in facturaViewModel.IdProductos)
                {
                    detallesFactura.Add(new DetalleFactura
                    {
                        CantidadVendida = facturaViewModel.Cantidades[contador],
                        IdProducto = facturaViewModel.IdProductos[contador],
                        PrecioTotal = facturaViewModel.PrecioTotales[contador]
                    });

                    var producto = _productoRepository.GetProductoById(facturaViewModel.IdProductos[contador]);
                    producto.Stock = producto.Stock - facturaViewModel.Cantidades[contador];
                    if (producto.Stock < 0)
                    {
                        factura.Subtotal = -1;
                        break;
                    }
                    productosUpdate.Add(producto);
                    contador++;
                }
                if (factura.Subtotal != -1)
                {
                    foreach (var p in productosUpdate)
                    {
                        _productoRepository.UpdateProducto(p);
                    }

                    var facturas = _facturacionService.GetFacturasByEmprendimientoAll(idEmprendimiento);
                    int n = 1;


                    if (facturas.Count() > 0)
                    {
                        n = facturas.Max(f => f.CabeceraFactura.NroFactura) + 1;
                    }

                    factura.DetalleFacturas = detallesFactura;
                    factura.NroFactura = n;



                    _facturaCabeceraRepository.CreateFacturaCabecera(factura);
                    return RedirectToAction(nameof(Index));
                }

            } 
            return RedirectToAction("Index","Facturacion");
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
