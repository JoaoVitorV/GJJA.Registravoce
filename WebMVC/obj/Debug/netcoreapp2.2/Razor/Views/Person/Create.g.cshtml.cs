#pragma checksum "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3d09338e23abb225f3a0bc7714776ece7e38a5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Create), @"mvc.1.0.view", @"/Views/Person/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/Create.cshtml", typeof(AspNetCore.Views_Person_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3d09338e23abb225f3a0bc7714776ece7e38a5f", @"/Views/Person/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07e873f05b36c9d83cd6a184d4bfbe1720fee4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Create.cshtml"
  
    ViewData["Title"] = "Create Page";

#line default
#line hidden
            BeginContext(63, 85, true);
            WriteLiteral("\n<h2>*** Create Person Page! ***</h2>\n\n<p>O que voçê deseja fazer?</p>\n\n<strong>\n    ");
            EndContext();
            BeginContext(149, 45, false);
#line 11 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Create.cshtml"
Write(Html.ActionLink("List all","Create","Person"));

#line default
#line hidden
            EndContext();
            BeginContext(194, 11, true);
            WriteLiteral("\n</strong>\n");
            EndContext();
#line 13 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Create.cshtml"
 using (Html.BeginForm("Insert", "Person", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(268, 160, true);
            WriteLiteral("<table>\n    <tr style=\"text-align:center; background-color:red\">\n    <th>Parâmeter</th>\n    <th>Value</th>\n    </tr>\n    <tr>\n        <td>Name</td>\n        <td>");
            EndContext();
            BeginContext(429, 27, false);
#line 22 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Create.cshtml"
       Write(Html.EditorFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(456, 61, true);
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>Gender</td>\n        <td>");
            EndContext();
            BeginContext(518, 251, false);
#line 26 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Create.cshtml"
       Write(Html.DropDownListFor(m => m.Gender, new List<SelectListItem> {
           new SelectListItem {Text = "Male", Value="0"},
           new SelectListItem {Text = "Female", Value="1"},
           new SelectListItem {Text = "No info", Value="2"}
        }));

#line default
#line hidden
            EndContext();
            BeginContext(769, 69, true);
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>DocumentNumber</td>\n        <td>");
            EndContext();
            BeginContext(839, 37, false);
#line 34 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Create.cshtml"
       Write(Html.EditorFor(m => m.DocumentNumber));

#line default
#line hidden
            EndContext();
            BeginContext(876, 69, true);
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>Identification</td>\n        <td>");
            EndContext();
            BeginContext(946, 37, false);
#line 38 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Create.cshtml"
       Write(Html.EditorFor(m => m.Identification));

#line default
#line hidden
            EndContext();
            BeginContext(983, 64, true);
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>BirthDate</td>\n        <td>");
            EndContext();
            BeginContext(1048, 32, false);
#line 42 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Create.cshtml"
       Write(Html.EditorFor(m => m.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 69, true);
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>Marital Status</td>\n        <td>");
            EndContext();
            BeginContext(1150, 323, false);
#line 46 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Create.cshtml"
       Write(Html.DropDownListFor(m => m.MeritalStatus, new List<SelectListItem> {
           new SelectListItem {Text = "Married", Value="0"},
           new SelectListItem {Text = "Single", Value="1"},
           new SelectListItem {Text = "Divorced", Value="2"},
           new SelectListItem {Text = "Widowed", Value="3"}
        }));

#line default
#line hidden
            EndContext();
            BeginContext(1473, 71, true);
            WriteLiteral("\n        </td>\n    </tr>\n    <tr>\n        <td>Address</td>\n        <td>");
            EndContext();
            BeginContext(1545, 30, false);
#line 56 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Create.cshtml"
       Write(Html.EditorFor(m => m.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1575, 60, true);
            WriteLiteral("</td>\n    </tr>\n    <tr>\n        <td>Phone</td>\n        <td>");
            EndContext();
            BeginContext(1636, 28, false);
#line 60 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Create.cshtml"
       Write(Html.EditorFor(m => m.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 68, true);
            WriteLiteral("</td>\n    </tr>\n</table>\n<input type=\"submit\" value=\"Save Person\"/>\n");
            EndContext();
#line 64 "/home/season/Documentos/projects/GJJA.RegistraVoce.Git/WebMVC/Views/Person/Create.cshtml"
}

#line default
#line hidden
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
