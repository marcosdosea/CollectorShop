#pragma checksum "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3054df3f0e1587a7d47aaa13cd61e6bb45872049"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anuncio_Index), @"mvc.1.0.view", @"/Views/Anuncio/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Anuncio/Index.cshtml", typeof(AspNetCore.Views_Anuncio_Index))]
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
#line 1 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\_ViewImports.cshtml"
using collectorShop;

#line default
#line hidden
#line 2 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\_ViewImports.cshtml"
using collectorShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3054df3f0e1587a7d47aaa13cd61e6bb45872049", @"/Views/Anuncio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95c50455cb4d1429ca56ac1062e3d05dc38f6c51", @"/Views/_ViewImports.cshtml")]
    public class Views_Anuncio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Model.Anuncio>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
  
   Layout = "_Layout";

#line default
#line hidden
            BeginContext(68, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(95, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b281488efd646a2a914f33e4d01d693", async() => {
                BeginContext(101, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Anúncio</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(197, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(199, 3137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "861f2d6f19c04c41938f6223325d6c1c", async() => {
                BeginContext(205, 19, true);
                WriteLiteral("\r\n    <p>\r\n        ");
                EndContext();
                BeginContext(224, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da6c84b4f537486a958dd40b1030c00d", async() => {
                    BeginContext(247, 18, true);
                    WriteLiteral("Criar novo anúncio");
                    EndContext();
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
                EndContext();
                BeginContext(269, 26, true);
                WriteLiteral("\r\n        <br />\r\n        ");
                EndContext();
                BeginContext(295, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd6e82ca3f9441bc82079ab2254bbe3c", async() => {
                    BeginContext(316, 14, true);
                    WriteLiteral("Editar anúncio");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(334, 26, true);
                WriteLiteral("\r\n        <br />\r\n        ");
                EndContext();
                BeginContext(360, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd18e3ea307b4cc5adda6f6ce581c433", async() => {
                    BeginContext(383, 14, true);
                    WriteLiteral("Apagar anúncio");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(401, 26, true);
                WriteLiteral("\r\n        <br />\r\n        ");
                EndContext();
                BeginContext(427, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57a4a058b19740cab2c76729e58c893b", async() => {
                    BeginContext(451, 18, true);
                    WriteLiteral("Visualizar anúncio");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(473, 116, true);
                WriteLiteral("\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(590, 46, false);
#line 27 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CodAnuncio));

#line default
#line hidden
                EndContext();
                BeginContext(636, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(704, 42, false);
#line 30 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
                EndContext();
                BeginContext(746, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(814, 50, false);
#line 33 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.QuantAnunciada));

#line default
#line hidden
                EndContext();
                BeginContext(864, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(932, 51, false);
#line 36 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.QuantDisponivel));

#line default
#line hidden
                EndContext();
                BeginContext(983, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1051, 42, false);
#line 39 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
                EndContext();
                BeginContext(1093, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1161, 45, false);
#line 42 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
                EndContext();
                BeginContext(1206, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1274, 41, false);
#line 45 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
                EndContext();
                BeginContext(1315, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1383, 46, false);
#line 48 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CodUsuario));

#line default
#line hidden
                EndContext();
                BeginContext(1429, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1497, 39, false);
#line 51 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Msg));

#line default
#line hidden
                EndContext();
                BeginContext(1536, 106, true);
                WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 57 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(1699, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1772, 45, false);
#line 61 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CodAnuncio));

#line default
#line hidden
                EndContext();
                BeginContext(1817, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1897, 41, false);
#line 64 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
                EndContext();
                BeginContext(1938, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2018, 49, false);
#line 67 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.QuantAnunciada));

#line default
#line hidden
                EndContext();
                BeginContext(2067, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2147, 50, false);
#line 70 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.QuantDisponivel));

#line default
#line hidden
                EndContext();
                BeginContext(2197, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2277, 41, false);
#line 73 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
                EndContext();
                BeginContext(2318, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2398, 44, false);
#line 76 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
                EndContext();
                BeginContext(2442, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2522, 40, false);
#line 79 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
                EndContext();
                BeginContext(2562, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2642, 45, false);
#line 82 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CodUsuario));

#line default
#line hidden
                EndContext();
                BeginContext(2687, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2767, 38, false);
#line 85 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Msg));

#line default
#line hidden
                EndContext();
                BeginContext(2805, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2885, 61, false);
#line 88 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = item.CodAnuncio }));

#line default
#line hidden
                EndContext();
                BeginContext(2946, 28, true);
                WriteLiteral(" |\r\n                        ");
                EndContext();
                BeginContext(2975, 65, false);
#line 89 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
                   Write(Html.ActionLink("Create", "Create", new { id = item.CodAnuncio }));

#line default
#line hidden
                EndContext();
                BeginContext(3040, 28, true);
                WriteLiteral(" |\r\n                        ");
                EndContext();
                BeginContext(3069, 67, false);
#line 90 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id = item.CodAnuncio }));

#line default
#line hidden
                EndContext();
                BeginContext(3136, 28, true);
                WriteLiteral(" |\r\n                        ");
                EndContext();
                BeginContext(3165, 65, false);
#line 91 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = item.CodAnuncio }));

#line default
#line hidden
                EndContext();
                BeginContext(3230, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 94 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(3297, 32, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3336, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Model.Anuncio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
