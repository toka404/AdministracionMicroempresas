using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Banding.Core.Models.Entities.MySql
{
    public partial class Provincia
    {
        public Provincia()
        {
            Proveedors = new HashSet<Proveedor>();
            Usuarios = new HashSet<Usuario>();
        }

        public int IdProvincia { get; set; }
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre no puede estar vacío")]
        public string NombreProvincia { get; set; }

        public virtual ICollection<Proveedor> Proveedors { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        //public int Id_Provincia { get; set; }
    }
}
