#pragma checksum "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec605bb61697a325ad719e36fe83b6c5118248bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\_ViewImports.cshtml"
using Banding.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\_ViewImports.cshtml"
using Banding.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec605bb61697a325ad719e36fe83b6c5118248bc", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f7619db698bd484796481168d0f971ac17277a6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Banding.Core.Models.Entities.MySql.Producto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"       <div class=""container-xxl bg-primary hero-header"">
        <div class=""container"">
            <div class=""row g-5 align-items-center"" style=""padding:40px"">

            <div class=""container"">
            <div class=""row"">
                <div class=""col-9"">
                    <div class=""jumbotron"">
                        <h1 class=""display-4 text-white"">Bienvenido ");
#nullable restore
#line 19 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"
                                                               Write(User.Claims.ElementAt(2).Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p class=\"lead text-white\">Bienvenido a la página de adminstración de su emprendimiento.</p>\r\n                        <hr class=\"my-4\">\r\n                        <p style=\"font-size: 40px\" class=\"text-white\">");
#nullable restore
#line 22 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"
                                                                 Write(User.Claims.ElementAt(4).Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""col-3"">
                   
                            <div class=""col-md col-sm"">
                                <div class=""container bootstrap snippets bootdeys"">
                                    <div class=""row"">
                                        <div class=""col-lg wow fadeInUp"" data-wow-delay=""0.5s"">
                                            <div class=""feature-item bg-light rounded text-center"">
                                                <br>
                                                    <h5 class=""mb"">Stock Mínimo</h5>
                                                    <br>
                                                    <i class=""fa fa-4x fa-cart-flatbed text-primary mb""></i>
                                                    <br>
");
#nullable restore
#line 37 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"
                                                         if (@Model.Count() > 0)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <br />\r\n                                                    <ul>\r\n");
#nullable restore
#line 41 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"
                                                                 foreach (var item in Model)
                                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <li class=\"description\">");
#nullable restore
#line 43 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"
                                                                                   Write(item.NombreProducto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 44 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </ul>\r\n");
#nullable restore
#line 46 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div>No hay productos con el stock mínimo.</div>\r\n");
#nullable restore
#line 50 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                        <br>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>


                     



                </div>
            </div>
        </div>



            </div>
        </div>
       </div>
");
#nullable restore
#line 72 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"


}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""container-xxl bg-primary hero-header"">
                <div class=""container"">
                    <div class=""row g-5 align-items-center"" style=""padding:35px"">
                        <div class=""col-lg-6 text-center text-lg-start"" style=""margin: 0;padding: 0px 0px 0px 40px;"">
                             <h1 class=""text-white mb-4 animated slideInDown"">Una increíble forma de administrar tu emprendimiento</h1>
                                <p class=""text-white pb-3 animated slideInDown"" style=""font-size: 20px;"">Con Banding es posible administrar tu emprendimiento facilitando tus procesos de inventario y facturación sin necesidad de experiencia previa en sistemas de administración.</p>
                        </div>

                    </div>
                </div>
            </div>
");
            WriteLiteral(@"            <div class=""container-xxl py-6"">
                <div class=""container"">
                    <div class=""row g-4"">
                        <div class=""col-lg-4 wow fadeInUp"" data-wow-delay=""0.1s"">
                            <div class=""feature-item bg-light rounded text-center p-5"">
                                <i class=""fa fa-4x fa-warehouse text-primary mb-4""></i>
                                <h5 class=""mb-3"">Inventario</h5>
                                <p class=""m-0"">El manejo del inventario permite una gestión completa de los productos.</p>
                            </div>
                        </div>
                        <div class=""col-lg-4 wow fadeInUp"" data-wow-delay=""0.3s"">
                            <div class=""feature-item bg-light rounded text-center p-5"">
                                <i class=""fa fa-4x fa-chart-column text-primary mb-4""></i>
                                <h5 class=""mb-3"">Reportes</h5>
                                <p class=""m-0"">");
            WriteLiteral(@"Se generan reportes sobre datos en base a dos fechas definidas.</p>
                            </div>
                        </div>
                        <div class=""col-lg-4 wow fadeInUp"" data-wow-delay=""0.5s"">
                            <div class=""feature-item bg-light rounded text-center p-5"">
                                <i class=""fa fa-4x fa-wallet text-primary mb-4""></i>
                                <h5 class=""mb-3"">Facturación</h5>
                                <p class=""m-0"">Se permite una gestión completa de las facturas del emprendimiento.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
            WriteLiteral("            <a href=\"#\" class=\"btn btn-lg btn-primary btn-lg-square back-to-top\"><i class=\"bi bi-arrow-up\"></i></a>\r\n");
#nullable restore
#line 119 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Banding.Core.Models.Entities.MySql.Producto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
