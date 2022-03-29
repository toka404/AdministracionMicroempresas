using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD.Web.Data
{
    public class provincia
    {
        [Key]
        public int ID_PROVINCIA { get; set; }
        public string NOMBRE_PROVINCIA { get; set; }
    }
}
