using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Interfaces.Service;
using Banding.Core.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Service.Services
{
    public class FacturacionService : IFacturacionService
    {
        private readonly IIvaRepository _ivaRepository;
        private readonly IProductoRepository _productoRepository;
        private readonly IFacturaCabeceraRepository _facturaCabeceraRepository;
        private readonly IDetalleFacturaRepository _detalleFacturaRepository;


        public FacturacionService(
            IIvaRepository ivaRepository,
            IProductoRepository productoRepository,
            IFacturaCabeceraRepository facturaCabeceraRepository,
            IDetalleFacturaRepository detalleFacturaRepository)
        {
            _ivaRepository = ivaRepository;
            _productoRepository = productoRepository;
            _facturaCabeceraRepository = facturaCabeceraRepository;
            _detalleFacturaRepository = detalleFacturaRepository;
        }

        public List<FacturaViewModel> GetFacturasByEmprendimiento(int idEmprendimiento)
        {
            List<FacturaViewModel> _facturas;
            _facturas = new List<FacturaViewModel>();

            var cabecerasFactura = _facturaCabeceraRepository.GetFacturaCabeceras();

            foreach (var cabecera in cabecerasFactura)
            {
                List<DetalleFacturaViewModel> detalles = new List<DetalleFacturaViewModel>();

                foreach (var detalle in cabecera.DetalleFacturas)
                {
                    DetalleFacturaViewModel detalleAux = new DetalleFacturaViewModel();

                    var productoAux = _productoRepository.GetProductoById(detalle.IdProducto);
                    if (productoAux.IdEmprendimiento == idEmprendimiento)
                    {
                        detalleAux.NombreProducto = productoAux.NombreProducto;
                        detalleAux.CantidadVendida = detalle.CantidadVendida;
                        detalleAux.PrecioUnitario = productoAux.PrecioVenta;
                        detalleAux.PrecioTotal = detalle.PrecioTotal;
                        detalles.Add(detalleAux);
                    }
                }

                if (detalles.Count() > 0)
                {
                    FacturaViewModel facturaAux = new FacturaViewModel();
                    facturaAux.CabeceraFactura = cabecera;
                    facturaAux.Iva = _ivaRepository.GetIvaById(facturaAux.CabeceraFactura.IdIva).ValorIva;

                    facturaAux.DetalleFactura = detalles;
                    _facturas.Add(facturaAux);
                }
            }
            return _facturas;
        }
        public List<FacturaViewModel> GetFacturasByEmprendimientoDates(int idEmprendimiento, DateTime fechaInicio, DateTime fechaFin)
        {
            List<FacturaViewModel> _facturas;
            _facturas = new List<FacturaViewModel>();

            var cabecerasFactura = _facturaCabeceraRepository.GetFacturaCabecerasByDates(fechaInicio, fechaFin);

            foreach (var cabecera in cabecerasFactura)
            {
                List<DetalleFacturaViewModel> detalles = new List<DetalleFacturaViewModel>();

                foreach (var detalle in cabecera.DetalleFacturas)
                {
                    DetalleFacturaViewModel detalleAux = new DetalleFacturaViewModel();

                    var productoAux = _productoRepository.GetProductoById(detalle.IdProducto);
                    if (productoAux.IdEmprendimiento == idEmprendimiento)
                    {
                        detalleAux.NombreProducto = productoAux.NombreProducto;
                        detalleAux.CantidadVendida = detalle.CantidadVendida;
                        detalleAux.PrecioUnitario = productoAux.PrecioVenta;
                        detalleAux.PrecioTotal = detalle.PrecioTotal;
                        detalleAux.Id_Producto = detalle.IdProducto;
                        detalles.Add(detalleAux);
                    }
                }

                if (detalles.Count() > 0)
                {
                    FacturaViewModel facturaAux = new FacturaViewModel();
                    facturaAux.CabeceraFactura = cabecera;
                    facturaAux.Iva = _ivaRepository.GetIvaById(facturaAux.CabeceraFactura.IdIva).ValorIva;

                    facturaAux.DetalleFactura = detalles;
                    _facturas.Add(facturaAux);
                }
            }
            return _facturas;
        }
    }
}
