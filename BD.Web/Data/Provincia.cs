using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD.Web.Data
{
    public class Provincia
    {
        [Key]
        public int Id_Provincia { get; set; }
        public string Nombre_Provincia { get; set; }
    }
}
