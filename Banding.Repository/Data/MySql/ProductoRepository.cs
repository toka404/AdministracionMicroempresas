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
    public class ProductoRepository : IProductoRepository
    {
        private readonly MyDbContext _context;
        public ProductoRepository(MyDbContext context)
        {
            _context = context;
        }
        public void CreateProducto(Producto producto)
        {
            _context.Add(producto);
            _context.SaveChanges();
        }

        public void DeleteProducto(Producto producto)
        {
            _context.Remove(producto);
            _context.SaveChanges();
        }

        public Producto GetProductoById(int? id)
        {
            return _context.Producto.FirstOrDefault(p=>p.Id_Producto == id);
        }

        public List<Producto> GetProductos()
        {
            return _context.Producto.ToList();
        }

        public bool ProductoExists(int id)
        {
            return _context.Producto.Any(p => p.Id_Producto == id);
        }

        public void UpdateProducto(Producto producto)
        {
            _context.Update(producto);
            _context.SaveChanges();
        }
        public void UpdateProductos(List<Producto> productos)
        {
            _context.Update(productos);
            _context.SaveChanges();
        }
        public List<Producto> ProductosWithMinStock(int? idEmprendimiento)
        {
            return _context.Producto.Where(p => p.Stock <= p.Stock_Minimo && p.Id_Emprendimiento == idEmprendimiento).ToList(); 
        }
        public List<Producto> ProductosNotEmailSent(int? idEmprendimiento)
        {
            return _context.Producto.Where(p => p.Stock <= p.Stock_Minimo && p.Id_Emprendimiento == idEmprendimiento && p.Email_Enviado.Equals("0")).ToList();
        }

    }
}
