using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Models.Entities.MySql;
using Banding.Repository.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Repository.Data.MySql
{
    public class UsuarioEmprendimientoRepository : IUsuarioEmprendimientoRepository
    {
        private readonly MyDbContext _context;
        public UsuarioEmprendimientoRepository(MyDbContext context)
        {
            _context = context;
        }

        public Usuario_Tiene_Emprendimientos GetUsuarioEmprendimientoByIdUsuario(int? idUsuario)
        {
            return _context.Usuario_Tiene_Emprendimientos.FirstOrDefault(u => u.Id_Usuario == idUsuario);
        }
        public Usuario_Tiene_Emprendimientos GetUsuarioEmprendimientoByIdEmprendimiento(int? idEmprendimiento)
        {
            return _context.Usuario_Tiene_Emprendimientos.FirstOrDefault(u => u.Id_Emprendimiento == idEmprendimiento);
        }

        public List<Usuario_Tiene_Emprendimientos> GetUsuarioEmprendimientos()
        {
            return _context.Usuario_Tiene_Emprendimientos.ToList();
        }

    }
}
