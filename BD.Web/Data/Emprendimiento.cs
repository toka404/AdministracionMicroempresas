using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD.Web.Data
{
    public class Emprendimiento
    {
        [Key]
        public int Id_Emprendimiento { get; set; }
        [Display(Name = "Categoría")]
        public int Id_Categoria { get; set; }
        [Display(Name = "Nombre")]
        public string Nombre_Emprendimiento { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion_Emprendimiento { get; set; }
        [Display(Name = "Logo")]
        public string Logo { get; set; }
    }
}
