using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Models.Entities.MySql
{
    public class Roles
    {
        [Key]
        public int id_rol { get; set; }
        public string nombre_rol { get; set; }
    }
}
