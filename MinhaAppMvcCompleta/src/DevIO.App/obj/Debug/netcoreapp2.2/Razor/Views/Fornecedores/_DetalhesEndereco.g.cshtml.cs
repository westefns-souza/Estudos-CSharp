#pragma checksum "C:\Users\l4304\Desktop\Liga\Estudos Asp.Net\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df2663d57df04ee11d58c66a45b9a27e1292ebbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fornecedores__DetalhesEndereco), @"mvc.1.0.view", @"/Views/Fornecedores/_DetalhesEndereco.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fornecedores/_DetalhesEndereco.cshtml", typeof(AspNetCore.Views_Fornecedores__DetalhesEndereco))]
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
#line 1 "C:\Users\l4304\Desktop\Liga\Estudos Asp.Net\MinhaAppMvcCompleta\src\DevIO.App\Views\_ViewImports.cshtml"
using DevIO.App;

#line default
#line hidden
#line 2 "C:\Users\l4304\Desktop\Liga\Estudos Asp.Net\MinhaAppMvcCompleta\src\DevIO.App\Views\_ViewImports.cshtml"
using DevIO.App.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df2663d57df04ee11d58c66a45b9a27e1292ebbe", @"/Views/Fornecedores/_DetalhesEndereco.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f4e717c4124c55203fe493fa8cdf7ca43650315", @"/Views/_ViewImports.cshtml")]
    public class Views_Fornecedores__DetalhesEndereco : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevIO.App.ViewModels.EnderecoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Endereco", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(47, 101, true);
            WriteLiteral("\r\n<div style=\"padding-top: 20px\">\r\n    <div>\r\n        <hr />\r\n        <h4>Endereço</h4>\r\n    </div>\r\n");
            EndContext();
#line 8 "C:\Users\l4304\Desktop\Liga\Estudos Asp.Net\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(180, 155, true);
            WriteLiteral("        <table class=\"table table-hover\">\r\n            <thead class=\"thead-dark\">\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(336, 47, false);
#line 14 "C:\Users\l4304\Desktop\Liga\Estudos Asp.Net\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Longradouro));

#line default
#line hidden
            EndContext();
            BeginContext(383, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(463, 42, false);
#line 17 "C:\Users\l4304\Desktop\Liga\Estudos Asp.Net\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(505, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(585, 47, false);
#line 20 "C:\Users\l4304\Desktop\Liga\Estudos Asp.Net\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(632, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(712, 42, false);
#line 23 "C:\Users\l4304\Desktop\Liga\Estudos Asp.Net\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(754, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(834, 39, false);
#line 26 "C:\Users\l4304\Desktop\Liga\Estudos Asp.Net\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(873, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(953, 42, false);
#line 29 "C:\Users\l4304\Desktop\Liga\Estudos Asp.Net\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(995, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1075, 42, false);
#line 32 "C:\Users\l4304\Desktop\Liga\Estudos Asp.Net\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1117, 198, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1316, 43, false);
#line 40 "C:\Users\l4304\Desktop\Liga\Estudos Asp.Net\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayFor(model => model.Longradouro));

#line default
#line hidden
            EndContext();
            BeginContext(1359, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1439, 38, false);
#line 43 "C:\Users\l4304\Desktop\Liga\Estudos Asp.Net\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayFor(model => model.Numero));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1557, 43, false);
#line 46 "C:\Users\l4304\Desktop\Liga\Estudos Asp.Net\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayFor(model => model.Complemento));

#line default
#line hidden
            EndContext();
            BeginContext(1600, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1680, 38, false);
#line 49 "C:\Users\l4304\Desktop\Liga\Estudos Asp.Net\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayFor(model => model.Bairro));

#line default
#line hidden
            EndContext();
            BeginContext(1718, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1798, 35, false);
#line 52 "C:\Users\l4304\Desktop\Liga\Estudos Asp.Net\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayFor(model => model.Cep));

#line default
#line hidden
            EndContext();
            BeginContext(1833, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1913, 38, false);
#line 55 "C:\Users\l4304\Desktop\Liga\Estudos Asp.Net\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1951, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2031, 38, false);
#line 58 "C:\Users\l4304\Desktop\Liga\Estudos Asp.Net\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
                   Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(2069, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2148, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df2663d57df04ee11d58c66a45b9a27e1292ebbe11955", async() => {
                BeginContext(2216, 53, true);
                WriteLiteral("<span title=\"Editar\" class=\"fa fa-pencil-alt\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2273, 92, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 66 "C:\Users\l4304\Desktop\Liga\Estudos Asp.Net\MinhaAppMvcCompleta\src\DevIO.App\Views\Fornecedores\_DetalhesEndereco.cshtml"
    }

#line default
#line hidden
            BeginContext(2372, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevIO.App.ViewModels.EnderecoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
