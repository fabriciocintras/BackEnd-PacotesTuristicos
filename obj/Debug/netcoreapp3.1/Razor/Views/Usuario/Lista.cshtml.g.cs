#pragma checksum "C:\Users\Fabrício\Documents\repositorio local git\BackEnd-\Views\Usuario\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e87eae90635a10ae0f9c9537d936a938a151ef2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Lista), @"mvc.1.0.view", @"/Views/Usuario/Lista.cshtml")]
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
#line 1 "C:\Users\Fabrício\Documents\repositorio local git\BackEnd-\Views\_ViewImports.cshtml"
using Viagem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fabrício\Documents\repositorio local git\BackEnd-\Views\_ViewImports.cshtml"
using Viagem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e87eae90635a10ae0f9c9537d936a938a151ef2d", @"/Views/Usuario/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3502097358ea1718afb407c575fb88a4e8be5a45", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Fabrício\Documents\repositorio local git\BackEnd-\Views\Usuario\Lista.cshtml"
      
        ViewData["Title"]= "Listagem dos usuarios";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h2>Listagem dos usuarios</h2>
    <table border=""1"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>Data de Nascimento</th>
                <th>Login</th>
                <th>Senha</th>
                <th>Tipo</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 18 "C:\Users\Fabrício\Documents\repositorio local git\BackEnd-\Views\Usuario\Lista.cshtml"
             foreach (Usuario u in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\Fabrício\Documents\repositorio local git\BackEnd-\Views\Usuario\Lista.cshtml"
                   Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\Fabrício\Documents\repositorio local git\BackEnd-\Views\Usuario\Lista.cshtml"
                   Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\Fabrício\Documents\repositorio local git\BackEnd-\Views\Usuario\Lista.cshtml"
                   Write(u.DataNascimento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\Fabrício\Documents\repositorio local git\BackEnd-\Views\Usuario\Lista.cshtml"
                   Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\Fabrício\Documents\repositorio local git\BackEnd-\Views\Usuario\Lista.cshtml"
                   Write(u.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\Fabrício\Documents\repositorio local git\BackEnd-\Views\Usuario\Lista.cshtml"
                   Write(u.Tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 28 "C:\Users\Fabrício\Documents\repositorio local git\BackEnd-\Views\Usuario\Lista.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
