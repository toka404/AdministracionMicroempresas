using Banding.Core.Models.Entities.MySql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Core.Interfaces.Repository.MySql
{
    public interface IUsuarioRepository
    {
        public Usuario GetUserByEmailUsername(string param, string password);
        public List<Usuario> GetUsuariosByEmprendimiento(int id_emprendimiento);
        public List<Usuario> GetUsuarios();
        public Usuario GetUsuarioById(int? id);
        public string GetRol(int? id);
        public void CreateUsuario(Usuario usuario);
        public void UpdateUsuario(Usuario usuario);
        public void DeleteUsuario(Usuario usuario);
        public bool UsuarioExists(int id);
        

    }
}
