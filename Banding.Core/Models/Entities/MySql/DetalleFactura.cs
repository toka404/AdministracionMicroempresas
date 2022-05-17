using System;
using System.Collections.Generic;

#nullable disable

namespace Banding.Core.Models.Entities.MySql
{
    public partial class DetalleFactura
    {
        public int IdCabecera { get; set; }
        public int IdProducto { get; set; }
        public int? CantidadVendida { get; set; }
        public decimal? PrecioTotal { get; set; }
        public int Id { get; set; }

        public virtual FacturaCabecera IdCabeceraNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
