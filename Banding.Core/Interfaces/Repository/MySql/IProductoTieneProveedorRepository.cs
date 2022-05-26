using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Interfaces.Repository.MySql
{
    public interface IProductoTieneProveedorRepository
    {
        public void CreateProveedor(int idProveedor, int idProducto);
        public void DeleteProveedor(int idProveedor);

    }
}
