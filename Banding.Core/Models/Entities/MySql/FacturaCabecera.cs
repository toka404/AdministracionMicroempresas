using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Banding.Core.Models.Entities.MySql
{
    public partial class FacturaCabecera
    {
        public FacturaCabecera()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }

        public int IdCabecera { get; set; }
        public int IdIva { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Fecha")]
        public DateTime FechaCabecera { get; set; }
        [DisplayName("Nombre")]
        public string NombreCliente { get; set; }
        [DisplayName("Cédula")]
        public string CedulaCliente { get; set; }
        [DisplayName("Celular")]
        public string TelefonoCliente { get; set; }
        [DisplayName("Dirección")]
        public string DireccionCliente { get; set; }
        [DisplayName("Número Factura")]

        public int NroFactura { get; set; }
        public decimal Subtotal { get; set; }
        public decimal? IvaTotal { get; set; }
        public decimal Total { get; set; }
        public int IvaCero { get; set; }
        public string Anulado { get; set; } = "0";

        public virtual Iva IdIvaNavigation { get; set; }
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
    }
}
