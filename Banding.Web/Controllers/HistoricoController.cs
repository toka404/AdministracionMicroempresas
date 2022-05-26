using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Interfaces.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Banding.Web.Controllers
{
    [Authorize]

    public class HistoricoController : Controller
    {
        private readonly IFacturacionService _facturacionService;
        private readonly IDetalleFacturaRepository _detalleFacturaRepository;
        public HistoricoController(IFacturacionService facturacionService,
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
        public async Task<IActionResult> Index(DateTime fechaInicio, DateTime fechaFin, string search, int page = 1)
        {
            if (fechaInicio != null && fechaFin != null)
            {
                ViewData["fechaInicio"] = fechaInicio.ToShortDateString();
                ViewData["fechaFin"] = fechaFin.ToShortDateString();

            }
            int idEmprendimiento = int.Parse(User.Claims.ElementAt(3).Value);
            var facturas = _facturacionService.GetFacturasByEmprendimientoDates(idEmprendimiento, fechaInicio, fechaFin);

            /*if (!string.IsNullOrEmpty(search))
            {
                ViewData["search"] = search;

                var facturass = _facturacionService.GetFacturasByEmprendimientoDatesNombres(idEmprendimiento, fechaInicio, fechaFin, search);
                return View(facturass);
            }*/

            return View(facturas);
        }

    }
}
