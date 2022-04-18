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
        private readonly MyDbContext _contexto;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MyDbContext context)
        {
            _contexto = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_contexto.Provincia.FirstOrDefault());
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
        public IActionResult LogIn(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        [HttpPost("login")]
        public async Task<IActionResult> Validate(string username, string password, string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            var usuario = _contexto.Usuario.Where(u => (u.Username.Equals(username) || u.E_Mail.Equals(username))
            && u.Contrasena.Equals(password)).SingleOrDefault();
            if (usuario != null)
            {
                var claims = new List<Claim>();
                claims.Add(new Claim("username", usuario.Username));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, usuario.Username));
                claims.Add(new Claim(ClaimTypes.Name, usuario.Nombre_Usuario));

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
