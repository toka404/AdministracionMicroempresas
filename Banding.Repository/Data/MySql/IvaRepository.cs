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
    public class IvaRepository : IIvaRepository
    {
        private readonly MyDbContext _context;
        public IvaRepository(MyDbContext context)
        {
            _context = context;
        }
        public void CreateIva(Iva iva)
        {
            _context.Add(iva);
            _context.SaveChanges();
        }

        public void DeleteIva(Iva iva)
        {
            _context.Remove(iva);
            _context.SaveChanges();
        }

        public Iva GetIvaById(int? id)
        {
            return _context.Iva.FirstOrDefault(i=> i.Id_Iva == id);
        }

        public List<Iva> GetIvas()
        {
            return _context.Iva.ToList();
        }

        public bool IvaExists(int id)
        {
            return _context.Iva.Any(i => i.Id_Iva == id);
        }

        public void UpdateIva(Iva iva)
        {
            _context.Update(iva);
            _context.SaveChanges();
        }
    }
}
