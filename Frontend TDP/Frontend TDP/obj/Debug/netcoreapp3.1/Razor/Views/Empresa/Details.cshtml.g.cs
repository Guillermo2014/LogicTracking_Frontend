#pragma checksum "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Empresa\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cf7b9e740eb96cdf6488da23383e141128d9ca0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empresa_Details), @"mvc.1.0.view", @"/Views/Empresa/Details.cshtml")]
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
#line 1 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\_ViewImports.cshtml"
using Frontend_TDP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\_ViewImports.cshtml"
using Frontend_TDP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cf7b9e740eb96cdf6488da23383e141128d9ca0", @"/Views/Empresa/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c4408ecd28af7af4fc86edad17445b79b4b0542", @"/Views/_ViewImports.cshtml")]
    public class Views_Empresa_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Frontend_TDP.Models.Empresa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Empresa\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalles empresa</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Empresa\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.idEmpresaCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Empresa\Details.cshtml"
       Write(Html.DisplayFor(model => model.idEmpresaCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Empresa\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.fechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Empresa\Details.cshtml"
       Write(Html.DisplayFor(model => model.fechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Empresa\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.razonSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Empresa\Details.cshtml"
       Write(Html.DisplayFor(model => model.razonSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Empresa\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.identificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Empresa\Details.cshtml"
       Write(Html.DisplayFor(model => model.identificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Empresa\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.departamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Empresa\Details.cshtml"
       Write(Html.DisplayFor(model => model.departamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Empresa\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ciudad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Empresa\Details.cshtml"
       Write(Html.DisplayFor(model => model.ciudad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Empresa\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Empresa\Details.cshtml"
       Write(Html.DisplayFor(model => model.direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 55 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Empresa\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 58 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Empresa\Details.cshtml"
       Write(Html.DisplayFor(model => model.telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 63 "C:\Users\PC\Desktop\TDP_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Empresa\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3cf7b9e740eb96cdf6488da23383e141128d9ca09816", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend_TDP.Models.Empresa> Html { get; private set; }
    }
}
#pragma warning restore 1591
