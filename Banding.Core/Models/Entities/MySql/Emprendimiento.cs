using System;
using System.Collections.Generic;

#nullable disable

namespace Banding.Core.Models.Entities.MySql
{
    public partial class Emprendimiento
    {
        public Emprendimiento()
        {
            Productos = new HashSet<Producto>();
            Usuarios = new HashSet<Usuario>();
        }

        public int IdEmprendimiento { get; set; }
        public int IdCategoria { get; set; }
        public string NombreEmprendimiento { get; set; }
        public string DescripcionEmprendimiento { get; set; }
        public string Logo { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
