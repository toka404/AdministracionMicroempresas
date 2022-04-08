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
        public int Id_Provincia { get; set; }
        [DataType(DataType.Text)]
        public string Nombre_Usuario { get; set; }
        public string Apellido_Usuario { get; set; }
        public string Celular { get; set; }
        [DataType(DataType.EmailAddress)]
        public string E_Mail { get; set; }
        public string Username { get; set; }
        public string Contrasena { get; set; }
    }
}
