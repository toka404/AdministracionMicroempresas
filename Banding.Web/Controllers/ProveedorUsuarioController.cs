using Banding.Core.Interfaces.Repository.MySql;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Banding.Web.Controllers
{
    public class ProveedorUsuarioController : Controller
    {
        private readonly IProveedorRepository _proveedorRepository;
        public ProveedorUsuarioController(IProveedorRepository proveedorRepository)
        {
            _proveedorRepository = proveedorRepository;
        }
        public IActionResult Index()
        {
            int idEmprendimiento = int.Parse(User.Claims.ElementAt(3).Value);
            
            return View(_proveedorRepository.GetProveedoresByEmprendimiento(idEmprendimiento));
        }
    }
}
