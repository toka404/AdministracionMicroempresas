using System;
using System.Collections.Generic;
using System.ComponentModel;

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
        [DisplayName("Emprendimiento")]
        public int IdEmprendimiento { get; set; }
        [DisplayName("Nombre")]
        public string NombreProducto { get; set; }
        [DisplayName("Precio de Fabricación")]
        public decimal PrecioFabricacion { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        public int Stock { get; set; }
        [DisplayName("Fecha de Caducidad")]
        public DateTime? FechaCaducidad { get; set; }
        [DisplayName("Precio")]
        public decimal PrecioVenta { get; set; }
        [DisplayName("Iva")]
        public string Iva { get; set; }
        [DisplayName("Employee Name")]
        public int StockMinimo { get; set; }
        public string EmailEnviado { get; set; } = "0";

        public virtual Emprendimiento IdEmprendimientoNavigation { get; set; }
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
        public virtual ICollection<ProductoTieneProveedor> ProductoTieneProveedors { get; set; }
    }
}
