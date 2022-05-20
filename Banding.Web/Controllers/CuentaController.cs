using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Models.Entities.MySql;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Banding.Web.Controllers
{
    [Authorize]
    public class CuentaController : Controller
    {
        private readonly IUsuarioRepository _userRepository;
        private readonly IProvinciaRepository _provinciaRepository;
        public CuentaController(IUsuarioRepository userRepository,
            IProvinciaRepository provinciaRepository)
        {
            _userRepository = userRepository;
            _provinciaRepository = provinciaRepository;
        }
        public IActionResult Index()
        {
            int id = int.Parse(User.Claims.ElementAt(7).Value);

            var usuario = _userRepository.GetUsuarioById(id);

            ViewData["IdProvincia"] = new SelectList(_provinciaRepository.GetProvincias(), "IdProvincia", "NombreProvincia", usuario.IdProvincia);


            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string nombreProvincia, [Bind("IdEmprendimiento, IdUsuario,IdProvincia,NombreUsuario,ApellidoUsuario,Celular,EMail,Username,Contrasena, RolId")] Usuario usuario)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _userRepository.UpdateUsuario(usuario);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_userRepository.UsuarioExists(usuario.IdUsuario))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index","Home");
        }
    }
}
