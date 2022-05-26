using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Banding.Core.Models.Entities.MySql
{
    public partial class Proveedor
    {
        public Proveedor()
        {
            ProductoTieneProveedors = new HashSet<ProductoTieneProveedor>();
        }

        public int IdProveedor { get; set; }
        [DisplayName("Provincia")]
        public int IdProvincia { get; set; }
        [Required(ErrorMessage = "El nombre no puede estar vacío")]
        [DisplayName("Proveedor")]
        public string NombreProveedor { get; set; }
        [DisplayName("Celular")]
        [StringLength(10, ErrorMessage = "El número de celular debe contener 10 dígitos.", MinimumLength = 10)]

        public string Telefono { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "El correo electrónico no puede estar vacío")]
        [EmailAddress(ErrorMessage = "Ingrese un email válido")]

        public string EMailProveedor { get; set; }
        [Required(ErrorMessage = "El campo no puede estar vacío")]
        [DisplayName("Producto")]
        public int Producto { get; set; }
        [DisplayName("RUC")]
        [StringLength(13, ErrorMessage = "El número de celular debe contener 13 dígitos.", MinimumLength = 13)]
        public string Ruc { get; set; }
        [DisplayName("Provincia")]
        public virtual Provincia IdProvinciaNavigation { get; set; }
        public virtual ICollection<ProductoTieneProveedor> ProductoTieneProveedors { get; set; }
    }
}
