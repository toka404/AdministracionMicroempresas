#pragma checksum "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a846f54188e0dd192b88db4c10a3d82b5a3e8ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Facturacion_Index), @"mvc.1.0.view", @"/Views/Facturacion/Index.cshtml")]
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
#line 1 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a846f54188e0dd192b88db4c10a3d82b5a3e8ea", @"/Views/Facturacion/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f7619db698bd484796481168d0f971ac17277a6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Facturacion_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Banding.Core.Models.ViewModels.FacturaViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark btn-footer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
  
    Layout = "_Layout";



#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
 if (!(Model.Count() > 0))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>No tiene ninguna factura</div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a846f54188e0dd192b88db4c10a3d82b5a3e8ea6394", async() => {
                WriteLiteral("Registrar Factura");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"factura-label\">\r\n            <div class=\"factura-header\">\r\n                <div class=\"container-header\">\r\n                    <div class=\"container\">\r\n                        <h2>Factura N° ");
#nullable restore
#line 27 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
                                  Write(Html.DisplayFor(model => model.First().CabeceraFactura.NroFactura));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>


                        <div class=""row"">
                            <div class=""col-8"">

                                <div class=""container"">
                                    <div class=""row"">
                                        <div class=""col-2"">
                                            <label><strong>Nombre</strong></label>
                                            <label><strong>Cédula</strong></label>
                                            <label><strong>Celular</strong></label>
                                        </div>
                                        <div class=""col-5"">
                                            <label>
                                                ");
#nullable restore
#line 42 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
                                           Write(Html.DisplayFor(model => model.First().CabeceraFactura.NombreCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </label>\r\n                                            <label>\r\n                                                ");
#nullable restore
#line 45 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
                                           Write(Html.DisplayFor(model => model.First().CabeceraFactura.CedulaCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </label>\r\n                                            <label>\r\n                                                ");
#nullable restore
#line 48 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
                                           Write(Html.DisplayFor(model => model.First().CabeceraFactura.TelefonoCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </label>
                                        </div>
                                        <div class=""col""></div>
                                    </div>
                                </div>
                            </div>

                            <div class=""col-4 align-content-end"" style=""padding:0"">
                                <div class=""container"">
                                    <div class=""row"">
                                        <div class=""col-4"">
                                            <label><strong>Fecha</strong></label>
                                            <label><strong>Dirección</strong></label>
                                        </div>
                                        <div class=""col-7"">

                                            <label>
                                                ");
#nullable restore
#line 66 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
                                           Write(Html.DisplayFor(model => model.First().CabeceraFactura.FechaCabecera));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </label>\r\n                                            <label>\r\n                                                ");
#nullable restore
#line 69 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
                                           Write(Html.DisplayFor(model => model.First().CabeceraFactura.DireccionCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </label>
                                        </div>
                                        <div class=""col"">
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <table class=""table table-footer"">
                <thead>
                    <tr>
                        <th scope=""col"">Producto</th>
                        <th scope=""col"">Cantidad</th>
                        <th scope=""col"">Precio Unitario</th>
                        <th scope=""col"">Precio Total</th>
                    </tr>
                </thead>

                <tbody>

");
#nullable restore
#line 95 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
                     foreach (var producto in item.DetalleFactura)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 98 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
                           Write(producto.NombreProducto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 99 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
                           Write(producto.CantidadVendida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>$");
#nullable restore
#line 100 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
                            Write(producto.PrecioUnitario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>$");
#nullable restore
#line 101 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
                            Write(producto.PrecioTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 103 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n\r\n            <div hidden>");
#nullable restore
#line 108 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
                   Write(Html.DisplayFor(model => model.First().CabeceraFactura.IdIva));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div hidden>");
#nullable restore
#line 109 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
                   Write(Html.DisplayFor(model => model.First().CabeceraFactura.IvaCero));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

            <div class=""container-header"">
                <div class=""factura-footer"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-2"">
                                <label><strong>Subtotal</strong></label>
                                <label><strong>Iva ");
#nullable restore
#line 117 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
                                              Write(item.Iva);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</strong></label>
                                <label><strong>Precio Total</strong></label>
                            </div>
                            <div class=""col-1"">
                                <label>
                                    ");
#nullable restore
#line 122 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
                               Write(Html.DisplayFor(model => model.First().CabeceraFactura.Subtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </label>\r\n                                <label>\r\n                                    ");
#nullable restore
#line 125 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
                               Write(Html.DisplayFor(model => model.First().CabeceraFactura.IvaTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </label>\r\n                                <label>\r\n                                    ");
#nullable restore
#line 128 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
                               Write(Html.DisplayFor(model => model.First().CabeceraFactura.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </label>
                            </div>
                            <div class=""col"">
                            </div>
                        </div>
                    </div>

                    <div class=""row"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a846f54188e0dd192b88db4c10a3d82b5a3e8ea18431", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 138 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
                              
                                int IdCabecera = item.CabeceraFactura.IdCabecera;
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a846f54188e0dd192b88db4c10a3d82b5a3e8ea19083", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 141 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => IdCabecera);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                            <input type=\"submit\" value=\"Anular\" class=\"btn btn-dark btn-footer\" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <br>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a846f54188e0dd192b88db4c10a3d82b5a3e8ea22370", async() => {
                WriteLiteral("Registrar Factura");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n                    ");
#nullable restore
#line 149 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
               Write(Html.PagedListPager((IPagedList)Model, page =>
                    Url.Action("Index", new { page = page }),
                    new PagedListRenderOptions {
                    LiElementClasses = new string[] { "page-item" },
                    PageClasses = new string[] { "page-link" }}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </div>\r\n");
#nullable restore
#line 159 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Facturacion\Index.cshtml"
     


}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Banding.Core.Models.ViewModels.FacturaViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591