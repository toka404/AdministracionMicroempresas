using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BD.Web.Data
{
    [Keyless]
    public class Usuario_Tiene_Emprendimientos
    {
        public int Id_Usuario { get; set; }
        public int Id_Emprendimiento { get; set; }
    }
}
