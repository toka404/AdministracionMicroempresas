using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Banding.Core.Models.Entities.MySql
{
    public partial class DetalleFactura
    {
        public int IdCabecera { get; set; }
        public int IdProducto { get; set; }
        [DisplayName("Cantidad Vendida")]
        public int? CantidadVendida { get; set; }
        [DisplayName("Total")]
        public decimal? PrecioTotal { get; set; }
        public int Id { get; set; }

        public virtual FacturaCabecera IdCabeceraNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
