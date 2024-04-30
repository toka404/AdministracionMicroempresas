using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
        [Required(ErrorMessage = "El campo no puede estar vacío")]
        [DisplayName("Nombre")]
        public string NombreCategoria { get; set; }
        public string TipoCategoria { get; set; }
        public string EspecialidadCategoria { get; set; }

        public virtual ICollection<Emprendimiento> Emprendimientos { get; set; }
    }
}
