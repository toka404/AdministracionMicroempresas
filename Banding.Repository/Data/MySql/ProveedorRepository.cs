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
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly MyDbContext _context;
        public ProveedorRepository(MyDbContext context)
        {
            _context = context;
        }

        public void CreateProveedor(Proveedor proveedor)
        {
            _context.Add(proveedor);
            _context.SaveChanges();
        }

        public void DeleteProveedor(Proveedor proveedor)
        {
            _context.Remove(proveedor);
            _context.SaveChanges();
        }

        public Proveedor GetProveedorById(int? id)
        {
            return _context.Proveedor.FirstOrDefault(p => p.Id_Proveedor == id);
        }

        public List<Proveedor> GetProveedores()
        {
            return _context.Proveedor.ToList();
        }

        public bool ProveedorExists(int id)
        {
            return _context.Proveedor.Any(p => p.Id_Proveedor == id);
        }

        public void UpdateProveedor(Proveedor proveedor)
        {
            _context.Update(proveedor);
            _context.SaveChanges();
        }
    }
}
