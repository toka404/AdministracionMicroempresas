using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banding.Web.Controllers
{
    public class ReporteController : Controller
    {
        private readonly IFacturacionService _facturacionService;
        private readonly IDetalleFacturaRepository _detalleFacturaRepository;
        public ReporteController(IFacturacionService facturacionService,
            IDetalleFacturaRepository detalleFacturaRepository)
        {
            _facturacionService = facturacionService;
            _detalleFacturaRepository = detalleFacturaRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Index(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio != fechaFin)
            {
                ViewData["fechaInicio"] = fechaInicio.ToShortDateString();
                ViewData["fechaFin"] = fechaFin.ToShortDateString();
            }

            int idEmprendimiento = int.Parse(User.Claims.ElementAt(3).Value);

            var facturas = _facturacionService.GetFacturasByEmprendimientoDates(idEmprendimiento, fechaInicio, fechaFin);
            List<int?> cabeceras = new List<int?>();
            foreach (var item in facturas)
            {
                cabeceras.Add(item.CabeceraFactura.IdCabecera);
            }
            var detalles = _detalleFacturaRepository.GetDetallesGroupByProducto(idEmprendimiento).Take(5);
            var detallesDesc = _detalleFacturaRepository.GetDetallesGroupByDescendingProducto(idEmprendimiento).Take(5);

            List<string> nombres = new List<string>();
            List<string> nombresDesc = new List<string>();
            List<int?> cantidades = new List<int?>();
            List<int?> cantidadesDesc = new List<int?>();

            if(detalles.Count() > 0)
            {
                foreach (var item in detalles)
                {
                    foreach (var cabecera in cabeceras)
                    {
                        if (item.Cabecera == cabecera)
                        {
                            nombres.Add(item.Producto);
                            cantidades.Add(item.Cantidad);
                        }
                    }
                }
            }
            

            if (detallesDesc.Count() > 0)
            {

                foreach (var item in detallesDesc)
                {
                    foreach (var cabecera in cabeceras)
                    {
                        if (item.Cabecera == cabecera)
                        {
                            nombresDesc.Add(item.Producto);
                            cantidadesDesc.Add(item.Cantidad);
                        }
                    }
                }
            }

            ViewBag.nombres = nombres;
            ViewBag.cantidades = cantidades;
            ViewBag.nombresDesc = nombresDesc;
            ViewBag.cantidadesDesc = cantidadesDesc;


            return View();
        }
    }
}
