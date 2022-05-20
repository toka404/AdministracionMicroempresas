using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Banding.Core.Models.Entities.MySql
{
    public partial class Categoria
    {
        public Categoria()
        {
            Emprendimientos = new HashSet<Emprendimiento>();
        }

        public int IdCategoria { get; set; }
        [DisplayName("Nombre")]
        public string NombreCategoria { get; set; }

        public virtual ICollection<Emprendimiento> Emprendimientos { get; set; }
    }
}
