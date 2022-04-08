using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Banding.Core.Models.Entities.MySql
{
    public class Producto
    {
        [Key]
        public int Id_Producto { get; set; }
        [Display(Name = "Emprendimiento")]
        public int Id_Emprendimiento { get; set; } 
        [Display(Name = "Nombre")]
        [StringLength(40, ErrorMessage = "El nombre no puede exceder los 40 caracteres.")]
        [Required]
        public string Nombre_Producto { get; set; }
        [Display(Name = "Precio")]
        [DataType(DataType.Currency)]
        public double Precio_Fabricacion { get; set; }
        [Display(Name = "Descripción")]
        [StringLength(500, ErrorMessage = "La descripción no puede exceder los 1000 caracteres.")]
        public string Descripcion { get; set; }
        [Display(Name = "Foto")]
        [DataType(DataType.ImageUrl)]
        public string Foto { get; set; }
        [Display(Name = "Stock")]
        public int Stock { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de caducidad")]
        public DateTime? Fecha_Caducidad { get; set; }
        [Display(Name = "Precio de venta")]
        [DataType(DataType.Currency)]
        [RegularExpression(@"^\d+(\.\d{1,2})?$")]
        [Range(0, 9999999999999999.99, ErrorMessage ="Ingrese un número válido.")]
        public double Precio_Venta { get; set; }
        [Display(Name = "Iva")]
        public string Iva { get; set; }
    }
}
