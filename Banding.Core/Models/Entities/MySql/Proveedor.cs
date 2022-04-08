using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Banding.Core.Models.Entities.MySql
{
    public class Proveedor
    {
        [Key]
        public int Id_Proveedor { get; set; }
        public int Id_Provincia { get; set; }
        [Display(Name = "Nombre")]
        [StringLength(40, ErrorMessage = "El nombre no puede exceder los 40 caracteres.")]

        public string Nombre_Proveedor { get; set; }
        [Display(Name = "Celular")]
        public string Telefono { get; set; }
        [DataType(DataType.Date)]
        public string E_Mail_Proveedor { get; set; }
        [Display(Name = "Producto")]
        public string Producto { get; set; }
        [Display(Name = "Ruc")]
        public string RUC { get; set; }
    }
}
