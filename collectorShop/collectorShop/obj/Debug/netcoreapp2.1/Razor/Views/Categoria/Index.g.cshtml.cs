#pragma checksum "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5116c830ac60e3172ceb5d4965667ba861838fd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria_Index), @"mvc.1.0.view", @"/Views/Categoria/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categoria/Index.cshtml", typeof(AspNetCore.Views_Categoria_Index))]
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
#line 1 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\_ViewImports.cshtml"
using collectorShop;

#line default
#line hidden
#line 2 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\_ViewImports.cshtml"
using collectorShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5116c830ac60e3172ceb5d4965667ba861838fd4", @"/Views/Categoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95c50455cb4d1429ca56ac1062e3d05dc38f6c51", @"/Views/_ViewImports.cshtml")]
    public class Views_Categoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Model.Categoria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(105, 260, true);
            WriteLiteral(@"
    <div class=""col-md-3"">
        <div>
            <a href=""#"" class=""list-group-item active"">
                Menu do Usuário
            </a>
            <ul class=""list-group"">

                <li class=""list-group-item"">

                    ");
            EndContext();
            BeginContext(366, 51, false);
#line 17 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
               Write(Html.ActionLink("Meus dados", "Details", "Usuario"));

#line default
#line hidden
            EndContext();
            BeginContext(417, 1868, true);
            WriteLiteral(@"

                </li>
                <li class=""list-group-item"">
                    <a href=""#"">Modificar dados</a>

                </li>

                <li class=""list-group-item"">
                    <a href=""#"">Segurança</a>

                </li>
                <li class=""list-group-item"">
                    <a href=""#"">Saldo</a>

                </li>
            </ul>
        </div>
        <!-- /.div -->
        <div>
            <a href=""#"" class=""list-group-item active list-group-item-success"">
                Compras
            </a>
            <ul class=""list-group"">

                <li class=""list-group-item"">
                    <a href=""#"">Compras</a>

                </li>
                <li class=""list-group-item"">
                    <a href=""#"">Perguntas</a>

                </li>

            </ul>
        </div>
        <!-- /.div -->
        <div>
            <a href=""#"" class=""list-group-item active"">
                Vendas
           ");
            WriteLiteral(@" </a>
            <ul class=""list-group"">
                <li class=""list-group-item"">
                    <a href=""#"">Anúncios</a>

                </li>
                <li class=""list-group-item"">
                    <a href=""#"">Vendas</a>

                </li>
                <li class=""list-group-item"">
                    <a href=""#"">Perguntas</a>

                </li>
            </ul>
        </div>

    </div>
    <div class=""col-md-9"">

        <div class=""row"">

            <div class=""col-md-10"">
                <h3><strong>Categorias</strong></h3>

                <hr>

                <div class=""row"">

                    <div class=""col-md-12 col-sm-12"">
                        <div class=""form-group"">
                            <hr>
                            <div class=""row"">

");
            EndContext();
#line 91 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
            BeginContext(2382, 339, true);
            WriteLiteral(@"                                    <div class=""col-md-3 text-center col-sm-4 col-xs-4"">
                                        <div class=""thumbnail product-box"">
                                            
                                            <div class=""caption"">
                                                <p><strong>");
            EndContext();
            BeginContext(2722, 47, false);
#line 97 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.CodCategoria));

#line default
#line hidden
            EndContext();
            BeginContext(2769, 81, true);
            WriteLiteral("</strong>  </p>\r\n                                                <h5><a href=\"#\">");
            EndContext();
            BeginContext(2851, 39, false);
#line 98 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2890, 11, true);
            WriteLiteral("</a></h5>\r\n");
            EndContext();
#line 99 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
                                                 using (Html.BeginForm("Details", "Categoria", new { id = item.CodCategoria }))
                                                {

#line default
#line hidden
            BeginContext(3081, 121, true);
            WriteLiteral("                                                    <button type=\"submit\" class=\"btn btn-primary\">Ver detalhes</button>\r\n");
            EndContext();
#line 102 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(3253, 48, true);
            WriteLiteral("                                                ");
            EndContext();
#line 103 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
                                                 using (Html.BeginForm("Delete", "Categoria", new { id = item.CodCategoria }))
                                                {

#line default
#line hidden
            BeginContext(3432, 114, true);
            WriteLiteral("                                                    <button type=\"submit\" class=\"btn btn-danger\">Apagar</button>\r\n");
            EndContext();
#line 106 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(3597, 48, true);
            WriteLiteral("                                                ");
            EndContext();
#line 107 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
                                                 using (Html.BeginForm("Edit", "Categoria", new { id = item.CodCategoria }))
                                                {

#line default
#line hidden
            BeginContext(3774, 115, true);
            WriteLiteral("                                                    <button type=\"submit\" class=\"btn btn-warning\">Editar</button>\r\n");
            EndContext();
#line 110 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(3940, 144, true);
            WriteLiteral("                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n");
            EndContext();
#line 114 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(4119, 90, true);
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-md-3\">\r\n");
            EndContext();
#line 118 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
                                 using (Html.BeginForm("Create", "Categoria", FormMethod.Get))
                                {

#line default
#line hidden
            BeginContext(4340, 111, true);
            WriteLiteral("                                    <button type=\"submit\" class=\"btn btn-primary\">Criar novo anúncio</button>\r\n");
            EndContext();
#line 121 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(4486, 88, true);
            WriteLiteral("                            </div>\r\n                            <div class=\"col-md-3\">\r\n");
            EndContext();
#line 124 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
                                 using (Html.BeginForm("Details", "Categoria", FormMethod.Get))
                                {

#line default
#line hidden
            BeginContext(4706, 101, true);
            WriteLiteral("                                    <button type=\"submit\" class=\"btn btn-primary\">Detalhes</button>\r\n");
            EndContext();
#line 127 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(4842, 88, true);
            WriteLiteral("                            </div>\r\n                            <div class=\"col-md-3\">\r\n");
            EndContext();
#line 130 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
                                 using (Html.BeginForm("Edit", "Categoria", FormMethod.Get))
                                {

#line default
#line hidden
            BeginContext(5059, 99, true);
            WriteLiteral("                                    <button type=\"submit\" class=\"btn btn-primary\">Editar</button>\r\n");
            EndContext();
#line 133 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(5193, 88, true);
            WriteLiteral("                            </div>\r\n                            <div class=\"col-md-3\">\r\n");
            EndContext();
#line 136 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
                                 using (Html.BeginForm("Delele", "Categoria", FormMethod.Get))
                                {

#line default
#line hidden
            BeginContext(5412, 99, true);
            WriteLiteral("                                    <button type=\"submit\" class=\"btn btn-primary\">Apagar</button>\r\n");
            EndContext();
#line 139 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(5546, 175, true);
            WriteLiteral("                            </div> \r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(5721, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7be327471bb2437a980c8bc733bc4bf1", async() => {
                BeginContext(5744, 24, true);
                WriteLiteral("Cadastrar nova Categoria");
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
            BeginContext(5772, 90, true);
            WriteLiteral("\r\n<!--<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(5863, 48, false);
#line 153 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CodCategoria));

#line default
#line hidden
            EndContext();
            BeginContext(5911, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(5967, 40, false);
#line 156 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(6007, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 162 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(6125, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(6174, 47, false);
#line 165 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CodCategoria));

#line default
#line hidden
            EndContext();
            BeginContext(6221, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(6277, 39, false);
#line 168 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(6316, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(6372, 63, false);
#line 171 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {  id=item.CodCategoria  }));

#line default
#line hidden
            EndContext();
            BeginContext(6435, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(6456, 68, false);
#line 172 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new {  id=item.CodCategoria }));

#line default
#line hidden
            EndContext();
            BeginContext(6524, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(6545, 66, false);
#line 173 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new {  id=item.CodCategoria }));

#line default
#line hidden
            EndContext();
            BeginContext(6611, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 176 "C:\Users\barbi\Desktop\CollectorShop\collectorShop\collectorShop\Views\Categoria\Index.cshtml"
}

#line default
#line hidden
            BeginContext(6650, 33, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n    -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Model.Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
