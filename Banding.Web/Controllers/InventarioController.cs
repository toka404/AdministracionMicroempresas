using Banding.Repository.DataBaseContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Banding.Web.Controllers
{
    [Authorize]
    public class InventarioController : Controller
    {
        private readonly MyDbContext _context;
        public InventarioController(MyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var productos = _context.Producto.Where(p => p.Id_Emprendimiento == Convert.ToInt32(User.Claims.ElementAt(3).Value)).ToList();
            return View(productos);
        }
    }
}
