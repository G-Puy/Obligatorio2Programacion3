#pragma checksum "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\TipoPlanta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fad89d1236739d67ea16f4ef8be84c4d2e5b41a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TipoPlanta_Index), @"mvc.1.0.view", @"/Views/TipoPlanta/Index.cshtml")]
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
#line 1 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\_ViewImports.cshtml"
using MVCvivero;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\_ViewImports.cshtml"
using MVCvivero.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fad89d1236739d67ea16f4ef8be84c4d2e5b41a6", @"/Views/TipoPlanta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c0e3ca78a4761f3a26a4ecdfd77ec26021a3f8f", @"/Views/_ViewImports.cshtml")]
    public class Views_TipoPlanta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dominio.EntidadesNegocio.TipoPlanta>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MantenimientoTipoPlanta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container-fluid bg-dark text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\TipoPlanta\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fad89d1236739d67ea16f4ef8be84c4d2e5b41a64793", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n            <h1 class=\"text-center\">Tipos Plantas</h1>\r\n            <p class=\"h5 text-center\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fad89d1236739d67ea16f4ef8be84c4d2e5b41a65232", async() => {
                    WriteLiteral("Dar de alta");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" - ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fad89d1236739d67ea16f4ef8be84c4d2e5b41a66455", async() => {
                    WriteLiteral("Mantenimiento de tipos de plantas");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n\r\n    <table class=\"table text-light\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 20 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\TipoPlanta\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\TipoPlanta\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.NomTipoPlanta));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\TipoPlanta\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DescTipoPlanta));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\TipoPlanta\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 35 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\TipoPlanta\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\TipoPlanta\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NomTipoPlanta));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\TipoPlanta\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DescTipoPlanta));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\TipoPlanta\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dominio.EntidadesNegocio.TipoPlanta>> Html { get; private set; }
    }
}
#pragma warning restore 1591
