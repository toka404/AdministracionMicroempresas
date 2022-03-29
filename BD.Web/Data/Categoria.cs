using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD.Web.Data
{
    public class Categoria
    {
        [Key]
        public int Id_Categoria { get; set; }
        public string Nombre_Categoria { get; set; }
    }
}
