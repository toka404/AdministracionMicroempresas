using System;
using System.Collections.Generic;

#nullable disable

namespace Banding.Core.Models.Entities.MySql
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdProvincia { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public string Celular { get; set; }
        public string EMail { get; set; }
        public string Username { get; set; }
        public string Contrasena { get; set; }
        public int RolId { get; set; }
        public int IdEmprendimiento { get; set; }
        public string Anulado { get; set; } = "0";

        public virtual Emprendimiento IdEmprendimientoNavigation { get; set; }
        public virtual Provincia IdProvinciaNavigation { get; set; }
        public virtual Roles Rol { get; set; }
    }
}
