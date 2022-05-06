using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Interfaces.Service;
using Banding.Core.Models.Entities.MySql;
using Banding.Core.Models.ViewModels;
using Banding.Repository.Data.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Service.Services
{
    public class FacturacionService : IFacturacionService
    {
        private readonly IDetalleFacturaRepository _detalleFacturaRepository;
        private readonly IFacturaCabeceraRepository _facturaCabeceraRepository;
        private readonly IProductoRepository _productoRepository;
        private readonly IIvaRepository _ivaRepository;

        public FacturacionService(
            IDetalleFacturaRepository detalleFacturaRepository,
            IFacturaCabeceraRepository facturaCabeceraRepository,
            IProductoRepository productoRepository,
            IIvaRepository ivaRepository)
        {
            _detalleFacturaRepository = detalleFacturaRepository;
            _facturaCabeceraRepository = facturaCabeceraRepository;
            _productoRepository = productoRepository;
            _ivaRepository = ivaRepository;
        }

        public List<FacturaViewModel> GetFacturasByEmprendimiento(int idEmprendimiento)
        {
            List<FacturaViewModel> _facturas;
            _facturas = new List<FacturaViewModel>();

            var cabecerasFactura = _facturaCabeceraRepository.GetFacturaCabeceras();

            foreach (var cabecera in cabecerasFactura)
            {
                
                List<DetalleFacturaViewModel> detalles = new List<DetalleFacturaViewModel>();

                var detalleFactura = _detalleFacturaRepository.GetDetalleFacturasByIdCabecera(cabecera.Id_Cabecera);
                foreach (var detalle in detalleFactura)
                {
                    DetalleFacturaViewModel detalleAux = new DetalleFacturaViewModel();

                    var productoAux = _productoRepository.GetProductoById(detalle.Id_Producto);
                    if (productoAux.Id_Emprendimiento == idEmprendimiento)
                    {
                        detalleAux.NombreProducto = productoAux.Nombre_Producto;
                        detalleAux.CantidadVendida = detalle.Cantidad_Vendida;
                        detalleAux.PrecioUnitario = productoAux.Precio_Venta;
                        detalleAux.PrecioTotal = detalle.Precio_Total;
                        detalles.Add(detalleAux);
                    }
                }
                if (detalles.Count() > 0)
                {
                    FacturaViewModel facturaAux = new FacturaViewModel();
                    facturaAux.FacturaCabecera = cabecera;
                    facturaAux.Iva = _ivaRepository.GetIvaById(facturaAux.FacturaCabecera.Id_Iva).Valor_Iva;

                    facturaAux.DetalleFactura = detalles;
                    _facturas.Add(facturaAux);
                }
            }
            return _facturas;
        }
        public void CreateFactura()
        {
            throw new NotImplementedException();
        }
    }
}
