#pragma checksum "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae8ab0166f53efab2e4d6e524e784317d99ba43f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Delete), @"mvc.1.0.view", @"/Views/Usuario/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae8ab0166f53efab2e4d6e524e784317d99ba43f", @"/Views/Usuario/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f7619db698bd484796481168d0f971ac17277a6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Usuario_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Banding.Core.Models.Entities.MySql.Usuario>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/_NavbarStylePartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-xxl hero-header"" style=""padding-bottom:0px"">
    <div class=""contenedor-middle"">


        <div>
            <hr />
            <div class=""row"">
                <div class=""col-2""></div>
                <div class=""col-8"">
                            <h3 style=""text-align:center;"">¿Estás seguro de eliminar el usuario seleccionado?</h3>

                <dl class=""row"">
                 <div class=""col-sm-2""></div>   
                <dt class = ""col-sm-4"">
                    ");
#nullable restore
#line 21 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.NombreUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-4\">\r\n                    ");
#nullable restore
#line 24 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
               Write(Html.DisplayFor(model => model.NombreUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                 <div class=\"col-sm-2\"></div>   \r\n\r\n                 <div class=\"col-sm-2\"></div>   \r\n                <dt class = \"col-sm-4\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.ApellidoUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-4\">\r\n                    ");
#nullable restore
#line 33 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
               Write(Html.DisplayFor(model => model.ApellidoUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                 <div class=\"col-sm-2\"></div>   \r\n\r\n                <div class=\"col-sm-2\"></div>   \r\n                <dt class = \"col-sm-4\">\r\n                    ");
#nullable restore
#line 39 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-4\">\r\n                    ");
#nullable restore
#line 42 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Celular));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                 <div class=\"col-sm-2\"></div>   \r\n\r\n                <div class=\"col-sm-2\"></div>   \r\n                <dt class = \"col-sm-4\">\r\n                    ");
#nullable restore
#line 48 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.EMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-4\">\r\n                    ");
#nullable restore
#line 51 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
               Write(Html.DisplayFor(model => model.EMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <div class=\"col-sm-2\"></div> \r\n\r\n                <div class=\"col-sm-2\"></div> \r\n                <dt class = \"col-sm-4\">\r\n                    ");
#nullable restore
#line 57 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-4\">\r\n                    ");
#nullable restore
#line 60 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <div class=\"col-sm-2\"></div> \r\n\r\n                <div class=\"col-sm-2\"></div> \r\n                <dt class = \"col-sm-4\">\r\n                    ");
#nullable restore
#line 66 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Contrasena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-4\">\r\n                    ");
#nullable restore
#line 69 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Contrasena));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <div class=\"col-sm-2\"></div> \r\n\r\n                <div class=\"col-sm-2\"></div> \r\n                <dt class = \"col-sm-4\">\r\n                    ");
#nullable restore
#line 75 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.IdEmprendimientoNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-4\">\r\n                    ");
#nullable restore
#line 78 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
               Write(Html.DisplayFor(model => model.IdEmprendimientoNavigation.IdEmprendimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <div class=\"col-sm-2\"></div> \r\n\r\n                <div class=\"col-sm-2\"></div> \r\n                <dt class = \"col-sm-4\">\r\n                    ");
#nullable restore
#line 84 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.IdProvinciaNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-4\">\r\n                    ");
#nullable restore
#line 87 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
               Write(Html.DisplayFor(model => model.IdProvinciaNavigation.NombreProvincia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <div class=\"col-sm-2\"></div> \r\n\r\n                <div class=\"col-sm-2\"></div> \r\n                <dt class = \"col-sm-4\">\r\n                    ");
#nullable restore
#line 93 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.Rol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class = \"col-sm-4\">\r\n                    ");
#nullable restore
#line 96 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
               Write(Html.DisplayFor(model => model.Rol.NombreRol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <div class=\"col-sm-2\"></div> \r\n\r\n            </dl>\r\n    \r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae8ab0166f53efab2e4d6e524e784317d99ba43f13857", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ae8ab0166f53efab2e4d6e524e784317d99ba43f14132", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 103 "C:\Users\alang\Documents\GitHub\AdministracionMicroempresas\Banding.Web\Views\Usuario\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdUsuario);

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
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-dark\" style=\"margin-left: 60px\" /> |\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae8ab0166f53efab2e4d6e524e784317d99ba43f15991", async() => {
                    WriteLiteral("Regresar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n                <div class=\"col-2\"></div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ae8ab0166f53efab2e4d6e524e784317d99ba43f18646", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Banding.Core.Models.Entities.MySql.Usuario> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
