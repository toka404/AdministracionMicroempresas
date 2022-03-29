using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD.Web.Data
{
    public class Iva
    {
        [Key]
        public int Id_Iva { get; set; }
        public decimal Valor_Iva { get; set; }
    }
}
