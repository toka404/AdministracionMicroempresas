using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Models.Entities.MySql;
using Banding.Repository.MySql;
using Microsoft.EntityFrameworkCore;
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
        public Usuario GetUserByEmailUsername(string param, string password)
        {
            return _context.Usuario.Where(u => (u.EMail.Equals(param) || u.Username.Equals(param)) && u.Contrasena.Equals(password)).SingleOrDefault();
        }
        public List<Usuario> GetUsuarios()
        {
            return _context.Usuario.Include(u => u.IdEmprendimientoNavigation).Include(u => u.IdProvinciaNavigation).Include(u=>u.Rol).ToList();
        }
        public string GetRol(int? id)
        {
            var usuario = _context.Usuario.FirstOrDefault(u => u.IdUsuario == id);
            return "";
        }
        public Usuario GetUsuarioById(int? id)
        {
            return _context.Usuario.FirstOrDefault(u => u.IdUsuario == id);
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
            return _context.Usuario.Any(e => e.IdUsuario == id);
        }

        public List<Usuario> GetUsuariosByEmprendimiento(int id_emprendimiento)
        {
            return _context.Usuario.Where(u => u.IdEmprendimiento == id_emprendimiento).ToList();
        }
    }
}
