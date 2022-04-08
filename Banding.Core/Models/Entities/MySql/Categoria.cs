using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Banding.Core.Models.Entities.MySql
{
    public class Categoria
    {
        [Key]
        [Display(Name = "Categoria")]
        public int Id_Categoria { get; set; }
        [Display(Name = "Nombre")]
        [StringLength(20, ErrorMessage = "El nombre no puede exceder los 20 caracteres.")]
        public string Nombre_Categoria { get; set; }
    }
}
