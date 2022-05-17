using Banding.Core.Models.Entities.MySql;
using Banding.Core.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Interfaces.Repository.MySql
{
    public interface IDetalleFacturaRepository
    {
        public List<DetalleFactura> GetDetalleFacturas();
        public List<DetalleFactura> GetDetalleFacturasByIdCabecera(int? idCabecera);
        public void CreateDetalleFactura(DetalleFactura detalleFactura);
        public void UpdateDetalleFactura(DetalleFactura detalleFactura);
        public void DeleteDetalleFactura(DetalleFactura detalleFactura);
        public List<ChartProductoViewModel> GetDetallesGroupByProducto(int idEmprendimiento);
        public List<ChartProductoViewModel> GetDetallesGroupByDescendingProducto(int idEmprendimiento);
    }
}
