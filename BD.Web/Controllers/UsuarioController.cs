using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Banding.Repository.DataBaseContext;
using Banding.Core.Models.Entities.MySql;
using Banding.Core.ViewModels;


namespace BD.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly MyDbContext _context;

        public UsuarioController(MyDbContext context)
        {
            _context = context;
        }

        // GET: Usuario
        public async Task<IActionResult> Index()
        {
            var usuarios = new UsuarioEmprendimientoViewModel();
            usuarios.Usuarios = await _context.Usuario.ToListAsync();
            var emprendimientos = await _context.Usuario_Tiene_Emprendimientos.ToListAsync();

            

            //Guardar los nombres de los emprendimientos por cada usuario
            var emprendimientoUsuario = new List<List<string>>();
            foreach (var usuario in usuarios.Usuarios)
            {
                var aux = new List<string>();
                foreach (var empUsuarios in emprendimientos)
                {
                    if(usuario.Id_Usuario == empUsuarios.Id_Usuario)
                    {
                        Emprendimiento emprendimientoAux = await _context.Emprendimiento.Where(e => e.Id_Emprendimiento == empUsuarios.Id_Emprendimiento).SingleOrDefaultAsync();
                        string nombreEmprendimiento = emprendimientoAux.Nombre_Emprendimiento;
                        aux.Add(nombreEmprendimiento);
                    }
                }
                emprendimientoUsuario.Add(aux);
            }

            usuarios.EmprendimientosUsuario = emprendimientoUsuario;

            return View(usuarios);
        }

        // GET: Usuario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuario
                .FirstOrDefaultAsync(m => m.Id_Usuario == id);
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
        public async Task<IActionResult> Create([Bind("Id_Usuario,Id_Provincia,Nombre_Usuario,Apellido_Usuario,Celular,E_Mail,Username,Contrasena")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
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

            var usuario = await _context.Usuario.FindAsync(id);
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
        public async Task<IActionResult> Edit(int id, [Bind("Id_Usuario,Id_Provincia,Nombre_Usuario,Apellido_Usuario,Celular,E_Mail,Username,Contrasena")] Usuario usuario)
        {
            if (id != usuario.Id_Usuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id_Usuario))
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

            var usuario = await _context.Usuario
                .FirstOrDefaultAsync(m => m.Id_Usuario == id);
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
            var usuario = await _context.Usuario.FindAsync(id);
            _context.Usuario.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuario.Any(e => e.Id_Usuario == id);
        }
    }
}
