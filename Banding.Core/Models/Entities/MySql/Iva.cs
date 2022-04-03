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
        public decimal Valor_Iva { get; set; }
    }
}
