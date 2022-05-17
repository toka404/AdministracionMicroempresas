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
        public decimal? CantidadVendida { get; set; }
        [DataType(DataType.Currency)]
        public decimal? PrecioUnitario { get; set; }
        [DataType(DataType.Currency)]
        public decimal? PrecioTotal { get; set; }
        public int Id_Cabecera { get; set; }
        public int Id_Producto { get; set; }
    }
}
