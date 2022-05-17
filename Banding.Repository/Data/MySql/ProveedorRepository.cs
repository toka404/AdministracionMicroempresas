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
            return _context.Proveedor.FirstOrDefault(p => p.IdProveedor == id);
        }

        public List<Proveedor> GetProveedores()
        {
            return _context.Proveedor.ToList();
        }

        public List<Proveedor> GetProveedoresByEmprendimiento(int id)
        {
            var productos = _context.Producto.Where(p => p.IdEmprendimiento == id).ToList();
            List<int> proveedoresProducto = new List<int>();
            List<Proveedor> proveedores = _context.Proveedor.ToList();

            foreach (var item in productos)
            {
                var aux = _context.ProductoTieneProveedor.FirstOrDefault(p => p.IdProducto == item.IdProducto);
                proveedoresProducto.Add(aux.IdProveedor);
            }


            IEnumerable<int> auxiliar = proveedoresProducto.Distinct();
            List<Proveedor> auxLista = new List<Proveedor>();

            foreach (var obj in auxiliar)
            {
                var aux = _context.Proveedor.FirstOrDefault(p => p.IdProveedor == obj);
                auxLista.Add(aux);
            }


            return auxLista;
        }

        public bool ProveedorExists(int id)
        {
            return _context.Proveedor.Any(p => p.IdProveedor == id);
        }

        public void UpdateProveedor(Proveedor proveedor)
        {
            _context.Update(proveedor);
            _context.SaveChanges();
        }
    }
}
