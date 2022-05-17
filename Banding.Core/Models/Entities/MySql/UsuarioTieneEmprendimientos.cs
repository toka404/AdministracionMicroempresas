using System;
using System.Collections.Generic;

#nullable disable

namespace Banding.Core.Models.Entities.MySql
{
    public partial class UsuarioTieneEmprendimientos
    {
        public int IdUsuario { get; set; }
        public int IdEmprendimiento { get; set; }

        public virtual Emprendimiento IdEmprendimientoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
