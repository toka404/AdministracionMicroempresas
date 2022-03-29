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
        public int Id_Categoria { get; set; }
        public string Nombre_Emprendimiento { get; set; }
        public string Descripcion_Emprendimiento { get; set; }
        public string Logo { get; set; }
    }
}
