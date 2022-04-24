using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Interfaces.Service;
using Banding.Core.Models.Entities.MySql;
using Banding.Repository.Data.MySql;
using Banding.Repository.DataBaseContext;
using Banding.Web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Banding.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAuthenticateUserService _authenticationService;
        private readonly IInventarioService _inventarioService;
        private readonly IProductoRepository _productoRepository;

        public HomeController(ILogger<HomeController> logger,
            IAuthenticateUserService authenticationService,
            IInventarioService inventarioService,
            IProductoRepository productoRepository)
        {
            _authenticationService = authenticationService;
            _inventarioService = inventarioService;
            _productoRepository = productoRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
            IEnumerable<Producto> listaProductos = Enumerable.Empty<Producto>();
            if (User.Claims.Any())
            {
                int idEmprendimiento = int.Parse(User.Claims.ElementAt(3).Value);
                listaProductos = _productoRepository.ProductosWithMinStock(idEmprendimiento);
                var listaEmailProductos = _productoRepository.ProductosNotEmailSent(idEmprendimiento);
                if (listaEmailProductos != null && listaEmailProductos.Count()>0)
                {
                    _inventarioService.SendEmail(listaEmailProductos, User.Claims.ElementAt(2).Value, User.Claims.ElementAt(5).Value );
                }
            }
            return View(listaProductos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet("login")]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost("login")]
        public async Task<IActionResult> LogIn(string username, string password)
        {
            var claims = _authenticationService.Validate(username, password);

            if (claims.Count != 0)
            {
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                return Redirect("/");
            }
            TempData["Error"] = "Error. Los datos ingresados no son correctos";
            return View("login");
        }
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}
