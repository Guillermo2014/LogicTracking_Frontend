#pragma checksum "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e527d179cfe9709f0ad0beb9b8f1fa29dac8d098"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
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
#line 1 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\_ViewImports.cshtml"
using Frontend_TDP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\_ViewImports.cshtml"
using Frontend_TDP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e527d179cfe9709f0ad0beb9b8f1fa29dac8d098", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c4408ecd28af7af4fc86edad17445b79b4b0542", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Frontend_TDP.Models.Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Clientes</h1>
<br />
<p>
    <!--<a asp-action=""Create"">Agregar</a>-->
    <!--<button asp-action=""Create"">Agregar</button>-->
    <a href=""/Cliente/Create""><input type=""button"" class=""btn btn-primary"" value=""Crear cliente""></a>
</p>

<div style=""overflow-x:auto;"">
    <table class=""table table-bordered table-sm table-striped"" cellspacing=""0"" width=""120%"">
        <thead class=""table-dark text-center"">
            <tr>
                <th>
                    ");
#nullable restore
#line 21 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 27 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 30 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 33 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.movil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 36 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.cargo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 39 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.empresa.razonSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    editar\r\n                </th>\r\n                <th>\r\n                    eliminar\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 50 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"text-center\">\r\n                    <td>\r\n                        <button type=\"button\" value=\"Details\" class=\"btn btn-primary\">\r\n                            ");
#nullable restore
#line 55 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
                       Write(Html.ActionLink(".", "Details", new { id = item.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 56 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </button>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 60 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 63 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 66 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 69 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.movil));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 72 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.cargo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 75 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.empresa.razonSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <button type=\"button\" value=\"Editar\" class=\"btn btn-outline-primary\">\r\n\r\n                            ");
#nullable restore
#line 80 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
                       Write(Html.ActionLink("Editar", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </button>\r\n                    </td>\r\n                    <td>\r\n                        <button type=\"button\" value=\"Eliminar\" class=\"btn btn-outline-danger\">\r\n                            ");
#nullable restore
#line 85 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
                       Write(Html.ActionLink("Eliminar", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </button>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 89 "C:\Users\PC\Desktop\NUEVO_FRONT\LogicTracking_Frontend\Frontend TDP\Frontend TDP\Views\Cliente\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>

<!--<nav aria-label=""Page navigation example"">
    <ul class=""pagination justify-content-end"">
        <li class=""page-item""><a class=""page-link"" href=""#"">Previous</a></li>
        <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
        <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
        <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
        <li class=""page-item""><a class=""page-link"" href=""#"">Next</a></li>
    </ul>
</nav>-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Frontend_TDP.Models.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
