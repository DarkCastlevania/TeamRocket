#pragma checksum "C:\Users\ANDRE\OneDrive\Documentos\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Directivo\DetailsDirectivo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36654e00466f43c239acffd35847ad7140c958b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(frontsito.Pages.Directivo.Pages_Directivo_DetailsDirectivo), @"mvc.1.0.razor-page", @"/Pages/Directivo/DetailsDirectivo.cshtml")]
namespace frontsito.Pages.Directivo
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
#line 1 "C:\Users\ANDRE\OneDrive\Documentos\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\_ViewImports.cshtml"
using frontsito;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36654e00466f43c239acffd35847ad7140c958b4", @"/Pages/Directivo/DetailsDirectivo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d650ece085f0a102d859394c8ea4a733e9b2d132", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Directivo_DetailsDirectivo : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListDirectivo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ANDRE\OneDrive\Documentos\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Directivo\DetailsDirectivo.cshtml"
  
ViewData["Title"] ="Detalle Directivo";    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalle Directivo</h1>\r\n<small>\r\n</small>\r\n<div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\ANDRE\OneDrive\Documentos\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Directivo\DetailsDirectivo.cshtml"
       Write(Html.DisplayNameFor(model => Model.directivo.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\ANDRE\OneDrive\Documentos\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Directivo\DetailsDirectivo.cshtml"
       Write(Html.DisplayFor(model => Model.directivo.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\ANDRE\OneDrive\Documentos\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Directivo\DetailsDirectivo.cshtml"
       Write(Html.DisplayNameFor(model => Model.directivo.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\ANDRE\OneDrive\Documentos\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Directivo\DetailsDirectivo.cshtml"
       Write(Html.DisplayFor(model => Model.directivo.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\ANDRE\OneDrive\Documentos\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Directivo\DetailsDirectivo.cshtml"
       Write(Html.DisplayNameFor(model => model.directivo.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\ANDRE\OneDrive\Documentos\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Directivo\DetailsDirectivo.cshtml"
       Write(Html.DisplayFor(model => model.directivo.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\ANDRE\OneDrive\Documentos\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Directivo\DetailsDirectivo.cshtml"
       Write(Html.DisplayNameFor(model => model.directivo.TipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\ANDRE\OneDrive\Documentos\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Directivo\DetailsDirectivo.cshtml"
       Write(Html.DisplayFor(model => model.directivo.TipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 53 "C:\Users\ANDRE\OneDrive\Documentos\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Directivo\DetailsDirectivo.cshtml"
       Write(Html.DisplayNameFor(model => model.directivo.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 56 "C:\Users\ANDRE\OneDrive\Documentos\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Directivo\DetailsDirectivo.cshtml"
       Write(Html.DisplayFor(model => model.directivo.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 61 "C:\Users\ANDRE\OneDrive\Documentos\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Directivo\DetailsDirectivo.cshtml"
       Write(Html.DisplayNameFor(model => model.directivo.GrupoEmpleados));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 64 "C:\Users\ANDRE\OneDrive\Documentos\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Directivo\DetailsDirectivo.cshtml"
       Write(Html.DisplayFor(model => model.directivo.GrupoEmpleados));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\ANDRE\OneDrive\Documentos\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Directivo\DetailsDirectivo.cshtml"
       Write(Html.DisplayNameFor(model => model.directivo.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\ANDRE\OneDrive\Documentos\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Directivo\DetailsDirectivo.cshtml"
       Write(Html.DisplayFor(model => model.directivo.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n</div>\r\n<div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36654e00466f43c239acffd35847ad7140c958b49562", async() => {
                WriteLiteral("<i class=\"fas fa-angle-double-left\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("\r\n \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DetailsDirectivoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsDirectivoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsDirectivoModel>)PageContext?.ViewData;
        public MyApp.Namespace.DetailsDirectivoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591