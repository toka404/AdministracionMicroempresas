using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD.Web.Data
{
    public class Factura_Cabecera
    {
        [Key]
        public int Id_Cabecera { get; set; }

        [Display(Name = "Iva")]
        public int Id_Iva { get; set; }

        [Display(Name = "Fecha")]
        public DateTime Fecha_Cabecera { get; set; }
        [Display(Name = "Nombre del cliente")]
        public string Nombre_Cliente { get; set; }
        [Display(Name = "Cédula del cliente")]
        public string Cedula_Cliente { get; set; }
        [Display(Name = "Celular del cliente")]
        public string Telefono_Cliente { get; set; }
        [Display(Name = "Dirección del cliente")]
        public string Direccion_Cliente { get; set; }
        [Display(Name = "Número de factura")]
        public int Nro_Factura { get; set; }
        [Display(Name = "Subtotal")]
        public decimal Subtotal { get; set; }
        [Display(Name = "Iva Total")]
        public decimal Iva_Total { get; set; }
        [Display(Name = "Precio Total")]
        public decimal Total { get; set; }
        [Display(Name = "Iva Cero")]
        public decimal Iva_Cero { get; set; }
    }
}
