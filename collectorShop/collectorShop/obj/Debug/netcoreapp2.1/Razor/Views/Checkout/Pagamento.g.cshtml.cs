#pragma checksum "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Checkout\Pagamento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cc45da7976bd012a0e038f9437b4958fdb9ad21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Pagamento), @"mvc.1.0.view", @"/Views/Checkout/Pagamento.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Checkout/Pagamento.cshtml", typeof(AspNetCore.Views_Checkout_Pagamento))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cc45da7976bd012a0e038f9437b4958fdb9ad21", @"/Views/Checkout/Pagamento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95c50455cb4d1429ca56ac1062e3d05dc38f6c51", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_Pagamento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("text/plain"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\6 periodo\Engenharia de Software 2\Projeto\CollectorShop\collectorShop\collectorShop\Views\Checkout\Pagamento.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(34, 243, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n<div class=\"col-md-9 footer-box\">\r\n\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-md-10\">\r\n            <h5><strong>1 Login/ Seu Carrinho de Compras 2/ Envio 3/Pagamento</strong></h5>\r\n\r\n            <hr>\r\n            ");
            EndContext();
            BeginContext(277, 2536, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "902095d07b1445f6a5bd81840a5c99e4", async() => {
                BeginContext(318, 274, true);
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-md-12 col-sm-12"">
                        <div class=""form-group"">
                            <h5>SELECIONE O MÉTODO DE PAGAMENTO</h5>
                            <hr>
                            ");
                EndContext();
                BeginContext(592, 2074, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "211ad2ce8e554fed9b6242a2550d2537", async() => {
                    BeginContext(609, 2050, true);
                    WriteLiteral(@"
                                <h6>Selecione qual a bandeira do seu cartão de crédito:</h6>
                                <input type=""radio"" name=""envio"" value=""pac"" required=""required"">Visa<img src=""assets/img/visa.png"" width=""20px"" height=""30px""><br>
                                <input type=""radio"" name=""envio"" value=""sedex"" required=""required""> Mastercard<img src=""assets/img/masterCard.jpg"" width=""20px"" height=""30px""><br>
                                <input type=""radio"" name=""envio"" value=""outro"" required=""required""> Paypal<img src=""assets/img/paypal.jpg"" width=""20px"" height=""30px""><br>
                                <input type=""radio"" name=""envio"" value=""outro"" required=""required""> Banese<img src=""assets/img/BaneseCard.jpg"" width=""20px"" height=""30px""><br>
                                <hr>
                                <h5>Entre com os dados:</h5>
                                <hr>
                                Número do cartão <input type=""text"" class=""form-control"" required");
                    WriteLiteral(@"=""required"" placeholder="""">
                                <h5>Data de expiração</h5>
                                <input type=""date"" class=""form-control"" required=""required"" placeholder="""">
                                <h5>Número de segurança</h5>
                                <input type=""text"" class=""form-control"" required=""required"" placeholder="""">
                                <input type=""checkbox"" formaction=""mailto:magdaamaral2014@yahoo.com.br"" name=""checkbox"" value=""Sim""> Eu aceito os termos e condições da venda <br>
                                <hr>
                                <h5>TOTAL</h5>
                                <hr>
                                <p>
                                    Produto = R$ 0,00 <br>
                                    Envio = R$ 0,00 <br>
                                    Total = R$ 0,00  <br>
                                </p>
                                <input type=""submit"" value=""Continuar"">
                          ");
                    WriteLiteral("  ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2666, 140, true);
                WriteLiteral("\r\n\r\n                            <br>\r\n\r\n                        </div>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2813, 119, true);
            WriteLiteral("\r\n            <input type=\"submit\" value=\"Voltar para compras\">\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n        </div>");
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
