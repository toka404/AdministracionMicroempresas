using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Banding.Core.Models.Entities.MySql
{
    public class Producto
    {
        [Key]
        public int Id_Producto { get; set; }
        public int Id_Emprendimiento { get; set; }
        public string Nombre_Producto { get; set; }
        public decimal Precio_Fabricacion { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        public int Stock { get; set; }
        public DateTime Fecha_Caducidad { get; set; }
        public decimal Precio_Venta { get; set; }
        public string Iva { get; set; }
    }
}
