using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Banding.Core.Models.Entities.MySql
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        [DisplayName("Provincia")]
        public int IdProvincia { get; set; }
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre no puede estar vacío")]
        public string NombreUsuario { get; set; }
        [DisplayName("Apellido")]
        [Required(ErrorMessage = "El apellido no puede estar vacío")]
        public string ApellidoUsuario { get; set; }
        [DisplayName("Celular")]
        [Required(ErrorMessage = "El número de celular no puede estar vacío")]
        [StringLength(10, ErrorMessage = "El número de celular debe contener 10 dígitos.", MinimumLength = 10)]
        public string Celular { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage ="El correo electrónico no puede estar vacío")]
        [DataType(DataType.EmailAddress, ErrorMessage = "El email no es válido")]
        public string EMail { get; set; }
        [Required(ErrorMessage = "El nombre de usuario no puede estar vacío")]
        [DisplayName("Nombre de usuario")]
        public string Username { get; set; }
        [DisplayName("Contraseña")]
        [Required(ErrorMessage = "La contraseña no puede estar vacía")]
        public string Contrasena { get; set; }
        [DisplayName("Rol")]
        public int RolId { get; set; }
        [DisplayName("Emprendimiento")]
        public int IdEmprendimiento { get; set; }
        public string Anulado { get; set; } = "0";

        [DisplayName("Emprendimiento")]
        public virtual Emprendimiento IdEmprendimientoNavigation { get; set; }
        [DisplayName("Provincia")]
        public virtual Provincia IdProvinciaNavigation { get; set; }
        [DisplayName("Rol")]
        public virtual Roles Rol { get; set; }
    }
}
