#pragma checksum "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Cliente\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "901ac123a3fd641bc2df0d536a878f762f3f7f6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(frontsito.Pages.Cliente.Pages_Cliente_Details), @"mvc.1.0.razor-page", @"/Pages/Cliente/Details.cshtml")]
namespace frontsito.Pages.Cliente
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"901ac123a3fd641bc2df0d536a878f762f3f7f6b", @"/Pages/Cliente/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d650ece085f0a102d859394c8ea4a733e9b2d132", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cliente_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Cliente\Details.cshtml"
  
    ViewData["Title"] ="Detalle Persona";
    

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "901ac123a3fd641bc2df0d536a878f762f3f7f6b3798", async() => {
                WriteLiteral(@"
    <title>Educational registration form</title>
    <link rel=""stylesheet"" href=""Empresa.css"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.4.1/css/all.css"" integrity=""sha384-5sAR7xN1Nv6T6+dT2mhtzEpVJvfS3NScPQTrOxhwjIuvcA67KV2R5Jz6kr4abQsz"" crossorigin=""anonymous"">
    
    <link href=""https://fonts.googleapis.com/css?family=Roboto:300,400,500,700"" rel=""stylesheet"">
   
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h1>Detalle Cliente</h1>\r\n<small>\r\n</small>\r\n<div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Cliente\Details.cshtml"
       Write(Html.DisplayNameFor(model => Model.cliente.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Cliente\Details.cshtml"
       Write(Html.DisplayFor(model => Model.cliente.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 30 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Cliente\Details.cshtml"
       Write(Html.DisplayNameFor(model => Model.cliente.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 33 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Cliente\Details.cshtml"
       Write(Html.DisplayFor(model => Model.cliente.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Cliente\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.cliente.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Cliente\Details.cshtml"
       Write(Html.DisplayFor(model => model.cliente.Edad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 46 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Cliente\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.cliente.NumeroTelefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Cliente\Details.cshtml"
       Write(Html.DisplayFor(model => model.cliente.NumeroTelefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 54 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Cliente\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.cliente.TipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 57 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Cliente\Details.cshtml"
       Write(Html.DisplayFor(model => model.cliente.TipoDocumento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </div>\r\n    <div class=\"row\">\r\n        <dt class=\"col-md-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Cliente\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.cliente.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n        </dt>\r\n        <dd class=\"col-md-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\IEDTISQUESUSA\Documents\GitHub\TeamRocket\Equipo rocket\frontsito\Pages\Cliente\Details.cshtml"
       Write(Html.DisplayFor(model => model.cliente.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </div>
</div>

<div class=""main-block"">
      <div class=""left-part"">       
        <i class=""fas fa-user-astronaut""></i>  
        <div class=""contenedor"">
          <img src=""images\ER_background.jpg"" alt=""Equipo Rocket"">
          
         
          <div class=""texto-debajo"">
            <h1>Equipo rocket</h1> 
          </div>
         
        </div>  
                       
      </div>
      
      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "901ac123a3fd641bc2df0d536a878f762f3f7f6b10267", async() => {
                WriteLiteral("\r\n        <div class=\"title\">\r\n          <i class=\"fas fa-pencil-alt\"></i> \r\n          <h2>Registro Cliente</h2>\r\n        </div>\r\n        <div class=\"info\">\r\n          <input type=\"number\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 2885, "\"", 2893, 0);
                EndWriteAttribute();
                WriteLiteral(@"placeholder=""Id"">
          <input type=""text"" name=""NumeroTelefono"" placeholder=""Numero de telefono"">
          <input class=""name"" type=""text"" name=""Nombre"" placeholder=""Nombre"">
          <input type=""number"" name=""Edad"" placeholder=""Edad"">
          <input type=""number"" name=""TipoDocumento"" placeholder=""Tipo de Documento"">
          <input type=""number"" name=""Documento"" placeholder=""Documento"">
        
          <!--
          
          <input type=""text"" name=""name"" placeholder=""Phone number"">
          <input type=""password"" name=""name"" placeholder=""Password"">
           <select>
            <option value=""course-type"" selected>Course type*</option>
            <option value=""short-courses"">Short courses</option>
            <option value=""featured-courses"">Featured courses</option>
            <option value=""undergraduate"">Undergraduate</option>
            <option value=""diploma"">Diploma</option>
            <option value=""certificate"">Certificate</option>
            <option value");
                WriteLiteral(@"=""masters-degree"">Masters degree</option>
            <option value=""postgraduate"">Postgraduate</option>
          </select>
        </div>
        <div class=""checkbox"">
          <input type=""checkbox"" name=""checkbox""><span>I agree to the <a href=""https://www.w3docs.com/privacy-policy"">Privacy Poalicy for W3Docs.</a></span>
        
        </div>
      <button type=""submit"" href=""/"">Enviar</button>
      -->        
        <div class=""btn-group"" align=""center"">
          <a class=""btn-item"" >Guardar</a>
          <a class=""btn-item"" >Cancelar</a>
        </div>
      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.DetailsModel>)PageContext?.ViewData;
        public MyApp.Namespace.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
