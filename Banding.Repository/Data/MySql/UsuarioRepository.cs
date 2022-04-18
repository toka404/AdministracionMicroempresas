using Banding.Core.Models.Entities.MySql;
using Banding.Repository.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Repository.Data.MySql
{
    public class UsuarioRepository 
    {
        private readonly MyDbContext _context;
        public UsuarioRepository(MyDbContext context)
        {
            _context = context;
        }
        public Usuario GetUserByEmailUsername(string param)
        {
           return _context.Usuario.Where(u => u.E_Mail.Equals(param) || u.Username.Equals(param)).SingleOrDefault();
        }
    }
}
