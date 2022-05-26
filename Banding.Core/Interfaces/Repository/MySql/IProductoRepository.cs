using Banding.Core.Models.Entities.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Interfaces.Repository.MySql
{
    public interface IProductoRepository
    {
        public List<Producto> GetProductos();
        public Producto GetProductoById(int? id);
        public void CreateProducto(Producto usuario);
        public void UpdateProducto(Producto usuario);
        public void UpdateProductos(List<Producto> usuario);
        public void DeleteProducto(int usuario);
        public bool ProductoExists(int id);
        public List<Producto> ProductosWithMinStock(int? idEmprendimiento);
        public List<Producto> ProductosNotEmailSent(int? idEmprendimiento);
        public List<Producto> GetProductosByEmprendimiento(int idEmprendimiento);
        public List<Producto> GetProductosByEmprendimientoAvailable(int idEmprendimiento);

    }
}
