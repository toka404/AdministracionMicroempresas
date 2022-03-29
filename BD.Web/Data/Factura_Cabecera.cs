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
        public int Id_Iva { get; set; }
        public DateTime Fecha_Cabecera { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Cedula_Cliente { get; set; }
        public string Telefono_Cliente { get; set; }
        public string Direccion_Cliente { get; set; }
        public int Nro_Factura { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Iva_Total { get; set; }
        public decimal Total { get; set; }
        public decimal Iva_Cero { get; set; }
    }
}
