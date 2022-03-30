using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD.Web.Data
{
    public class Producto
    {
        [Key]
        public int Id_Producto { get; set; }
        [Display(Name = "Emprendimiento")]
        public int Id_Emprendimiento { get; set; }
        [Display(Name = "Nombre")]
        public string Nombre_Producto { get; set; }
        [Display(Name = "Precio de fabricación")]
        public decimal Precio_Fabricacion { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Display(Name = "Foto")]
        public string Foto { get; set; }
        [Display(Name = "Stock")]
        public int Stock { get; set; }
        [Display(Name = "Fecha de caducidad")]
        public DateTime Fecha_Caducidad { get; set; }
        [Display(Name = "Precio de venta")]
        public decimal Precio_Venta { get; set; }
        [Display(Name = "Iva")]
        public string Iva { get; set; }
    }
}
