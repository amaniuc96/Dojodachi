#pragma checksum "C:\Users\amani\Desktop\codingdojo\csharp_stack\ASPCoreII\Dojodachi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77e6532b03a9083d99203e092a33a8b1c6dcceac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\amani\Desktop\codingdojo\csharp_stack\ASPCoreII\Dojodachi\Views\_ViewImports.cshtml"
using Dojodachi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amani\Desktop\codingdojo\csharp_stack\ASPCoreII\Dojodachi\Views\_ViewImports.cshtml"
using Dojodachi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77e6532b03a9083d99203e092a33a8b1c6dcceac", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f823666e3659d58cebeb316cce4284db07d26c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77e6532b03a9083d99203e092a33a8b1c6dcceac3283", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Dojodachi</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77e6532b03a9083d99203e092a33a8b1c6dcceac4460", async() => {
                WriteLiteral(@"
    <div class=""text-center"">
        <nav class=""navbar navbar-expand-sm navbar-toggleable-sm navbar-light border-bottom box-shadow mb-3"" style=""background-color: #F3F3F3; margin: 5px;"">
            <div class=""container"">
                <h5>Fullness: ");
#nullable restore
#line 13 "C:\Users\amani\Desktop\codingdojo\csharp_stack\ASPCoreII\Dojodachi\Views\Home\Index.cshtml"
                         Write(TempData["Fullness"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                \r\n                <h5>Happniess: ");
#nullable restore
#line 15 "C:\Users\amani\Desktop\codingdojo\csharp_stack\ASPCoreII\Dojodachi\Views\Home\Index.cshtml"
                          Write(TempData["Happiness"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n\r\n                <h5>Meals: ");
#nullable restore
#line 17 "C:\Users\amani\Desktop\codingdojo\csharp_stack\ASPCoreII\Dojodachi\Views\Home\Index.cshtml"
                      Write(TempData["Meal"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n\r\n                <h5>Energy: ");
#nullable restore
#line 19 "C:\Users\amani\Desktop\codingdojo\csharp_stack\ASPCoreII\Dojodachi\Views\Home\Index.cshtml"
                       Write(TempData["Energy"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n            </div>\r\n        </nav>\r\n        <div>\r\n            <p>");
#nullable restore
#line 23 "C:\Users\amani\Desktop\codingdojo\csharp_stack\ASPCoreII\Dojodachi\Views\Home\Index.cshtml"
          Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <img");
                BeginWriteAttribute("src", " src=\"", 833, "\"", 867, 1);
#nullable restore
#line 24 "C:\Users\amani\Desktop\codingdojo\csharp_stack\ASPCoreII\Dojodachi\Views\Home\Index.cshtml"
WriteAttributeValue("", 839, Url.Content(ViewBag.ImgUrl), 839, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 868, "\"", 874, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"max-height: 40vh; border: 2px solid gray;\">\r\n        </div>\r\n\r\n");
#nullable restore
#line 27 "C:\Users\amani\Desktop\codingdojo\csharp_stack\ASPCoreII\Dojodachi\Views\Home\Index.cshtml"
          
            if((string)TempData["GameStatus"] == "Playing")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div style=""margin-top: 10px;"">
                    <a href=""feed"" class=""btn btn-sm btn-success"">Feed</a>
                    <a href=""play"" class=""btn btn-sm btn-warning"">Play</a>
                    <a href=""work"" class=""btn btn-sm btn-danger"">Work</a>
                    <a href=""sleep""class=""btn btn-sm btn-info"">Sleep</a>
                </div>
");
#nullable restore
#line 36 "C:\Users\amani\Desktop\codingdojo\csharp_stack\ASPCoreII\Dojodachi\Views\Home\Index.cshtml"
            }
            else if((string)TempData["GameStatus"] == "Over")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <a href=\"reset\" id=\"resetButton\" class=\"btn btn-dark\">Reset</a>\r\n");
#nullable restore
#line 40 "C:\Users\amani\Desktop\codingdojo\csharp_stack\ASPCoreII\Dojodachi\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
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
            WriteLiteral("\r\n</html>");
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
