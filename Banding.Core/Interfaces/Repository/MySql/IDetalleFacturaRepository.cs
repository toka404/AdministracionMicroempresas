using Banding.Core.Models.Entities.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Interfaces.Repository.MySql
{
    public interface IDetalleFacturaRepository
    {
        public List<Detalle_Factura> GetDetalleFacturas();
        public List<Detalle_Factura> GetDetalleFacturasByIdCabecera(int? idCabecera);
        public void CreateDetalleFactura(Detalle_Factura detalleFactura);
        public void UpdateDetalleFactura(Detalle_Factura detalleFactura);
        public void DeleteDetalleFactura(Detalle_Factura detalleFactura);
    }
}
