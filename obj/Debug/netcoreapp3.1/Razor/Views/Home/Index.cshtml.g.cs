#pragma checksum "C:\Users\BRIGITTE\Documents\PROGRAMACION\PCteoria3\PC3teoria\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "244afbfc8aef4b6d6c7546ddeed920251affce2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\BRIGITTE\Documents\PROGRAMACION\PCteoria3\PC3teoria\Views\_ViewImports.cshtml"
using PCteoria3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BRIGITTE\Documents\PROGRAMACION\PCteoria3\PC3teoria\Views\_ViewImports.cshtml"
using PCteoria3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"244afbfc8aef4b6d6c7546ddeed920251affce2f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e0a83f12074c804c7a1936dc3f93966be5132f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Registrar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<h1><center>RESULTADO</center></h1>\r\n");
#nullable restore
#line 6 "C:\Users\BRIGITTE\Documents\PROGRAMACION\PCteoria3\PC3teoria\Views\Home\Index.cshtml"
 if (Model.Count == 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <tr>
                <td colspan=""9"" class=""text-center"">Lista de pedidos registrados.</td>
                
            </tr><br>
            <tr>
                 <td colspan=""9"" class=""text-center"">  <a href=""/Home/Registrar"" class=""btn btn-info"">Registrar</a></td>
              
                
            </tr>
");
#nullable restore
#line 16 "C:\Users\BRIGITTE\Documents\PROGRAMACION\PCteoria3\PC3teoria\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\BRIGITTE\Documents\PROGRAMACION\PCteoria3\PC3teoria\Views\Home\Index.cshtml"
 foreach (var result in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-sm\" style=\"border-radius: 14px; border: 1px solid rgb(56, 175, 255); background-color: rgb(255, 255, 255); margin-right: 10px;  margin-left: 10px; margin-top: 20px; padding: 20px; border-style: dotted; border-size:1pt;\">\r\n    <center><img");
            BeginWriteAttribute("src", " src=\"", 741, "\"", 788, 1);
#nullable restore
#line 20 "C:\Users\BRIGITTE\Documents\PROGRAMACION\PCteoria3\PC3teoria\Views\Home\Index.cshtml"
WriteAttributeValue("", 747, Html.DisplayFor(modelItem => result.url), 747, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 789, "\"", 795, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"200\" class=\"rounded-lg \"></center><br>\r\n    <center><p class=\"text-primary\">");
#nullable restore
#line 21 "C:\Users\BRIGITTE\Documents\PROGRAMACION\PCteoria3\PC3teoria\Views\Home\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => result.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></center>\r\n           \r\n          <br>\r\n\r\n<span style=\"color:#000000;\">Total S/ ");
#nullable restore
#line 25 "C:\Users\BRIGITTE\Documents\PROGRAMACION\PCteoria3\PC3teoria\Views\Home\Index.cshtml"
                                 Write(Html.DisplayFor(modelItem => result.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n <br>\r\n\r\n<span style=\"color:#000000;\">Direccion : ");
#nullable restore
#line 28 "C:\Users\BRIGITTE\Documents\PROGRAMACION\PCteoria3\PC3teoria\Views\Home\Index.cshtml"
                                    Write(Html.DisplayFor(modelItem => result.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n\r\n<br>\r\n\r\n<span style=\"color:#000000;\">Descripcion : ");
#nullable restore
#line 33 "C:\Users\BRIGITTE\Documents\PROGRAMACION\PCteoria3\PC3teoria\Views\Home\Index.cshtml"
                                      Write(Html.DisplayFor(modelItem => result.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n<br>\r\n\r\n<span style=\"color:#000000;\">Usuario: ");
#nullable restore
#line 37 "C:\Users\BRIGITTE\Documents\PROGRAMACION\PCteoria3\PC3teoria\Views\Home\Index.cshtml"
                                 Write(Html.DisplayFor(modelItem => result.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n<br>\r\n\r\n<span style=\"color:#000000;\">Telefono: ");
#nullable restore
#line 41 "C:\Users\BRIGITTE\Documents\PROGRAMACION\PCteoria3\PC3teoria\Views\Home\Index.cshtml"
                                  Write(Html.DisplayFor(modelItem => result.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n<br>\r\n\r\n<span style=\"color:#000000;\">Fecha: ");
#nullable restore
#line 45 "C:\Users\BRIGITTE\Documents\PROGRAMACION\PCteoria3\PC3teoria\Views\Home\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => result.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n</div>\r\n");
#nullable restore
#line 48 "C:\Users\BRIGITTE\Documents\PROGRAMACION\PCteoria3\PC3teoria\Views\Home\Index.cshtml"
          
         
            
        }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Registrar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
