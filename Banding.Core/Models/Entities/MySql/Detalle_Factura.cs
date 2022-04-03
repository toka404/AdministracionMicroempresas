using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Banding.Core.Models.Entities.MySql
{
    public class Detalle_Factura
    {
        [Key]
        public int Id_Cabecera { get; set; }
        public int Id_Producto { get; set; }
        public decimal Cantidad_Vendida { get; set; }
        public decimal Precio_Total { get; set; }
    }
}
