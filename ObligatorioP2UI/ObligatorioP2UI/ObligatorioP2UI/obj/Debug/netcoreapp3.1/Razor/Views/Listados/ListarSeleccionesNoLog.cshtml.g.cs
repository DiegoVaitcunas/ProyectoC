#pragma checksum "C:\Users\alvez\OneDrive\Escritorio\ObligatorioP2UI\ObligatorioP2UI\Views\Listados\ListarSeleccionesNoLog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01944ba375233fe04f229b13023c4f6045360c0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Listados_ListarSeleccionesNoLog), @"mvc.1.0.view", @"/Views/Listados/ListarSeleccionesNoLog.cshtml")]
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
#line 1 "C:\Users\alvez\OneDrive\Escritorio\ObligatorioP2UI\ObligatorioP2UI\Views\_ViewImports.cshtml"
using ObligatorioP2UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alvez\OneDrive\Escritorio\ObligatorioP2UI\ObligatorioP2UI\Views\_ViewImports.cshtml"
using ObligatorioP2UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alvez\OneDrive\Escritorio\ObligatorioP2UI\ObligatorioP2UI\Views\Listados\ListarSeleccionesNoLog.cshtml"
using Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01944ba375233fe04f229b13023c4f6045360c0e", @"/Views/Listados/ListarSeleccionesNoLog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5317fd6ef6a7a63b5377651ab44bbfa543f29412", @"/Views/_ViewImports.cshtml")]
    public class Views_Listados_ListarSeleccionesNoLog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Seleccion>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>Listado de selecciones ordenadas</h3>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>#</th>\r\n            <th>Nombre</th>\r\n            <th>Jugadores</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 21 "C:\Users\alvez\OneDrive\Escritorio\ObligatorioP2UI\ObligatorioP2UI\Views\Listados\ListarSeleccionesNoLog.cshtml"
          
            int i = 0;

            foreach (Seleccion s in Model)
            {
                i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\alvez\OneDrive\Escritorio\ObligatorioP2UI\ObligatorioP2UI\Views\Listados\ListarSeleccionesNoLog.cshtml"
                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\alvez\OneDrive\Escritorio\ObligatorioP2UI\ObligatorioP2UI\Views\Listados\ListarSeleccionesNoLog.cshtml"
                   Write(s.unPais.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n");
#nullable restore
#line 32 "C:\Users\alvez\OneDrive\Escritorio\ObligatorioP2UI\ObligatorioP2UI\Views\Listados\ListarSeleccionesNoLog.cshtml"
                         foreach (Jugador j in s.jugadores)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\alvez\OneDrive\Escritorio\ObligatorioP2UI\ObligatorioP2UI\Views\Listados\ListarSeleccionesNoLog.cshtml"
                       Write(j.NombreCompleto);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 35 "C:\Users\alvez\OneDrive\Escritorio\ObligatorioP2UI\ObligatorioP2UI\Views\Listados\ListarSeleccionesNoLog.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 38 "C:\Users\alvez\OneDrive\Escritorio\ObligatorioP2UI\ObligatorioP2UI\Views\Listados\ListarSeleccionesNoLog.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Seleccion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
