using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Models.ViewModels
{
    public class ChartProductoViewModel
    {
        public string Producto { get; set; }
        public int Emprendimiento { get; set; }
        public int? Cantidad { get; set; }
        public int Cabecera { get; set; }
        public decimal? PrecioTotal { get; set; }
    }
}
