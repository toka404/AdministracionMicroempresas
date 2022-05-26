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

        public void DeleteProducto(int id)
        {
            var producto = _context.Producto.FirstOrDefault(c => c.IdProducto == id);
            producto.Anulado = "1";
            _context.Update(producto);
            _context.SaveChanges();
        }

        public Producto GetProductoById(int? id)
        {
            return _context.Producto.Include(p => p.IdEmprendimientoNavigation).FirstOrDefault(p => p.IdProducto == id);
        }

        public List<Producto> GetProductos()
        {
            return _context.Producto.Include(p => p.IdEmprendimientoNavigation).Where(p=>p.Anulado.Equals("0")).ToList();
        }
        public List<Producto> GetProductosByEmprendimiento(int idEmprendimiento)
        {
            return _context.Producto.Include(p => p.IdEmprendimientoNavigation).Where(p => p.IdEmprendimiento == idEmprendimiento && p.Anulado.Equals("0")).ToList();
        }
        public List<Producto> GetProductosByEmprendimientoAvailable(int idEmprendimiento)
        {
            return _context.Producto.Include(p => p.IdEmprendimientoNavigation).Where(p => p.IdEmprendimiento == idEmprendimiento && p.Anulado.Equals("0") && p.Stock >0).ToList();
        }
        public bool ProductoExists(int id)
        {
            return _context.Producto.Any(p => p.IdProducto == id);
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
            return _context.Producto.Where(p => p.Stock <= p.StockMinimo && p.IdEmprendimiento == idEmprendimiento).ToList();
        }
        public List<Producto> ProductosNotEmailSent(int? idEmprendimiento)
        {
            return _context.Producto.Where(p => p.Stock <= p.StockMinimo && p.IdEmprendimiento == idEmprendimiento && p.EmailEnviado.Equals("0")).ToList();
        }
    }
}
