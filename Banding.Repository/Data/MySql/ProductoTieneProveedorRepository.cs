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
    public class ProductoTieneProveedorRepository : IProductoTieneProveedorRepository
    {
        private readonly MyDbContext _context;
        public ProductoTieneProveedorRepository(MyDbContext context)
        {
            _context = context;
        }

        public void CreateProveedor(int idProveedor, int idProducto)
        {
            var ProductoTieneProveedor = new ProductoTieneProveedor
            {
                IdProducto = idProducto,
                IdProveedor = idProveedor
            };
            _context.Add(ProductoTieneProveedor);
            _context.SaveChanges();
        }
        public void DeleteProveedor(int idProveedor)
        {
            
            var ProductoTieneProveedor = _context.ProductoTieneProveedor.Where(p=>p.IdProveedor==idProveedor).ToList();
            foreach (var item in ProductoTieneProveedor)
            {
                _context.Remove(item);
            }
            _context.SaveChanges();
        }
    }
}
