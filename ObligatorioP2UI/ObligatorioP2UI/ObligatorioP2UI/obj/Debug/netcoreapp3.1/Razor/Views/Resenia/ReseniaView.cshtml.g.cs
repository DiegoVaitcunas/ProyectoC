#pragma checksum "C:\Users\alvez\OneDrive\Escritorio\ObligatorioP2UI\ObligatorioP2UI\Views\Resenia\ReseniaView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfe1e8bb7295b692702abbb1de4b4f02d395d0ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Resenia_ReseniaView), @"mvc.1.0.view", @"/Views/Resenia/ReseniaView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfe1e8bb7295b692702abbb1de4b4f02d395d0ca", @"/Views/Resenia/ReseniaView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5317fd6ef6a7a63b5377651ab44bbfa543f29412", @"/Views/_ViewImports.cshtml")]
    public class Views_Resenia_ReseniaView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Resenia/ReseniaView"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfe1e8bb7295b692702abbb1de4b4f02d395d0ca3961", async() => {
                WriteLiteral("\r\n\r\n    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=", 210, "", 233, 1);
#nullable restore
#line 9 "C:\Users\alvez\OneDrive\Escritorio\ObligatorioP2UI\ObligatorioP2UI\Views\Resenia\ReseniaView.cshtml"
WriteAttributeValue("", 217, ViewBag.Partido, 217, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""partidoId"" />

    <div class=""form-outline mb-4"">
        <label class=""form-label"" for=""usuario"">Titulo de reseña: </label>
        <input type=""text"" id=""Titulo"" class=""form-control"" name=""Titulo"" />
    </div>

    <div class=""form-outline mb-4"">
        <label class=""form-label"" for=""form2Example2"">Reseña</label>
        <textarea cols=""20"" id=""resenia"" name=""Contenido"" rows=""2""></textarea>
    </div>
    <button type=""submit"" class=""btn btn-primary btn-block mb-4"">Enviar resenia</button>

");
#nullable restore
#line 22 "C:\Users\alvez\OneDrive\Escritorio\ObligatorioP2UI\ObligatorioP2UI\Views\Resenia\ReseniaView.cshtml"
     if (ViewBag.NombreError != null)
    {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\alvez\OneDrive\Escritorio\ObligatorioP2UI\ObligatorioP2UI\Views\Resenia\ReseniaView.cshtml"
       Write(ViewBag.NombreError);

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\alvez\OneDrive\Escritorio\ObligatorioP2UI\ObligatorioP2UI\Views\Resenia\ReseniaView.cshtml"
                                
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591