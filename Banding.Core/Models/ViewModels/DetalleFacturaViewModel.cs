using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Models.ViewModels
{
    public class DetalleFacturaViewModel
    {
        public string NombreProducto { get; set; }
        public double CantidadVendida { get; set; }
        [DataType(DataType.Currency)]
        public double PrecioUnitario { get; set; }
        [DataType(DataType.Currency)]
        public double PrecioTotal { get; set; }
    }
}
