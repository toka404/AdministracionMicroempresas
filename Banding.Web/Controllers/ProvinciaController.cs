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
using X.PagedList;

namespace Banding.Web.Controllers
{
    [Authorize(Roles = "admin")]
    public class ProvinciaController : Controller
    {
        private readonly IProvinciaRepository _provinciaRepository;

        public ProvinciaController(IProvinciaRepository provinciaRepository)
        {
            _provinciaRepository = provinciaRepository;
        }

        // GET: Provincia
        public async Task<IActionResult> Index(int page=1)
        {
            return View(_provinciaRepository.GetProvincias().ToPagedList(page, 5));
        }

        // GET: Provincia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var provincia = _provinciaRepository.GetProvinciaById(id);
            if (provincia == null)
            {
                return NotFound();
            }

            return View(provincia);
        }

        // GET: Provincia/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Provincia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Provincia,Nombre_Provincia")] Provincia provincia)
        {
            if (ModelState.IsValid)
            {
                _provinciaRepository.CreateProvincia(provincia);
                return RedirectToAction(nameof(Index));
            }
            return View(provincia);
        }

        // GET: Provincia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var provincia = _provinciaRepository.GetProvinciaById(id);
            if (provincia == null)
            {
                return NotFound();
            }
            return View(provincia);
        }

        // POST: Provincia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Provincia,Nombre_Provincia")] Provincia provincia)
        {
            if (id != provincia.Id_Provincia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _provinciaRepository.UpdateProvincia(provincia);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_provinciaRepository.ProvinciaExists(provincia.Id_Provincia))
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
            return View(provincia);
        }

        // GET: Provincia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var provincia = _provinciaRepository.GetProvinciaById(id);
            if (provincia == null)
            {
                return NotFound();
            }

            return View(provincia);
        }

        // POST: Provincia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var provincia = _provinciaRepository.GetProvinciaById(id);
            _provinciaRepository.DeleteProvincia(provincia);
            return RedirectToAction(nameof(Index));
        }
    }
}