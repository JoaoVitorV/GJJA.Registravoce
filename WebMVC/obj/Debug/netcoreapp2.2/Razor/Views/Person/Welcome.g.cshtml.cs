#pragma checksum "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99c876a1d5ac94725f129202cb489563656cc824"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Welcome), @"mvc.1.0.view", @"/Views/Person/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/Welcome.cshtml", typeof(AspNetCore.Views_Person_Welcome))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c876a1d5ac94725f129202cb489563656cc824", @"/Views/Person/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07e873f05b36c9d83cd6a184d4bfbe1720fee4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Welcome.cshtml"
  
    ViewData["Title"]="Welcome";

#line default
#line hidden
            BeginContext(57, 30, true);
            WriteLiteral("<h2>Welcome</h2>\n<p>\n    Id : ");
            EndContext();
            BeginContext(88, 8, false);
#line 7 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Welcome.cshtml"
    Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(96, 17, true);
            WriteLiteral("</br>\n    Nome : ");
            EndContext();
            BeginContext(114, 10, false);
#line 8 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Welcome.cshtml"
      Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(124, 17, true);
            WriteLiteral("</br>\n    Data : ");
            EndContext();
            BeginContext(142, 15, false);
#line 9 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Welcome.cshtml"
      Write(Model.BirthDate);

#line default
#line hidden
            EndContext();
            BeginContext(157, 15, true);
            WriteLiteral("</br>\n    Rg : ");
            EndContext();
            BeginContext(173, 20, false);
#line 10 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Welcome.cshtml"
    Write(Model.Identification);

#line default
#line hidden
            EndContext();
            BeginContext(193, 16, true);
            WriteLiteral("</br>\n    Cpf : ");
            EndContext();
            BeginContext(210, 20, false);
#line 11 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Welcome.cshtml"
     Write(Model.DocumentNumber);

#line default
#line hidden
            EndContext();
            BeginContext(230, 25, true);
            WriteLiteral("</br>\n    Estado Civil : ");
            EndContext();
            BeginContext(256, 19, false);
#line 12 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Welcome.cshtml"
              Write(Model.MeritalStatus);

#line default
#line hidden
            EndContext();
            BeginContext(275, 21, true);
            WriteLiteral("</br>\n    Telefone : ");
            EndContext();
            BeginContext(297, 11, false);
#line 13 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Welcome.cshtml"
          Write(Model.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(308, 21, true);
            WriteLiteral("</br>\n    Endereço : ");
            EndContext();
            BeginContext(330, 13, false);
#line 14 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Welcome.cshtml"
          Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(343, 19, true);
            WriteLiteral("</br>\n    Genero : ");
            EndContext();
            BeginContext(363, 12, false);
#line 15 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Welcome.cshtml"
        Write(Model.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(375, 5, true);
            WriteLiteral("\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
