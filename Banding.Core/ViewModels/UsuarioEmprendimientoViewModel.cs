using Banding.Core.Models.Entities.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.ViewModels
{
    public class UsuarioEmprendimientoViewModel
    {
        public IEnumerable<Usuario> Usuarios { get; set; }
        public List<List<string>> EmprendimientosUsuario { get; set; }
        public List<Usuario_Tiene_Emprendimientos> Emprendimientos { get; set; }
    }
}
