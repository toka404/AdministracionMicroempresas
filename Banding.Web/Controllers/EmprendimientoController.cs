using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Banding.Core.Models.Entities.MySql;
using Banding.Repository.DataBaseContext;
using Microsoft.AspNetCore.Authorization;
using Banding.Core.Interfaces.Repository.MySql;

namespace Banding.Web.Controllers
{
    [Authorize(Roles = "admin")]
    public class EmprendimientoController : Controller
    {
        private readonly IEmprendimientoRepository _emprendimientoRepository;

        public EmprendimientoController(IEmprendimientoRepository emprendimientoRepository)
        {
            _emprendimientoRepository = emprendimientoRepository;
        }

        // GET: Emprendimiento
        public async Task<IActionResult> Index()
        {
            return View(_emprendimientoRepository.GetEmprendimientos());
        }

        // GET: Emprendimiento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emprendimiento = _emprendimientoRepository.GetEmprendimientoById(id);
            if (emprendimiento == null)
            {
                return NotFound();
            }

            return View(emprendimiento);
        }

        // GET: Emprendimiento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Emprendimiento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Emprendimiento,Id_Categoria,Nombre_Emprendimiento,Descripcion_Emprendimiento,Logo")] Emprendimiento emprendimiento)
        {
            if (ModelState.IsValid)
            {
                _emprendimientoRepository.CreateEmprendimiento(emprendimiento);
                return RedirectToAction(nameof(Index));
            }
            return View(emprendimiento);
        }

        // GET: Emprendimiento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emprendimiento = _emprendimientoRepository.GetEmprendimientoById(id);
            if (emprendimiento == null)
            {
                return NotFound();
            }
            return View(emprendimiento);
        }

        // POST: Emprendimiento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Emprendimiento,Id_Categoria,Nombre_Emprendimiento,Descripcion_Emprendimiento,Logo")] Emprendimiento emprendimiento)
        {
            if (id != emprendimiento.Id_Emprendimiento)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _emprendimientoRepository.UpdateEmprendimiento(emprendimiento);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_emprendimientoRepository.EmprendimientoExists(emprendimiento.Id_Emprendimiento))
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
            return View(emprendimiento);
        }

        // GET: Emprendimiento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emprendimiento = _emprendimientoRepository.GetEmprendimientoById(id);
            if (emprendimiento == null)
            {
                return NotFound();
            }

            return View(emprendimiento);
        }

        // POST: Emprendimiento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var emprendimiento = _emprendimientoRepository.GetEmprendimientoById(id);
            _emprendimientoRepository.DeleteEmprendimiento(emprendimiento);
            return RedirectToAction(nameof(Index));
        }

    }
}
