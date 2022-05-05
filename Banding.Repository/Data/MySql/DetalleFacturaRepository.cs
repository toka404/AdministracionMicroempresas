using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Models.Entities.MySql;
using Banding.Repository.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Repository.Data.MySql
{
    public class DetalleFacturaRepository : IDetalleFacturaRepository
    {
        private readonly MyDbContext _context;
        public DetalleFacturaRepository(MyDbContext context)
        {
            _context = context;
        }

        public void CreateDetalleFactura(Detalle_Factura detalleFactura)
        {
            _context.Add(detalleFactura);
            _context.SaveChanges();
        }

        public void DeleteDetalleFactura(Detalle_Factura detalleFactura)
        {
            _context.Remove(detalleFactura);
            _context.SaveChanges();
        }


        public List<Detalle_Factura> GetDetalleFacturasByIdCabecera(int? idCabecera)
        {
            return _context.Detalle_Factura.Where(d => d.Id_Cabecera == idCabecera).Distinct().ToList();
        }

        public List<Detalle_Factura> GetDetalleFacturas()
        {
            return _context.Detalle_Factura.ToList();
        }

        public void UpdateDetalleFactura(Detalle_Factura detalleFactura)
        {
            _context.Update(detalleFactura);
            _context.SaveChanges();
        }
    }
}
