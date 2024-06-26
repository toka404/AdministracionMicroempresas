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
    public class IvaController : Controller
    {
        private readonly IIvaRepository _ivaRepository;
        public IvaController(IIvaRepository ivaRepository)
        {
            _ivaRepository = ivaRepository;
        }

        // GET: Iva
        public async Task<IActionResult> Index(int page = 1)
        {
            return View(_ivaRepository.GetIvas().ToPagedList(page, 5));
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
        public async Task<IActionResult> Create([Bind("IdIva,ValorIva")] Iva iva)
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
        public async Task<IActionResult> Edit(int id, [Bind("IdIva,ValorIva")] Iva iva)
        {
            if (id != iva.IdIva)
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
                    if (!_ivaRepository.IvaExists(iva.IdIva))
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
