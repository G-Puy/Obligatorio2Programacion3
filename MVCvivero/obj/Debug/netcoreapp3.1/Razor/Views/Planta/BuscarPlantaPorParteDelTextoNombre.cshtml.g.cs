#pragma checksum "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\Planta\BuscarPlantaPorParteDelTextoNombre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bab46b8b695d4323976059773c09019ab8414250"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planta_BuscarPlantaPorParteDelTextoNombre), @"mvc.1.0.view", @"/Views/Planta/BuscarPlantaPorParteDelTextoNombre.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bab46b8b695d4323976059773c09019ab8414250", @"/Views/Planta/BuscarPlantaPorParteDelTextoNombre.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c0e3ca78a4761f3a26a4ecdfd77ec26021a3f8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Planta_BuscarPlantaPorParteDelTextoNombre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dominio.EntidadesNegocio.Planta>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formBuscaPlantaTexto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-dark text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\Planta\BuscarPlantaPorParteDelTextoNombre.cshtml"
  
    ViewData["Title"] = "BuscarPlantaPorParteDelTextoNombre";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bab46b8b695d4323976059773c09019ab84142506451", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"row justify-content-center\">\r\n        <div class=\"col-5\">\r\n            <h1 class=\"text-center\">Buscar Planta por Texto o parte del mismo</h1>\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bab46b8b695d4323976059773c09019ab84142506900", async() => {
                    WriteLiteral(@"
                <label class=""control-label"" for=""buscarPlanta"">Buscar una planta por parte del texto:</label>
                <input class=""form-control"" type=""text"" placeholder=""Ingrese una palabra"" name=""textoBuscado"" id=""inputBuscarTexto"" /> <br />
                <input type=""submit"" value=""Buscar Planta"" class=""btn btn-primary mt-4"" />
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <p id=\"pMensaje\" class=\"text-danger pt-3\"></p>\r\n            <div>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bab46b8b695d4323976059773c09019ab84142508975", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <span class=\"ml-3 text-danger\">");
#nullable restore
#line 26 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\Planta\BuscarPlantaPorParteDelTextoNombre.cshtml"
                              Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n    <div class=\"row\">\r\n        <div class=\"col-12\">\r\n");
#nullable restore
#line 29 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\Planta\BuscarPlantaPorParteDelTextoNombre.cshtml"
             if (ViewBag.lst > 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <table class=""table text-light"">
                    <thead>
                        <tr>
                            <th>Foto</th>
                            <th>Nombre Cientifico</th>
                            <th>Nombres Vulgares</th>
                            <th>Descripcion</th>
                            <th>Tipo de Ambiente</th>
                            <th>Cantidad de Riego</th>
                            <th>Unidad de Riego</th>
                            <th>Temperatura</th>
                            <th>Tipo de Iluminacion</th>
                            <th>Tipo de Planta</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 47 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\Planta\BuscarPlantaPorParteDelTextoNombre.cshtml"
                         foreach (var item in ViewBag.LstPlantas)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>\r\n");
#nullable restore
#line 51 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\Planta\BuscarPlantaPorParteDelTextoNombre.cshtml"
                                     foreach (var foto in item.FotosDePlanta)
                                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bab46b8b695d4323976059773c09019ab841425012843", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2239, "~/img/", 2239, 6, true);
#nullable restore
#line 54 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\Planta\BuscarPlantaPorParteDelTextoNombre.cshtml"
AddHtmlAttributeValue("", 2245, foto.NombreFoto, 2245, 16, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\Planta\BuscarPlantaPorParteDelTextoNombre.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </td>\r\n\r\n                                <td>\r\n                                    ");
#nullable restore
#line 59 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\Planta\BuscarPlantaPorParteDelTextoNombre.cshtml"
                               Write(item.NombreCientifico);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 62 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\Planta\BuscarPlantaPorParteDelTextoNombre.cshtml"
                               Write(item.NombresVulgares);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 65 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\Planta\BuscarPlantaPorParteDelTextoNombre.cshtml"
                               Write(item.DescripcionPlanta);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 68 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\Planta\BuscarPlantaPorParteDelTextoNombre.cshtml"
                               Write(item.TipoAmbiente);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 71 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\Planta\BuscarPlantaPorParteDelTextoNombre.cshtml"
                               Write(item.CuidadosPlanta.CantidadFrecRiego);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 74 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\Planta\BuscarPlantaPorParteDelTextoNombre.cshtml"
                               Write(item.CuidadosPlanta.UnidadFrecRiego);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 77 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\Planta\BuscarPlantaPorParteDelTextoNombre.cshtml"
                               Write(item.CuidadosPlanta.Temperatura);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 80 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\Planta\BuscarPlantaPorParteDelTextoNombre.cshtml"
                               Write(item.CuidadosPlanta.TipoIluminacion.NombreTipoIluminacion);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 83 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\Planta\BuscarPlantaPorParteDelTextoNombre.cshtml"
                               Write(item.Tipo.NomTipoPlanta);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                            </tr>\r\n");
#nullable restore
#line 87 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\Planta\BuscarPlantaPorParteDelTextoNombre.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 90 "C:\Users\Fran\OneDrive\Escritorio\ORT\SEMESTRE 3\Programacion 3\OBLIGATORIO P3 2\P3OblViveroV8 20-06-2022 11-57\ViveroProgram\MVCvivero\Views\Planta\BuscarPlantaPorParteDelTextoNombre.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        \r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        document.querySelector(""#formBuscaPlantaTexto"").addEventListener('submit', validarBuscarPlantaPorTexto);
        function validarBuscarPlantaPorTexto(evento) {
            evento.preventDefault();
            let buscarTexto = document.querySelector(""#inputBuscarTexto"").value;

            let mensaje = """";
            if (buscarTexto != """") {
                this.submit();
            }
            else {
                mensaje = ""Error, al menos debe ingresar una letra o palabra para su busqueda."";
            }
            document.querySelector(""#pMensaje"").innerHTML = mensaje;
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dominio.EntidadesNegocio.Planta>> Html { get; private set; }
    }
}
#pragma warning restore 1591