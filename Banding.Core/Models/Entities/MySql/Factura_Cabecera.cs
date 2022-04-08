using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Banding.Core.Models.Entities.MySql
{
    public class Factura_Cabecera
    {
        [Key]
        public int Id_Cabecera { get; set; }
        public int Id_Iva { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha_Cabecera { get; set; }
        [Display(Name = "Nombre")]
        public string Nombre_Cliente { get; set; }
        [Display(Name = "Cedula")]
        public string Cedula_Cliente { get; set; }
        [Display(Name = "Celular")]
        public string Telefono_Cliente { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion_Cliente { get; set; }
        [Display(Name = "Número de factura")]
        public int Nro_Factura { get; set; }
        [Display(Name = "Subtotal")]
        public double Subtotal { get; set; }
        [Display(Name = "Iva total")]
        public double Iva_Total { get; set; }
        [Display(Name = "Total")]
        public double Total { get; set; }
        [Display(Name = "Iva Cero")]
        public int Iva_Cero { get; set; }
    }
}
