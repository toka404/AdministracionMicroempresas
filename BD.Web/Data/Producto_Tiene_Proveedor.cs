using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BD.Web.Data
{
    [Keyless]
    public class Producto_Tiene_Proveedor
    {
        public int Id_Proveedor { get; set; }
        public int Id_Producto { get; set; }
    }
}
