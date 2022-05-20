using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Models.Entities.MySql;
using Banding.Repository.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Repository.Data.MySql
{
    public class ProvinciaRepository : IProvinciaRepository
    {
        private readonly MyDbContext _context;
        public ProvinciaRepository(MyDbContext context)
        {
            _context = context;
        }
        public bool ProvinciaExists(int id)
        {
            return _context.Provincia.Any(c => c.IdProvincia == id);
        }

        public void CreateProvincia(Provincia provincia)
        {
            _context.Add(provincia);
            _context.SaveChanges();
        }

        public void DeleteProvincia(Provincia provincia)
        {
            _context.Remove(provincia);
            _context.SaveChanges();
        }

        public List<Provincia> GetProvincias()
        {
            return _context.Provincia.ToList();
        }

        public Provincia GetProvinciaById(int? id)
        {
            return _context.Provincia.FirstOrDefault(p => p.IdProvincia == id);
        }

        public void UpdateProvincia(Provincia provincia)
        {
            _context.Update(provincia);
            _context.SaveChanges();
        }
    }
}
