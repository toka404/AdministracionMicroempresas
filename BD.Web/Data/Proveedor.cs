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
        [Display(Name = "Provincia")]
        public int Id_Provincia { get; set; }
        [Display(Name = "Nombre")]
        public string Nombre_Proveedor { get; set; }
        [Display(Name = "Celular")]
        public string Telefono { get; set; }
        [Display(Name = "Email")]
        public string E_Mail_Proveedor { get; set; }
        [Display(Name = "Producto")]
        public string Producto { get; set; }
        [Display(Name = "RUC")]
        public string RUC { get; set; }
    }
}
