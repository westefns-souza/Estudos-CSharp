#pragma checksum "C:\Users\l4304\Desktop\Estudos Asp.Net\AspNetCoreIdentity\AspNetCoreIdentity\Views\Home\Secret.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2ee89ef24651e6aff3272b2862343cc81627cc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Secret), @"mvc.1.0.view", @"/Views/Home/Secret.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Secret.cshtml", typeof(AspNetCore.Views_Home_Secret))]
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
#line 1 "C:\Users\l4304\Desktop\Estudos Asp.Net\AspNetCoreIdentity\AspNetCoreIdentity\Views\_ViewImports.cshtml"
using AspNetCoreIdentity;

#line default
#line hidden
#line 2 "C:\Users\l4304\Desktop\Estudos Asp.Net\AspNetCoreIdentity\AspNetCoreIdentity\Views\_ViewImports.cshtml"
using AspNetCoreIdentity.Models;

#line default
#line hidden
#line 1 "C:\Users\l4304\Desktop\Estudos Asp.Net\AspNetCoreIdentity\AspNetCoreIdentity\Views\Home\Secret.cshtml"
using AspNetCoreIdentity.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2ee89ef24651e6aff3272b2862343cc81627cc5", @"/Views/Home/Secret.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b55bec701bb5c4324487dfe3a90e1f98fbf801d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Secret : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\l4304\Desktop\Estudos Asp.Net\AspNetCoreIdentity\AspNetCoreIdentity\Views\Home\Secret.cshtml"
  
    ViewData["Title"] = "Secret";

#line default
#line hidden
            BeginContext(80, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(85, 17, false);
#line 5 "C:\Users\l4304\Desktop\Estudos Asp.Net\AspNetCoreIdentity\AspNetCoreIdentity\Views\Home\Secret.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(102, 71, true);
            WriteLiteral("</h1>\r\n\r\n<p>Use this page to detail your site\'s privacy policy.</p>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\l4304\Desktop\Estudos Asp.Net\AspNetCoreIdentity\AspNetCoreIdentity\Views\Home\Secret.cshtml"
   
    if (this.IfClaim("Produtos", "Adicionar"))
    {

#line default
#line hidden
            BeginContext(233, 39, true);
            WriteLiteral("        <p>Permissão de adicionar</p>\r\n");
            EndContext();
#line 13 "C:\Users\l4304\Desktop\Estudos Asp.Net\AspNetCoreIdentity\AspNetCoreIdentity\Views\Home\Secret.cshtml"
    }

#line default
#line hidden
            BeginContext(282, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(296, 81, false);
#line 17 "C:\Users\l4304\Desktop\Estudos Asp.Net\AspNetCoreIdentity\AspNetCoreIdentity\Views\Home\Secret.cshtml"
Write(Html.ActionLink("Secret", "Secret").IfClaimShow(Context, "Produtos", "Adicionar"));

#line default
#line hidden
            EndContext();
            BeginContext(377, 46, true);
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    <br />\r\n    <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 423, "\"", 496, 3);
            WriteAttributeValue("", 431, "btn", 431, 3, true);
            WriteAttributeValue(" ", 434, "btn-danger", 435, 11, true);
#line 22 "C:\Users\l4304\Desktop\Estudos Asp.Net\AspNetCoreIdentity\AspNetCoreIdentity\Views\Home\Secret.cshtml"
WriteAttributeValue(" ", 445, Html.Raw(this.IfClaimShow("Produtos", "Excluir")), 446, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(497, 22, true);
            WriteLiteral(">Excluir</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
