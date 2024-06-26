﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Banding.Core.Models.Entities.MySql;
using Banding.Repository.MySql;
using Microsoft.AspNetCore.Authorization;
using Banding.Core.Interfaces.Repository.MySql;
using X.PagedList;

namespace Banding.Web.Controllers
{
    [Authorize(Roles = "admin")]
    public class EmprendimientoController : Controller
    {
        private readonly IEmprendimientoRepository _emprendimientoRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public EmprendimientoController(IEmprendimientoRepository emprendimientoRepository,
            ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
            _emprendimientoRepository = emprendimientoRepository;
        }

        // GET: Emprendimiento
        public async Task<IActionResult> Index(int page = 1)
        {
            return View(_emprendimientoRepository.GetEmprendimientos().ToPagedList(page, 4));
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
            ViewData["IdCategoria"] = new SelectList(_categoriaRepository.GetCategorias(), "IdCategoria", "NombreCategoria");
            return View();
        }

        // POST: Emprendimiento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEmprendimiento,IdCategoria,NombreEmprendimiento,DescripcionEmprendimiento,Logo")] Emprendimiento emprendimiento)
        {
            if (ModelState.IsValid)
            {
                _emprendimientoRepository.CreateEmprendimiento(emprendimiento);
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCategoria"] = new SelectList(_categoriaRepository.GetCategorias(), "IdCategoria", "NombreCategoria", emprendimiento.IdCategoria);

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
            ViewData["IdCategoria"] = new SelectList(_categoriaRepository.GetCategorias(), "IdCategoria", "NombreCategoria", emprendimiento.IdCategoria);
            return View(emprendimiento);
        }

        // POST: Emprendimiento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEmprendimiento,IdCategoria,NombreEmprendimiento,DescripcionEmprendimiento,Logo")] Emprendimiento emprendimiento)
        {
            if (id != emprendimiento.IdEmprendimiento)
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
                    if (!_emprendimientoRepository.EmprendimientoExists(emprendimiento.IdEmprendimiento))
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
            ViewData["IdCategoria"] = new SelectList(_categoriaRepository.GetCategorias(), "IdCategoria", "NombreCategoria", emprendimiento.IdCategoria);
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
