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
        public int Id { get; set; }
        public int Id_Cabecera { get; set; }
        public int Id_Producto { get; set; }
        [Display(Name = "Cantidad Vendida" )]
        public int Cantidad_Vendida { get; set; }
        public double Precio_Total { get; set; }
    }
}
