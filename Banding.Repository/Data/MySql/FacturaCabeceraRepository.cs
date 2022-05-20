using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Models.Entities.MySql;
using Banding.Repository.MySql;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Repository.Data.MySql
{
    public class FacturaCabeceraRepository : IFacturaCabeceraRepository
    {
        private readonly MyDbContext _context;
        public FacturaCabeceraRepository(MyDbContext context)
        {
            _context = context;
        }

        public void CreateFacturaCabecera(FacturaCabecera facturaCabecera)
        {
            _context.Add(facturaCabecera);
            _context.SaveChanges();
        }

        public void DeleteFacturaCabecera(int id)
        {
            var cabecera = _context.FacturaCabecera.FirstOrDefault(c => c.IdCabecera == id);
            cabecera.Anulado = "1";
            _context.Update(cabecera);
            _context.SaveChanges();
        }

        public bool FacturaCabeceraExists(int id)
        {
            return _context.FacturaCabecera.Any(f => f.IdCabecera == id);
        }

        public FacturaCabecera GetFacturaCabeceraById(int? id)
        {
            return _context.FacturaCabecera.FirstOrDefault(f => f.IdCabecera == id);
        }

        public ICollection<FacturaCabecera> GetFacturaCabecerasByDates(DateTime fechaInicio, DateTime fechaFin)
        {
            return _context.FacturaCabecera.Include(c => c.DetalleFacturas).
                Where(f => f.FechaCabecera >= fechaInicio && f.FechaCabecera<=fechaFin).OrderBy(t=>t.FechaCabecera).ToList();
        }

        public ICollection<FacturaCabecera> GetFacturaCabeceras()
        {
            return _context.FacturaCabecera.Include(c => c.DetalleFacturas).Where(c=>c.Anulado.Equals("0")).OrderBy(t=>t.NroFactura).ToList();
        }
        public ICollection<DetalleFactura> GetDetallesByIdCabecera(int idCabecera)
        {
            var cabecera= _context.FacturaCabecera.Include(c => c.DetalleFacturas).FirstOrDefault(c => c.IdCabecera == 1);
            return cabecera.DetalleFacturas;
        }

        public void UpdateFacturaCabecera(FacturaCabecera facturaCabecera)
        {
            _context.Update(facturaCabecera);
            _context.SaveChanges();
        }
    }
}
