using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Banding.Service.Services
{
    public class AuthenticateUserService : IAuthenticateUserService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IEmprendimientoRepository _emprendimientoRepository;
        private readonly IUsuarioEmprendimientosRepository _usuarioEmprendimientoRepository;
        private readonly IRolRepository _rolRepository;
        public AuthenticateUserService(IUsuarioRepository usuarioRepository,
            IEmprendimientoRepository emprendimientoRepository,
            IUsuarioEmprendimientosRepository usuarioEmprendimientoRepository,
            IRolRepository rolRepository)
        {
            _usuarioRepository = usuarioRepository;
            _emprendimientoRepository = emprendimientoRepository;
            _usuarioEmprendimientoRepository = usuarioEmprendimientoRepository;
            _rolRepository = rolRepository;

        }
        public List<Claim> Validate(string username, string password)
        {
            List<Claim> claims = new List<Claim>();
            var usuario = _usuarioRepository.GetUserByEmailUsername(username, password);


            if (usuario != null)
            {
                var emprendimiento = _emprendimientoRepository.GetEmprendimientoById(usuario.IdEmprendimiento);
                string rol = _rolRepository.GetNameRol(usuario.RolId);

                claims.Add(new Claim("username", usuario.Username));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, usuario.Username));
                claims.Add(new Claim(ClaimTypes.Name, usuario.NombreUsuario));
                claims.Add(new Claim("emprendimientoID", emprendimiento.IdEmprendimiento.ToString()));
                claims.Add(new Claim("emprendimiento", emprendimiento.NombreEmprendimiento));
                claims.Add(new Claim("email", usuario.EMail));
                claims.Add(new Claim(ClaimTypes.Role, rol));
                claims.Add(new Claim("id_usuario", usuario.IdUsuario.ToString()));

            }
            return claims;
        }
    }
}
