#pragma checksum "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a62dddb7fa78f0bbd6549fcdd28804ca5be5c45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feed_Index), @"mvc.1.0.view", @"/Views/Feed/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\dev\Desktop\Medina\InstaDev\Views\_ViewImports.cshtml"
using InstaDev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dev\Desktop\Medina\InstaDev\Views\_ViewImports.cshtml"
using InstaDev.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a62dddb7fa78f0bbd6549fcdd28804ca5be5c45", @"/Views/Feed/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e21b0f649ba389abf6f454a8c2b6a61dd9d6b1f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Feed_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imagem_story"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("usuario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Usuario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("postar_foto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("user_post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imagem_post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imagem_usuario_aside"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml"
  
    ViewData["Title"] = "Feed";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"posicionando_aside\">\r\n    <div class=\"feed_main\">\r\n        <div class=\"container_feed\">\r\n            <section class=\"perfis\">\r\n                <div class=\"container_perfis\">\r\n\r\n");
#nullable restore
#line 23 "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml"
                      
                        int cont = 0;
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml"
                     foreach (var item in ViewBag.usuarios)
                    {
                        if (cont < 7 && item.NomeUsuario != ViewBag.UserName)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"container_perfis_colunas\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2a62dddb7fa78f0bbd6549fcdd28804ca5be5c458023", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1240, "~/img/", 1240, 6, true);
#nullable restore
#line 31 "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml"
AddHtmlAttributeValue("", 1246, item.FotoPerfil, 1246, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <p class=\"nome_usuario_story\">");
#nullable restore
#line 32 "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml"
                                                         Write(item.NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>     \r\n");
#nullable restore
#line 34 "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml"
                            cont++;
                        }else if (cont >= 7)
                        {
                            break;
                        }
                        else
                        {
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    \r\n\r\n                </div>\r\n            </section>\r\n\r\n            <section class=\"feed_postar\">\r\n                <div class=\"container_postar\">\r\n                    <div class=\"titulo_post\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2a62dddb7fa78f0bbd6549fcdd28804ca5be5c4510738", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1934, "~/img/", 1934, 6, true);
#nullable restore
#line 52 "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml"
AddHtmlAttributeValue("", 1940, ViewBag.ImagemUsuario, 1940, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <p>Postar</p>\r\n                    </div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a62dddb7fa78f0bbd6549fcdd28804ca5be5c4512382", async() => {
                WriteLiteral(@"
                        <input class=""descricao_post"" type=""text"" name=""Descricao"" placeholder=""Digite a descrição da imagem..."">
                        <label class=""upload_imagem"" for='escolha_imagem'>Escolha a imagem</label>
                        <input id=""escolha_imagem"" type=""file"" name=""Imagem"">
                        <button class=""feed_btn_postar"" type=""submit"">Postar</button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 55 "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml"
AddHtmlAttributeValue("", 2115, Url.Action("Postar"), 2115, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </section>\r\n\r\n");
#nullable restore
#line 64 "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml"
             foreach (var item in ViewBag.Posts)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <section class=\"post\">\r\n                    <div class=\"header_post\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2a62dddb7fa78f0bbd6549fcdd28804ca5be5c4515281", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2850, "~/img/", 2850, 6, true);
#nullable restore
#line 68 "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml"
AddHtmlAttributeValue("", 2856, item.ImagemUsuario, 2856, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <div class=\"header_post_textos\">\r\n                            <p class=\"nome_usuario\">");
#nullable restore
#line 70 "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml"
                                               Write(item.NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"localizacao_usuario\">Flamengo, RJ</p>\r\n                        </div>\r\n                    </div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2a62dddb7fa78f0bbd6549fcdd28804ca5be5c4517449", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3213, "~/img/Posts/", 3213, 12, true);
#nullable restore
#line 74 "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml"
AddHtmlAttributeValue("", 3225, item.Imagem, 3225, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                    <div class=""comentario"">
                        <div class=""interacao_post"">
                            <i class=""far fa-heart logos_comentario""></i>
                            <i class=""far fa-comment logos_comentario""></i>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a62dddb7fa78f0bbd6549fcdd28804ca5be5c4519371", async() => {
                WriteLiteral("\r\n                                <input class=\"input_comentar\" type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 3615, "\"", 3622, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Comentar...\">\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <span class=\"curtidas\">2700 curtidas</span>\r\n                        <p class=\"mensagem_comentario\"> <span class=\"usuario_comentario\">");
#nullable restore
#line 86 "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml"
                                                                                    Write(item.NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> ");
#nullable restore
#line 86 "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml"
                                                                                                             Write(item.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                        <p class=""mensagem_comentario""> <span class=""usuario_comentario"">yes_baby</span> thank you</p>
                        <p class=""mensagem_comentario""> <span class=""usuario_comentario"">king_pele</span> Esses são bons de
                            bola, entende? </p>
                    </div>
                </section>
");
#nullable restore
#line 92 "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <aside class=\"aside_feed\">\r\n        <div class=\"container_aside\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2a62dddb7fa78f0bbd6549fcdd28804ca5be5c4522383", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4449, "~/img/", 4449, 6, true);
#nullable restore
#line 100 "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml"
AddHtmlAttributeValue("", 4455, ViewBag.ImagemUsuario, 4455, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"textos_aside\">\r\n                <p class=\"usuario_aside\">");
#nullable restore
#line 102 "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml"
                                    Write(ViewBag.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"nome_usuario_aside\">");
#nullable restore
#line 103 "C:\Users\dev\Desktop\Medina\InstaDev\Views\Feed\Index.cshtml"
                                         Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </aside>\r\n</div>");
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
