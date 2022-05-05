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
    public class FacturaCabeceraRepository : IFacturaCabeceraRepository
    {
        private readonly MyDbContext _context;
        public FacturaCabeceraRepository(MyDbContext context)
        {
            _context = context;
        }

        public void CreateFacturaCabecera(Factura_Cabecera facturaCabecera)
        {
            _context.Add(facturaCabecera);
            _context.SaveChanges();
        }

        public void DeleteFacturaCabecera(Factura_Cabecera facturaCabecera)
        {
            _context.Remove(facturaCabecera);
            _context.SaveChanges();
        }

        public bool FacturaCabeceraExists(int id)
        {
            return _context.Factura_Cabecera.Any(f=>f.Id_Cabecera == id);
        }

        public Factura_Cabecera GetFacturaCabeceraById(int? id)
        {
            return _context.Factura_Cabecera.FirstOrDefault(f=> f.Id_Cabecera == id);
        }

        public List<Factura_Cabecera> GetFacturaCabeceras()
        {
            return _context.Factura_Cabecera.ToList();
        }

        public void UpdateFacturaCabecera(Factura_Cabecera facturaCabecera)
        {
            _context.Update(facturaCabecera);
            _context.SaveChanges();
        }
    }
}
