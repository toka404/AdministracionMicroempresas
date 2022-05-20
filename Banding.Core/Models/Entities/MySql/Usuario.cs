using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Banding.Core.Models.Entities.MySql
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        [DisplayName("Provincia")]
        public int IdProvincia { get; set; }
        [DisplayName("Nombre")]
        public string NombreUsuario { get; set; }
        [DisplayName("Apellido")]
        public string ApellidoUsuario { get; set; }
        [DisplayName("Celular")]
        public string Celular { get; set; }
        [DisplayName("Email")]
        public string EMail { get; set; }
        [DisplayName("Nombre de usuario")]
        public string Username { get; set; }
        [DisplayName("Contraseña")]
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
