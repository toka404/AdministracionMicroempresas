using Banding.Core.Interfaces.Repository.MySql;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Banding.Web.Controllers
{
    [Authorize]
    public class CuentaController : Controller
    {
        private readonly IUsuarioRepository _userRepository;
        public CuentaController(IUsuarioRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            int id = int.Parse(User.Claims.ElementAt(7).Value);
            var usuario = _userRepository.GetUsuarioById(id);

            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }
    }
}
