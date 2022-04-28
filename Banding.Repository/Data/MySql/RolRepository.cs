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
    public class RolRepository : IRolRepository
    {
        private readonly MyDbContext _context;
        public RolRepository(MyDbContext context)
        {
            _context = context;
        }
        public string GetNameRol(int? id)
        {
            var rol = _context.Roles.FirstOrDefault(r => r.id_rol == id);
            return rol.nombre_rol;
        }

        public Roles GetRolById(int? id)
        {
            return _context.Roles.FirstOrDefault(r => r.id_rol == id);
        }

        public List<Roles> GetRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
