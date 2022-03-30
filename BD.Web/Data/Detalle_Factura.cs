using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD.Web.Data
{
    public class Detalle_Factura
    {
        [Key]
        public int Id_Cabecera { get; set; }
        [Display(Name = "Producto")]
        public int Id_Producto { get; set; }
        [Display(Name = "Cantidad Vendida")]
        public decimal Cantidad_Vendida { get; set; }
        [Display(Name = "Precio Total")]
        public decimal Precio_Total { get; set; }
    }
}
