#pragma checksum "/home/season/Documentos/projects/GJJA.RegistraVoce/WebMVC/Views/Person/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52179a7b0982bff0de784f4a0a9bfc3e4d9fa412"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Index), @"mvc.1.0.view", @"/Views/Person/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/Index.cshtml", typeof(AspNetCore.Views_Person_Index))]
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
#line 1 "/home/season/Documentos/projects/GJJA.RegistraVoce/WebMVC/Views/_ViewImports.cshtml"
using WebMVC;

#line default
#line hidden
#line 2 "/home/season/Documentos/projects/GJJA.RegistraVoce/WebMVC/Views/_ViewImports.cshtml"
using WebMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52179a7b0982bff0de784f4a0a9bfc3e4d9fa412", @"/Views/Person/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07e873f05b36c9d83cd6a184d4bfbe1720fee4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListPersonModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/season/Documentos/projects/GJJA.RegistraVoce/WebMVC/Views/Person/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(61, 175, true);
            WriteLiteral("\n<h2>*** Bem Vindo! ***</h2>\n\n<p>O que voçê deseja fazer?</p>\n\n<p>Listar Pessoas</p>\n<p>Inserir Pessoas</p>\n<p>Atualizar Pessoas</p>\n<p>Deletar Pessoas</p>\n<p>Contar Pessoas: ");
            EndContext();
            BeginContext(237, 19, false);
#line 14 "/home/season/Documentos/projects/GJJA.RegistraVoce/WebMVC/Views/Person/Index.cshtml"
              Write(Model.Lista.Count());

#line default
#line hidden
            EndContext();
            BeginContext(256, 273, true);
            WriteLiteral(@"</p>

<table border=""2"" width=""15"" height=""25"">
   <tr>
       <th>ID</th>
       <th>Nome</th>
       <th>Gênero</th>
       <th>RG</th>
       <th>CPF</th>
       <th>Nascimento</th>
       <th>Estado Civil</th>
       <th>Endereço</th>
       <th>Telefone</th>
   </tr>
");
            EndContext();
#line 28 "/home/season/Documentos/projects/GJJA.RegistraVoce/WebMVC/Views/Person/Index.cshtml"
    foreach(var person in Model.Lista)
   {

#line default
#line hidden
            BeginContext(573, 28, true);
            WriteLiteral("       <tr>\n            <td>");
            EndContext();
            BeginContext(602, 9, false);
#line 31 "/home/season/Documentos/projects/GJJA.RegistraVoce/WebMVC/Views/Person/Index.cshtml"
           Write(person.Id);

#line default
#line hidden
            EndContext();
            BeginContext(611, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(634, 11, false);
#line 32 "/home/season/Documentos/projects/GJJA.RegistraVoce/WebMVC/Views/Person/Index.cshtml"
           Write(person.Name);

#line default
#line hidden
            EndContext();
            BeginContext(645, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(668, 13, false);
#line 33 "/home/season/Documentos/projects/GJJA.RegistraVoce/WebMVC/Views/Person/Index.cshtml"
           Write(person.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(681, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(704, 21, false);
#line 34 "/home/season/Documentos/projects/GJJA.RegistraVoce/WebMVC/Views/Person/Index.cshtml"
           Write(person.DocumentNumber);

#line default
#line hidden
            EndContext();
            BeginContext(725, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(748, 21, false);
#line 35 "/home/season/Documentos/projects/GJJA.RegistraVoce/WebMVC/Views/Person/Index.cshtml"
           Write(person.Identification);

#line default
#line hidden
            EndContext();
            BeginContext(769, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(792, 16, false);
#line 36 "/home/season/Documentos/projects/GJJA.RegistraVoce/WebMVC/Views/Person/Index.cshtml"
           Write(person.BirthDate);

#line default
#line hidden
            EndContext();
            BeginContext(808, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(831, 20, false);
#line 37 "/home/season/Documentos/projects/GJJA.RegistraVoce/WebMVC/Views/Person/Index.cshtml"
           Write(person.MeritalStatus);

#line default
#line hidden
            EndContext();
            BeginContext(851, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(874, 14, false);
#line 38 "/home/season/Documentos/projects/GJJA.RegistraVoce/WebMVC/Views/Person/Index.cshtml"
           Write(person.Address);

#line default
#line hidden
            EndContext();
            BeginContext(888, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(911, 12, false);
#line 39 "/home/season/Documentos/projects/GJJA.RegistraVoce/WebMVC/Views/Person/Index.cshtml"
           Write(person.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(923, 22, true);
            WriteLiteral("</td>   \n       </tr>\n");
            EndContext();
#line 41 "/home/season/Documentos/projects/GJJA.RegistraVoce/WebMVC/Views/Person/Index.cshtml"
   }

#line default
#line hidden
            BeginContext(950, 8, true);
            WriteLiteral("</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListPersonModel> Html { get; private set; }
    }
}
#pragma warning restore 1591