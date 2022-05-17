using System;
using System.Collections.Generic;

#nullable disable

namespace Banding.Core.Models.Entities.MySql
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            ProductoTieneProveedors = new HashSet<ProductoTieneProveedor>();
        }

        public int IdProveedor { get; set; }
        public int IdProvincia { get; set; }
        public string NombreProveedor { get; set; }
        public string Telefono { get; set; }
        public string EMailProveedor { get; set; }
        public string Producto { get; set; }
        public string Ruc { get; set; }

        public virtual Provincia IdProvinciaNavigation { get; set; }
        public virtual ICollection<ProductoTieneProveedor> ProductoTieneProveedors { get; set; }
    }
}
