#pragma checksum "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a6d88264ddd54149d9d43d8a05da67d043e982c"
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
#line 1 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/_ViewImports.cshtml"
using WebMVC;

#line default
#line hidden
#line 2 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/_ViewImports.cshtml"
using WebMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6d88264ddd54149d9d43d8a05da67d043e982c", @"/Views/Person/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07e873f05b36c9d83cd6a184d4bfbe1720fee4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListPersonModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Index.cshtml"
  
    ViewData["Title"] = "Person Page";

#line default
#line hidden
            BeginContext(67, 226, true);
            WriteLiteral("\n<h2>*** Person Page! ***</h2>\n\n<p>O que voçê deseja fazer?</p>\n\n\n<table border=\"2\" style=\"width:100% \">\n    <tr style=\"text-align:center; background-color:beige\">  \n<strong>\n        <th>\n             <strong>\n                ");
            EndContext();
            BeginContext(294, 50, false);
#line 16 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Index.cshtml"
           Write(Html.ActionLink("Create Person","Create","Person"));

#line default
#line hidden
            EndContext();
            BeginContext(344, 375, true);
            WriteLiteral(@"
             </strong>  
        </th>

    </tr>
   <tr style=""text-align:center; background-color:red"">
       <th>ID</th>
       <th>Nome</th>
       <th>Gênero</th>
       <th>RG</th>
       <th>CPF</th>
       <th>Nascimento</th>
       <th>Estado Civil</th>
       <th>Endereço</th>
       <th>Telefone</th>
       <th>ATUALIZAR</th>
       <th>EXCLUIR</th>

   </tr>
");
            EndContext();
#line 35 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Index.cshtml"
    if (Model.Lista != null)
   {

#line default
#line hidden
#line 37 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Index.cshtml"
 foreach(var person in Model.Lista)
   {

#line default
#line hidden
            BeginContext(794, 59, true);
            WriteLiteral("       <tr style=\"background-color:beige\">\n            <td>");
            EndContext();
            BeginContext(854, 9, false);
#line 40 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Index.cshtml"
           Write(person.Id);

#line default
#line hidden
            EndContext();
            BeginContext(863, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(886, 11, false);
#line 41 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Index.cshtml"
           Write(person.Name);

#line default
#line hidden
            EndContext();
            BeginContext(897, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(920, 13, false);
#line 42 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Index.cshtml"
           Write(person.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(933, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(956, 21, false);
#line 43 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Index.cshtml"
           Write(person.DocumentNumber);

#line default
#line hidden
            EndContext();
            BeginContext(977, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(1000, 21, false);
#line 44 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Index.cshtml"
           Write(person.Identification);

#line default
#line hidden
            EndContext();
            BeginContext(1021, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(1044, 16, false);
#line 45 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Index.cshtml"
           Write(person.BirthDate);

#line default
#line hidden
            EndContext();
            BeginContext(1060, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(1083, 20, false);
#line 46 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Index.cshtml"
           Write(person.MeritalStatus);

#line default
#line hidden
            EndContext();
            BeginContext(1103, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(1126, 14, false);
#line 47 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Index.cshtml"
           Write(person.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1140, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(1163, 12, false);
#line 48 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Index.cshtml"
           Write(person.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1175, 95, true);
            WriteLiteral("</td> \n            <td style=\"text-align:center\">\n                <strong>\n                    ");
            EndContext();
            BeginContext(1271, 66, false);
#line 51 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Index.cshtml"
               Write(Html.ActionLink("!", "Edit", "Person", new {personId = person.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(1337, 134, true);
            WriteLiteral("\n                </strong>\n            </td> \n            <td style=\"text-align:center\">\n                <strong>\n                    ");
            EndContext();
            BeginContext(1472, 74, false);
#line 56 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Index.cshtml"
               Write(Html.ActionLink("X", "DeletePerson", "Person", new {personId = person.Id}));

#line default
#line hidden
            EndContext();
            BeginContext(1546, 74, true);
            WriteLiteral("\n                </strong>\n            </td> \n             \n        </tr>\n");
            EndContext();
#line 61 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Index.cshtml"
   }

#line default
#line hidden
            BeginContext(1625, 96, true);
            WriteLiteral("        <tr style=\"background-color:beige\">\n           <th><strong>Total de Pessoas => </strong>");
            EndContext();
            BeginContext(1722, 19, false);
#line 63 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Index.cshtml"
                                               Write(Model.Lista.Count());

#line default
#line hidden
            EndContext();
            BeginContext(1741, 20, true);
            WriteLiteral("</th>\n        </tr>\n");
            EndContext();
#line 65 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Index.cshtml"
   }   

#line default
#line hidden
            BeginContext(1769, 9, true);
            WriteLiteral("</table>\n");
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
