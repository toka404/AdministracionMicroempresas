#pragma checksum "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Historico\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ce46367401570722001019096c92897e2469954"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Historico_Index), @"mvc.1.0.view", @"/Views/Historico/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Historico\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Historico\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Historico\Index.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ce46367401570722001019096c92897e2469954", @"/Views/Historico/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f7619db698bd484796481168d0f971ac17277a6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Historico_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Banding.Core.Models.ViewModels.FacturaViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_NavbarStylePartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""container-xxl hero-header"" style=""padding-bottom:0px"">
    <div class=""container"">

        <div class=""contenedor-grande"" style=""margin:20px 400px;"">
            <div class=""row"">
                <div class=""col-1""></div>
                <div class=""col-10"">
                    <div>
                        <div class=""row"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ce46367401570722001019096c92897e24699545494", async() => {
                WriteLiteral(@"
                                <h5>Fecha Inicio</h5>
                                <input type=""date"" name=""fechaInicio"" class=""form-control mar2"" />
                                <br />
                                <h5>Fecha Fin</h5>
                                <input type=""date"" name=""fechaFin"" class=""form-control mar2"" />

                                <br />
                                <input type=""submit"" value=""Consultar"" class=""btn btn-dark"" />
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n                <div class=\"col-1\"></div>\r\n            </div>\r\n\r\n            <br />\r\n        </div>>\r\n\r\n        <br />\r\n\r\n");
#nullable restore
#line 38 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Historico\Index.cshtml"
         if (@Model.Count() != 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"contenedor-grande\">\r\n\r\n");
            WriteLiteral("                <h3 style=\"text-align:center\">Mostrando resultados desde ");
#nullable restore
#line 50 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Historico\Index.cshtml"
                                                                    Write(ViewData["fechaInicio"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" hasta ");
#nullable restore
#line 50 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Historico\Index.cshtml"
                                                                                                   Write(ViewData["fechaFin"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h3>

                <table class=""table"">
                    <thead>
                        <tr>
                            <th>
                                Producto
                            </th>
                            <th>
                                Cantidad Vendida
                            </th>
                            <th>
                                Fecha de Venta
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 67 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Historico\Index.cshtml"
                         foreach (var factura in Model)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Historico\Index.cshtml"
                             foreach (var detalle in factura.DetalleFactura)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 73 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Historico\Index.cshtml"
                                   Write(detalle.NombreProducto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 76 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Historico\Index.cshtml"
                                   Write(detalle.CantidadVendida);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 79 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Historico\Index.cshtml"
                                   Write(factura.CabeceraFactura.FechaCabecera.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 82 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Historico\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Historico\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n");
#nullable restore
#line 87 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Historico\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6ce46367401570722001019096c92897e246995412307", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Banding.Core.Models.ViewModels.FacturaViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
