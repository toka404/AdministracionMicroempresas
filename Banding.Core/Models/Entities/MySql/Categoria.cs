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
        public int Id_Categoria { get; set; }
        public string Nombre_Categoria { get; set; }
    }
}
