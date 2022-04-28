using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Banding.Core.Models.Entities.MySql
{
    public class Usuario
    {
        [Key]
        public int Id_Usuario { get; set; }
        [Display(Name = "Provincia")]
        public int Id_Provincia { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "Nombre")]
        public string Nombre_Usuario { get; set; }
        [Display(Name = "Apellido")]

        public string Apellido_Usuario { get; set; }
        [Display(Name = "Celular")]

        public string Celular { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]

        public string E_Mail { get; set; }
        [Display(Name = "Nombre de usuario")]

        public string Username { get; set; }
        [Display(Name = "Contraseña")]
        public string Contrasena { get; set; }
        public int rol_id { get; set; }
        [Display(Name = "Emprendimiento")]
        public int id_emprendimiento { get; set; }
    }
}
