using System;
using System.Collections.Generic;
using System.ComponentModel;

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
        [DisplayName("Categoria")]
        public int IdCategoria { get; set; }
        [DisplayName("Nombre")]
        public string NombreEmprendimiento { get; set; }
        [DisplayName("Descripción")]
        public string DescripcionEmprendimiento { get; set; }
        public string Anulado { get; set; } = "0";
        public string Logo { get; set; }
        [DisplayName("Categoría")]
        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
