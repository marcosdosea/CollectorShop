#pragma checksum "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44f4294e37ab16de92fc62824cb6d18c2dad17d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anuncio_Details), @"mvc.1.0.view", @"/Views/Anuncio/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Anuncio/Details.cshtml", typeof(AspNetCore.Views_Anuncio_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44f4294e37ab16de92fc62824cb6d18c2dad17d0", @"/Views/Anuncio/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95c50455cb4d1429ca56ac1062e3d05dc38f6c51", @"/Views/_ViewImports.cshtml")]
    public class Views_Anuncio_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Model.Anuncio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
  
     Layout = "_Layout";

#line default
#line hidden
            BeginContext(57, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Anuncio</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(179, 46, false);
#line 14 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CodAnuncio));

#line default
#line hidden
            EndContext();
            BeginContext(225, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(269, 42, false);
#line 17 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.CodAnuncio));

#line default
#line hidden
            EndContext();
            BeginContext(311, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(355, 42, false);
#line 20 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(397, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(441, 38, false);
#line 23 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(479, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(523, 50, false);
#line 26 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuantAnunciada));

#line default
#line hidden
            EndContext();
            BeginContext(573, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(617, 46, false);
#line 29 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.QuantAnunciada));

#line default
#line hidden
            EndContext();
            BeginContext(663, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(707, 51, false);
#line 32 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuantDisponivel));

#line default
#line hidden
            EndContext();
            BeginContext(758, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(802, 47, false);
#line 35 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.QuantDisponivel));

#line default
#line hidden
            EndContext();
            BeginContext(849, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(893, 42, false);
#line 38 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(935, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(979, 38, false);
#line 41 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1061, 45, false);
#line 44 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1106, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1150, 41, false);
#line 47 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1191, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1235, 41, false);
#line 50 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1320, 37, false);
#line 53 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1357, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1401, 46, false);
#line 56 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CodUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1491, 42, false);
#line 59 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.CodUsuario));

#line default
#line hidden
            EndContext();
            BeginContext(1533, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1577, 39, false);
#line 62 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Msg));

#line default
#line hidden
            EndContext();
            BeginContext(1616, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1660, 35, false);
#line 65 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
       Write(Html.DisplayFor(model => model.Msg));

#line default
#line hidden
            EndContext();
            BeginContext(1695, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1743, 68, false);
#line 70 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Anuncio\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1811, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1819, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b294a814153246b880bc88935502b99a", async() => {
                BeginContext(1841, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(1857, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Model.Anuncio> Html { get; private set; }
    }
}
#pragma warning restore 1591
