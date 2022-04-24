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
        private readonly IUsuarioEmprendimientoRepository _usuarioEmprendimientoRepository;
        public AuthenticateUserService(IUsuarioRepository usuarioRepository,
            IEmprendimientoRepository emprendimientoRepository,
            IUsuarioEmprendimientoRepository usuarioEmprendimientoRepository  )
        {
            _usuarioRepository = usuarioRepository;
            _emprendimientoRepository = emprendimientoRepository;
            _usuarioEmprendimientoRepository = usuarioEmprendimientoRepository;

        }
        public List<Claim> Validate(string username, string password)
        {
            List<Claim> claims = new List<Claim>();
            var usuario = _usuarioRepository.GetUserByEmailUsername(username, password);
            

            if (usuario != null)
            {
                var emprendimientoAux = _usuarioEmprendimientoRepository.GetUsuarioEmprendimientoByIdUsuario(usuario.Id_Usuario);
                var emprendimiento = _emprendimientoRepository.GetEmprendimientoById(emprendimientoAux.Id_Emprendimiento);

                claims.Add(new Claim("username", usuario.Username));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, usuario.Username));
                claims.Add(new Claim(ClaimTypes.Name, usuario.Nombre_Usuario));
                claims.Add(new Claim("emprendimientoID", emprendimientoAux.Id_Emprendimiento.ToString()));
                claims.Add(new Claim("emprendimiento", emprendimiento.Nombre_Emprendimiento));
                claims.Add(new Claim("email", usuario.E_Mail));

            }
            return claims;
        }
    }
}
