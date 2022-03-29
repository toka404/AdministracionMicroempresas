using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD.Web.Data
{
    public class Proveedor
    {
        [Key]
        public int Id_Proveedor { get; set; }
        public int Id_Provincia { get; set; }
        public string Nombre_Proveedor { get; set; }
        public string Telefono { get; set; }
        public string E_Mail_Proveedor { get; set; }
        public string Producto { get; set; }
        public string RUC { get; set; }
    }
}
