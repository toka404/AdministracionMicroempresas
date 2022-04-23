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
        public void DeleteProducto(Producto usuario);
        public bool ProductoExists(int id);
    }
}
