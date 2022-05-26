using Banding.Core.Interfaces.Repository.MySql;
using Banding.Core.Interfaces.Service;
using Banding.Repository.Data.MySql;
using Banding.Repository.MySql;
using Banding.Service.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Banding.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //DB
            services.AddDbContext<MyDbContext>(options => options.UseMySQL(Configuration.GetConnectionString("Default")));

            //Repository
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IProductoRepository, ProductoRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IEmprendimientoRepository, EmprendimientoRepository>();
            services.AddScoped<IUsuarioEmprendimientosRepository, UsuarioEmprendimientosRepository>();
            services.AddScoped<IIvaRepository, IvaRepository>();
            services.AddScoped<IProveedorRepository, ProveedorRepository>();
            services.AddScoped<IProvinciaRepository, ProvinciaRepository>();
            services.AddScoped<IRolRepository, RolRepository>();
            services.AddScoped<IDetalleFacturaRepository, DetalleFacturaRepository>();
            services.AddScoped<IFacturaCabeceraRepository, FacturaCabeceraRepository>();
            services.AddScoped<IProductoTieneProveedorRepository, ProductoTieneProveedorRepository>();

            //Service
            services.AddTransient<IAuthenticateUserService, AuthenticateUserService>();
            services.AddTransient<IInventarioService, InventarioService>();
            services.AddTransient<IFacturacionService, FacturacionService>();
            services.AddTransient<IValidationService, ValidationService>();

            services.AddControllersWithViews();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            
            services.AddControllersWithViews().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);


            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).
               AddCookie(options =>
               {
                   options.LoginPath = "/login";
                   options.Events = new CookieAuthenticationEvents()
                   {
                       OnSigningIn = async context =>
                       {
                       }
                   };
               });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
