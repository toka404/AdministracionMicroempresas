using Banding.Core.Models.Entities.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Interfaces.Repository.MySql
{
    public interface IUsuarioEmprendimientoRepository
    {
        public Usuario_Tiene_Emprendimientos GetUsuarioEmprendimientoByIdUsuario(int? IdUsuario);
        public Usuario_Tiene_Emprendimientos GetUsuarioEmprendimientoByIdEmprendimiento(int? IdEmprendimiento);
        public List<Usuario_Tiene_Emprendimientos> GetUsuarioEmprendimientos();
    }
}
