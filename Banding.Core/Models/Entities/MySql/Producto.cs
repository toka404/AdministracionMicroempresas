using System;
using System.Collections.Generic;

#nullable disable

namespace Banding.Core.Models.Entities.MySql
{
    public partial class Producto
    {
        public Producto()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
            ProductoTieneProveedors = new HashSet<ProductoTieneProveedor>();
        }

        public int IdProducto { get; set; }
        public int IdEmprendimiento { get; set; }
        public string NombreProducto { get; set; }
        public decimal PrecioFabricacion { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        public int Stock { get; set; }
        public DateTime? FechaCaducidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public string Iva { get; set; }
        public int StockMinimo { get; set; }
        public string EmailEnviado { get; set; } = "0";

        public virtual Emprendimiento IdEmprendimientoNavigation { get; set; }
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
        public virtual ICollection<ProductoTieneProveedor> ProductoTieneProveedors { get; set; }
    }
}
