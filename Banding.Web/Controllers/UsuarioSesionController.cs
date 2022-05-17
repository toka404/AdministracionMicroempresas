using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Models.Entities.MySql;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Banding.Web.Controllers
{
    [Authorize]
    public class UsuarioSesionController : Controller
    {
        private readonly IUsuarioRepository _userRepository;
        public UsuarioSesionController(IUsuarioRepository userRepository)
        {
            _userRepository = userRepository;
        }
        // GET: Usuario
        public async Task<IActionResult> Index(int page = 1)
        {
            int id_emprendimiento = int.Parse(User.Claims.ElementAt(3).Value);
            return View(_userRepository.GetUsuariosByEmprendimiento(id_emprendimiento).ToPagedList(page, 4));
        }

        // GET: Usuario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = _userRepository.GetUsuarioById(id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuario/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUsuario,IdProvincia,NombreUsuario,ApellidoUsuario,Celular,EMail,Username,Contrasena")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.IdEmprendimiento = int.Parse(User.Claims.ElementAt(3).Value);
                _userRepository.CreateUsuario(usuario);
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = _userRepository.GetUsuarioById(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUsuario,IdProvincia,NombreUsuario,ApellidoUsuario,Celular,EMail,Username,Contrasena")] Usuario usuario)
        {
            if (id != usuario.IdUsuario)
            {
                return NotFound();
            }

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
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = _userRepository.GetUsuarioById(id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = _userRepository.GetUsuarioById(id);
            _userRepository.DeleteUsuario(usuario);
            return RedirectToAction(nameof(Index));
        }
    }
}
