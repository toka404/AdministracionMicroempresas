using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Models.Entities.MySql;
using Banding.Repository.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Repository.Data.MySql
{
    public class UsuarioEmprendimientosRepository : IUsuarioEmprendimientosRepository
    {
        private readonly MyDbContext _context;
        public UsuarioEmprendimientosRepository(MyDbContext context)
        {
            _context = context;
        }
        public UsuarioTieneEmprendimientos GetUsuarioEmprendimientoByIdUsuario(int? idUsuario)
        {
            return _context.UsuarioTieneEmprendimientos.FirstOrDefault(u => u.IdUsuario == idUsuario);
        }
        public UsuarioTieneEmprendimientos GetUsuarioEmprendimientoByIdEmprendimiento(int? idEmprendimiento)
        {
            return _context.UsuarioTieneEmprendimientos.FirstOrDefault(u => u.IdEmprendimiento == idEmprendimiento);
        }

        public List<UsuarioTieneEmprendimientos> GetUsuarioEmprendimientos()
        {
            return _context.UsuarioTieneEmprendimientos.ToList();
        }
    }
}
