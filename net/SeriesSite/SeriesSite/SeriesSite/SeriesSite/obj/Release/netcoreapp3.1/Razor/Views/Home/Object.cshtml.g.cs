#pragma checksum "C:\Users\Lera\Desktop\University\Study\8\PSP\net\SeriesSite\SeriesSite\SeriesSite\SeriesSite\Views\Home\Object.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9103220abf21bc44f0a9f2f286c8788d4af6d2ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Object), @"mvc.1.0.view", @"/Views/Home/Object.cshtml")]
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
#line 1 "C:\Users\Lera\Desktop\University\Study\8\PSP\net\SeriesSite\SeriesSite\SeriesSite\SeriesSite\Views\_ViewImports.cshtml"
using SeriesSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lera\Desktop\University\Study\8\PSP\net\SeriesSite\SeriesSite\SeriesSite\SeriesSite\Views\_ViewImports.cshtml"
using SeriesSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9103220abf21bc44f0a9f2f286c8788d4af6d2ed", @"/Views/Home/Object.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"016f208705c25b754594b189f267fbf03eb0801d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Object : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style-other.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Lera\Desktop\University\Study\8\PSP\net\SeriesSite\SeriesSite\SeriesSite\SeriesSite\Views\Home\Object.cshtml"
  
    ViewBag.Title = "About-Serial";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9103220abf21bc44f0a9f2f286c8788d4af6d2ed4202", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"series\">\r\n    <div class=\"container\">\r\n        <div class=\"container-general\">\r\n            <div class=\"image__wrapper\">\r\n                <img");
            BeginWriteAttribute("src", " src=", 258, "", 285, 1);
#nullable restore
#line 11 "C:\Users\Lera\Desktop\University\Study\8\PSP\net\SeriesSite\SeriesSite\SeriesSite\SeriesSite\Views\Home\Object.cshtml"
WriteAttributeValue("", 263, ViewBag.ListImages[0], 263, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"poster\" width=\"500\" height=\"700\"/>\r\n            </div>\r\n            <h1>");
#nullable restore
#line 13 "C:\Users\Lera\Desktop\University\Study\8\PSP\net\SeriesSite\SeriesSite\SeriesSite\SeriesSite\Views\Home\Object.cshtml"
           Write(ViewBag.Serial[0].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <p class=\"originalname\">");
#nullable restore
#line 14 "C:\Users\Lera\Desktop\University\Study\8\PSP\net\SeriesSite\SeriesSite\SeriesSite\SeriesSite\Views\Home\Object.cshtml"
                               Write(ViewBag.Serial[0].OriginalName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <table cellspacing=\"10\" width=\"470\">\r\n                <tr><td><b>Год выхода:</b></td><td>");
#nullable restore
#line 16 "C:\Users\Lera\Desktop\University\Study\8\PSP\net\SeriesSite\SeriesSite\SeriesSite\SeriesSite\Views\Home\Object.cshtml"
                                              Write(ViewBag.Serial[0].Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td><b>Страна:</b></td><td>");
#nullable restore
#line 17 "C:\Users\Lera\Desktop\University\Study\8\PSP\net\SeriesSite\SeriesSite\SeriesSite\SeriesSite\Views\Home\Object.cshtml"
                                          Write(ViewBag.Serial[0].Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td><b>Жанр:</b></td><td>");
#nullable restore
#line 18 "C:\Users\Lera\Desktop\University\Study\8\PSP\net\SeriesSite\SeriesSite\SeriesSite\SeriesSite\Views\Home\Object.cshtml"
                                        Write(ViewBag.Serial[0].Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td><b>Режиссер:</b></td><td>");
#nullable restore
#line 19 "C:\Users\Lera\Desktop\University\Study\8\PSP\net\SeriesSite\SeriesSite\SeriesSite\SeriesSite\Views\Home\Object.cshtml"
                                            Write(ViewBag.Serial[0].Producer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td><b>Бюджет:</b></td><td>");
#nullable restore
#line 20 "C:\Users\Lera\Desktop\University\Study\8\PSP\net\SeriesSite\SeriesSite\SeriesSite\SeriesSite\Views\Home\Object.cshtml"
                                          Write(ViewBag.Serial[0].Budget);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td><b>Премьера в мире:</b></td><td>");
#nullable restore
#line 21 "C:\Users\Lera\Desktop\University\Study\8\PSP\net\SeriesSite\SeriesSite\SeriesSite\SeriesSite\Views\Home\Object.cshtml"
                                                   Write(ViewBag.Serial[0].Premiere);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td><b>Возраст:</b></td><td>");
#nullable restore
#line 22 "C:\Users\Lera\Desktop\University\Study\8\PSP\net\SeriesSite\SeriesSite\SeriesSite\SeriesSite\Views\Home\Object.cshtml"
                                           Write(ViewBag.Serial[0].Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td><b>Длительность серии:</b></td><td>");
#nullable restore
#line 23 "C:\Users\Lera\Desktop\University\Study\8\PSP\net\SeriesSite\SeriesSite\SeriesSite\SeriesSite\Views\Home\Object.cshtml"
                                                      Write(ViewBag.Serial[0].Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td><b>Общее время:</b></td><td>");
#nullable restore
#line 24 "C:\Users\Lera\Desktop\University\Study\8\PSP\net\SeriesSite\SeriesSite\SeriesSite\SeriesSite\Views\Home\Object.cshtml"
                                               Write(ViewBag.Serial[0].TotalTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td><b>Рейтинг:</b></td><td>");
#nullable restore
#line 25 "C:\Users\Lera\Desktop\University\Study\8\PSP\net\SeriesSite\SeriesSite\SeriesSite\SeriesSite\Views\Home\Object.cshtml"
                                           Write(ViewBag.Serial[0].Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n            </table>\r\n        </div>\r\n        <div class=\"container-descr\">\r\n            <h2>Описание</h2>\r\n            <p>");
#nullable restore
#line 30 "C:\Users\Lera\Desktop\University\Study\8\PSP\net\SeriesSite\SeriesSite\SeriesSite\SeriesSite\Views\Home\Object.cshtml"
          Write(ViewBag.Serial[0].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
