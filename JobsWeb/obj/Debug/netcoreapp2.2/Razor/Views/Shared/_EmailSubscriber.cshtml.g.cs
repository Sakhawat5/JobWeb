#pragma checksum "C:\Eninas\wetransfer-a9bd10\JobsWeb\JobsWeb\Views\Shared\_EmailSubscriber.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03f718f3819902b3ee0ac69ade6de5cdceb87cde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__EmailSubscriber), @"mvc.1.0.view", @"/Views/Shared/_EmailSubscriber.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_EmailSubscriber.cshtml", typeof(AspNetCore.Views_Shared__EmailSubscriber))]
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
#line 1 "C:\Eninas\wetransfer-a9bd10\JobsWeb\JobsWeb\Views\_ViewImports.cshtml"
using JobsWeb;

#line default
#line hidden
#line 2 "C:\Eninas\wetransfer-a9bd10\JobsWeb\JobsWeb\Views\_ViewImports.cshtml"
using JobsWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03f718f3819902b3ee0ac69ade6de5cdceb87cde", @"/Views/Shared/_EmailSubscriber.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a23fbbf7517e66a8f5ffec8eb814e0f737f6155", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__EmailSubscriber : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("newsletter-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("validator"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 219, true);
            WriteLiteral("\r\n\r\n    <!-- Subscribe Form -->\r\n   \r\n        <div class=\"section-title\">\r\n            <h2>Subscribe Newsletter</h2>\r\n        </div>\r\n\r\n\r\n  \r\n    <!-- End Subscribe Form -->\r\n\r\n    <div class=\"subscribe-item\">\r\n        ");
            EndContext();
            BeginContext(219, 435, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03f718f3819902b3ee0ac69ade6de5cdceb87cde4329", async() => {
                BeginContext(273, 374, true);
                WriteLiteral(@"

            <input type=""email"" class=""form-control"" placeholder=""Enter Your Email"" name=""EMAIL"" required="""" autocomplete=""off"">
            <button class=""btn subscribe-btn "" type=""submit"" style=""pointer-events: all; cursor: pointer;"">
                Subscribe
            </button>
            <div id=""validator-newsletter"" class=""form-result""></div>

        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(654, 2258, true);
            WriteLiteral(@"
       
   




    </div>


    <style>
        .section-title {
    text-align: center;
    margin-bottom: 40px;
    margin-top: -10px;
}
        .subscribe-item{
            max-width: 660px;
            margin-left: auto;
            margin-right: auto;
        }
          .subscribe-item .newsletter-form .subscribe-btn {
            color: #ffffff;
            background-color: #cb202d;
            font-size: 16px;
            // background: -webkit-gradient(linear, left top, right top, from(#38a745), color-stop(63%, #4cce5b));
            //background: linear-gradient(90deg, #38a745 0%, #4cce5b 63%);
            padding: 15px 30px;
            position: absolute;
            right: 0;
            top: 0;
            border-radius: 0;
        }
        .subscribe-item .newsletter-form {
            position: relative;
        }

        .subscribe-item .newsletter-form .form-control {
            border: 1px solid #cb202d;
            //border-image-source: linear-");
            WriteLiteral(@"gradient(90deg, #38a745 0%, #4cce5b 63%);
            border-image-slice: 1;
            height: 55px;
            font-size: 16px;
            padding-left: 25px;
}


        .form-control {
            display: block;
            width: 100%;
            //height: calc(1.5em + .75rem + 2px);
            padding: .375rem .75rem;
            // font-size: 1rem;
            font-weight: 400;
            line-height: 1.5;
            color: #495057;
            background-color: #fff;
            background-clip: padding-box;
            // border: 1px solid #ced4da;
            border-radius: .25rem;
            transition: border-color .15s ease-in-out,box-shadow .15s ease-in-out;
        }
      
        .aqeel{
            button{
                        color: #ffffff;
            background-color: #cb202d;
            font-size: 16px;
            // background: -webkit-gradient(linear, left top, right top, from(#38a745), color-stop(63%, #4cce5b));
            //background: li");
            WriteLiteral("near-gradient(90deg, #38a745 0%, #4cce5b 63%);\r\n            padding: 15px 30px;\r\n                  }\r\n        }\r\n\r\n      \r\n        button:hover {\r\n            background-color: #d94148;\r\n        }\r\n    </style>");
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
