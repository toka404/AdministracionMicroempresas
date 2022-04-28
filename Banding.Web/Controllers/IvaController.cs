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
    public class IvaController : Controller
    {
        private readonly IIvaRepository _ivaRepository;
        public IvaController(IIvaRepository ivaRepository)
        {
            _ivaRepository = ivaRepository;
        }

        // GET: Iva
        public async Task<IActionResult> Index()
        {
            return View(_ivaRepository.GetIvas());
        }

        // GET: Iva/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iva = _ivaRepository.GetIvaById(id);
            if (iva == null)
            {
                return NotFound();
            }

            return View(iva);
        }

        // GET: Iva/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Iva/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Iva,Valor_Iva")] Iva iva)
        {
            if (ModelState.IsValid)
            {
                _ivaRepository.CreateIva(iva);
                return RedirectToAction(nameof(Index));
            }
            return View(iva);
        }

        // GET: Iva/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iva = _ivaRepository.GetIvaById(id);
            if (iva == null)
            {
                return NotFound();
            }
            return View(iva);
        }

        // POST: Iva/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Iva,Valor_Iva")] Iva iva)
        {
            if (id != iva.Id_Iva)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _ivaRepository.UpdateIva(iva);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_ivaRepository.IvaExists(iva.Id_Iva))
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
            return View(iva);
        }

        // GET: Iva/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iva = _ivaRepository.GetIvaById(id);
            if (iva == null)
            {
                return NotFound();
            }

            return View(iva);
        }

        // POST: Iva/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var iva = _ivaRepository.GetIvaById(id);
            _ivaRepository.DeleteIva(iva);
            return RedirectToAction(nameof(Index));
        }

    }
}
