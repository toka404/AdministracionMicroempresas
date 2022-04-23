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
    public class UsuarioRepository : IUsuarioRepository
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
        public List<Usuario> GetUsuarios()
        {
            return _context.Usuario.ToList();
        }
        public Usuario GetUsuarioById(int? id)
        {
            return _context.Usuario.FirstOrDefault(u => u.Id_Usuario == id);
        }
        public void CreateUsuario(Usuario usuario)
        {
            _context.Add(usuario);
            _context.SaveChanges();
        }
        public void UpdateUsuario(Usuario usuario)
        {
            _context.Update(usuario);
            _context.SaveChanges();
        }
        public void DeleteUsuario(Usuario usuario)
        {
            _context.Usuario.Remove(usuario);
            _context.SaveChanges();
        }
        public bool UsuarioExists(int id)
        {
            return _context.Usuario.Any(e => e.Id_Usuario == id);
        }
    }
}
