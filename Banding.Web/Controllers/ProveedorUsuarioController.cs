using Banding.Core.Interfaces.Repository.MySql;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using X.PagedList;

namespace Banding.Web.Controllers
{
    public class ProveedorUsuarioController : Controller
    {
        private readonly IProveedorRepository _proveedorRepository;
        public ProveedorUsuarioController(IProveedorRepository proveedorRepository)
        {
            _proveedorRepository = proveedorRepository;
        }
        public IActionResult Index(int page = 1)
        {
            int idEmprendimiento = int.Parse(User.Claims.ElementAt(3).Value);

            return View(_proveedorRepository.GetProveedoresByEmprendimiento(idEmprendimiento).ToPagedList(page, 4));
        }
    }
}
