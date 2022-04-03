
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banding.Core.Models.Entities.MySql
{
    [Keyless]
    public class Producto_Tiene_Proveedor
    {
        public int Id_Proveedor { get; set; }
        public int Id_Producto { get; set; }
    }
}
