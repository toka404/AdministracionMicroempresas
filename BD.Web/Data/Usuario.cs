using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD.Web.Data
{
    public class Usuario
    {
        [Key]
        public int Id_Usuario { get; set; }
        [Display(Name = "Provincia")]
        public int Id_Provincia { get; set; }
        [Display(Name = "Nombre")]
        public string Nombre_Usuario { get; set; }
        [Display(Name = "Apellido")]
        public string Apellido_Usuario { get; set; }
        [Display(Name = "Celular")]
        public string Celular { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "El correo no es válido")]
        public string E_Mail { get; set; }
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Display(Name = "Contraseña")]
        public string Contrasena { get; set; }
    }
}
