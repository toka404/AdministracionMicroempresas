using System;
using System.Collections.Generic;

#nullable disable

namespace Banding.Core.Models.Entities.MySql
{
    public partial class ProductoTieneProveedor
    {
        public int IdProveedor { get; set; }
        public int IdProducto { get; set; }
        public int IdProductoProveedor { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
        public virtual Proveedor IdProveedorNavigation { get; set; }
    }
}
