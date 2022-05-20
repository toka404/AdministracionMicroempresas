using System;
using System.Collections.Generic;
using System.ComponentModel;

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
        [DisplayName("Provincia")]
        public int IdProvincia { get; set; }
        [DisplayName("Proveedor")]
        public string NombreProveedor { get; set; }
        [DisplayName("Celular")]
        public string Telefono { get; set; }
        [DisplayName("Email")]
        public string EMailProveedor { get; set; }
        [DisplayName("Employee Name")]
        public string Producto { get; set; }
        [DisplayName("RUC")]
        public string Ruc { get; set; }

        public virtual Provincia IdProvinciaNavigation { get; set; }
        public virtual ICollection<ProductoTieneProveedor> ProductoTieneProveedors { get; set; }
    }
}
