#pragma checksum "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e06b25a053d0869b698df75b229b768bc5cade81"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e06b25a053d0869b698df75b229b768bc5cade81", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f7619db698bd484796481168d0f971ac17277a6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Banding.Core.Models.Entities.MySql.Producto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-9\">\r\n                <div class=\"jumbotron\">\r\n                    <h1 class=\"display-4\">Bienvenido ");
#nullable restore
#line 14 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"
                                                Write(User.Claims.ElementAt(2).Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p class=\"lead\">Bienvenido a la página de adminstración de su emprendimiento.</p>\r\n                    <hr class=\"my-4\">\r\n                    <p>");
#nullable restore
#line 17 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"
                  Write(User.Claims.ElementAt(4).Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
            <div class=""col-3"">
                <div class=""notifications"">
                    <div><strong>Notificaciones</strong></div>

                    Los siguentes productos llegaron a su stock mínimo.
                    <ul>
");
#nullable restore
#line 26 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"
                     foreach(var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>");
#nullable restore
#line 28 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"
                       Write(item.Nombre_Producto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 29 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n");
#nullable restore
#line 38 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""jumbotron"">
        <h1 class=""display-4"">Banding, administración de emprendimientos</h1>
        <p class=""lead"">Bienvenido a la página de banding</p>
        <hr class=""my-4"">
        <p>Emprendimientos para todos</p>
        <p class=""lead"">
            <a class=""btn btn-primary btn-lg"" href=""#"" role=""button"">Saber más</a>
        </p>
    </div>
");
#nullable restore
#line 51 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Home\Index.cshtml"
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
