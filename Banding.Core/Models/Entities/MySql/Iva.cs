using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Banding.Core.Models.Entities.MySql
{
    public class Iva
    {
        [Key]
        public int Id_Iva { get; set; }
        [Display(Name = "Valor")]
        public double Valor_Iva { get; set; }
    }
}
