﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Banding.Core.Models.Entities.MySql
{
    public partial class Roles
    {
        public Roles()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdRol { get; set; }
        [DisplayName("Rol")]
        [Required(ErrorMessage = "El nombre no puede estar vacío")]
        public string NombreRol { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
