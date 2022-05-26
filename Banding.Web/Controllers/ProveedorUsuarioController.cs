using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Models.Entities.MySql;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Banding.Web.Controllers
{
    [Authorize]
    public class ProveedorUsuarioController : Controller
    {
        private readonly IProveedorRepository _proveedorRepository;
        private readonly IProvinciaRepository _provinciaRepository;
        private readonly IProductoTieneProveedorRepository _productoTieneProveedorRepository;
        private readonly IProductoRepository _productoRepository;
        public ProveedorUsuarioController(IProveedorRepository proveedorRepository,
            IProvinciaRepository provinciaRepository,
            IProductoTieneProveedorRepository productoTieneProveedorRepository,
            IProductoRepository productoRepository)
        {
            _proveedorRepository = proveedorRepository;
            _provinciaRepository = provinciaRepository;
            _productoTieneProveedorRepository = productoTieneProveedorRepository;
            _productoRepository = productoRepository;
        }
        public IActionResult Index(int page = 1)
        {
            int idEmprendimiento = int.Parse(User.Claims.ElementAt(3).Value);

            return View(_proveedorRepository.GetProveedoresByEmprendimiento(idEmprendimiento).ToPagedList(page, 4));
        }
        // GET: Proveedor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proveedor = _proveedorRepository.GetProveedorById(id);
            if (proveedor == null)
            {
                return NotFound();
            }

            return View(proveedor);
        }

        // GET: Proveedor/Create
        public IActionResult Create()
        {
            int idEmprendimiento = int.Parse(User.Claims.ElementAt(3).Value);


            ViewData["IdProvincia"] = new SelectList(_provinciaRepository.GetProvincias(), "IdProvincia", "NombreProvincia");
            ViewData["IdProducto"] = new SelectList(_productoRepository.GetProductosByEmprendimiento(idEmprendimiento), "IdProducto", "NombreProducto");
            return View();
        }

        // POST: Proveedor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdProveedor,IdProvincia,NombreProveedor,Telefono,EMailProveedor,Producto,Ruc")] Proveedor proveedor)
        {
            if (ModelState.IsValid)
            {
                _proveedorRepository.CreateProveedor(proveedor);
                _productoTieneProveedorRepository.CreateProveedor(proveedor.IdProveedor, proveedor.Producto);
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdProvincia"] = new SelectList(_provinciaRepository.GetProvincias(), "IdProvincia", "NombreProvincia", proveedor.IdProvincia);
            return View(proveedor);
        }

        // GET: Proveedor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proveedor = _proveedorRepository.GetProveedorById(id);
            if (proveedor == null)
            {
                return NotFound();
            }
            ViewData["IdProvincia"] = new SelectList(_provinciaRepository.GetProvincias(), "IdProvincia", "NombreProvincia", proveedor.IdProvincia);

            return View(proveedor);
        }

        // POST: Proveedor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdProveedor,IdProvincia,NombreProveedor,Telefono,EMailProveedor,Producto,Ruc")] Proveedor proveedor)
        {
            if (id != proveedor.IdProveedor)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _proveedorRepository.UpdateProveedor(proveedor);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_proveedorRepository.ProveedorExists(proveedor.IdProveedor))
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
            ViewData["IdProvincia"] = new SelectList(_provinciaRepository.GetProvincias(), "IdProvincia", "NombreProvincia", proveedor.IdProvincia);
            return View(proveedor);
        }

        // GET: Proveedor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proveedor = _proveedorRepository.GetProveedorById(id);
            if (proveedor == null)
            {
                return NotFound();
            }

            return View(proveedor);
        }

        // POST: Proveedor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proveedor = _proveedorRepository.GetProveedorById(id);
            _productoTieneProveedorRepository.DeleteProveedor(id);
            _proveedorRepository.DeleteProveedor(proveedor);
            return RedirectToAction(nameof(Index));
        }
    }
}
