#pragma checksum "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Empresa\DetailsEmpresa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11f0491032dfe56d0c16dfed096291ea956adffe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(frontsito.Pages.Empresa.Pages_Empresa_DetailsEmpresa), @"mvc.1.0.razor-page", @"/Pages/Empresa/DetailsEmpresa.cshtml")]
namespace frontsito.Pages.Empresa
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
#line 1 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\_ViewImports.cshtml"
using frontsito;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11f0491032dfe56d0c16dfed096291ea956adffe", @"/Pages/Empresa/DetailsEmpresa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d650ece085f0a102d859394c8ea4a733e9b2d132", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Empresa_DetailsEmpresa : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListEmpresa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Empresa\DetailsEmpresa.cshtml"
  
ViewData["Title"] ="Detalle Empresa";    

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Detalle Empresa</h1>\r\n<small>\r\n</small>\r\n<div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 12 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Empresa\DetailsEmpresa.cshtml"
       Write(Html.DisplayNameFor(model => Model.empresa.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 15 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Empresa\DetailsEmpresa.cshtml"
       Write(Html.DisplayFor(model => Model.empresa.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Empresa\DetailsEmpresa.cshtml"
       Write(Html.DisplayNameFor(model => Model.empresa.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Empresa\DetailsEmpresa.cshtml"
       Write(Html.DisplayFor(model => Model.empresa.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Empresa\DetailsEmpresa.cshtml"
       Write(Html.DisplayNameFor(model => model.empresa.Nit));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Empresa\DetailsEmpresa.cshtml"
       Write(Html.DisplayFor(model => model.empresa.Nit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>    \r\n<div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11f0491032dfe56d0c16dfed096291ea956adffe6292", async() => {
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
            WriteLiteral("\r\n</div>\r\n \r\n \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DetailsEmpresaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsEmpresaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsEmpresaModel>)PageContext?.ViewData;
        public MyApp.Namespace.DetailsEmpresaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
